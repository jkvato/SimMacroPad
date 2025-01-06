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
   GPS = 3,
   NAV1 = 4,
   NAV2 = 5,
   PFD = 6,
   HDG = 7,
   CRS = 8,
   MFD = 9,
   ALT = 10,
   VS = 11,
   XPND = 12
}
