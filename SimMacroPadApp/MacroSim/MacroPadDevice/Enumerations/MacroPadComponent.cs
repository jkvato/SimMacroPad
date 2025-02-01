using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.MacroPadDevice.Enumerations;

public enum MacroPadComponent : byte
{
   Rotary = 0,
   COM1 = 1,
   COM2 = 2,
   BAR = 3,
   NAV = 4,
   HDG_CRS = 5,
   ALT_VS = 6,
   AV1 = 7,
   AV2 = 8,
   SPD_MCH = 9,
   AV3 = 10,
   AV4 = 11,
   XPND = 12
}

//public enum MacroPadComponent : byte
//{
//   Rotary = 0,
//   COM1 = 1,
//   COM2 = 2,
//   BAR = 3,
//   NAV1 = 4,
//   NAV2 = 5,
//   PFD = 6,
//   HDG = 7,
//   CRS = 8,
//   MFD = 9,
//   ALT = 10,
//   VS = 11,
//   XPND = 12
//}
