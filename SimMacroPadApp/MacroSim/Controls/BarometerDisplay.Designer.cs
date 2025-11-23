namespace MacroSim.MacroPadDevice.Controls
{
   partial class BarometerDisplay
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
         lblBarometer = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblBarometer
         // 
         lblBarometer.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblBarometer.Appearance.Options.UseFont = true;
         lblBarometer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblBarometer.Location = new Point(0, 0);
         lblBarometer.Name = "lblBarometer";
         lblBarometer.Size = new Size(70, 40);
         lblBarometer.TabIndex = 2;
         lblBarometer.Text = "00.00";
         // 
         // BarometerDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblBarometer);
         Name = "BarometerDisplay";
         Size = new Size(70, 40);
         ResumeLayout(false);
      }

      #endregion

      public DevExpress.XtraEditors.LabelControl lblBarometer;
   }
}
