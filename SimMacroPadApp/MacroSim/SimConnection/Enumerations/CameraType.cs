using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum CameraType : int
{
   Undefined = 0,
   CockpitPilot = 1,
   CockpitInstrument = 2,
   CockpitQuickView = 3,
   CockpitSmartcam = 4,
   ExternalDefault = 5,
   ExternalQuickView = 6,
   ExternalSmartcam = 7,
   ShowcaseFree = 8,
   ShowcaseFixed = 9,
   ShowcaseSmartcam = 10,
   Custom = 11,
}
