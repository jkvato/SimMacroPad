using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.MacroPadDevice.Enumerations;

public enum MacroPadState : byte
{
   None = 0b000000_00,
   COM1_MHZ = 0b000001_00,
   COM1_KHZ = 0b000001_01,
   COM2_MHZ = 0b000010_00,
   COM2_KHZ = 0b000010_01,
   NAV1_MHZ = 0b000011_00,
   NAV1_KHZ = 0b000011_01,
   NAV2_MHZ = 0b000100_00,
   NAV2_KHZ = 0b000100_01,
   HEADING = 0b000101_00,
   COURSE = 0b000110_00,
   ALTITUDE_1000 = 0b000111_00,
   ALTITUDE_100 = 0b000111_01,
   VERTICAL_SPEED = 0b001000_00,
   XPND_1000 = 0b001001_00,
   XPND_100 = 0b001001_01,
   XPND_10 = 0b001001_10,
   XPND_1 = 0b001001_11,
   GPS_GROUP = 0b001010_00,
   GPS_PAGE = 0b001010_01,
   PFD_GROUP = 0b001011_00,
   PFD_PAGE = 0b001011_01,
   MFD_GROUP = 0b001100_00,
   MFD_PAGE = 0b001100_01,
}
