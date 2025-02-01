using DevExpress.XtraEditors;

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
         lblBarometer1 = new LabelControl();
         label6 = new LabelControl();
         lblCurrentAircraft = new LabelControl();
         lblEngCondition1 = new LabelControl();
         lblMixture1Pct = new LabelControl();
         lblPropeller1Pct = new LabelControl();
         lblThrottle1Pct = new LabelControl();
         lblSpoilersPosition = new LabelControl();
         lblSpoilersHandlePosition = new LabelControl();
         lblSpoilersArmed = new LabelControl();
         lblSpoilersAvailable = new LabelControl();
         lblCustomCamera = new LabelControl();
         btnPreviousSmartcam = new SimpleButton();
         btnNextSmartcam = new SimpleButton();
         checkSmartcam = new CheckButton();
         lblSCTargetDesc = new LabelControl();
         lblSCTargetType = new LabelControl();
         trackFlaps = new TrackBar();
         checkCustomCameraState = new CheckButton();
         checkShowcaseFixedSubState = new CheckButton();
         lblEngineTorquePct = new LabelControl();
         checkShowcaseDroneSubState = new CheckButton();
         checkCamera9 = new CheckButton();
         lblEngineNPRpm = new LabelControl();
         checkCamera8 = new CheckButton();
         checkExternalQuickViewSubState = new CheckButton();
         checkCamera7 = new CheckButton();
         lblEngineNGPct = new LabelControl();
         checkCamera6 = new CheckButton();
         checkExternalDefaultSubState = new CheckButton();
         checkCamera5 = new CheckButton();
         lblEngineITT = new LabelControl();
         checkCamera4 = new CheckButton();
         checkCockpitQuickViewSubState = new CheckButton();
         checkCamera3 = new CheckButton();
         lblEngineTorque = new LabelControl();
         checkCamera2 = new CheckButton();
         checkCockpitInstrumentSubState = new CheckButton();
         checkCamera1 = new CheckButton();
         lblFlapsCurrentPosition = new LabelControl();
         checkCamera10 = new CheckButton();
         checkCockpitPilotSubState = new CheckButton();
         lblFlapsNumberOfDetents = new LabelControl();
         lblIndex1 = new LabelControl();
         btnPreviousSubView = new SimpleButton();
         lblIndex0 = new LabelControl();
         lblCurrentFlapsLimit = new LabelControl();
         lblCameraSubstate = new LabelControl();
         btnNextSubView = new SimpleButton();
         lblCameraState = new LabelControl();
         lblTrailingFlapsRight = new LabelControl();
         btnPreviousView = new SimpleButton();
         lblTrailingFlapsLeft = new LabelControl();
         btnNextView = new SimpleButton();
         lblAileronTrimPct = new LabelControl();
         lblRudderTrimPct = new LabelControl();
         lblElevatorTrimPct = new LabelControl();
         btnSetCamera = new SimpleButton();
         txtCameraIndex1 = new TextBox();
         txtCameraIndex0 = new TextBox();
         txtCameraSubState = new TextBox();
         txtCameraState = new TextBox();
         groupBox1 = new GroupBox();
         btnSimRateReset = new SimpleButton();
         btnSimRateDec = new SimpleButton();
         btnSimRateInc = new SimpleButton();
         lblSimRate = new LabelControl();
         lblCurrentCameraType = new LabelControl();
         txtOutput = new TextBox();
         groupCameras = new GroupBox();
         checkCameraPilotCoPilot = new CheckButton();
         checkCameraPilotLand = new CheckButton();
         checkCameraPilotClose = new CheckButton();
         checkCameraPilotNormal = new CheckButton();
         lblCameraCurrentView = new LabelControl();
         groupFuel = new GroupBox();
         lblFuelDumpSwitch = new LabelControl();
         btnFuelDump = new SimpleButton();
         lblTotalFuelPct = new LabelControl();
         btnAddFuel = new SimpleButton();
         groupPause = new GroupBox();
         btnPauseSim = new SimpleButton();
         checkPauseEsc = new CheckButton();
         checkPauseSim = new CheckButton();
         checkPauseActive = new CheckButton();
         checkPauseFull = new CheckButton();
         btnPauseFull = new SimpleButton();
         groupFms = new GroupBox();
         btnFmsMfdInner = new SimpleButton();
         btnFmsMfdOuter = new SimpleButton();
         btnFmsEnt = new SimpleButton();
         btnFmsClr = new SimpleButton();
         btnFmsMenu = new SimpleButton();
         btnFmsProc = new SimpleButton();
         btnFmsFpl = new SimpleButton();
         btnFmsDirect = new SimpleButton();
         btnFmsPfdInner = new SimpleButton();
         btnFmsPfdOuter = new SimpleButton();
         groupAutopilot = new GroupBox();
         lblApproachStatus = new LabelControl();
         btnCrs2Sel = new SimpleButton();
         checkApSpd = new CheckButton();
         checkApFlc = new CheckButton();
         btnNoseUpDn = new SimpleButton();
         checkApVnv = new CheckButton();
         checkApVsHold = new CheckButton();
         btnAltSel = new SimpleButton();
         checkApAltHold = new CheckButton();
         checkApYd = new CheckButton();
         checkApFd = new CheckButton();
         checkApMaster = new CheckButton();
         btnCrs1Sel = new SimpleButton();
         btnHdgSel = new SimpleButton();
         checkApBcHold = new CheckButton();
         checkApAprHold = new CheckButton();
         checkApNavHold = new CheckButton();
         checkApHdgHold = new CheckButton();
         groupLights = new GroupBox();
         checkBeaconLight = new CheckButton();
         checkWingLight = new CheckButton();
         checkCabinLight = new CheckButton();
         checkTaxiLight = new CheckButton();
         checkGlareshieldLight = new CheckButton();
         checkStrobeLight = new CheckButton();
         checkLandingLight = new CheckButton();
         checkRecognitionLight = new CheckButton();
         checkLogoLight = new CheckButton();
         checkPedestralLight = new CheckButton();
         checkNavLight = new CheckButton();
         checkPanelLight = new CheckButton();
         lblTransponder = new LabelControl();
         label4 = new LabelControl();
         lblVerticalSpeedValue = new LabelControl();
         label7 = new LabelControl();
         lblAltitudeValue = new LabelControl();
         label5 = new LabelControl();
         lblCourseValue = new LabelControl();
         label3 = new LabelControl();
         lblHeadingValue = new LabelControl();
         groupNav2 = new GroupBox();
         lblNav2StandbyValue = new LabelControl();
         lblNav2ActiveValue = new LabelControl();
         lblNav2Standby = new LabelControl();
         lblNav2Active = new LabelControl();
         label2 = new LabelControl();
         groupNav1 = new GroupBox();
         lblNav1StandbyValue = new LabelControl();
         lblNav1ActiveValue = new LabelControl();
         lblNav1Standby = new LabelControl();
         lblNav1Active = new LabelControl();
         groupCom2 = new GroupBox();
         lblCom2Standby = new LabelControl();
         lblCom2StandbyValue = new LabelControl();
         lblCom2ActiveValue = new LabelControl();
         lblCom2Active = new LabelControl();
         groupCom1 = new GroupBox();
         lblCom1StandbyValue = new LabelControl();
         lblCom1ActiveValue = new LabelControl();
         lblCom1Standby = new LabelControl();
         lblCom1Active = new LabelControl();
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
         toolStripContainer1.ContentPanel.Controls.Add(lblBarometer1);
         toolStripContainer1.ContentPanel.Controls.Add(label6);
         toolStripContainer1.ContentPanel.Controls.Add(lblCurrentAircraft);
         toolStripContainer1.ContentPanel.Controls.Add(lblEngCondition1);
         toolStripContainer1.ContentPanel.Controls.Add(lblMixture1Pct);
         toolStripContainer1.ContentPanel.Controls.Add(lblPropeller1Pct);
         toolStripContainer1.ContentPanel.Controls.Add(lblThrottle1Pct);
         toolStripContainer1.ContentPanel.Controls.Add(lblSpoilersPosition);
         toolStripContainer1.ContentPanel.Controls.Add(lblSpoilersHandlePosition);
         toolStripContainer1.ContentPanel.Controls.Add(lblSpoilersArmed);
         toolStripContainer1.ContentPanel.Controls.Add(lblSpoilersAvailable);
         toolStripContainer1.ContentPanel.Controls.Add(lblCustomCamera);
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
         toolStripContainer1.ContentPanel.Margin = new Padding(4, 3, 4, 3);
         toolStripContainer1.ContentPanel.Size = new Size(1133, 674);
         toolStripContainer1.Dock = DockStyle.Fill;
         toolStripContainer1.Location = new Point(0, 0);
         toolStripContainer1.Margin = new Padding(4, 3, 4, 3);
         toolStripContainer1.Name = "toolStripContainer1";
         toolStripContainer1.Size = new Size(1133, 721);
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
         // lblBarometer1
         // 
         lblBarometer1.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblBarometer1.Appearance.Options.UseFont = true;
         lblBarometer1.Location = new Point(158, 522);
         lblBarometer1.Margin = new Padding(4, 3, 4, 3);
         lblBarometer1.Name = "lblBarometer1";
         lblBarometer1.Size = new Size(70, 40);
         lblBarometer1.TabIndex = 184;
         lblBarometer1.Text = "00.00";
         // 
         // label6
         // 
         label6.Location = new Point(158, 502);
         label6.Margin = new Padding(4, 3, 4, 3);
         label6.Name = "label6";
         label6.Size = new Size(52, 17);
         label6.TabIndex = 183;
         label6.Text = "Altimeter";
         // 
         // lblCurrentAircraft
         // 
         lblCurrentAircraft.Location = new Point(501, 650);
         lblCurrentAircraft.Margin = new Padding(4, 3, 4, 3);
         lblCurrentAircraft.Name = "lblCurrentAircraft";
         lblCurrentAircraft.Size = new Size(42, 17);
         lblCurrentAircraft.TabIndex = 182;
         lblCurrentAircraft.Text = "Aircraft";
         // 
         // lblEngCondition1
         // 
         lblEngCondition1.Location = new Point(525, 355);
         lblEngCondition1.Margin = new Padding(4, 3, 4, 3);
         lblEngCondition1.Name = "lblEngCondition1";
         lblEngCondition1.Size = new Size(74, 17);
         lblEngCondition1.TabIndex = 181;
         lblEngCondition1.Text = "Condition 1: ";
         // 
         // lblMixture1Pct
         // 
         lblMixture1Pct.Location = new Point(525, 338);
         lblMixture1Pct.Margin = new Padding(4, 3, 4, 3);
         lblMixture1Pct.Name = "lblMixture1Pct";
         lblMixture1Pct.Size = new Size(80, 17);
         lblMixture1Pct.TabIndex = 180;
         lblMixture1Pct.Text = "Mixture 1: 0%";
         // 
         // lblPropeller1Pct
         // 
         lblPropeller1Pct.Location = new Point(525, 321);
         lblPropeller1Pct.Margin = new Padding(4, 3, 4, 3);
         lblPropeller1Pct.Name = "lblPropeller1Pct";
         lblPropeller1Pct.Size = new Size(89, 17);
         lblPropeller1Pct.TabIndex = 179;
         lblPropeller1Pct.Text = "Propeller 1: 0%";
         // 
         // lblThrottle1Pct
         // 
         lblThrottle1Pct.Location = new Point(525, 304);
         lblThrottle1Pct.Margin = new Padding(4, 3, 4, 3);
         lblThrottle1Pct.Name = "lblThrottle1Pct";
         lblThrottle1Pct.Size = new Size(81, 17);
         lblThrottle1Pct.TabIndex = 178;
         lblThrottle1Pct.Text = "Throttle 1: 0%";
         // 
         // lblSpoilersPosition
         // 
         lblSpoilersPosition.Location = new Point(911, 304);
         lblSpoilersPosition.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersPosition.Name = "lblSpoilersPosition";
         lblSpoilersPosition.Size = new Size(148, 17);
         lblSpoilersPosition.TabIndex = 177;
         lblSpoilersPosition.Text = "Spoilers Position: 0 L, 0 R";
         // 
         // lblSpoilersHandlePosition
         // 
         lblSpoilersHandlePosition.Location = new Point(911, 287);
         lblSpoilersHandlePosition.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersHandlePosition.Name = "lblSpoilersHandlePosition";
         lblSpoilersHandlePosition.Size = new Size(106, 17);
         lblSpoilersHandlePosition.TabIndex = 176;
         lblSpoilersHandlePosition.Text = "Spoilers Handle: 0";
         // 
         // lblSpoilersArmed
         // 
         lblSpoilersArmed.Location = new Point(911, 270);
         lblSpoilersArmed.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersArmed.Name = "lblSpoilersArmed";
         lblSpoilersArmed.Size = new Size(116, 17);
         lblSpoilersArmed.TabIndex = 175;
         lblSpoilersArmed.Text = "Spoilers Not Armed";
         // 
         // lblSpoilersAvailable
         // 
         lblSpoilersAvailable.Location = new Point(911, 253);
         lblSpoilersAvailable.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersAvailable.Name = "lblSpoilersAvailable";
         lblSpoilersAvailable.Size = new Size(86, 17);
         lblSpoilersAvailable.TabIndex = 174;
         lblSpoilersAvailable.Text = "Spoilers: None";
         // 
         // lblCustomCamera
         // 
         lblCustomCamera.Location = new Point(686, 355);
         lblCustomCamera.Margin = new Padding(4, 3, 4, 3);
         lblCustomCamera.Name = "lblCustomCamera";
         lblCustomCamera.Size = new Size(74, 17);
         lblCustomCamera.TabIndex = 173;
         lblCustomCamera.Text = "Cust Camera";
         // 
         // btnPreviousSmartcam
         // 
         btnPreviousSmartcam.Location = new Point(820, 438);
         btnPreviousSmartcam.Margin = new Padding(4, 3, 4, 3);
         btnPreviousSmartcam.Name = "btnPreviousSmartcam";
         btnPreviousSmartcam.Size = new Size(42, 27);
         btnPreviousSmartcam.TabIndex = 172;
         btnPreviousSmartcam.Text = "SC-";
         //btnPreviousSmartcam.UseVisualStyleBackColor = true;
         btnPreviousSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // btnNextSmartcam
         // 
         btnNextSmartcam.Location = new Point(820, 405);
         btnNextSmartcam.Margin = new Padding(4, 3, 4, 3);
         btnNextSmartcam.Name = "btnNextSmartcam";
         btnNextSmartcam.Size = new Size(42, 27);
         btnNextSmartcam.TabIndex = 171;
         btnNextSmartcam.Text = "SC+";
         //btnNextSmartcam.UseVisualStyleBackColor = true;
         btnNextSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // checkSmartcam
         // 
         checkSmartcam.Location = new Point(820, 371);
         checkSmartcam.Margin = new Padding(4, 3, 4, 3);
         checkSmartcam.Name = "checkSmartcam";
         checkSmartcam.Size = new Size(60, 27);
         checkSmartcam.TabIndex = 170;
         checkSmartcam.Text = "SC";
         checkSmartcam.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblSCTargetDesc
         // 
         lblSCTargetDesc.Location = new Point(413, 371);
         lblSCTargetDesc.Margin = new Padding(4, 3, 4, 3);
         lblSCTargetDesc.Name = "lblSCTargetDesc";
         lblSCTargetDesc.Size = new Size(89, 17);
         lblSCTargetDesc.TabIndex = 169;
         lblSCTargetDesc.Text = "SC Target Desc";
         // 
         // lblSCTargetType
         // 
         lblSCTargetType.Location = new Point(413, 352);
         lblSCTargetType.Margin = new Padding(4, 3, 4, 3);
         lblSCTargetType.Name = "lblSCTargetType";
         lblSCTargetType.Size = new Size(89, 17);
         lblSCTargetType.TabIndex = 168;
         lblSCTargetType.Text = "SC Target Type";
         // 
         // trackFlaps
         // 
         trackFlaps.Location = new Point(769, 398);
         trackFlaps.Margin = new Padding(4, 3, 4, 3);
         trackFlaps.Name = "trackFlaps";
         trackFlaps.Orientation = Orientation.Vertical;
         trackFlaps.Size = new Size(45, 206);
         trackFlaps.TabIndex = 167;
         trackFlaps.ValueChanged += TrackFlaps_ValueChanged;
         // 
         // checkCustomCameraState
         // 
         checkCustomCameraState.Location = new Point(1004, 603);
         checkCustomCameraState.Margin = new Padding(4, 3, 4, 3);
         checkCustomCameraState.Name = "checkCustomCameraState";
         checkCustomCameraState.Size = new Size(60, 27);
         checkCustomCameraState.TabIndex = 80;
         checkCustomCameraState.Text = "Custom";
         checkCustomCameraState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkShowcaseFixedSubState
         // 
         checkShowcaseFixedSubState.Location = new Point(1004, 570);
         checkShowcaseFixedSubState.Margin = new Padding(4, 3, 4, 3);
         checkShowcaseFixedSubState.Name = "checkShowcaseFixedSubState";
         checkShowcaseFixedSubState.Size = new Size(60, 27);
         checkShowcaseFixedSubState.TabIndex = 74;
         checkShowcaseFixedSubState.Text = "X-Fixed";
         checkShowcaseFixedSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineTorquePct
         // 
         lblEngineTorquePct.Location = new Point(413, 315);
         lblEngineTorquePct.Margin = new Padding(4, 3, 4, 3);
         lblEngineTorquePct.Name = "lblEngineTorquePct";
         lblEngineTorquePct.Size = new Size(40, 17);
         lblEngineTorquePct.TabIndex = 79;
         lblEngineTorquePct.Text = "TRQ %";
         // 
         // checkShowcaseDroneSubState
         // 
         checkShowcaseDroneSubState.Location = new Point(1004, 537);
         checkShowcaseDroneSubState.Margin = new Padding(4, 3, 4, 3);
         checkShowcaseDroneSubState.Name = "checkShowcaseDroneSubState";
         checkShowcaseDroneSubState.Size = new Size(60, 27);
         checkShowcaseDroneSubState.TabIndex = 73;
         checkShowcaseDroneSubState.Text = "Drone";
         checkShowcaseDroneSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera9
         // 
         checkCamera9.Location = new Point(960, 469);
         checkCamera9.Margin = new Padding(4, 3, 4, 3);
         checkCamera9.Name = "checkCamera9";
         checkCamera9.Size = new Size(31, 27);
         checkCamera9.TabIndex = 52;
         checkCamera9.Tag = "9";
         checkCamera9.Text = "9";
         checkCamera9.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineNPRpm
         // 
         lblEngineNPRpm.Location = new Point(294, 366);
         lblEngineNPRpm.Margin = new Padding(4, 3, 4, 3);
         lblEngineNPRpm.Name = "lblEngineNPRpm";
         lblEngineNPRpm.Size = new Size(48, 17);
         lblEngineNPRpm.TabIndex = 78;
         lblEngineNPRpm.Text = "NP RPM";
         // 
         // checkCamera8
         // 
         checkCamera8.Location = new Point(924, 469);
         checkCamera8.Margin = new Padding(4, 3, 4, 3);
         checkCamera8.Name = "checkCamera8";
         checkCamera8.Size = new Size(31, 27);
         checkCamera8.TabIndex = 51;
         checkCamera8.Tag = "8";
         checkCamera8.Text = "8";
         checkCamera8.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkExternalQuickViewSubState
         // 
         checkExternalQuickViewSubState.Location = new Point(1004, 503);
         checkExternalQuickViewSubState.Margin = new Padding(4, 3, 4, 3);
         checkExternalQuickViewSubState.Name = "checkExternalQuickViewSubState";
         checkExternalQuickViewSubState.Size = new Size(60, 27);
         checkExternalQuickViewSubState.TabIndex = 72;
         checkExternalQuickViewSubState.Text = "X-QV";
         checkExternalQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera7
         // 
         checkCamera7.Location = new Point(888, 471);
         checkCamera7.Margin = new Padding(4, 3, 4, 3);
         checkCamera7.Name = "checkCamera7";
         checkCamera7.Size = new Size(31, 27);
         checkCamera7.TabIndex = 50;
         checkCamera7.Tag = "7";
         checkCamera7.Text = "7";
         checkCamera7.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineNGPct
         // 
         lblEngineNGPct.Location = new Point(294, 349);
         lblEngineNGPct.Margin = new Padding(4, 3, 4, 3);
         lblEngineNGPct.Name = "lblEngineNGPct";
         lblEngineNGPct.Size = new Size(34, 17);
         lblEngineNGPct.TabIndex = 77;
         lblEngineNGPct.Text = "NG %";
         // 
         // checkCamera6
         // 
         checkCamera6.Location = new Point(960, 503);
         checkCamera6.Margin = new Padding(4, 3, 4, 3);
         checkCamera6.Name = "checkCamera6";
         checkCamera6.Size = new Size(31, 27);
         checkCamera6.TabIndex = 49;
         checkCamera6.Tag = "6";
         checkCamera6.Text = "6";
         checkCamera6.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkExternalDefaultSubState
         // 
         checkExternalDefaultSubState.Location = new Point(1004, 471);
         checkExternalDefaultSubState.Margin = new Padding(4, 3, 4, 3);
         checkExternalDefaultSubState.Name = "checkExternalDefaultSubState";
         checkExternalDefaultSubState.Size = new Size(60, 27);
         checkExternalDefaultSubState.TabIndex = 71;
         checkExternalDefaultSubState.Text = "EXT";
         checkExternalDefaultSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera5
         // 
         checkCamera5.Location = new Point(924, 503);
         checkCamera5.Margin = new Padding(4, 3, 4, 3);
         checkCamera5.Name = "checkCamera5";
         checkCamera5.Size = new Size(31, 27);
         checkCamera5.TabIndex = 48;
         checkCamera5.Tag = "5";
         checkCamera5.Text = "5";
         checkCamera5.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineITT
         // 
         lblEngineITT.Location = new Point(294, 332);
         lblEngineITT.Margin = new Padding(4, 3, 4, 3);
         lblEngineITT.Name = "lblEngineITT";
         lblEngineITT.Size = new Size(17, 17);
         lblEngineITT.TabIndex = 76;
         lblEngineITT.Text = "ITT";
         // 
         // checkCamera4
         // 
         checkCamera4.Location = new Point(888, 503);
         checkCamera4.Margin = new Padding(4, 3, 4, 3);
         checkCamera4.Name = "checkCamera4";
         checkCamera4.Size = new Size(31, 27);
         checkCamera4.TabIndex = 47;
         checkCamera4.Tag = "4";
         checkCamera4.Text = "4";
         checkCamera4.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitQuickViewSubState
         // 
         checkCockpitQuickViewSubState.Location = new Point(1004, 438);
         checkCockpitQuickViewSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitQuickViewSubState.Name = "checkCockpitQuickViewSubState";
         checkCockpitQuickViewSubState.Size = new Size(60, 27);
         checkCockpitQuickViewSubState.TabIndex = 70;
         checkCockpitQuickViewSubState.Text = "C-QV";
         checkCockpitQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera3
         // 
         checkCamera3.Location = new Point(960, 537);
         checkCamera3.Margin = new Padding(4, 3, 4, 3);
         checkCamera3.Name = "checkCamera3";
         checkCamera3.Size = new Size(31, 27);
         checkCamera3.TabIndex = 46;
         checkCamera3.Tag = "3";
         checkCamera3.Text = "3";
         checkCamera3.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineTorque
         // 
         lblEngineTorque.Location = new Point(294, 315);
         lblEngineTorque.Margin = new Padding(4, 3, 4, 3);
         lblEngineTorque.Name = "lblEngineTorque";
         lblEngineTorque.Size = new Size(42, 17);
         lblEngineTorque.TabIndex = 75;
         lblEngineTorque.Text = "Torque";
         // 
         // checkCamera2
         // 
         checkCamera2.Location = new Point(924, 537);
         checkCamera2.Margin = new Padding(4, 3, 4, 3);
         checkCamera2.Name = "checkCamera2";
         checkCamera2.Size = new Size(31, 27);
         checkCamera2.TabIndex = 45;
         checkCamera2.Tag = "2";
         checkCamera2.Text = "2";
         checkCamera2.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitInstrumentSubState
         // 
         checkCockpitInstrumentSubState.Location = new Point(1004, 405);
         checkCockpitInstrumentSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitInstrumentSubState.Name = "checkCockpitInstrumentSubState";
         checkCockpitInstrumentSubState.Size = new Size(60, 27);
         checkCockpitInstrumentSubState.TabIndex = 69;
         checkCockpitInstrumentSubState.Text = "Instr";
         checkCockpitInstrumentSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera1
         // 
         checkCamera1.Location = new Point(888, 537);
         checkCamera1.Margin = new Padding(4, 3, 4, 3);
         checkCamera1.Name = "checkCamera1";
         checkCamera1.Size = new Size(31, 27);
         checkCamera1.TabIndex = 44;
         checkCamera1.Tag = "1";
         checkCamera1.Text = "1";
         checkCamera1.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblFlapsCurrentPosition
         // 
         lblFlapsCurrentPosition.Location = new Point(686, 323);
         lblFlapsCurrentPosition.Margin = new Padding(4, 3, 4, 3);
         lblFlapsCurrentPosition.Name = "lblFlapsCurrentPosition";
         lblFlapsCurrentPosition.Size = new Size(93, 17);
         lblFlapsCurrentPosition.TabIndex = 74;
         lblFlapsCurrentPosition.Text = "Current Position";
         // 
         // checkCamera10
         // 
         checkCamera10.Location = new Point(888, 570);
         checkCamera10.Margin = new Padding(4, 3, 4, 3);
         checkCamera10.Name = "checkCamera10";
         checkCamera10.Size = new Size(66, 27);
         checkCamera10.TabIndex = 43;
         checkCamera10.Tag = "0";
         checkCamera10.Text = "0";
         checkCamera10.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCockpitPilotSubState
         // 
         checkCockpitPilotSubState.Location = new Point(1004, 371);
         checkCockpitPilotSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitPilotSubState.Name = "checkCockpitPilotSubState";
         checkCockpitPilotSubState.Size = new Size(60, 27);
         checkCockpitPilotSubState.TabIndex = 68;
         checkCockpitPilotSubState.Text = "Pilot";
         checkCockpitPilotSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblFlapsNumberOfDetents
         // 
         lblFlapsNumberOfDetents.Location = new Point(686, 304);
         lblFlapsNumberOfDetents.Margin = new Padding(4, 3, 4, 3);
         lblFlapsNumberOfDetents.Name = "lblFlapsNumberOfDetents";
         lblFlapsNumberOfDetents.Size = new Size(112, 17);
         lblFlapsNumberOfDetents.TabIndex = 73;
         lblFlapsNumberOfDetents.Text = "Number of Detents";
         // 
         // lblIndex1
         // 
         lblIndex1.Location = new Point(192, 654);
         lblIndex1.Margin = new Padding(4, 3, 4, 3);
         lblIndex1.Name = "lblIndex1";
         lblIndex1.Size = new Size(51, 17);
         lblIndex1.TabIndex = 60;
         lblIndex1.Text = "Index1: x";
         // 
         // btnPreviousSubView
         // 
         btnPreviousSubView.Location = new Point(942, 405);
         btnPreviousSubView.Margin = new Padding(4, 3, 4, 3);
         btnPreviousSubView.Name = "btnPreviousSubView";
         btnPreviousSubView.Size = new Size(42, 27);
         btnPreviousSubView.TabIndex = 166;
         btnPreviousSubView.Text = "PSV";
         //btnPreviousSubView.UseVisualStyleBackColor = true;
         btnPreviousSubView.Click += CameraViewButton_Click;
         // 
         // lblIndex0
         // 
         lblIndex0.Location = new Point(192, 637);
         lblIndex0.Margin = new Padding(4, 3, 4, 3);
         lblIndex0.Name = "lblIndex0";
         lblIndex0.Size = new Size(51, 17);
         lblIndex0.TabIndex = 60;
         lblIndex0.Text = "Index0: x";
         // 
         // lblCurrentFlapsLimit
         // 
         lblCurrentFlapsLimit.Location = new Point(686, 287);
         lblCurrentFlapsLimit.Margin = new Padding(4, 3, 4, 3);
         lblCurrentFlapsLimit.Name = "lblCurrentFlapsLimit";
         lblCurrentFlapsLimit.Size = new Size(108, 17);
         lblCurrentFlapsLimit.TabIndex = 72;
         lblCurrentFlapsLimit.Text = "Current Flaps Limit";
         // 
         // lblCameraSubstate
         // 
         lblCameraSubstate.Location = new Point(192, 620);
         lblCameraSubstate.Margin = new Padding(4, 3, 4, 3);
         lblCameraSubstate.Name = "lblCameraSubstate";
         lblCameraSubstate.Size = new Size(63, 17);
         lblCameraSubstate.TabIndex = 59;
         lblCameraSubstate.Text = "Substate: x";
         // 
         // btnNextSubView
         // 
         btnNextSubView.Location = new Point(942, 371);
         btnNextSubView.Margin = new Padding(4, 3, 4, 3);
         btnNextSubView.Name = "btnNextSubView";
         btnNextSubView.Size = new Size(42, 27);
         btnNextSubView.TabIndex = 165;
         btnNextSubView.Text = "NSV";
         //btnNextSubView.UseVisualStyleBackColor = true;
         btnNextSubView.Click += CameraViewButton_Click;
         // 
         // lblCameraState
         // 
         lblCameraState.Location = new Point(192, 603);
         lblCameraState.Margin = new Padding(4, 3, 4, 3);
         lblCameraState.Name = "lblCameraState";
         lblCameraState.Size = new Size(42, 17);
         lblCameraState.TabIndex = 58;
         lblCameraState.Text = "State: x";
         // 
         // lblTrailingFlapsRight
         // 
         lblTrailingFlapsRight.Location = new Point(686, 270);
         lblTrailingFlapsRight.Margin = new Padding(4, 3, 4, 3);
         lblTrailingFlapsRight.Name = "lblTrailingFlapsRight";
         lblTrailingFlapsRight.Size = new Size(111, 17);
         lblTrailingFlapsRight.TabIndex = 71;
         lblTrailingFlapsRight.Text = "Trailing Flaps Right";
         // 
         // btnPreviousView
         // 
         btnPreviousView.Location = new Point(888, 405);
         btnPreviousView.Margin = new Padding(4, 3, 4, 3);
         btnPreviousView.Name = "btnPreviousView";
         btnPreviousView.Size = new Size(42, 27);
         btnPreviousView.TabIndex = 165;
         btnPreviousView.Text = "PV";
         //btnPreviousView.UseVisualStyleBackColor = true;
         btnPreviousView.Click += CameraViewButton_Click;
         // 
         // lblTrailingFlapsLeft
         // 
         lblTrailingFlapsLeft.Location = new Point(686, 253);
         lblTrailingFlapsLeft.Margin = new Padding(4, 3, 4, 3);
         lblTrailingFlapsLeft.Name = "lblTrailingFlapsLeft";
         lblTrailingFlapsLeft.Size = new Size(102, 17);
         lblTrailingFlapsLeft.TabIndex = 70;
         lblTrailingFlapsLeft.Text = "Trailing Flaps Left";
         // 
         // btnNextView
         // 
         btnNextView.Location = new Point(888, 371);
         btnNextView.Margin = new Padding(4, 3, 4, 3);
         btnNextView.Name = "btnNextView";
         btnNextView.Size = new Size(42, 27);
         btnNextView.TabIndex = 164;
         btnNextView.Text = "NV";
         //btnNextView.UseVisualStyleBackColor = true;
         btnNextView.Click += CameraViewButton_Click;
         // 
         // lblAileronTrimPct
         // 
         lblAileronTrimPct.Location = new Point(525, 276);
         lblAileronTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblAileronTrimPct.Name = "lblAileronTrimPct";
         lblAileronTrimPct.Size = new Size(96, 17);
         lblAileronTrimPct.TabIndex = 69;
         lblAileronTrimPct.Text = "Aileron Trim: 0%";
         // 
         // lblRudderTrimPct
         // 
         lblRudderTrimPct.Location = new Point(525, 259);
         lblRudderTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblRudderTrimPct.Name = "lblRudderTrimPct";
         lblRudderTrimPct.Size = new Size(98, 17);
         lblRudderTrimPct.TabIndex = 68;
         lblRudderTrimPct.Text = "Rudder Trim: 0%";
         // 
         // lblElevatorTrimPct
         // 
         lblElevatorTrimPct.Location = new Point(525, 242);
         lblElevatorTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblElevatorTrimPct.Name = "lblElevatorTrimPct";
         lblElevatorTrimPct.Size = new Size(102, 17);
         lblElevatorTrimPct.TabIndex = 2;
         lblElevatorTrimPct.Text = "Elevator Trim: 0%";
         // 
         // btnSetCamera
         // 
         btnSetCamera.Location = new Point(340, 282);
         btnSetCamera.Margin = new Padding(4, 3, 4, 3);
         btnSetCamera.Name = "btnSetCamera";
         btnSetCamera.Size = new Size(140, 24);
         btnSetCamera.TabIndex = 67;
         btnSetCamera.Text = "Set Camera";
         //btnSetCamera.UseVisualStyleBackColor = true;
         btnSetCamera.Click += btnSetCamera_Click;
         // 
         // txtCameraIndex1
         // 
         txtCameraIndex1.Location = new Point(451, 251);
         txtCameraIndex1.Margin = new Padding(4, 3, 4, 3);
         txtCameraIndex1.Name = "txtCameraIndex1";
         txtCameraIndex1.Size = new Size(31, 25);
         txtCameraIndex1.TabIndex = 66;
         // 
         // txtCameraIndex0
         // 
         txtCameraIndex0.Location = new Point(413, 251);
         txtCameraIndex0.Margin = new Padding(4, 3, 4, 3);
         txtCameraIndex0.Name = "txtCameraIndex0";
         txtCameraIndex0.Size = new Size(31, 25);
         txtCameraIndex0.TabIndex = 65;
         // 
         // txtCameraSubState
         // 
         txtCameraSubState.Location = new Point(375, 251);
         txtCameraSubState.Margin = new Padding(4, 3, 4, 3);
         txtCameraSubState.Name = "txtCameraSubState";
         txtCameraSubState.Size = new Size(31, 25);
         txtCameraSubState.TabIndex = 64;
         // 
         // txtCameraState
         // 
         txtCameraState.Location = new Point(340, 251);
         txtCameraState.Margin = new Padding(4, 3, 4, 3);
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
         groupBox1.Margin = new Padding(4, 3, 4, 3);
         groupBox1.Name = "groupBox1";
         groupBox1.Padding = new Padding(4, 3, 4, 3);
         groupBox1.Size = new Size(178, 95);
         groupBox1.TabIndex = 62;
         groupBox1.TabStop = false;
         groupBox1.Text = "Time";
         // 
         // btnSimRateReset
         // 
         btnSimRateReset.AutoSize = true;
         btnSimRateReset.Location = new Point(73, 41);
         btnSimRateReset.Margin = new Padding(4, 3, 4, 3);
         btnSimRateReset.Name = "btnSimRateReset";
         btnSimRateReset.Size = new Size(52, 30);
         btnSimRateReset.TabIndex = 69;
         btnSimRateReset.Text = "Reset";
         //btnSimRateReset.UseVisualStyleBackColor = true;
         btnSimRateReset.Click += SimRateButton_Click;
         // 
         // btnSimRateDec
         // 
         btnSimRateDec.Location = new Point(6, 41);
         btnSimRateDec.Margin = new Padding(4, 3, 4, 3);
         btnSimRateDec.Name = "btnSimRateDec";
         btnSimRateDec.Size = new Size(27, 27);
         btnSimRateDec.TabIndex = 68;
         btnSimRateDec.Text = "-";
         //btnSimRateDec.UseVisualStyleBackColor = true;
         btnSimRateDec.Click += SimRateButton_Click;
         // 
         // btnSimRateInc
         // 
         btnSimRateInc.Location = new Point(38, 41);
         btnSimRateInc.Margin = new Padding(4, 3, 4, 3);
         btnSimRateInc.Name = "btnSimRateInc";
         btnSimRateInc.Size = new Size(27, 27);
         btnSimRateInc.TabIndex = 67;
         btnSimRateInc.Text = "+";
         //btnSimRateInc.UseVisualStyleBackColor = true;
         btnSimRateInc.Click += SimRateButton_Click;
         // 
         // lblSimRate
         // 
         lblSimRate.Location = new Point(6, 21);
         lblSimRate.Margin = new Padding(4, 3, 4, 3);
         lblSimRate.Name = "lblSimRate";
         lblSimRate.Size = new Size(71, 17);
         lblSimRate.TabIndex = 0;
         lblSimRate.Text = "Sim Rate: 1x";
         // 
         // lblCurrentCameraType
         // 
         lblCurrentCameraType.Location = new Point(724, 622);
         lblCurrentCameraType.Margin = new Padding(4, 3, 4, 3);
         lblCurrentCameraType.Name = "lblCurrentCameraType";
         lblCurrentCameraType.Size = new Size(124, 17);
         lblCurrentCameraType.TabIndex = 67;
         lblCurrentCameraType.Text = "Current Camera Type";
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(738, 233);
         txtOutput.Margin = new Padding(4, 3, 4, 3);
         txtOutput.Multiline = true;
         txtOutput.Name = "txtOutput";
         txtOutput.ReadOnly = true;
         txtOutput.Size = new Size(326, 91);
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
         groupCameras.Margin = new Padding(4, 3, 4, 3);
         groupCameras.Name = "groupCameras";
         groupCameras.Padding = new Padding(4, 3, 4, 3);
         groupCameras.Size = new Size(468, 129);
         groupCameras.TabIndex = 45;
         groupCameras.TabStop = false;
         groupCameras.Text = "Cameras";
         // 
         // checkCameraPilotCoPilot
         // 
         checkCameraPilotCoPilot.Location = new Point(204, 58);
         checkCameraPilotCoPilot.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotCoPilot.Name = "checkCameraPilotCoPilot";
         checkCameraPilotCoPilot.Size = new Size(60, 27);
         checkCameraPilotCoPilot.TabIndex = 57;
         checkCameraPilotCoPilot.Text = "CoPilot";
         checkCameraPilotCoPilot.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotLand
         // 
         checkCameraPilotLand.Location = new Point(137, 58);
         checkCameraPilotLand.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotLand.Name = "checkCameraPilotLand";
         checkCameraPilotLand.Size = new Size(60, 27);
         checkCameraPilotLand.TabIndex = 56;
         checkCameraPilotLand.Text = "Land";
         checkCameraPilotLand.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotClose
         // 
         checkCameraPilotClose.Location = new Point(6, 58);
         checkCameraPilotClose.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotClose.Name = "checkCameraPilotClose";
         checkCameraPilotClose.Size = new Size(60, 27);
         checkCameraPilotClose.TabIndex = 55;
         checkCameraPilotClose.Text = "Close";
         checkCameraPilotClose.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotNormal
         // 
         checkCameraPilotNormal.Location = new Point(73, 58);
         checkCameraPilotNormal.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotNormal.Name = "checkCameraPilotNormal";
         checkCameraPilotNormal.Size = new Size(60, 27);
         checkCameraPilotNormal.TabIndex = 54;
         checkCameraPilotNormal.Text = "Pilot";
         checkCameraPilotNormal.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblCameraCurrentView
         // 
         lblCameraCurrentView.Location = new Point(295, 61);
         lblCameraCurrentView.Margin = new Padding(4, 3, 4, 3);
         lblCameraCurrentView.Name = "lblCameraCurrentView";
         lblCameraCurrentView.Size = new Size(119, 17);
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
         groupFuel.Margin = new Padding(4, 3, 4, 3);
         groupFuel.Name = "groupFuel";
         groupFuel.Padding = new Padding(4, 3, 4, 3);
         groupFuel.Size = new Size(193, 82);
         groupFuel.TabIndex = 40;
         groupFuel.TabStop = false;
         groupFuel.Text = "Fuel";
         // 
         // lblFuelDumpSwitch
         // 
         lblFuelDumpSwitch.Location = new Point(129, 53);
         lblFuelDumpSwitch.Margin = new Padding(4, 3, 4, 3);
         lblFuelDumpSwitch.Name = "lblFuelDumpSwitch";
         lblFuelDumpSwitch.Size = new Size(16, 17);
         lblFuelDumpSwitch.TabIndex = 67;
         lblFuelDumpSwitch.Text = "off";
         // 
         // btnFuelDump
         // 
         btnFuelDump.Location = new Point(66, 49);
         btnFuelDump.Margin = new Padding(4, 3, 4, 3);
         btnFuelDump.Name = "btnFuelDump";
         btnFuelDump.Size = new Size(55, 27);
         btnFuelDump.TabIndex = 66;
         btnFuelDump.Text = "DUMP";
         //btnFuelDump.UseVisualStyleBackColor = true;
         btnFuelDump.Click += btnFuelDump_Click;
         // 
         // lblTotalFuelPct
         // 
         lblTotalFuelPct.Location = new Point(6, 21);
         lblTotalFuelPct.Margin = new Padding(4, 3, 4, 3);
         lblTotalFuelPct.Name = "lblTotalFuelPct";
         lblTotalFuelPct.Size = new Size(105, 17);
         lblTotalFuelPct.TabIndex = 65;
         lblTotalFuelPct.Text = "Total Fuel: 100.0%";
         // 
         // btnAddFuel
         // 
         btnAddFuel.Location = new Point(6, 49);
         btnAddFuel.Margin = new Padding(4, 3, 4, 3);
         btnAddFuel.Name = "btnAddFuel";
         btnAddFuel.Size = new Size(55, 27);
         btnAddFuel.TabIndex = 64;
         btnAddFuel.Text = "ADD";
         //btnAddFuel.UseVisualStyleBackColor = true;
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
         groupPause.Margin = new Padding(4, 3, 4, 3);
         groupPause.Name = "groupPause";
         groupPause.Padding = new Padding(4, 3, 4, 3);
         groupPause.Size = new Size(242, 134);
         groupPause.TabIndex = 39;
         groupPause.TabStop = false;
         groupPause.Text = "Pause";
         // 
         // btnPauseSim
         // 
         btnPauseSim.Location = new Point(6, 78);
         btnPauseSim.Margin = new Padding(4, 3, 4, 3);
         btnPauseSim.Name = "btnPauseSim";
         btnPauseSim.Size = new Size(97, 48);
         btnPauseSim.TabIndex = 5;
         btnPauseSim.Text = "Sim Pause";
         //btnPauseSim.UseVisualStyleBackColor = true;
         btnPauseSim.Click += BtnPause_Click;
         // 
         // checkPauseEsc
         // 
         checkPauseEsc.AutoSize = true;
         checkPauseEsc.Location = new Point(116, 105);
         checkPauseEsc.Margin = new Padding(4, 3, 4, 3);
         checkPauseEsc.Name = "checkPauseEsc";
         checkPauseEsc.Size = new Size(64, 22);
         checkPauseEsc.TabIndex = 4;
         checkPauseEsc.Text = "Esc Pause";
         // 
         // checkPauseSim
         // 
         checkPauseSim.AutoSize = true;
         checkPauseSim.Location = new Point(116, 78);
         checkPauseSim.Margin = new Padding(4, 3, 4, 3);
         checkPauseSim.Name = "checkPauseSim";
         checkPauseSim.Size = new Size(66, 22);
         checkPauseSim.TabIndex = 3;
         checkPauseSim.Text = "Sim Pause";
         // 
         // checkPauseActive
         // 
         checkPauseActive.AutoSize = true;
         checkPauseActive.Location = new Point(116, 51);
         checkPauseActive.Margin = new Padding(4, 3, 4, 3);
         checkPauseActive.Name = "checkPauseActive";
         checkPauseActive.Size = new Size(79, 22);
         checkPauseActive.TabIndex = 2;
         checkPauseActive.Text = "Active Pause";
         // 
         // checkPauseFull
         // 
         checkPauseFull.AutoSize = true;
         checkPauseFull.Location = new Point(116, 24);
         checkPauseFull.Margin = new Padding(4, 3, 4, 3);
         checkPauseFull.Name = "checkPauseFull";
         checkPauseFull.Size = new Size(64, 22);
         checkPauseFull.TabIndex = 1;
         checkPauseFull.Text = "Full Pause";
         // 
         // btnPauseFull
         // 
         btnPauseFull.Location = new Point(6, 24);
         btnPauseFull.Margin = new Padding(4, 3, 4, 3);
         btnPauseFull.Name = "btnPauseFull";
         btnPauseFull.Size = new Size(97, 48);
         btnPauseFull.TabIndex = 0;
         btnPauseFull.Text = "Full Pause";
         //btnPauseFull.UseVisualStyleBackColor = true;
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
         groupFms.Margin = new Padding(4, 3, 4, 3);
         groupFms.Name = "groupFms";
         groupFms.Padding = new Padding(4, 3, 4, 3);
         groupFms.Size = new Size(396, 95);
         groupFms.TabIndex = 38;
         groupFms.TabStop = false;
         groupFms.Text = "FMS";
         // 
         // btnFmsMfdInner
         // 
         btnFmsMfdInner.Location = new Point(342, 30);
         btnFmsMfdInner.Margin = new Padding(4, 3, 4, 3);
         btnFmsMfdInner.Name = "btnFmsMfdInner";
         btnFmsMfdInner.Size = new Size(46, 44);
         btnFmsMfdInner.TabIndex = 63;
         btnFmsMfdInner.Text = "MFD\r\nIN";
         //btnFmsMfdInner.UseVisualStyleBackColor = true;
         // 
         // btnFmsMfdOuter
         // 
         btnFmsMfdOuter.Location = new Point(290, 30);
         btnFmsMfdOuter.Margin = new Padding(4, 3, 4, 3);
         btnFmsMfdOuter.Name = "btnFmsMfdOuter";
         btnFmsMfdOuter.Size = new Size(46, 44);
         btnFmsMfdOuter.TabIndex = 62;
         btnFmsMfdOuter.Text = "MFD\r\nOUT";
         //btnFmsMfdOuter.UseVisualStyleBackColor = true;
         // 
         // btnFmsEnt
         // 
         btnFmsEnt.Location = new Point(230, 58);
         btnFmsEnt.Margin = new Padding(4, 3, 4, 3);
         btnFmsEnt.Name = "btnFmsEnt";
         btnFmsEnt.Size = new Size(55, 27);
         btnFmsEnt.TabIndex = 61;
         btnFmsEnt.Text = "ENT";
         //btnFmsEnt.UseVisualStyleBackColor = true;
         btnFmsEnt.Click += FmsButton_Click;
         // 
         // btnFmsClr
         // 
         btnFmsClr.Location = new Point(169, 58);
         btnFmsClr.Margin = new Padding(4, 3, 4, 3);
         btnFmsClr.Name = "btnFmsClr";
         btnFmsClr.Size = new Size(55, 27);
         btnFmsClr.TabIndex = 60;
         btnFmsClr.Text = "CLR";
         //btnFmsClr.UseVisualStyleBackColor = true;
         btnFmsClr.Click += FmsButton_Click;
         // 
         // btnFmsMenu
         // 
         btnFmsMenu.Location = new Point(108, 58);
         btnFmsMenu.Margin = new Padding(4, 3, 4, 3);
         btnFmsMenu.Name = "btnFmsMenu";
         btnFmsMenu.Size = new Size(55, 27);
         btnFmsMenu.TabIndex = 59;
         btnFmsMenu.Text = "MENU";
         //btnFmsMenu.UseVisualStyleBackColor = true;
         btnFmsMenu.Click += FmsButton_Click;
         // 
         // btnFmsProc
         // 
         btnFmsProc.Location = new Point(230, 24);
         btnFmsProc.Margin = new Padding(4, 3, 4, 3);
         btnFmsProc.Name = "btnFmsProc";
         btnFmsProc.Size = new Size(55, 27);
         btnFmsProc.TabIndex = 58;
         btnFmsProc.Text = "PROC";
         //btnFmsProc.UseVisualStyleBackColor = true;
         btnFmsProc.Click += FmsButton_Click;
         // 
         // btnFmsFpl
         // 
         btnFmsFpl.Location = new Point(169, 24);
         btnFmsFpl.Margin = new Padding(4, 3, 4, 3);
         btnFmsFpl.Name = "btnFmsFpl";
         btnFmsFpl.Size = new Size(55, 27);
         btnFmsFpl.TabIndex = 57;
         btnFmsFpl.Text = "FPL";
         //btnFmsFpl.UseVisualStyleBackColor = true;
         btnFmsFpl.Click += FmsButton_Click;
         // 
         // btnFmsDirect
         // 
         btnFmsDirect.Location = new Point(108, 24);
         btnFmsDirect.Margin = new Padding(4, 3, 4, 3);
         btnFmsDirect.Name = "btnFmsDirect";
         btnFmsDirect.Size = new Size(55, 27);
         btnFmsDirect.TabIndex = 56;
         btnFmsDirect.Text = "DIR";
         //btnFmsDirect.UseVisualStyleBackColor = true;
         btnFmsDirect.Click += FmsButton_Click;
         // 
         // btnFmsPfdInner
         // 
         btnFmsPfdInner.Location = new Point(57, 30);
         btnFmsPfdInner.Margin = new Padding(4, 3, 4, 3);
         btnFmsPfdInner.Name = "btnFmsPfdInner";
         btnFmsPfdInner.Size = new Size(46, 44);
         btnFmsPfdInner.TabIndex = 55;
         btnFmsPfdInner.Text = "PFD\r\nIN";
         //btnFmsPfdInner.UseVisualStyleBackColor = true;
         // 
         // btnFmsPfdOuter
         // 
         btnFmsPfdOuter.Location = new Point(6, 30);
         btnFmsPfdOuter.Margin = new Padding(4, 3, 4, 3);
         btnFmsPfdOuter.Name = "btnFmsPfdOuter";
         btnFmsPfdOuter.Size = new Size(46, 44);
         btnFmsPfdOuter.TabIndex = 54;
         btnFmsPfdOuter.Text = "PFD\r\nOUT";
         //btnFmsPfdOuter.UseVisualStyleBackColor = true;
         // 
         // groupAutopilot
         // 
         groupAutopilot.Controls.Add(lblApproachStatus);
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
         groupAutopilot.Margin = new Padding(4, 3, 4, 3);
         groupAutopilot.Name = "groupAutopilot";
         groupAutopilot.Padding = new Padding(4, 3, 4, 3);
         groupAutopilot.Size = new Size(529, 134);
         groupAutopilot.TabIndex = 37;
         groupAutopilot.TabStop = false;
         groupAutopilot.Text = "Autopilot";
         // 
         // lblApproachStatus
         // 
         lblApproachStatus.Location = new Point(10, 109);
         lblApproachStatus.Margin = new Padding(4, 3, 4, 3);
         lblApproachStatus.Name = "lblApproachStatus";
         lblApproachStatus.Size = new Size(64, 17);
         lblApproachStatus.TabIndex = 54;
         lblApproachStatus.Text = "Approach: ";
         // 
         // btnCrs2Sel
         // 
         btnCrs2Sel.Location = new Point(473, 58);
         btnCrs2Sel.Margin = new Padding(4, 3, 4, 3);
         btnCrs2Sel.Name = "btnCrs2Sel";
         btnCrs2Sel.Size = new Size(46, 44);
         btnCrs2Sel.TabIndex = 53;
         btnCrs2Sel.Text = "CS2\r\nSEL";
         //btnCrs2Sel.UseVisualStyleBackColor = true;
         btnCrs2Sel.Click += ApButton_Click;
         // 
         // checkApSpd
         // 
         checkApSpd.Location = new Point(416, 58);
         checkApSpd.Margin = new Padding(4, 3, 4, 3);
         checkApSpd.Name = "checkApSpd";
         checkApSpd.Size = new Size(46, 27);
         checkApSpd.TabIndex = 52;
         checkApSpd.Text = "SPD";
         checkApSpd.CheckedChanged += Autopilot_CheckedChanged;
         checkApSpd.Click += ApButton_Click;
         // 
         // checkApFlc
         // 
         checkApFlc.Location = new Point(416, 24);
         checkApFlc.Margin = new Padding(4, 3, 4, 3);
         checkApFlc.Name = "checkApFlc";
         checkApFlc.Size = new Size(46, 27);
         checkApFlc.TabIndex = 51;
         checkApFlc.Text = "FLC";
         checkApFlc.CheckedChanged += Autopilot_CheckedChanged;
         checkApFlc.Click += ApButton_Click;
         // 
         // btnNoseUpDn
         // 
         btnNoseUpDn.Location = new Point(375, 24);
         btnNoseUpDn.Margin = new Padding(4, 3, 4, 3);
         btnNoseUpDn.Name = "btnNoseUpDn";
         btnNoseUpDn.Size = new Size(35, 78);
         btnNoseUpDn.TabIndex = 50;
         btnNoseUpDn.Text = "DN\r\n\r\n\r\nUP";
         //btnNoseUpDn.UseVisualStyleBackColor = true;
         // 
         // checkApVnv
         // 
         checkApVnv.Location = new Point(326, 58);
         checkApVnv.Margin = new Padding(4, 3, 4, 3);
         checkApVnv.Name = "checkApVnv";
         checkApVnv.Size = new Size(46, 27);
         checkApVnv.TabIndex = 49;
         checkApVnv.Text = "VNV";
         checkApVnv.CheckedChanged += Autopilot_CheckedChanged;
         checkApVnv.Click += ApButton_Click;
         // 
         // checkApVsHold
         // 
         checkApVsHold.Location = new Point(326, 24);
         checkApVsHold.Margin = new Padding(4, 3, 4, 3);
         checkApVsHold.Name = "checkApVsHold";
         checkApVsHold.Size = new Size(46, 27);
         checkApVsHold.TabIndex = 48;
         checkApVsHold.Text = "VS";
         checkApVsHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApVsHold.Click += ApButton_Click;
         // 
         // btnAltSel
         // 
         btnAltSel.Location = new Point(276, 58);
         btnAltSel.Margin = new Padding(4, 3, 4, 3);
         btnAltSel.Name = "btnAltSel";
         btnAltSel.Size = new Size(46, 44);
         btnAltSel.TabIndex = 47;
         btnAltSel.Text = "ALT\r\nSEL";
         //btnAltSel.UseVisualStyleBackColor = true;
         btnAltSel.Click += ApButton_Click;
         // 
         // checkApAltHold
         // 
         checkApAltHold.Location = new Point(276, 24);
         checkApAltHold.Margin = new Padding(4, 3, 4, 3);
         checkApAltHold.Name = "checkApAltHold";
         checkApAltHold.Size = new Size(46, 27);
         checkApAltHold.TabIndex = 46;
         checkApAltHold.Text = "ALT";
         checkApAltHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApAltHold.Click += ApButton_Click;
         // 
         // checkApYd
         // 
         checkApYd.Location = new Point(218, 58);
         checkApYd.Margin = new Padding(4, 3, 4, 3);
         checkApYd.Name = "checkApYd";
         checkApYd.Size = new Size(46, 27);
         checkApYd.TabIndex = 45;
         checkApYd.Text = "YD";
         checkApYd.CheckedChanged += Autopilot_CheckedChanged;
         checkApYd.Click += ApButton_Click;
         // 
         // checkApFd
         // 
         checkApFd.Location = new Point(192, 24);
         checkApFd.Margin = new Padding(4, 3, 4, 3);
         checkApFd.Name = "checkApFd";
         checkApFd.Size = new Size(46, 27);
         checkApFd.TabIndex = 44;
         checkApFd.Text = "FD";
         checkApFd.CheckedChanged += Autopilot_CheckedChanged;
         checkApFd.Click += ApButton_Click;
         // 
         // checkApMaster
         // 
         checkApMaster.Location = new Point(167, 58);
         checkApMaster.Margin = new Padding(4, 3, 4, 3);
         checkApMaster.Name = "checkApMaster";
         checkApMaster.Size = new Size(46, 27);
         checkApMaster.TabIndex = 38;
         checkApMaster.Text = "AP";
         checkApMaster.CheckedChanged += Autopilot_CheckedChanged;
         checkApMaster.Click += ApButton_Click;
         // 
         // btnCrs1Sel
         // 
         btnCrs1Sel.Location = new Point(109, 58);
         btnCrs1Sel.Margin = new Padding(4, 3, 4, 3);
         btnCrs1Sel.Name = "btnCrs1Sel";
         btnCrs1Sel.Size = new Size(46, 44);
         btnCrs1Sel.TabIndex = 43;
         btnCrs1Sel.Text = "CS1\r\nSEL";
         //btnCrs1Sel.UseVisualStyleBackColor = true;
         btnCrs1Sel.Click += ApButton_Click;
         // 
         // btnHdgSel
         // 
         btnHdgSel.Location = new Point(10, 58);
         btnHdgSel.Margin = new Padding(4, 3, 4, 3);
         btnHdgSel.Name = "btnHdgSel";
         btnHdgSel.Size = new Size(46, 44);
         btnHdgSel.TabIndex = 39;
         btnHdgSel.Text = "HDG\r\nSEL";
         //btnHdgSel.UseVisualStyleBackColor = true;
         btnHdgSel.Click += ApButton_Click;
         // 
         // checkApBcHold
         // 
         checkApBcHold.Location = new Point(60, 58);
         checkApBcHold.Margin = new Padding(4, 3, 4, 3);
         checkApBcHold.Name = "checkApBcHold";
         checkApBcHold.Size = new Size(46, 27);
         checkApBcHold.TabIndex = 42;
         checkApBcHold.Text = "BC";
         checkApBcHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApBcHold.Click += ApButton_Click;
         // 
         // checkApAprHold
         // 
         checkApAprHold.Location = new Point(60, 24);
         checkApAprHold.Margin = new Padding(4, 3, 4, 3);
         checkApAprHold.Name = "checkApAprHold";
         checkApAprHold.Size = new Size(46, 27);
         checkApAprHold.TabIndex = 41;
         checkApAprHold.Text = "APR";
         checkApAprHold.CheckedChanged += Autopilot_CheckedChanged;
         checkApAprHold.Click += ApButton_Click;
         // 
         // checkApNavHold
         // 
         checkApNavHold.Location = new Point(109, 24);
         checkApNavHold.Margin = new Padding(4, 3, 4, 3);
         checkApNavHold.Name = "checkApNavHold";
         checkApNavHold.Size = new Size(46, 27);
         checkApNavHold.TabIndex = 40;
         checkApNavHold.Text = "NAV";
         checkApNavHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApHdgHold
         // 
         checkApHdgHold.Location = new Point(10, 24);
         checkApHdgHold.Margin = new Padding(4, 3, 4, 3);
         checkApHdgHold.Name = "checkApHdgHold";
         checkApHdgHold.Size = new Size(46, 27);
         checkApHdgHold.TabIndex = 39;
         checkApHdgHold.Text = "HDG";
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
         groupLights.Location = new Point(284, 393);
         groupLights.Margin = new Padding(4, 3, 4, 3);
         groupLights.Name = "groupLights";
         groupLights.Padding = new Padding(4, 3, 4, 3);
         groupLights.Size = new Size(396, 92);
         groupLights.TabIndex = 2;
         groupLights.TabStop = false;
         groupLights.Text = "Lights";
         // 
         // checkBeaconLight
         // 
         checkBeaconLight.AutoSize = true;
         checkBeaconLight.Location = new Point(6, 24);
         checkBeaconLight.Margin = new Padding(4, 3, 4, 3);
         checkBeaconLight.Name = "checkBeaconLight";
         checkBeaconLight.Size = new Size(49, 22);
         checkBeaconLight.TabIndex = 2;
         checkBeaconLight.Text = "Beacon";
         checkBeaconLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkWingLight
         // 
         checkWingLight.AutoSize = true;
         checkWingLight.Location = new Point(340, 58);
         checkWingLight.Margin = new Padding(4, 3, 4, 3);
         checkWingLight.Name = "checkWingLight";
         checkWingLight.Size = new Size(37, 22);
         checkWingLight.TabIndex = 44;
         checkWingLight.Text = "Wing";
         checkWingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkCabinLight
         // 
         checkCabinLight.AutoSize = true;
         checkCabinLight.Location = new Point(73, 24);
         checkCabinLight.Margin = new Padding(4, 3, 4, 3);
         checkCabinLight.Name = "checkCabinLight";
         checkCabinLight.Size = new Size(40, 22);
         checkCabinLight.TabIndex = 34;
         checkCabinLight.Text = "Cabin";
         checkCabinLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkTaxiLight
         // 
         checkTaxiLight.AutoSize = true;
         checkTaxiLight.Location = new Point(295, 58);
         checkTaxiLight.Margin = new Padding(4, 3, 4, 3);
         checkTaxiLight.Name = "checkTaxiLight";
         checkTaxiLight.Size = new Size(30, 22);
         checkTaxiLight.TabIndex = 43;
         checkTaxiLight.Text = "Taxi";
         checkTaxiLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkGlareshieldLight
         // 
         checkGlareshieldLight.AutoSize = true;
         checkGlareshieldLight.Location = new Point(130, 24);
         checkGlareshieldLight.Margin = new Padding(4, 3, 4, 3);
         checkGlareshieldLight.Name = "checkGlareshieldLight";
         checkGlareshieldLight.Size = new Size(72, 22);
         checkGlareshieldLight.TabIndex = 35;
         checkGlareshieldLight.Text = "Glareshield";
         checkGlareshieldLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkStrobeLight
         // 
         checkStrobeLight.AutoSize = true;
         checkStrobeLight.Location = new Point(232, 58);
         checkStrobeLight.Margin = new Padding(4, 3, 4, 3);
         checkStrobeLight.Name = "checkStrobeLight";
         checkStrobeLight.Size = new Size(46, 22);
         checkStrobeLight.TabIndex = 42;
         checkStrobeLight.Text = "Strobe";
         checkStrobeLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLandingLight
         // 
         checkLandingLight.AutoSize = true;
         checkLandingLight.Location = new Point(218, 24);
         checkLandingLight.Margin = new Padding(4, 3, 4, 3);
         checkLandingLight.Name = "checkLandingLight";
         checkLandingLight.Size = new Size(53, 22);
         checkLandingLight.TabIndex = 36;
         checkLandingLight.Text = "Landing";
         checkLandingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkRecognitionLight
         // 
         checkRecognitionLight.AutoSize = true;
         checkRecognitionLight.Location = new Point(139, 58);
         checkRecognitionLight.Margin = new Padding(4, 3, 4, 3);
         checkRecognitionLight.Name = "checkRecognitionLight";
         checkRecognitionLight.Size = new Size(76, 22);
         checkRecognitionLight.TabIndex = 41;
         checkRecognitionLight.Text = "Recognition";
         checkRecognitionLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLogoLight
         // 
         checkLogoLight.AutoSize = true;
         checkLogoLight.Location = new Point(288, 24);
         checkLogoLight.Margin = new Padding(4, 3, 4, 3);
         checkLogoLight.Name = "checkLogoLight";
         checkLogoLight.Size = new Size(37, 22);
         checkLogoLight.TabIndex = 37;
         checkLogoLight.Text = "Logo";
         checkLogoLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPedestralLight
         // 
         checkPedestralLight.AutoSize = true;
         checkPedestralLight.Location = new Point(60, 58);
         checkPedestralLight.Margin = new Padding(4, 3, 4, 3);
         checkPedestralLight.Name = "checkPedestralLight";
         checkPedestralLight.Size = new Size(61, 22);
         checkPedestralLight.TabIndex = 40;
         checkPedestralLight.Text = "Pedestral";
         checkPedestralLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkNavLight
         // 
         checkNavLight.AutoSize = true;
         checkNavLight.Location = new Point(342, 24);
         checkNavLight.Margin = new Padding(4, 3, 4, 3);
         checkNavLight.Name = "checkNavLight";
         checkNavLight.Size = new Size(30, 22);
         checkNavLight.TabIndex = 38;
         checkNavLight.Text = "Nav";
         checkNavLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPanelLight
         // 
         checkPanelLight.AutoSize = true;
         checkPanelLight.Location = new Point(6, 58);
         checkPanelLight.Margin = new Padding(4, 3, 4, 3);
         checkPanelLight.Name = "checkPanelLight";
         checkPanelLight.Size = new Size(38, 22);
         checkPanelLight.TabIndex = 39;
         checkPanelLight.Text = "Panel";
         checkPanelLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // lblTransponder
         // 
         lblTransponder.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblTransponder.Appearance.Options.UseFont = true;
         lblTransponder.Location = new Point(11, 522);
         lblTransponder.Margin = new Padding(4, 3, 4, 3);
         lblTransponder.Name = "lblTransponder";
         lblTransponder.Size = new Size(64, 40);
         lblTransponder.TabIndex = 20;
         lblTransponder.Text = "0000";
         // 
         // label4
         // 
         label4.Location = new Point(11, 502);
         label4.Margin = new Padding(4, 3, 4, 3);
         label4.Name = "label4";
         label4.Size = new Size(75, 17);
         label4.TabIndex = 19;
         label4.Text = "Transponder";
         // 
         // lblVerticalSpeedValue
         // 
         lblVerticalSpeedValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblVerticalSpeedValue.Appearance.Options.UseFont = true;
         lblVerticalSpeedValue.Location = new Point(158, 456);
         lblVerticalSpeedValue.Margin = new Padding(4, 3, 4, 3);
         lblVerticalSpeedValue.Name = "lblVerticalSpeedValue";
         lblVerticalSpeedValue.Size = new Size(76, 40);
         lblVerticalSpeedValue.TabIndex = 18;
         lblVerticalSpeedValue.Text = "-0000";
         // 
         // label7
         // 
         label7.Location = new Point(158, 437);
         label7.Margin = new Padding(4, 3, 4, 3);
         label7.Name = "label7";
         label7.Size = new Size(84, 17);
         label7.TabIndex = 17;
         label7.Text = "Vertical Speed";
         // 
         // lblAltitudeValue
         // 
         lblAltitudeValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblAltitudeValue.Appearance.Options.UseFont = true;
         lblAltitudeValue.Location = new Point(11, 456);
         lblAltitudeValue.Margin = new Padding(4, 3, 4, 3);
         lblAltitudeValue.Name = "lblAltitudeValue";
         lblAltitudeValue.Size = new Size(80, 40);
         lblAltitudeValue.TabIndex = 16;
         lblAltitudeValue.Text = "00000";
         // 
         // label5
         // 
         label5.Location = new Point(11, 437);
         label5.Margin = new Padding(4, 3, 4, 3);
         label5.Name = "label5";
         label5.Size = new Size(44, 17);
         label5.TabIndex = 15;
         label5.Text = "Altitude";
         // 
         // lblCourseValue
         // 
         lblCourseValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCourseValue.Appearance.Options.UseFont = true;
         lblCourseValue.Location = new Point(158, 393);
         lblCourseValue.Margin = new Padding(4, 3, 4, 3);
         lblCourseValue.Name = "lblCourseValue";
         lblCourseValue.Size = new Size(48, 40);
         lblCourseValue.TabIndex = 14;
         lblCourseValue.Text = "000";
         // 
         // label3
         // 
         label3.Location = new Point(158, 371);
         label3.Margin = new Padding(4, 3, 4, 3);
         label3.Name = "label3";
         label3.Size = new Size(41, 17);
         label3.TabIndex = 13;
         label3.Text = "Course";
         // 
         // lblHeadingValue
         // 
         lblHeadingValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblHeadingValue.Appearance.Options.UseFont = true;
         lblHeadingValue.Location = new Point(11, 393);
         lblHeadingValue.Margin = new Padding(4, 3, 4, 3);
         lblHeadingValue.Name = "lblHeadingValue";
         lblHeadingValue.Size = new Size(48, 40);
         lblHeadingValue.TabIndex = 7;
         lblHeadingValue.Text = "000";
         // 
         // groupNav2
         // 
         groupNav2.Controls.Add(lblNav2StandbyValue);
         groupNav2.Controls.Add(lblNav2ActiveValue);
         groupNav2.Controls.Add(lblNav2Standby);
         groupNav2.Controls.Add(lblNav2Active);
         groupNav2.Location = new Point(4, 282);
         groupNav2.Margin = new Padding(4, 3, 4, 3);
         groupNav2.Name = "groupNav2";
         groupNav2.Padding = new Padding(4, 3, 4, 3);
         groupNav2.Size = new Size(276, 88);
         groupNav2.TabIndex = 12;
         groupNav2.TabStop = false;
         groupNav2.Text = "NAV 2";
         // 
         // lblNav2StandbyValue
         // 
         lblNav2StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav2StandbyValue.Appearance.Options.UseFont = true;
         lblNav2StandbyValue.Location = new Point(6, 41);
         lblNav2StandbyValue.Margin = new Padding(4, 3, 4, 3);
         lblNav2StandbyValue.Name = "lblNav2StandbyValue";
         lblNav2StandbyValue.Size = new Size(86, 40);
         lblNav2StandbyValue.TabIndex = 4;
         lblNav2StandbyValue.Text = "000.00";
         // 
         // lblNav2ActiveValue
         // 
         lblNav2ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav2ActiveValue.Appearance.Options.UseFont = true;
         lblNav2ActiveValue.Location = new Point(157, 41);
         lblNav2ActiveValue.Margin = new Padding(4, 3, 4, 3);
         lblNav2ActiveValue.Name = "lblNav2ActiveValue";
         lblNav2ActiveValue.Size = new Size(86, 40);
         lblNav2ActiveValue.TabIndex = 5;
         lblNav2ActiveValue.Text = "000.00";
         // 
         // lblNav2Standby
         // 
         lblNav2Standby.Location = new Point(6, 21);
         lblNav2Standby.Margin = new Padding(4, 3, 4, 3);
         lblNav2Standby.Name = "lblNav2Standby";
         lblNav2Standby.Size = new Size(47, 17);
         lblNav2Standby.TabIndex = 2;
         lblNav2Standby.Text = "Standby";
         // 
         // lblNav2Active
         // 
         lblNav2Active.Location = new Point(157, 21);
         lblNav2Active.Margin = new Padding(4, 3, 4, 3);
         lblNav2Active.Name = "lblNav2Active";
         lblNav2Active.Size = new Size(34, 17);
         lblNav2Active.TabIndex = 3;
         lblNav2Active.Text = "Active";
         // 
         // label2
         // 
         label2.Location = new Point(11, 371);
         label2.Margin = new Padding(4, 3, 4, 3);
         label2.Name = "label2";
         label2.Size = new Size(49, 17);
         label2.TabIndex = 6;
         label2.Text = "Heading";
         // 
         // groupNav1
         // 
         groupNav1.Controls.Add(lblNav1StandbyValue);
         groupNav1.Controls.Add(lblNav1ActiveValue);
         groupNav1.Controls.Add(lblNav1Standby);
         groupNav1.Controls.Add(lblNav1Active);
         groupNav1.Location = new Point(4, 190);
         groupNav1.Margin = new Padding(4, 3, 4, 3);
         groupNav1.Name = "groupNav1";
         groupNav1.Padding = new Padding(4, 3, 4, 3);
         groupNav1.Size = new Size(276, 88);
         groupNav1.TabIndex = 11;
         groupNav1.TabStop = false;
         groupNav1.Text = "NAV 1";
         // 
         // lblNav1StandbyValue
         // 
         lblNav1StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav1StandbyValue.Appearance.Options.UseFont = true;
         lblNav1StandbyValue.Location = new Point(6, 41);
         lblNav1StandbyValue.Margin = new Padding(4, 3, 4, 3);
         lblNav1StandbyValue.Name = "lblNav1StandbyValue";
         lblNav1StandbyValue.Size = new Size(86, 40);
         lblNav1StandbyValue.TabIndex = 4;
         lblNav1StandbyValue.Text = "000.00";
         // 
         // lblNav1ActiveValue
         // 
         lblNav1ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav1ActiveValue.Appearance.Options.UseFont = true;
         lblNav1ActiveValue.Location = new Point(157, 41);
         lblNav1ActiveValue.Margin = new Padding(4, 3, 4, 3);
         lblNav1ActiveValue.Name = "lblNav1ActiveValue";
         lblNav1ActiveValue.Size = new Size(86, 40);
         lblNav1ActiveValue.TabIndex = 5;
         lblNav1ActiveValue.Text = "000.00";
         // 
         // lblNav1Standby
         // 
         lblNav1Standby.Location = new Point(6, 21);
         lblNav1Standby.Margin = new Padding(4, 3, 4, 3);
         lblNav1Standby.Name = "lblNav1Standby";
         lblNav1Standby.Size = new Size(47, 17);
         lblNav1Standby.TabIndex = 2;
         lblNav1Standby.Text = "Standby";
         // 
         // lblNav1Active
         // 
         lblNav1Active.Location = new Point(157, 21);
         lblNav1Active.Margin = new Padding(4, 3, 4, 3);
         lblNav1Active.Name = "lblNav1Active";
         lblNav1Active.Size = new Size(34, 17);
         lblNav1Active.TabIndex = 3;
         lblNav1Active.Text = "Active";
         // 
         // groupCom2
         // 
         groupCom2.Controls.Add(lblCom2Standby);
         groupCom2.Controls.Add(lblCom2StandbyValue);
         groupCom2.Controls.Add(lblCom2ActiveValue);
         groupCom2.Controls.Add(lblCom2Active);
         groupCom2.Location = new Point(4, 95);
         groupCom2.Margin = new Padding(4, 3, 4, 3);
         groupCom2.Name = "groupCom2";
         groupCom2.Padding = new Padding(4, 3, 4, 3);
         groupCom2.Size = new Size(276, 88);
         groupCom2.TabIndex = 11;
         groupCom2.TabStop = false;
         groupCom2.Text = "COM 2";
         // 
         // lblCom2Standby
         // 
         lblCom2Standby.Location = new Point(6, 21);
         lblCom2Standby.Margin = new Padding(4, 3, 4, 3);
         lblCom2Standby.Name = "lblCom2Standby";
         lblCom2Standby.Size = new Size(47, 17);
         lblCom2Standby.TabIndex = 6;
         lblCom2Standby.Text = "Standby";
         // 
         // lblCom2StandbyValue
         // 
         lblCom2StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCom2StandbyValue.Appearance.Options.UseFont = true;
         lblCom2StandbyValue.Location = new Point(6, 38);
         lblCom2StandbyValue.Margin = new Padding(4, 3, 4, 3);
         lblCom2StandbyValue.Name = "lblCom2StandbyValue";
         lblCom2StandbyValue.Size = new Size(102, 40);
         lblCom2StandbyValue.TabIndex = 8;
         lblCom2StandbyValue.Text = "000.000";
         // 
         // lblCom2ActiveValue
         // 
         lblCom2ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCom2ActiveValue.Appearance.Options.UseFont = true;
         lblCom2ActiveValue.Location = new Point(157, 38);
         lblCom2ActiveValue.Margin = new Padding(4, 3, 4, 3);
         lblCom2ActiveValue.Name = "lblCom2ActiveValue";
         lblCom2ActiveValue.Size = new Size(102, 40);
         lblCom2ActiveValue.TabIndex = 9;
         lblCom2ActiveValue.Text = "000.000";
         // 
         // lblCom2Active
         // 
         lblCom2Active.Location = new Point(157, 21);
         lblCom2Active.Margin = new Padding(4, 3, 4, 3);
         lblCom2Active.Name = "lblCom2Active";
         lblCom2Active.Size = new Size(34, 17);
         lblCom2Active.TabIndex = 7;
         lblCom2Active.Text = "Active";
         // 
         // groupCom1
         // 
         groupCom1.Controls.Add(lblCom1StandbyValue);
         groupCom1.Controls.Add(lblCom1ActiveValue);
         groupCom1.Controls.Add(lblCom1Standby);
         groupCom1.Controls.Add(lblCom1Active);
         groupCom1.Location = new Point(4, 3);
         groupCom1.Margin = new Padding(4, 3, 4, 3);
         groupCom1.Name = "groupCom1";
         groupCom1.Padding = new Padding(4, 3, 4, 3);
         groupCom1.Size = new Size(276, 88);
         groupCom1.TabIndex = 10;
         groupCom1.TabStop = false;
         groupCom1.Text = "COM 1";
         // 
         // lblCom1StandbyValue
         // 
         lblCom1StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1StandbyValue.Appearance.Options.UseFont = true;
         lblCom1StandbyValue.Location = new Point(6, 41);
         lblCom1StandbyValue.Margin = new Padding(4, 3, 4, 3);
         lblCom1StandbyValue.Name = "lblCom1StandbyValue";
         lblCom1StandbyValue.Size = new Size(102, 40);
         lblCom1StandbyValue.TabIndex = 4;
         lblCom1StandbyValue.Text = "000.000";
         // 
         // lblCom1ActiveValue
         // 
         lblCom1ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1ActiveValue.Appearance.Options.UseFont = true;
         lblCom1ActiveValue.Location = new Point(157, 41);
         lblCom1ActiveValue.Margin = new Padding(4, 3, 4, 3);
         lblCom1ActiveValue.Name = "lblCom1ActiveValue";
         lblCom1ActiveValue.Size = new Size(102, 40);
         lblCom1ActiveValue.TabIndex = 5;
         lblCom1ActiveValue.Text = "000.000";
         // 
         // lblCom1Standby
         // 
         lblCom1Standby.Location = new Point(6, 21);
         lblCom1Standby.Margin = new Padding(4, 3, 4, 3);
         lblCom1Standby.Name = "lblCom1Standby";
         lblCom1Standby.Size = new Size(47, 17);
         lblCom1Standby.TabIndex = 2;
         lblCom1Standby.Text = "Standby";
         // 
         // lblCom1Active
         // 
         lblCom1Active.Location = new Point(157, 21);
         lblCom1Active.Margin = new Padding(4, 3, 4, 3);
         lblCom1Active.Name = "lblCom1Active";
         lblCom1Active.Size = new Size(34, 17);
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
         ClientSize = new Size(1133, 721);
         Controls.Add(toolStripContainer1);
         Font = new Font("Segoe UI", 9.75F);
         MainMenuStrip = mainMenu;
         Margin = new Padding(4, 3, 4, 3);
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
         groupAutopilot.PerformLayout();
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
      private LabelControl lblCom1Active;
      private LabelControl lblCom1Standby;
      private LabelControl lblCom1ActiveValue;
      private LabelControl lblCom1StandbyValue;
      private LabelControl lblCom2ActiveValue;
      private LabelControl lblCom2StandbyValue;
      private LabelControl lblCom2Active;
      private LabelControl lblCom2Standby;
      private GroupBox groupCom1;
      private GroupBox groupCom2;
      private GroupBox groupNav1;
      private LabelControl lblNav1StandbyValue;
      private LabelControl lblNav1ActiveValue;
      private LabelControl lblNav1Standby;
      private LabelControl lblNav1Active;
      private GroupBox groupNav2;
      private LabelControl lblNav2StandbyValue;
      private LabelControl lblNav2ActiveValue;
      private LabelControl lblNav2Standby;
      private LabelControl lblNav2Active;
      private LabelControl lblHeadingValue;
      private LabelControl label2;
      private LabelControl lblCourseValue;
      private LabelControl label3;
      private LabelControl lblVerticalSpeedValue;
      private LabelControl label7;
      private LabelControl lblAltitudeValue;
      private LabelControl label5;
      private LabelControl lblTransponder;
      private LabelControl label4;
      private ToolStripMenuItem macroPadToolStripMenuItem;
      private ToolStripMenuItem simConnectToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator1;
      private ToolStripStatusLabel lblMacroPadState;
      private ToolStripStatusLabel lblSerialPortStatus;
      private CheckButton checkGlareshieldLight;
      private CheckButton checkCabinLight;
      private CheckButton checkBeaconLight;
      private CheckButton checkWingLight;
      private CheckButton checkTaxiLight;
      private CheckButton checkStrobeLight;
      private CheckButton checkRecognitionLight;
      private CheckButton checkPedestralLight;
      private CheckButton checkPanelLight;
      private CheckButton checkNavLight;
      private CheckButton checkLogoLight;
      private CheckButton checkLandingLight;
      private ToolStripMenuItem refreshSerialPortsToolStripMenuItem;
      private ToolStripSeparator toolStripSeparator2;
      private GroupBox groupLights;
      private ToolStripStatusLabel lblFsuipcStatus;
      private ToolStripMenuItem fsuipcConnectToolStripMenuItem;
      private ToolStripMenuItem utilityToolStripMenuItem;
      private ToolStripMenuItem presetEventsToolStripMenuItem;
      private GroupBox groupAutopilot;
      private CheckButton checkApNavHold;
      private CheckButton checkApHdgHold;
      private CheckButton checkApMaster;
      private CheckButton checkApAprHold;
      private SimpleButton btnCrs1Sel;
      private SimpleButton btnHdgSel;
      private CheckButton checkApBcHold;
      private CheckButton checkApYd;
      private CheckButton checkApFd;
      private CheckButton checkApAltHold;
      private SimpleButton btnAltSel;
      private CheckButton checkApVsHold;
      private CheckButton checkApVnv;
      private SimpleButton btnNoseUpDn;
      private CheckButton checkApFlc;
      private CheckButton checkApSpd;
      private SimpleButton btnCrs2Sel;
      private GroupBox groupFms;
      private SimpleButton btnFmsFpl;
      private SimpleButton btnFmsDirect;
      private SimpleButton btnFmsPfdInner;
      private SimpleButton btnFmsPfdOuter;
      private SimpleButton btnFmsProc;
      private SimpleButton btnFmsMfdInner;
      private SimpleButton btnFmsMfdOuter;
      private SimpleButton btnFmsEnt;
      private SimpleButton btnFmsClr;
      private SimpleButton btnFmsMenu;
      private ToolTip toolTip1;
      private GroupBox groupPause;
      private SimpleButton btnPauseFull;
      private CheckButton checkPauseFull;
      private CheckButton checkPauseActive;
      private CheckButton checkPauseEsc;
      private CheckButton checkPauseSim;
      private SimpleButton btnPauseSim;
      private GroupBox groupFuel;
      private SimpleButton btnAddFuel;
      private TextBox txtTotalFuelPct;
      private LabelControl lblTotalFuelPct;
      private SimpleButton btnFuelDump;
      private LabelControl lblFuelDumpSwitch;
      private GroupBox groupCameras;
      private CheckButton checkCamera10;
      private CheckButton checkCamera9;
      private CheckButton checkCamera8;
      private CheckButton checkCamera7;
      private CheckButton checkCamera6;
      private CheckButton checkCamera5;
      private CheckButton checkCamera4;
      private CheckButton checkCamera3;
      private CheckButton checkCamera2;
      private CheckButton checkCamera1;
      private LabelControl lblCameraCurrentView;
      private CheckButton checkCameraPilotCoPilot;
      private CheckButton checkCameraPilotLand;
      private CheckButton checkCameraPilotClose;
      private CheckButton checkCameraPilotNormal;
      private LabelControl lblIndex1;
      private LabelControl lblIndex0;
      private LabelControl lblCameraSubstate;
      private LabelControl lblCameraState;
      public TextBox txtOutput;
      private SimpleButton btnNextView;
      private SimpleButton btnPreviousSubView;
      private SimpleButton btnNextSubView;
      private SimpleButton btnPreviousView;
      private GroupBox groupBox1;
      private LabelControl lblSimRate;
      private SimpleButton btnSimRateDec;
      private SimpleButton btnSimRateInc;
      private ToolStripStatusLabel lblLocalTime;
      private SimpleButton btnSimRateReset;
      private LabelControl lblCurrentCameraType;
      private SimpleButton btnSetCamera;
      private TextBox txtCameraIndex1;
      private TextBox txtCameraIndex0;
      private TextBox txtCameraSubState;
      private TextBox txtCameraState;
      private CheckButton checkExternalQuickViewSubState;
      private CheckButton checkExternalDefaultSubState;
      private CheckButton checkCockpitQuickViewSubState;
      private CheckButton checkCockpitInstrumentSubState;
      private CheckButton checkCockpitPilotSubState;
      private CheckButton checkShowcaseFixedSubState;
      private CheckButton checkShowcaseDroneSubState;
      private LabelControl lblAileronTrimPct;
      private LabelControl lblRudderTrimPct;
      private LabelControl lblElevatorTrimPct;
      private LabelControl lblTrailingFlapsRight;
      private LabelControl lblTrailingFlapsLeft;
      private LabelControl lblFlapsCurrentPosition;
      private LabelControl lblFlapsNumberOfDetents;
      private LabelControl lblCurrentFlapsLimit;
      private LabelControl lblEngineTorque;
      private LabelControl lblEngineITT;
      private LabelControl lblEngineNGPct;
      private LabelControl lblEngineNPRpm;
      private LabelControl lblEngineTorquePct;
      private CheckButton checkCustomCameraState;
      private TrackBar trackFlaps;
      private LabelControl lblSCTargetDesc;
      private LabelControl lblSCTargetType;
      private CheckButton checkSmartcam;
      private SimpleButton btnPreviousSmartcam;
      private SimpleButton btnNextSmartcam;
      private LabelControl lblCustomCamera;
      private LabelControl lblSpoilersPosition;
      private LabelControl lblSpoilersHandlePosition;
      private LabelControl lblSpoilersArmed;
      private LabelControl lblSpoilersAvailable;
      private LabelControl lblEngCondition1;
      private LabelControl lblMixture1Pct;
      private LabelControl lblPropeller1Pct;
      private LabelControl lblThrottle1Pct;
      private LabelControl lblCurrentAircraft;
      private LabelControl lblApproachStatus;
      private LabelControl lblBarometer1;
      private LabelControl label6;
   }
}
