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
         lblBarometer1 = new LabelControl();
         label6 = new LabelControl();
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
         txtCameraIndex1 = new TextEdit();
         txtCameraIndex0 = new TextEdit();
         txtCameraSubState = new TextEdit();
         txtCameraState = new TextEdit();
         GroupControl1 = new GroupControl();
         btnSimRateReset = new SimpleButton();
         btnSimRateDec = new SimpleButton();
         btnSimRateInc = new SimpleButton();
         lblSimRate = new LabelControl();
         lblCurrentCameraType = new LabelControl();
         txtOutput = new MemoEdit();
         groupCameras = new GroupControl();
         checkCameraPilotCoPilot = new CheckButton();
         checkCameraPilotLand = new CheckButton();
         checkCameraPilotClose = new CheckButton();
         checkCameraPilotNormal = new CheckButton();
         lblCameraCurrentView = new LabelControl();
         groupFuel = new GroupControl();
         lblFuelDumpSwitch = new LabelControl();
         btnFuelDump = new SimpleButton();
         lblTotalFuelPct = new LabelControl();
         btnAddFuel = new SimpleButton();
         groupPause = new GroupControl();
         btnPauseSim = new SimpleButton();
         checkPauseEsc = new CheckEdit();
         checkPauseSim = new CheckEdit();
         checkPauseActive = new CheckEdit();
         checkPauseFull = new CheckEdit();
         btnPauseFull = new SimpleButton();
         groupFms = new GroupControl();
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
         groupAutopilot = new GroupControl();
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
         groupLights = new GroupControl();
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
         label5 = new LabelControl();
         lblCourseSel = new LabelControl();
         groupNav2 = new GroupControl();
         lblNav2Standby = new LabelControl();
         lblNav2Active = new LabelControl();
         navRadioDisplay2Active = new MacroPadDevice.Controls.NavRadioDisplay();
         navRadioDisplay2Standby = new MacroPadDevice.Controls.NavRadioDisplay();
         label2 = new LabelControl();
         groupNav1 = new GroupControl();
         lblNav1Standby = new LabelControl();
         lblNav1Active = new LabelControl();
         navRadioDisplay1Standby = new MacroPadDevice.Controls.NavRadioDisplay();
         navRadioDisplay1Active = new MacroPadDevice.Controls.NavRadioDisplay();
         groupCom2 = new GroupControl();
         comRadioDisplay2Active = new MacroPadDevice.Controls.ComRadioDisplay();
         comRadioDisplay2Standby = new MacroPadDevice.Controls.ComRadioDisplay();
         lblCom2Standby = new LabelControl();
         lblCom2Active = new LabelControl();
         groupCom1 = new GroupControl();
         comRadioDisplay1Active = new MacroPadDevice.Controls.ComRadioDisplay();
         comRadioDisplay1Standby = new MacroPadDevice.Controls.ComRadioDisplay();
         lblCom1Standby = new LabelControl();
         lblCom1Active = new LabelControl();
         toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
         gridLookUpEdit1 = new GridLookUpEdit();
         toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
         bar1 = new DevExpress.XtraBars.Bar();
         menuApp = new DevExpress.XtraBars.BarSubItem();
         menuConnectSimConnect = new DevExpress.XtraBars.BarButtonItem();
         menuConnectFsuipc = new DevExpress.XtraBars.BarButtonItem();
         menuExit = new DevExpress.XtraBars.BarButtonItem();
         menuMacroPad = new DevExpress.XtraBars.BarSubItem();
         menuRefreshSerialPorts = new DevExpress.XtraBars.BarButtonItem();
         menuUtility = new DevExpress.XtraBars.BarSubItem();
         menuPresetEvents = new DevExpress.XtraBars.BarButtonItem();
         bar2 = new DevExpress.XtraBars.Bar();
         lblSimConnectStatus = new DevExpress.XtraBars.BarStaticItem();
         lblFsuipcStatus = new DevExpress.XtraBars.BarStaticItem();
         lblSerialPortStatus = new DevExpress.XtraBars.BarStaticItem();
         lblSimAircraft = new DevExpress.XtraBars.BarStaticItem();
         lblMacroPadState = new DevExpress.XtraBars.BarStaticItem();
         lblLocalTime = new DevExpress.XtraBars.BarStaticItem();
         barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
         skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
         gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
         bar3 = new DevExpress.XtraBars.Bar();
         trackBarFlaps = new TrackBarControl();
         dirHeadingDisplay = new MacroPadDevice.Controls.DirectionDisplay();
         dirCourse1Display = new MacroPadDevice.Controls.DirectionDisplay();
         altitudeDisplay = new MacroPadDevice.Controls.AltitudeDisplay();
         ((System.ComponentModel.ISupportInitialize)txtCameraIndex1.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraIndex0.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraSubState.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraState.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)GroupControl1).BeginInit();
         GroupControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)txtOutput.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)groupCameras).BeginInit();
         groupCameras.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupFuel).BeginInit();
         groupFuel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupPause).BeginInit();
         groupPause.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)checkPauseEsc.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseSim.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseActive.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseFull.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)groupFms).BeginInit();
         groupFms.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupAutopilot).BeginInit();
         groupAutopilot.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupLights).BeginInit();
         groupLights.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupNav2).BeginInit();
         groupNav2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupNav1).BeginInit();
         groupNav1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupCom2).BeginInit();
         groupCom2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)groupCom1).BeginInit();
         groupCom1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).BeginInit();
         toolbarFormControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).BeginInit();
         ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
         ((System.ComponentModel.ISupportInitialize)trackBarFlaps).BeginInit();
         ((System.ComponentModel.ISupportInitialize)trackBarFlaps.Properties).BeginInit();
         SuspendLayout();
         // 
         // lblBarometer1
         // 
         lblBarometer1.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblBarometer1.Appearance.Options.UseFont = true;
         lblBarometer1.Location = new Point(150, 634);
         lblBarometer1.Margin = new Padding(4, 3, 4, 3);
         lblBarometer1.Name = "lblBarometer1";
         lblBarometer1.Size = new Size(70, 40);
         lblBarometer1.TabIndex = 269;
         lblBarometer1.Text = "00.00";
         // 
         // label6
         // 
         label6.Location = new Point(150, 615);
         label6.Margin = new Padding(4, 3, 4, 3);
         label6.Name = "label6";
         label6.Size = new Size(52, 17);
         label6.TabIndex = 268;
         label6.Text = "Altimeter";
         // 
         // lblEngCondition1
         // 
         lblEngCondition1.Location = new Point(539, 683);
         lblEngCondition1.Margin = new Padding(4, 3, 4, 3);
         lblEngCondition1.Name = "lblEngCondition1";
         lblEngCondition1.Size = new Size(74, 17);
         lblEngCondition1.TabIndex = 266;
         lblEngCondition1.Text = "Condition 1: ";
         // 
         // lblMixture1Pct
         // 
         lblMixture1Pct.Location = new Point(540, 659);
         lblMixture1Pct.Margin = new Padding(4, 3, 4, 3);
         lblMixture1Pct.Name = "lblMixture1Pct";
         lblMixture1Pct.Size = new Size(80, 17);
         lblMixture1Pct.TabIndex = 265;
         lblMixture1Pct.Text = "Mixture 1: 0%";
         // 
         // lblPropeller1Pct
         // 
         lblPropeller1Pct.Location = new Point(539, 636);
         lblPropeller1Pct.Margin = new Padding(4, 3, 4, 3);
         lblPropeller1Pct.Name = "lblPropeller1Pct";
         lblPropeller1Pct.Size = new Size(89, 17);
         lblPropeller1Pct.TabIndex = 264;
         lblPropeller1Pct.Text = "Propeller 1: 0%";
         // 
         // lblThrottle1Pct
         // 
         lblThrottle1Pct.Location = new Point(539, 613);
         lblThrottle1Pct.Margin = new Padding(4, 3, 4, 3);
         lblThrottle1Pct.Name = "lblThrottle1Pct";
         lblThrottle1Pct.Size = new Size(81, 17);
         lblThrottle1Pct.TabIndex = 263;
         lblThrottle1Pct.Text = "Throttle 1: 0%";
         // 
         // lblSpoilersPosition
         // 
         lblSpoilersPosition.Location = new Point(540, 790);
         lblSpoilersPosition.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersPosition.Name = "lblSpoilersPosition";
         lblSpoilersPosition.Size = new Size(148, 17);
         lblSpoilersPosition.TabIndex = 262;
         lblSpoilersPosition.Text = "Spoilers Position: 0 L, 0 R";
         // 
         // lblSpoilersHandlePosition
         // 
         lblSpoilersHandlePosition.Location = new Point(540, 768);
         lblSpoilersHandlePosition.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersHandlePosition.Name = "lblSpoilersHandlePosition";
         lblSpoilersHandlePosition.Size = new Size(106, 17);
         lblSpoilersHandlePosition.TabIndex = 261;
         lblSpoilersHandlePosition.Text = "Spoilers Handle: 0";
         // 
         // lblSpoilersArmed
         // 
         lblSpoilersArmed.Location = new Point(540, 744);
         lblSpoilersArmed.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersArmed.Name = "lblSpoilersArmed";
         lblSpoilersArmed.Size = new Size(116, 17);
         lblSpoilersArmed.TabIndex = 260;
         lblSpoilersArmed.Text = "Spoilers Not Armed";
         // 
         // lblSpoilersAvailable
         // 
         lblSpoilersAvailable.Location = new Point(540, 721);
         lblSpoilersAvailable.Margin = new Padding(4, 3, 4, 3);
         lblSpoilersAvailable.Name = "lblSpoilersAvailable";
         lblSpoilersAvailable.Size = new Size(86, 17);
         lblSpoilersAvailable.TabIndex = 259;
         lblSpoilersAvailable.Text = "Spoilers: None";
         // 
         // lblCustomCamera
         // 
         lblCustomCamera.Location = new Point(676, 659);
         lblCustomCamera.Margin = new Padding(4, 3, 4, 3);
         lblCustomCamera.Name = "lblCustomCamera";
         lblCustomCamera.Size = new Size(74, 17);
         lblCustomCamera.TabIndex = 258;
         lblCustomCamera.Text = "Cust Camera";
         // 
         // btnPreviousSmartcam
         // 
         btnPreviousSmartcam.Location = new Point(824, 479);
         btnPreviousSmartcam.Margin = new Padding(4, 3, 4, 3);
         btnPreviousSmartcam.Name = "btnPreviousSmartcam";
         btnPreviousSmartcam.Size = new Size(41, 25);
         btnPreviousSmartcam.TabIndex = 257;
         btnPreviousSmartcam.Text = "SC-";
         btnPreviousSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // btnNextSmartcam
         // 
         btnNextSmartcam.Location = new Point(824, 449);
         btnNextSmartcam.Margin = new Padding(4, 3, 4, 3);
         btnNextSmartcam.Name = "btnNextSmartcam";
         btnNextSmartcam.Size = new Size(41, 25);
         btnNextSmartcam.TabIndex = 256;
         btnNextSmartcam.Text = "SC+";
         btnNextSmartcam.Click += SmartcamCycleButton_Click;
         // 
         // checkSmartcam
         // 
         checkSmartcam.Location = new Point(824, 417);
         checkSmartcam.Margin = new Padding(4, 3, 4, 3);
         checkSmartcam.Name = "checkSmartcam";
         checkSmartcam.Size = new Size(59, 25);
         checkSmartcam.TabIndex = 255;
         checkSmartcam.Text = "SC";
         checkSmartcam.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblSCTargetDesc
         // 
         lblSCTargetDesc.Location = new Point(412, 590);
         lblSCTargetDesc.Margin = new Padding(4, 3, 4, 3);
         lblSCTargetDesc.Name = "lblSCTargetDesc";
         lblSCTargetDesc.Size = new Size(89, 17);
         lblSCTargetDesc.TabIndex = 254;
         lblSCTargetDesc.Text = "SC Target Desc";
         // 
         // lblSCTargetType
         // 
         lblSCTargetType.Location = new Point(412, 568);
         lblSCTargetType.Margin = new Padding(4, 3, 4, 3);
         lblSCTargetType.Name = "lblSCTargetType";
         lblSCTargetType.Size = new Size(89, 17);
         lblSCTargetType.TabIndex = 253;
         lblSCTargetType.Text = "SC Target Type";
         // 
         // checkCustomCameraState
         // 
         checkCustomCameraState.Location = new Point(1004, 630);
         checkCustomCameraState.Margin = new Padding(4, 3, 4, 3);
         checkCustomCameraState.Name = "checkCustomCameraState";
         checkCustomCameraState.Size = new Size(59, 25);
         checkCustomCameraState.TabIndex = 247;
         checkCustomCameraState.Text = "Custom";
         checkCustomCameraState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkShowcaseFixedSubState
         // 
         checkShowcaseFixedSubState.Location = new Point(1004, 599);
         checkShowcaseFixedSubState.Margin = new Padding(4, 3, 4, 3);
         checkShowcaseFixedSubState.Name = "checkShowcaseFixedSubState";
         checkShowcaseFixedSubState.Size = new Size(59, 25);
         checkShowcaseFixedSubState.TabIndex = 241;
         checkShowcaseFixedSubState.Text = "X-Fixed";
         checkShowcaseFixedSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblEngineTorquePct
         // 
         lblEngineTorquePct.Location = new Point(412, 544);
         lblEngineTorquePct.Margin = new Padding(4, 3, 4, 3);
         lblEngineTorquePct.Name = "lblEngineTorquePct";
         lblEngineTorquePct.Size = new Size(40, 17);
         lblEngineTorquePct.TabIndex = 246;
         lblEngineTorquePct.Text = "TRQ %";
         // 
         // checkShowcaseDroneSubState
         // 
         checkShowcaseDroneSubState.Location = new Point(1004, 568);
         checkShowcaseDroneSubState.Margin = new Padding(4, 3, 4, 3);
         checkShowcaseDroneSubState.Name = "checkShowcaseDroneSubState";
         checkShowcaseDroneSubState.Size = new Size(59, 25);
         checkShowcaseDroneSubState.TabIndex = 239;
         checkShowcaseDroneSubState.Text = "Drone";
         checkShowcaseDroneSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera9
         // 
         checkCamera9.Location = new Point(962, 506);
         checkCamera9.Margin = new Padding(4, 3, 4, 3);
         checkCamera9.Name = "checkCamera9";
         checkCamera9.Size = new Size(31, 25);
         checkCamera9.TabIndex = 215;
         checkCamera9.Tag = "9";
         checkCamera9.Text = "9";
         // 
         // lblEngineNPRpm
         // 
         lblEngineNPRpm.Location = new Point(412, 613);
         lblEngineNPRpm.Margin = new Padding(4, 3, 4, 3);
         lblEngineNPRpm.Name = "lblEngineNPRpm";
         lblEngineNPRpm.Size = new Size(48, 17);
         lblEngineNPRpm.TabIndex = 245;
         lblEngineNPRpm.Text = "NP RPM";
         // 
         // checkCamera8
         // 
         checkCamera8.Location = new Point(924, 506);
         checkCamera8.Margin = new Padding(4, 3, 4, 3);
         checkCamera8.Name = "checkCamera8";
         checkCamera8.Size = new Size(31, 25);
         checkCamera8.TabIndex = 214;
         checkCamera8.Tag = "8";
         checkCamera8.Text = "8";
         // 
         // checkExternalQuickViewSubState
         // 
         checkExternalQuickViewSubState.Location = new Point(1004, 536);
         checkExternalQuickViewSubState.Margin = new Padding(4, 3, 4, 3);
         checkExternalQuickViewSubState.Name = "checkExternalQuickViewSubState";
         checkExternalQuickViewSubState.Size = new Size(59, 25);
         checkExternalQuickViewSubState.TabIndex = 236;
         checkExternalQuickViewSubState.Text = "X-QV";
         checkExternalQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera7
         // 
         checkCamera7.Location = new Point(889, 506);
         checkCamera7.Margin = new Padding(4, 3, 4, 3);
         checkCamera7.Name = "checkCamera7";
         checkCamera7.Size = new Size(31, 25);
         checkCamera7.TabIndex = 213;
         checkCamera7.Tag = "7";
         checkCamera7.Text = "7";
         // 
         // lblEngineNGPct
         // 
         lblEngineNGPct.Location = new Point(412, 683);
         lblEngineNGPct.Margin = new Padding(4, 3, 4, 3);
         lblEngineNGPct.Name = "lblEngineNGPct";
         lblEngineNGPct.Size = new Size(34, 17);
         lblEngineNGPct.TabIndex = 244;
         lblEngineNGPct.Text = "NG %";
         // 
         // checkCamera6
         // 
         checkCamera6.Location = new Point(962, 536);
         checkCamera6.Margin = new Padding(4, 3, 4, 3);
         checkCamera6.Name = "checkCamera6";
         checkCamera6.Size = new Size(31, 25);
         checkCamera6.TabIndex = 212;
         checkCamera6.Tag = "6";
         checkCamera6.Text = "6";
         // 
         // checkExternalDefaultSubState
         // 
         checkExternalDefaultSubState.Location = new Point(1004, 507);
         checkExternalDefaultSubState.Margin = new Padding(4, 3, 4, 3);
         checkExternalDefaultSubState.Name = "checkExternalDefaultSubState";
         checkExternalDefaultSubState.Size = new Size(59, 25);
         checkExternalDefaultSubState.TabIndex = 235;
         checkExternalDefaultSubState.Text = "EXT";
         checkExternalDefaultSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera5
         // 
         checkCamera5.Location = new Point(924, 536);
         checkCamera5.Margin = new Padding(4, 3, 4, 3);
         checkCamera5.Name = "checkCamera5";
         checkCamera5.Size = new Size(31, 25);
         checkCamera5.TabIndex = 211;
         checkCamera5.Tag = "5";
         checkCamera5.Text = "5";
         // 
         // lblEngineITT
         // 
         lblEngineITT.Location = new Point(412, 659);
         lblEngineITT.Margin = new Padding(4, 3, 4, 3);
         lblEngineITT.Name = "lblEngineITT";
         lblEngineITT.Size = new Size(17, 17);
         lblEngineITT.TabIndex = 243;
         lblEngineITT.Text = "ITT";
         // 
         // checkCamera4
         // 
         checkCamera4.Location = new Point(889, 536);
         checkCamera4.Margin = new Padding(4, 3, 4, 3);
         checkCamera4.Name = "checkCamera4";
         checkCamera4.Size = new Size(31, 25);
         checkCamera4.TabIndex = 210;
         checkCamera4.Tag = "4";
         checkCamera4.Text = "4";
         // 
         // checkCockpitQuickViewSubState
         // 
         checkCockpitQuickViewSubState.Location = new Point(1004, 479);
         checkCockpitQuickViewSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitQuickViewSubState.Name = "checkCockpitQuickViewSubState";
         checkCockpitQuickViewSubState.Size = new Size(59, 25);
         checkCockpitQuickViewSubState.TabIndex = 233;
         checkCockpitQuickViewSubState.Text = "C-QV";
         checkCockpitQuickViewSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera3
         // 
         checkCamera3.Location = new Point(962, 568);
         checkCamera3.Margin = new Padding(4, 3, 4, 3);
         checkCamera3.Name = "checkCamera3";
         checkCamera3.Size = new Size(31, 25);
         checkCamera3.TabIndex = 209;
         checkCamera3.Tag = "3";
         checkCamera3.Text = "3";
         // 
         // lblEngineTorque
         // 
         lblEngineTorque.Location = new Point(412, 636);
         lblEngineTorque.Margin = new Padding(4, 3, 4, 3);
         lblEngineTorque.Name = "lblEngineTorque";
         lblEngineTorque.Size = new Size(42, 17);
         lblEngineTorque.TabIndex = 242;
         lblEngineTorque.Text = "Torque";
         // 
         // checkCamera2
         // 
         checkCamera2.Location = new Point(924, 568);
         checkCamera2.Margin = new Padding(4, 3, 4, 3);
         checkCamera2.Name = "checkCamera2";
         checkCamera2.Size = new Size(31, 25);
         checkCamera2.TabIndex = 207;
         checkCamera2.Tag = "2";
         checkCamera2.Text = "2";
         // 
         // checkCockpitInstrumentSubState
         // 
         checkCockpitInstrumentSubState.Location = new Point(1004, 449);
         checkCockpitInstrumentSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitInstrumentSubState.Name = "checkCockpitInstrumentSubState";
         checkCockpitInstrumentSubState.Size = new Size(59, 25);
         checkCockpitInstrumentSubState.TabIndex = 231;
         checkCockpitInstrumentSubState.Text = "Instr";
         checkCockpitInstrumentSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCamera1
         // 
         checkCamera1.Location = new Point(889, 568);
         checkCamera1.Margin = new Padding(4, 3, 4, 3);
         checkCamera1.Name = "checkCamera1";
         checkCamera1.Size = new Size(31, 25);
         checkCamera1.TabIndex = 206;
         checkCamera1.Tag = "1";
         checkCamera1.Text = "1";
         // 
         // lblFlapsCurrentPosition
         // 
         lblFlapsCurrentPosition.Location = new Point(676, 636);
         lblFlapsCurrentPosition.Margin = new Padding(4, 3, 4, 3);
         lblFlapsCurrentPosition.Name = "lblFlapsCurrentPosition";
         lblFlapsCurrentPosition.Size = new Size(93, 17);
         lblFlapsCurrentPosition.TabIndex = 240;
         lblFlapsCurrentPosition.Text = "Current Position";
         // 
         // checkCamera10
         // 
         checkCamera10.Location = new Point(889, 599);
         checkCamera10.Margin = new Padding(4, 3, 4, 3);
         checkCamera10.Name = "checkCamera10";
         checkCamera10.Size = new Size(66, 25);
         checkCamera10.TabIndex = 205;
         checkCamera10.Tag = "0";
         checkCamera10.Text = "0";
         // 
         // checkCockpitPilotSubState
         // 
         checkCockpitPilotSubState.Location = new Point(1004, 417);
         checkCockpitPilotSubState.Margin = new Padding(4, 3, 4, 3);
         checkCockpitPilotSubState.Name = "checkCockpitPilotSubState";
         checkCockpitPilotSubState.Size = new Size(59, 25);
         checkCockpitPilotSubState.TabIndex = 229;
         checkCockpitPilotSubState.Text = "Pilot";
         checkCockpitPilotSubState.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblFlapsNumberOfDetents
         // 
         lblFlapsNumberOfDetents.Location = new Point(676, 613);
         lblFlapsNumberOfDetents.Margin = new Padding(4, 3, 4, 3);
         lblFlapsNumberOfDetents.Name = "lblFlapsNumberOfDetents";
         lblFlapsNumberOfDetents.Size = new Size(112, 17);
         lblFlapsNumberOfDetents.TabIndex = 238;
         lblFlapsNumberOfDetents.Text = "Number of Detents";
         // 
         // lblIndex1
         // 
         lblIndex1.Location = new Point(264, 620);
         lblIndex1.Margin = new Padding(4, 3, 4, 3);
         lblIndex1.Name = "lblIndex1";
         lblIndex1.Size = new Size(51, 17);
         lblIndex1.TabIndex = 218;
         lblIndex1.Text = "Index1: x";
         // 
         // btnPreviousSubView
         // 
         btnPreviousSubView.Location = new Point(943, 449);
         btnPreviousSubView.Margin = new Padding(4, 3, 4, 3);
         btnPreviousSubView.Name = "btnPreviousSubView";
         btnPreviousSubView.Size = new Size(41, 25);
         btnPreviousSubView.TabIndex = 251;
         btnPreviousSubView.Text = "PSV";
         btnPreviousSubView.Click += CameraViewButton_Click;
         // 
         // lblIndex0
         // 
         lblIndex0.Location = new Point(264, 598);
         lblIndex0.Margin = new Padding(4, 3, 4, 3);
         lblIndex0.Name = "lblIndex0";
         lblIndex0.Size = new Size(51, 17);
         lblIndex0.TabIndex = 219;
         lblIndex0.Text = "Index0: x";
         // 
         // lblCurrentFlapsLimit
         // 
         lblCurrentFlapsLimit.Location = new Point(676, 590);
         lblCurrentFlapsLimit.Margin = new Padding(4, 3, 4, 3);
         lblCurrentFlapsLimit.Name = "lblCurrentFlapsLimit";
         lblCurrentFlapsLimit.Size = new Size(108, 17);
         lblCurrentFlapsLimit.TabIndex = 237;
         lblCurrentFlapsLimit.Text = "Current Flaps Limit";
         // 
         // lblCameraSubstate
         // 
         lblCameraSubstate.Location = new Point(264, 574);
         lblCameraSubstate.Margin = new Padding(4, 3, 4, 3);
         lblCameraSubstate.Name = "lblCameraSubstate";
         lblCameraSubstate.Size = new Size(63, 17);
         lblCameraSubstate.TabIndex = 217;
         lblCameraSubstate.Text = "Substate: x";
         // 
         // btnNextSubView
         // 
         btnNextSubView.Location = new Point(943, 417);
         btnNextSubView.Margin = new Padding(4, 3, 4, 3);
         btnNextSubView.Name = "btnNextSubView";
         btnNextSubView.Size = new Size(41, 25);
         btnNextSubView.TabIndex = 250;
         btnNextSubView.Text = "NSV";
         btnNextSubView.Click += CameraViewButton_Click;
         // 
         // lblCameraState
         // 
         lblCameraState.Location = new Point(264, 551);
         lblCameraState.Margin = new Padding(4, 3, 4, 3);
         lblCameraState.Name = "lblCameraState";
         lblCameraState.Size = new Size(42, 17);
         lblCameraState.TabIndex = 216;
         lblCameraState.Text = "State: x";
         // 
         // lblTrailingFlapsRight
         // 
         lblTrailingFlapsRight.Location = new Point(676, 568);
         lblTrailingFlapsRight.Margin = new Padding(4, 3, 4, 3);
         lblTrailingFlapsRight.Name = "lblTrailingFlapsRight";
         lblTrailingFlapsRight.Size = new Size(111, 17);
         lblTrailingFlapsRight.TabIndex = 234;
         lblTrailingFlapsRight.Text = "Trailing Flaps Right";
         // 
         // btnPreviousView
         // 
         btnPreviousView.Location = new Point(889, 449);
         btnPreviousView.Margin = new Padding(4, 3, 4, 3);
         btnPreviousView.Name = "btnPreviousView";
         btnPreviousView.Size = new Size(41, 25);
         btnPreviousView.TabIndex = 249;
         btnPreviousView.Text = "PV";
         btnPreviousView.Click += CameraViewButton_Click;
         // 
         // lblTrailingFlapsLeft
         // 
         lblTrailingFlapsLeft.Location = new Point(676, 544);
         lblTrailingFlapsLeft.Margin = new Padding(4, 3, 4, 3);
         lblTrailingFlapsLeft.Name = "lblTrailingFlapsLeft";
         lblTrailingFlapsLeft.Size = new Size(102, 17);
         lblTrailingFlapsLeft.TabIndex = 232;
         lblTrailingFlapsLeft.Text = "Trailing Flaps Left";
         // 
         // btnNextView
         // 
         btnNextView.Location = new Point(889, 417);
         btnNextView.Margin = new Padding(4, 3, 4, 3);
         btnNextView.Name = "btnNextView";
         btnNextView.Size = new Size(41, 25);
         btnNextView.TabIndex = 248;
         btnNextView.Text = "NV";
         btnNextView.Click += CameraViewButton_Click;
         // 
         // lblAileronTrimPct
         // 
         lblAileronTrimPct.Location = new Point(539, 590);
         lblAileronTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblAileronTrimPct.Name = "lblAileronTrimPct";
         lblAileronTrimPct.Size = new Size(96, 17);
         lblAileronTrimPct.TabIndex = 230;
         lblAileronTrimPct.Text = "Aileron Trim: 0%";
         // 
         // lblRudderTrimPct
         // 
         lblRudderTrimPct.Location = new Point(539, 568);
         lblRudderTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblRudderTrimPct.Name = "lblRudderTrimPct";
         lblRudderTrimPct.Size = new Size(98, 17);
         lblRudderTrimPct.TabIndex = 228;
         lblRudderTrimPct.Text = "Rudder Trim: 0%";
         // 
         // lblElevatorTrimPct
         // 
         lblElevatorTrimPct.Location = new Point(539, 544);
         lblElevatorTrimPct.Margin = new Padding(4, 3, 4, 3);
         lblElevatorTrimPct.Name = "lblElevatorTrimPct";
         lblElevatorTrimPct.Size = new Size(102, 17);
         lblElevatorTrimPct.TabIndex = 186;
         lblElevatorTrimPct.Text = "Elevator Trim: 0%";
         // 
         // btnSetCamera
         // 
         btnSetCamera.Location = new Point(178, 738);
         btnSetCamera.Margin = new Padding(4, 3, 4, 3);
         btnSetCamera.Name = "btnSetCamera";
         btnSetCamera.Size = new Size(148, 24);
         btnSetCamera.TabIndex = 226;
         btnSetCamera.Text = "Set Camera";
         btnSetCamera.Click += btnSetCamera_Click;
         // 
         // txtCameraIndex1
         // 
         txtCameraIndex1.Location = new Point(295, 707);
         txtCameraIndex1.Margin = new Padding(4, 3, 4, 3);
         txtCameraIndex1.Name = "txtCameraIndex1";
         txtCameraIndex1.Size = new Size(31, 24);
         txtCameraIndex1.TabIndex = 225;
         // 
         // txtCameraIndex0
         // 
         txtCameraIndex0.Location = new Point(257, 707);
         txtCameraIndex0.Margin = new Padding(4, 3, 4, 3);
         txtCameraIndex0.Name = "txtCameraIndex0";
         txtCameraIndex0.Size = new Size(31, 24);
         txtCameraIndex0.TabIndex = 224;
         // 
         // txtCameraSubState
         // 
         txtCameraSubState.Location = new Point(219, 707);
         txtCameraSubState.Margin = new Padding(4, 3, 4, 3);
         txtCameraSubState.Name = "txtCameraSubState";
         txtCameraSubState.Size = new Size(31, 24);
         txtCameraSubState.TabIndex = 223;
         // 
         // txtCameraState
         // 
         txtCameraState.Location = new Point(178, 707);
         txtCameraState.Margin = new Padding(4, 3, 4, 3);
         txtCameraState.Name = "txtCameraState";
         txtCameraState.Size = new Size(31, 24);
         txtCameraState.TabIndex = 222;
         // 
         // GroupControl1
         // 
         GroupControl1.Controls.Add(btnSimRateReset);
         GroupControl1.Controls.Add(btnSimRateDec);
         GroupControl1.Controls.Add(btnSimRateInc);
         GroupControl1.Controls.Add(lblSimRate);
         GroupControl1.Location = new Point(824, 203);
         GroupControl1.Margin = new Padding(4, 3, 4, 3);
         GroupControl1.Name = "GroupControl1";
         GroupControl1.Padding = new Padding(4, 3, 4, 3);
         GroupControl1.Size = new Size(237, 95);
         GroupControl1.TabIndex = 221;
         GroupControl1.Text = "Time";
         // 
         // btnSimRateReset
         // 
         btnSimRateReset.AutoSize = true;
         btnSimRateReset.Location = new Point(74, 52);
         btnSimRateReset.Margin = new Padding(4, 3, 4, 3);
         btnSimRateReset.Name = "btnSimRateReset";
         btnSimRateReset.Size = new Size(39, 22);
         btnSimRateReset.TabIndex = 69;
         btnSimRateReset.Text = "Reset";
         btnSimRateReset.Click += SimRateButton_Click;
         // 
         // btnSimRateDec
         // 
         btnSimRateDec.Location = new Point(10, 52);
         btnSimRateDec.Margin = new Padding(4, 3, 4, 3);
         btnSimRateDec.Name = "btnSimRateDec";
         btnSimRateDec.Size = new Size(24, 25);
         btnSimRateDec.TabIndex = 68;
         btnSimRateDec.Text = "-";
         btnSimRateDec.Click += SimRateButton_Click;
         // 
         // btnSimRateInc
         // 
         btnSimRateInc.Location = new Point(42, 52);
         btnSimRateInc.Margin = new Padding(4, 3, 4, 3);
         btnSimRateInc.Name = "btnSimRateInc";
         btnSimRateInc.Size = new Size(24, 25);
         btnSimRateInc.TabIndex = 67;
         btnSimRateInc.Text = "+";
         btnSimRateInc.Click += SimRateButton_Click;
         // 
         // lblSimRate
         // 
         lblSimRate.Location = new Point(10, 29);
         lblSimRate.Margin = new Padding(4, 3, 4, 3);
         lblSimRate.Name = "lblSimRate";
         lblSimRate.Size = new Size(71, 17);
         lblSimRate.TabIndex = 0;
         lblSimRate.Text = "Sim Rate: 1x";
         // 
         // lblCurrentCameraType
         // 
         lblCurrentCameraType.Location = new Point(746, 1279);
         lblCurrentCameraType.Margin = new Padding(4, 3, 4, 3);
         lblCurrentCameraType.Name = "lblCurrentCameraType";
         lblCurrentCameraType.Size = new Size(124, 17);
         lblCurrentCameraType.TabIndex = 227;
         lblCurrentCameraType.Text = "Current Camera Type";
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(760, 707);
         txtOutput.Margin = new Padding(4, 3, 4, 3);
         txtOutput.Name = "txtOutput";
         txtOutput.Properties.ReadOnly = true;
         txtOutput.Size = new Size(318, 116);
         txtOutput.TabIndex = 220;
         // 
         // groupCameras
         // 
         groupCameras.Controls.Add(checkCameraPilotCoPilot);
         groupCameras.Controls.Add(checkCameraPilotLand);
         groupCameras.Controls.Add(checkCameraPilotClose);
         groupCameras.Controls.Add(checkCameraPilotNormal);
         groupCameras.Controls.Add(lblCameraCurrentView);
         groupCameras.Location = new Point(276, 411);
         groupCameras.Margin = new Padding(4, 3, 4, 3);
         groupCameras.Name = "groupCameras";
         groupCameras.Padding = new Padding(4, 3, 4, 3);
         groupCameras.Size = new Size(458, 64);
         groupCameras.TabIndex = 208;
         groupCameras.Text = "Cameras";
         // 
         // checkCameraPilotCoPilot
         // 
         checkCameraPilotCoPilot.Location = new Point(211, 29);
         checkCameraPilotCoPilot.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotCoPilot.Name = "checkCameraPilotCoPilot";
         checkCameraPilotCoPilot.Size = new Size(59, 25);
         checkCameraPilotCoPilot.TabIndex = 57;
         checkCameraPilotCoPilot.Text = "CoPilot";
         checkCameraPilotCoPilot.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotLand
         // 
         checkCameraPilotLand.Location = new Point(144, 29);
         checkCameraPilotLand.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotLand.Name = "checkCameraPilotLand";
         checkCameraPilotLand.Size = new Size(59, 25);
         checkCameraPilotLand.TabIndex = 56;
         checkCameraPilotLand.Text = "Land";
         checkCameraPilotLand.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotClose
         // 
         checkCameraPilotClose.Location = new Point(10, 29);
         checkCameraPilotClose.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotClose.Name = "checkCameraPilotClose";
         checkCameraPilotClose.Size = new Size(59, 25);
         checkCameraPilotClose.TabIndex = 55;
         checkCameraPilotClose.Text = "Close";
         checkCameraPilotClose.CheckedChanged += CameraButton_CheckChanged;
         // 
         // checkCameraPilotNormal
         // 
         checkCameraPilotNormal.Location = new Point(77, 29);
         checkCameraPilotNormal.Margin = new Padding(4, 3, 4, 3);
         checkCameraPilotNormal.Name = "checkCameraPilotNormal";
         checkCameraPilotNormal.Size = new Size(59, 25);
         checkCameraPilotNormal.TabIndex = 54;
         checkCameraPilotNormal.Text = "Pilot";
         checkCameraPilotNormal.CheckedChanged += CameraButton_CheckChanged;
         // 
         // lblCameraCurrentView
         // 
         lblCameraCurrentView.Location = new Point(280, 33);
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
         groupFuel.Location = new Point(824, 303);
         groupFuel.Margin = new Padding(4, 3, 4, 3);
         groupFuel.Name = "groupFuel";
         groupFuel.Padding = new Padding(4, 3, 4, 3);
         groupFuel.Size = new Size(237, 88);
         groupFuel.TabIndex = 204;
         groupFuel.Text = "Fuel";
         // 
         // lblFuelDumpSwitch
         // 
         lblFuelDumpSwitch.Location = new Point(130, 56);
         lblFuelDumpSwitch.Margin = new Padding(4, 3, 4, 3);
         lblFuelDumpSwitch.Name = "lblFuelDumpSwitch";
         lblFuelDumpSwitch.Size = new Size(16, 17);
         lblFuelDumpSwitch.TabIndex = 67;
         lblFuelDumpSwitch.Text = "off";
         // 
         // btnFuelDump
         // 
         btnFuelDump.Location = new Point(70, 52);
         btnFuelDump.Margin = new Padding(4, 3, 4, 3);
         btnFuelDump.Name = "btnFuelDump";
         btnFuelDump.Size = new Size(52, 25);
         btnFuelDump.TabIndex = 66;
         btnFuelDump.Text = "DUMP";
         btnFuelDump.Click += FuelDumpButton_Click;
         // 
         // lblTotalFuelPct
         // 
         lblTotalFuelPct.Location = new Point(10, 29);
         lblTotalFuelPct.Margin = new Padding(4, 3, 4, 3);
         lblTotalFuelPct.Name = "lblTotalFuelPct";
         lblTotalFuelPct.Size = new Size(105, 17);
         lblTotalFuelPct.TabIndex = 65;
         lblTotalFuelPct.Text = "Total Fuel: 100.0%";
         // 
         // btnAddFuel
         // 
         btnAddFuel.Location = new Point(10, 52);
         btnAddFuel.Margin = new Padding(4, 3, 4, 3);
         btnAddFuel.Name = "btnAddFuel";
         btnAddFuel.Size = new Size(52, 25);
         btnAddFuel.TabIndex = 64;
         btnAddFuel.Text = "ADD";
         btnAddFuel.Click += AddFuelButton_Click;
         // 
         // groupPause
         // 
         groupPause.Controls.Add(btnPauseSim);
         groupPause.Controls.Add(checkPauseEsc);
         groupPause.Controls.Add(checkPauseSim);
         groupPause.Controls.Add(checkPauseActive);
         groupPause.Controls.Add(checkPauseFull);
         groupPause.Controls.Add(btnPauseFull);
         groupPause.Location = new Point(824, 61);
         groupPause.Margin = new Padding(4, 3, 4, 3);
         groupPause.Name = "groupPause";
         groupPause.Padding = new Padding(4, 3, 4, 3);
         groupPause.Size = new Size(237, 136);
         groupPause.TabIndex = 203;
         groupPause.Text = "Pause";
         // 
         // btnPauseSim
         // 
         btnPauseSim.Location = new Point(10, 78);
         btnPauseSim.Margin = new Padding(4, 3, 4, 3);
         btnPauseSim.Name = "btnPauseSim";
         btnPauseSim.Size = new Size(94, 44);
         btnPauseSim.TabIndex = 5;
         btnPauseSim.Text = "Sim Pause";
         btnPauseSim.Click += BtnPause_Click;
         // 
         // checkPauseEsc
         // 
         checkPauseEsc.Location = new Point(115, 101);
         checkPauseEsc.Margin = new Padding(4, 3, 4, 3);
         checkPauseEsc.Name = "checkPauseEsc";
         checkPauseEsc.Properties.Caption = "Esc Pause";
         checkPauseEsc.Properties.ReadOnly = true;
         checkPauseEsc.Size = new Size(102, 21);
         checkPauseEsc.TabIndex = 4;
         // 
         // checkPauseSim
         // 
         checkPauseSim.Location = new Point(115, 78);
         checkPauseSim.Margin = new Padding(4, 3, 4, 3);
         checkPauseSim.Name = "checkPauseSim";
         checkPauseSim.Properties.Caption = "Sim Pause";
         checkPauseSim.Properties.ReadOnly = true;
         checkPauseSim.Size = new Size(102, 21);
         checkPauseSim.TabIndex = 3;
         // 
         // checkPauseActive
         // 
         checkPauseActive.Location = new Point(115, 55);
         checkPauseActive.Margin = new Padding(4, 3, 4, 3);
         checkPauseActive.Name = "checkPauseActive";
         checkPauseActive.Properties.Caption = "Active Pause";
         checkPauseActive.Properties.ReadOnly = true;
         checkPauseActive.Size = new Size(102, 21);
         checkPauseActive.TabIndex = 2;
         // 
         // checkPauseFull
         // 
         checkPauseFull.Location = new Point(115, 31);
         checkPauseFull.Margin = new Padding(4, 3, 4, 3);
         checkPauseFull.Name = "checkPauseFull";
         checkPauseFull.Properties.Caption = "Full Pause";
         checkPauseFull.Properties.ReadOnly = true;
         checkPauseFull.Size = new Size(102, 21);
         checkPauseFull.TabIndex = 1;
         // 
         // btnPauseFull
         // 
         btnPauseFull.Location = new Point(10, 29);
         btnPauseFull.Margin = new Padding(4, 3, 4, 3);
         btnPauseFull.Name = "btnPauseFull";
         btnPauseFull.Size = new Size(94, 44);
         btnPauseFull.TabIndex = 0;
         btnPauseFull.Text = "Full Pause";
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
         groupFms.Location = new Point(276, 203);
         groupFms.Margin = new Padding(4, 3, 4, 3);
         groupFms.Name = "groupFms";
         groupFms.Padding = new Padding(4, 3, 4, 3);
         groupFms.Size = new Size(539, 95);
         groupFms.TabIndex = 202;
         groupFms.Text = "FMS";
         // 
         // btnFmsMfdInner
         // 
         btnFmsMfdInner.Location = new Point(352, 29);
         btnFmsMfdInner.Margin = new Padding(4, 3, 4, 3);
         btnFmsMfdInner.Name = "btnFmsMfdInner";
         btnFmsMfdInner.Size = new Size(46, 41);
         btnFmsMfdInner.TabIndex = 63;
         btnFmsMfdInner.Text = "MFD\r\nIN";
         // 
         // btnFmsMfdOuter
         // 
         btnFmsMfdOuter.Location = new Point(298, 29);
         btnFmsMfdOuter.Margin = new Padding(4, 3, 4, 3);
         btnFmsMfdOuter.Name = "btnFmsMfdOuter";
         btnFmsMfdOuter.Size = new Size(46, 41);
         btnFmsMfdOuter.TabIndex = 62;
         btnFmsMfdOuter.Text = "MFD\r\nOUT";
         // 
         // btnFmsEnt
         // 
         btnFmsEnt.Location = new Point(238, 60);
         btnFmsEnt.Margin = new Padding(4, 3, 4, 3);
         btnFmsEnt.Name = "btnFmsEnt";
         btnFmsEnt.Size = new Size(52, 25);
         btnFmsEnt.TabIndex = 61;
         btnFmsEnt.Text = "ENT";
         btnFmsEnt.Click += FmsButton_Click;
         // 
         // btnFmsClr
         // 
         btnFmsClr.Location = new Point(178, 60);
         btnFmsClr.Margin = new Padding(4, 3, 4, 3);
         btnFmsClr.Name = "btnFmsClr";
         btnFmsClr.Size = new Size(52, 25);
         btnFmsClr.TabIndex = 60;
         btnFmsClr.Text = "CLR";
         btnFmsClr.Click += FmsButton_Click;
         // 
         // btnFmsMenu
         // 
         btnFmsMenu.Location = new Point(118, 60);
         btnFmsMenu.Margin = new Padding(4, 3, 4, 3);
         btnFmsMenu.Name = "btnFmsMenu";
         btnFmsMenu.Size = new Size(52, 25);
         btnFmsMenu.TabIndex = 59;
         btnFmsMenu.Text = "MENU";
         btnFmsMenu.Click += FmsButton_Click;
         // 
         // btnFmsProc
         // 
         btnFmsProc.Location = new Point(238, 29);
         btnFmsProc.Margin = new Padding(4, 3, 4, 3);
         btnFmsProc.Name = "btnFmsProc";
         btnFmsProc.Size = new Size(52, 25);
         btnFmsProc.TabIndex = 58;
         btnFmsProc.Text = "PROC";
         btnFmsProc.Click += FmsButton_Click;
         // 
         // btnFmsFpl
         // 
         btnFmsFpl.Location = new Point(178, 29);
         btnFmsFpl.Margin = new Padding(4, 3, 4, 3);
         btnFmsFpl.Name = "btnFmsFpl";
         btnFmsFpl.Size = new Size(52, 25);
         btnFmsFpl.TabIndex = 57;
         btnFmsFpl.Text = "FPL";
         btnFmsFpl.Click += FmsButton_Click;
         // 
         // btnFmsDirect
         // 
         btnFmsDirect.Location = new Point(118, 29);
         btnFmsDirect.Margin = new Padding(4, 3, 4, 3);
         btnFmsDirect.Name = "btnFmsDirect";
         btnFmsDirect.Size = new Size(52, 25);
         btnFmsDirect.TabIndex = 56;
         btnFmsDirect.Text = "DIR";
         btnFmsDirect.Click += FmsButton_Click;
         // 
         // btnFmsPfdInner
         // 
         btnFmsPfdInner.Location = new Point(64, 29);
         btnFmsPfdInner.Margin = new Padding(4, 3, 4, 3);
         btnFmsPfdInner.Name = "btnFmsPfdInner";
         btnFmsPfdInner.Size = new Size(46, 41);
         btnFmsPfdInner.TabIndex = 55;
         btnFmsPfdInner.Text = "PFD\r\nIN";
         // 
         // btnFmsPfdOuter
         // 
         btnFmsPfdOuter.Location = new Point(10, 29);
         btnFmsPfdOuter.Margin = new Padding(4, 3, 4, 3);
         btnFmsPfdOuter.Name = "btnFmsPfdOuter";
         btnFmsPfdOuter.Size = new Size(46, 41);
         btnFmsPfdOuter.TabIndex = 54;
         btnFmsPfdOuter.Text = "PFD\r\nOUT";
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
         groupAutopilot.Location = new Point(276, 61);
         groupAutopilot.Margin = new Padding(4, 3, 4, 3);
         groupAutopilot.Name = "groupAutopilot";
         groupAutopilot.Padding = new Padding(4, 3, 4, 3);
         groupAutopilot.Size = new Size(539, 136);
         groupAutopilot.TabIndex = 201;
         groupAutopilot.Text = "Autopilot";
         // 
         // lblApproachStatus
         // 
         lblApproachStatus.Location = new Point(10, 107);
         lblApproachStatus.Margin = new Padding(4, 3, 4, 3);
         lblApproachStatus.Name = "lblApproachStatus";
         lblApproachStatus.Size = new Size(64, 17);
         lblApproachStatus.TabIndex = 54;
         lblApproachStatus.Text = "Approach: ";
         // 
         // btnCrs2Sel
         // 
         btnCrs2Sel.Location = new Point(484, 59);
         btnCrs2Sel.Margin = new Padding(4, 3, 4, 3);
         btnCrs2Sel.Name = "btnCrs2Sel";
         btnCrs2Sel.Size = new Size(46, 41);
         btnCrs2Sel.TabIndex = 53;
         btnCrs2Sel.Text = "CS2\r\nSEL";
         btnCrs2Sel.Click += AutopilotButton_Click;
         btnCrs2Sel.MouseEnter += btnCrs2Sel_MouseEnter;
         btnCrs2Sel.MouseLeave += btnCrs2Sel_MouseLeave;
         btnCrs2Sel.MouseHover += btnCrs2Sel_MouseHover;
         // 
         // checkApSpd
         // 
         checkApSpd.Location = new Point(430, 60);
         checkApSpd.Margin = new Padding(4, 3, 4, 3);
         checkApSpd.Name = "checkApSpd";
         checkApSpd.Size = new Size(46, 25);
         checkApSpd.TabIndex = 52;
         checkApSpd.Text = "SPD";
         checkApSpd.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApFlc
         // 
         checkApFlc.Location = new Point(430, 29);
         checkApFlc.Margin = new Padding(4, 3, 4, 3);
         checkApFlc.Name = "checkApFlc";
         checkApFlc.Size = new Size(46, 25);
         checkApFlc.TabIndex = 51;
         checkApFlc.Text = "FLC";
         checkApFlc.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // btnNoseUpDn
         // 
         btnNoseUpDn.Location = new Point(388, 29);
         btnNoseUpDn.Margin = new Padding(4, 3, 4, 3);
         btnNoseUpDn.Name = "btnNoseUpDn";
         btnNoseUpDn.Size = new Size(34, 75);
         btnNoseUpDn.TabIndex = 50;
         btnNoseUpDn.Text = "DN\r\n\r\n\r\nUP";
         // 
         // checkApVnv
         // 
         checkApVnv.Location = new Point(332, 60);
         checkApVnv.Margin = new Padding(4, 3, 4, 3);
         checkApVnv.Name = "checkApVnv";
         checkApVnv.Size = new Size(46, 25);
         checkApVnv.TabIndex = 49;
         checkApVnv.Text = "VNV";
         checkApVnv.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApVsHold
         // 
         checkApVsHold.Location = new Point(332, 29);
         checkApVsHold.Margin = new Padding(4, 3, 4, 3);
         checkApVsHold.Name = "checkApVsHold";
         checkApVsHold.Size = new Size(46, 25);
         checkApVsHold.TabIndex = 48;
         checkApVsHold.Text = "VS";
         checkApVsHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // btnAltSel
         // 
         btnAltSel.Location = new Point(280, 60);
         btnAltSel.Margin = new Padding(4, 3, 4, 3);
         btnAltSel.Name = "btnAltSel";
         btnAltSel.Size = new Size(46, 41);
         btnAltSel.TabIndex = 47;
         btnAltSel.Text = "ALT\r\nSEL";
         btnAltSel.Click += AutopilotButton_Click;
         // 
         // checkApAltHold
         // 
         checkApAltHold.Location = new Point(280, 29);
         checkApAltHold.Margin = new Padding(4, 3, 4, 3);
         checkApAltHold.Name = "checkApAltHold";
         checkApAltHold.Size = new Size(46, 25);
         checkApAltHold.TabIndex = 46;
         checkApAltHold.Text = "ALT";
         checkApAltHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApYd
         // 
         checkApYd.Location = new Point(227, 60);
         checkApYd.Margin = new Padding(4, 3, 4, 3);
         checkApYd.Name = "checkApYd";
         checkApYd.Size = new Size(46, 25);
         checkApYd.TabIndex = 45;
         checkApYd.Text = "YD";
         checkApYd.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApFd
         // 
         checkApFd.Location = new Point(200, 29);
         checkApFd.Margin = new Padding(4, 3, 4, 3);
         checkApFd.Name = "checkApFd";
         checkApFd.Size = new Size(46, 25);
         checkApFd.TabIndex = 44;
         checkApFd.Text = "FD";
         checkApFd.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApMaster
         // 
         checkApMaster.Location = new Point(172, 60);
         checkApMaster.Margin = new Padding(4, 3, 4, 3);
         checkApMaster.Name = "checkApMaster";
         checkApMaster.Size = new Size(46, 25);
         checkApMaster.TabIndex = 38;
         checkApMaster.Text = "AP";
         checkApMaster.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // btnCrs1Sel
         // 
         btnCrs1Sel.Location = new Point(118, 60);
         btnCrs1Sel.Margin = new Padding(4, 3, 4, 3);
         btnCrs1Sel.Name = "btnCrs1Sel";
         btnCrs1Sel.Size = new Size(46, 41);
         btnCrs1Sel.TabIndex = 43;
         btnCrs1Sel.Text = "CS1\r\nSEL";
         btnCrs1Sel.Click += AutopilotButton_Click;
         btnCrs1Sel.MouseEnter += btnCrs2Sel_MouseEnter;
         btnCrs1Sel.MouseLeave += btnCrs2Sel_MouseLeave;
         // 
         // btnHdgSel
         // 
         btnHdgSel.Location = new Point(10, 60);
         btnHdgSel.Margin = new Padding(4, 3, 4, 3);
         btnHdgSel.Name = "btnHdgSel";
         btnHdgSel.Size = new Size(46, 41);
         btnHdgSel.TabIndex = 39;
         btnHdgSel.Text = "HDG\r\nSEL";
         btnHdgSel.Click += AutopilotButton_Click;
         // 
         // checkApBcHold
         // 
         checkApBcHold.Location = new Point(64, 60);
         checkApBcHold.Margin = new Padding(4, 3, 4, 3);
         checkApBcHold.Name = "checkApBcHold";
         checkApBcHold.Size = new Size(46, 25);
         checkApBcHold.TabIndex = 42;
         checkApBcHold.Text = "BC";
         checkApBcHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApAprHold
         // 
         checkApAprHold.Location = new Point(64, 29);
         checkApAprHold.Margin = new Padding(4, 3, 4, 3);
         checkApAprHold.Name = "checkApAprHold";
         checkApAprHold.Size = new Size(46, 25);
         checkApAprHold.TabIndex = 41;
         checkApAprHold.Text = "APR";
         checkApAprHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApNavHold
         // 
         checkApNavHold.Location = new Point(118, 29);
         checkApNavHold.Margin = new Padding(4, 3, 4, 3);
         checkApNavHold.Name = "checkApNavHold";
         checkApNavHold.Size = new Size(46, 25);
         checkApNavHold.TabIndex = 40;
         checkApNavHold.Text = "NAV";
         checkApNavHold.CheckedChanged += Autopilot_CheckedChanged;
         // 
         // checkApHdgHold
         // 
         checkApHdgHold.Location = new Point(10, 29);
         checkApHdgHold.Margin = new Padding(4, 3, 4, 3);
         checkApHdgHold.Name = "checkApHdgHold";
         checkApHdgHold.Size = new Size(46, 25);
         checkApHdgHold.TabIndex = 39;
         checkApHdgHold.Text = "HDG";
         checkApHdgHold.CheckedChanged += Autopilot_CheckedChanged;
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
         groupLights.Location = new Point(276, 303);
         groupLights.Margin = new Padding(4, 3, 4, 3);
         groupLights.Name = "groupLights";
         groupLights.Padding = new Padding(4, 3, 4, 3);
         groupLights.Size = new Size(539, 102);
         groupLights.TabIndex = 185;
         groupLights.Text = "Lights";
         // 
         // checkBeaconLight
         // 
         checkBeaconLight.AutoSize = true;
         checkBeaconLight.Location = new Point(10, 29);
         checkBeaconLight.Margin = new Padding(4, 3, 4, 3);
         checkBeaconLight.Name = "checkBeaconLight";
         checkBeaconLight.Padding = new Padding(4, 3, 4, 3);
         checkBeaconLight.Size = new Size(57, 28);
         checkBeaconLight.TabIndex = 2;
         checkBeaconLight.Text = "Beacon";
         checkBeaconLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkWingLight
         // 
         checkWingLight.AutoSize = true;
         checkWingLight.Location = new Point(331, 63);
         checkWingLight.Margin = new Padding(4, 3, 4, 3);
         checkWingLight.Name = "checkWingLight";
         checkWingLight.Padding = new Padding(4, 3, 4, 3);
         checkWingLight.Size = new Size(45, 28);
         checkWingLight.TabIndex = 44;
         checkWingLight.Text = "Wing";
         checkWingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkCabinLight
         // 
         checkCabinLight.AutoSize = true;
         checkCabinLight.Location = new Point(74, 29);
         checkCabinLight.Margin = new Padding(4, 3, 4, 3);
         checkCabinLight.Name = "checkCabinLight";
         checkCabinLight.Padding = new Padding(4, 3, 4, 3);
         checkCabinLight.Size = new Size(48, 28);
         checkCabinLight.TabIndex = 34;
         checkCabinLight.Text = "Cabin";
         checkCabinLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkTaxiLight
         // 
         checkTaxiLight.AutoSize = true;
         checkTaxiLight.Location = new Point(287, 63);
         checkTaxiLight.Margin = new Padding(4, 3, 4, 3);
         checkTaxiLight.Name = "checkTaxiLight";
         checkTaxiLight.Padding = new Padding(4, 3, 4, 3);
         checkTaxiLight.Size = new Size(38, 28);
         checkTaxiLight.TabIndex = 43;
         checkTaxiLight.Text = "Taxi";
         checkTaxiLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkGlareshieldLight
         // 
         checkGlareshieldLight.AutoSize = true;
         checkGlareshieldLight.Location = new Point(127, 29);
         checkGlareshieldLight.Margin = new Padding(4, 3, 4, 3);
         checkGlareshieldLight.Name = "checkGlareshieldLight";
         checkGlareshieldLight.Padding = new Padding(4, 3, 4, 3);
         checkGlareshieldLight.Size = new Size(80, 28);
         checkGlareshieldLight.TabIndex = 35;
         checkGlareshieldLight.Text = "Glareshield";
         checkGlareshieldLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkStrobeLight
         // 
         checkStrobeLight.AutoSize = true;
         checkStrobeLight.Location = new Point(227, 63);
         checkStrobeLight.Margin = new Padding(4, 3, 4, 3);
         checkStrobeLight.Name = "checkStrobeLight";
         checkStrobeLight.Padding = new Padding(4, 3, 4, 3);
         checkStrobeLight.Size = new Size(54, 28);
         checkStrobeLight.TabIndex = 42;
         checkStrobeLight.Text = "Strobe";
         checkStrobeLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLandingLight
         // 
         checkLandingLight.AutoSize = true;
         checkLandingLight.Location = new Point(214, 29);
         checkLandingLight.Margin = new Padding(4, 3, 4, 3);
         checkLandingLight.Name = "checkLandingLight";
         checkLandingLight.Padding = new Padding(4, 3, 4, 3);
         checkLandingLight.Size = new Size(61, 28);
         checkLandingLight.TabIndex = 36;
         checkLandingLight.Text = "Landing";
         checkLandingLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkRecognitionLight
         // 
         checkRecognitionLight.AutoSize = true;
         checkRecognitionLight.Location = new Point(136, 63);
         checkRecognitionLight.Margin = new Padding(4, 3, 4, 3);
         checkRecognitionLight.Name = "checkRecognitionLight";
         checkRecognitionLight.Padding = new Padding(4, 3, 4, 3);
         checkRecognitionLight.Size = new Size(84, 28);
         checkRecognitionLight.TabIndex = 41;
         checkRecognitionLight.Text = "Recognition";
         checkRecognitionLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkLogoLight
         // 
         checkLogoLight.AutoSize = true;
         checkLogoLight.Location = new Point(280, 29);
         checkLogoLight.Margin = new Padding(4, 3, 4, 3);
         checkLogoLight.Name = "checkLogoLight";
         checkLogoLight.Padding = new Padding(4, 3, 4, 3);
         checkLogoLight.Size = new Size(45, 28);
         checkLogoLight.TabIndex = 37;
         checkLogoLight.Text = "Logo";
         checkLogoLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPedestralLight
         // 
         checkPedestralLight.AutoSize = true;
         checkPedestralLight.Location = new Point(62, 63);
         checkPedestralLight.Margin = new Padding(4, 3, 4, 3);
         checkPedestralLight.Name = "checkPedestralLight";
         checkPedestralLight.Padding = new Padding(4, 3, 4, 3);
         checkPedestralLight.Size = new Size(69, 28);
         checkPedestralLight.TabIndex = 40;
         checkPedestralLight.Text = "Pedestral";
         checkPedestralLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkNavLight
         // 
         checkNavLight.AutoSize = true;
         checkNavLight.Location = new Point(331, 29);
         checkNavLight.Margin = new Padding(4, 3, 4, 3);
         checkNavLight.Name = "checkNavLight";
         checkNavLight.Padding = new Padding(4, 3, 4, 3);
         checkNavLight.Size = new Size(38, 28);
         checkNavLight.TabIndex = 38;
         checkNavLight.Text = "Nav";
         checkNavLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // checkPanelLight
         // 
         checkPanelLight.AutoSize = true;
         checkPanelLight.Location = new Point(10, 63);
         checkPanelLight.Margin = new Padding(4, 3, 4, 3);
         checkPanelLight.Name = "checkPanelLight";
         checkPanelLight.Padding = new Padding(4, 3, 4, 3);
         checkPanelLight.Size = new Size(46, 28);
         checkPanelLight.TabIndex = 39;
         checkPanelLight.Text = "Panel";
         checkPanelLight.CheckedChanged += LightButton_CheckedChanged;
         // 
         // lblTransponder
         // 
         lblTransponder.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblTransponder.Appearance.Options.UseFont = true;
         lblTransponder.Location = new Point(24, 634);
         lblTransponder.Margin = new Padding(4, 3, 4, 3);
         lblTransponder.Name = "lblTransponder";
         lblTransponder.Size = new Size(64, 40);
         lblTransponder.TabIndex = 200;
         lblTransponder.Text = "0000";
         // 
         // label4
         // 
         label4.Location = new Point(24, 615);
         label4.Margin = new Padding(4, 3, 4, 3);
         label4.Name = "label4";
         label4.Size = new Size(75, 17);
         label4.TabIndex = 199;
         label4.Text = "Transponder";
         // 
         // lblVerticalSpeedValue
         // 
         lblVerticalSpeedValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblVerticalSpeedValue.Appearance.Options.UseFont = true;
         lblVerticalSpeedValue.Location = new Point(150, 569);
         lblVerticalSpeedValue.Margin = new Padding(4, 3, 4, 3);
         lblVerticalSpeedValue.Name = "lblVerticalSpeedValue";
         lblVerticalSpeedValue.Size = new Size(76, 40);
         lblVerticalSpeedValue.TabIndex = 198;
         lblVerticalSpeedValue.Text = "-0000";
         // 
         // label7
         // 
         label7.Location = new Point(150, 551);
         label7.Margin = new Padding(4, 3, 4, 3);
         label7.Name = "label7";
         label7.Size = new Size(84, 17);
         label7.TabIndex = 197;
         label7.Text = "Vertical Speed";
         // 
         // label5
         // 
         label5.Location = new Point(24, 551);
         label5.Margin = new Padding(4, 3, 4, 3);
         label5.Name = "label5";
         label5.Size = new Size(44, 17);
         label5.TabIndex = 195;
         label5.Text = "Altitude";
         // 
         // lblCourseSel
         // 
         lblCourseSel.Location = new Point(150, 485);
         lblCourseSel.Margin = new Padding(4, 3, 4, 3);
         lblCourseSel.Name = "lblCourseSel";
         lblCourseSel.Size = new Size(41, 17);
         lblCourseSel.TabIndex = 193;
         lblCourseSel.Text = "Course";
         // 
         // groupNav2
         // 
         groupNav2.Controls.Add(lblNav2Standby);
         groupNav2.Controls.Add(lblNav2Active);
         groupNav2.Controls.Add(navRadioDisplay2Active);
         groupNav2.Controls.Add(navRadioDisplay2Standby);
         groupNav2.Location = new Point(13, 379);
         groupNav2.Margin = new Padding(4, 3, 4, 3);
         groupNav2.Name = "groupNav2";
         groupNav2.Padding = new Padding(4, 3, 4, 3);
         groupNav2.Size = new Size(255, 99);
         groupNav2.TabIndex = 192;
         groupNav2.Text = "NAV 2";
         // 
         // lblNav2Standby
         // 
         lblNav2Standby.Location = new Point(10, 29);
         lblNav2Standby.Margin = new Padding(4, 3, 4, 3);
         lblNav2Standby.Name = "lblNav2Standby";
         lblNav2Standby.Size = new Size(47, 17);
         lblNav2Standby.TabIndex = 2;
         lblNav2Standby.Text = "Standby";
         // 
         // lblNav2Active
         // 
         lblNav2Active.Location = new Point(139, 29);
         lblNav2Active.Margin = new Padding(4, 3, 4, 3);
         lblNav2Active.Name = "lblNav2Active";
         lblNav2Active.Size = new Size(34, 17);
         lblNav2Active.TabIndex = 3;
         lblNav2Active.Text = "Active";
         // 
         // navRadioDisplay2Active
         // 
         navRadioDisplay2Active.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         navRadioDisplay2Active.Id = 2;
         navRadioDisplay2Active.Location = new Point(139, 48);
         navRadioDisplay2Active.Margin = new Padding(3, 2, 3, 2);
         navRadioDisplay2Active.Name = "navRadioDisplay2Active";
         navRadioDisplay2Active.Size = new Size(86, 40);
         navRadioDisplay2Active.TabIndex = 280;
         navRadioDisplay2Active.Value = 108D;
         // 
         // navRadioDisplay2Standby
         // 
         navRadioDisplay2Standby.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         navRadioDisplay2Standby.Id = 2;
         navRadioDisplay2Standby.IsHighlightable = true;
         navRadioDisplay2Standby.Location = new Point(10, 48);
         navRadioDisplay2Standby.Margin = new Padding(3, 2, 3, 2);
         navRadioDisplay2Standby.Name = "navRadioDisplay2Standby";
         navRadioDisplay2Standby.Size = new Size(86, 40);
         navRadioDisplay2Standby.TabIndex = 281;
         navRadioDisplay2Standby.Value = 108D;
         // 
         // label2
         // 
         label2.Location = new Point(24, 485);
         label2.Margin = new Padding(4, 3, 4, 3);
         label2.Name = "label2";
         label2.Size = new Size(49, 17);
         label2.TabIndex = 187;
         label2.Text = "Heading";
         // 
         // groupNav1
         // 
         groupNav1.Controls.Add(lblNav1Standby);
         groupNav1.Controls.Add(lblNav1Active);
         groupNav1.Controls.Add(navRadioDisplay1Standby);
         groupNav1.Controls.Add(navRadioDisplay1Active);
         groupNav1.Location = new Point(13, 275);
         groupNav1.Margin = new Padding(4, 3, 4, 3);
         groupNav1.Name = "groupNav1";
         groupNav1.Padding = new Padding(4, 3, 4, 3);
         groupNav1.Size = new Size(255, 99);
         groupNav1.TabIndex = 191;
         groupNav1.Text = "NAV 1";
         // 
         // lblNav1Standby
         // 
         lblNav1Standby.Location = new Point(10, 29);
         lblNav1Standby.Margin = new Padding(4, 3, 4, 3);
         lblNav1Standby.Name = "lblNav1Standby";
         lblNav1Standby.Size = new Size(47, 17);
         lblNav1Standby.TabIndex = 2;
         lblNav1Standby.Text = "Standby";
         // 
         // lblNav1Active
         // 
         lblNav1Active.Location = new Point(139, 29);
         lblNav1Active.Margin = new Padding(4, 3, 4, 3);
         lblNav1Active.Name = "lblNav1Active";
         lblNav1Active.Size = new Size(34, 17);
         lblNav1Active.TabIndex = 3;
         lblNav1Active.Text = "Active";
         // 
         // navRadioDisplay1Standby
         // 
         navRadioDisplay1Standby.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         navRadioDisplay1Standby.IsHighlightable = true;
         navRadioDisplay1Standby.Location = new Point(10, 48);
         navRadioDisplay1Standby.Margin = new Padding(3, 2, 3, 2);
         navRadioDisplay1Standby.Name = "navRadioDisplay1Standby";
         navRadioDisplay1Standby.Size = new Size(86, 40);
         navRadioDisplay1Standby.TabIndex = 279;
         navRadioDisplay1Standby.Value = 108D;
         // 
         // navRadioDisplay1Active
         // 
         navRadioDisplay1Active.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         navRadioDisplay1Active.Location = new Point(139, 48);
         navRadioDisplay1Active.Margin = new Padding(3, 2, 3, 2);
         navRadioDisplay1Active.Name = "navRadioDisplay1Active";
         navRadioDisplay1Active.Size = new Size(86, 40);
         navRadioDisplay1Active.TabIndex = 280;
         navRadioDisplay1Active.Value = 108D;
         // 
         // groupCom2
         // 
         groupCom2.Controls.Add(comRadioDisplay2Active);
         groupCom2.Controls.Add(comRadioDisplay2Standby);
         groupCom2.Controls.Add(lblCom2Standby);
         groupCom2.Controls.Add(lblCom2Active);
         groupCom2.Location = new Point(13, 167);
         groupCom2.Margin = new Padding(4, 3, 4, 3);
         groupCom2.Name = "groupCom2";
         groupCom2.Padding = new Padding(4, 3, 4, 3);
         groupCom2.Size = new Size(255, 99);
         groupCom2.TabIndex = 190;
         groupCom2.Text = "COM 2";
         // 
         // comRadioDisplay2Active
         // 
         comRadioDisplay2Active.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         comRadioDisplay2Active.Id = 2;
         comRadioDisplay2Active.Location = new Point(139, 48);
         comRadioDisplay2Active.Margin = new Padding(3, 2, 3, 2);
         comRadioDisplay2Active.Name = "comRadioDisplay2Active";
         comRadioDisplay2Active.Size = new Size(102, 40);
         comRadioDisplay2Active.TabIndex = 8;
         comRadioDisplay2Active.Value = 118D;
         // 
         // comRadioDisplay2Standby
         // 
         comRadioDisplay2Standby.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         comRadioDisplay2Standby.Id = 2;
         comRadioDisplay2Standby.IsHighlightable = true;
         comRadioDisplay2Standby.Location = new Point(10, 48);
         comRadioDisplay2Standby.Margin = new Padding(3, 2, 3, 2);
         comRadioDisplay2Standby.Name = "comRadioDisplay2Standby";
         comRadioDisplay2Standby.Size = new Size(102, 40);
         comRadioDisplay2Standby.TabIndex = 6;
         comRadioDisplay2Standby.Value = 118D;
         // 
         // lblCom2Standby
         // 
         lblCom2Standby.Location = new Point(10, 29);
         lblCom2Standby.Margin = new Padding(4, 3, 4, 3);
         lblCom2Standby.Name = "lblCom2Standby";
         lblCom2Standby.Size = new Size(47, 17);
         lblCom2Standby.TabIndex = 6;
         lblCom2Standby.Text = "Standby";
         // 
         // lblCom2Active
         // 
         lblCom2Active.Location = new Point(139, 29);
         lblCom2Active.Margin = new Padding(4, 3, 4, 3);
         lblCom2Active.Name = "lblCom2Active";
         lblCom2Active.Size = new Size(34, 17);
         lblCom2Active.TabIndex = 7;
         lblCom2Active.Text = "Active";
         // 
         // groupCom1
         // 
         groupCom1.Controls.Add(comRadioDisplay1Active);
         groupCom1.Controls.Add(comRadioDisplay1Standby);
         groupCom1.Controls.Add(lblCom1Standby);
         groupCom1.Controls.Add(lblCom1Active);
         groupCom1.Location = new Point(13, 61);
         groupCom1.Margin = new Padding(4, 3, 4, 3);
         groupCom1.Name = "groupCom1";
         groupCom1.Padding = new Padding(4, 3, 4, 3);
         groupCom1.Size = new Size(255, 99);
         groupCom1.TabIndex = 189;
         groupCom1.Text = "COM 1";
         // 
         // comRadioDisplay1Active
         // 
         comRadioDisplay1Active.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         comRadioDisplay1Active.Location = new Point(139, 48);
         comRadioDisplay1Active.Margin = new Padding(3, 2, 3, 2);
         comRadioDisplay1Active.Name = "comRadioDisplay1Active";
         comRadioDisplay1Active.Size = new Size(102, 40);
         comRadioDisplay1Active.TabIndex = 5;
         comRadioDisplay1Active.Value = 118D;
         // 
         // comRadioDisplay1Standby
         // 
         comRadioDisplay1Standby.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         comRadioDisplay1Standby.IsHighlightable = true;
         comRadioDisplay1Standby.Location = new Point(10, 48);
         comRadioDisplay1Standby.Margin = new Padding(3, 2, 3, 2);
         comRadioDisplay1Standby.Name = "comRadioDisplay1Standby";
         comRadioDisplay1Standby.Size = new Size(102, 40);
         comRadioDisplay1Standby.TabIndex = 4;
         comRadioDisplay1Standby.Value = 118D;
         // 
         // lblCom1Standby
         // 
         lblCom1Standby.Location = new Point(10, 29);
         lblCom1Standby.Margin = new Padding(4, 3, 4, 3);
         lblCom1Standby.Name = "lblCom1Standby";
         lblCom1Standby.Size = new Size(47, 17);
         lblCom1Standby.TabIndex = 2;
         lblCom1Standby.Text = "Standby";
         // 
         // lblCom1Active
         // 
         lblCom1Active.Location = new Point(139, 29);
         lblCom1Active.Margin = new Padding(4, 3, 4, 3);
         lblCom1Active.Name = "lblCom1Active";
         lblCom1Active.Size = new Size(34, 17);
         lblCom1Active.TabIndex = 3;
         lblCom1Active.Text = "Active";
         // 
         // toolbarFormControl1
         // 
         toolbarFormControl1.Controls.Add(gridLookUpEdit1);
         toolbarFormControl1.Location = new Point(0, 0);
         toolbarFormControl1.Manager = toolbarFormManager1;
         toolbarFormControl1.Margin = new Padding(4, 3, 4, 3);
         toolbarFormControl1.Name = "toolbarFormControl1";
         toolbarFormControl1.Size = new Size(1133, 31);
         toolbarFormControl1.TabIndex = 270;
         toolbarFormControl1.TabStop = false;
         toolbarFormControl1.TitleItemLinks.Add(skinPaletteDropDownButtonItem1);
         toolbarFormControl1.TitleItemLinks.Add(skinDropDownButtonItem1);
         toolbarFormControl1.ToolbarForm = this;
         // 
         // gridLookUpEdit1
         // 
         gridLookUpEdit1.Location = new Point(479, 30);
         gridLookUpEdit1.Margin = new Padding(4, 3, 4, 3);
         gridLookUpEdit1.MenuManager = toolbarFormManager1;
         gridLookUpEdit1.Name = "gridLookUpEdit1";
         gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
         gridLookUpEdit1.Properties.PopupView = gridLookUpEdit1View;
         gridLookUpEdit1.Size = new Size(100, 24);
         gridLookUpEdit1.TabIndex = 0;
         // 
         // toolbarFormManager1
         // 
         toolbarFormManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar2 });
         toolbarFormManager1.DockControls.Add(barDockControlTop);
         toolbarFormManager1.DockControls.Add(barDockControlBottom);
         toolbarFormManager1.DockControls.Add(barDockControlLeft);
         toolbarFormManager1.DockControls.Add(barDockControlRight);
         toolbarFormManager1.Form = this;
         toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { lblSimConnectStatus, lblFsuipcStatus, menuApp, menuMacroPad, menuUtility, skinPaletteDropDownButtonItem1, skinDropDownButtonItem1, menuConnectSimConnect, menuExit, menuConnectFsuipc, lblSerialPortStatus, menuRefreshSerialPorts, menuPresetEvents, lblSimAircraft, lblMacroPadState, lblLocalTime });
         toolbarFormManager1.MainMenu = bar1;
         toolbarFormManager1.MaxItemId = 16;
         toolbarFormManager1.StatusBar = bar2;
         // 
         // bar1
         // 
         bar1.BarName = "Custom 2";
         bar1.DockCol = 0;
         bar1.DockRow = 0;
         bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(menuApp), new DevExpress.XtraBars.LinkPersistInfo(menuMacroPad), new DevExpress.XtraBars.LinkPersistInfo(menuUtility) });
         bar1.OptionsBar.MultiLine = true;
         bar1.OptionsBar.UseWholeRow = true;
         bar1.Text = "Custom 2";
         // 
         // menuApp
         // 
         menuApp.Caption = "App";
         menuApp.Id = 2;
         menuApp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(menuConnectSimConnect), new DevExpress.XtraBars.LinkPersistInfo(menuConnectFsuipc), new DevExpress.XtraBars.LinkPersistInfo(menuExit) });
         menuApp.Name = "menuApp";
         // 
         // menuConnectSimConnect
         // 
         menuConnectSimConnect.Caption = "Connect SimConnect";
         menuConnectSimConnect.Id = 7;
         menuConnectSimConnect.Name = "menuConnectSimConnect";
         // 
         // menuConnectFsuipc
         // 
         menuConnectFsuipc.Caption = "Connect FSUIPC";
         menuConnectFsuipc.Id = 9;
         menuConnectFsuipc.Name = "menuConnectFsuipc";
         // 
         // menuExit
         // 
         menuExit.Caption = "Exit";
         menuExit.Id = 8;
         menuExit.Name = "menuExit";
         menuExit.ItemClick += menuExit_ItemClick;
         // 
         // menuMacroPad
         // 
         menuMacroPad.Caption = "MacroPad";
         menuMacroPad.Id = 3;
         menuMacroPad.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(menuRefreshSerialPorts) });
         menuMacroPad.Name = "menuMacroPad";
         // 
         // menuRefreshSerialPorts
         // 
         menuRefreshSerialPorts.Caption = "Refresh Serial Ports";
         menuRefreshSerialPorts.Id = 11;
         menuRefreshSerialPorts.Name = "menuRefreshSerialPorts";
         menuRefreshSerialPorts.ItemClick += menuRefreshSerialPorts_ItemClick;
         // 
         // menuUtility
         // 
         menuUtility.Caption = "Utility";
         menuUtility.Id = 4;
         menuUtility.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(menuPresetEvents) });
         menuUtility.Name = "menuUtility";
         // 
         // menuPresetEvents
         // 
         menuPresetEvents.Caption = "Preset Events...";
         menuPresetEvents.Id = 12;
         menuPresetEvents.Name = "menuPresetEvents";
         menuPresetEvents.ItemClick += menuPresetEvents_ItemClick;
         // 
         // bar2
         // 
         bar2.BarName = "Custom 3";
         bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         bar2.DockCol = 0;
         bar2.DockRow = 0;
         bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(lblSimConnectStatus), new DevExpress.XtraBars.LinkPersistInfo(lblFsuipcStatus), new DevExpress.XtraBars.LinkPersistInfo(lblSerialPortStatus), new DevExpress.XtraBars.LinkPersistInfo(lblSimAircraft), new DevExpress.XtraBars.LinkPersistInfo(lblMacroPadState), new DevExpress.XtraBars.LinkPersistInfo(lblLocalTime) });
         bar2.OptionsBar.AllowQuickCustomization = false;
         bar2.OptionsBar.DrawDragBorder = false;
         bar2.OptionsBar.UseWholeRow = true;
         bar2.Text = "Custom 3";
         // 
         // lblSimConnectStatus
         // 
         lblSimConnectStatus.Caption = "SimConnect Status";
         lblSimConnectStatus.Id = 0;
         lblSimConnectStatus.Name = "lblSimConnectStatus";
         // 
         // lblFsuipcStatus
         // 
         lblFsuipcStatus.Caption = "FSUIPC Status";
         lblFsuipcStatus.Id = 1;
         lblFsuipcStatus.Name = "lblFsuipcStatus";
         // 
         // lblSerialPortStatus
         // 
         lblSerialPortStatus.Caption = "Serial Port Status";
         lblSerialPortStatus.Id = 10;
         lblSerialPortStatus.Name = "lblSerialPortStatus";
         // 
         // lblSimAircraft
         // 
         lblSimAircraft.Caption = "AC Template: ";
         lblSimAircraft.Id = 13;
         lblSimAircraft.Name = "lblSimAircraft";
         // 
         // lblMacroPadState
         // 
         lblMacroPadState.Caption = "State";
         lblMacroPadState.Id = 14;
         lblMacroPadState.Name = "lblMacroPadState";
         // 
         // lblLocalTime
         // 
         lblLocalTime.Caption = "Local Time";
         lblLocalTime.Id = 15;
         lblLocalTime.Name = "lblLocalTime";
         // 
         // barDockControlTop
         // 
         barDockControlTop.CausesValidation = false;
         barDockControlTop.Dock = DockStyle.Top;
         barDockControlTop.Location = new Point(0, 31);
         barDockControlTop.Manager = toolbarFormManager1;
         barDockControlTop.Margin = new Padding(4, 3, 4, 3);
         barDockControlTop.Size = new Size(1133, 24);
         // 
         // barDockControlBottom
         // 
         barDockControlBottom.CausesValidation = false;
         barDockControlBottom.Dock = DockStyle.Bottom;
         barDockControlBottom.Location = new Point(0, 848);
         barDockControlBottom.Manager = toolbarFormManager1;
         barDockControlBottom.Margin = new Padding(4, 3, 4, 3);
         barDockControlBottom.Size = new Size(1133, 26);
         // 
         // barDockControlLeft
         // 
         barDockControlLeft.CausesValidation = false;
         barDockControlLeft.Dock = DockStyle.Left;
         barDockControlLeft.Location = new Point(0, 55);
         barDockControlLeft.Manager = toolbarFormManager1;
         barDockControlLeft.Margin = new Padding(4, 3, 4, 3);
         barDockControlLeft.Size = new Size(0, 793);
         // 
         // barDockControlRight
         // 
         barDockControlRight.CausesValidation = false;
         barDockControlRight.Dock = DockStyle.Right;
         barDockControlRight.Location = new Point(1133, 55);
         barDockControlRight.Manager = toolbarFormManager1;
         barDockControlRight.Margin = new Padding(4, 3, 4, 3);
         barDockControlRight.Size = new Size(0, 793);
         // 
         // skinPaletteDropDownButtonItem1
         // 
         skinPaletteDropDownButtonItem1.ActAsDropDown = true;
         skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
         skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
         skinPaletteDropDownButtonItem1.Id = 5;
         skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
         // 
         // skinDropDownButtonItem1
         // 
         skinDropDownButtonItem1.ActAsDropDown = true;
         skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
         skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
         skinDropDownButtonItem1.Id = 6;
         skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
         // 
         // gridLookUpEdit1View
         // 
         gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
         gridLookUpEdit1View.Name = "gridLookUpEdit1View";
         gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
         gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
         // 
         // bar3
         // 
         bar3.BarName = "Custom 4";
         bar3.DockCol = 0;
         bar3.DockRow = 1;
         bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         bar3.Text = "Custom 4";
         // 
         // trackBarFlaps
         // 
         trackBarFlaps.EditValue = null;
         trackBarFlaps.Location = new Point(752, 411);
         trackBarFlaps.Margin = new Padding(4, 3, 4, 3);
         trackBarFlaps.MenuManager = toolbarFormManager1;
         trackBarFlaps.Name = "trackBarFlaps";
         trackBarFlaps.Properties.LabelAppearance.Options.UseTextOptions = true;
         trackBarFlaps.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         trackBarFlaps.Properties.Orientation = Orientation.Vertical;
         trackBarFlaps.Size = new Size(45, 105);
         trackBarFlaps.TabIndex = 274;
         trackBarFlaps.ValueChanged += trackBarFlaps_ValueChanged;
         // 
         // dirHeadingDisplay
         // 
         dirHeadingDisplay.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         dirHeadingDisplay.Location = new Point(23, 504);
         dirHeadingDisplay.MacroPadStateId = MacroPadDevice.Enumerations.MacroPadState.HEADING;
         dirHeadingDisplay.Name = "dirHeadingDisplay";
         dirHeadingDisplay.Size = new Size(48, 40);
         dirHeadingDisplay.TabIndex = 279;
         dirHeadingDisplay.Value = 0;
         // 
         // dirCourse1Display
         // 
         dirCourse1Display.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         dirCourse1Display.Location = new Point(150, 504);
         dirCourse1Display.MacroPadStateId = MacroPadDevice.Enumerations.MacroPadState.COURSE1;
         dirCourse1Display.Name = "dirCourse1Display";
         dirCourse1Display.Size = new Size(48, 40);
         dirCourse1Display.TabIndex = 280;
         dirCourse1Display.Value = 0;
         // 
         // altitudeDisplay
         // 
         altitudeDisplay.CurrentMacroPadState = MacroPadDevice.Enumerations.MacroPadState.None;
         altitudeDisplay.Location = new Point(24, 569);
         altitudeDisplay.Name = "altitudeDisplay";
         altitudeDisplay.Size = new Size(80, 40);
         altitudeDisplay.TabIndex = 285;
         altitudeDisplay.Value = 0;
         // 
         // MainForm
         // 
         Appearance.Options.UseFont = true;
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1133, 874);
         Controls.Add(altitudeDisplay);
         Controls.Add(dirCourse1Display);
         Controls.Add(dirHeadingDisplay);
         Controls.Add(trackBarFlaps);
         Controls.Add(lblBarometer1);
         Controls.Add(label6);
         Controls.Add(lblEngCondition1);
         Controls.Add(lblMixture1Pct);
         Controls.Add(lblPropeller1Pct);
         Controls.Add(lblThrottle1Pct);
         Controls.Add(lblSpoilersPosition);
         Controls.Add(lblSpoilersHandlePosition);
         Controls.Add(lblSpoilersArmed);
         Controls.Add(lblSpoilersAvailable);
         Controls.Add(lblCustomCamera);
         Controls.Add(btnPreviousSmartcam);
         Controls.Add(btnNextSmartcam);
         Controls.Add(checkSmartcam);
         Controls.Add(lblSCTargetDesc);
         Controls.Add(lblSCTargetType);
         Controls.Add(checkCustomCameraState);
         Controls.Add(checkShowcaseFixedSubState);
         Controls.Add(lblEngineTorquePct);
         Controls.Add(checkShowcaseDroneSubState);
         Controls.Add(checkCamera9);
         Controls.Add(lblEngineNPRpm);
         Controls.Add(checkCamera8);
         Controls.Add(checkExternalQuickViewSubState);
         Controls.Add(checkCamera7);
         Controls.Add(lblEngineNGPct);
         Controls.Add(checkCamera6);
         Controls.Add(checkExternalDefaultSubState);
         Controls.Add(checkCamera5);
         Controls.Add(lblEngineITT);
         Controls.Add(checkCamera4);
         Controls.Add(checkCockpitQuickViewSubState);
         Controls.Add(checkCamera3);
         Controls.Add(lblEngineTorque);
         Controls.Add(checkCamera2);
         Controls.Add(checkCockpitInstrumentSubState);
         Controls.Add(checkCamera1);
         Controls.Add(lblFlapsCurrentPosition);
         Controls.Add(checkCamera10);
         Controls.Add(checkCockpitPilotSubState);
         Controls.Add(lblFlapsNumberOfDetents);
         Controls.Add(lblIndex1);
         Controls.Add(btnPreviousSubView);
         Controls.Add(lblIndex0);
         Controls.Add(lblCurrentFlapsLimit);
         Controls.Add(lblCameraSubstate);
         Controls.Add(btnNextSubView);
         Controls.Add(lblCameraState);
         Controls.Add(lblTrailingFlapsRight);
         Controls.Add(btnPreviousView);
         Controls.Add(lblTrailingFlapsLeft);
         Controls.Add(btnNextView);
         Controls.Add(lblAileronTrimPct);
         Controls.Add(lblRudderTrimPct);
         Controls.Add(lblElevatorTrimPct);
         Controls.Add(btnSetCamera);
         Controls.Add(txtCameraIndex1);
         Controls.Add(txtCameraIndex0);
         Controls.Add(txtCameraSubState);
         Controls.Add(txtCameraState);
         Controls.Add(GroupControl1);
         Controls.Add(lblCurrentCameraType);
         Controls.Add(txtOutput);
         Controls.Add(groupCameras);
         Controls.Add(groupFuel);
         Controls.Add(groupPause);
         Controls.Add(groupFms);
         Controls.Add(groupAutopilot);
         Controls.Add(groupLights);
         Controls.Add(lblTransponder);
         Controls.Add(label4);
         Controls.Add(lblVerticalSpeedValue);
         Controls.Add(label7);
         Controls.Add(label5);
         Controls.Add(lblCourseSel);
         Controls.Add(groupNav2);
         Controls.Add(label2);
         Controls.Add(groupNav1);
         Controls.Add(groupCom2);
         Controls.Add(groupCom1);
         Controls.Add(barDockControlLeft);
         Controls.Add(barDockControlRight);
         Controls.Add(barDockControlBottom);
         Controls.Add(barDockControlTop);
         Controls.Add(toolbarFormControl1);
         Margin = new Padding(4, 3, 4, 3);
         Name = "MainForm";
         Text = "MainForm";
         ToolbarFormControl = toolbarFormControl1;
         ((System.ComponentModel.ISupportInitialize)txtCameraIndex1.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraIndex0.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraSubState.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)txtCameraState.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)GroupControl1).EndInit();
         GroupControl1.ResumeLayout(false);
         GroupControl1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)txtOutput.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)groupCameras).EndInit();
         groupCameras.ResumeLayout(false);
         groupCameras.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupFuel).EndInit();
         groupFuel.ResumeLayout(false);
         groupFuel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupPause).EndInit();
         groupPause.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)checkPauseEsc.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseSim.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseActive.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)checkPauseFull.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)groupFms).EndInit();
         groupFms.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)groupAutopilot).EndInit();
         groupAutopilot.ResumeLayout(false);
         groupAutopilot.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupLights).EndInit();
         groupLights.ResumeLayout(false);
         groupLights.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupNav2).EndInit();
         groupNav2.ResumeLayout(false);
         groupNav2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupNav1).EndInit();
         groupNav1.ResumeLayout(false);
         groupNav1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupCom2).EndInit();
         groupCom2.ResumeLayout(false);
         groupCom2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)groupCom1).EndInit();
         groupCom1.ResumeLayout(false);
         groupCom1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)toolbarFormControl1).EndInit();
         toolbarFormControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).EndInit();
         ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
         ((System.ComponentModel.ISupportInitialize)trackBarFlaps.Properties).EndInit();
         ((System.ComponentModel.ISupportInitialize)trackBarFlaps).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private ToolStripMenuItem testToolStripMenuItem;
      private TextEdit txtTotalFuelPct;
      private LabelControl lblBarometer1;
      private LabelControl label6;
      private LabelControl lblEngCondition1;
      private LabelControl lblMixture1Pct;
      private LabelControl lblPropeller1Pct;
      private LabelControl lblThrottle1Pct;
      private LabelControl lblSpoilersPosition;
      private LabelControl lblSpoilersHandlePosition;
      private LabelControl lblSpoilersArmed;
      private LabelControl lblSpoilersAvailable;
      private LabelControl lblCustomCamera;
      private SimpleButton btnPreviousSmartcam;
      private SimpleButton btnNextSmartcam;
      private CheckButton checkSmartcam;
      private LabelControl lblSCTargetDesc;
      private LabelControl lblSCTargetType;
      private CheckButton checkCustomCameraState;
      private CheckButton checkShowcaseFixedSubState;
      private LabelControl lblEngineTorquePct;
      private CheckButton checkShowcaseDroneSubState;
      private CheckButton checkCamera9;
      private LabelControl lblEngineNPRpm;
      private CheckButton checkCamera8;
      private CheckButton checkExternalQuickViewSubState;
      private CheckButton checkCamera7;
      private LabelControl lblEngineNGPct;
      private CheckButton checkCamera6;
      private CheckButton checkExternalDefaultSubState;
      private CheckButton checkCamera5;
      private LabelControl lblEngineITT;
      private CheckButton checkCamera4;
      private CheckButton checkCockpitQuickViewSubState;
      private CheckButton checkCamera3;
      private LabelControl lblEngineTorque;
      private CheckButton checkCamera2;
      private CheckButton checkCockpitInstrumentSubState;
      private CheckButton checkCamera1;
      private LabelControl lblFlapsCurrentPosition;
      private CheckButton checkCamera10;
      private CheckButton checkCockpitPilotSubState;
      private LabelControl lblFlapsNumberOfDetents;
      private LabelControl lblIndex1;
      private SimpleButton btnPreviousSubView;
      private LabelControl lblIndex0;
      private LabelControl lblCurrentFlapsLimit;
      private LabelControl lblCameraSubstate;
      private SimpleButton btnNextSubView;
      private LabelControl lblCameraState;
      private LabelControl lblTrailingFlapsRight;
      private SimpleButton btnPreviousView;
      private LabelControl lblTrailingFlapsLeft;
      private SimpleButton btnNextView;
      private LabelControl lblAileronTrimPct;
      private LabelControl lblRudderTrimPct;
      private LabelControl lblElevatorTrimPct;
      private SimpleButton btnSetCamera;
      private TextEdit txtCameraIndex1;
      private TextEdit txtCameraIndex0;
      private TextEdit txtCameraSubState;
      private TextEdit txtCameraState;
      private GroupControl GroupControl1;
      private SimpleButton btnSimRateReset;
      private SimpleButton btnSimRateDec;
      private SimpleButton btnSimRateInc;
      private LabelControl lblSimRate;
      private LabelControl lblCurrentCameraType;
      public MemoEdit txtOutput;
      private GroupControl groupCameras;
      private CheckButton checkCameraPilotCoPilot;
      private CheckButton checkCameraPilotLand;
      private CheckButton checkCameraPilotClose;
      private CheckButton checkCameraPilotNormal;
      private LabelControl lblCameraCurrentView;
      private GroupControl groupFuel;
      private LabelControl lblFuelDumpSwitch;
      private SimpleButton btnFuelDump;
      private LabelControl lblTotalFuelPct;
      private SimpleButton btnAddFuel;
      private GroupControl groupPause;
      private SimpleButton btnPauseSim;
      private CheckEdit checkPauseEsc;
      private CheckEdit checkPauseSim;
      private CheckEdit checkPauseActive;
      private CheckEdit checkPauseFull;
      private SimpleButton btnPauseFull;
      private GroupControl groupFms;
      private SimpleButton btnFmsMfdInner;
      private SimpleButton btnFmsMfdOuter;
      private SimpleButton btnFmsEnt;
      private SimpleButton btnFmsClr;
      private SimpleButton btnFmsMenu;
      private SimpleButton btnFmsProc;
      private SimpleButton btnFmsFpl;
      private SimpleButton btnFmsDirect;
      private SimpleButton btnFmsPfdInner;
      private SimpleButton btnFmsPfdOuter;
      private GroupControl groupAutopilot;
      private LabelControl lblApproachStatus;
      private SimpleButton btnCrs2Sel;
      private CheckButton checkApSpd;
      private CheckButton checkApFlc;
      private SimpleButton btnNoseUpDn;
      private CheckButton checkApVnv;
      private CheckButton checkApVsHold;
      private SimpleButton btnAltSel;
      private CheckButton checkApAltHold;
      private CheckButton checkApYd;
      private CheckButton checkApFd;
      private CheckButton checkApMaster;
      private SimpleButton btnCrs1Sel;
      private SimpleButton btnHdgSel;
      private CheckButton checkApBcHold;
      private CheckButton checkApAprHold;
      private CheckButton checkApNavHold;
      private CheckButton checkApHdgHold;
      private GroupControl groupLights;
      private CheckButton checkBeaconLight;
      private CheckButton checkWingLight;
      private CheckButton checkCabinLight;
      private CheckButton checkTaxiLight;
      private CheckButton checkGlareshieldLight;
      private CheckButton checkStrobeLight;
      private CheckButton checkLandingLight;
      private CheckButton checkRecognitionLight;
      private CheckButton checkLogoLight;
      private CheckButton checkPedestralLight;
      private CheckButton checkNavLight;
      private CheckButton checkPanelLight;
      private LabelControl lblTransponder;
      private LabelControl label4;
      private LabelControl lblVerticalSpeedValue;
      private LabelControl label7;
      private LabelControl label5;
      private LabelControl lblCourseSel;
      private GroupControl groupNav2;
      private LabelControl lblNav2Standby;
      private LabelControl lblNav2Active;
      private LabelControl label2;
      private GroupControl groupNav1;
      private LabelControl lblNav1Standby;
      private LabelControl lblNav1Active;
      private GroupControl groupCom2;
      private LabelControl lblCom2Standby;
      private LabelControl lblCom2Active;
      private GroupControl groupCom1;
      private LabelControl lblCom1Standby;
      private LabelControl lblCom1Active;
      private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
      private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarSubItem menuApp;
      private DevExpress.XtraBars.BarSubItem menuMacroPad;
      private DevExpress.XtraBars.BarStaticItem lblSimConnectStatus;
      private DevExpress.XtraBars.BarStaticItem lblFsuipcStatus;
      private DevExpress.XtraBars.BarSubItem menuUtility;
      private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
      private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
      private DevExpress.XtraBars.BarButtonItem menuConnectSimConnect;
      private DevExpress.XtraBars.BarButtonItem menuConnectFsuipc;
      private DevExpress.XtraBars.BarButtonItem menuExit;
      private DevExpress.XtraBars.BarStaticItem lblSerialPortStatus;
      private DevExpress.XtraBars.BarButtonItem menuRefreshSerialPorts;
      private DevExpress.XtraBars.BarButtonItem menuPresetEvents;
      private DevExpress.XtraBars.Bar bar3;
      private TrackBarControl trackBarFlaps;
      private DevExpress.XtraBars.BarStaticItem lblSimAircraft;
      private DevExpress.XtraBars.BarStaticItem lblMacroPadState;
      private DevExpress.XtraBars.BarStaticItem lblLocalTime;
      private MacroPadDevice.Controls.NavRadioDisplay navRadioDisplay1Standby;
      private MacroPadDevice.Controls.NavRadioDisplay navRadioDisplay1Active;
      private MacroPadDevice.Controls.NavRadioDisplay navRadioDisplay2Standby;
      private MacroPadDevice.Controls.NavRadioDisplay navRadioDisplay2Active;
      private GridLookUpEdit gridLookUpEdit1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
      private MacroPadDevice.Controls.ComRadioDisplay comRadioDisplay1Standby;
      private MacroPadDevice.Controls.ComRadioDisplay comRadioDisplay2Active;
      private MacroPadDevice.Controls.ComRadioDisplay comRadioDisplay2Standby;
      private MacroPadDevice.Controls.ComRadioDisplay comRadioDisplay1Active;
      private MacroPadDevice.Controls.DirectionDisplay dirCourse1Display;
      private MacroPadDevice.Controls.DirectionDisplay dirHeadingDisplay;
      private MacroPadDevice.Controls.AltitudeDisplay altitudeDisplay;
   }
}
