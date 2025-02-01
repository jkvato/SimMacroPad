using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum EngineType : int
{
   Piston = 0,
   Jet = 1,
   None = 2,
   HeloTurbine = 3,
   Unsupported = 4,
   Turboprop = 5,
}
