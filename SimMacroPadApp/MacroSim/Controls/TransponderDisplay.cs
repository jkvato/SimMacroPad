using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.Controls;
using MacroSim.MacroPadDevice.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroSim.MacroPadDevice.Controls
{
   public partial class TransponderDisplay : ControlBase
   {
      public static readonly int MinDigit = 0;
      public static readonly int MaxDigit = 7;
      public static readonly int VfrCode = 1200;

      public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

      public event TransponderChangedEventHandler? TransponderChanged;

      private int transponder;
      string text;

      protected override (int X1, int Y1, int X2, int Y2, int regionId)[] Regions =>
      [
         ( 0, 0, 16, 39, 0),   // 1000s
         (16, 0, 32, 39, 1),    // 100s
         (32, 0, 48, 39, 2),     // 10s
         (48, 0, 63, 39, 3)       // 1s
      ];

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

      private int MakeValid(int squawk)
      {
         if (squawk < 0)
            return 0;
         if (squawk > 7777)
            return 7777;
         string str = string.Format("{0:0000}", squawk);
         char[] chars = str.ToCharArray();
         for (int i = 0; i < chars.Length; i++)
         {
            int d = int.Parse(chars[i].ToString());
            if (d < MinDigit)
               chars[i] = MaxDigit.ToString()[0];
            if (d > MaxDigit)
               chars[i] = MinDigit.ToString()[0];
         }
         return int.Parse(new string(chars));
      }

      //[Browsable(true)]
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

            if (int.TryParse(value, out int transponder) == false)
            {
               throw new FormatException("Invalid transponder format.");
            }

            transponder = int.Parse(value);
            SetTransponder(transponder);
         }
      }

      //[Browsable(true)]
      //[DefaultValue(1200)]
      public int Value
      {
         get => transponder;
         set => SetTransponder(value);
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

         Value = VfrCode;

         MouseWheel += TransponderDisplay_MouseWheel;
      }

      private void TransponderDisplay_MouseWheel(object? sender, MouseEventArgs e)
      {
         int sign = Math.Sign(e.Delta);
         int sqwak = transponder;
         var digits = GetTransponderDigits();

         for (int i = 0; i < Regions.Length; i++)
         {
            var region = Regions[i];
            if (e.X >= region.X1 && e.X <= region.X2 &&
                e.Y >= region.Y1 && e.Y <= region.Y2)
            {
               var d = digits[i] + sign;
               if (d < MinDigit)
                  d = MaxDigit;
               else if (d > MaxDigit)
                  d = MinDigit;

               digits[i] = d;
            }
         }

         sqwak = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

         OnTransponderChanged(new TransponderDisplayEventArgs(sqwak));
      }

      protected virtual void OnTransponderChanged(TransponderDisplayEventArgs e)
      {
         TransponderChanged?.Invoke(this, e);
      }

      char[] GetTransponderDigitsAsChars()
      {
         string str = string.Format("{0:0000}", transponder);
         return str.ToCharArray();
      }

      string[] GetTransponderDigitsAsStrings()
      {
         char[] chars = GetTransponderDigitsAsChars();
         return chars.Select(c => c.ToString()).ToArray();
      }

      int[] GetTransponderDigits()
      {
         char[] chars = GetTransponderDigitsAsChars();
         return chars.Select(c => int.Parse(c.ToString())).ToArray();
      }

      private void TransponderDisplay_DoubleClick(object sender, EventArgs e)
      {
         OnTransponderChanged(new TransponderDisplayEventArgs(VfrCode));
      }
   }
}

public delegate void TransponderChangedEventHandler(object sender, TransponderDisplayEventArgs e);

public record TransponderDisplayEventArgs(int Transponder);

public enum TransponderDigit
{
   Ones,
   Tens,
   Hundreds,
   Thousands
}