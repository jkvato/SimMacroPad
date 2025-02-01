using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimAircraft;

internal class SimAircraft
{
   public string Title { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has an AS530 device.
   /// </summary>
   public bool HasAS530 { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has an AS430 device.
   /// </summary>
   public bool HasAS430 { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has an AS1000 device.
   /// </summary>
   /// <remarks>Kodiak 100, Baron</remarks>
   public bool HasAS1000 { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has a G3X Touch device
   /// with one control panel.
   /// </summary>
   public bool HasG3X1x { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has a G3X Touch device
   /// with two control panels.
   /// </summary>
   public bool HasG3X2x { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has a G3X Touch device
   /// with three control panels.
   /// </summary>
   public bool HasG3X3x { get; set; }


   /// <summary>
   /// Gets or sets whether an aircraft has the AS3X Touch device
   /// portrait version with two screens.
   /// </summary>
   public bool HasAS3XPortrait2x { get; set; }

   /// <summary>
   /// Gets or sets whether an aircraft has a GTN650 device.
   /// </summary>
   public bool HasGTN650 { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has GPS device.
   /// </summary>
   public bool HasGPS { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the TBM G3000 device
   /// with one control panels.
   /// </summary>
   /// <remarks>Midnight</remarks>
   public bool HasAS3000Horiz1x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the TBM G3000 device
   /// with two control panels.
   /// </summary>
   /// <remarks>TBM 930</remarks>
   public bool HasAS3000Horiz2x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the TBM G3000 device
   /// with three control panels.
   /// </summary>
   /// <remarks>Vision Jet</remarks>
   public bool HasAS3000Horiz3x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the Longitude G3000 device
   /// with one control panel.
   /// </summary>
   /// <remarks>Joby</remarks>
   public bool HasAS3000Vert1x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the Longitude G3000 device
   /// with two control panels.
   /// </summary>
   /// <remarks>ES30</remarks>
   public bool HasAS3000Vert2x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the Longitude G3000 device
   /// with four control panels.
   /// </summary>
   /// <remarks>Longitude</remarks>
   public bool HasAS3000Vert4x { get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the Aera 760 device.
   /// </summary>
   public bool HasAera760 {  get; set; }

   /// <summary>
   /// Gets or sets whether the aircraft has the Aera 510 device.
   /// </summary>
   public bool HasAera510 { get; set; }

   //public bool HasPanelLight { get; set; }
   //public bool HasPedestralLight { get; set; }
   //public bool HasCabinLight { get; set; }
   //public bool HasTaxiLight { get; set; }
   //public bool HasLandingLight { get; set; }
   //public bool HasStrobeLight { get; set; }
   //public bool HasNavLight { get; set; }
   //public bool HasWinLight { get; set; }
   //public bool HasBeaconLight { get; set; }
   //public bool HasGlareshieldLight { get; set; }
   //public bool HasLogoLight { get; set; }
   //public bool HasRecognitionLight { get; set; }

   //public int MaxCamera0 { get; set; }
   //public int MaxCamera1 { get; set; }
   //public int MaxCamera2 { get; set; }
   //public int MaxCamera3 { get; set; }
   //public int MaxCamera4 { get; set; }
   //public int MaxCamera5 { get; set; }
   //public int MaxCamera6 { get; set; }
   //public int MaxCamera7 { get; set; }
   //public int MaxCamera8 { get; set; }
   //public int MaxCamera9 { get; set; }

   public SimAircraft()
      : this(string.Empty)
   {
   }

   public SimAircraft(string title)
   {
      Title = title;

      HasAS1000 = false;
      HasG3X2x = false;
      HasG3X3x = false;
      HasAS530 = false;
      HasAS430 = false;
      HasGTN650 = false;
      HasGPS = false;
      HasAS3000Horiz1x = false;
      HasAS3000Horiz2x = false;
      HasAS3000Horiz3x = false;
      HasAS3000Vert1x = false;
      HasAS3000Vert2x = false;
      HasAS3000Vert4x = false;
   }


}
