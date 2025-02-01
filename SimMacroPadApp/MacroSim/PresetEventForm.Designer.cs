using DevExpress.XtraEditors;

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
         components = new System.ComponentModel.Container();
         label1 = new LabelControl();
         listPresets = new ListBox();
         btnClearAircraft = new SimpleButton();
         txtCalculatorCode = new MemoEdit();
         btnSendCalculatorCode = new SimpleButton();
         label2 = new LabelControl();
         txtParameter = new TextEdit();
         gridLookUpEditAircraft = new GridLookUpEdit();
         gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
         simAircraftBindingSource = new BindingSource(components);
         ((System.ComponentModel.ISupportInitialize)txtCalculatorCode.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)txtParameter.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEditAircraft.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
         ((System.ComponentModel.ISupportInitialize)simAircraftBindingSource).BeginInit();
         SuspendLayout();
         // 
         // label1
         // 
         label1.Location = new Point(12, 9);
         label1.Margin = new Padding(4, 3, 4, 3);
         label1.Name = "label1";
         label1.Size = new Size(42, 17);
         label1.TabIndex = 0;
         label1.Text = "Aircraft";
         // 
         // listPresets
         // 
         listPresets.FormattingEnabled = true;
         listPresets.ItemHeight = 17;
         listPresets.Location = new Point(13, 60);
         listPresets.Margin = new Padding(4, 3, 4, 3);
         listPresets.Name = "listPresets";
         listPresets.Size = new Size(457, 191);
         listPresets.TabIndex = 3;
         listPresets.SelectedIndexChanged += listPresets_SelectedIndexChanged;
         // 
         // btnClearAircraft
         // 
         btnClearAircraft.Location = new Point(181, 31);
         btnClearAircraft.Margin = new Padding(4, 3, 4, 3);
         btnClearAircraft.Name = "btnClearAircraft";
         btnClearAircraft.Size = new Size(75, 24);
         btnClearAircraft.TabIndex = 4;
         btnClearAircraft.Text = "Clear";
         btnClearAircraft.Click += btnClearAircraft_Click;
         // 
         // txtCalculatorCode
         // 
         txtCalculatorCode.Location = new Point(12, 258);
         txtCalculatorCode.Margin = new Padding(4, 3, 4, 3);
         txtCalculatorCode.Name = "txtCalculatorCode";
         txtCalculatorCode.Size = new Size(458, 75);
         txtCalculatorCode.TabIndex = 5;
         txtCalculatorCode.TextChanged += txtCalculatorCode_TextChanged;
         // 
         // btnSendCalculatorCode
         // 
         btnSendCalculatorCode.Location = new Point(12, 377);
         btnSendCalculatorCode.Margin = new Padding(4, 3, 4, 3);
         btnSendCalculatorCode.Name = "btnSendCalculatorCode";
         btnSendCalculatorCode.Size = new Size(75, 24);
         btnSendCalculatorCode.TabIndex = 6;
         btnSendCalculatorCode.Text = "Send";
         btnSendCalculatorCode.Click += btnSendCalculatorCode_Click;
         // 
         // label2
         // 
         label2.Location = new Point(12, 344);
         label2.Margin = new Padding(4, 3, 4, 3);
         label2.Name = "label2";
         label2.Size = new Size(60, 17);
         label2.TabIndex = 7;
         label2.Text = "Parameter";
         // 
         // txtParameter
         // 
         txtParameter.Location = new Point(86, 341);
         txtParameter.Margin = new Padding(4, 3, 4, 3);
         txtParameter.Name = "txtParameter";
         txtParameter.Size = new Size(100, 24);
         txtParameter.TabIndex = 8;
         // 
         // gridLookUpEditAircraft
         // 
         gridLookUpEditAircraft.Location = new Point(13, 30);
         gridLookUpEditAircraft.Margin = new Padding(4, 3, 4, 3);
         gridLookUpEditAircraft.Name = "gridLookUpEditAircraft";
         gridLookUpEditAircraft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
         gridLookUpEditAircraft.Properties.PopupView = gridLookUpEdit1View;
         gridLookUpEditAircraft.Size = new Size(162, 24);
         gridLookUpEditAircraft.TabIndex = 9;
         gridLookUpEditAircraft.EditValueChanged += gridLookUpEditAircraft_EditValueChanged;
         // 
         // gridLookUpEdit1View
         // 
         gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
         gridLookUpEdit1View.Name = "gridLookUpEdit1View";
         gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
         gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
         // 
         // simAircraftBindingSource
         // 
         simAircraftBindingSource.DataSource = typeof(SimAircraft.SimAircraft);
         // 
         // PresetEventForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(512, 417);
         Controls.Add(gridLookUpEditAircraft);
         Controls.Add(txtParameter);
         Controls.Add(label2);
         Controls.Add(btnSendCalculatorCode);
         Controls.Add(txtCalculatorCode);
         Controls.Add(btnClearAircraft);
         Controls.Add(listPresets);
         Controls.Add(label1);
         Margin = new Padding(4, 3, 4, 3);
         Name = "PresetEventForm";
         ShowInTaskbar = false;
         StartPosition = FormStartPosition.CenterParent;
         Text = "PresetEventForm";
         ((System.ComponentModel.ISupportInitialize)txtCalculatorCode.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)txtParameter.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEditAircraft.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
         ((System.ComponentModel.ISupportInitialize)simAircraftBindingSource).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private LabelControl label1;
      private ListBox listPresets;
      private SimpleButton btnClearAircraft;
      private MemoEdit txtCalculatorCode;
      private SimpleButton btnSendCalculatorCode;
      private LabelControl label2;
      private TextEdit txtParameter;
      private GridLookUpEdit gridLookUpEditAircraft;
      private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
      private BindingSource simAircraftBindingSource;
   }
}