using MacroSim.Ascii;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.MacroPadDevice;

internal class SimMessage
{
   /// <summary>
   /// Number of characters of the <see cref="Text1"/> property that will
   /// be transmitted in the message, not including the terminating zero.
   /// </summary>
   private const int TextLength = 10;

   public MacroPadState MacroPadState { get; set; }

   public string Text1 { get; set; }
   public string Text2 { get; set; }

   public SimMessage()
      : this(MacroPadState.None, string.Empty, string.Empty)
   {
   }

   public SimMessage(MacroPadState macroPadState, string text1, string text2)
   {
      MacroPadState = macroPadState;
      Text1 = text1;
      Text2 = text2;
   }

   /// <summary>
   /// Sends the message through the specified <see cref="SerialPort"/>.
   /// </summary>
   /// <param name="port">The <see cref="SerialPort"/> to use.</param>
   public void Send(SerialPort port)
   {
      // Convert the properties to ASCII bytes
      byte stateByte = (byte)MacroPadState;
      byte[] text1Bytes = Encoding.ASCII.GetBytes(Text1);
      byte[] text2Bytes = Encoding.ASCII.GetBytes(Text2);

      // Create the message buffer and fill with zeroes
      byte[] buffer = new byte[25];
      for (int i = 0; i < buffer.Length; i++)
         buffer[i] = 0;

      // Compose the message as a byte array
      // ASCII Start of Heading
      buffer[0] = (byte)AsciiCode.SOH;

      // MacroPadState as a byte
      buffer[1] = stateByte;

      // Text1, truncated if necessary
      for (int i = 0; i < Math.Min(TextLength, text1Bytes.Length); i++)
      {
         buffer[2 + i] = text1Bytes[i];
      }

      // Text2, truncated if necessary
      for (int i = 0; i < Math.Min(TextLength, text2Bytes.Length); i++)
      {
         buffer[13 + i] = text2Bytes[i];
      }

      // ASCII End of Transmission
      buffer[buffer.Length - 1] = (byte)AsciiCode.EOT;

      // Write the data to the serial port
      try
      {
         port.Write(buffer, 0, buffer.Length);
      }
      catch { }
   }
}

enum MessageState
{
   PreSOH = 0,
   State = 1,
   Text1 = 2,
   Text2 = 3,
   PreEOT = 4,
}

// 0 = SOH
// 1 = State
// 2-11 = Text1
// 12 = Text1 /0
// 13-22 = Text2
// 23 = Text2 /0
// 24 = EOT
