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
         txtOutput = new TextEdit();
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
         checkPauseEsc = new CheckBox();
         checkPauseSim = new CheckBox();
         checkPauseActive = new CheckBox();
         checkPauseFull = new CheckBox();
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
         lblAltitudeValue = new LabelControl();
         label5 = new LabelControl();
         lblCourseValue = new LabelControl();
         label3 = new LabelControl();
         lblHeadingValue = new LabelControl();
         groupNav2 = new GroupControl();
         lblNav2StandbyValue = new LabelControl();
         lblNav2ActiveValue = new LabelControl();
         lblNav2Standby = new LabelControl();
         lblNav2Active = new LabelControl();
         label2 = new LabelControl();
         groupNav1 = new GroupControl();
         lblNav1StandbyValue = new LabelControl();
         lblNav1ActiveValue = new LabelControl();
         lblNav1Standby = new LabelControl();
         lblNav1Active = new LabelControl();
         groupCom2 = new GroupControl();
         lblCom2Standby = new LabelControl();
         lblCom2StandbyValue = new LabelControl();
         lblCom2ActiveValue = new LabelControl();
         lblCom2Active = new LabelControl();
         groupCom1 = new GroupControl();
         lblCom1StandbyValue = new LabelControl();
         lblCom1ActiveValue = new LabelControl();
         lblCom1Standby = new LabelControl();
         lblCom1Active = new LabelControl();
         toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
         toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
         barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         ((System.ComponentModel.ISupportInitialize)trackFlaps).BeginInit();
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
         ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).BeginInit();
         SuspendLayout();
         // 
         // lblBarometer1
         // 
         lblBarometer1.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblBarometer1.Appearance.Options.UseFont = true;
         lblBarometer1.Location = new Point(163, 503);
         lblBarometer1.Margin = new Padding(3, 2, 3, 2);
         lblBarometer1.Name = "lblBarometer1";
         lblBarometer1.Size = new Size(70, 40);
         lblBarometer1.TabIndex = 269;
         lblBarometer1.Text = "00.00";
         // 
         // label6
         // 
         label6.Location = new Point(163, 486);
         label6.Margin = new Padding(3, 2, 3, 2);
         label6.Name = "label6";
         label6.Size = new Size(52, 17);
         label6.TabIndex = 268;
         label6.Text = "Altimeter";
         // 
         // lblCurrentAircraft
         // 
         lblCurrentAircraft.Location = new Point(499, 619);
         lblCurrentAircraft.Margin = new Padding(3, 2, 3, 2);
         lblCurrentAircraft.Name = "lblCurrentAircraft";
         lblCurrentAircraft.Size = new Size(42, 17);
         lblCurrentAircraft.TabIndex = 267;
         lblCurrentAircraft.Text = "Aircraft";
         // 
         // lblEngCondition1
         // 
         lblEngCondition1.Location = new Point(523, 353);
         lblEngCondition1.Margin = new Padding(3, 2, 3, 2);
         lblEngCondition1.Name = "lblEngCondition1";
         lblEngCondition1.Size = new Size(74, 17);
         lblEngCondition1.TabIndex = 266;
         lblEngCondition1.Text = "Condition 1: ";
         // 
         // lblMixture1Pct
         // 
         lblMixture1Pct.Location = new Point(523, 338);
         lblMixture1Pct.Margin = new Padding(3, 2, 3, 2);
         lblMixture1Pct.Name = "lblMixture1Pct";
         lblMixture1Pct.Size = new Size(80, 17);
         lblMixture1Pct.TabIndex = 265;
         lblMixture1Pct.Text = "Mixture 1: 0%";
         // 
         // lblPropeller1Pct
         // 
         lblPropeller1Pct.Location = new Point(523, 322);
         lblPropeller1Pct.Margin = new Padding(3, 2, 3, 2);
         lblPropeller1Pct.Name = "lblPropeller1Pct";
         lblPropeller1Pct.Size = new Size(89, 17);
         lblPropeller1Pct.TabIndex = 264;
         lblPropeller1Pct.Text = "Propeller 1: 0%";
         // 
         // lblThrottle1Pct
         // 
         lblThrottle1Pct.Location = new Point(523, 307);
         lblThrottle1Pct.Margin = new Padding(3, 2, 3, 2);
         lblThrottle1Pct.Name = "lblThrottle1Pct";
         lblThrottle1Pct.Size = new Size(81, 17);
         lblThrottle1Pct.TabIndex = 263;
         lblThrottle1Pct.Text = "Throttle 1: 0%";
         // 
         // lblSpoilersPosition
         // 
         lblSpoilersPosition.Location = new Point(902, 307);
         lblSpoilersPosition.Margin = new Padding(3, 2, 3, 2);
         lblSpoilersPosition.Name = "lblSpoilersPosition";
         lblSpoilersPosition.Size = new Size(148, 17);
         lblSpoilersPosition.TabIndex = 262;
         lblSpoilersPosition.Text = "Spoilers Position: 0 L, 0 R";
         // 
         // lblSpoilersHandlePosition
         // 
         lblSpoilersHandlePosition.Location = new Point(902, 292);
         lblSpoilersHandlePosition.Margin = new Padding(3, 2, 3, 2);
         lblSpoilersHandlePosition.Name = "lblSpoilersHandlePosition";
         lblSpoilersHandlePosition.Size = new Size(106, 17);
         lblSpoilersHandlePosition.TabIndex = 261;
         lblSpoilersHandlePosition.Text = "Spoilers Handle: 0";
         // 
         // lblSpoilersArmed
         // 
         lblSpoilersArmed.Location = new Point(902, 276);
         lblSpoilersArmed.Margin = new Padding(3, 2, 3, 2);
         lblSpoilersArmed.Name = "lblSpoilersArmed";
         lblSpoilersArmed.Size = new Size(116, 17);
         lblSpoilersArmed.TabIndex = 260;
         lblSpoilersArmed.Text = "Spoilers Not Armed";
         // 
         // lblSpoilersAvailable
         // 
         lblSpoilersAvailable.Location = new Point(902, 261);
         lblSpoilersAvailable.Margin = new Padding(3, 2, 3, 2);
         lblSpoilersAvailable.Name = "lblSpoilersAvailable";
         lblSpoilersAvailable.Size = new Size(86, 17);
         lblSpoilersAvailable.TabIndex = 259;
         lblSpoilersAvailable.Text = "Spoilers: None";
         // 
         // lblCustomCamera
         // 
         lblCustomCamera.Location = new Point(681, 353);
         lblCustomCamera.Margin = new Padding(3, 2, 3, 2);
         lblCustomCamera.Name = "lblCustomCamera";
         lblCustomCamera.Size = new Size(74, 17);
         lblCustomCamera.TabIndex = 258;
         lblCustomCamera.Text = "Cust Camera";
         // 
         // btnPreviousSmartcam
         // 
         btnPreviousSmartcam.Location = new Point(812, 428);
         btnPreviousSmartcam.Margin = new Padding(3, 2, 3, 2);
         btnPreviousSmartcam.Name = "btnPreviousSmartcam";
         btnPreviousSmartcam.Size = new Size(41, 25);
         btnPreviousSmartcam.TabIndex = 257;
         btnPreviousSmartcam.Text = "SC-";
         // 
         // btnNextSmartcam
         // 
         btnNextSmartcam.Location = new Point(812, 399);
         btnNextSmartcam.Margin = new Padding(3, 2, 3, 2);
         btnNextSmartcam.Name = "btnNextSmartcam";
         btnNextSmartcam.Size = new Size(41, 25);
         btnNextSmartcam.TabIndex = 256;
         btnNextSmartcam.Text = "SC+";
         // 
         // checkSmartcam
         // 
         checkSmartcam.Location = new Point(812, 368);
         checkSmartcam.Margin = new Padding(3, 2, 3, 2);
         checkSmartcam.Name = "checkSmartcam";
         checkSmartcam.Size = new Size(58, 25);
         checkSmartcam.TabIndex = 255;
         checkSmartcam.Text = "SC";
         // 
         // lblSCTargetDesc
         // 
         lblSCTargetDesc.Location = new Point(414, 368);
         lblSCTargetDesc.Margin = new Padding(3, 2, 3, 2);
         lblSCTargetDesc.Name = "lblSCTargetDesc";
         lblSCTargetDesc.Size = new Size(89, 17);
         lblSCTargetDesc.TabIndex = 254;
         lblSCTargetDesc.Text = "SC Target Desc";
         // 
         // lblSCTargetType
         // 
         lblSCTargetType.Location = new Point(414, 350);
         lblSCTargetType.Margin = new Padding(3, 2, 3, 2);
         lblSCTargetType.Name = "lblSCTargetType";
         lblSCTargetType.Size = new Size(89, 17);
         lblSCTargetType.TabIndex = 253;
         lblSCTargetType.Text = "SC Target Type";
         // 
         // trackFlaps
         // 
         trackFlaps.Location = new Point(762, 392);
         trackFlaps.Margin = new Padding(3, 2, 3, 2);
         trackFlaps.Name = "trackFlaps";
         trackFlaps.Orientation = Orientation.Vertical;
         trackFlaps.Size = new Size(45, 186);
         trackFlaps.TabIndex = 252;
         // 
         // checkCustomCameraState
         // 
         checkCustomCameraState.Location = new Point(993, 576);
         checkCustomCameraState.Margin = new Padding(3, 2, 3, 2);
         checkCustomCameraState.Name = "checkCustomCameraState";
         checkCustomCameraState.Size = new Size(58, 25);
         checkCustomCameraState.TabIndex = 247;
         checkCustomCameraState.Text = "Custom";
         // 
         // checkShowcaseFixedSubState
         // 
         checkShowcaseFixedSubState.Location = new Point(993, 547);
         checkShowcaseFixedSubState.Margin = new Padding(3, 2, 3, 2);
         checkShowcaseFixedSubState.Name = "checkShowcaseFixedSubState";
         checkShowcaseFixedSubState.Size = new Size(58, 25);
         checkShowcaseFixedSubState.TabIndex = 241;
         checkShowcaseFixedSubState.Text = "X-Fixed";
         // 
         // lblEngineTorquePct
         // 
         lblEngineTorquePct.Location = new Point(414, 318);
         lblEngineTorquePct.Margin = new Padding(3, 2, 3, 2);
         lblEngineTorquePct.Name = "lblEngineTorquePct";
         lblEngineTorquePct.Size = new Size(40, 17);
         lblEngineTorquePct.TabIndex = 246;
         lblEngineTorquePct.Text = "TRQ %";
         // 
         // checkShowcaseDroneSubState
         // 
         checkShowcaseDroneSubState.Location = new Point(993, 518);
         checkShowcaseDroneSubState.Margin = new Padding(3, 2, 3, 2);
         checkShowcaseDroneSubState.Name = "checkShowcaseDroneSubState";
         checkShowcaseDroneSubState.Size = new Size(58, 25);
         checkShowcaseDroneSubState.TabIndex = 239;
         checkShowcaseDroneSubState.Text = "Drone";
         // 
         // checkCamera9
         // 
         checkCamera9.Location = new Point(950, 456);
         checkCamera9.Margin = new Padding(3, 2, 3, 2);
         checkCamera9.Name = "checkCamera9";
         checkCamera9.Size = new Size(31, 25);
         checkCamera9.TabIndex = 215;
         checkCamera9.Tag = "9";
         checkCamera9.Text = "9";
         // 
         // lblEngineNPRpm
         // 
         lblEngineNPRpm.Location = new Point(297, 363);
         lblEngineNPRpm.Margin = new Padding(3, 2, 3, 2);
         lblEngineNPRpm.Name = "lblEngineNPRpm";
         lblEngineNPRpm.Size = new Size(48, 17);
         lblEngineNPRpm.TabIndex = 245;
         lblEngineNPRpm.Text = "NP RPM";
         // 
         // checkCamera8
         // 
         checkCamera8.Location = new Point(914, 456);
         checkCamera8.Margin = new Padding(3, 2, 3, 2);
         checkCamera8.Name = "checkCamera8";
         checkCamera8.Size = new Size(31, 25);
         checkCamera8.TabIndex = 214;
         checkCamera8.Tag = "8";
         checkCamera8.Text = "8";
         // 
         // checkExternalQuickViewSubState
         // 
         checkExternalQuickViewSubState.Location = new Point(993, 487);
         checkExternalQuickViewSubState.Margin = new Padding(3, 2, 3, 2);
         checkExternalQuickViewSubState.Name = "checkExternalQuickViewSubState";
         checkExternalQuickViewSubState.Size = new Size(58, 25);
         checkExternalQuickViewSubState.TabIndex = 236;
         checkExternalQuickViewSubState.Text = "X-QV";
         // 
         // checkCamera7
         // 
         checkCamera7.Location = new Point(879, 456);
         checkCamera7.Margin = new Padding(3, 2, 3, 2);
         checkCamera7.Name = "checkCamera7";
         checkCamera7.Size = new Size(31, 25);
         checkCamera7.TabIndex = 213;
         checkCamera7.Tag = "7";
         checkCamera7.Text = "7";
         // 
         // lblEngineNGPct
         // 
         lblEngineNGPct.Location = new Point(297, 348);
         lblEngineNGPct.Margin = new Padding(3, 2, 3, 2);
         lblEngineNGPct.Name = "lblEngineNGPct";
         lblEngineNGPct.Size = new Size(34, 17);
         lblEngineNGPct.TabIndex = 244;
         lblEngineNGPct.Text = "NG %";
         // 
         // checkCamera6
         // 
         checkCamera6.Location = new Point(950, 487);
         checkCamera6.Margin = new Padding(3, 2, 3, 2);
         checkCamera6.Name = "checkCamera6";
         checkCamera6.Size = new Size(31, 25);
         checkCamera6.TabIndex = 212;
         checkCamera6.Tag = "6";
         checkCamera6.Text = "6";
         // 
         // checkExternalDefaultSubState
         // 
         checkExternalDefaultSubState.Location = new Point(993, 458);
         checkExternalDefaultSubState.Margin = new Padding(3, 2, 3, 2);
         checkExternalDefaultSubState.Name = "checkExternalDefaultSubState";
         checkExternalDefaultSubState.Size = new Size(58, 25);
         checkExternalDefaultSubState.TabIndex = 235;
         checkExternalDefaultSubState.Text = "EXT";
         // 
         // checkCamera5
         // 
         checkCamera5.Location = new Point(914, 487);
         checkCamera5.Margin = new Padding(3, 2, 3, 2);
         checkCamera5.Name = "checkCamera5";
         checkCamera5.Size = new Size(31, 25);
         checkCamera5.TabIndex = 211;
         checkCamera5.Tag = "5";
         checkCamera5.Text = "5";
         // 
         // lblEngineITT
         // 
         lblEngineITT.Location = new Point(297, 333);
         lblEngineITT.Margin = new Padding(3, 2, 3, 2);
         lblEngineITT.Name = "lblEngineITT";
         lblEngineITT.Size = new Size(17, 17);
         lblEngineITT.TabIndex = 243;
         lblEngineITT.Text = "ITT";
         // 
         // checkCamera4
         // 
         checkCamera4.Location = new Point(879, 487);
         checkCamera4.Margin = new Padding(3, 2, 3, 2);
         checkCamera4.Name = "checkCamera4";
         checkCamera4.Size = new Size(31, 25);
         checkCamera4.TabIndex = 210;
         checkCamera4.Tag = "4";
         checkCamera4.Text = "4";
         // 
         // checkCockpitQuickViewSubState
         // 
         checkCockpitQuickViewSubState.Location = new Point(993, 428);
         checkCockpitQuickViewSubState.Margin = new Padding(3, 2, 3, 2);
         checkCockpitQuickViewSubState.Name = "checkCockpitQuickViewSubState";
         checkCockpitQuickViewSubState.Size = new Size(58, 25);
         checkCockpitQuickViewSubState.TabIndex = 233;
         checkCockpitQuickViewSubState.Text = "C-QV";
         // 
         // checkCamera3
         // 
         checkCamera3.Location = new Point(950, 518);
         checkCamera3.Margin = new Padding(3, 2, 3, 2);
         checkCamera3.Name = "checkCamera3";
         checkCamera3.Size = new Size(31, 25);
         checkCamera3.TabIndex = 209;
         checkCamera3.Tag = "3";
         checkCamera3.Text = "3";
         // 
         // lblEngineTorque
         // 
         lblEngineTorque.Location = new Point(297, 318);
         lblEngineTorque.Margin = new Padding(3, 2, 3, 2);
         lblEngineTorque.Name = "lblEngineTorque";
         lblEngineTorque.Size = new Size(42, 17);
         lblEngineTorque.TabIndex = 242;
         lblEngineTorque.Text = "Torque";
         // 
         // checkCamera2
         // 
         checkCamera2.Location = new Point(914, 518);
         checkCamera2.Margin = new Padding(3, 2, 3, 2);
         checkCamera2.Name = "checkCamera2";
         checkCamera2.Size = new Size(31, 25);
         checkCamera2.TabIndex = 207;
         checkCamera2.Tag = "2";
         checkCamera2.Text = "2";
         // 
         // checkCockpitInstrumentSubState
         // 
         checkCockpitInstrumentSubState.Location = new Point(993, 399);
         checkCockpitInstrumentSubState.Margin = new Padding(3, 2, 3, 2);
         checkCockpitInstrumentSubState.Name = "checkCockpitInstrumentSubState";
         checkCockpitInstrumentSubState.Size = new Size(58, 25);
         checkCockpitInstrumentSubState.TabIndex = 231;
         checkCockpitInstrumentSubState.Text = "Instr";
         // 
         // checkCamera1
         // 
         checkCamera1.Location = new Point(879, 518);
         checkCamera1.Margin = new Padding(3, 2, 3, 2);
         checkCamera1.Name = "checkCamera1";
         checkCamera1.Size = new Size(31, 25);
         checkCamera1.TabIndex = 206;
         checkCamera1.Tag = "1";
         checkCamera1.Text = "1";
         // 
         // lblFlapsCurrentPosition
         // 
         lblFlapsCurrentPosition.Location = new Point(681, 325);
         lblFlapsCurrentPosition.Margin = new Padding(3, 2, 3, 2);
         lblFlapsCurrentPosition.Name = "lblFlapsCurrentPosition";
         lblFlapsCurrentPosition.Size = new Size(93, 17);
         lblFlapsCurrentPosition.TabIndex = 240;
         lblFlapsCurrentPosition.Text = "Current Position";
         // 
         // checkCamera10
         // 
         checkCamera10.Location = new Point(879, 547);
         checkCamera10.Margin = new Padding(3, 2, 3, 2);
         checkCamera10.Name = "checkCamera10";
         checkCamera10.Size = new Size(65, 25);
         checkCamera10.TabIndex = 205;
         checkCamera10.Tag = "0";
         checkCamera10.Text = "0";
         // 
         // checkCockpitPilotSubState
         // 
         checkCockpitPilotSubState.Location = new Point(993, 368);
         checkCockpitPilotSubState.Margin = new Padding(3, 2, 3, 2);
         checkCockpitPilotSubState.Name = "checkCockpitPilotSubState";
         checkCockpitPilotSubState.Size = new Size(58, 25);
         checkCockpitPilotSubState.TabIndex = 229;
         checkCockpitPilotSubState.Text = "Pilot";
         // 
         // lblFlapsNumberOfDetents
         // 
         lblFlapsNumberOfDetents.Location = new Point(681, 307);
         lblFlapsNumberOfDetents.Margin = new Padding(3, 2, 3, 2);
         lblFlapsNumberOfDetents.Name = "lblFlapsNumberOfDetents";
         lblFlapsNumberOfDetents.Size = new Size(112, 17);
         lblFlapsNumberOfDetents.TabIndex = 238;
         lblFlapsNumberOfDetents.Text = "Number of Detents";
         // 
         // lblIndex1
         // 
         lblIndex1.Location = new Point(198, 622);
         lblIndex1.Margin = new Padding(3, 2, 3, 2);
         lblIndex1.Name = "lblIndex1";
         lblIndex1.Size = new Size(51, 17);
         lblIndex1.TabIndex = 218;
         lblIndex1.Text = "Index1: x";
         // 
         // btnPreviousSubView
         // 
         btnPreviousSubView.Location = new Point(931, 399);
         btnPreviousSubView.Margin = new Padding(3, 2, 3, 2);
         btnPreviousSubView.Name = "btnPreviousSubView";
         btnPreviousSubView.Size = new Size(41, 25);
         btnPreviousSubView.TabIndex = 251;
         btnPreviousSubView.Text = "PSV";
         // 
         // lblIndex0
         // 
         lblIndex0.Location = new Point(198, 607);
         lblIndex0.Margin = new Padding(3, 2, 3, 2);
         lblIndex0.Name = "lblIndex0";
         lblIndex0.Size = new Size(51, 17);
         lblIndex0.TabIndex = 219;
         lblIndex0.Text = "Index0: x";
         // 
         // lblCurrentFlapsLimit
         // 
         lblCurrentFlapsLimit.Location = new Point(681, 292);
         lblCurrentFlapsLimit.Margin = new Padding(3, 2, 3, 2);
         lblCurrentFlapsLimit.Name = "lblCurrentFlapsLimit";
         lblCurrentFlapsLimit.Size = new Size(108, 17);
         lblCurrentFlapsLimit.TabIndex = 237;
         lblCurrentFlapsLimit.Text = "Current Flaps Limit";
         // 
         // lblCameraSubstate
         // 
         lblCameraSubstate.Location = new Point(198, 592);
         lblCameraSubstate.Margin = new Padding(3, 2, 3, 2);
         lblCameraSubstate.Name = "lblCameraSubstate";
         lblCameraSubstate.Size = new Size(63, 17);
         lblCameraSubstate.TabIndex = 217;
         lblCameraSubstate.Text = "Substate: x";
         // 
         // btnNextSubView
         // 
         btnNextSubView.Location = new Point(931, 368);
         btnNextSubView.Margin = new Padding(3, 2, 3, 2);
         btnNextSubView.Name = "btnNextSubView";
         btnNextSubView.Size = new Size(41, 25);
         btnNextSubView.TabIndex = 250;
         btnNextSubView.Text = "NSV";
         // 
         // lblCameraState
         // 
         lblCameraState.Location = new Point(198, 576);
         lblCameraState.Margin = new Padding(3, 2, 3, 2);
         lblCameraState.Name = "lblCameraState";
         lblCameraState.Size = new Size(42, 17);
         lblCameraState.TabIndex = 216;
         lblCameraState.Text = "State: x";
         // 
         // lblTrailingFlapsRight
         // 
         lblTrailingFlapsRight.Location = new Point(681, 276);
         lblTrailingFlapsRight.Margin = new Padding(3, 2, 3, 2);
         lblTrailingFlapsRight.Name = "lblTrailingFlapsRight";
         lblTrailingFlapsRight.Size = new Size(111, 17);
         lblTrailingFlapsRight.TabIndex = 234;
         lblTrailingFlapsRight.Text = "Trailing Flaps Right";
         // 
         // btnPreviousView
         // 
         btnPreviousView.Location = new Point(879, 399);
         btnPreviousView.Margin = new Padding(3, 2, 3, 2);
         btnPreviousView.Name = "btnPreviousView";
         btnPreviousView.Size = new Size(41, 25);
         btnPreviousView.TabIndex = 249;
         btnPreviousView.Text = "PV";
         // 
         // lblTrailingFlapsLeft
         // 
         lblTrailingFlapsLeft.Location = new Point(681, 261);
         lblTrailingFlapsLeft.Margin = new Padding(3, 2, 3, 2);
         lblTrailingFlapsLeft.Name = "lblTrailingFlapsLeft";
         lblTrailingFlapsLeft.Size = new Size(102, 17);
         lblTrailingFlapsLeft.TabIndex = 232;
         lblTrailingFlapsLeft.Text = "Trailing Flaps Left";
         // 
         // btnNextView
         // 
         btnNextView.Location = new Point(879, 368);
         btnNextView.Margin = new Padding(3, 2, 3, 2);
         btnNextView.Name = "btnNextView";
         btnNextView.Size = new Size(41, 25);
         btnNextView.TabIndex = 248;
         btnNextView.Text = "NV";
         // 
         // lblAileronTrimPct
         // 
         lblAileronTrimPct.Location = new Point(523, 282);
         lblAileronTrimPct.Margin = new Padding(3, 2, 3, 2);
         lblAileronTrimPct.Name = "lblAileronTrimPct";
         lblAileronTrimPct.Size = new Size(96, 17);
         lblAileronTrimPct.TabIndex = 230;
         lblAileronTrimPct.Text = "Aileron Trim: 0%";
         // 
         // lblRudderTrimPct
         // 
         lblRudderTrimPct.Location = new Point(523, 267);
         lblRudderTrimPct.Margin = new Padding(3, 2, 3, 2);
         lblRudderTrimPct.Name = "lblRudderTrimPct";
         lblRudderTrimPct.Size = new Size(98, 17);
         lblRudderTrimPct.TabIndex = 228;
         lblRudderTrimPct.Text = "Rudder Trim: 0%";
         // 
         // lblElevatorTrimPct
         // 
         lblElevatorTrimPct.Location = new Point(523, 252);
         lblElevatorTrimPct.Margin = new Padding(3, 2, 3, 2);
         lblElevatorTrimPct.Name = "lblElevatorTrimPct";
         lblElevatorTrimPct.Size = new Size(102, 17);
         lblElevatorTrimPct.TabIndex = 186;
         lblElevatorTrimPct.Text = "Elevator Trim: 0%";
         // 
         // btnSetCamera
         // 
         btnSetCamera.Location = new Point(342, 288);
         btnSetCamera.Margin = new Padding(3, 2, 3, 2);
         btnSetCamera.Name = "btnSetCamera";
         btnSetCamera.Size = new Size(137, 21);
         btnSetCamera.TabIndex = 226;
         btnSetCamera.Text = "Set Camera";
         // 
         // txtCameraIndex1
         // 
         txtCameraIndex1.Location = new Point(451, 260);
         txtCameraIndex1.Margin = new Padding(3, 2, 3, 2);
         txtCameraIndex1.Name = "txtCameraIndex1";
         txtCameraIndex1.Size = new Size(31, 24);
         txtCameraIndex1.TabIndex = 225;
         // 
         // txtCameraIndex0
         // 
         txtCameraIndex0.Location = new Point(414, 260);
         txtCameraIndex0.Margin = new Padding(3, 2, 3, 2);
         txtCameraIndex0.Name = "txtCameraIndex0";
         txtCameraIndex0.Size = new Size(31, 24);
         txtCameraIndex0.TabIndex = 224;
         // 
         // txtCameraSubState
         // 
         txtCameraSubState.Location = new Point(376, 260);
         txtCameraSubState.Margin = new Padding(3, 2, 3, 2);
         txtCameraSubState.Name = "txtCameraSubState";
         txtCameraSubState.Size = new Size(31, 24);
         txtCameraSubState.TabIndex = 223;
         // 
         // txtCameraState
         // 
         txtCameraState.Location = new Point(342, 260);
         txtCameraState.Margin = new Padding(3, 2, 3, 2);
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
         GroupControl1.Location = new Point(681, 163);
         GroupControl1.Margin = new Padding(3, 2, 3, 2);
         GroupControl1.Name = "GroupControl1";
         GroupControl1.Padding = new Padding(3, 2, 3, 2);
         GroupControl1.Size = new Size(175, 86);
         GroupControl1.TabIndex = 221;
         GroupControl1.Text = "Time";
         // 
         // btnSimRateReset
         // 
         btnSimRateReset.AutoSize = true;
         btnSimRateReset.Location = new Point(75, 38);
         btnSimRateReset.Margin = new Padding(3, 2, 3, 2);
         btnSimRateReset.Name = "btnSimRateReset";
         btnSimRateReset.Size = new Size(39, 22);
         btnSimRateReset.TabIndex = 69;
         btnSimRateReset.Text = "Reset";
         // 
         // btnSimRateDec
         // 
         btnSimRateDec.Location = new Point(6, 36);
         btnSimRateDec.Margin = new Padding(3, 2, 3, 2);
         btnSimRateDec.Name = "btnSimRateDec";
         btnSimRateDec.Size = new Size(26, 25);
         btnSimRateDec.TabIndex = 68;
         btnSimRateDec.Text = "-";
         // 
         // btnSimRateInc
         // 
         btnSimRateInc.Location = new Point(38, 36);
         btnSimRateInc.Margin = new Padding(3, 2, 3, 2);
         btnSimRateInc.Name = "btnSimRateInc";
         btnSimRateInc.Size = new Size(26, 25);
         btnSimRateInc.TabIndex = 67;
         btnSimRateInc.Text = "+";
         // 
         // lblSimRate
         // 
         lblSimRate.Location = new Point(9, 21);
         lblSimRate.Margin = new Padding(3, 2, 3, 2);
         lblSimRate.Name = "lblSimRate";
         lblSimRate.Size = new Size(71, 17);
         lblSimRate.TabIndex = 0;
         lblSimRate.Text = "Sim Rate: 1x";
         // 
         // lblCurrentCameraType
         // 
         lblCurrentCameraType.Location = new Point(719, 594);
         lblCurrentCameraType.Margin = new Padding(3, 2, 3, 2);
         lblCurrentCameraType.Name = "lblCurrentCameraType";
         lblCurrentCameraType.Size = new Size(124, 17);
         lblCurrentCameraType.TabIndex = 227;
         lblCurrentCameraType.Text = "Current Camera Type";
         // 
         // txtOutput
         // 
         txtOutput.Location = new Point(732, 243);
         txtOutput.Margin = new Padding(3, 2, 3, 2);
         txtOutput.Name = "txtOutput";
         txtOutput.Properties.ReadOnly = true;
         txtOutput.Size = new Size(319, 24);
         txtOutput.TabIndex = 220;
         // 
         // groupCameras
         // 
         groupCameras.Controls.Add(checkCameraPilotCoPilot);
         groupCameras.Controls.Add(checkCameraPilotLand);
         groupCameras.Controls.Add(checkCameraPilotClose);
         groupCameras.Controls.Add(checkCameraPilotNormal);
         groupCameras.Controls.Add(lblCameraCurrentView);
         groupCameras.Location = new Point(287, 475);
         groupCameras.Margin = new Padding(3, 2, 3, 2);
         groupCameras.Name = "groupCameras";
         groupCameras.Padding = new Padding(3, 2, 3, 2);
         groupCameras.Size = new Size(458, 116);
         groupCameras.TabIndex = 208;
         groupCameras.Text = "Cameras";
         // 
         // checkCameraPilotCoPilot
         // 
         checkCameraPilotCoPilot.Location = new Point(200, 52);
         checkCameraPilotCoPilot.Margin = new Padding(3, 2, 3, 2);
         checkCameraPilotCoPilot.Name = "checkCameraPilotCoPilot";
         checkCameraPilotCoPilot.Size = new Size(58, 25);
         checkCameraPilotCoPilot.TabIndex = 57;
         checkCameraPilotCoPilot.Text = "CoPilot";
         // 
         // checkCameraPilotLand
         // 
         checkCameraPilotLand.Location = new Point(134, 52);
         checkCameraPilotLand.Margin = new Padding(3, 2, 3, 2);
         checkCameraPilotLand.Name = "checkCameraPilotLand";
         checkCameraPilotLand.Size = new Size(58, 25);
         checkCameraPilotLand.TabIndex = 56;
         checkCameraPilotLand.Text = "Land";
         // 
         // checkCameraPilotClose
         // 
         checkCameraPilotClose.Location = new Point(6, 52);
         checkCameraPilotClose.Margin = new Padding(3, 2, 3, 2);
         checkCameraPilotClose.Name = "checkCameraPilotClose";
         checkCameraPilotClose.Size = new Size(58, 25);
         checkCameraPilotClose.TabIndex = 55;
         checkCameraPilotClose.Text = "Close";
         // 
         // checkCameraPilotNormal
         // 
         checkCameraPilotNormal.Location = new Point(72, 52);
         checkCameraPilotNormal.Margin = new Padding(3, 2, 3, 2);
         checkCameraPilotNormal.Name = "checkCameraPilotNormal";
         checkCameraPilotNormal.Size = new Size(58, 25);
         checkCameraPilotNormal.TabIndex = 54;
         checkCameraPilotNormal.Text = "Pilot";
         // 
         // lblCameraCurrentView
         // 
         lblCameraCurrentView.Location = new Point(292, 57);
         lblCameraCurrentView.Margin = new Padding(3, 2, 3, 2);
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
         groupFuel.Location = new Point(860, 163);
         groupFuel.Margin = new Padding(3, 2, 3, 2);
         groupFuel.Name = "groupFuel";
         groupFuel.Padding = new Padding(3, 2, 3, 2);
         groupFuel.Size = new Size(189, 74);
         groupFuel.TabIndex = 204;
         groupFuel.Text = "Fuel";
         // 
         // lblFuelDumpSwitch
         // 
         lblFuelDumpSwitch.Location = new Point(130, 50);
         lblFuelDumpSwitch.Margin = new Padding(3, 2, 3, 2);
         lblFuelDumpSwitch.Name = "lblFuelDumpSwitch";
         lblFuelDumpSwitch.Size = new Size(16, 17);
         lblFuelDumpSwitch.TabIndex = 67;
         lblFuelDumpSwitch.Text = "off";
         // 
         // btnFuelDump
         // 
         btnFuelDump.Location = new Point(65, 44);
         btnFuelDump.Margin = new Padding(3, 2, 3, 2);
         btnFuelDump.Name = "btnFuelDump";
         btnFuelDump.Size = new Size(54, 25);
         btnFuelDump.TabIndex = 66;
         btnFuelDump.Text = "DUMP";
         // 
         // lblTotalFuelPct
         // 
         lblTotalFuelPct.Location = new Point(9, 21);
         lblTotalFuelPct.Margin = new Padding(3, 2, 3, 2);
         lblTotalFuelPct.Name = "lblTotalFuelPct";
         lblTotalFuelPct.Size = new Size(105, 17);
         lblTotalFuelPct.TabIndex = 65;
         lblTotalFuelPct.Text = "Total Fuel: 100.0%";
         // 
         // btnAddFuel
         // 
         btnAddFuel.Location = new Point(6, 44);
         btnAddFuel.Margin = new Padding(3, 2, 3, 2);
         btnAddFuel.Name = "btnAddFuel";
         btnAddFuel.Size = new Size(54, 25);
         btnAddFuel.TabIndex = 64;
         btnAddFuel.Text = "ADD";
         // 
         // groupPause
         // 
         groupPause.Controls.Add(btnPauseSim);
         groupPause.Controls.Add(checkPauseEsc);
         groupPause.Controls.Add(checkPauseSim);
         groupPause.Controls.Add(checkPauseActive);
         groupPause.Controls.Add(checkPauseFull);
         groupPause.Controls.Add(btnPauseFull);
         groupPause.Location = new Point(812, 36);
         groupPause.Margin = new Padding(3, 2, 3, 2);
         groupPause.Name = "groupPause";
         groupPause.Padding = new Padding(3, 2, 3, 2);
         groupPause.Size = new Size(237, 120);
         groupPause.TabIndex = 203;
         groupPause.Text = "Pause";
         // 
         // btnPauseSim
         // 
         btnPauseSim.Location = new Point(6, 71);
         btnPauseSim.Margin = new Padding(3, 2, 3, 2);
         btnPauseSim.Name = "btnPauseSim";
         btnPauseSim.Size = new Size(95, 44);
         btnPauseSim.TabIndex = 5;
         btnPauseSim.Text = "Sim Pause";
         // 
         // checkPauseEsc
         // 
         checkPauseEsc.AutoSize = true;
         checkPauseEsc.Location = new Point(116, 96);
         checkPauseEsc.Margin = new Padding(3, 2, 3, 2);
         checkPauseEsc.Name = "checkPauseEsc";
         checkPauseEsc.Size = new Size(84, 21);
         checkPauseEsc.TabIndex = 4;
         checkPauseEsc.Text = "Esc Pause";
         // 
         // checkPauseSim
         // 
         checkPauseSim.AutoSize = true;
         checkPauseSim.Location = new Point(116, 73);
         checkPauseSim.Margin = new Padding(3, 2, 3, 2);
         checkPauseSim.Name = "checkPauseSim";
         checkPauseSim.Size = new Size(86, 21);
         checkPauseSim.TabIndex = 3;
         checkPauseSim.Text = "Sim Pause";
         // 
         // checkPauseActive
         // 
         checkPauseActive.AutoSize = true;
         checkPauseActive.Location = new Point(116, 48);
         checkPauseActive.Margin = new Padding(3, 2, 3, 2);
         checkPauseActive.Name = "checkPauseActive";
         checkPauseActive.Size = new Size(99, 21);
         checkPauseActive.TabIndex = 2;
         checkPauseActive.Text = "Active Pause";
         // 
         // checkPauseFull
         // 
         checkPauseFull.AutoSize = true;
         checkPauseFull.Location = new Point(116, 23);
         checkPauseFull.Margin = new Padding(3, 2, 3, 2);
         checkPauseFull.Name = "checkPauseFull";
         checkPauseFull.Size = new Size(84, 21);
         checkPauseFull.TabIndex = 1;
         checkPauseFull.Text = "Full Pause";
         // 
         // btnPauseFull
         // 
         btnPauseFull.Location = new Point(6, 21);
         btnPauseFull.Margin = new Padding(3, 2, 3, 2);
         btnPauseFull.Name = "btnPauseFull";
         btnPauseFull.Size = new Size(95, 44);
         btnPauseFull.TabIndex = 0;
         btnPauseFull.Text = "Full Pause";
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
         groupFms.Location = new Point(287, 163);
         groupFms.Margin = new Padding(3, 2, 3, 2);
         groupFms.Name = "groupFms";
         groupFms.Padding = new Padding(3, 2, 3, 2);
         groupFms.Size = new Size(387, 86);
         groupFms.TabIndex = 202;
         groupFms.Text = "FMS";
         // 
         // btnFmsMfdInner
         // 
         btnFmsMfdInner.Location = new Point(335, 27);
         btnFmsMfdInner.Margin = new Padding(3, 2, 3, 2);
         btnFmsMfdInner.Name = "btnFmsMfdInner";
         btnFmsMfdInner.Size = new Size(45, 40);
         btnFmsMfdInner.TabIndex = 63;
         btnFmsMfdInner.Text = "MFD\r\nIN";
         // 
         // btnFmsMfdOuter
         // 
         btnFmsMfdOuter.Location = new Point(285, 27);
         btnFmsMfdOuter.Margin = new Padding(3, 2, 3, 2);
         btnFmsMfdOuter.Name = "btnFmsMfdOuter";
         btnFmsMfdOuter.Size = new Size(45, 40);
         btnFmsMfdOuter.TabIndex = 62;
         btnFmsMfdOuter.Text = "MFD\r\nOUT";
         // 
         // btnFmsEnt
         // 
         btnFmsEnt.Location = new Point(225, 52);
         btnFmsEnt.Margin = new Padding(3, 2, 3, 2);
         btnFmsEnt.Name = "btnFmsEnt";
         btnFmsEnt.Size = new Size(54, 25);
         btnFmsEnt.TabIndex = 61;
         btnFmsEnt.Text = "ENT";
         // 
         // btnFmsClr
         // 
         btnFmsClr.Location = new Point(166, 52);
         btnFmsClr.Margin = new Padding(3, 2, 3, 2);
         btnFmsClr.Name = "btnFmsClr";
         btnFmsClr.Size = new Size(54, 25);
         btnFmsClr.TabIndex = 60;
         btnFmsClr.Text = "CLR";
         // 
         // btnFmsMenu
         // 
         btnFmsMenu.Location = new Point(106, 52);
         btnFmsMenu.Margin = new Padding(3, 2, 3, 2);
         btnFmsMenu.Name = "btnFmsMenu";
         btnFmsMenu.Size = new Size(54, 25);
         btnFmsMenu.TabIndex = 59;
         btnFmsMenu.Text = "MENU";
         // 
         // btnFmsProc
         // 
         btnFmsProc.Location = new Point(225, 21);
         btnFmsProc.Margin = new Padding(3, 2, 3, 2);
         btnFmsProc.Name = "btnFmsProc";
         btnFmsProc.Size = new Size(54, 25);
         btnFmsProc.TabIndex = 58;
         btnFmsProc.Text = "PROC";
         // 
         // btnFmsFpl
         // 
         btnFmsFpl.Location = new Point(166, 21);
         btnFmsFpl.Margin = new Padding(3, 2, 3, 2);
         btnFmsFpl.Name = "btnFmsFpl";
         btnFmsFpl.Size = new Size(54, 25);
         btnFmsFpl.TabIndex = 57;
         btnFmsFpl.Text = "FPL";
         // 
         // btnFmsDirect
         // 
         btnFmsDirect.Location = new Point(106, 21);
         btnFmsDirect.Margin = new Padding(3, 2, 3, 2);
         btnFmsDirect.Name = "btnFmsDirect";
         btnFmsDirect.Size = new Size(54, 25);
         btnFmsDirect.TabIndex = 56;
         btnFmsDirect.Text = "DIR";
         // 
         // btnFmsPfdInner
         // 
         btnFmsPfdInner.Location = new Point(56, 27);
         btnFmsPfdInner.Margin = new Padding(3, 2, 3, 2);
         btnFmsPfdInner.Name = "btnFmsPfdInner";
         btnFmsPfdInner.Size = new Size(45, 40);
         btnFmsPfdInner.TabIndex = 55;
         btnFmsPfdInner.Text = "PFD\r\nIN";
         // 
         // btnFmsPfdOuter
         // 
         btnFmsPfdOuter.Location = new Point(6, 27);
         btnFmsPfdOuter.Margin = new Padding(3, 2, 3, 2);
         btnFmsPfdOuter.Name = "btnFmsPfdOuter";
         btnFmsPfdOuter.Size = new Size(45, 40);
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
         groupAutopilot.Location = new Point(287, 36);
         groupAutopilot.Margin = new Padding(3, 2, 3, 2);
         groupAutopilot.Name = "groupAutopilot";
         groupAutopilot.Padding = new Padding(3, 2, 3, 2);
         groupAutopilot.Size = new Size(518, 120);
         groupAutopilot.TabIndex = 201;
         groupAutopilot.Text = "Autopilot";
         // 
         // lblApproachStatus
         // 
         lblApproachStatus.Location = new Point(13, 100);
         lblApproachStatus.Margin = new Padding(3, 2, 3, 2);
         lblApproachStatus.Name = "lblApproachStatus";
         lblApproachStatus.Size = new Size(64, 17);
         lblApproachStatus.TabIndex = 54;
         lblApproachStatus.Text = "Approach: ";
         // 
         // btnCrs2Sel
         // 
         btnCrs2Sel.Location = new Point(463, 52);
         btnCrs2Sel.Margin = new Padding(3, 2, 3, 2);
         btnCrs2Sel.Name = "btnCrs2Sel";
         btnCrs2Sel.Size = new Size(45, 40);
         btnCrs2Sel.TabIndex = 53;
         btnCrs2Sel.Text = "CS2\r\nSEL";
         // 
         // checkApSpd
         // 
         checkApSpd.Location = new Point(408, 52);
         checkApSpd.Margin = new Padding(3, 2, 3, 2);
         checkApSpd.Name = "checkApSpd";
         checkApSpd.Size = new Size(45, 25);
         checkApSpd.TabIndex = 52;
         checkApSpd.Text = "SPD";
         // 
         // checkApFlc
         // 
         checkApFlc.Location = new Point(408, 21);
         checkApFlc.Margin = new Padding(3, 2, 3, 2);
         checkApFlc.Name = "checkApFlc";
         checkApFlc.Size = new Size(45, 25);
         checkApFlc.TabIndex = 51;
         checkApFlc.Text = "FLC";
         // 
         // btnNoseUpDn
         // 
         btnNoseUpDn.Location = new Point(367, 21);
         btnNoseUpDn.Margin = new Padding(3, 2, 3, 2);
         btnNoseUpDn.Name = "btnNoseUpDn";
         btnNoseUpDn.Size = new Size(34, 71);
         btnNoseUpDn.TabIndex = 50;
         btnNoseUpDn.Text = "DN\r\n\r\n\r\nUP";
         // 
         // checkApVnv
         // 
         checkApVnv.Location = new Point(319, 52);
         checkApVnv.Margin = new Padding(3, 2, 3, 2);
         checkApVnv.Name = "checkApVnv";
         checkApVnv.Size = new Size(45, 25);
         checkApVnv.TabIndex = 49;
         checkApVnv.Text = "VNV";
         // 
         // checkApVsHold
         // 
         checkApVsHold.Location = new Point(319, 21);
         checkApVsHold.Margin = new Padding(3, 2, 3, 2);
         checkApVsHold.Name = "checkApVsHold";
         checkApVsHold.Size = new Size(45, 25);
         checkApVsHold.TabIndex = 48;
         checkApVsHold.Text = "VS";
         // 
         // btnAltSel
         // 
         btnAltSel.Location = new Point(271, 52);
         btnAltSel.Margin = new Padding(3, 2, 3, 2);
         btnAltSel.Name = "btnAltSel";
         btnAltSel.Size = new Size(45, 40);
         btnAltSel.TabIndex = 47;
         btnAltSel.Text = "ALT\r\nSEL";
         // 
         // checkApAltHold
         // 
         checkApAltHold.Location = new Point(271, 21);
         checkApAltHold.Margin = new Padding(3, 2, 3, 2);
         checkApAltHold.Name = "checkApAltHold";
         checkApAltHold.Size = new Size(45, 25);
         checkApAltHold.TabIndex = 46;
         checkApAltHold.Text = "ALT";
         // 
         // checkApYd
         // 
         checkApYd.Location = new Point(214, 52);
         checkApYd.Margin = new Padding(3, 2, 3, 2);
         checkApYd.Name = "checkApYd";
         checkApYd.Size = new Size(45, 25);
         checkApYd.TabIndex = 45;
         checkApYd.Text = "YD";
         // 
         // checkApFd
         // 
         checkApFd.Location = new Point(189, 21);
         checkApFd.Margin = new Padding(3, 2, 3, 2);
         checkApFd.Name = "checkApFd";
         checkApFd.Size = new Size(45, 25);
         checkApFd.TabIndex = 44;
         checkApFd.Text = "FD";
         // 
         // checkApMaster
         // 
         checkApMaster.Location = new Point(163, 52);
         checkApMaster.Margin = new Padding(3, 2, 3, 2);
         checkApMaster.Name = "checkApMaster";
         checkApMaster.Size = new Size(45, 25);
         checkApMaster.TabIndex = 38;
         checkApMaster.Text = "AP";
         // 
         // btnCrs1Sel
         // 
         btnCrs1Sel.Location = new Point(106, 52);
         btnCrs1Sel.Margin = new Padding(3, 2, 3, 2);
         btnCrs1Sel.Name = "btnCrs1Sel";
         btnCrs1Sel.Size = new Size(45, 40);
         btnCrs1Sel.TabIndex = 43;
         btnCrs1Sel.Text = "CS1\r\nSEL";
         // 
         // btnHdgSel
         // 
         btnHdgSel.Location = new Point(10, 52);
         btnHdgSel.Margin = new Padding(3, 2, 3, 2);
         btnHdgSel.Name = "btnHdgSel";
         btnHdgSel.Size = new Size(45, 40);
         btnHdgSel.TabIndex = 39;
         btnHdgSel.Text = "HDG\r\nSEL";
         // 
         // checkApBcHold
         // 
         checkApBcHold.Location = new Point(58, 52);
         checkApBcHold.Margin = new Padding(3, 2, 3, 2);
         checkApBcHold.Name = "checkApBcHold";
         checkApBcHold.Size = new Size(45, 25);
         checkApBcHold.TabIndex = 42;
         checkApBcHold.Text = "BC";
         // 
         // checkApAprHold
         // 
         checkApAprHold.Location = new Point(58, 21);
         checkApAprHold.Margin = new Padding(3, 2, 3, 2);
         checkApAprHold.Name = "checkApAprHold";
         checkApAprHold.Size = new Size(45, 25);
         checkApAprHold.TabIndex = 41;
         checkApAprHold.Text = "APR";
         // 
         // checkApNavHold
         // 
         checkApNavHold.Location = new Point(106, 21);
         checkApNavHold.Margin = new Padding(3, 2, 3, 2);
         checkApNavHold.Name = "checkApNavHold";
         checkApNavHold.Size = new Size(45, 25);
         checkApNavHold.TabIndex = 40;
         checkApNavHold.Text = "NAV";
         // 
         // checkApHdgHold
         // 
         checkApHdgHold.Location = new Point(10, 21);
         checkApHdgHold.Margin = new Padding(3, 2, 3, 2);
         checkApHdgHold.Name = "checkApHdgHold";
         checkApHdgHold.Size = new Size(45, 25);
         checkApHdgHold.TabIndex = 39;
         checkApHdgHold.Text = "HDG";
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
         groupLights.Location = new Point(287, 388);
         groupLights.Margin = new Padding(3, 2, 3, 2);
         groupLights.Name = "groupLights";
         groupLights.Padding = new Padding(3, 2, 3, 2);
         groupLights.Size = new Size(387, 82);
         groupLights.TabIndex = 185;
         groupLights.Text = "Lights";
         // 
         // checkBeaconLight
         // 
         checkBeaconLight.AutoSize = true;
         checkBeaconLight.Location = new Point(9, 23);
         checkBeaconLight.Margin = new Padding(3, 2, 3, 2);
         checkBeaconLight.Name = "checkBeaconLight";
         checkBeaconLight.Size = new Size(49, 22);
         checkBeaconLight.TabIndex = 2;
         checkBeaconLight.Text = "Beacon";
         // 
         // checkWingLight
         // 
         checkWingLight.AutoSize = true;
         checkWingLight.Location = new Point(336, 54);
         checkWingLight.Margin = new Padding(3, 2, 3, 2);
         checkWingLight.Name = "checkWingLight";
         checkWingLight.Size = new Size(37, 22);
         checkWingLight.TabIndex = 44;
         checkWingLight.Text = "Wing";
         // 
         // checkCabinLight
         // 
         checkCabinLight.AutoSize = true;
         checkCabinLight.Location = new Point(75, 23);
         checkCabinLight.Margin = new Padding(3, 2, 3, 2);
         checkCabinLight.Name = "checkCabinLight";
         checkCabinLight.Size = new Size(40, 22);
         checkCabinLight.TabIndex = 34;
         checkCabinLight.Text = "Cabin";
         // 
         // checkTaxiLight
         // 
         checkTaxiLight.AutoSize = true;
         checkTaxiLight.Location = new Point(292, 54);
         checkTaxiLight.Margin = new Padding(3, 2, 3, 2);
         checkTaxiLight.Name = "checkTaxiLight";
         checkTaxiLight.Size = new Size(30, 22);
         checkTaxiLight.TabIndex = 43;
         checkTaxiLight.Text = "Taxi";
         // 
         // checkGlareshieldLight
         // 
         checkGlareshieldLight.AutoSize = true;
         checkGlareshieldLight.Location = new Point(130, 23);
         checkGlareshieldLight.Margin = new Padding(3, 2, 3, 2);
         checkGlareshieldLight.Name = "checkGlareshieldLight";
         checkGlareshieldLight.Size = new Size(72, 22);
         checkGlareshieldLight.TabIndex = 35;
         checkGlareshieldLight.Text = "Glareshield";
         // 
         // checkStrobeLight
         // 
         checkStrobeLight.AutoSize = true;
         checkStrobeLight.Location = new Point(230, 54);
         checkStrobeLight.Margin = new Padding(3, 2, 3, 2);
         checkStrobeLight.Name = "checkStrobeLight";
         checkStrobeLight.Size = new Size(46, 22);
         checkStrobeLight.TabIndex = 42;
         checkStrobeLight.Text = "Strobe";
         // 
         // checkLandingLight
         // 
         checkLandingLight.AutoSize = true;
         checkLandingLight.Location = new Point(217, 23);
         checkLandingLight.Margin = new Padding(3, 2, 3, 2);
         checkLandingLight.Name = "checkLandingLight";
         checkLandingLight.Size = new Size(53, 22);
         checkLandingLight.TabIndex = 36;
         checkLandingLight.Text = "Landing";
         // 
         // checkRecognitionLight
         // 
         checkRecognitionLight.AutoSize = true;
         checkRecognitionLight.Location = new Point(139, 54);
         checkRecognitionLight.Margin = new Padding(3, 2, 3, 2);
         checkRecognitionLight.Name = "checkRecognitionLight";
         checkRecognitionLight.Size = new Size(76, 22);
         checkRecognitionLight.TabIndex = 41;
         checkRecognitionLight.Text = "Recognition";
         // 
         // checkLogoLight
         // 
         checkLogoLight.AutoSize = true;
         checkLogoLight.Location = new Point(285, 23);
         checkLogoLight.Margin = new Padding(3, 2, 3, 2);
         checkLogoLight.Name = "checkLogoLight";
         checkLogoLight.Size = new Size(37, 22);
         checkLogoLight.TabIndex = 37;
         checkLogoLight.Text = "Logo";
         // 
         // checkPedestralLight
         // 
         checkPedestralLight.AutoSize = true;
         checkPedestralLight.Location = new Point(61, 54);
         checkPedestralLight.Margin = new Padding(3, 2, 3, 2);
         checkPedestralLight.Name = "checkPedestralLight";
         checkPedestralLight.Size = new Size(61, 22);
         checkPedestralLight.TabIndex = 40;
         checkPedestralLight.Text = "Pedestral";
         // 
         // checkNavLight
         // 
         checkNavLight.AutoSize = true;
         checkNavLight.Location = new Point(338, 23);
         checkNavLight.Margin = new Padding(3, 2, 3, 2);
         checkNavLight.Name = "checkNavLight";
         checkNavLight.Size = new Size(30, 22);
         checkNavLight.TabIndex = 38;
         checkNavLight.Text = "Nav";
         // 
         // checkPanelLight
         // 
         checkPanelLight.AutoSize = true;
         checkPanelLight.Location = new Point(9, 54);
         checkPanelLight.Margin = new Padding(3, 2, 3, 2);
         checkPanelLight.Name = "checkPanelLight";
         checkPanelLight.Size = new Size(38, 22);
         checkPanelLight.TabIndex = 39;
         checkPanelLight.Text = "Panel";
         // 
         // lblTransponder
         // 
         lblTransponder.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblTransponder.Appearance.Options.UseFont = true;
         lblTransponder.Location = new Point(19, 503);
         lblTransponder.Margin = new Padding(3, 2, 3, 2);
         lblTransponder.Name = "lblTransponder";
         lblTransponder.Size = new Size(64, 40);
         lblTransponder.TabIndex = 200;
         lblTransponder.Text = "0000";
         // 
         // label4
         // 
         label4.Location = new Point(19, 486);
         label4.Margin = new Padding(3, 2, 3, 2);
         label4.Name = "label4";
         label4.Size = new Size(75, 17);
         label4.TabIndex = 199;
         label4.Text = "Transponder";
         // 
         // lblVerticalSpeedValue
         // 
         lblVerticalSpeedValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblVerticalSpeedValue.Appearance.Options.UseFont = true;
         lblVerticalSpeedValue.Location = new Point(163, 445);
         lblVerticalSpeedValue.Margin = new Padding(3, 2, 3, 2);
         lblVerticalSpeedValue.Name = "lblVerticalSpeedValue";
         lblVerticalSpeedValue.Size = new Size(76, 40);
         lblVerticalSpeedValue.TabIndex = 198;
         lblVerticalSpeedValue.Text = "-0000";
         // 
         // label7
         // 
         label7.Location = new Point(163, 427);
         label7.Margin = new Padding(3, 2, 3, 2);
         label7.Name = "label7";
         label7.Size = new Size(84, 17);
         label7.TabIndex = 197;
         label7.Text = "Vertical Speed";
         // 
         // lblAltitudeValue
         // 
         lblAltitudeValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblAltitudeValue.Appearance.Options.UseFont = true;
         lblAltitudeValue.Location = new Point(19, 445);
         lblAltitudeValue.Margin = new Padding(3, 2, 3, 2);
         lblAltitudeValue.Name = "lblAltitudeValue";
         lblAltitudeValue.Size = new Size(80, 40);
         lblAltitudeValue.TabIndex = 196;
         lblAltitudeValue.Text = "00000";
         // 
         // label5
         // 
         label5.Location = new Point(19, 427);
         label5.Margin = new Padding(3, 2, 3, 2);
         label5.Name = "label5";
         label5.Size = new Size(44, 17);
         label5.TabIndex = 195;
         label5.Text = "Altitude";
         // 
         // lblCourseValue
         // 
         lblCourseValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCourseValue.Appearance.Options.UseFont = true;
         lblCourseValue.Location = new Point(163, 388);
         lblCourseValue.Margin = new Padding(3, 2, 3, 2);
         lblCourseValue.Name = "lblCourseValue";
         lblCourseValue.Size = new Size(48, 40);
         lblCourseValue.TabIndex = 194;
         lblCourseValue.Text = "000";
         // 
         // label3
         // 
         label3.Location = new Point(163, 368);
         label3.Margin = new Padding(3, 2, 3, 2);
         label3.Name = "label3";
         label3.Size = new Size(41, 17);
         label3.TabIndex = 193;
         label3.Text = "Course";
         // 
         // lblHeadingValue
         // 
         lblHeadingValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblHeadingValue.Appearance.Options.UseFont = true;
         lblHeadingValue.Location = new Point(19, 388);
         lblHeadingValue.Margin = new Padding(3, 2, 3, 2);
         lblHeadingValue.Name = "lblHeadingValue";
         lblHeadingValue.Size = new Size(48, 40);
         lblHeadingValue.TabIndex = 188;
         lblHeadingValue.Text = "000";
         // 
         // groupNav2
         // 
         groupNav2.Controls.Add(lblNav2StandbyValue);
         groupNav2.Controls.Add(lblNav2ActiveValue);
         groupNav2.Controls.Add(lblNav2Standby);
         groupNav2.Controls.Add(lblNav2Active);
         groupNav2.Location = new Point(12, 288);
         groupNav2.Margin = new Padding(3, 2, 3, 2);
         groupNav2.Name = "groupNav2";
         groupNav2.Padding = new Padding(3, 2, 3, 2);
         groupNav2.Size = new Size(271, 79);
         groupNav2.TabIndex = 192;
         groupNav2.Text = "NAV 2";
         // 
         // lblNav2StandbyValue
         // 
         lblNav2StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav2StandbyValue.Appearance.Options.UseFont = true;
         lblNav2StandbyValue.Location = new Point(9, 38);
         lblNav2StandbyValue.Margin = new Padding(3, 2, 3, 2);
         lblNav2StandbyValue.Name = "lblNav2StandbyValue";
         lblNav2StandbyValue.Size = new Size(86, 40);
         lblNav2StandbyValue.TabIndex = 4;
         lblNav2StandbyValue.Text = "000.00";
         // 
         // lblNav2ActiveValue
         // 
         lblNav2ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav2ActiveValue.Appearance.Options.UseFont = true;
         lblNav2ActiveValue.Location = new Point(157, 38);
         lblNav2ActiveValue.Margin = new Padding(3, 2, 3, 2);
         lblNav2ActiveValue.Name = "lblNav2ActiveValue";
         lblNav2ActiveValue.Size = new Size(86, 40);
         lblNav2ActiveValue.TabIndex = 5;
         lblNav2ActiveValue.Text = "000.00";
         // 
         // lblNav2Standby
         // 
         lblNav2Standby.Location = new Point(9, 21);
         lblNav2Standby.Margin = new Padding(3, 2, 3, 2);
         lblNav2Standby.Name = "lblNav2Standby";
         lblNav2Standby.Size = new Size(47, 17);
         lblNav2Standby.TabIndex = 2;
         lblNav2Standby.Text = "Standby";
         // 
         // lblNav2Active
         // 
         lblNav2Active.Location = new Point(157, 21);
         lblNav2Active.Margin = new Padding(3, 2, 3, 2);
         lblNav2Active.Name = "lblNav2Active";
         lblNav2Active.Size = new Size(34, 17);
         lblNav2Active.TabIndex = 3;
         lblNav2Active.Text = "Active";
         // 
         // label2
         // 
         label2.Location = new Point(19, 368);
         label2.Margin = new Padding(3, 2, 3, 2);
         label2.Name = "label2";
         label2.Size = new Size(49, 17);
         label2.TabIndex = 187;
         label2.Text = "Heading";
         // 
         // groupNav1
         // 
         groupNav1.Controls.Add(lblNav1StandbyValue);
         groupNav1.Controls.Add(lblNav1ActiveValue);
         groupNav1.Controls.Add(lblNav1Standby);
         groupNav1.Controls.Add(lblNav1Active);
         groupNav1.Location = new Point(12, 205);
         groupNav1.Margin = new Padding(3, 2, 3, 2);
         groupNav1.Name = "groupNav1";
         groupNav1.Padding = new Padding(3, 2, 3, 2);
         groupNav1.Size = new Size(271, 79);
         groupNav1.TabIndex = 191;
         groupNav1.Text = "NAV 1";
         // 
         // lblNav1StandbyValue
         // 
         lblNav1StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav1StandbyValue.Appearance.Options.UseFont = true;
         lblNav1StandbyValue.Location = new Point(9, 38);
         lblNav1StandbyValue.Margin = new Padding(3, 2, 3, 2);
         lblNav1StandbyValue.Name = "lblNav1StandbyValue";
         lblNav1StandbyValue.Size = new Size(86, 40);
         lblNav1StandbyValue.TabIndex = 4;
         lblNav1StandbyValue.Text = "000.00";
         // 
         // lblNav1ActiveValue
         // 
         lblNav1ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblNav1ActiveValue.Appearance.Options.UseFont = true;
         lblNav1ActiveValue.Location = new Point(157, 38);
         lblNav1ActiveValue.Margin = new Padding(3, 2, 3, 2);
         lblNav1ActiveValue.Name = "lblNav1ActiveValue";
         lblNav1ActiveValue.Size = new Size(86, 40);
         lblNav1ActiveValue.TabIndex = 5;
         lblNav1ActiveValue.Text = "000.00";
         // 
         // lblNav1Standby
         // 
         lblNav1Standby.Location = new Point(9, 21);
         lblNav1Standby.Margin = new Padding(3, 2, 3, 2);
         lblNav1Standby.Name = "lblNav1Standby";
         lblNav1Standby.Size = new Size(47, 17);
         lblNav1Standby.TabIndex = 2;
         lblNav1Standby.Text = "Standby";
         // 
         // lblNav1Active
         // 
         lblNav1Active.Location = new Point(157, 21);
         lblNav1Active.Margin = new Padding(3, 2, 3, 2);
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
         groupCom2.Location = new Point(12, 120);
         groupCom2.Margin = new Padding(3, 2, 3, 2);
         groupCom2.Name = "groupCom2";
         groupCom2.Padding = new Padding(3, 2, 3, 2);
         groupCom2.Size = new Size(271, 79);
         groupCom2.TabIndex = 190;
         groupCom2.Text = "COM 2";
         // 
         // lblCom2Standby
         // 
         lblCom2Standby.Location = new Point(9, 21);
         lblCom2Standby.Margin = new Padding(3, 2, 3, 2);
         lblCom2Standby.Name = "lblCom2Standby";
         lblCom2Standby.Size = new Size(47, 17);
         lblCom2Standby.TabIndex = 6;
         lblCom2Standby.Text = "Standby";
         // 
         // lblCom2StandbyValue
         // 
         lblCom2StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCom2StandbyValue.Appearance.Options.UseFont = true;
         lblCom2StandbyValue.Location = new Point(9, 36);
         lblCom2StandbyValue.Margin = new Padding(3, 2, 3, 2);
         lblCom2StandbyValue.Name = "lblCom2StandbyValue";
         lblCom2StandbyValue.Size = new Size(102, 40);
         lblCom2StandbyValue.TabIndex = 8;
         lblCom2StandbyValue.Text = "000.000";
         // 
         // lblCom2ActiveValue
         // 
         lblCom2ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F);
         lblCom2ActiveValue.Appearance.Options.UseFont = true;
         lblCom2ActiveValue.Location = new Point(157, 36);
         lblCom2ActiveValue.Margin = new Padding(3, 2, 3, 2);
         lblCom2ActiveValue.Name = "lblCom2ActiveValue";
         lblCom2ActiveValue.Size = new Size(102, 40);
         lblCom2ActiveValue.TabIndex = 9;
         lblCom2ActiveValue.Text = "000.000";
         // 
         // lblCom2Active
         // 
         lblCom2Active.Location = new Point(157, 21);
         lblCom2Active.Margin = new Padding(3, 2, 3, 2);
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
         groupCom1.Location = new Point(12, 36);
         groupCom1.Margin = new Padding(3, 2, 3, 2);
         groupCom1.Name = "groupCom1";
         groupCom1.Padding = new Padding(3, 2, 3, 2);
         groupCom1.Size = new Size(271, 79);
         groupCom1.TabIndex = 189;
         groupCom1.Text = "COM 1";
         // 
         // lblCom1StandbyValue
         // 
         lblCom1StandbyValue.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1StandbyValue.Appearance.Options.UseFont = true;
         lblCom1StandbyValue.Location = new Point(9, 38);
         lblCom1StandbyValue.Margin = new Padding(3, 2, 3, 2);
         lblCom1StandbyValue.Name = "lblCom1StandbyValue";
         lblCom1StandbyValue.Size = new Size(102, 40);
         lblCom1StandbyValue.TabIndex = 4;
         lblCom1StandbyValue.Text = "000.000";
         // 
         // lblCom1ActiveValue
         // 
         lblCom1ActiveValue.Appearance.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
         lblCom1ActiveValue.Appearance.Options.UseFont = true;
         lblCom1ActiveValue.Location = new Point(157, 38);
         lblCom1ActiveValue.Margin = new Padding(3, 2, 3, 2);
         lblCom1ActiveValue.Name = "lblCom1ActiveValue";
         lblCom1ActiveValue.Size = new Size(102, 40);
         lblCom1ActiveValue.TabIndex = 5;
         lblCom1ActiveValue.Text = "000.000";
         // 
         // lblCom1Standby
         // 
         lblCom1Standby.Location = new Point(9, 21);
         lblCom1Standby.Margin = new Padding(3, 2, 3, 2);
         lblCom1Standby.Name = "lblCom1Standby";
         lblCom1Standby.Size = new Size(47, 17);
         lblCom1Standby.TabIndex = 2;
         lblCom1Standby.Text = "Standby";
         // 
         // lblCom1Active
         // 
         lblCom1Active.Location = new Point(157, 21);
         lblCom1Active.Margin = new Padding(3, 2, 3, 2);
         lblCom1Active.Name = "lblCom1Active";
         lblCom1Active.Size = new Size(34, 17);
         lblCom1Active.TabIndex = 3;
         lblCom1Active.Text = "Active";
         // 
         // toolbarFormControl1
         // 
         toolbarFormControl1.Location = new Point(0, 0);
         toolbarFormControl1.Manager = toolbarFormManager1;
         toolbarFormControl1.Name = "toolbarFormControl1";
         toolbarFormControl1.Size = new Size(1133, 31);
         toolbarFormControl1.TabIndex = 270;
         toolbarFormControl1.TabStop = false;
         toolbarFormControl1.ToolbarForm = this;
         // 
         // toolbarFormManager1
         // 
         toolbarFormManager1.DockControls.Add(barDockControlTop);
         toolbarFormManager1.DockControls.Add(barDockControlBottom);
         toolbarFormManager1.DockControls.Add(barDockControlLeft);
         toolbarFormManager1.DockControls.Add(barDockControlRight);
         toolbarFormManager1.Form = this;
         // 
         // barDockControlTop
         // 
         barDockControlTop.CausesValidation = false;
         barDockControlTop.Dock = DockStyle.Top;
         barDockControlTop.Location = new Point(0, 31);
         barDockControlTop.Manager = toolbarFormManager1;
         barDockControlTop.Size = new Size(1133, 0);
         // 
         // barDockControlBottom
         // 
         barDockControlBottom.CausesValidation = false;
         barDockControlBottom.Dock = DockStyle.Bottom;
         barDockControlBottom.Location = new Point(0, 695);
         barDockControlBottom.Manager = toolbarFormManager1;
         barDockControlBottom.Size = new Size(1133, 0);
         // 
         // barDockControlLeft
         // 
         barDockControlLeft.CausesValidation = false;
         barDockControlLeft.Dock = DockStyle.Left;
         barDockControlLeft.Location = new Point(0, 31);
         barDockControlLeft.Manager = toolbarFormManager1;
         barDockControlLeft.Size = new Size(0, 664);
         // 
         // barDockControlRight
         // 
         barDockControlRight.CausesValidation = false;
         barDockControlRight.Dock = DockStyle.Right;
         barDockControlRight.Location = new Point(1133, 31);
         barDockControlRight.Manager = toolbarFormManager1;
         barDockControlRight.Size = new Size(0, 664);
         // 
         // MainForm
         // 
         Appearance.Options.UseFont = true;
         AutoScaleDimensions = new SizeF(7F, 17F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1133, 695);
         Controls.Add(lblBarometer1);
         Controls.Add(label6);
         Controls.Add(lblCurrentAircraft);
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
         Controls.Add(trackFlaps);
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
         Controls.Add(lblAltitudeValue);
         Controls.Add(label5);
         Controls.Add(lblCourseValue);
         Controls.Add(label3);
         Controls.Add(lblHeadingValue);
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
         ((System.ComponentModel.ISupportInitialize)trackFlaps).EndInit();
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
         groupPause.PerformLayout();
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
         ((System.ComponentModel.ISupportInitialize)toolbarFormManager1).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private ToolStripMenuItem testToolStripMenuItem;
      private TextEdit txtTotalFuelPct;
      private LabelControl lblBarometer1;
      private LabelControl label6;
      private LabelControl lblCurrentAircraft;
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
      private TrackBar trackFlaps;
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
      public TextEdit txtOutput;
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
      private CheckBox checkPauseEsc;
      private CheckBox checkPauseSim;
      private CheckBox checkPauseActive;
      private CheckBox checkPauseFull;
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
      private LabelControl lblAltitudeValue;
      private LabelControl label5;
      private LabelControl lblCourseValue;
      private LabelControl label3;
      private LabelControl lblHeadingValue;
      private GroupControl groupNav2;
      private LabelControl lblNav2StandbyValue;
      private LabelControl lblNav2ActiveValue;
      private LabelControl lblNav2Standby;
      private LabelControl lblNav2Active;
      private LabelControl label2;
      private GroupControl groupNav1;
      private LabelControl lblNav1StandbyValue;
      private LabelControl lblNav1ActiveValue;
      private LabelControl lblNav1Standby;
      private LabelControl lblNav1Active;
      private GroupControl groupCom2;
      private LabelControl lblCom2Standby;
      private LabelControl lblCom2StandbyValue;
      private LabelControl lblCom2ActiveValue;
      private LabelControl lblCom2Active;
      private GroupControl groupCom1;
      private LabelControl lblCom1StandbyValue;
      private LabelControl lblCom1ActiveValue;
      private LabelControl lblCom1Standby;
      private LabelControl lblCom1Active;
      private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
      private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
   }
}
