using DevExpress.LookAndFeel;
using DevExpress.Skins;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;

namespace MacroSim.MacroPadDevice.Controls;

public partial class VerticalSpeedDisplay : UserControl
{
   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

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
   public override string Text
   {
      get
      {
         return text;
      }
      set
      {
         verticalSpeed = int.Parse(value);
         SetVerticalSpeed(verticalSpeed);
      }
   }

   [Browsable(true)]
   [DefaultValue(0)]
   public int Value
   {
      get
      {
         return verticalSpeed;
      }
      set
      {
         SetVerticalSpeed(value);
      }
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

      Text = "-0000";
      Value = 0;
   }
}
