using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MacroSim.MacroPadDevice.Controls;

public partial class DirectionDisplay : UserControl
{
   public static readonly int MinDirection = 0;
   public static readonly int MaxDirection = 360;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   private int direction;
   private string text;

   MacroPadState macroPadState;

   [Browsable(true)]
   [DefaultValue(MacroPadState.None)]
   public MacroPadState MacroPadStateId { get; set; } = MacroPadState.None;

   [Browsable(false)]
   public MacroPadState CurrentMacroPadState
   {
      get => macroPadState;
      set
      {
         macroPadState = value;

         Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

         if (CurrentMacroPadState == MacroPadStateId)
         {
            lblDirection.Appearance.ForeColor = HighlightForeColor;
            lblDirection.Appearance.BackColor = skin.Colors["Control"];
         }
         else
         {
            lblDirection.Appearance.ForeColor = skin.Colors["ControlText"];
            lblDirection.Appearance.BackColor = skin.Colors["Control"];
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
            text = "000";
            SetDirection(0);
            return;
         }

         if (int.TryParse(value, out int direction) == false)
         {
            direction = 0;
         }

         SetDirection(direction);
      }
   }

   [Browsable(true)]
   public int Value
   {
      get
      {
         return direction;
      }
      set
      {
         SetDirection(value);
      }
   }

   private void SetDirection(int dir)
   {
      if (dir < MinDirection || dir > MaxDirection)
      {
         throw new ArgumentOutOfRangeException("Direction");
      }

      direction = dir;
      text = string.Format("{0:000}", direction);
      lblDirection.Text = text;
   }

   public DirectionDisplay()
   {
      InitializeComponent();

      Value = 0;
      Text = "000";
   }
}
