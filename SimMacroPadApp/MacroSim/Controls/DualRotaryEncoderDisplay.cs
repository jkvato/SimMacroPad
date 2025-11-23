using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using MacroSim.MacroPadDevice;
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

namespace MacroSim.Controls;

public partial class DualRotaryEncoderDisplay : UserControl
{
   public Color HighlightForeColor = DXSkinColors.ForeColors.Critical;
   public Color HoverForeColor = DXSkinColors.ForeColors.Warning;

   public MacroPadState TopButtonId {  get; set; }
   public MacroPadState BottomButtonId { get; set; }

   public delegate void MouseWheelEventHandler(object sender, MouseWheelEventArgs e);
   public event MouseWheelEventHandler? MouseWheelMoved;

   private MacroPadState currentState;

   private bool isMouseInTopButton = false;
   private bool isMouseInBottomButton = false;

   public string TopButtonText
   {
      get => btnTop.Text;
      set => btnTop.Text = value;
   }

   public string BottomButtonText
   {
      get => btnBottom.Text;
      set => btnBottom.Text = value;
   }

   public MacroPadState CurrentState
   {
      get => currentState;
      set
      {
         currentState = value;
         HighlightButtons();
      }
   }

   protected virtual void OnMouseWheelMoved(MouseWheelEventArgs e)
   {
      MouseWheelMoved?.Invoke(this, e);
   }

   public DualRotaryEncoderDisplay()
   {
      InitializeComponent();

      btnTop.MouseWheel += Button_MouseWheel;
      btnTop.MouseEnter += Button_MouseEnter;
      btnTop.MouseLeave += Button_MouseLeave;

      btnBottom.MouseWheel += Button_MouseWheel;
      btnBottom.MouseEnter += Button_MouseEnter;
      btnBottom.MouseLeave += Button_MouseLeave;
   }

   private void Button_MouseLeave(object? sender, EventArgs e)
   {
      if (sender is SimpleButton btn)
      {
         if (btn == btnTop)
         {
            isMouseInTopButton = false;
            System.Diagnostics.Debug.WriteLine("isMouseInTopButton = false");
         }
         else if (btn == btnBottom)
         {
            isMouseInBottomButton = false;
            System.Diagnostics.Debug.WriteLine("isMouseInBottomButton = false");
         }
      }
      HighlightButtons();
   }

   private void Button_MouseEnter(object? sender, EventArgs e)
   {
      if (sender is SimpleButton btn)
      {
         if (btn == btnTop)
         {
            isMouseInTopButton = true;
            System.Diagnostics.Debug.WriteLine("isMouseInTopButton = true");
         }
         else if (btn == btnBottom)
         {
            isMouseInBottomButton = true;
            System.Diagnostics.Debug.WriteLine("isMouseInBottomButton = true");
         }
      }
      HighlightButtons();
   }

   private void Button_MouseWheel(object? sender, MouseEventArgs e)
   {
      if (sender is SimpleButton btn)
      {
         if (btn == btnTop)
         {
            OnMouseWheelMoved(new MouseWheelEventArgs(TopButtonId, e.Delta));
         }
         else if (btn == btnBottom)
         {
            OnMouseWheelMoved(new MouseWheelEventArgs(BottomButtonId, e.Delta));
         }
      }
   }

   private void HighlightButtons()
   {
      Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

      btnTop.Appearance.ForeColor = skin.Colors["ControlText"];
      btnTop.Appearance.BackColor = skin.Colors["Control"];
      btnBottom.Appearance.ForeColor = skin.Colors["ControlText"];
      btnBottom.Appearance.BackColor = skin.Colors["Control"];

      if (currentState == TopButtonId)
      {
         btnTop.Appearance.ForeColor = HighlightForeColor;
         btnTop.Appearance.BackColor = skin.Colors["Control"];
      }
      else if (currentState == BottomButtonId)
      {
         btnBottom.Appearance.ForeColor = HighlightForeColor;
         btnBottom.Appearance.BackColor = skin.Colors["Control"];
      }
      if (isMouseInTopButton)
      {
         btnTop.Appearance.ForeColor = HoverForeColor;
         btnTop.Appearance.BackColor = skin.Colors["Control"];
      }
      if (isMouseInBottomButton)
      {
         btnBottom.Appearance.ForeColor = HoverForeColor;
         btnBottom.Appearance.BackColor = skin.Colors["Control"];
      }
   }
}

public class MouseWheelEventArgs : EventArgs
{
   public MacroPadState ButtonId { get; private set; }
   public int Delta { get; private set; }

   public MouseWheelEventArgs(MacroPadState buttonId, int delta)
   {
      ButtonId = buttonId;
      Delta = delta;
   }
}

