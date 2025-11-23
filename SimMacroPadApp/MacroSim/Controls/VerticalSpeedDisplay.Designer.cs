namespace MacroSim.MacroPadDevice.Controls
{
   partial class VerticalSpeedDisplay
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
         lblVerticalSpeed = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblVerticalSpeed
         // 
         lblVerticalSpeed.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblVerticalSpeed.Appearance.Options.UseFont = true;
         lblVerticalSpeed.Appearance.Options.UseTextOptions = true;
         lblVerticalSpeed.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
         lblVerticalSpeed.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblVerticalSpeed.Location = new Point(0, 0);
         lblVerticalSpeed.Name = "lblVerticalSpeed";
         lblVerticalSpeed.Size = new Size(76, 40);
         lblVerticalSpeed.TabIndex = 2;
         lblVerticalSpeed.Text = "-0000";
         // 
         // VerticalSpeedDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblVerticalSpeed);
         Name = "VerticalSpeedDisplay";
         Size = new Size(76, 40);
         ResumeLayout(false);
      }

      #endregion

      public DevExpress.XtraEditors.LabelControl lblVerticalSpeed;
   }
}
