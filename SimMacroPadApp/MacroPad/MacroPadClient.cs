using System;
using System.Threading;
using System.Threading.Tasks;
using Hds.MacroLink;

namespace Hds.MacroPad;

/// <summary>
/// High-level client for talking to a MacroPad device over an IMacroLinkTransport.
/// </summary>
public sealed class MacroPadClient : IAsyncDisposable
{
   private const byte MsgTypeSimDisplay = 0x01;
   private const byte MsgTypePadInput = 0x81;

   private readonly IMacroLinkTransport _transport;

   /// <summary>
   /// Raised when a 1-byte input event is received from the MacroPad.
   /// </summary>
   public event EventHandler<byte>? PadInputEventReceived;

   public MacroPadClient(IMacroLinkTransport transport)
   {
      _transport = transport ?? throw new ArgumentNullException(nameof(transport));
      _transport.FrameReceived += OnFrameReceived;
   }

   public Task OpenAsync(CancellationToken ct = default)
       => _transport.OpenAsync(ct);

   public Task CloseAsync(CancellationToken ct = default)
       => _transport.CloseAsync(ct);

   public async ValueTask DisposeAsync()
   {
      await _transport.DisposeAsync().ConfigureAwait(false);
   }

   private void OnFrameReceived(object? sender, MacroLinkFrame frame)
   {
      if (frame.MessageType == MsgTypePadInput && frame.Payload.Length == 1)
      {
         PadInputEventReceived?.Invoke(this, frame.Payload[0]);
      }
      // Unknown message types are ignored by default.
   }

   /// <summary>
   /// Sends a SimMessage to the MacroPad.
   /// </summary>
   public Task SendSimMessageAsync(SimMessage message, CancellationToken ct = default)
   {
      if (message is null) throw new ArgumentNullException(nameof(message));

      var (state, text1, text2) = message.ToWire();
      var payload = new byte[1 + 10 + 10];

      payload[0] = state;
      Buffer.BlockCopy(text1, 0, payload, 1, 10);
      Buffer.BlockCopy(text2, 0, payload, 11, 10);

      var frame = new MacroLinkFrame(MsgTypeSimDisplay, payload);
      return _transport.SendAsync(frame, ct);
   }
}
