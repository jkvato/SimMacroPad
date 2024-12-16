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
         lblSimConnectStatus = new ToolStripStatusLabel();
         lblFsuipcStatus = new ToolStripStatusLabel();
         lblSerialPortStatus = new ToolStripStatusLabel();
         lblMacroPadState = new ToolStripStatusLabel();
         txtRudderTrimMax = new TextBox();
         txtRudderTrimPosition = new TextBox();
         txtRudderTrimDisabled = new TextBox();
         txtRudderTrimMin = new TextBox();
         txtAileronTrimMax = new TextBox();
         txtAileronTrimPosition = new TextBox();
         txtAileronTrimDisabled = new TextBox();
         txtAileronTrimMin = new TextBox();
         label9 = new Label();
         txtElevatorTrimMax = new TextBox();
         label8 = new Label();
         label6 = new Label();
         txtElevatorTrim = new TextBox();
         txtElevatorTrimNeutral = new TextBox();
         txtElevatorTrimMin = new TextBox();
         label1 = new Label();
         groupLights = new GroupBox();
         checkBeaconLight = new CheckBox();
         checkWingLight = new CheckBox();
         checkCabinLight = new CheckBox();
         checkTaxiLight = new CheckBox();
         checkGlareshieldLight = new CheckBox();
         checkStrobeLight = new CheckBox();
         checkLandingLight = new CheckBox();
         checkRecognitionLight = new CheckBox();
         checkLogoLight = new CheckBox();
         checkPedestralLight = new CheckBox();
         checkNavLight = new CheckBox();
         checkPanelLight = new CheckBox();
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
         simConnectToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator1 = new ToolStripSeparator();
         exitToolStripMenuItem = new ToolStripMenuItem();
         macroPadToolStripMenuItem = new ToolStripMenuItem();
         refreshSerialPortsToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator2 = new ToolStripSeparator();
         fsuipcConnectToolStripMenuItem = new ToolStripMenuItem();
         toolStripContainer1.BottomToolStripPanel.SuspendLayout();
         toolStripContainer1.ContentPanel.SuspendLayout();
         toolStripContainer1.TopToolStripPanel.SuspendLayout();
         toolStripContainer1.SuspendLayout();
         statusStrip.SuspendLayout();
         groupLights.SuspendLayout();
         groupNav2.SuspendLayout();
         groupNav1.SuspendLayout();
         groupCom2.SuspendLayout();
         groupCom1.SuspendLayout();
         mainMenu.SuspendLayout();
         SuspendLayout();
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(314, 21);
         txtOutput.Multiline = true;
         txtOutput.Name = "txtOutput";
         txtOutput.ReadOnly = true;
         txtOutput.ScrollBars = ScrollBars.Vertical;
         txtOutput.Size = new Size(357, 202);
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
         toolStripContainer1.ContentPanel.Controls.Add(txtRudderTrimMax);
         toolStripContainer1.ContentPanel.Controls.Add(txtRudderTrimPosition);
         toolStripContainer1.ContentPanel.Controls.Add(txtRudderTrimDisabled);
         toolStripContainer1.ContentPanel.Controls.Add(txtRudderTrimMin);
         toolStripContainer1.ContentPanel.Controls.Add(txtAileronTrimMax);
         toolStripContainer1.ContentPanel.Controls.Add(txtAileronTrimPosition);
         toolStripContainer1.ContentPanel.Controls.Add(txtAileronTrimDisabled);
         toolStripContainer1.ContentPanel.Controls.Add(txtAileronTrimMin);
         toolStripContainer1.ContentPanel.Controls.Add(label9);
         toolStripContainer1.ContentPanel.Controls.Add(txtElevatorTrimMax);
         toolStripContainer1.ContentPanel.Controls.Add(label8);
         toolStripContainer1.ContentPanel.Controls.Add(label6);
         toolStripContainer1.ContentPanel.Controls.Add(txtElevatorTrim);
         toolStripContainer1.ContentPanel.Controls.Add(txtElevatorTrimNeutral);
         toolStripContainer1.ContentPanel.Controls.Add(txtElevatorTrimMin);
         toolStripContainer1.ContentPanel.Controls.Add(label1);
         toolStripContainer1.ContentPanel.Controls.Add(groupLights);
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
         toolStripContainer1.ContentPanel.Size = new Size(1080, 566);
         toolStripContainer1.Dock = DockStyle.Fill;
         toolStripContainer1.Location = new Point(0, 0);
         toolStripContainer1.Name = "toolStripContainer1";
         toolStripContainer1.Size = new Size(1080, 613);
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
         statusStrip.Items.AddRange(new ToolStripItem[] { lblSimConnectStatus, lblFsuipcStatus, lblSerialPortStatus, lblMacroPadState });
         statusStrip.Location = new Point(0, 0);
         statusStrip.Name = "statusStrip";
         statusStrip.Size = new Size(1080, 22);
         statusStrip.TabIndex = 0;
         // 
         // lblSimConnectStatus
         // 
         lblSimConnectStatus.AutoSize = false;
         lblSimConnectStatus.Name = "lblSimConnectStatus";
         lblSimConnectStatus.Size = new Size(180, 17);
         lblSimConnectStatus.Text = "SimConnect: Disconnected";
         lblSimConnectStatus.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // lblFsuipcStatus
         // 
         lblFsuipcStatus.AutoSize = false;
         lblFsuipcStatus.Name = "lblFsuipcStatus";
         lblFsuipcStatus.Size = new Size(180, 17);
         lblFsuipcStatus.Text = "FSUIPC: Disconnected";
         lblFsuipcStatus.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // lblSerialPortStatus
         // 
         lblSerialPortStatus.AutoSize = false;
         lblSerialPortStatus.Name = "lblSerialPortStatus";
         lblSerialPortStatus.Size = new Size(180, 17);
         lblSerialPortStatus.Text = "Serial Port: Disconnected";
         lblSerialPortStatus.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // lblMacroPadState
         // 
         lblMacroPadState.Name = "lblMacroPadState";
         lblMacroPadState.Padding = new Padding(5, 0, 5, 0);
         lblMacroPadState.Size = new Size(55, 17);
         lblMacroPadState.Text = "NONE";
         // 
         // txtRudderTrimMax
         // 
         txtRudderTrimMax.Location = new Point(709, 371);
         txtRudderTrimMax.Name = "txtRudderTrimMax";
         txtRudderTrimMax.ReadOnly = true;
         txtRudderTrimMax.Size = new Size(100, 25);
         txtRudderTrimMax.TabIndex = 36;
         // 
         // txtRudderTrimPosition
         // 
         txtRudderTrimPosition.Location = new Point(709, 340);
         txtRudderTrimPosition.Name = "txtRudderTrimPosition";
         txtRudderTrimPosition.ReadOnly = true;
         txtRudderTrimPosition.Size = new Size(100, 25);
         txtRudderTrimPosition.TabIndex = 35;
         // 
         // txtRudderTrimDisabled
         // 
         txtRudderTrimDisabled.Location = new Point(709, 309);
         txtRudderTrimDisabled.Name = "txtRudderTrimDisabled";
         txtRudderTrimDisabled.ReadOnly = true;
         txtRudderTrimDisabled.Size = new Size(100, 25);
         txtRudderTrimDisabled.TabIndex = 34;
         // 
         // txtRudderTrimMin
         // 
         txtRudderTrimMin.Location = new Point(709, 278);
         txtRudderTrimMin.Name = "txtRudderTrimMin";
         txtRudderTrimMin.ReadOnly = true;
         txtRudderTrimMin.Size = new Size(100, 25);
         txtRudderTrimMin.TabIndex = 33;
         // 
         // txtAileronTrimMax
         // 
         txtAileronTrimMax.Location = new Point(603, 371);
         txtAileronTrimMax.Name = "txtAileronTrimMax";
         txtAileronTrimMax.ReadOnly = true;
         txtAileronTrimMax.Size = new Size(100, 25);
         txtAileronTrimMax.TabIndex = 32;
         // 
         // txtAileronTrimPosition
         // 
         txtAileronTrimPosition.Location = new Point(603, 340);
         txtAileronTrimPosition.Name = "txtAileronTrimPosition";
         txtAileronTrimPosition.ReadOnly = true;
         txtAileronTrimPosition.Size = new Size(100, 25);
         txtAileronTrimPosition.TabIndex = 31;
         // 
         // txtAileronTrimDisabled
         // 
         txtAileronTrimDisabled.Location = new Point(603, 309);
         txtAileronTrimDisabled.Name = "txtAileronTrimDisabled";
         txtAileronTrimDisabled.ReadOnly = true;
         txtAileronTrimDisabled.Size = new Size(100, 25);
         txtAileronTrimDisabled.TabIndex = 30;
         // 
         // txtAileronTrimMin
         // 
         txtAileronTrimMin.Location = new Point(603, 278);
         txtAileronTrimMin.Name = "txtAileronTrimMin";
         txtAileronTrimMin.ReadOnly = true;
         txtAileronTrimMin.Size = new Size(100, 25);
         txtAileronTrimMin.TabIndex = 29;
         // 
         // label9
         // 
         label9.AutoSize = true;
         label9.Location = new Point(342, 374);
         label9.Name = "label9";
         label9.Size = new Size(113, 17);
         label9.TabIndex = 28;
         label9.Text = "Elevator Trim Max";
         // 
         // txtElevatorTrimMax
         // 
         txtElevatorTrimMax.Location = new Point(483, 371);
         txtElevatorTrimMax.Name = "txtElevatorTrimMax";
         txtElevatorTrimMax.ReadOnly = true;
         txtElevatorTrimMax.Size = new Size(100, 25);
         txtElevatorTrimMax.TabIndex = 27;
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new Point(342, 312);
         label8.Name = "label8";
         label8.Size = new Size(131, 17);
         label8.TabIndex = 26;
         label8.Text = "Elevator Trim Neutral";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Location = new Point(342, 343);
         label6.Name = "label6";
         label6.Size = new Size(84, 17);
         label6.TabIndex = 25;
         label6.Text = "Elevator Trim";
         // 
         // txtElevatorTrim
         // 
         txtElevatorTrim.Location = new Point(483, 340);
         txtElevatorTrim.Name = "txtElevatorTrim";
         txtElevatorTrim.ReadOnly = true;
         txtElevatorTrim.Size = new Size(100, 25);
         txtElevatorTrim.TabIndex = 24;
         // 
         // txtElevatorTrimNeutral
         // 
         txtElevatorTrimNeutral.Location = new Point(483, 309);
         txtElevatorTrimNeutral.Name = "txtElevatorTrimNeutral";
         txtElevatorTrimNeutral.ReadOnly = true;
         txtElevatorTrimNeutral.Size = new Size(100, 25);
         txtElevatorTrimNeutral.TabIndex = 23;
         // 
         // txtElevatorTrimMin
         // 
         txtElevatorTrimMin.Location = new Point(483, 278);
         txtElevatorTrimMin.Name = "txtElevatorTrimMin";
         txtElevatorTrimMin.ReadOnly = true;
         txtElevatorTrimMin.Size = new Size(100, 25);
         txtElevatorTrimMin.TabIndex = 22;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(342, 281);
         label1.Name = "label1";
         label1.Size = new Size(110, 17);
         label1.TabIndex = 21;
         label1.Text = "Elevator Trim Min";
         // 
         // groupLights
         // 
         groupLights.Controls.Add(checkBeaconLight);
         groupLights.Controls.Add(checkWingLight);
         groupLights.Controls.Add(checkCabinLight);
         groupLights.Controls.Add(checkTaxiLight);
         groupLights.Controls.Add(checkGlareshieldLight);
         groupLights.Controls.Add(checkStrobeLight);
         groupLights.Controls.Add(checkLandingLight);
         groupLights.Controls.Add(checkRecognitionLight);
         groupLights.Controls.Add(checkLogoLight);
         groupLights.Controls.Add(checkPedestralLight);
         groupLights.Controls.Add(checkNavLight);
         groupLights.Controls.Add(checkPanelLight);
         groupLights.Location = new Point(308, 470);
         groupLights.Name = "groupLights";
         groupLights.Size = new Size(396, 92);
         groupLights.TabIndex = 2;
         groupLights.TabStop = false;
         groupLights.Text = "Lights";
         // 
         // checkBeaconLight
         // 
         checkBeaconLight.Appearance = Appearance.Button;
         checkBeaconLight.AutoSize = true;
         checkBeaconLight.Location = new Point(6, 24);
         checkBeaconLight.Name = "checkBeaconLight";
         checkBeaconLight.Size = new Size(60, 27);
         checkBeaconLight.TabIndex = 2;
         checkBeaconLight.Text = "Beacon";
         checkBeaconLight.UseVisualStyleBackColor = true;
         checkBeaconLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkWingLight
         // 
         checkWingLight.Appearance = Appearance.Button;
         checkWingLight.AutoSize = true;
         checkWingLight.Location = new Point(341, 57);
         checkWingLight.Name = "checkWingLight";
         checkWingLight.Size = new Size(48, 27);
         checkWingLight.TabIndex = 44;
         checkWingLight.Text = "Wing";
         checkWingLight.UseVisualStyleBackColor = true;
         checkWingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkCabinLight
         // 
         checkCabinLight.Appearance = Appearance.Button;
         checkCabinLight.AutoSize = true;
         checkCabinLight.Location = new Point(72, 24);
         checkCabinLight.Name = "checkCabinLight";
         checkCabinLight.Size = new Size(51, 27);
         checkCabinLight.TabIndex = 34;
         checkCabinLight.Text = "Cabin";
         checkCabinLight.UseVisualStyleBackColor = true;
         checkCabinLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkTaxiLight
         // 
         checkTaxiLight.Appearance = Appearance.Button;
         checkTaxiLight.AutoSize = true;
         checkTaxiLight.Location = new Point(295, 57);
         checkTaxiLight.Name = "checkTaxiLight";
         checkTaxiLight.Size = new Size(40, 27);
         checkTaxiLight.TabIndex = 43;
         checkTaxiLight.Text = "Taxi";
         checkTaxiLight.UseVisualStyleBackColor = true;
         checkTaxiLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkGlareshieldLight
         // 
         checkGlareshieldLight.Appearance = Appearance.Button;
         checkGlareshieldLight.AutoSize = true;
         checkGlareshieldLight.Location = new Point(129, 24);
         checkGlareshieldLight.Name = "checkGlareshieldLight";
         checkGlareshieldLight.Size = new Size(83, 27);
         checkGlareshieldLight.TabIndex = 35;
         checkGlareshieldLight.Text = "Glareshield";
         checkGlareshieldLight.UseVisualStyleBackColor = true;
         checkGlareshieldLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkStrobeLight
         // 
         checkStrobeLight.Appearance = Appearance.Button;
         checkStrobeLight.AutoSize = true;
         checkStrobeLight.Location = new Point(232, 57);
         checkStrobeLight.Name = "checkStrobeLight";
         checkStrobeLight.Size = new Size(57, 27);
         checkStrobeLight.TabIndex = 42;
         checkStrobeLight.Text = "Strobe";
         checkStrobeLight.UseVisualStyleBackColor = true;
         checkStrobeLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLandingLight
         // 
         checkLandingLight.Appearance = Appearance.Button;
         checkLandingLight.AutoSize = true;
         checkLandingLight.Location = new Point(218, 24);
         checkLandingLight.Name = "checkLandingLight";
         checkLandingLight.Size = new Size(64, 27);
         checkLandingLight.TabIndex = 36;
         checkLandingLight.Text = "Landing";
         checkLandingLight.UseVisualStyleBackColor = true;
         checkLandingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkRecognitionLight
         // 
         checkRecognitionLight.Appearance = Appearance.Button;
         checkRecognitionLight.AutoSize = true;
         checkRecognitionLight.Location = new Point(139, 57);
         checkRecognitionLight.Name = "checkRecognitionLight";
         checkRecognitionLight.Size = new Size(87, 27);
         checkRecognitionLight.TabIndex = 41;
         checkRecognitionLight.Text = "Recognition";
         checkRecognitionLight.UseVisualStyleBackColor = true;
         checkRecognitionLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLogoLight
         // 
         checkLogoLight.Appearance = Appearance.Button;
         checkLogoLight.AutoSize = true;
         checkLogoLight.Location = new Point(288, 24);
         checkLogoLight.Name = "checkLogoLight";
         checkLogoLight.Size = new Size(48, 27);
         checkLogoLight.TabIndex = 37;
         checkLogoLight.Text = "Logo";
         checkLogoLight.UseVisualStyleBackColor = true;
         checkLogoLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPedestralLight
         // 
         checkPedestralLight.Appearance = Appearance.Button;
         checkPedestralLight.AutoSize = true;
         checkPedestralLight.Location = new Point(61, 57);
         checkPedestralLight.Name = "checkPedestralLight";
         checkPedestralLight.Size = new Size(72, 27);
         checkPedestralLight.TabIndex = 40;
         checkPedestralLight.Text = "Pedestral";
         checkPedestralLight.UseVisualStyleBackColor = true;
         checkPedestralLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkNavLight
         // 
         checkNavLight.Appearance = Appearance.Button;
         checkNavLight.AutoSize = true;
         checkNavLight.Location = new Point(342, 24);
         checkNavLight.Name = "checkNavLight";
         checkNavLight.Size = new Size(41, 27);
         checkNavLight.TabIndex = 38;
         checkNavLight.Text = "Nav";
         checkNavLight.UseVisualStyleBackColor = true;
         checkNavLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPanelLight
         // 
         checkPanelLight.Appearance = Appearance.Button;
         checkPanelLight.AutoSize = true;
         checkPanelLight.Location = new Point(6, 57);
         checkPanelLight.Name = "checkPanelLight";
         checkPanelLight.Size = new Size(49, 27);
         checkPanelLight.TabIndex = 39;
         checkPanelLight.Text = "Panel";
         checkPanelLight.UseVisualStyleBackColor = true;
         checkPanelLight.CheckedChanged += LightButton_CheckedChanged;
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
         mainMenu.Size = new Size(1080, 25);
         mainMenu.TabIndex = 0;
         mainMenu.Text = "menuStrip1";
         // 
         // appToolStripMenuItem
         // 
         appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simConnectToolStripMenuItem, fsuipcConnectToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
         appToolStripMenuItem.Name = "appToolStripMenuItem";
         appToolStripMenuItem.Size = new Size(44, 21);
         appToolStripMenuItem.Text = "App";
         // 
         // simConnectToolStripMenuItem
         // 
         simConnectToolStripMenuItem.Name = "simConnectToolStripMenuItem";
         simConnectToolStripMenuItem.Size = new Size(195, 22);
         simConnectToolStripMenuItem.Text = "Connect SimConnect";
         simConnectToolStripMenuItem.Click += ConnectToSimToolStripMenuItem_Click;
         // 
         // toolStripSeparator1
         // 
         toolStripSeparator1.Name = "toolStripSeparator1";
         toolStripSeparator1.Size = new Size(192, 6);
         // 
         // exitToolStripMenuItem
         // 
         exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         exitToolStripMenuItem.Size = new Size(195, 22);
         exitToolStripMenuItem.Text = "E&xit";
         exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
         // 
         // macroPadToolStripMenuItem
         // 
         macroPadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshSerialPortsToolStripMenuItem, toolStripSeparator2 });
         macroPadToolStripMenuItem.Name = "macroPadToolStripMenuItem";
         macroPadToolStripMenuItem.Size = new Size(80, 21);
         macroPadToolStripMenuItem.Text = "MacroPad";
         // 
         // refreshSerialPortsToolStripMenuItem
         // 
         refreshSerialPortsToolStripMenuItem.Name = "refreshSerialPortsToolStripMenuItem";
         refreshSerialPortsToolStripMenuItem.Size = new Size(190, 22);
         refreshSerialPortsToolStripMenuItem.Text = "Refresh Serial Ports";
         refreshSerialPortsToolStripMenuItem.Click += RefreshSerialPortsToolStripMenuItem_Click;
         // 
         // toolStripSeparator2
         // 
         toolStripSeparator2.Name = "toolStripSeparator2";
         toolStripSeparator2.Size = new Size(187, 6);
         // 
         // fsuipcConnectToolStripMenuItem
         // 
         fsuipcConnectToolStripMenuItem.Name = "fsuipcConnectToolStripMenuItem";
         fsuipcConnectToolStripMenuItem.Size = new Size(195, 22);
         fsuipcConnectToolStripMenuItem.Text = "Connect FSUIPC";
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1080, 613);
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
         groupLights.ResumeLayout(false);
         groupLights.PerformLayout();
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
      private ToolStripStatusLabel lblSimConnectStatus;
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
      private ToolStripMenuItem simConnectToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripStatusLabel lblMacroPadState;
      private ToolStripStatusLabel lblSerialPortStatus;
      private CheckBox checkGlareshieldLight;
      private CheckBox checkCabinLight;
      private CheckBox checkBeaconLight;
      private CheckBox checkWingLight;
      private CheckBox checkTaxiLight;
      private CheckBox checkStrobeLight;
      private CheckBox checkRecognitionLight;
      private CheckBox checkPedestralLight;
      private CheckBox checkPanelLight;
      private CheckBox checkNavLight;
      private CheckBox checkLogoLight;
      private CheckBox checkLandingLight;
      private ToolStripMenuItem refreshSerialPortsToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator2;
      private GroupBox groupLights;
      private Label label9;
      private TextBox txtElevatorTrimMax;
      private Label label8;
      private Label label6;
      private TextBox txtElevatorTrim;
      private TextBox txtElevatorTrimNeutral;
      private TextBox txtElevatorTrimMin;
      private Label label1;
      private TextBox txtAileronTrimMax;
      private TextBox txtAileronTrimPosition;
      private TextBox txtAileronTrimDisabled;
      private TextBox txtAileronTrimMin;
      private TextBox txtRudderTrimMax;
      private TextBox txtRudderTrimPosition;
      private TextBox txtRudderTrimDisabled;
      private TextBox txtRudderTrimMin;
      private ToolStripStatusLabel lblFsuipcStatus;
      private ToolStripMenuItem fsuipcConnectToolStripMenuItem;
   }
}
