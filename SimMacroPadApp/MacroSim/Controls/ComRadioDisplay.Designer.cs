namespace MacroSim.MacroPadDevice.Controls
{
   partial class ComRadioDisplay
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
         lblMHz = new DevExpress.XtraEditors.LabelControl();
         lblKHz = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblMHz
         // 
         lblMHz.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblMHz.Appearance.Options.UseFont = true;
         lblMHz.Location = new Point(0, 0);
         lblMHz.Name = "lblMHz";
         lblMHz.Size = new Size(54, 40);
         lblMHz.TabIndex = 0;
         lblMHz.Text = "000.";
         // 
         // lblKHz
         // 
         lblKHz.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblKHz.Appearance.Options.UseFont = true;
         lblKHz.Location = new Point(54, 0);
         lblKHz.Name = "lblKHz";
         lblKHz.Size = new Size(48, 40);
         lblKHz.TabIndex = 1;
         lblKHz.Text = "000";
         // 
         // ComRadioDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblKHz);
         Controls.Add(lblMHz);
         Name = "ComRadioDisplay";
         Size = new Size(102, 40);
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private DevExpress.XtraEditors.LabelControl lblMHz;
      private DevExpress.XtraEditors.LabelControl lblKHz;
   }
}
