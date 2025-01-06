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

   public int MaxCamera0 { get; set; }
   public int MaxCamera1 { get; set; }
   public int MaxCamera2 { get; set; }
   public int MaxCamera3 { get; set; }
   public int MaxCamera4 { get; set; }
   public int MaxCamera5 { get; set; }
   public int MaxCamera6 { get; set; }
   public int MaxCamera7 { get; set; }
   public int MaxCamera8 { get; set; }
   public int MaxCamera9 { get; set; }

   public SimAircraft()
   {
      Title = string.Empty;
   }
}
