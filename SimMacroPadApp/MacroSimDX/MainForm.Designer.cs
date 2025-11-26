namespace MacroSimDX
{
   partial class MainForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         barManager1 = new DevExpress.XtraBars.BarManager(components);
         bar1 = new DevExpress.XtraBars.Bar();
         bar2 = new DevExpress.XtraBars.Bar();
         bar3 = new DevExpress.XtraBars.Bar();
         barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         memoOutput = new DevExpress.XtraEditors.MemoEdit();
         btnSend = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)memoOutput.Properties).BeginInit();
         SuspendLayout();
         // 
         // barManager1
         // 
         barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2, bar3 });
         barManager1.DockControls.Add(barDockControlTop);
         barManager1.DockControls.Add(barDockControlBottom);
         barManager1.DockControls.Add(barDockControlLeft);
         barManager1.DockControls.Add(barDockControlRight);
         barManager1.Form = this;
         barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnSend });
         barManager1.MainMenu = bar2;
         barManager1.MaxItemId = 2;
         barManager1.StatusBar = bar3;
         // 
         // bar1
         // 
         bar1.BarName = "Tools";
         bar1.DockCol = 0;
         bar1.DockRow = 1;
         bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnSend) });
         bar1.Text = "Tools";
         // 
         // bar2
         // 
         bar2.BarName = "Main menu";
         bar2.DockCol = 0;
         bar2.DockRow = 0;
         bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         bar2.OptionsBar.MultiLine = true;
         bar2.OptionsBar.UseWholeRow = true;
         bar2.Text = "Main menu";
         // 
         // bar3
         // 
         bar3.BarName = "Status bar";
         bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         bar3.DockCol = 0;
         bar3.DockRow = 0;
         bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         bar3.OptionsBar.AllowQuickCustomization = false;
         bar3.OptionsBar.DrawDragBorder = false;
         bar3.OptionsBar.UseWholeRow = true;
         bar3.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         barDockControlTop.CausesValidation = false;
         barDockControlTop.Dock = DockStyle.Top;
         barDockControlTop.Location = new Point(0, 0);
         barDockControlTop.Manager = barManager1;
         barDockControlTop.Margin = new Padding(4, 4, 4, 4);
         barDockControlTop.Size = new Size(832, 48);
         // 
         // barDockControlBottom
         // 
         barDockControlBottom.CausesValidation = false;
         barDockControlBottom.Dock = DockStyle.Bottom;
         barDockControlBottom.Location = new Point(0, 558);
         barDockControlBottom.Manager = barManager1;
         barDockControlBottom.Margin = new Padding(4, 4, 4, 4);
         barDockControlBottom.Size = new Size(832, 18);
         // 
         // barDockControlLeft
         // 
         barDockControlLeft.CausesValidation = false;
         barDockControlLeft.Dock = DockStyle.Left;
         barDockControlLeft.Location = new Point(0, 48);
         barDockControlLeft.Manager = barManager1;
         barDockControlLeft.Margin = new Padding(4, 4, 4, 4);
         barDockControlLeft.Size = new Size(0, 510);
         // 
         // barDockControlRight
         // 
         barDockControlRight.CausesValidation = false;
         barDockControlRight.Dock = DockStyle.Right;
         barDockControlRight.Location = new Point(832, 48);
         barDockControlRight.Manager = barManager1;
         barDockControlRight.Margin = new Padding(4, 4, 4, 4);
         barDockControlRight.Size = new Size(0, 510);
         // 
         // memoOutput
         // 
         memoOutput.Location = new Point(84, 258);
         memoOutput.Margin = new Padding(4, 3, 4, 3);
         memoOutput.MenuManager = barManager1;
         memoOutput.Name = "memoOutput";
         memoOutput.Size = new Size(610, 273);
         memoOutput.TabIndex = 4;
         // 
         // btnSend
         // 
         btnSend.Caption = "Send";
         btnSend.Id = 1;
         btnSend.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
         btnSend.Name = "btnSend";
         btnSend.ItemClick += btnSend_ItemClick;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(832, 576);
         Controls.Add(memoOutput);
         Controls.Add(barDockControlLeft);
         Controls.Add(barDockControlRight);
         Controls.Add(barDockControlBottom);
         Controls.Add(barDockControlTop);
         Font = new Font("Segoe UI", 9.75F);
         Margin = new Padding(4, 4, 4, 4);
         Name = "MainForm";
         Text = "Form1";
         FormClosing += MainForm_FormClosing;
         Load += MainForm_Load;
         ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
         ((System.ComponentModel.ISupportInitialize)memoOutput.Properties).EndInit();
         ResumeLayout(false);
         PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraEditors.MemoEdit memoOutput;
      private DevExpress.XtraBars.BarButtonItem btnSend;
   }
}

