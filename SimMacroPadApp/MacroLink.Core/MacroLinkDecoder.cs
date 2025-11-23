using System;

namespace Hds.MacroLink;

/// <summary>
/// Stateful decoder for the MacroLink framing protocol.
/// Feed bytes one at a time via <see cref="FeedByte"/>.
/// When a complete, valid frame is decoded, <see cref="FrameDecoded"/> is raised.
/// </summary>
public sealed class MacroLinkDecoder
{
   private const byte Sof = 0x7E;

   private enum State
   {
      WaitForSof,
      ReadMsgType,
      ReadLength,
      ReadPayload,
      ReadChecksum
   }

   private State _state = State.WaitForSof;
   private byte _msgType;
   private byte _length;
   private int _payloadIndex;
   private byte[] _payload = Array.Empty<byte>();

   public event EventHandler<MacroLinkFrame>? FrameDecoded;

   public void Reset()
   {
      _state = State.WaitForSof;
      _msgType = 0;
      _length = 0;
      _payloadIndex = 0;
      _payload = Array.Empty<byte>();
   }

   public void FeedByte(byte b)
   {
      switch (_state)
      {
         case State.WaitForSof:
            if (b == Sof)
            {
               _state = State.ReadMsgType;
            }
            break;

         case State.ReadMsgType:
            _msgType = b;
            _state = State.ReadLength;
            break;

         case State.ReadLength:
            _length = b;
            _payloadIndex = 0;
            _payload = _length > 0 ? new byte[_length] : Array.Empty<byte>();
            _state = _length == 0 ? State.ReadChecksum : State.ReadPayload;
            break;

         case State.ReadPayload:
            _payload[_payloadIndex++] = b;
            if (_payloadIndex >= _length)
            {
               _state = State.ReadChecksum;
            }
            break;

         case State.ReadChecksum:
            var checksum = b;
            if (VerifyChecksum(_msgType, _length, _payload, checksum))
            {
               FrameDecoded?.Invoke(this,
                   new MacroLinkFrame(_msgType, _payload));
            }

            // Regardless of checksum success, reset for next frame
            Reset();
            break;

         default:
            Reset();
            break;
      }
   }

   private static bool VerifyChecksum(byte msgType, byte length, byte[] payload, byte checksum)
   {
      int sum = msgType + length;
      for (int i = 0; i < payload.Length; i++)
      {
         sum += payload[i];
      }
      sum += checksum;
      return (sum & 0xFF) == 0;
   }

   public static byte CalcChecksum(byte msgType, byte length, byte[] payload)
   {
      int sum = msgType + length;
      for (int i = 0; i < payload.Length; i++)
      {
         sum += payload[i];
      }
      // Two's complement so sum + checksum == 0 (mod 256)
      return unchecked((byte)(-sum));
   }
}
