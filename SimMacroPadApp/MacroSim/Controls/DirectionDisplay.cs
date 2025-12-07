using DevExpress.LookAndFeel;
using DevExpress.Skins;
using Hds.MacroPad;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MacroSim.MacroPadDevice.Controls;

public partial class DirectionDisplay : UserControl
{
   public static readonly int MinDirection = 1;
   public static readonly int MaxDirection = 360;

   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;

   public event DirectionChangedEventHandler? DirectionChanged;

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
            throw new ArgumentNullException(nameof(Text));
         }

         if (int.TryParse(value, out int direction) == false)
         {
            throw new FormatException("Invalid direction format.");
         }

         SetDirection(direction);
      }
   }

   [Browsable(true)]
   public int Value
   {
      get => direction;
      set => SetDirection(value);
   }

   private void SetDirection(int dir)
   {
      if (dir == 0)
      {
         dir = 360;
      }
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

      Value = MinDirection;

      MouseWheel += DirectionDisplay_MouseWheel;
   }

   private void DirectionDisplay_MouseWheel(object? sender, MouseEventArgs e)
   {
      var sign = Math.Sign(e.Delta);

      int newDirection = direction +  (sign * 1);

      if (newDirection < MinDirection)
      {
         newDirection = MaxDirection;
      }
      else if (newDirection > MaxDirection)
      {
         newDirection = MinDirection;
      }

      OnDirectionChanged(new DirectionDisplayEventArgs(newDirection));
   }

   private void Direction_DoubleClick(object sender, EventArgs e)
   {

   }

   protected virtual void OnDirectionChanged(DirectionDisplayEventArgs e)
   {
      DirectionChanged?.Invoke(this, e);
   }
}

public delegate void DirectionChangedEventHandler(object sender, DirectionDisplayEventArgs e);

public record DirectionDisplayEventArgs(int Direction);
