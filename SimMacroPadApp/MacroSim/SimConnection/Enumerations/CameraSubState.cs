using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum CameraSubState : int
{
   Locked = 1,
   Unlocked = 2,
   QuickView = 3,
   Smart = 4,
   Instrument = 5
}
