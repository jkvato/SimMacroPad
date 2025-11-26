using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MacroSim.MacroPadDevice.Controls
{
   public partial class BarometerDisplay : UserControl
   {
      public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

      private double barometer;
      private string text;

      MacroPadState macroPadState;

      [Browsable(false)]
      [DefaultValue(MacroPadState.None)]
      public MacroPadState CurrentMacroPadState
      {
         get => macroPadState;
         set
         {
            macroPadState = value;

            Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

            if (macroPadState == MacroPadState.BAROMETER)
            {
               lblBarometer.Appearance.ForeColor = HighlightForeColor;
               lblBarometer.Appearance.BackColor = skin.Colors["Control"];
            }
            else
            {
               lblBarometer.Appearance.ForeColor = skin.Colors["ControlText"];
               lblBarometer.Appearance.BackColor = skin.Colors["Control"];
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
               text = "29.92";
               SetBarometer(29.92);
               return;
            }

            text = value;

            if (!double.TryParse(value, out double barometer))
            {
               barometer = 29.92;
            }

            SetBarometer(barometer);
         }
      }

      [Browsable(true)]
      [DefaultValue(29.92)]
      public double Value
      {
         get
         {
            return barometer;
         }
         set
         {
            SetBarometer(value);
         }
      }

      private void SetBarometer(double bar)
      {
         barometer = bar;
         text = string.Format("{0:00.00}", barometer);
         lblBarometer.Text = text;
      }

      public BarometerDisplay()
      {
         InitializeComponent();
         Text = "29.92";
         Value = 29.92;
      }
   }
}
