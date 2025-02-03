using DevExpress.LookAndFeel;
using DevExpress.Skins;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;

namespace MacroSim.MacroPadDevice.Controls;

public partial class AltitudeDisplay : UserControl
{
   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

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
   public override string Text
   {
      get
      {
         return text;
      }
      set
      {
         altitude = int.Parse(value);
         SetAltitude(altitude);
      }
   }

   [Browsable(true)]
   public int Value
   {
      get
      {
         return altitude;
      }
      set
      {
         SetAltitude(value);
      }
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
      Text = "00000";
   }
}
