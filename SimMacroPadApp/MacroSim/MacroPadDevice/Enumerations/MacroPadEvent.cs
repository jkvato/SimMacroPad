using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.MacroPadDevice.Enumerations;

public enum MacroPadEvent : byte
{
   Clicked = 0,
   DoubleClicked = 1,
   LongPressed = 2,
   RepeatPressed = 3,
   Increment = 4,
   Decrement = 5
}
