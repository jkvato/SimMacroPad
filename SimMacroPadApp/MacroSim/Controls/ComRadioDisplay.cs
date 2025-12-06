using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using MacroSim.Controls;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MacroSim.MacroPadDevice.Controls;

public partial class ComRadioDisplay : ControlBase
{
   public static readonly decimal MinFrequency = 118.000m;
   public static readonly decimal MaxFrequency = 136.995m;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   public event ComFrequencyChangedEventHandler? FrequencyChanged;
   public event ComFrequencySwappedEventHandler? FrequencySwapped;

   private decimal frequency;
   private string text;
   MacroPadState macroPadState;

   protected override (int X1, int Y1, int X2, int Y2, int regionId)[] Regions =>
      [
         (0, 0, 48, 39, 1),    // MHz
         (54, 0, 101, 39, 2)   // KHz
      ];

   [Browsable(false)]
   public MacroPadState CurrentMacroPadState
   {
      get => macroPadState;
      set
      {
         macroPadState = value;

         Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);

         lblMHz.Appearance.ForeColor = skin.Colors["ControlText"];
         lblMHz.Appearance.BackColor = skin.Colors["Control"];
         lblKHz.Appearance.ForeColor = skin.Colors["ControlText"];
         lblKHz.Appearance.BackColor = skin.Colors["Control"];

         if (IsHighlightable)
         {
            if (macroPadState == MacroPadState.COM1_MHZ && Id == 1)
            {
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.COM1_KHZ && Id == 1)
            {
               lblKHz.Appearance.ForeColor = HighlightForeColor;
               lblKHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.COM2_MHZ && Id == 2)
            {
               lblMHz.Appearance.ForeColor = HighlightForeColor;
               lblMHz.Appearance.BackColor = skin.Colors["Control"];
            }
            else if (macroPadState == MacroPadState.COM2_KHZ && Id == 2)
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
   [AllowNull]
   public override string Text
   {
      get => text;
      set
      {
         if (value == null)
         {
            SetFrequency(MinFrequency);
            return;
         }

         if (decimal.TryParse(
            value,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out var freq))
         {
            SetFrequency(freq);
         }
         else
         {
            throw new FormatException("Invalid frequency format.");
         }
      }
   }

   [Browsable(true)]
   public decimal Value
   {
      get => frequency;
      set => SetFrequency(value);
   }

   private void SetFrequency(decimal freq)
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

      Value = MinFrequency;

      MouseWheel += ComDisplay_MouseWheel;
   }

   private void ComDisplay_DoubleClick(object? sender, EventArgs e)
   {
      OnComFrequencySwapped(EventArgs.Empty);
   }

   private void ComDisplay_MouseWheel(object? sender, MouseEventArgs e)
   {
      int regionId = GetRegionIdFromPoint(e.Location);

      var sign = Math.Sign(e.Delta);
      decimal freq = Convert.ToDecimal(frequency);
      decimal max = Convert.ToDecimal(Math.Floor(MaxFrequency));
      decimal min = Convert.ToDecimal(MinFrequency);

      decimal mhz = Math.Floor(freq);
      decimal khz = freq - Math.Floor(freq);

      if (regionId == 1)
      {
         mhz += (sign * 1.0m);
         if (mhz < min)
         {
            mhz = max;
         }
         else if (mhz > max)
         {
            mhz = min;
         }
      }
      else if (regionId == 2)
      {
         // KHz change independently of MHz
         khz += (sign * 0.005m);
         if (khz < 0.0m)
         {
            khz = 0.995m;
         }
         else if (khz > 0.995m)
         {
            khz = 0.0m;
         }
      }

      decimal f = mhz + khz;
      double fDouble = Convert.ToDouble(f);

      OnComFrequencyChanged(new ComDisplayEventArgs(fDouble));
   }

   protected virtual void OnComFrequencyChanged(ComDisplayEventArgs e)
   {
      FrequencyChanged?.Invoke(this, e);
   }

   protected virtual void OnComFrequencySwapped(EventArgs e)
   {
      FrequencySwapped?.Invoke(this, e);
   }
}

public delegate void ComFrequencyChangedEventHandler(object sender, ComDisplayEventArgs e);
public delegate void ComFrequencySwappedEventHandler(object sender, EventArgs e);

public record ComDisplayEventArgs(double Frequency);
