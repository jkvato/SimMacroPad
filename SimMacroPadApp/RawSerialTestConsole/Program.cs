using System;
using System.IO.Ports;

class RawTest
{
   static void Main()
   {
      using var port = new SerialPort("COM4", 115200)
      {
         DtrEnable = true,   // <-- IMPORTANT
         RtsEnable = true    // <-- often needed too
      };

      port.DataReceived += (s, e) =>
      {
         var sp = (SerialPort)s!;
         int count = sp.BytesToRead;
         var buffer = new byte[count];
         sp.Read(buffer, 0, count);
         Console.WriteLine("Raw bytes: " + BitConverter.ToString(buffer));
      };

      port.Open();

      Console.WriteLine("Listening on COM4. Press ENTER to exit.");
      Console.ReadLine();
   }
}
