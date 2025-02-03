using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace MacroSim.MacroPadDevice.Controls;

public enum NavRadioHighlight : int
{
   None = 0,
   MHz = 1,
   KHz = 2,
}

public partial class NavRadioDisplay : UserControl
{
   public static readonly double MinFrequency = 108.00;
   public static readonly double MaxFrequency = 117.95;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   private double frequency;
   private string text;
   private NavRadioHighlight highlight;

   public NavRadioHighlight Highlight
   {
      get => highlight;
      set
      {
         highlight = value;

         Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

         switch (highlight)
         {
            case NavRadioHighlight.MHz:
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
               lblKHz.Appearance.ForeColor = DXSkinColors.ForeColors.ControlText;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
               break;
            case NavRadioHighlight.KHz:
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
