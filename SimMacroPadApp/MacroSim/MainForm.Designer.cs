namespace MacroSim
{
   partial class MainForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         txtOutput = new TextBox();
         toolStripContainer1 = new ToolStripContainer();
         statusStrip = new StatusStrip();
         lblSimConnectionStatus = new ToolStripStatusLabel();
         lblMacroPadState = new ToolStripStatusLabel();
         lblTransponder = new Label();
         label4 = new Label();
         lblVerticalSpeedValue = new Label();
         label7 = new Label();
         lblAltitudeValue = new Label();
         label5 = new Label();
         lblCourseValue = new Label();
         label3 = new Label();
         lblHeadingValue = new Label();
         groupNav2 = new GroupBox();
         lblNav2StandbyValue = new Label();
         lblNav2ActiveValue = new Label();
         lblNav2Standby = new Label();
         lblNav2Active = new Label();
         label2 = new Label();
         groupNav1 = new GroupBox();
         lblNav1StandbyValue = new Label();
         lblNav1ActiveValue = new Label();
         lblNav1Standby = new Label();
         lblNav1Active = new Label();
         groupCom2 = new GroupBox();
         lblCom2Standby = new Label();
         lblCom2StandbyValue = new Label();
         lblCom2ActiveValue = new Label();
         lblCom2Active = new Label();
         groupCom1 = new GroupBox();
         lblCom1StandbyValue = new Label();
         lblCom1ActiveValue = new Label();
         lblCom1Standby = new Label();
         lblCom1Active = new Label();
         mainMenu = new MenuStrip();
         appToolStripMenuItem = new ToolStripMenuItem();
         connectToSimToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator1 = new ToolStripSeparator();
         exitToolStripMenuItem = new ToolStripMenuItem();
         macroPadToolStripMenuItem = new ToolStripMenuItem();
         toolStripContainer1.BottomToolStripPanel.SuspendLayout();
         toolStripContainer1.ContentPanel.SuspendLayout();
         toolStripContainer1.TopToolStripPanel.SuspendLayout();
         toolStripContainer1.SuspendLayout();
         statusStrip.SuspendLayout();
         groupNav2.SuspendLayout();
         groupNav1.SuspendLayout();
         groupCom2.SuspendLayout();
         groupCom1.SuspendLayout();
         mainMenu.SuspendLayout();
         SuspendLayout();
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(465, 25);
         txtOutput.Multiline = true;
         txtOutput.Name = "txtOutput";
         txtOutput.ReadOnly = true;
         txtOutput.ScrollBars = ScrollBars.Vertical;
         txtOutput.Size = new Size(357, 426);
         txtOutput.TabIndex = 0;
         // 
         // toolStripContainer1
         // 
         // 
         // toolStripContainer1.BottomToolStripPanel
         // 
         toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip);
         // 
         // toolStripContainer1.ContentPanel
         // 
         toolStripContainer1.ContentPanel.Controls.Add(lblTransponder);
         toolStripContainer1.ContentPanel.Controls.Add(label4);
         toolStripContainer1.ContentPanel.Controls.Add(lblVerticalSpeedValue);
         toolStripContainer1.ContentPanel.Controls.Add(label7);
         toolStripContainer1.ContentPanel.Controls.Add(lblAltitudeValue);
         toolStripContainer1.ContentPanel.Controls.Add(label5);
         toolStripContainer1.ContentPanel.Controls.Add(lblCourseValue);
         toolStripContainer1.ContentPanel.Controls.Add(label3);
         toolStripContainer1.ContentPanel.Controls.Add(lblHeadingValue);
         toolStripContainer1.ContentPanel.Controls.Add(groupNav2);
         toolStripContainer1.ContentPanel.Controls.Add(label2);
         toolStripContainer1.ContentPanel.Controls.Add(groupNav1);
         toolStripContainer1.ContentPanel.Controls.Add(groupCom2);
         toolStripContainer1.ContentPanel.Controls.Add(groupCom1);
         toolStripContainer1.ContentPanel.Controls.Add(txtOutput);
         toolStripContainer1.ContentPanel.Size = new Size(852, 566);
         toolStripContainer1.Dock = DockStyle.Fill;
         toolStripContainer1.Location = new Point(0, 0);
         toolStripContainer1.Name = "toolStripContainer1";
         toolStripContainer1.Size = new Size(852, 613);
         toolStripContainer1.TabIndex = 1;
         toolStripContainer1.Text = "toolStripContainer1";
         // 
         // toolStripContainer1.TopToolStripPanel
         // 
         toolStripContainer1.TopToolStripPanel.Controls.Add(mainMenu);
         // 
         // statusStrip
         // 
         statusStrip.Dock = DockStyle.None;
         statusStrip.Items.AddRange(new ToolStripItem[] { lblSimConnectionStatus, lblMacroPadState });
         statusStrip.Location = new Point(0, 0);
         statusStrip.Name = "statusStrip";
         statusStrip.Size = new Size(852, 22);
         statusStrip.TabIndex = 0;
         // 
         // lblSimConnectionStatus
         // 
         lblSimConnectionStatus.AutoSize = false;
         lblSimConnectionStatus.Name = "lblSimConnectionStatus";
         lblSimConnectionStatus.Size = new Size(153, 17);
         lblSimConnectionStatus.Text = "Disconnected from Sim";
         lblSimConnectionStatus.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // lblMacroPadState
         // 
         lblMacroPadState.Name = "lblMacroPadState";
         lblMacroPadState.Size = new Size(45, 17);
         lblMacroPadState.Text = "NONE";
         // 
         // lblTransponder
         // 
         lblTransponder.AutoSize = true;
         lblTransponder.Font = new Font("Segoe UI", 21.75F);
         lblTransponder.Location = new Point(12, 522);
         lblTransponder.Name = "lblTransponder";
         lblTransponder.Size = new Size(81, 40);
         lblTransponder.TabIndex = 20;
         lblTransponder.Text = "0000";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(12, 502);
         label4.Name = "label4";
         label4.Size = new Size(82, 17);
         label4.TabIndex = 19;
         label4.Text = "Transponder";
         // 
         // lblVerticalSpeedValue
         // 
         lblVerticalSpeedValue.AutoSize = true;
         lblVerticalSpeedValue.Font = new Font("Segoe UI", 21.75F);
         lblVerticalSpeedValue.Location = new Point(159, 457);
         lblVerticalSpeedValue.Name = "lblVerticalSpeedValue";
         lblVerticalSpeedValue.Size = new Size(93, 40);
         lblVerticalSpeedValue.TabIndex = 18;
         lblVerticalSpeedValue.Text = "-0000";
         lblVerticalSpeedValue.TextAlign = ContentAlignment.TopRight;
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Location = new Point(159, 437);
         label7.Name = "label7";
         label7.Size = new Size(91, 17);
         label7.TabIndex = 17;
         label7.Text = "Vertical Speed";
         // 
         // lblAltitudeValue
         // 
         lblAltitudeValue.AutoSize = true;
         lblAltitudeValue.Font = new Font("Segoe UI", 21.75F);
         lblAltitudeValue.Location = new Point(12, 457);
         lblAltitudeValue.Name = "lblAltitudeValue";
         lblAltitudeValue.Size = new Size(97, 40);
         lblAltitudeValue.TabIndex = 16;
         lblAltitudeValue.Text = "00000";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Location = new Point(12, 437);
         label5.Name = "label5";
         label5.Size = new Size(52, 17);
         label5.TabIndex = 15;
         label5.Text = "Altitude";
         // 
         // lblCourseValue
         // 
         lblCourseValue.AutoSize = true;
         lblCourseValue.Font = new Font("Segoe UI", 21.75F);
         lblCourseValue.Location = new Point(159, 392);
         lblCourseValue.Name = "lblCourseValue";
         lblCourseValue.Size = new Size(65, 40);
         lblCourseValue.TabIndex = 14;
         lblCourseValue.Text = "000";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(159, 372);
         label3.Name = "label3";
         label3.Size = new Size(49, 17);
         label3.TabIndex = 13;
         label3.Text = "Course";
         // 
         // lblHeadingValue
         // 
         lblHeadingValue.AutoSize = true;
         lblHeadingValue.Font = new Font("Segoe UI", 21.75F);
         lblHeadingValue.Location = new Point(12, 392);
         lblHeadingValue.Name = "lblHeadingValue";
         lblHeadingValue.Size = new Size(65, 40);
         lblHeadingValue.TabIndex = 7;
         lblHeadingValue.Text = "000";
         // 
         // groupNav2
         // 
         groupNav2.Controls.Add(lblNav2StandbyValue);
         groupNav2.Controls.Add(lblNav2ActiveValue);
         groupNav2.Controls.Add(lblNav2Standby);
         groupNav2.Controls.Add(lblNav2Active);
         groupNav2.Location = new Point(3, 282);
         groupNav2.Name = "groupNav2";
         groupNav2.Size = new Size(275, 87);
         groupNav2.TabIndex = 12;
         groupNav2.TabStop = false;
         groupNav2.Text = "NAV 2";
         // 
         // lblNav2StandbyValue
         // 
         lblNav2StandbyValue.AutoSize = true;
         lblNav2StandbyValue.Font = new Font("Segoe UI", 21.75F);
         lblNav2StandbyValue.Location = new Point(6, 41);
         lblNav2StandbyValue.Name = "lblNav2StandbyValue";
         lblNav2StandbyValue.Size = new Size(103, 40);
         lblNav2StandbyValue.TabIndex = 4;
         lblNav2StandbyValue.Text = "000.00";
         // 
         // lblNav2ActiveValue
         // 
         lblNav2ActiveValue.AutoSize = true;
         lblNav2ActiveValue.Font = new Font("Segoe UI", 21.75F);
         lblNav2ActiveValue.Location = new Point(156, 41);
         lblNav2ActiveValue.Name = "lblNav2ActiveValue";
         lblNav2ActiveValue.Size = new Size(103, 40);
         lblNav2ActiveValue.TabIndex = 5;
         lblNav2ActiveValue.Text = "000.00";
         // 
         // lblNav2Standby
         // 
         lblNav2Standby.AutoSize = true;
         lblNav2Standby.Location = new Point(6, 21);
         lblNav2Standby.Name = "lblNav2Standby";
         lblNav2Standby.Size = new Size(55, 17);
         lblNav2Standby.TabIndex = 2;
         lblNav2Standby.Text = "Standby";
         // 
         // lblNav2Active
         // 
         lblNav2Active.AutoSize = true;
         lblNav2Active.Location = new Point(156, 21);
         lblNav2Active.Name = "lblNav2Active";
         lblNav2Active.Size = new Size(42, 17);
         lblNav2Active.TabIndex = 3;
         lblNav2Active.Text = "Active";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(12, 372);
         label2.Name = "label2";
         label2.Size = new Size(57, 17);
         label2.TabIndex = 6;
         label2.Text = "Heading";
         // 
         // groupNav1
         // 
         groupNav1.Controls.Add(lblNav1StandbyValue);
         groupNav1.Controls.Add(lblNav1ActiveValue);
         groupNav1.Controls.Add(lblNav1Standby);
         groupNav1.Controls.Add(lblNav1Active);
         groupNav1.Location = new Point(3, 189);
         groupNav1.Name = "groupNav1";
         groupNav1.Size = new Size(275, 87);
         groupNav1.TabIndex = 11;
         groupNav1.TabStop = false;
         groupNav1.Text = "NAV 1";
         // 
         // lblNav1StandbyValue
         // 
         lblNav1StandbyValue.AutoSize = true;
         lblNav1StandbyValue.Font = new Font("Segoe UI", 21.75F);
         lblNav1StandbyValue.Location = new Point(6, 41);
         lblNav1StandbyValue.Name = "lblNav1StandbyValue";
         lblNav1StandbyValue.Size = new Size(103, 40);
         lblNav1StandbyValue.TabIndex = 4;
         lblNav1StandbyValue.Text = "000.00";
         // 
         // lblNav1ActiveValue
         // 
         lblNav1ActiveValue.AutoSize = true;
         lblNav1ActiveValue.Font = new Font("Segoe UI", 21.75F);
         lblNav1ActiveValue.Location = new Point(156, 41);
         lblNav1ActiveValue.Name = "lblNav1ActiveValue";
         lblNav1ActiveValue.Size = new Size(103, 40);
         lblNav1ActiveValue.TabIndex = 5;
         lblNav1ActiveValue.Text = "000.00";
         // 
         // lblNav1Standby
         // 
         lblNav1Standby.AutoSize = true;
         lblNav1Standby.Location = new Point(6, 21);
         lblNav1Standby.Name = "lblNav1Standby";
         lblNav1Standby.Size = new Size(55, 17);
         lblNav1Standby.TabIndex = 2;
         lblNav1Standby.Text = "Standby";
         // 
         // lblNav1Active
         // 
         lblNav1Active.AutoSize = true;
         lblNav1Active.Location = new Point(156, 21);
         lblNav1Active.Name = "lblNav1Active";
         lblNav1Active.Size = new Size(42, 17);
         lblNav1Active.TabIndex = 3;
         lblNav1Active.Text = "Active";
         // 
         // groupCom2
         // 
         groupCom2.Controls.Add(lblCom2Standby);
         groupCom2.Controls.Add(lblCom2StandbyValue);
         groupCom2.Controls.Add(lblCom2ActiveValue);
         groupCom2.Controls.Add(lblCom2Active);
         groupCom2.Location = new Point(3, 96);
         groupCom2.Name = "groupCom2";
         groupCom2.Size = new Size(275, 87);
         groupCom2.TabIndex = 11;
         groupCom2.TabStop = false;
         groupCom2.Text = "COM 2";
         // 
         // lblCom2Standby
         // 
         lblCom2Standby.AutoSize = true;
         lblCom2Standby.Location = new Point(6, 21);
         lblCom2Standby.Name = "lblCom2Standby";
         lblCom2Standby.Size = new Size(55, 17);
         lblCom2Standby.TabIndex = 6;
         lblCom2Standby.Text = "Standby";
         // 
         // lblCom2StandbyValue
         // 
         lblCom2StandbyValue.AutoSize = true;
         lblCom2StandbyValue.Font = new Font("Segoe UI", 21.75F);
         lblCom2StandbyValue.Location = new Point(6, 38);
         lblCom2StandbyValue.Name = "lblCom2StandbyValue";
         lblCom2StandbyValue.Size = new Size(119, 40);
         lblCom2StandbyValue.TabIndex = 8;
         lblCom2StandbyValue.Text = "000.000";
         // 
         // lblCom2ActiveValue
         // 
         lblCom2ActiveValue.AutoSize = true;
         lblCom2ActiveValue.Font = new Font("Segoe UI", 21.75F);
         lblCom2ActiveValue.Location = new Point(156, 38);
         lblCom2ActiveValue.Name = "lblCom2ActiveValue";
         lblCom2ActiveValue.Size = new Size(119, 40);
         lblCom2ActiveValue.TabIndex = 9;
         lblCom2ActiveValue.Text = "000.000";
         // 
         // lblCom2Active
         // 
         lblCom2Active.AutoSize = true;
         lblCom2Active.Location = new Point(156, 21);
         lblCom2Active.Name = "lblCom2Active";
         lblCom2Active.Size = new Size(42, 17);
         lblCom2Active.TabIndex = 7;
         lblCom2Active.Text = "Active";
         // 
         // groupCom1
         // 
         groupCom1.Controls.Add(lblCom1StandbyValue);
         groupCom1.Controls.Add(lblCom1ActiveValue);
         groupCom1.Controls.Add(lblCom1Standby);
         groupCom1.Controls.Add(lblCom1Active);
         groupCom1.Location = new Point(3, 3);
         groupCom1.Name = "groupCom1";
         groupCom1.Size = new Size(275, 87);
         groupCom1.TabIndex = 10;
         groupCom1.TabStop = false;
         groupCom1.Text = "COM 1";
         // 
         // lblCom1StandbyValue
         // 
         lblCom1StandbyValue.AutoSize = true;
         lblCom1StandbyValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1StandbyValue.Location = new Point(6, 41);
         lblCom1StandbyValue.Name = "lblCom1StandbyValue";
         lblCom1StandbyValue.Size = new Size(119, 40);
         lblCom1StandbyValue.TabIndex = 4;
         lblCom1StandbyValue.Text = "000.000";
         // 
         // lblCom1ActiveValue
         // 
         lblCom1ActiveValue.AutoSize = true;
         lblCom1ActiveValue.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1ActiveValue.Location = new Point(156, 41);
         lblCom1ActiveValue.Name = "lblCom1ActiveValue";
         lblCom1ActiveValue.Size = new Size(119, 40);
         lblCom1ActiveValue.TabIndex = 5;
         lblCom1ActiveValue.Text = "000.000";
         // 
         // lblCom1Standby
         // 
         lblCom1Standby.AutoSize = true;
         lblCom1Standby.Location = new Point(6, 21);
         lblCom1Standby.Name = "lblCom1Standby";
         lblCom1Standby.Size = new Size(55, 17);
         lblCom1Standby.TabIndex = 2;
         lblCom1Standby.Text = "Standby";
         // 
         // lblCom1Active
         // 
         lblCom1Active.AutoSize = true;
         lblCom1Active.Location = new Point(156, 21);
         lblCom1Active.Name = "lblCom1Active";
         lblCom1Active.Size = new Size(42, 17);
         lblCom1Active.TabIndex = 3;
         lblCom1Active.Text = "Active";
         // 
         // mainMenu
         // 
         mainMenu.Dock = DockStyle.None;
         mainMenu.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, macroPadToolStripMenuItem });
         mainMenu.Location = new Point(0, 0);
         mainMenu.Name = "mainMenu";
         mainMenu.Size = new Size(852, 25);
         mainMenu.TabIndex = 0;
         mainMenu.Text = "menuStrip1";
         // 
         // appToolStripMenuItem
         // 
         appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToSimToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
         appToolStripMenuItem.Name = "appToolStripMenuItem";
         appToolStripMenuItem.Size = new Size(44, 21);
         appToolStripMenuItem.Text = "App";
         // 
         // connectToSimToolStripMenuItem
         // 
         connectToSimToolStripMenuItem.Name = "connectToSimToolStripMenuItem";
         connectToSimToolStripMenuItem.Size = new Size(164, 22);
         connectToSimToolStripMenuItem.Text = "Connect to Sim";
         connectToSimToolStripMenuItem.Click += ConnectToSimToolStripMenuItem_Click;
         // 
         // toolStripSeparator1
         // 
         toolStripSeparator1.Name = "toolStripSeparator1";
         toolStripSeparator1.Size = new Size(161, 6);
         // 
         // exitToolStripMenuItem
         // 
         exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         exitToolStripMenuItem.Size = new Size(164, 22);
         exitToolStripMenuItem.Text = "E&xit";
         exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
         // 
         // macroPadToolStripMenuItem
         // 
         macroPadToolStripMenuItem.Name = "macroPadToolStripMenuItem";
         macroPadToolStripMenuItem.Size = new Size(80, 21);
         macroPadToolStripMenuItem.Text = "MacroPad";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(852, 613);
         Controls.Add(toolStripContainer1);
         MainMenuStrip = mainMenu;
         Name = "MainForm";
         Text = "MainForm";
         toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
         toolStripContainer1.BottomToolStripPanel.PerformLayout();
         toolStripContainer1.ContentPanel.ResumeLayout(false);
         toolStripContainer1.ContentPanel.PerformLayout();
         toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
         toolStripContainer1.TopToolStripPanel.PerformLayout();
         toolStripContainer1.ResumeLayout(false);
         toolStripContainer1.PerformLayout();
         statusStrip.ResumeLayout(false);
         statusStrip.PerformLayout();
         groupNav2.ResumeLayout(false);
         groupNav2.PerformLayout();
         groupNav1.ResumeLayout(false);
         groupNav1.PerformLayout();
         groupCom2.ResumeLayout(false);
         groupCom2.PerformLayout();
         groupCom1.ResumeLayout(false);
         groupCom1.PerformLayout();
         mainMenu.ResumeLayout(false);
         mainMenu.PerformLayout();
         ResumeLayout(false);
      }

      #endregion

      private TextBox txtOutput;
      private ToolStripContainer toolStripContainer1;
      private MenuStrip mainMenu;
      private StatusStrip statusStrip;
      private ToolStripMenuItem appToolStripMenuItem;
      private ToolStripMenuItem exitToolStripMenuItem;
      private ToolStripMenuItem testToolStripMenuItem;
      private ToolStripStatusLabel lblSimConnectionStatus;
      private Label lblCom1Active;
      private Label lblCom1Standby;
      private Label lblCom1ActiveValue;
      private Label lblCom1StandbyValue;
      private Label lblCom2ActiveValue;
      private Label lblCom2StandbyValue;
      private Label lblCom2Active;
      private Label lblCom2Standby;
      private GroupBox groupCom1;
      private GroupBox groupCom2;
      private GroupBox groupNav1;
      private Label lblNav1StandbyValue;
      private Label lblNav1ActiveValue;
      private Label lblNav1Standby;
      private Label lblNav1Active;
      private GroupBox groupNav2;
      private Label lblNav2StandbyValue;
      private Label lblNav2ActiveValue;
      private Label lblNav2Standby;
      private Label lblNav2Active;
      private Label lblHeadingValue;
      private Label label2;
      private Label lblCourseValue;
      private Label label3;
      private Label lblVerticalSpeedValue;
      private Label label7;
      private Label lblAltitudeValue;
      private Label label5;
      private Label lblTransponder;
      private Label label4;
      private ToolStripMenuItem macroPadToolStripMenuItem;
      private ToolStripMenuItem connectToSimToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripStatusLabel lblMacroPadState;
   }
}
