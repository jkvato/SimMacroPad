using DevExpress.LookAndFeel;
using DevExpress.Skins;
using MacroSim.MacroPadDevice.Enumerations;
using System.ComponentModel;

namespace MacroSim.MacroPadDevice.Controls;

public partial class NavRadioDisplay : UserControl
{
   public static readonly double MinFrequency = 108.00;
   public static readonly double MaxFrequency = 117.95;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   private double frequency;
   private string text;
   MacroPadState macroPadState;


   [Browsable(false)]
   public MacroPadState CurrentMacroPadState
   {
      get => macroPadState;
      set
      {
         macroPadState = value;

         Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

         lblMHz.Appearance.ForeColor = skin.Colors["ControlText"];
         lblMHz.Appearance.BackColor = skin.Colors["Control"];
         lblKHz.Appearance.ForeColor = skin.Colors["ControlText"];
         lblKHz.Appearance.BackColor = skin.Colors["Control"];

         if (IsHighlightable)
         {
            if (macroPadState == MacroPadState.NAV1_MHZ && Id == 1)
            {
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.NAV1_KHZ && Id == 1)
            {
               lblKHz.Appearance.ForeColor = HighlightForeColor;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.NAV2_MHZ && Id == 2)
            {
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.NAV2_KHZ && Id == 2)
            {
               lblKHz.Appearance.ForeColor = HighlightForeColor;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
            }
         }
      }
   }

   [Browsable(true)]
   [DefaultValue(1)]
   public int Id { get; set; } = 1;

   [Browsable(true)]
   [DefaultValue(false)]
   public bool IsHighlightable { get; set; } = false;

   [Browsable(true)]
   public override string Text
   {
      get
      {
         return text;
      }
      set
      {
         frequency = double.Parse(value);
         SetFrequency(frequency);
      }
   }

   [Browsable(true)]
   public double Value
   {
      get
      {
         return frequency;
      }
      set
      {
         SetFrequency(value);
      }
   }

   private void SetFrequency(double freq)
   {
      if (freq < MinFrequency || freq > MaxFrequency)
      {
         throw new ArgumentOutOfRangeException("Frequency");
      }

      frequency = freq;
      text = string.Format("{0:000.00}", frequency);
      string[] parts = text.Split('.');
      int mhz = int.Parse(parts[0]);
      int khz = int.Parse(parts[1]);

      lblMHz.Text = string.Format("{0:000}.", mhz);
      lblKHz.Text = string.Format("{0:00}", khz);
   }

   public NavRadioDisplay()
   {
      InitializeComponent();

      Value = 108.0;
      Text = "108.00";
   }
}
