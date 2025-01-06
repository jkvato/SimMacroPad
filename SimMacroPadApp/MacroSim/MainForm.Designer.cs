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
         components = new System.ComponentModel.Container();
         toolStripContainer1 = new ToolStripContainer();
         statusStrip = new StatusStrip();
         lblSimConnectStatus = new ToolStripStatusLabel();
         lblFsuipcStatus = new ToolStripStatusLabel();
         lblSerialPortStatus = new ToolStripStatusLabel();
         lblMacroPadState = new ToolStripStatusLabel();
         lblLocalTime = new ToolStripStatusLabel();
         label8 = new Label();
         btnPreviousSmartcam = new Button();
         btnNextSmartcam = new Button();
         checkSmartcam = new CheckBox();
         lblSCTargetDesc = new Label();
         lblSCTargetType = new Label();
         trackFlaps = new TrackBar();
         checkCustomCameraState = new CheckBox();
         checkShowcaseFixedSubState = new CheckBox();
         lblEngineTorquePct = new Label();
         checkShowcaseDroneSubState = new CheckBox();
         checkCamera9 = new CheckBox();
         lblEngineNPRpm = new Label();
         checkCamera8 = new CheckBox();
         checkExternalQuickViewSubState = new CheckBox();
         checkCamera7 = new CheckBox();
         lblEngineNGPct = new Label();
         checkCamera6 = new CheckBox();
         checkExternalDefaultSubState = new CheckBox();
         checkCamera5 = new CheckBox();
         lblEngineITT = new Label();
         checkCamera4 = new CheckBox();
         checkCockpitQuickViewSubState = new CheckBox();
         checkCamera3 = new CheckBox();
         lblEngineTorque = new Label();
         checkCamera2 = new CheckBox();
         checkCockpitInstrumentSubState = new CheckBox();
         checkCamera1 = new CheckBox();
         lblFlapsCurrentPosition = new Label();
         checkCamera10 = new CheckBox();
         checkCockpitPilotSubState = new CheckBox();
         lblFlapsNumberOfDetents = new Label();
         lblIndex1 = new Label();
         btnPreviousSubView = new Button();
         lblIndex0 = new Label();
         lblCurrentFlapsLimit = new Label();
         lblCameraSubstate = new Label();
         btnNextSubView = new Button();
         lblCameraState = new Label();
         lblTrailingFlapsRight = new Label();
         btnPreviousView = new Button();
         lblTrailingFlapsLeft = new Label();
         btnNextView = new Button();
         lblAileronTrimPct = new Label();
         lblRudderTrimPct = new Label();
         lblElevatorTrimPct = new Label();
         btnSetCamera = new Button();
         txtCameraIndex1 = new TextBox();
         txtCameraIndex0 = new TextBox();
         txtCameraSubState = new TextBox();
         txtCameraState = new TextBox();
         groupBox1 = new GroupBox();
         btnSimRateReset = new Button();
         btnSimRateDec = new Button();
         btnSimRateInc = new Button();
         lblSimRate = new Label();
         lblCurrentCameraType = new Label();
         txtOutput = new TextBox();
         groupCameras = new GroupBox();
         checkCameraPilotCoPilot = new CheckBox();
         checkCameraPilotLand = new CheckBox();
         checkCameraPilotClose = new CheckBox();
         checkCameraPilotNormal = new CheckBox();
         lblCameraCurrentView = new Label();
         groupFuel = new GroupBox();
         lblFuelDumpSwitch = new Label();
         btnFuelDump = new Button();
         lblTotalFuelPct = new Label();
         btnAddFuel = new Button();
         groupPause = new GroupBox();
         btnPauseSim = new Button();
         checkPauseEsc = new CheckBox();
         checkPauseSim = new CheckBox();
         checkPauseActive = new CheckBox();
         checkPauseFull = new CheckBox();
         btnPauseFull = new Button();
         groupFms = new GroupBox();
         btnFmsMfdInner = new Button();
         btnFmsMfdOuter = new Button();
         btnFmsEnt = new Button();
         btnFmsClr = new Button();
         btnFmsMenu = new Button();
         btnFmsProc = new Button();
         btnFmsFpl = new Button();
         btnFmsDirect = new Button();
         btnFmsPfdInner = new Button();
         btnFmsPfdOuter = new Button();
         groupAutopilot = new GroupBox();
         btnCrs2Sel = new Button();
         checkApSpd = new CheckBox();
         checkApFlc = new CheckBox();
         btnNoseUpDn = new Button();
         checkApVnv = new CheckBox();
         checkApVsHold = new CheckBox();
         btnAltSel = new Button();
         checkApAltHold = new CheckBox();
         checkApYd = new CheckBox();
         checkApFd = new CheckBox();
         checkApMaster = new CheckBox();
         btnCrs1Sel = new Button();
         btnHdgSel = new Button();
         checkApBcHold = new CheckBox();
         checkApAprHold = new CheckBox();
         checkApNavHold = new CheckBox();
         checkApHdgHold = new CheckBox();
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
         fsuipcConnectToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator1 = new ToolStripSeparator();
         exitToolStripMenuItem = new ToolStripMenuItem();
         macroPadToolStripMenuItem = new ToolStripMenuItem();
         refreshSerialPortsToolStripMenuItem = new ToolStripMenuItem();
         toolStripSeparator2 = new ToolStripSeparator();
         utilityToolStripMenuItem = new ToolStripMenuItem();
         presetEventsToolStripMenuItem = new ToolStripMenuItem();
         toolTip1 = new ToolTip(components);
         toolStripContainer1.BottomToolStripPanel.SuspendLayout();
         toolStripContainer1.ContentPanel.SuspendLayout();
         toolStripContainer1.TopToolStripPanel.SuspendLayout();
         toolStripContainer1.SuspendLayout();
         statusStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)trackFlaps).BeginInit();
         groupBox1.SuspendLayout();
         groupCameras.SuspendLayout();
         groupFuel.SuspendLayout();
         groupPause.SuspendLayout();
         groupFms.SuspendLayout();
         groupAutopilot.SuspendLayout();
         groupLights.SuspendLayout();
         groupNav2.SuspendLayout();
         groupNav1.SuspendLayout();
         groupCom2.SuspendLayout();
         groupCom1.SuspendLayout();
         mainMenu.SuspendLayout();
         SuspendLayout();
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
         toolStripContainer1.ContentPanel.Controls.Add(label8);
         toolStripContainer1.ContentPanel.Controls.Add(btnPreviousSmartcam);
         toolStripContainer1.ContentPanel.Controls.Add(btnNextSmartcam);
         toolStripContainer1.ContentPanel.Controls.Add(checkSmartcam);
         toolStripContainer1.ContentPanel.Controls.Add(lblSCTargetDesc);
         toolStripContainer1.ContentPanel.Controls.Add(lblSCTargetType);
         toolStripContainer1.ContentPanel.Controls.Add(trackFlaps);
         toolStripContainer1.ContentPanel.Controls.Add(checkCustomCameraState);
         toolStripContainer1.ContentPanel.Controls.Add(checkShowcaseFixedSubState);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngineTorquePct);
         toolStripContainer1.ContentPanel.Controls.Add(checkShowcaseDroneSubState);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera9);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngineNPRpm);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera8);
         toolStripContainer1.ContentPanel.Controls.Add(checkExternalQuickViewSubState);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera7);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngineNGPct);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera6);
         toolStripContainer1.ContentPanel.Controls.Add(checkExternalDefaultSubState);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera5);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngineITT);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera4);
         toolStripContainer1.ContentPanel.Controls.Add(checkCockpitQuickViewSubState);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera3);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngineTorque);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera2);
         toolStripContainer1.ContentPanel.Controls.Add(checkCockpitInstrumentSubState);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera1);
         toolStripContainer1.ContentPanel.Controls.Add(lblFlapsCurrentPosition);
         toolStripContainer1.ContentPanel.Controls.Add(checkCamera10);
         toolStripContainer1.ContentPanel.Controls.Add(checkCockpitPilotSubState);
         toolStripContainer1.ContentPanel.Controls.Add(lblFlapsNumberOfDetents);
         toolStripContainer1.ContentPanel.Controls.Add(lblIndex1);
         toolStripContainer1.ContentPanel.Controls.Add(btnPreviousSubView);
         toolStripContainer1.ContentPanel.Controls.Add(lblIndex0);
         toolStripContainer1.ContentPanel.Controls.Add(lblCurrentFlapsLimit);
         toolStripContainer1.ContentPanel.Controls.Add(lblCameraSubstate);
         toolStripContainer1.ContentPanel.Controls.Add(btnNextSubView);
         toolStripContainer1.ContentPanel.Controls.Add(lblCameraState);
         toolStripContainer1.ContentPanel.Controls.Add(lblTrailingFlapsRight);
         toolStripContainer1.ContentPanel.Controls.Add(btnPreviousView);
         toolStripContainer1.ContentPanel.Controls.Add(lblTrailingFlapsLeft);
         toolStripContainer1.ContentPanel.Controls.Add(btnNextView);
         toolStripContainer1.ContentPanel.Controls.Add(lblAileronTrimPct);
         toolStripContainer1.ContentPanel.Controls.Add(lblRudderTrimPct);
         toolStripContainer1.ContentPanel.Controls.Add(lblElevatorTrimPct);
         toolStripContainer1.ContentPanel.Controls.Add(btnSetCamera);
         toolStripContainer1.ContentPanel.Controls.Add(txtCameraIndex1);
         toolStripContainer1.ContentPanel.Controls.Add(txtCameraIndex0);
         toolStripContainer1.ContentPanel.Controls.Add(txtCameraSubState);
         toolStripContainer1.ContentPanel.Controls.Add(txtCameraState);
         toolStripContainer1.ContentPanel.Controls.Add(groupBox1);
         toolStripContainer1.ContentPanel.Controls.Add(lblCurrentCameraType);
         toolStripContainer1.ContentPanel.Controls.Add(txtOutput);
         toolStripContainer1.ContentPanel.Controls.Add(groupCameras);
         toolStripContainer1.ContentPanel.Controls.Add(groupFuel);
         toolStripContainer1.ContentPanel.Controls.Add(groupPause);
         toolStripContainer1.ContentPanel.Controls.Add(groupFms);
         toolStripContainer1.ContentPanel.Controls.Add(groupAutopilot);
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
         toolStripContainer1.ContentPanel.Size = new Size(1133, 673);
         toolStripContainer1.Dock = DockStyle.Fill;
         toolStripContainer1.Location = new Point(0, 0);
         toolStripContainer1.Name = "toolStripContainer1";
         toolStripContainer1.Size = new Size(1133, 720);
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
         statusStrip.Items.AddRange(new ToolStripItem[] { lblSimConnectStatus, lblFsuipcStatus, lblSerialPortStatus, lblMacroPadState, lblLocalTime });
         statusStrip.Location = new Point(0, 0);
         statusStrip.Name = "statusStrip";
         statusStrip.Size = new Size(1133, 22);
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
         // lblLocalTime
         // 
         lblLocalTime.Name = "lblLocalTime";
         lblLocalTime.Size = new Size(77, 17);
         lblLocalTime.Text = "Local Time: ";
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Location = new Point(709, 366);
         label8.Name = "label8";
         label8.Size = new Size(43, 17);
         label8.TabIndex = 173;
         label8.Text = "label8";
         // 
         // btnPreviousSmartcam
         // 
         btnPreviousSmartcam.Location = new Point(820, 438);
         btnPreviousSmartcam.Name = "btnPreviousSmartcam";
         btnPreviousSmartcam.Size = new Size(42, 27);
         btnPreviousSmartcam.TabIndex = 172;
         btnPreviousSmartcam.Text = "SC-";
         btnPreviousSmartcam.UseVisualStyleBackColor = true;
         btnPreviousSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // btnNextSmartcam
         // 
         btnNextSmartcam.Location = new Point(820, 405);
         btnNextSmartcam.Name = "btnNextSmartcam";
         btnNextSmartcam.Size = new Size(42, 27);
         btnNextSmartcam.TabIndex = 171;
         btnNextSmartcam.Text = "SC+";
         btnNextSmartcam.UseVisualStyleBackColor = true;
         btnNextSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // checkSmartcam
         // 
         checkSmartcam.Appearance = Appearance.Button;
         checkSmartcam.Location = new Point(820, 372);
         checkSmartcam.Name = "checkSmartcam";
         checkSmartcam.Size = new Size(60, 27);
         checkSmartcam.TabIndex = 170;
         checkSmartcam.Text = "SC";
         checkSmartcam.TextAlign = ContentAlignment.MiddleCenter;
         checkSmartcam.UseVisualStyleBackColor = true;
         checkSmartcam.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblSCTargetDesc
         // 
         lblSCTargetDesc.AutoSize = true;
         lblSCTargetDesc.Location = new Point(413, 372);
         lblSCTargetDesc.Name = "lblSCTargetDesc";
         lblSCTargetDesc.Size = new Size(96, 17);
         lblSCTargetDesc.TabIndex = 169;
         lblSCTargetDesc.Text = "SC Target Desc";
         // 
         // lblSCTargetType
         // 
         lblSCTargetType.AutoSize = true;
         lblSCTargetType.Location = new Point(413, 352);
         lblSCTargetType.Name = "lblSCTargetType";
         lblSCTargetType.Size = new Size(95, 17);
         lblSCTargetType.TabIndex = 168;
         lblSCTargetType.Text = "SC Target Type";
         // 
         // trackFlaps
         // 
         trackFlaps.Location = new Point(769, 398);
         trackFlaps.Name = "trackFlaps";
         trackFlaps.Orientation = Orientation.Vertical;
         trackFlaps.Size = new Size(45, 205);
         trackFlaps.TabIndex = 167;
         trackFlaps.ValueChanged += TrackFlaps_ValueChanged;
         // 
         // checkCustomCameraState
         // 
         checkCustomCameraState.Appearance = Appearance.Button;
         checkCustomCameraState.Location = new Point(1003, 603);
         checkCustomCameraState.Name = "checkCustomCameraState";
         checkCustomCameraState.Size = new Size(60, 27);
         checkCustomCameraState.TabIndex = 80;
         checkCustomCameraState.Text = "Custom";
         checkCustomCameraState.TextAlign = ContentAlignment.MiddleCenter;
         checkCustomCameraState.UseVisualStyleBackColor = true;
         checkCustomCameraState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkShowcaseFixedSubState
         // 
         checkShowcaseFixedSubState.Appearance = Appearance.Button;
         checkShowcaseFixedSubState.Location = new Point(1003, 570);
         checkShowcaseFixedSubState.Name = "checkShowcaseFixedSubState";
         checkShowcaseFixedSubState.Size = new Size(60, 27);
         checkShowcaseFixedSubState.TabIndex = 74;
         checkShowcaseFixedSubState.Text = "X-Fixed";
         checkShowcaseFixedSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkShowcaseFixedSubState.UseVisualStyleBackColor = true;
         checkShowcaseFixedSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineTorquePct
         // 
         lblEngineTorquePct.AutoSize = true;
         lblEngineTorquePct.Location = new Point(413, 315);
         lblEngineTorquePct.Name = "lblEngineTorquePct";
         lblEngineTorquePct.Size = new Size(48, 17);
         lblEngineTorquePct.TabIndex = 79;
         lblEngineTorquePct.Text = "TRQ %";
         // 
         // checkShowcaseDroneSubState
         // 
         checkShowcaseDroneSubState.Appearance = Appearance.Button;
         checkShowcaseDroneSubState.Location = new Point(1003, 537);
         checkShowcaseDroneSubState.Name = "checkShowcaseDroneSubState";
         checkShowcaseDroneSubState.Size = new Size(60, 27);
         checkShowcaseDroneSubState.TabIndex = 73;
         checkShowcaseDroneSubState.Text = "Drone";
         checkShowcaseDroneSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkShowcaseDroneSubState.UseVisualStyleBackColor = true;
         checkShowcaseDroneSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera9
         // 
         checkCamera9.Appearance = Appearance.Button;
         checkCamera9.Location = new Point(960, 470);
         checkCamera9.Name = "checkCamera9";
         checkCamera9.Size = new Size(30, 27);
         checkCamera9.TabIndex = 52;
         checkCamera9.Tag = "9";
         checkCamera9.Text = "9";
         checkCamera9.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera9.UseVisualStyleBackColor = true;
         checkCamera9.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineNPRpm
         // 
         lblEngineNPRpm.AutoSize = true;
         lblEngineNPRpm.Location = new Point(294, 366);
         lblEngineNPRpm.Name = "lblEngineNPRpm";
         lblEngineNPRpm.Size = new Size(56, 17);
         lblEngineNPRpm.TabIndex = 78;
         lblEngineNPRpm.Text = "NP RPM";
         // 
         // checkCamera8
         // 
         checkCamera8.Appearance = Appearance.Button;
         checkCamera8.Location = new Point(924, 470);
         checkCamera8.Name = "checkCamera8";
         checkCamera8.Size = new Size(30, 27);
         checkCamera8.TabIndex = 51;
         checkCamera8.Tag = "8";
         checkCamera8.Text = "8";
         checkCamera8.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera8.UseVisualStyleBackColor = true;
         checkCamera8.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkExternalQuickViewSubState
         // 
         checkExternalQuickViewSubState.Appearance = Appearance.Button;
         checkExternalQuickViewSubState.Location = new Point(1003, 504);
         checkExternalQuickViewSubState.Name = "checkExternalQuickViewSubState";
         checkExternalQuickViewSubState.Size = new Size(60, 27);
         checkExternalQuickViewSubState.TabIndex = 72;
         checkExternalQuickViewSubState.Text = "X-QV";
         checkExternalQuickViewSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkExternalQuickViewSubState.UseVisualStyleBackColor = true;
         checkExternalQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera7
         // 
         checkCamera7.Appearance = Appearance.Button;
         checkCamera7.Location = new Point(888, 471);
         checkCamera7.Name = "checkCamera7";
         checkCamera7.Size = new Size(30, 27);
         checkCamera7.TabIndex = 50;
         checkCamera7.Tag = "7";
         checkCamera7.Text = "7";
         checkCamera7.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera7.UseVisualStyleBackColor = true;
         checkCamera7.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineNGPct
         // 
         lblEngineNGPct.AutoSize = true;
         lblEngineNGPct.Location = new Point(294, 349);
         lblEngineNGPct.Name = "lblEngineNGPct";
         lblEngineNGPct.Size = new Size(42, 17);
         lblEngineNGPct.TabIndex = 77;
         lblEngineNGPct.Text = "NG %";
         // 
         // checkCamera6
         // 
         checkCamera6.Appearance = Appearance.Button;
         checkCamera6.Location = new Point(960, 504);
         checkCamera6.Name = "checkCamera6";
         checkCamera6.Size = new Size(30, 27);
         checkCamera6.TabIndex = 49;
         checkCamera6.Tag = "6";
         checkCamera6.Text = "6";
         checkCamera6.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera6.UseVisualStyleBackColor = true;
         checkCamera6.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkExternalDefaultSubState
         // 
         checkExternalDefaultSubState.Appearance = Appearance.Button;
         checkExternalDefaultSubState.Location = new Point(1003, 471);
         checkExternalDefaultSubState.Name = "checkExternalDefaultSubState";
         checkExternalDefaultSubState.Size = new Size(60, 27);
         checkExternalDefaultSubState.TabIndex = 71;
         checkExternalDefaultSubState.Text = "EXT";
         checkExternalDefaultSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkExternalDefaultSubState.UseVisualStyleBackColor = true;
         checkExternalDefaultSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera5
         // 
         checkCamera5.Appearance = Appearance.Button;
         checkCamera5.Location = new Point(924, 504);
         checkCamera5.Name = "checkCamera5";
         checkCamera5.Size = new Size(30, 27);
         checkCamera5.TabIndex = 48;
         checkCamera5.Tag = "5";
         checkCamera5.Text = "5";
         checkCamera5.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera5.UseVisualStyleBackColor = true;
         checkCamera5.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineITT
         // 
         lblEngineITT.AutoSize = true;
         lblEngineITT.Location = new Point(294, 332);
         lblEngineITT.Name = "lblEngineITT";
         lblEngineITT.Size = new Size(25, 17);
         lblEngineITT.TabIndex = 76;
         lblEngineITT.Text = "ITT";
         // 
         // checkCamera4
         // 
         checkCamera4.Appearance = Appearance.Button;
         checkCamera4.Location = new Point(888, 504);
         checkCamera4.Name = "checkCamera4";
         checkCamera4.Size = new Size(30, 27);
         checkCamera4.TabIndex = 47;
         checkCamera4.Tag = "4";
         checkCamera4.Text = "4";
         checkCamera4.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera4.UseVisualStyleBackColor = true;
         checkCamera4.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitQuickViewSubState
         // 
         checkCockpitQuickViewSubState.Appearance = Appearance.Button;
         checkCockpitQuickViewSubState.Location = new Point(1003, 438);
         checkCockpitQuickViewSubState.Name = "checkCockpitQuickViewSubState";
         checkCockpitQuickViewSubState.Size = new Size(60, 27);
         checkCockpitQuickViewSubState.TabIndex = 70;
         checkCockpitQuickViewSubState.Text = "C-QV";
         checkCockpitQuickViewSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkCockpitQuickViewSubState.UseVisualStyleBackColor = true;
         checkCockpitQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera3
         // 
         checkCamera3.Appearance = Appearance.Button;
         checkCamera3.Location = new Point(960, 537);
         checkCamera3.Name = "checkCamera3";
         checkCamera3.Size = new Size(30, 27);
         checkCamera3.TabIndex = 46;
         checkCamera3.Tag = "3";
         checkCamera3.Text = "3";
         checkCamera3.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera3.UseVisualStyleBackColor = true;
         checkCamera3.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineTorque
         // 
         lblEngineTorque.AutoSize = true;
         lblEngineTorque.Location = new Point(294, 315);
         lblEngineTorque.Name = "lblEngineTorque";
         lblEngineTorque.Size = new Size(49, 17);
         lblEngineTorque.TabIndex = 75;
         lblEngineTorque.Text = "Torque";
         // 
         // checkCamera2
         // 
         checkCamera2.Appearance = Appearance.Button;
         checkCamera2.Location = new Point(924, 537);
         checkCamera2.Name = "checkCamera2";
         checkCamera2.Size = new Size(30, 27);
         checkCamera2.TabIndex = 45;
         checkCamera2.Tag = "2";
         checkCamera2.Text = "2";
         checkCamera2.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera2.UseVisualStyleBackColor = true;
         checkCamera2.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitInstrumentSubState
         // 
         checkCockpitInstrumentSubState.Appearance = Appearance.Button;
         checkCockpitInstrumentSubState.Location = new Point(1003, 405);
         checkCockpitInstrumentSubState.Name = "checkCockpitInstrumentSubState";
         checkCockpitInstrumentSubState.Size = new Size(60, 27);
         checkCockpitInstrumentSubState.TabIndex = 69;
         checkCockpitInstrumentSubState.Text = "Instr";
         checkCockpitInstrumentSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkCockpitInstrumentSubState.UseVisualStyleBackColor = true;
         checkCockpitInstrumentSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera1
         // 
         checkCamera1.Appearance = Appearance.Button;
         checkCamera1.Location = new Point(888, 537);
         checkCamera1.Name = "checkCamera1";
         checkCamera1.Size = new Size(30, 27);
         checkCamera1.TabIndex = 44;
         checkCamera1.Tag = "1";
         checkCamera1.Text = "1";
         checkCamera1.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera1.UseVisualStyleBackColor = true;
         checkCamera1.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblFlapsCurrentPosition
         // 
         lblFlapsCurrentPosition.AutoSize = true;
         lblFlapsCurrentPosition.Location = new Point(686, 323);
         lblFlapsCurrentPosition.Name = "lblFlapsCurrentPosition";
         lblFlapsCurrentPosition.Size = new Size(101, 17);
         lblFlapsCurrentPosition.TabIndex = 74;
         lblFlapsCurrentPosition.Text = "Current Position";
         // 
         // checkCamera10
         // 
         checkCamera10.Appearance = Appearance.Button;
         checkCamera10.Location = new Point(888, 570);
         checkCamera10.Name = "checkCamera10";
         checkCamera10.Size = new Size(66, 27);
         checkCamera10.TabIndex = 43;
         checkCamera10.Tag = "0";
         checkCamera10.Text = "0";
         checkCamera10.TextAlign = ContentAlignment.MiddleCenter;
         checkCamera10.UseVisualStyleBackColor = true;
         checkCamera10.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitPilotSubState
         // 
         checkCockpitPilotSubState.Appearance = Appearance.Button;
         checkCockpitPilotSubState.Location = new Point(1003, 372);
         checkCockpitPilotSubState.Name = "checkCockpitPilotSubState";
         checkCockpitPilotSubState.Size = new Size(60, 27);
         checkCockpitPilotSubState.TabIndex = 68;
         checkCockpitPilotSubState.Text = "Pilot";
         checkCockpitPilotSubState.TextAlign = ContentAlignment.MiddleCenter;
         checkCockpitPilotSubState.UseVisualStyleBackColor = true;
         checkCockpitPilotSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblFlapsNumberOfDetents
         // 
         lblFlapsNumberOfDetents.AutoSize = true;
         lblFlapsNumberOfDetents.Location = new Point(686, 305);
         lblFlapsNumberOfDetents.Name = "lblFlapsNumberOfDetents";
         lblFlapsNumberOfDetents.Size = new Size(120, 17);
         lblFlapsNumberOfDetents.TabIndex = 73;
         lblFlapsNumberOfDetents.Text = "Number of Detents";
         // 
         // lblIndex1
         // 
         lblIndex1.AutoSize = true;
         lblIndex1.Location = new Point(151, 620);
         lblIndex1.Name = "lblIndex1";
         lblIndex1.Size = new Size(59, 17);
         lblIndex1.TabIndex = 60;
         lblIndex1.Text = "Index1: x";
         // 
         // btnPreviousSubView
         // 
         btnPreviousSubView.Location = new Point(943, 405);
         btnPreviousSubView.Name = "btnPreviousSubView";
         btnPreviousSubView.Size = new Size(42, 27);
         btnPreviousSubView.TabIndex = 166;
         btnPreviousSubView.Text = "PSV";
         btnPreviousSubView.UseVisualStyleBackColor = true;
         btnPreviousSubView.Click += CameraViewButton_Click;
         // 
         // lblIndex0
         // 
         lblIndex0.AutoSize = true;
         lblIndex0.Location = new Point(151, 603);
         lblIndex0.Name = "lblIndex0";
         lblIndex0.Size = new Size(59, 17);
         lblIndex0.TabIndex = 60;
         lblIndex0.Text = "Index0: x";
         // 
         // lblCurrentFlapsLimit
         // 
         lblCurrentFlapsLimit.AutoSize = true;
         lblCurrentFlapsLimit.Location = new Point(686, 288);
         lblCurrentFlapsLimit.Name = "lblCurrentFlapsLimit";
         lblCurrentFlapsLimit.Size = new Size(116, 17);
         lblCurrentFlapsLimit.TabIndex = 72;
         lblCurrentFlapsLimit.Text = "Current Flaps Limit";
         // 
         // lblCameraSubstate
         // 
         lblCameraSubstate.AutoSize = true;
         lblCameraSubstate.Location = new Point(151, 586);
         lblCameraSubstate.Name = "lblCameraSubstate";
         lblCameraSubstate.Size = new Size(71, 17);
         lblCameraSubstate.TabIndex = 59;
         lblCameraSubstate.Text = "Substate: x";
         // 
         // btnNextSubView
         // 
         btnNextSubView.Location = new Point(943, 372);
         btnNextSubView.Name = "btnNextSubView";
         btnNextSubView.Size = new Size(42, 27);
         btnNextSubView.TabIndex = 165;
         btnNextSubView.Text = "NSV";
         btnNextSubView.UseVisualStyleBackColor = true;
         btnNextSubView.Click += CameraViewButton_Click;
         // 
         // lblCameraState
         // 
         lblCameraState.AutoSize = true;
         lblCameraState.Location = new Point(151, 569);
         lblCameraState.Name = "lblCameraState";
         lblCameraState.Size = new Size(50, 17);
         lblCameraState.TabIndex = 58;
         lblCameraState.Text = "State: x";
         // 
         // lblTrailingFlapsRight
         // 
         lblTrailingFlapsRight.AutoSize = true;
         lblTrailingFlapsRight.Location = new Point(686, 271);
         lblTrailingFlapsRight.Name = "lblTrailingFlapsRight";
         lblTrailingFlapsRight.Size = new Size(118, 17);
         lblTrailingFlapsRight.TabIndex = 71;
         lblTrailingFlapsRight.Text = "Trailing Flaps Right";
         // 
         // btnPreviousView
         // 
         btnPreviousView.Location = new Point(888, 405);
         btnPreviousView.Name = "btnPreviousView";
         btnPreviousView.Size = new Size(42, 27);
         btnPreviousView.TabIndex = 165;
         btnPreviousView.Text = "PV";
         btnPreviousView.UseVisualStyleBackColor = true;
         btnPreviousView.Click += CameraViewButton_Click;
         // 
         // lblTrailingFlapsLeft
         // 
         lblTrailingFlapsLeft.AutoSize = true;
         lblTrailingFlapsLeft.Location = new Point(686, 254);
         lblTrailingFlapsLeft.Name = "lblTrailingFlapsLeft";
         lblTrailingFlapsLeft.Size = new Size(109, 17);
         lblTrailingFlapsLeft.TabIndex = 70;
         lblTrailingFlapsLeft.Text = "Trailing Flaps Left";
         // 
         // btnNextView
         // 
         btnNextView.Location = new Point(888, 372);
         btnNextView.Name = "btnNextView";
         btnNextView.Size = new Size(42, 27);
         btnNextView.TabIndex = 164;
         btnNextView.Text = "NV";
         btnNextView.UseVisualStyleBackColor = true;
         btnNextView.Click += CameraViewButton_Click;
         // 
         // lblAileronTrimPct
         // 
         lblAileronTrimPct.AutoSize = true;
         lblAileronTrimPct.Location = new Point(525, 276);
         lblAileronTrimPct.Name = "lblAileronTrimPct";
         lblAileronTrimPct.Size = new Size(103, 17);
         lblAileronTrimPct.TabIndex = 69;
         lblAileronTrimPct.Text = "Aileron Trim: 0%";
         // 
         // lblRudderTrimPct
         // 
         lblRudderTrimPct.AutoSize = true;
         lblRudderTrimPct.Location = new Point(525, 259);
         lblRudderTrimPct.Name = "lblRudderTrimPct";
         lblRudderTrimPct.Size = new Size(105, 17);
         lblRudderTrimPct.TabIndex = 68;
         lblRudderTrimPct.Text = "Rudder Trim: 0%";
         // 
         // lblElevatorTrimPct
         // 
         lblElevatorTrimPct.AutoSize = true;
         lblElevatorTrimPct.Location = new Point(525, 242);
         lblElevatorTrimPct.Name = "lblElevatorTrimPct";
         lblElevatorTrimPct.Size = new Size(109, 17);
         lblElevatorTrimPct.TabIndex = 2;
         lblElevatorTrimPct.Text = "Elevator Trim: 0%";
         // 
         // btnSetCamera
         // 
         btnSetCamera.Location = new Point(341, 282);
         btnSetCamera.Name = "btnSetCamera";
         btnSetCamera.Size = new Size(140, 23);
         btnSetCamera.TabIndex = 67;
         btnSetCamera.Text = "Set Camera";
         btnSetCamera.UseVisualStyleBackColor = true;
         btnSetCamera.Click += btnSetCamera_Click;
         // 
         // txtCameraIndex1
         // 
         txtCameraIndex1.Location = new Point(450, 251);
         txtCameraIndex1.Name = "txtCameraIndex1";
         txtCameraIndex1.Size = new Size(31, 25);
         txtCameraIndex1.TabIndex = 66;
         // 
         // txtCameraIndex0
         // 
         txtCameraIndex0.Location = new Point(413, 251);
         txtCameraIndex0.Name = "txtCameraIndex0";
         txtCameraIndex0.Size = new Size(31, 25);
         txtCameraIndex0.TabIndex = 65;
         // 
         // txtCameraSubState
         // 
         txtCameraSubState.Location = new Point(376, 251);
         txtCameraSubState.Name = "txtCameraSubState";
         txtCameraSubState.Size = new Size(31, 25);
         txtCameraSubState.TabIndex = 64;
         // 
         // txtCameraState
         // 
         txtCameraState.Location = new Point(339, 251);
         txtCameraState.Name = "txtCameraState";
         txtCameraState.Size = new Size(31, 25);
         txtCameraState.TabIndex = 63;
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(btnSimRateReset);
         groupBox1.Controls.Add(btnSimRateDec);
         groupBox1.Controls.Add(btnSimRateInc);
         groupBox1.Controls.Add(lblSimRate);
         groupBox1.Location = new Point(686, 144);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new Size(177, 95);
         groupBox1.TabIndex = 62;
         groupBox1.TabStop = false;
         groupBox1.Text = "Time";
         // 
         // btnSimRateReset
         // 
         btnSimRateReset.AutoSize = true;
         btnSimRateReset.Location = new Point(72, 41);
         btnSimRateReset.Name = "btnSimRateReset";
         btnSimRateReset.Size = new Size(50, 27);
         btnSimRateReset.TabIndex = 69;
         btnSimRateReset.Text = "Reset";
         btnSimRateReset.UseVisualStyleBackColor = true;
         btnSimRateReset.Click += SimRateButton_Click;
         // 
         // btnSimRateDec
         // 
         btnSimRateDec.Location = new Point(6, 41);
         btnSimRateDec.Name = "btnSimRateDec";
         btnSimRateDec.Size = new Size(27, 27);
         btnSimRateDec.TabIndex = 68;
         btnSimRateDec.Text = "-";
         btnSimRateDec.UseVisualStyleBackColor = true;
         btnSimRateDec.Click += SimRateButton_Click;
         // 
         // btnSimRateInc
         // 
         btnSimRateInc.Location = new Point(39, 41);
         btnSimRateInc.Name = "btnSimRateInc";
         btnSimRateInc.Size = new Size(27, 27);
         btnSimRateInc.TabIndex = 67;
         btnSimRateInc.Text = "+";
         btnSimRateInc.UseVisualStyleBackColor = true;
         btnSimRateInc.Click += SimRateButton_Click;
         // 
         // lblSimRate
         // 
         lblSimRate.AutoSize = true;
         lblSimRate.Location = new Point(6, 21);
         lblSimRate.Name = "lblSimRate";
         lblSimRate.Size = new Size(79, 17);
         lblSimRate.TabIndex = 0;
         lblSimRate.Text = "Sim Rate: 1x";
         // 
         // lblCurrentCameraType
         // 
         lblCurrentCameraType.AutoSize = true;
         lblCurrentCameraType.Location = new Point(725, 623);
         lblCurrentCameraType.Name = "lblCurrentCameraType";
         lblCurrentCameraType.Size = new Size(50, 17);
         lblCurrentCameraType.TabIndex = 67;
         lblCurrentCameraType.Text = "label10";
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(737, 233);
         txtOutput.Multiline = true;
         txtOutput.Name = "txtOutput";
         txtOutput.ReadOnly = true;
         txtOutput.Size = new Size(326, 116);
         txtOutput.TabIndex = 61;
         // 
         // groupCameras
         // 
         groupCameras.Controls.Add(checkCameraPilotCoPilot);
         groupCameras.Controls.Add(checkCameraPilotLand);
         groupCameras.Controls.Add(checkCameraPilotClose);
         groupCameras.Controls.Add(checkCameraPilotNormal);
         groupCameras.Controls.Add(lblCameraCurrentView);
         groupCameras.Location = new Point(284, 490);
         groupCameras.Name = "groupCameras";
         groupCameras.Size = new Size(468, 130);
         groupCameras.TabIndex = 45;
         groupCameras.TabStop = false;
         groupCameras.Text = "Cameras";
         // 
         // checkCameraPilotCoPilot
         // 
         checkCameraPilotCoPilot.Appearance = Appearance.Button;
         checkCameraPilotCoPilot.Location = new Point(204, 57);
         checkCameraPilotCoPilot.Name = "checkCameraPilotCoPilot";
         checkCameraPilotCoPilot.Size = new Size(60, 27);
         checkCameraPilotCoPilot.TabIndex = 57;
         checkCameraPilotCoPilot.Text = "CoPilot";
         checkCameraPilotCoPilot.TextAlign = ContentAlignment.MiddleCenter;
         checkCameraPilotCoPilot.UseVisualStyleBackColor = true;
         checkCameraPilotCoPilot.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotLand
         // 
         checkCameraPilotLand.Appearance = Appearance.Button;
         checkCameraPilotLand.Location = new Point(138, 57);
         checkCameraPilotLand.Name = "checkCameraPilotLand";
         checkCameraPilotLand.Size = new Size(60, 27);
         checkCameraPilotLand.TabIndex = 56;
         checkCameraPilotLand.Text = "Land";
         checkCameraPilotLand.TextAlign = ContentAlignment.MiddleCenter;
         checkCameraPilotLand.UseVisualStyleBackColor = true;
         checkCameraPilotLand.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotClose
         // 
         checkCameraPilotClose.Appearance = Appearance.Button;
         checkCameraPilotClose.Location = new Point(6, 57);
         checkCameraPilotClose.Name = "checkCameraPilotClose";
         checkCameraPilotClose.Size = new Size(60, 27);
         checkCameraPilotClose.TabIndex = 55;
         checkCameraPilotClose.Text = "Close";
         checkCameraPilotClose.TextAlign = ContentAlignment.MiddleCenter;
         checkCameraPilotClose.UseVisualStyleBackColor = true;
         checkCameraPilotClose.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotNormal
         // 
         checkCameraPilotNormal.Appearance = Appearance.Button;
         checkCameraPilotNormal.Location = new Point(72, 57);
         checkCameraPilotNormal.Name = "checkCameraPilotNormal";
         checkCameraPilotNormal.Size = new Size(60, 27);
         checkCameraPilotNormal.TabIndex = 54;
         checkCameraPilotNormal.Text = "Pilot";
         checkCameraPilotNormal.TextAlign = ContentAlignment.MiddleCenter;
         checkCameraPilotNormal.UseVisualStyleBackColor = true;
         checkCameraPilotNormal.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblCameraCurrentView
         // 
         lblCameraCurrentView.AutoSize = true;
         lblCameraCurrentView.Location = new Point(295, 62);
         lblCameraCurrentView.Name = "lblCameraCurrentView";
         lblCameraCurrentView.Size = new Size(127, 17);
         lblCameraCurrentView.TabIndex = 53;
         lblCameraCurrentView.Text = "Current camera view";
         // 
         // groupFuel
         // 
         groupFuel.Controls.Add(lblFuelDumpSwitch);
         groupFuel.Controls.Add(btnFuelDump);
         groupFuel.Controls.Add(lblTotalFuelPct);
         groupFuel.Controls.Add(btnAddFuel);
         groupFuel.Location = new Point(869, 144);
         groupFuel.Name = "groupFuel";
         groupFuel.Size = new Size(194, 83);
         groupFuel.TabIndex = 40;
         groupFuel.TabStop = false;
         groupFuel.Text = "Fuel";
         // 
         // lblFuelDumpSwitch
         // 
         lblFuelDumpSwitch.Location = new Point(128, 52);
         lblFuelDumpSwitch.Name = "lblFuelDumpSwitch";
         lblFuelDumpSwitch.Size = new Size(60, 23);
         lblFuelDumpSwitch.TabIndex = 67;
         lblFuelDumpSwitch.Text = "off";
         lblFuelDumpSwitch.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // btnFuelDump
         // 
         btnFuelDump.Location = new Point(67, 50);
         btnFuelDump.Name = "btnFuelDump";
         btnFuelDump.Size = new Size(55, 27);
         btnFuelDump.TabIndex = 66;
         btnFuelDump.Text = "DUMP";
         btnFuelDump.UseVisualStyleBackColor = true;
         btnFuelDump.Click += btnFuelDump_Click;
         // 
         // lblTotalFuelPct
         // 
         lblTotalFuelPct.AutoSize = true;
         lblTotalFuelPct.Location = new Point(6, 21);
         lblTotalFuelPct.Name = "lblTotalFuelPct";
         lblTotalFuelPct.Size = new Size(112, 17);
         lblTotalFuelPct.TabIndex = 65;
         lblTotalFuelPct.Text = "Total Fuel: 100.0%";
         // 
         // btnAddFuel
         // 
         btnAddFuel.Location = new Point(6, 50);
         btnAddFuel.Name = "btnAddFuel";
         btnAddFuel.Size = new Size(55, 27);
         btnAddFuel.TabIndex = 64;
         btnAddFuel.Text = "ADD";
         btnAddFuel.UseVisualStyleBackColor = true;
         btnAddFuel.Click += btnAddFuel_Click;
         // 
         // groupPause
         // 
         groupPause.Controls.Add(btnPauseSim);
         groupPause.Controls.Add(checkPauseEsc);
         groupPause.Controls.Add(checkPauseSim);
         groupPause.Controls.Add(checkPauseActive);
         groupPause.Controls.Add(checkPauseFull);
         groupPause.Controls.Add(btnPauseFull);
         groupPause.Location = new Point(820, 3);
         groupPause.Name = "groupPause";
         groupPause.Size = new Size(243, 135);
         groupPause.TabIndex = 39;
         groupPause.TabStop = false;
         groupPause.Text = "Pause";
         // 
         // btnPauseSim
         // 
         btnPauseSim.Location = new Point(6, 78);
         btnPauseSim.Name = "btnPauseSim";
         btnPauseSim.Size = new Size(97, 48);
         btnPauseSim.TabIndex = 5;
         btnPauseSim.Text = "Sim Pause";
         btnPauseSim.UseVisualStyleBackColor = true;
         btnPauseSim.Click += BtnPause_Click;
         // 
         // checkPauseEsc
         // 
         checkPauseEsc.AutoCheck = false;
         checkPauseEsc.AutoSize = true;
         checkPauseEsc.Location = new Point(115, 105);
         checkPauseEsc.Name = "checkPauseEsc";
         checkPauseEsc.Size = new Size(84, 21);
         checkPauseEsc.TabIndex = 4;
         checkPauseEsc.Text = "Esc Pause";
         checkPauseEsc.UseVisualStyleBackColor = true;
         // 
         // checkPauseSim
         // 
         checkPauseSim.AutoSize = true;
         checkPauseSim.Location = new Point(115, 78);
         checkPauseSim.Name = "checkPauseSim";
         checkPauseSim.Size = new Size(86, 21);
         checkPauseSim.TabIndex = 3;
         checkPauseSim.Text = "Sim Pause";
         checkPauseSim.UseVisualStyleBackColor = true;
         // 
         // checkPauseActive
         // 
         checkPauseActive.AutoCheck = false;
         checkPauseActive.AutoSize = true;
         checkPauseActive.Location = new Point(115, 51);
         checkPauseActive.Name = "checkPauseActive";
         checkPauseActive.Size = new Size(99, 21);
         checkPauseActive.TabIndex = 2;
         checkPauseActive.Text = "Active Pause";
         checkPauseActive.UseVisualStyleBackColor = true;
         // 
         // checkPauseFull
         // 
         checkPauseFull.AutoCheck = false;
         checkPauseFull.AutoSize = true;
         checkPauseFull.Location = new Point(115, 24);
         checkPauseFull.Name = "checkPauseFull";
         checkPauseFull.Size = new Size(84, 21);
         checkPauseFull.TabIndex = 1;
         checkPauseFull.Text = "Full Pause";
         checkPauseFull.UseVisualStyleBackColor = true;
         // 
         // btnPauseFull
         // 
         btnPauseFull.Location = new Point(6, 24);
         btnPauseFull.Name = "btnPauseFull";
         btnPauseFull.Size = new Size(97, 48);
         btnPauseFull.TabIndex = 0;
         btnPauseFull.Text = "Full Pause";
         btnPauseFull.UseVisualStyleBackColor = true;
         btnPauseFull.Click += BtnPause_Click;
         // 
         // groupFms
         // 
         groupFms.Controls.Add(btnFmsMfdInner);
         groupFms.Controls.Add(btnFmsMfdOuter);
         groupFms.Controls.Add(btnFmsEnt);
         groupFms.Controls.Add(btnFmsClr);
         groupFms.Controls.Add(btnFmsMenu);
         groupFms.Controls.Add(btnFmsProc);
         groupFms.Controls.Add(btnFmsFpl);
         groupFms.Controls.Add(btnFmsDirect);
         groupFms.Controls.Add(btnFmsPfdInner);
         groupFms.Controls.Add(btnFmsPfdOuter);
         groupFms.Location = new Point(284, 144);
         groupFms.Name = "groupFms";
         groupFms.Size = new Size(396, 95);
         groupFms.TabIndex = 38;
         groupFms.TabStop = false;
         groupFms.Text = "FMS";
         // 
         // btnFmsMfdInner
         // 
         btnFmsMfdInner.Location = new Point(342, 30);
         btnFmsMfdInner.Name = "btnFmsMfdInner";
         btnFmsMfdInner.Size = new Size(45, 45);
         btnFmsMfdInner.TabIndex = 63;
         btnFmsMfdInner.Text = "MFD\r\nIN";
         btnFmsMfdInner.UseVisualStyleBackColor = true;
         // 
         // btnFmsMfdOuter
         // 
         btnFmsMfdOuter.Location = new Point(291, 30);
         btnFmsMfdOuter.Name = "btnFmsMfdOuter";
         btnFmsMfdOuter.Size = new Size(45, 45);
         btnFmsMfdOuter.TabIndex = 62;
         btnFmsMfdOuter.Text = "MFD\r\nOUT";
         btnFmsMfdOuter.UseVisualStyleBackColor = true;
         // 
         // btnFmsEnt
         // 
         btnFmsEnt.Location = new Point(230, 57);
         btnFmsEnt.Name = "btnFmsEnt";
         btnFmsEnt.Size = new Size(55, 27);
         btnFmsEnt.TabIndex = 61;
         btnFmsEnt.Text = "ENT";
         btnFmsEnt.UseVisualStyleBackColor = true;
         btnFmsEnt.Click += FmsButton_Click;
         // 
         // btnFmsClr
         // 
         btnFmsClr.Location = new Point(169, 57);
         btnFmsClr.Name = "btnFmsClr";
         btnFmsClr.Size = new Size(55, 27);
         btnFmsClr.TabIndex = 60;
         btnFmsClr.Text = "CLR";
         btnFmsClr.UseVisualStyleBackColor = true;
         btnFmsClr.Click += FmsButton_Click;
         // 
         // btnFmsMenu
         // 
         btnFmsMenu.Location = new Point(108, 57);
         btnFmsMenu.Name = "btnFmsMenu";
         btnFmsMenu.Size = new Size(55, 27);
         btnFmsMenu.TabIndex = 59;
         btnFmsMenu.Text = "MENU";
         btnFmsMenu.UseVisualStyleBackColor = true;
         btnFmsMenu.Click += FmsButton_Click;
         // 
         // btnFmsProc
         // 
         btnFmsProc.Location = new Point(230, 24);
         btnFmsProc.Name = "btnFmsProc";
         btnFmsProc.Size = new Size(55, 27);
         btnFmsProc.TabIndex = 58;
         btnFmsProc.Text = "PROC";
         btnFmsProc.UseVisualStyleBackColor = true;
         btnFmsProc.Click += FmsButton_Click;
         // 
         // btnFmsFpl
         // 
         btnFmsFpl.Location = new Point(169, 24);
         btnFmsFpl.Name = "btnFmsFpl";
         btnFmsFpl.Size = new Size(55, 27);
         btnFmsFpl.TabIndex = 57;
         btnFmsFpl.Text = "FPL";
         btnFmsFpl.UseVisualStyleBackColor = true;
         btnFmsFpl.Click += FmsButton_Click;
         // 
         // btnFmsDirect
         // 
         btnFmsDirect.Location = new Point(108, 24);
         btnFmsDirect.Name = "btnFmsDirect";
         btnFmsDirect.Size = new Size(55, 27);
         btnFmsDirect.TabIndex = 56;
         btnFmsDirect.Text = "DIR";
         btnFmsDirect.UseVisualStyleBackColor = true;
         btnFmsDirect.Click += FmsButton_Click;
         // 
         // btnFmsPfdInner
         // 
         btnFmsPfdInner.Location = new Point(57, 30);
         btnFmsPfdInner.Name = "btnFmsPfdInner";
         btnFmsPfdInner.Size = new Size(45, 45);
         btnFmsPfdInner.TabIndex = 55;
         btnFmsPfdInner.Text = "PFD\r\nIN";
         btnFmsPfdInner.UseVisualStyleBackColor = true;
         // 
         // btnFmsPfdOuter
         // 
         btnFmsPfdOuter.Location = new Point(6, 30);
         btnFmsPfdOuter.Name = "btnFmsPfdOuter";
         btnFmsPfdOuter.Size = new Size(45, 45);
         btnFmsPfdOuter.TabIndex = 54;
         btnFmsPfdOuter.Text = "PFD\r\nOUT";
         btnFmsPfdOuter.UseVisualStyleBackColor = true;
         // 
         // groupAutopilot
         // 
         groupAutopilot.Controls.Add(btnCrs2Sel);
         groupAutopilot.Controls.Add(checkApSpd);
         groupAutopilot.Controls.Add(checkApFlc);
         groupAutopilot.Controls.Add(btnNoseUpDn);
         groupAutopilot.Controls.Add(checkApVnv);
         groupAutopilot.Controls.Add(checkApVsHold);
         groupAutopilot.Controls.Add(btnAltSel);
         groupAutopilot.Controls.Add(checkApAltHold);
         groupAutopilot.Controls.Add(checkApYd);
         groupAutopilot.Controls.Add(checkApFd);
         groupAutopilot.Controls.Add(checkApMaster);
         groupAutopilot.Controls.Add(btnCrs1Sel);
         groupAutopilot.Controls.Add(btnHdgSel);
         groupAutopilot.Controls.Add(checkApBcHold);
         groupAutopilot.Controls.Add(checkApAprHold);
         groupAutopilot.Controls.Add(checkApNavHold);
         groupAutopilot.Controls.Add(checkApHdgHold);
         groupAutopilot.Location = new Point(284, 3);
         groupAutopilot.Name = "groupAutopilot";
         groupAutopilot.Size = new Size(530, 135);
         groupAutopilot.TabIndex = 37;
         groupAutopilot.TabStop = false;
         groupAutopilot.Text = "Autopilot";
         // 
         // btnCrs2Sel
         // 
         btnCrs2Sel.Location = new Point(474, 57);
         btnCrs2Sel.Name = "btnCrs2Sel";
         btnCrs2Sel.Size = new Size(45, 45);
         btnCrs2Sel.TabIndex = 53;
         btnCrs2Sel.Text = "CS2\r\nSEL";
         btnCrs2Sel.UseVisualStyleBackColor = true;
         btnCrs2Sel.Click += ApButton_Click;
         // 
         // checkApSpd
         // 
         checkApSpd.Appearance = Appearance.Button;
         checkApSpd.Location = new Point(417, 57);
         checkApSpd.Name = "checkApSpd";
         checkApSpd.Size = new Size(45, 27);
         checkApSpd.TabIndex = 52;
         checkApSpd.Text = "SPD";
         checkApSpd.TextAlign = ContentAlignment.MiddleCenter;
         checkApSpd.UseVisualStyleBackColor = true;
         checkApSpd.CheckedChanged += Autopilot_CheckedChanged;
         checkApSpd.Click += ApButton_Click;
         // 
         // checkApFlc
         // 
         checkApFlc.Appearance = Appearance.Button;
         checkApFlc.Location = new Point(417, 24);
         checkApFlc.Name = "checkApFlc";
         checkApFlc.Size = new Size(45, 27);
         checkApFlc.TabIndex = 51;
         checkApFlc.Text = "FLC";
         checkApFlc.TextAlign = ContentAlignment.MiddleCenter;
         checkApFlc.UseVisualStyleBackColor = true;
         checkApFlc.CheckedChanged += Autopilot_CheckedChanged;
         checkApFlc.Click += ApButton_Click;
         // 
         // btnNoseUpDn
         // 
         btnNoseUpDn.Location = new Point(376, 24);
         btnNoseUpDn.Name = "btnNoseUpDn";
         btnNoseUpDn.Size = new Size(35, 78);
         btnNoseUpDn.TabIndex = 50;
         btnNoseUpDn.Text = "DN\r\n\r\n\r\nUP";
         btnNoseUpDn.UseVisualStyleBackColor = true;
         // 
         // checkApVnv
         // 
         checkApVnv.Appearance = Appearance.Button;
         checkApVnv.Location = new Point(325, 57);
         checkApVnv.Name = "checkApVnv";
         checkApVnv.Size = new Size(45, 27);
         checkApVnv.TabIndex = 49;
         checkApVnv.Text = "VNV";
         checkApVnv.TextAlign = ContentAlignment.MiddleCenter;
         checkApVnv.UseVisualStyleBackColor = true;
         checkApVnv.CheckedChanged += Autopilot_CheckedChanged;
         checkApVnv.Click += ApButton_Click;
         // 
         // checkApVsHold
         // 
         checkApVsHold.Appearance = Appearance.Button;
         checkApVsHold.Location = new Point(325, 24);
         checkApVsHold.Name = "checkApVsHold";
         checkApVsHold.Size = new Size(45, 27);
         checkApVsHold.TabIndex = 48;
         checkApVsHold.Text = "VS";
         checkApVsHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApVsHold.UseVisualStyleBackColor = true;
         checkApVsHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApVsHold.Click += ApButton_Click;
         // 
         // btnAltSel
         // 
         btnAltSel.Location = new Point(275, 57);
         btnAltSel.Name = "btnAltSel";
         btnAltSel.Size = new Size(45, 45);
         btnAltSel.TabIndex = 47;
         btnAltSel.Text = "ALT\r\nSEL";
         btnAltSel.UseVisualStyleBackColor = true;
         btnAltSel.Click += ApButton_Click;
         // 
         // checkApAltHold
         // 
         checkApAltHold.Appearance = Appearance.Button;
         checkApAltHold.Location = new Point(275, 24);
         checkApAltHold.Name = "checkApAltHold";
         checkApAltHold.Size = new Size(45, 27);
         checkApAltHold.TabIndex = 46;
         checkApAltHold.Text = "ALT";
         checkApAltHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApAltHold.UseVisualStyleBackColor = true;
         checkApAltHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApAltHold.Click += ApButton_Click;
         // 
         // checkApYd
         // 
         checkApYd.Appearance = Appearance.Button;
         checkApYd.Location = new Point(218, 57);
         checkApYd.Name = "checkApYd";
         checkApYd.Size = new Size(45, 27);
         checkApYd.TabIndex = 45;
         checkApYd.Text = "YD";
         checkApYd.TextAlign = ContentAlignment.MiddleCenter;
         checkApYd.UseVisualStyleBackColor = true;
         checkApYd.CheckedChanged += Autopilot_CheckedChanged;
         checkApYd.Click += ApButton_Click;
         // 
         // checkApFd
         // 
         checkApFd.Appearance = Appearance.Button;
         checkApFd.Location = new Point(193, 24);
         checkApFd.Name = "checkApFd";
         checkApFd.Size = new Size(45, 27);
         checkApFd.TabIndex = 44;
         checkApFd.Text = "FD";
         checkApFd.TextAlign = ContentAlignment.MiddleCenter;
         checkApFd.UseVisualStyleBackColor = true;
         checkApFd.CheckedChanged += Autopilot_CheckedChanged;
         checkApFd.Click += ApButton_Click;
         // 
         // checkApMaster
         // 
         checkApMaster.Appearance = Appearance.Button;
         checkApMaster.Location = new Point(167, 57);
         checkApMaster.Name = "checkApMaster";
         checkApMaster.Size = new Size(45, 27);
         checkApMaster.TabIndex = 38;
         checkApMaster.Text = "AP";
         checkApMaster.TextAlign = ContentAlignment.MiddleCenter;
         checkApMaster.UseVisualStyleBackColor = true;
         checkApMaster.CheckedChanged += Autopilot_CheckedChanged;
         checkApMaster.Click += ApButton_Click;
         // 
         // btnCrs1Sel
         // 
         btnCrs1Sel.Location = new Point(110, 57);
         btnCrs1Sel.Name = "btnCrs1Sel";
         btnCrs1Sel.Size = new Size(45, 45);
         btnCrs1Sel.TabIndex = 43;
         btnCrs1Sel.Text = "CS1\r\nSEL";
         btnCrs1Sel.UseVisualStyleBackColor = true;
         btnCrs1Sel.Click += ApButton_Click;
         // 
         // btnHdgSel
         // 
         btnHdgSel.Location = new Point(10, 57);
         btnHdgSel.Name = "btnHdgSel";
         btnHdgSel.Size = new Size(45, 45);
         btnHdgSel.TabIndex = 39;
         btnHdgSel.Text = "HDG\r\nSEL";
         btnHdgSel.UseVisualStyleBackColor = true;
         btnHdgSel.Click += ApButton_Click;
         // 
         // checkApBcHold
         // 
         checkApBcHold.Appearance = Appearance.Button;
         checkApBcHold.Location = new Point(61, 57);
         checkApBcHold.Name = "checkApBcHold";
         checkApBcHold.Size = new Size(45, 27);
         checkApBcHold.TabIndex = 42;
         checkApBcHold.Text = "BC";
         checkApBcHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApBcHold.UseVisualStyleBackColor = true;
         checkApBcHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApBcHold.Click += ApButton_Click;
         // 
         // checkApAprHold
         // 
         checkApAprHold.Appearance = Appearance.Button;
         checkApAprHold.Location = new Point(61, 24);
         checkApAprHold.Name = "checkApAprHold";
         checkApAprHold.Size = new Size(45, 27);
         checkApAprHold.TabIndex = 41;
         checkApAprHold.Text = "APR";
         checkApAprHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApAprHold.UseVisualStyleBackColor = true;
         checkApAprHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApAprHold.Click += ApButton_Click;
         // 
         // checkApNavHold
         // 
         checkApNavHold.Appearance = Appearance.Button;
         checkApNavHold.Location = new Point(110, 24);
         checkApNavHold.Name = "checkApNavHold";
         checkApNavHold.Size = new Size(45, 27);
         checkApNavHold.TabIndex = 40;
         checkApNavHold.Text = "NAV";
         checkApNavHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApNavHold.UseVisualStyleBackColor = true;
         checkApNavHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApHdgHold
         // 
         checkApHdgHold.Appearance = Appearance.Button;
         checkApHdgHold.Location = new Point(10, 24);
         checkApHdgHold.Name = "checkApHdgHold";
         checkApHdgHold.Size = new Size(45, 27);
         checkApHdgHold.TabIndex = 39;
         checkApHdgHold.Text = "HDG";
         checkApHdgHold.TextAlign = ContentAlignment.MiddleCenter;
         checkApHdgHold.UseVisualStyleBackColor = true;
         checkApHdgHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApHdgHold.Click += ApButton_Click;
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
         groupLights.Location = new Point(284, 392);
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
         mainMenu.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, macroPadToolStripMenuItem, utilityToolStripMenuItem });
         mainMenu.Location = new Point(0, 0);
         mainMenu.Name = "mainMenu";
         mainMenu.Size = new Size(1133, 25);
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
         // fsuipcConnectToolStripMenuItem
         // 
         fsuipcConnectToolStripMenuItem.Name = "fsuipcConnectToolStripMenuItem";
         fsuipcConnectToolStripMenuItem.Size = new Size(195, 22);
         fsuipcConnectToolStripMenuItem.Text = "Connect FSUIPC";
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
         // utilityToolStripMenuItem
         // 
         utilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { presetEventsToolStripMenuItem });
         utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
         utilityToolStripMenuItem.Size = new Size(52, 21);
         utilityToolStripMenuItem.Text = "Utility";
         // 
         // presetEventsToolStripMenuItem
         // 
         presetEventsToolStripMenuItem.Name = "presetEventsToolStripMenuItem";
         presetEventsToolStripMenuItem.Size = new Size(162, 22);
         presetEventsToolStripMenuItem.Text = "Preset Events...";
         presetEventsToolStripMenuItem.Click += PresetEventsToolStripMenuItem_Click;
         // 
         // MainForm
         // 
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1133, 720);
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
         ((System.ComponentModel.ISupportInitialize)trackFlaps).EndInit();
         groupBox1.ResumeLayout(false);
         groupBox1.PerformLayout();
         groupCameras.ResumeLayout(false);
         groupCameras.PerformLayout();
         groupFuel.ResumeLayout(false);
         groupFuel.PerformLayout();
         groupPause.ResumeLayout(false);
         groupPause.PerformLayout();
         groupFms.ResumeLayout(false);
         groupAutopilot.ResumeLayout(false);
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
      private ToolStripStatusLabel lblFsuipcStatus;
      private ToolStripMenuItem fsuipcConnectToolStripMenuItem;
      private ToolStripMenuItem utilityToolStripMenuItem;
      private ToolStripMenuItem presetEventsToolStripMenuItem;
      private GroupBox groupAutopilot;
      private CheckBox checkApNavHold;
      private CheckBox checkApHdgHold;
      private CheckBox checkApMaster;
      private CheckBox checkApAprHold;
      private Button btnCrs1Sel;
      private Button btnHdgSel;
      private CheckBox checkApBcHold;
      private CheckBox checkApYd;
      private CheckBox checkApFd;
      private CheckBox checkApAltHold;
      private Button btnAltSel;
      private CheckBox checkApVsHold;
      private CheckBox checkApVnv;
      private Button btnNoseUpDn;
      private CheckBox checkApFlc;
      private CheckBox checkApSpd;
      private Button btnCrs2Sel;
      private GroupBox groupFms;
      private Button btnFmsFpl;
      private Button btnFmsDirect;
      private Button btnFmsPfdInner;
      private Button btnFmsPfdOuter;
      private Button btnFmsProc;
      private Button btnFmsMfdInner;
      private Button btnFmsMfdOuter;
      private Button btnFmsEnt;
      private Button btnFmsClr;
      private Button btnFmsMenu;
      private ToolTip toolTip1;
      private GroupBox groupPause;
      private Button btnPauseFull;
      private CheckBox checkPauseFull;
      private CheckBox checkPauseActive;
      private CheckBox checkPauseEsc;
      private CheckBox checkPauseSim;
      private Button btnPauseSim;
      private GroupBox groupFuel;
      private Button btnAddFuel;
      private TextBox txtTotalFuelPct;
      private Label lblTotalFuelPct;
      private Button btnFuelDump;
      private Label lblFuelDumpSwitch;
      private GroupBox groupCameras;
      private CheckBox checkCamera10;
      private CheckBox checkCamera9;
      private CheckBox checkCamera8;
      private CheckBox checkCamera7;
      private CheckBox checkCamera6;
      private CheckBox checkCamera5;
      private CheckBox checkCamera4;
      private CheckBox checkCamera3;
      private CheckBox checkCamera2;
      private CheckBox checkCamera1;
      private Label lblCameraCurrentView;
      private CheckBox checkCameraPilotCoPilot;
      private CheckBox checkCameraPilotLand;
      private CheckBox checkCameraPilotClose;
      private CheckBox checkCameraPilotNormal;
      private Label lblIndex1;
      private Label lblIndex0;
      private Label lblCameraSubstate;
      private Label lblCameraState;
      public TextBox txtOutput;
      private Button btnNextView;
      private Button btnPreviousSubView;
      private Button btnNextSubView;
      private Button btnPreviousView;
      private GroupBox groupBox1;
      private Label lblSimRate;
      private Button btnSimRateDec;
      private Button btnSimRateInc;
      private ToolStripStatusLabel lblLocalTime;
      private Button btnSimRateReset;
      private Label lblCurrentCameraType;
      private Button btnSetCamera;
      private TextBox txtCameraIndex1;
      private TextBox txtCameraIndex0;
      private TextBox txtCameraSubState;
      private TextBox txtCameraState;
      private CheckBox checkExternalQuickViewSubState;
      private CheckBox checkExternalDefaultSubState;
      private CheckBox checkCockpitQuickViewSubState;
      private CheckBox checkCockpitInstrumentSubState;
      private CheckBox checkCockpitPilotSubState;
      private CheckBox checkShowcaseFixedSubState;
      private CheckBox checkShowcaseDroneSubState;
      private Label lblAileronTrimPct;
      private Label lblRudderTrimPct;
      private Label lblElevatorTrimPct;
      private Label lblTrailingFlapsRight;
      private Label lblTrailingFlapsLeft;
      private Label lblFlapsCurrentPosition;
      private Label lblFlapsNumberOfDetents;
      private Label lblCurrentFlapsLimit;
      private Label lblEngineTorque;
      private Label lblEngineITT;
      private Label lblEngineNGPct;
      private Label lblEngineNPRpm;
      private Label lblEngineTorquePct;
      private CheckBox checkCustomCameraState;
      private TrackBar trackFlaps;
      private Label lblSCTargetDesc;
      private Label lblSCTargetType;
      private CheckBox checkSmartcam;
      private Button btnPreviousSmartcam;
      private Button btnNextSmartcam;
      private Label label8;
   }
}
