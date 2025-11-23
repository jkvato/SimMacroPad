using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hds.MacroLink;

/// <summary>
/// Abstraction over something that can send and receive framed MacroLink messages.
/// </summary>
public interface IMacroLinkTransport : IAsyncDisposable
{
   /// <summary>
   /// Raised when a valid frame is received from the underlying transport.
   /// </summary>
   event EventHandler<MacroLinkFrame>? FrameReceived;

   /// <summary>
   /// Raised when an exception occurs in the receive loop.
   /// </summary>
   event EventHandler<Exception>? ReceiveError;

   /// <summary>
   /// Raised when the underlying connection is opened (true) or closed (false).
   /// </summary>
   event EventHandler<bool>? ConnectionStateChanged;

   /// <summary>
   /// Opens the underlying transport and starts receiving frames.
   /// </summary>
   Task OpenAsync(CancellationToken cancellationToken = default);

   /// <summary>
   /// Closes the underlying transport and stops receiving frames.
   /// </summary>
   Task CloseAsync(CancellationToken cancellationToken = default);

   /// <summary>
   /// Sends a single framed message.
   /// </summary>
   Task SendAsync(MacroLinkFrame frame, CancellationToken cancellationToken = default);
}
