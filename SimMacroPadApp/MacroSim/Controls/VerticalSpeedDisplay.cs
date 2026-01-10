using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MacroSim.MacroPadDevice.Controls;

public partial class VerticalSpeedDisplay : UserControl
{
   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   public event VerticalSpeedChangedEventHandler? VerticalSpeedChanged;

   private int verticalSpeed;
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

         if (macroPadState == MacroPadState.VERTICAL_SPEED)
         {
            lblVerticalSpeed.Appearance.ForeColor = HighlightForeColor;
            lblVerticalSpeed.Appearance.BackColor = skin.Colors["Control"];
         }
         else
         {
            lblVerticalSpeed.Appearance.ForeColor = skin.Colors["ControlText"];
            lblVerticalSpeed.Appearance.BackColor = skin.Colors["Control"];
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
            throw new ArgumentNullException(nameof(value));
         }

         if (int.TryParse(value, out int verticalSpeed) == false)
            return;

         SetVerticalSpeed(verticalSpeed);
      }
   }

   [Browsable(true)]
   [DefaultValue(0)]
   public int Value
   {
      get => verticalSpeed;
      set => SetVerticalSpeed(value);
   }

   private void SetVerticalSpeed(int vs)
   {
      verticalSpeed = vs;
      text = string.Format("{0:0000}", verticalSpeed);
      lblVerticalSpeed.Text = text;
   }

   public VerticalSpeedDisplay()
   {
      InitializeComponent();

      Value = 0;

      MouseWheel += VerticalSpeedDisplay_MouseWheel;
   }

   private void VerticalSpeedDisplay_MouseWheel(object? sender, MouseEventArgs e)
   {
      var sign = Math.Sign(e.Delta);
      int newVerticalSpeed = verticalSpeed + (sign * 100);

      OnVerticalSpeedChanged(new DirectionDisplayEventArgs(newVerticalSpeed));
   }

   private void OnVerticalSpeedChanged(DirectionDisplayEventArgs directionDisplayEventArgs)
   {
      VerticalSpeedChanged?.Invoke(this, new VerticalSpeedDisplayEventArgs(directionDisplayEventArgs.Direction));
   }
}

public delegate void VerticalSpeedChangedEventHandler(object sender, VerticalSpeedDisplayEventArgs e);

public record VerticalSpeedDisplayEventArgs(int VerticalSpeed);
