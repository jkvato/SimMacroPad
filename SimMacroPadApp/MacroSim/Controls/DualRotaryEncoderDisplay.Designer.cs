namespace MacroSim.Controls
{
   partial class DualRotaryEncoderDisplay
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         btnTop = new DevExpress.XtraEditors.SimpleButton();
         btnBottom = new DevExpress.XtraEditors.SimpleButton();
         SuspendLayout();
         // 
         // btnTop
         // 
         btnTop.Location = new Point(1, 1);
         btnTop.Name = "btnTop";
         btnTop.Size = new Size(50, 25);
         btnTop.TabIndex = 0;
         btnTop.Text = "Top";
         // 
         // btnBottom
         // 
         btnBottom.Location = new Point(1, 26);
         btnBottom.Name = "btnBottom";
         btnBottom.Size = new Size(50, 25);
         btnBottom.TabIndex = 1;
         btnBottom.Text = "Btm";
         // 
         // DualRotaryEncoderDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(btnBottom);
         Controls.Add(btnTop);
         Name = "DualRotaryEncoderDisplay";
         Size = new Size(52, 52);
         ResumeLayout(false);
      }

      #endregion

      private DevExpress.XtraEditors.SimpleButton btnTop;
      private DevExpress.XtraEditors.SimpleButton btnBottom;
   }
}
