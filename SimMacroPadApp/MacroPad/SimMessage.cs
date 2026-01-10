using System;
using System.Text;

namespace Hds.MacroPad;

/// <summary>
/// Message sent from MacroSim (PC) to MacroPad (device).
/// Encoded as:
///   MsgType = 0x01
///   Payload:
///     [0]     : state (MacroPadState)
///     [1..10] : Text1 (10 ASCII chars)
///     [11..20]: Text2 (10 ASCII chars)
/// </summary>
public sealed class SimMessage
{
   private const int TextLength = 10;

   public MacroPadState MacroPadState { get; set; }

   public string Text1 { get; set; } = string.Empty;
   public string Text2 { get; set; } = string.Empty;

   /// <summary>
   /// Converts this SimMessage into the wire format (state + 10 bytes text1 + 10 bytes text2).
   /// </summary>
   public (byte state, byte[] text1Bytes, byte[] text2Bytes) ToWire()
   {
      byte state = (byte)MacroPadState;
      byte[] text1 = Normalize(Text1);
      byte[] text2 = Normalize(Text2);
      return (state, text1, text2);
   }

   private static byte[] Normalize(string s)
   {
      // Ensure ASCII, padded/truncated to TextLength
      Span<byte> bytes = stackalloc byte[TextLength];
      int i = 0;

      foreach (char c in s)
      {
         if (i >= TextLength)
            break;

         char ch = c <= 0x7F ? c : '?';
         bytes[i++] = (byte)ch;
      }

      for (; i < TextLength; i++)
      {
         bytes[i] = (byte)' ';
      }

      return bytes.ToArray();
   }

   public override string ToString()
       => $"{MacroPadState}: '{Text1}' / '{Text2}'";
}
