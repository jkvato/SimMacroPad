using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.Controls;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MacroSim.MacroPadDevice.Controls;

public partial class AltitudeDisplay : ControlBase
{
   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   public event AltitudeDisplayEventHandler? AltitudeChanged;

   protected override (int X1, int Y1, int X2, int Y2, int regionId)[] Regions =>
      [
         (0, 0, 32, 39, 1),    // Thousands
         (32, 0, 79, 39, 2)    // Hundreds
      ];

   private int altitude;
   private string text;
   MacroPadState macroPadState;

   [Browsable(false)]
   public MacroPadState CurrentMacroPadState
   {
      get => macroPadState;
      set
      {
         macroPadState = value;

         Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);

         lblThousands.Appearance.ForeColor = skin.Colors["ControlText"];
         lblThousands.Appearance.BackColor = skin.Colors["Control"];
         lblHundreds.Appearance.ForeColor = skin.Colors["ControlText"];
         lblHundreds.Appearance.BackColor = skin.Colors["Control"];

         if (macroPadState == MacroPadState.ALTITUDE_1000)
         {
            lblThousands.Appearance.ForeColor = HighlightForeColor;
            lblThousands.Appearance.BackColor = skin.Colors["Control"];
         }
         else if (macroPadState == MacroPadState.ALTITUDE_100)
         {
            lblHundreds.Appearance.ForeColor = HighlightForeColor;
            lblHundreds.Appearance.BackColor = skin.Colors["Control"];
         }
      }
   }

   [Browsable(true)]
   [AllowNull]
   public override string Text
   {
      get => text;
      set
      {
         if (value == null)
         {
            SetAltitude(0);
            return;
         }

         if (int.TryParse(value, out int altitude) == false)
         {
            throw new FormatException("Invalid frequency format.");
         }

         SetAltitude(altitude);
      }
   }

   [Browsable(true)]
   public int Value
   {
      get => altitude;
      set => SetAltitude(value);
   }

   private void SetAltitude(int alt)
   {
      altitude = alt;
      text = string.Format("{0:00000}", altitude);
      lblThousands.Text = text.Substring(0, 2);
      lblHundreds.Text = text.Substring(2, 3);
   }


   public AltitudeDisplay()
   {
      InitializeComponent();

      Value = 0;

      MouseWheel += AltitudeDisplay_MouseWheel;
   }

   private void AltitudeDisplay_MouseWheel(object? sender, MouseEventArgs e)
   {
      int regionId = GetRegionIdFromPoint(e.Location);
      int sign = Math.Sign(e.Delta);

      if (regionId == 1) // Thousands
      {
         altitude += sign * 1000;
      }
      else if (regionId == 2) // Hundreds
      {
         altitude += sign * 100;
      }
      if (altitude < 0)
         altitude = 0;
      if (altitude > 99999)
         altitude = 99999;

      OnAltitudeChanged(altitude);
   }

   protected void OnAltitudeChanged(int altitude)
   {
      AltitudeChanged?.Invoke(this, new AltitudeDisplayEventArgs(altitude));
   }

   private void AltitudeDisplay_DoubleClick(object sender, EventArgs e)
   {
   }
}

public delegate void AltitudeDisplayEventHandler(object sender, AltitudeDisplayEventArgs e);

public record AltitudeDisplayEventArgs(int Altitude);
