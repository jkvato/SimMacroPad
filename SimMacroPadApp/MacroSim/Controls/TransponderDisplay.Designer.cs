namespace MacroSim.MacroPadDevice.Controls
{
   partial class TransponderDisplay
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
         lblTens = new DevExpress.XtraEditors.LabelControl();
         lblOnes = new DevExpress.XtraEditors.LabelControl();
         SuspendLayout();
         // 
         // lblThousands
         // 
         lblThousands.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblThousands.Appearance.Options.UseFont = true;
         lblThousands.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblThousands.Location = new Point(0, 0);
         lblThousands.Name = "lblThousands";
         lblThousands.Size = new Size(16, 40);
         lblThousands.TabIndex = 3;
         lblThousands.Text = "0";
         // 
         // lblHundreds
         // 
         lblHundreds.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblHundreds.Appearance.Options.UseFont = true;
         lblHundreds.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblHundreds.Location = new Point(16, 0);
         lblHundreds.Name = "lblHundreds";
         lblHundreds.Size = new Size(16, 40);
         lblHundreds.TabIndex = 4;
         lblHundreds.Text = "0";
         // 
         // lblTens
         // 
         lblTens.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblTens.Appearance.Options.UseFont = true;
         lblTens.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblTens.Location = new Point(32, 0);
         lblTens.Name = "lblTens";
         lblTens.Size = new Size(16, 40);
         lblTens.TabIndex = 5;
         lblTens.Text = "0";
         // 
         // lblOnes
         // 
         lblOnes.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblOnes.Appearance.Options.UseFont = true;
         lblOnes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         lblOnes.Location = new Point(48, 0);
         lblOnes.Name = "lblOnes";
         lblOnes.Size = new Size(16, 40);
         lblOnes.TabIndex = 6;
         lblOnes.Text = "0";
         // 
         // TransponderDisplay
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         Controls.Add(lblOnes);
         Controls.Add(lblTens);
         Controls.Add(lblHundreds);
         Controls.Add(lblThousands);
         Name = "TransponderDisplay";
         Size = new Size(64, 40);
         ResumeLayout(false);
      }

      #endregion

      public DevExpress.XtraEditors.LabelControl lblThousands;
      public DevExpress.XtraEditors.LabelControl lblHundreds;
      public DevExpress.XtraEditors.LabelControl lblTens;
      public DevExpress.XtraEditors.LabelControl lblOnes;
   }
}
