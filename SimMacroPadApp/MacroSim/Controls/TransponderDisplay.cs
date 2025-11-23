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

namespace MacroSim.MacroPadDevice.Controls
{
   public partial class TransponderDisplay : UserControl
   {
      public static readonly int MinDigit = 0;
      public static readonly int MaxDigit = 7;
      public static readonly int VfrCode = 1200;

      public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

      private int transponder;
      string text;

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

            lblThousands.Appearance.ForeColor = skin.Colors["ControlText"];
            lblThousands.Appearance.BackColor = skin.Colors["Control"];
            lblHundreds.Appearance.ForeColor = skin.Colors["ControlText"];
            lblHundreds.Appearance.BackColor = skin.Colors["Control"];
            lblTens.Appearance.ForeColor = skin.Colors["ControlText"];
            lblTens.Appearance.BackColor = skin.Colors["Control"];
            lblOnes.Appearance.ForeColor = skin.Colors["ControlText"];
            lblOnes.Appearance.BackColor = skin.Colors["Control"];

            switch (macroPadState)
            {
               case MacroPadState.XPND_1000:
                  lblThousands.Appearance.ForeColor = HighlightForeColor;
                  lblThousands.Appearance.BackColor = skin.Colors["Control"];
                  break;
               case MacroPadState.XPND_100:
                  lblHundreds.Appearance.ForeColor = HighlightForeColor;
                  lblHundreds.Appearance.BackColor = skin.Colors["Control"];
                  break;
               case MacroPadState.XPND_10:
                  lblTens.Appearance.ForeColor = HighlightForeColor;
                  lblTens.Appearance.BackColor = skin.Colors["Control"];
                  break;
               case MacroPadState.XPND_1:
                  lblOnes.Appearance.ForeColor = HighlightForeColor;
                  lblOnes.Appearance.BackColor = skin.Colors["Control"];
                  break;
            }
         }
      }

      private bool IsValid(int squawk)
      {
         if (squawk < 0 || squawk > 7777)
            return false;

         string str = string.Format("{0:0000}", squawk);

         for (int i = 0; i < str.Length; i++)
         {
            int d = int.Parse(str.Substring(i, 1));
            if (d < MinDigit || d > MaxDigit)
               return false;
         }
         return true;
      }

      //[Browsable(true)]
      public override string Text
      {
         get
         {
            return text;
         }
         set
         {
            transponder = int.Parse(value);
            SetTransponder(transponder);
         }
      }

      //[Browsable(true)]
      //[DefaultValue(1200)]
      public int Value
      {
         get
         {
            return transponder;
         }
         set
         {
            SetTransponder(value);
         }
      }

      private void SetTransponder(int squawk)
      {
         if (!IsValid(squawk))
            throw new ArgumentOutOfRangeException(nameof(squawk));

         transponder = squawk;
         text = string.Format("{0:0000}", transponder);
         lblThousands.Text = text[0].ToString();
         lblHundreds.Text = text[1].ToString();
         lblTens.Text = text[2].ToString();
         lblOnes.Text = text[3].ToString();
      }

      public TransponderDisplay()
      {
         InitializeComponent();

         Text = "1200";
         Value = VfrCode;
      }
   }
}
