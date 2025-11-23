using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using Hds.MacroLink;

namespace Hds.MacroLink.Serial;

/// <summary>
/// SerialPort-based implementation of IMacroLinkTransport.
/// </summary>
public sealed class SerialMacroLinkTransport : IMacroLinkTransport
{
   private readonly string _portName;
   private readonly int _baudRate;

   private SerialPort? _port;
   private CancellationTokenSource? _cts;
   private Task? _readLoopTask;

   private readonly MacroLinkDecoder _decoder = new();

   public event EventHandler<MacroLinkFrame>? FrameReceived;
   public event EventHandler<Exception>? ReceiveError;
   public event EventHandler<bool>? ConnectionStateChanged;

   public SerialMacroLinkTransport(string portName, int baudRate = 115200)
   {
      _portName = portName;
      _baudRate = baudRate;

      _decoder.FrameDecoded += (s, frame) =>
      {
         FrameReceived?.Invoke(this, frame);
      };
   }

   public Task OpenAsync(CancellationToken cancellationToken = default)
   {
      if (_port is { IsOpen: true })
         return Task.CompletedTask;

      _port = new SerialPort(_portName, _baudRate, Parity.None, 8, StopBits.One)
      {
         ReadTimeout = -1,
         WriteTimeout = -1
      };

      _port.Open();

      _cts = new CancellationTokenSource();
      _readLoopTask = Task.Run(() => ReadLoopAsync(_cts.Token), cancellationToken);

      ConnectionStateChanged?.Invoke(this, true);
      return Task.CompletedTask;
   }

   public async Task CloseAsync(CancellationToken cancellationToken = default)
   {
      if (_port is not { IsOpen: true })
         return;

      _cts?.Cancel();
      if (_readLoopTask is not null)
      {
         try
         {
            await _readLoopTask.ConfigureAwait(false);
         }
         catch
         {
            // Swallow cancellation exceptions
         }
      }

      _port.Close();
      ConnectionStateChanged?.Invoke(this, false);
   }

   public async ValueTask DisposeAsync()
   {
      await CloseAsync().ConfigureAwait(false);
      _port?.Dispose();
   }

   public Task SendAsync(MacroLinkFrame frame, CancellationToken cancellationToken = default)
   {
      if (_port is not { IsOpen: true })
         throw new InvalidOperationException("Serial port is not open.");

      var payload = frame.Payload ?? Array.Empty<byte>();
      byte length = (byte)payload.Length;
      byte msgType = frame.MessageType;
      byte checksum = MacroLinkDecoder.CalcChecksum(msgType, length, payload);

      // 1 (SOF) + 1 (MsgType) + 1 (Length) + payload + 1 (Checksum)
      var buffer = new byte[1 + 1 + 1 + payload.Length + 1];
      int i = 0;
      buffer[i++] = 0x7E;
      buffer[i++] = msgType;
      buffer[i++] = length;
      Buffer.BlockCopy(payload, 0, buffer, i, payload.Length);
      i += payload.Length;
      buffer[i] = checksum;

      _port.BaseStream.Write(buffer, 0, buffer.Length);
      return Task.CompletedTask;
   }

   private async Task ReadLoopAsync(CancellationToken token)
   {
      if (_port is null)
         return;

      var stream = _port.BaseStream;
      var buffer = new byte[1];

      while (!token.IsCancellationRequested)
      {
         try
         {
            int read = await stream.ReadAsync(buffer.AsMemory(0, 1), token).ConfigureAwait(false);
            if (read == 0)
               continue;

            _decoder.FeedByte(buffer[0]);
         }
         catch (OperationCanceledException) when (token.IsCancellationRequested)
         {
            break;
         }
         catch (Exception ex)
         {
            ReceiveError?.Invoke(this, ex);
            _decoder.Reset();
         }
      }
   }
}
