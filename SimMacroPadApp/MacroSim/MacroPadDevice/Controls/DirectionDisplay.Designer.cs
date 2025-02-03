namespace MacroSim.MacroPadDevice.Controls
{
   partial class DirectionDisplay
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
         lblDirection = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblDirection
         // 
         lblDirection.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblDirection.Appearance.Options.UseFont = true;
         lblDirection.Location = new Point(0, 0);
         lblDirection.Name = "lblDirection";
         lblDirection.Size = new Size(48, 40);
         lblDirection.TabIndex = 1;
         lblDirection.Text = "000";
         // 
         // DirectionDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblDirection);
         Name = "DirectionDisplay";
         Size = new Size(48, 40);
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      public DevExpress.XtraEditors.LabelControl lblDirection;
   }
}
