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
   /// Number of characters of the <see cref="Text"/> property that will
   /// be transmitted in the message, not including the terminating zero.
   /// </summary>
   private const int TextLength = 10;

   public MacroPadState MacroPadState { get; set; }

   public string Text { get; set; }

   public SimMessage()
      : this(MacroPadState.None, string.Empty)
   {
   }

   public SimMessage(MacroPadState macroPadState, string text)
   {
      MacroPadState = macroPadState;
      Text = text;
   }

   /// <summary>
   /// Sends the message through the specified <see cref="SerialPort"/>.
   /// </summary>
   /// <param name="port">The <see cref="SerialPort"/> to use.</param>
   public void Send(SerialPort port)
   {
      // Convert the properties to ASCII bytes
      byte stateByte = (byte)MacroPadState;
      byte[] textBytes = Encoding.ASCII.GetBytes(Text);

      // Create the message buffer and fill with zeroes
      byte[] buffer = new byte[14];
      for (int i = 0; i < buffer.Length; i++)
         buffer[i] = 0;

      // Compose the message as a byte array
      // ASCII Start of Heading
      buffer[0] = (byte)AsciiCode.SOH;

      // MacroPadState as a byte
      buffer[1] = stateByte;

      // Text, truncated if necessary
      for (int i = 0; i < Math.Min(TextLength, textBytes.Length); i++)
      {
         buffer[2 + i] = textBytes[i];
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
   Text = 2,
   PreEOT = 3,
}