namespace MacroSim.MacroPadDevice.Controls
{
   partial class AltitudeDisplay
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
         lblThousands = new DevExpress.XtraEditors.LabelControl();
         lblHundreds = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblThousands
         // 
         lblThousands.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblThousands.Appearance.Options.UseFont = true;
         lblThousands.Location = new Point(0, 0);
         lblThousands.Name = "lblThousands";
         lblThousands.Size = new Size(32, 40);
         lblThousands.TabIndex = 2;
         lblThousands.Text = "00";
         // 
         // lblHundreds
         // 
         lblHundreds.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblHundreds.Appearance.Options.UseFont = true;
         lblHundreds.Location = new Point(32, 0);
         lblHundreds.Name = "lblHundreds";
         lblHundreds.Size = new Size(48, 40);
         lblHundreds.TabIndex = 3;
         lblHundreds.Text = "000";
         // 
         // AltitudeDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblHundreds);
         Controls.Add(lblThousands);
         Name = "AltitudeDisplay";
         Size = new Size(80, 40);
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      public DevExpress.XtraEditors.LabelControl lblThousands;
      public DevExpress.XtraEditors.LabelControl lblHundreds;
   }
}
