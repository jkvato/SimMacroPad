using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum SimDataRequest : uint
{
   AvionicsRequest,
   LightsRequest,
   TrimRequest,
   CamerasRequest,
   TimeRequest,
   EngineRequest,
   SmartcamTargetsRequest,
}
