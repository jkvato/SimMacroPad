using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hds.MacroLink;
using Hds.MacroLink.Serial;

namespace Hds.MacroPad;

/// <summary>
/// Helper for discovering a connected MacroPad by scanning available serial ports.
/// Uses Ping (0xF0) / Identify (0xF1, "MACROPAD") messages over MacroLink.
/// </summary>
public static class MacroPadDiscovery
{
   private const byte MsgTypePing = 0xF0;
   private const byte MsgTypeIdentify = 0xF1;

   /// <summary>
   /// Scans all available serial ports, sends a Ping frame to each,
   /// and waits for an Identify response indicating a MacroPad.
   /// Returns the first matching port name, or null if none are found.
   /// </summary>
   /// <param name="perPortTimeout">
   /// How long to wait for a response from each port. Default is 500 ms.
   /// </param>
   /// <param name="cancellationToken">Cancellation token for the whole scan.</param>
   public static async Task<string?> AutoDetectPortAsync(
       TimeSpan? perPortTimeout = null,
       CancellationToken cancellationToken = default)
   {
      perPortTimeout ??= TimeSpan.FromMilliseconds(500);

      var ports = SerialPort.GetPortNames();
      foreach (var port in ports)
      {
         cancellationToken.ThrowIfCancellationRequested();

         bool isMacroPad = await ProbePortAsync(port, perPortTimeout.Value, cancellationToken)
             .ConfigureAwait(false);

         if (isMacroPad)
         {
            return port;
         }
      }

      return null;
   }

   private static async Task<bool> ProbePortAsync(
       string portName,
       TimeSpan timeout,
       CancellationToken cancellationToken)
   {
      await using var transport = new SerialMacroLinkTransport(portName, 115200);

      var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

      void Handler(object? sender, MacroLinkFrame frame)
      {
         if (frame.MessageType != MsgTypeIdentify)
            return;

         var payload = frame.Payload;
         if (payload.Length < 8)
            return;

         // Check for ASCII "MACROPAD" at the start of the payload
         if (payload[0] == (byte)'M' &&
             payload[1] == (byte)'A' &&
             payload[2] == (byte)'C' &&
             payload[3] == (byte)'R' &&
             payload[4] == (byte)'O' &&
             payload[5] == (byte)'P' &&
             payload[6] == (byte)'A' &&
             payload[7] == (byte)'D')
         {
            tcs.TrySetResult(true);
         }
      }

      transport.FrameReceived += Handler;

      try
      {
         await transport.OpenAsync(cancellationToken).ConfigureAwait(false);

         // Send Ping (no payload)
         var pingFrame = new MacroLinkFrame(MsgTypePing, Array.Empty<byte>());
         await transport.SendAsync(pingFrame, cancellationToken).ConfigureAwait(false);

         using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
         var delayTask = Task.Delay(timeout, cts.Token);

         var completed = await Task.WhenAny(tcs.Task, delayTask).ConfigureAwait(false);

         if (completed == tcs.Task && tcs.Task.Result)
         {
            // Found a MacroPad; cancel the delay to clean up
            cts.Cancel();
            return true;
         }

         return false;
      }
      catch
      {
         // Opening or probing failed; treat as "not a MacroPad"
         return false;
      }
      finally
      {
         transport.FrameReceived -= Handler;
         try
         {
            await transport.CloseAsync().ConfigureAwait(false);
         }
         catch
         {
            // Ignore close errors
         }
      }
   }
}
