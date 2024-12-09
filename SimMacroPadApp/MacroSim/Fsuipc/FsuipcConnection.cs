using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.Fsuipc;

internal class FsuipcConnection
{
   public Offset<ushort> com1ActiveFrequency = new Offset<ushort>(0x034E);
   public Offset<ushort> nav1ActiveFrequency = new Offset<ushort>(0x0350);
   public Offset<ushort> nav2ActiveFrequency = new Offset<ushort>(0x0352);
   public Offset<ushort> transponderCode = new Offset<ushort>(0x0354);

   public Offset<uint> comActiveFrequency1 = new Offset<uint>(0x05C4);
   public Offset<uint> comActiveFrequency2 = new Offset<uint>(0x05C8);
   public Offset<uint> comStandbyFrequency1 = new Offset<uint>(0x05CC);
   public Offset<uint> comStandbyFrequency2 = new Offset<uint>(0x05D0);


   public bool ConnectToSim()
   {
      try
      {
         FSUIPCConnection.Open();
      }
      catch
      {
      }

      if (FSUIPCConnection.IsOpen)
      {
         return true;
      }
      return false;
   }

   public bool IsConnected => FSUIPCConnection.IsOpen;

   public void DisconnectFromSim()
   {
      FSUIPCConnection.Close();
   }

   public void Process(string? groupName = null)
   {
      if (FSUIPCConnection.IsOpen)
      {
         if (groupName == null)
            FSUIPCConnection.Process();
         else
            FSUIPCConnection.Process(groupName);
      }
   }

   public static double IntToFrequency(uint value)
   {
      double result = value / 1000000d;
      return result;
   }


}
