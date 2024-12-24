namespace MacroSim
{
   partial class PresetEventForm
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         label1 = new Label();
         txtAircraft = new TextBox();
         listAircraft = new ListBox();
         listPresets = new ListBox();
         btnClearAircraft = new Button();
         txtCalculatorCode = new TextBox();
         btnSendCalculatorCode = new Button();
         label2 = new Label();
         txtParameter = new TextBox();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(12, 9);
         label1.Name = "label1";
         label1.Size = new Size(50, 17);
         label1.TabIndex = 0;
         label1.Text = "Aircraft";
         // 
         // txtAircraft
         // 
         txtAircraft.Location = new Point(12, 29);
         txtAircraft.Name = "txtAircraft";
         txtAircraft.Size = new Size(163, 25);
         txtAircraft.TabIndex = 1;
         txtAircraft.TextChanged += txtAircraft_TextChanged;
         // 
         // listAircraft
         // 
         listAircraft.FormattingEnabled = true;
         listAircraft.ItemHeight = 17;
         listAircraft.Location = new Point(12, 60);
         listAircraft.Name = "listAircraft";
         listAircraft.Size = new Size(163, 191);
         listAircraft.TabIndex = 2;
         listAircraft.SelectedIndexChanged += listAircraft_SelectedIndexChanged;
         listAircraft.Leave += listAircraft_Leave;
         // 
         // listPresets
         // 
         listPresets.FormattingEnabled = true;
         listPresets.ItemHeight = 17;
         listPresets.Location = new Point(181, 60);
         listPresets.Name = "listPresets";
         listPresets.Size = new Size(289, 191);
         listPresets.TabIndex = 3;
         listPresets.SelectedIndexChanged += listPresets_SelectedIndexChanged;
         // 
         // btnClearAircraft
         // 
         btnClearAircraft.Location = new Point(181, 31);
         btnClearAircraft.Name = "btnClearAircraft";
         btnClearAircraft.Size = new Size(75, 23);
         btnClearAircraft.TabIndex = 4;
         btnClearAircraft.Text = "Clear";
         btnClearAircraft.UseVisualStyleBackColor = true;
         btnClearAircraft.Click += btnClearAircraft_Click;
         // 
         // txtCalculatorCode
         // 
         txtCalculatorCode.Location = new Point(12, 257);
         txtCalculatorCode.Multiline = true;
         txtCalculatorCode.Name = "txtCalculatorCode";
         txtCalculatorCode.Size = new Size(458, 74);
         txtCalculatorCode.TabIndex = 5;
         txtCalculatorCode.TextChanged += txtCalculatorCode_TextChanged;
         // 
         // btnSendCalculatorCode
         // 
         btnSendCalculatorCode.Location = new Point(12, 376);
         btnSendCalculatorCode.Name = "btnSendCalculatorCode";
         btnSendCalculatorCode.Size = new Size(75, 23);
         btnSendCalculatorCode.TabIndex = 6;
         btnSendCalculatorCode.Text = "Send";
         btnSendCalculatorCode.UseVisualStyleBackColor = true;
         btnSendCalculatorCode.Click += btnSendCalculatorCode_Click;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(12, 344);
         label2.Name = "label2";
         label2.Size = new Size(68, 17);
         label2.TabIndex = 7;
         label2.Text = "Parameter";
         // 
         // txtParameter
         // 
         txtParameter.Location = new Point(86, 341);
         txtParameter.Name = "txtParameter";
         txtParameter.Size = new Size(100, 25);
         txtParameter.TabIndex = 8;
         // 
         // PresetEventForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(512, 417);
         Controls.Add(txtParameter);
         Controls.Add(label2);
         Controls.Add(btnSendCalculatorCode);
         Controls.Add(txtCalculatorCode);
         Controls.Add(btnClearAircraft);
         Controls.Add(listPresets);
         Controls.Add(listAircraft);
         Controls.Add(txtAircraft);
         Controls.Add(label1);
         Name = "PresetEventForm";
         ShowInTaskbar = false;
         StartPosition = FormStartPosition.CenterParent;
         Text = "PresetEventForm";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label label1;
      private TextBox txtAircraft;
      private ListBox listAircraft;
      private ListBox listPresets;
      private Button btnClearAircraft;
      private TextBox txtCalculatorCode;
      private Button btnSendCalculatorCode;
      private Label label2;
      private TextBox txtParameter;
   }
}