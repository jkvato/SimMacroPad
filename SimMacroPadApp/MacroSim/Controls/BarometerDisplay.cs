using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using DevExpress.LookAndFeel;
using DevExpress.Map.Native;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.MacroPadDevice.Enumerations;

namespace MacroSim.MacroPadDevice.Controls
{
   public partial class BarometerDisplay : UserControl
   {
      public static readonly decimal StandardPressureInHg = 29.92m;

      public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

      public event BarometerChangedEventHandler? BarometerChanged;
      public event StandardBarometerEventHandler? StandardBarometerRequested;

      private decimal barometer;
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

            Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);

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
               throw new ArgumentNullException(nameof(Text));
            }

            if (!decimal.TryParse(value, out decimal barometer))
            {
               throw new FormatException("Invalid barometer format.");
            }

            SetBarometer(barometer);
         }
      }

      [Browsable(true)]
      [DefaultValue(29.92)]
      public decimal Value
      {
         get => barometer;
         set => SetBarometer(value);
      }

      private void SetBarometer(decimal bar)
      {
         barometer = bar;
         text = string.Format("{0:00.00}", barometer);
         lblBarometer.Text = text;
      }

      public BarometerDisplay()
      {
         InitializeComponent();

         Value = StandardPressureInHg;

         MouseWheel += BarometerDisplay_MouseWheel;
      }

      private void BarometerDisplay_MouseWheel(object? sender, MouseEventArgs e)
      {
         int sign = Math.Sign(e.Delta);

         decimal newBar = barometer + sign * 0.01m;

         OnBarometerChanged(new BarometerChangedEventArgs(newBar));
      }

      private void BarometerDisplay_DoubleClick(object sender, EventArgs e)
      {
         OnStandardBarometerRequested();
      }

      protected void OnBarometerChanged(BarometerChangedEventArgs e)
      {
         BarometerChanged?.Invoke(this, e);
      }

      protected void OnStandardBarometerRequested()
      {
         StandardBarometerRequested?.Invoke(this, EventArgs.Empty);
      }

   }
}

public delegate void BarometerChangedEventHandler(object sender, BarometerChangedEventArgs e);
public delegate void StandardBarometerEventHandler(object sender, EventArgs e);

public record BarometerChangedEventArgs(decimal Barometer);
