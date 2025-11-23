namespace Hds.MacroLink;

/// <summary>
/// Represents a single decoded frame from the MacroLink protocol.
/// </summary>
public sealed class MacroLinkFrame
{
   public byte MessageType { get; }
   public byte[] Payload { get; }

   public MacroLinkFrame(byte messageType, byte[] payload)
   {
      MessageType = messageType;
      Payload = payload ?? Array.Empty<byte>();
   }
}
