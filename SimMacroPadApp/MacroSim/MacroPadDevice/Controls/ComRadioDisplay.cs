using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace MacroSim.MacroPadDevice.Controls;

public enum ComRadioHighlight : int
{
   None = 0,
   MHz = 1,
   KHz = 2,
}

public partial class ComRadioDisplay : UserControl
{
   public static readonly double MinFrequency = 118.000;
   public static readonly double MaxFrequency = 136.995;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   private double frequency;
   private string text;
   private ComRadioHighlight highlight;

   public ComRadioHighlight Highlight
   {
      get => highlight;
      set
      {
         highlight = value;

         Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

         switch (highlight)
         {
            case ComRadioHighlight.MHz:
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
               lblKHz.Appearance.ForeColor = DXSkinColors.ForeColors.ControlText;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
               break;
            case ComRadioHighlight.KHz:
               lblMHz.Appearance.ForeColor = DXSkinColors.ForeColors.ControlText;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
               lblKHz.Appearance.ForeColor = HighlightForeColor;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
               break;
            default:
               lblMHz.Appearance.ForeColor = skin.Colors["ControlText"];
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
               lblKHz.Appearance.ForeColor = skin.Colors["ControlText"];
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
               break;
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
         frequency = double.Parse(value);
         SetFrequency(frequency);
      }
   }

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
      text = string.Format("{0:000.000}", frequency);
      string[] parts = text.Split('.');
      int mhz = int.Parse(parts[0]);
      int khz = int.Parse(parts[1]);

      lblMHz.Text = string.Format("{0:000}.", mhz);
      lblKHz.Text = string.Format("{0:000}", khz);
   }

   public ComRadioDisplay()
   {
      InitializeComponent();

      Value = 118.0;
      Text = "118.000";
   }
}
