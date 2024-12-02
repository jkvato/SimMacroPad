using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimAircraft;

internal class SimAircraft
{
   public string Title { get; set; }
   public bool HasPanelLight { get; set; }
   public bool HasPedestralLight { get; set; }
   public bool HasCabinLight { get; set; }
   public bool HasTaxiLight { get; set; }
   public bool HasLandingLight { get; set; }
   public bool HasStrobeLight { get; set; }
   public bool HasNavLight { get; set; }
   public bool HasWinLight { get; set; }
   public bool HasBeaconLight { get; set; }
   public bool HasGlareshieldLight { get; set; }
   public bool HasLogoLight { get; set; }
   public bool HasRecognitionLight { get; set; }

   public SimAircraft()
   {
      Title = string.Empty;
   }
}
