using DevExpress.LookAndFeel;
using DevExpress.Skins;
using MacroSim.MacroPadDevice.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

   public override string Text
   {
      get
      {
         return text;
      }
      set
      {
         direction = int.Parse(value);
         SetDirection(direction);
      }
   }

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
