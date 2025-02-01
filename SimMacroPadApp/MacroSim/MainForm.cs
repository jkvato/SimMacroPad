using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors;
using FSUIPC;
using MacroSim.Fsuipc;
using MacroSim.MacroPadDevice;
using MacroSim.Properties;
using MacroSim.SimConnection;
using MacroSim.SimConnection.Enumerations;
using MacroSim.SimConnection.Structures;
using static MacroSim.SimConnection.SimConnection;

namespace MacroSim;

public partial class MainForm : XtraForm
{
   private readonly string MSFS2020ProcessName = "FlightSimulator";
   private readonly string MSFS2024ProcessName = "FlightSimulator2024";

   private readonly SimConnection.SimConnection simConnection;
   private readonly MacroPadDevice.MacroPadDevice macroPadDevice;

   private readonly System.Windows.Forms.Timer timerConnection;
   private readonly System.Windows.Forms.Timer timerFsuipcProcess;

   private bool suppressLightButtonCheckChangedEvent = true;
   private bool suppressAutopilotButtonCheckChangedEvent = true;
   private bool programmaticallyChangingCameraCheckButtones = true;

   private bool isMSFS2020Running = false;
   private bool isMSFS2024Running = false;

   private FsuipcConnection fsuipcConnection;

   private CamerasStruct previousCamera;
   private int previousCockpitSmartcamTarget;
   private int previousExtSmartcamTarget;

   private SimAircraft.SimAircraft? currentAircraft;

   private string currentAircraftTitle;

   public MainForm()
   {
      InitializeComponent();

      currentAircraftTitle = string.Empty;
      currentAircraft = null;

      previousCamera.cameraState = 2;
      previousCamera.cameraSubState = 1;
      previousCamera.cameraViewTypeIndex0 = 1;
      previousCamera.cameraViewTypeIndex1 = 1;

      previousCockpitSmartcamTarget = 0;
      previousExtSmartcamTarget = 0;

      btnHdgSel.MouseWheel += ApButton_MouseWheel;
      btnAltSel.MouseWheel += ApButton_MouseWheel;
      btnCrs1Sel.MouseWheel += ApButton_MouseWheel;
      btnCrs2Sel.MouseWheel += ApButton_MouseWheel;
      btnNoseUpDn.MouseWheel += ApButton_MouseWheel;

      btnFmsPfdInner.MouseWheel += FmsButton_MouseWheel;
      btnFmsPfdOuter.MouseWheel += FmsButton_MouseWheel;
      btnFmsMfdInner.MouseWheel += FmsButton_MouseWheel;
      btnFmsMfdOuter.MouseWheel += FmsButton_MouseWheel;

      simConnection = new SimConnection.SimConnection();
      fsuipcConnection = new FsuipcConnection(this);

      string eventsFilename;
      eventsFilename = Path.Combine(Settings.Default.FsuipcDirectory, "events.txt");
      fsuipcConnection.PresetEvents.ImportEvents(eventsFilename);
      eventsFilename = Path.Combine(Settings.Default.FsuipcDirectory, "myevents.txt");
      fsuipcConnection.PresetEvents.ImportEvents(eventsFilename);

      simConnection.DataReceived += SimConnection_DataReceivedFromSim;

      macroPadDevice = new MacroPadDevice.MacroPadDevice(simConnection, fsuipcConnection);
      macroPadDevice.EventProcessed += MacroPadDevice_EventProcessed;

      lblVerticalSpeedValue.AutoSize = false;

      GetComPorts();

      timerConnection = new System.Windows.Forms.Timer();
      timerConnection.Interval = 1000;
      timerConnection.Tick += TimerConnection_Tick;
      timerConnection.Start();

      timerFsuipcProcess = new System.Windows.Forms.Timer();
      timerFsuipcProcess.Interval = 250;
      timerFsuipcProcess.Tick += TimerFsuipcProcess_Tick;
      timerFsuipcProcess.Start();
   }

   private void TimerFsuipcProcess_Tick(object? sender, EventArgs e)
   {
      if (fsuipcConnection.IsConnected)
      {
         try
         {
            fsuipcConnection.Process();

            PauseState pauseState = (PauseState)fsuipcConnection.pauseReadStatus.Value;
            checkPauseFull.Checked = pauseState.HasFlag(PauseState.FullPause);
            checkPauseSim.Checked = pauseState.HasFlag(PauseState.SimPause);
            checkPauseActive.Checked = pauseState.HasFlag(PauseState.ActivePause);
            checkPauseEsc.Checked = pauseState.HasFlag(PauseState.EscPause);

            if (pauseState.HasFlag(PauseState.FullPause))
               btnPauseFull.Text = "Unpause";
            else
               btnPauseFull.Text = "Full Pause";

            if (pauseState.HasFlag(PauseState.SimPause))
               btnPauseSim.Text = "Unpause";
            else
               btnPauseSim.Text = "Sim Pause";
         }
         catch { }
      }
   }

   private void TimerConnection_Tick(object? sender, EventArgs e)
   {
      if (!simConnection.IsConnected)
      {
         try
         {
            simConnection.ConnectToSim(Handle);
         }
         catch { }
      }

      if (!fsuipcConnection.IsConnected)
      {
         fsuipcConnection.ConnectToSim();
         MSFSVariableServices.Init();
         MSFSVariableServices.Start();
      }

      UpdateConnectionStatus();

      GetRunningSimulators();
   }

   private void GetRunningSimulators()
   {
      Process[] processes;

      processes = Process.GetProcessesByName(MSFS2020ProcessName);
      isMSFS2020Running = processes.Length > 0;

      processes = Process.GetProcessesByName(MSFS2024ProcessName);
      isMSFS2024Running = processes.Length > 0;
   }

   private void ActivateFlightSimulator()
   {
      if (isMSFS2024Running)
      {
         BringMainWindowToFront(MSFS2024ProcessName);
      }
      else if (isMSFS2020Running)
      {
         BringMainWindowToFront(MSFS2020ProcessName);
      }
   }

   private void MacroPadDevice_EventProcessed(object sender, EventProcessedEventArgs e)
   {
      InvokeAction(form =>
      {
         //form.lblMacroPadState.Text = e.NewState.ToString();
      });
      UpdateConnectionStatus();
   }

   private void SimConnection_DataReceivedFromSim(object sender, object structure)
   {
      if (structure is AvionicsStruct avionicsStruct)
      {
         macroPadDevice.UpdateData(avionicsStruct);

         if (currentAircraftTitle != avionicsStruct.title)
         {
            System.Diagnostics.Debug.WriteLine("CHANGE OF PLANE");
            currentAircraftTitle = avionicsStruct.title;
             
            currentAircraft = SimAircraft.SimAircraftCollection.DefaultAircraft.GetByTitleWildcard(avionicsStruct.title);
            macroPadDevice.CurrentAircraft = currentAircraft;
         }

         // Update UI via Invoke
         InvokeAction(form =>
         {
            string newFormText = $"MacroSimPad - {avionicsStruct.title} | {avionicsStruct.liveryName} | {simConnection.EngineData.EngineType.ToString()}";
            if (Text != newFormText)
            {
               Text = newFormText;
            }

            string ac = avionicsStruct.title;
            if (currentAircraft != null)
            {
               ac += " | " + currentAircraft.Title;
            }
            lblCurrentAircraft.Text = ac;



            // COM1
            form.lblCom1Standby.Text = avionicsStruct.Com1StandbyName;
            form.lblCom1Active.Text = avionicsStruct.Com1ActiveName;
            form.lblCom1StandbyValue.Text = string.Format("{0:000.000}", avionicsStruct.com1standby);
            form.lblCom1ActiveValue.Text = string.Format("{0:000.000}", avionicsStruct.com1active);

            // COM2
            form.lblCom2Standby.Text = avionicsStruct.Com2StandbyName;
            form.lblCom2Active.Text = avionicsStruct.Com2ActiveName;
            form.lblCom2StandbyValue.Text = string.Format("{0:000.000}", avionicsStruct.com2standby);
            form.lblCom2ActiveValue.Text = string.Format("{0:000.000}", avionicsStruct.com2active);

            // NAV1
            if (avionicsStruct.nav1Ident == "")
               form.lblNav1Active.Text = "Active";
            else
               form.lblNav1Active.Text = avionicsStruct.nav1Ident + " " + avionicsStruct.nav1Name;

            form.lblNav1StandbyValue.Text = string.Format("{0:000.00}", avionicsStruct.nav1standby);
            form.lblNav1ActiveValue.Text = string.Format("{0:000.00}", avionicsStruct.nav1active);

            // NAV2
            if (avionicsStruct.nav2Ident == "")
               form.lblNav2Active.Text = "Active";
            else
               form.lblNav2Active.Text = avionicsStruct.nav2Ident + " " + avionicsStruct.nav2Name;

            form.lblNav2StandbyValue.Text = string.Format("{0:000.00}", avionicsStruct.nav2standby);
            form.lblNav2ActiveValue.Text = string.Format("{0:000.00}", avionicsStruct.nav2active);

            // AP Heading
            form.lblHeadingValue.Text = string.Format("{0:000}", avionicsStruct.apHeadingSel);

            // AP Course
            form.lblCourseValue.Text = string.Format("{0:000}", avionicsStruct.apNav1ObsSel);

            // AP Altitude
            form.lblAltitudeValue.Text = string.Format("{0:00000}", avionicsStruct.apAltitudeSel);

            // AP Vertical Speed
            form.lblVerticalSpeedValue.Text = string.Format("{0:0000}", avionicsStruct.apVerticalSpeedSel);

            // Transponder
            form.lblTransponder.Text = string.Format("{0:0000}", avionicsStruct.transponderCode);

            // Barometer
            form.lblBarometer1.Text = string.Format("{0:00.00}", avionicsStruct.baro1Setting);

            // Fuel
            form.lblTotalFuelPct.Text = string.Format("Total Fuel: {0:00.0}%", avionicsStruct.TotalFuelPct);
            form.lblFuelDumpSwitch.Text = avionicsStruct.FuelDumpSwitch ? "DUMP" : "off";
            form.btnFuelDump.Enabled = avionicsStruct.FuelDumpActive;

            string appr = string.Empty;
            appr = "Approach:";
            if (avionicsStruct.ApIsApproachArmed)
               appr += " ARMED";
            if (avionicsStruct.ApIsApproachCaptured)
               appr += " CAPTURED";
            if (avionicsStruct.ApIsApproachActive)
               appr += " ACTIVE";

            appr += "  :  Glideslope:";
            if (avionicsStruct.ApIsGlideslopeArmed)
               appr += " ARMED";
            if (avionicsStruct.ApIsGlideslopeActive)
               appr += " ACTIVE";
            if (avionicsStruct.ApGlideslopeHoldEngaged)
               appr += " HOLD_ENGAGED";

            form.lblApproachStatus.Text = appr;

            suppressAutopilotButtonCheckChangedEvent = true;
            form.checkApMaster.Checked = avionicsStruct.ApMasterEngaged;
            form.checkApAltHold.Checked = avionicsStruct.ApAltitudeHoldEngaged;
            form.checkApHdgHold.Checked = avionicsStruct.ApHeadingHoldEngaged;
            form.checkApVsHold.Checked = avionicsStruct.ApVerticalSpeedHoldEngaged;
            form.checkApNavHold.Checked = avionicsStruct.ApNav1HoldEngaged;
            form.checkApAprHold.Checked = avionicsStruct.ApApproachHoldEngaged;
            form.checkApFd.Checked = avionicsStruct.ApFlightDirectorEnabled;
            form.checkApYd.Checked = avionicsStruct.ApYawDamperEngaged;
            form.checkApBcHold.Checked = avionicsStruct.ApBackCourseHoldEngaged;
            form.checkApVnv.Checked = false;
            form.checkApFlc.Checked = avionicsStruct.ApFlightLevelChangeEngaged;
            form.checkApSpd.Checked = avionicsStruct.ApVerticalSpeedHoldEngaged;

            suppressAutopilotButtonCheckChangedEvent = false;
         });
      }
      else if (structure is LightsStruct lightsStruct)
      {
         macroPadDevice.UpdateData(lightsStruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            // Lights
            suppressLightButtonCheckChangedEvent = true;
            form.checkBeaconLight.Checked = lightsStruct.LightBeaconOn;
            form.checkCabinLight.Checked = lightsStruct.LightCabinOn;
            form.checkGlareshieldLight.Checked = lightsStruct.LightGlareshieldOn;
            form.checkLandingLight.Checked = lightsStruct.LightLandingOn;
            form.checkLogoLight.Checked = lightsStruct.LightLogoOn;
            form.checkNavLight.Checked = lightsStruct.LightNavOn;
            form.checkPanelLight.Checked = lightsStruct.LightPanelOn;
            form.checkPedestralLight.Checked = lightsStruct.LightPedestralOn;
            form.checkRecognitionLight.Checked = lightsStruct.LightRecognitionOn;
            form.checkStrobeLight.Checked = lightsStruct.LightStrobeOn;
            form.checkTaxiLight.Checked = lightsStruct.LightTaxiOn;
            form.checkWingLight.Checked = lightsStruct.LightWingOn;
            suppressLightButtonCheckChangedEvent = false;
         });
      }
      else if (structure is AircraftControlStruct acControlSruct)
      {
         macroPadDevice.UpdateData(acControlSruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            double elevatorTrimMax = Math.Max(acControlSruct.elevatorTrimMax, -1 * acControlSruct.elevatorTrimMin);
            double elevatorTrimPct = 100d * acControlSruct.elevatorTrimPosition / elevatorTrimMax;
            form.lblElevatorTrimPct.Text = string.Format("Elevator Trim: {0:0} %", elevatorTrimPct);

            double rudderTrimMax = Math.Max(acControlSruct.rudderTrimMax, -1 * acControlSruct.rudderTrimMin);
            double rudderTrimPct = 100d * acControlSruct.rudderTrimPosition / rudderTrimMax;
            form.lblRudderTrimPct.Text = string.Format("Rudder Trim: {0:0} %", rudderTrimPct);

            form.lblTrailingFlapsLeft.Text = string.Format("Trailing Flaps Left: {0:0} Degrees", acControlSruct.flapsTrailingEdgeLeft);
            form.lblTrailingFlapsRight.Text = string.Format("Trailing Flaps Right: {0:0} Degrees", acControlSruct.flapsTrailingEdgeRight);
            form.lblCurrentFlapsLimit.Text = string.Format("Current Limit: {0:0} Knots", acControlSruct.flapsCurrentLimitation);
            form.lblFlapsNumberOfDetents.Text = string.Format("Number of Detents: {0}", acControlSruct.flapsNumHandlePositions);
            form.lblFlapsCurrentPosition.Text = string.Format("Current Position: {0}", acControlSruct.flapsHandleIndex);

            trackFlaps.Minimum = -1 * acControlSruct.flapsNumHandlePositions;
            trackFlaps.Maximum = 0;
            trackFlaps.Value = -1 * acControlSruct.flapsHandleIndex;
            //trackFlaps.Minimum = 0;
            //trackFlaps.Maximum = trimStruct.flapsNumHandlePositions;
            //trackFlaps.Value = trimStruct.flapsHandleIndex;

            lblSpoilersAvailable.Text = acControlSruct.SpoilersAvailable ?
               "Spoilers: Available" : "Spoilers: None";
            lblSpoilersArmed.Text = acControlSruct.SpoilersArmed ?
               "Spoilers: Armed" : "Spoilers: Not Armed";
            lblSpoilersHandlePosition.Text = string.Format("Spoilers Handle: {0:0}%",
               acControlSruct.spoilersHandlePosition);
            lblSpoilersPosition.Text = string.Format("Spoilers Position: {0:0}%  L, {1:0}% R",
               acControlSruct.spoilersLeftPosition, acControlSruct.spoilersRightPosition);
         });
      }
      else if (structure is CamerasStruct camerasStruct)
      {
         macroPadDevice.UpdateData(camerasStruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            programmaticallyChangingCameraCheckButtones = true;
            if (camerasStruct.IsCockpitPilotSubState)
            {
               form.checkCamera1.Checked = false;
               form.checkCamera2.Checked = false;
               form.checkCamera3.Checked = false;
               form.checkCamera4.Checked = false;
               form.checkCamera5.Checked = false;
               form.checkCamera6.Checked = false;
               form.checkCamera7.Checked = false;
               form.checkCamera8.Checked = false;
               form.checkCamera9.Checked = false;
               form.checkCamera10.Checked = false;
            }
            else if (camerasStruct.IsCustomCamera)
            {
               form.checkCamera1.Checked = currentCustomCamera == 0;
               form.checkCamera2.Checked = currentCustomCamera == 1;
               form.checkCamera3.Checked = currentCustomCamera == 2;
               form.checkCamera4.Checked = currentCustomCamera == 3;
               form.checkCamera5.Checked = currentCustomCamera == 4;
               form.checkCamera6.Checked = currentCustomCamera == 5;
               form.checkCamera7.Checked = currentCustomCamera == 6;
               form.checkCamera8.Checked = currentCustomCamera == 7;
               form.checkCamera9.Checked = currentCustomCamera == 8;
               form.checkCamera10.Checked = currentCustomCamera == 9;
            }
            else
            {
               form.checkCamera1.Checked = camerasStruct.CameraViewIndex1 == 0;
               form.checkCamera2.Checked = camerasStruct.CameraViewIndex1 == 1;
               form.checkCamera3.Checked = camerasStruct.CameraViewIndex1 == 2;
               form.checkCamera4.Checked = camerasStruct.CameraViewIndex1 == 3;
               form.checkCamera5.Checked = camerasStruct.CameraViewIndex1 == 4;
               form.checkCamera6.Checked = camerasStruct.CameraViewIndex1 == 5;
               form.checkCamera7.Checked = camerasStruct.CameraViewIndex1 == 6;
               form.checkCamera8.Checked = camerasStruct.CameraViewIndex1 == 7;
               form.checkCamera9.Checked = camerasStruct.CameraViewIndex1 == 8;
               form.checkCamera10.Checked = camerasStruct.CameraViewIndex1 == 9;
            }

            form.checkCameraPilotNormal.Checked = camerasStruct.IsPilotNormalCameraActive;
            form.checkCameraPilotClose.Checked = camerasStruct.IsPilotCloseCameraActive;
            form.checkCameraPilotLand.Checked = camerasStruct.IsPilotLandingCameraActive;
            form.checkCameraPilotCoPilot.Checked = camerasStruct.IsPilotCoPilotCameraActive;
            form.checkCockpitPilotSubState.Checked = camerasStruct.IsCockpitPilotSubState;
            form.checkCockpitInstrumentSubState.Checked = camerasStruct.IsCockpitInstrumentSubState;
            form.checkCockpitQuickViewSubState.Checked = camerasStruct.IsCockpitQuickViewSubState;
            form.checkExternalDefaultSubState.Checked = camerasStruct.IsExternalDefaultSubState;
            form.checkExternalQuickViewSubState.Checked = camerasStruct.IsExternalQuickViewSubState;
            form.checkShowcaseDroneSubState.Checked = camerasStruct.IsShowcaseDroneSubState;
            form.checkShowcaseFixedSubState.Checked = camerasStruct.IsShowcaseFixedSubState;
            form.checkCustomCameraState.Checked = camerasStruct.IsCustomCamera;

            form.checkSmartcam.Checked = camerasStruct.IsSmartCamActive;
            btnNextSmartcam.Enabled = camerasStruct.IsSmartCamActive;
            btnPreviousSmartcam.Enabled = camerasStruct.IsSmartCamActive;

            if (camerasStruct.IsSmartCamActive)
            {
               checkSmartcam.Text = $"SC {camerasStruct.SmartCameraTargetIndex}";
            }
            else
            {
               checkSmartcam.Text = $"SC {camerasStruct.SmartCameraTargetIndex}";
            }

            //form.lblCustomCamera.Text = $"{previousCockpitSmartcamTarget}, {previousExtSmartcamTarget}";
            form.lblCustomCamera.Text = $"c {currentCustomCamera}, p {previousCustomCamera}";

            form.lblCameraCurrentView.Text = $"{camerasStruct.cameraState}, {camerasStruct.cameraSubState}, {camerasStruct.cameraViewTypeIndex0}, {camerasStruct.cameraViewTypeIndex1}";
            form.lblCameraState.Text = $"State: {camerasStruct.cameraState} ({camerasStruct.CameraState})";
            form.lblCameraSubstate.Text = $"Substate: {camerasStruct.cameraSubState} ({camerasStruct.CameraSubState})";
            form.lblIndex0.Text = $"Index0: {camerasStruct.cameraViewTypeIndex0} ({camerasStruct.CameraViewIndex0})";

            string cam = string.Empty;
            cam = $"Index1: {camerasStruct.cameraViewTypeIndex1} ({camerasStruct.cameraViewTypeIndex1 + 1})";

            if (camerasStruct.IsSmartCamActive)
            {
               if (camerasStruct.CameraState == CameraState.Cockpit)
                  previousCockpitSmartcamTarget = camerasStruct.SmartCameraTargetIndex;
               else if (camerasStruct.CameraState == CameraState.External)
                  previousExtSmartcamTarget = camerasStruct.SmartCameraTargetIndex;
            }

            if (camerasStruct.CameraViewIndex0 == CameraViewIndex0.PilotView)
            {
               cam += $" [{(CameraViewIndex1Pilot)(camerasStruct.CameraViewIndex1 + 1)}]";
            }
            else if (camerasStruct.CameraViewIndex0 == CameraViewIndex0.Instruments)
            {
               cam += $" [{(CameraViewIndex1Instrument)(camerasStruct.CameraViewIndex1 + 1)}]";
            }

            lblIndex1.Text = cam;

            cam = string.Empty;
            cam = simConnection.CameraType.ToString();
            cam += $" [{simConnection.CamerasData.cameraviewTypeMax0}, ";
            cam += $" {simConnection.CamerasData.cameraviewTypeMax1}, ";
            cam += $" {simConnection.CamerasData.cameraviewTypeMax2}, ";
            cam += $" {simConnection.CamerasData.cameraviewTypeMax3}, ";
            cam += $" {simConnection.CamerasData.cameraviewTypeMax4}, ";
            cam += $" {simConnection.CamerasData.cameraviewTypeMax5}]";

            form.lblCurrentCameraType.Text = cam;

            if (camerasStruct.IsCockpitPilotSubState)
            {
               lastCockpitPilotCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsCockpitInstrumentSubState)
            {
               lastCockpitInstrumentCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsCockpitQuickViewSubState)
            {
               lastCockpitQuickViewCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsExternalDefaultSubState)
            {
               lastExternalDefaultCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsExternalQuickViewSubState)
            {
               lastExternalQuickViewCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsShowcaseDroneSubState)
            {
               lastExternalDefaultCamera = camerasStruct.cameraViewTypeIndex1;
            }
            else if (camerasStruct.IsShowcaseFixedSubState)
            {
               lastShowcaseFixedCamera = camerasStruct.cameraViewTypeIndex1;
            }

            programmaticallyChangingCameraCheckButtones = false;
         });
      }
      else if (structure is TimeStruct timeStruct)
      {
         macroPadDevice.UpdateData(timeStruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            form.lblSimRate.Text = "Sim Rate: " + timeStruct.SimulationRate.ToString();
            //form.lblLocalTime.Text = string.Format("Local Time: {0:MM/dd/yy hh:mm:ss tt}", timeStruct.LocalDateTime);
         });
      }
      else if (structure is EngineStruct engineStruct)
      {
         macroPadDevice.UpdateData(engineStruct);

         InvokeAction(form =>
         {
            form.lblEngineTorque.Text = string.Format("Torque: {0:0.0}", engineStruct.EngTorquePsi1);
            form.lblEngineITT.Text = string.Format("{0} engines", engineStruct.numberOfEngines);
            form.lblEngineITT.Text = string.Format("ITT: {0:0} C", engineStruct.turbEngITT1);
            form.lblEngineNGPct.Text = string.Format("NG: {0:0.0} %", engineStruct.turbEngN1_1);
            form.lblEngineNPRpm.Text = string.Format("NP: {0:0} RPM", engineStruct.propRpm1);
            form.lblEngineTorquePct.Text = string.Format("TRQ PCT: {0:0} %", engineStruct.turbEngMaxTorquePct1);

            form.lblThrottle1Pct.Text = string.Format("Throttle 1: {0:0.0} %", engineStruct.genEngThrottleLever1);
            form.lblPropeller1Pct.Text = string.Format("Propeller 1: {0:0.0} %", engineStruct.genEngPropellerLever1);
            form.lblMixture1Pct.Text = string.Format("Mixture 1: {0:0.0} %", engineStruct.genEngMixtureLever1);
            form.lblEngCondition1.Text = engineStruct.EngineCondition1.ToString();
         });
      }
      else if (structure is SmartcamTargetsStruct smartcamtargetsStruct)
      {
         macroPadDevice.UpdateData(smartcamtargetsStruct);

         InvokeAction(form =>
         {
            var targetData = smartcamtargetsStruct.GetSmartcamTarget(simConnection.CamerasData.smartCameraInfo1);
            lblSCTargetType.Text = targetData.Item1.ToString();
            lblSCTargetDesc.Text = targetData.Item2;
         });
      }
   }

   protected override void DefWndProc(ref Message m)
   {
      if (m.Msg == WM_USER_SIMCONNECT)
      {
         try
         {
            simConnection?.ReceiveMessage();
         }
         catch (COMException)
         {
         }
      }
      else
      {
         base.DefWndProc(ref m);
      }
   }

   /// <summary>
   /// Invoke an <see cref="Action"/> on a <see cref="MainForm"/> from any thread.
   /// </summary>
   /// <param name="action">The <see cref="Action"/> to invoke.</param>
   public void InvokeAction(Action<MainForm> action)
   {
      if (InvokeRequired)
      {
         Invoke(action, this);
      }
      else
      {
         action(this);
      }
   }

   private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
   {
      Close();
   }

   private void ConnectToSimToolStripMenuItem_Click(object sender, EventArgs e)
   {
      if (simConnection.IsConnected)
      {
         simConnection.DisconnectFromSim();
         System.Diagnostics.Debug.WriteLine("Disconnected");
      }
      else
      {
         simConnection.ConnectToSim(Handle);
         System.Diagnostics.Debug.WriteLine("Connected");
      }
   }

   private void GetComPorts()
   {
      string[] ports = SerialPort.GetPortNames();

      List<string> portList = new List<string>();

      for (int i = 0; i < ports.Length; i++)
      {
         if (!portList.Contains(ports[i]))
         {
            portList.Add(ports[i]);
         }
      }

      // Remove old list of com ports from the menu.
      //for (int i = macroPadToolStripMenuItem.DropDownItems.Count - 1; i >= 0; i--)
      //{
      //   var item = macroPadToolStripMenuItem.DropDownItems[i];
      //   if (item is ToolStripMenuItem menuItem)
      //   {
      //      if (menuItem.Text.StartsWith("COM", StringComparison.CurrentCultureIgnoreCase))
      //      {
      //         macroPadToolStripMenuItem.DropDownItems.RemoveAt(i);
      //      }
      //   }
      //}

      // Add new list of com ports to the menu.
      foreach (string port in portList)
      {
         ToolStripMenuItem item = new ToolStripMenuItem(port);   // create a new menu item
         item.Click += ComPortsStripMenuItem_Click;  // add event handler
         //macroPadToolStripMenuItem.DropDownItems.Add(item);  // add to the menu of COM ports
      }
   }

   private void ComPortsStripMenuItem_Click(object? sender, EventArgs e)
   {
      if (sender is ToolStripMenuItem menuItem)
      {
         string comPortName = menuItem.ToString();
         macroPadDevice.SetSerialPort(comPortName);
      }
   }

   private void UpdateConnectionStatus()
   {
      InvokeAction(form =>
      {
         if (macroPadDevice.SerialPort.IsOpen)
         {
            //lblSerialPortStatus.Text = $"Serial: {macroPadDevice.SerialPort.PortName}";
         }
         else
         {
            //lblSerialPortStatus.Text = $"Serial: Disconnected";
         }

         if (fsuipcConnection.IsConnected)
         {
            //fsuipcConnectToolStripMenuItem.Text = "Disconnect FSUIPC";
            //lblFsuipcStatus.Text = "FSUIPC: Connected";
         }
         else
         {
            //fsuipcConnectToolStripMenuItem.Text = "Connect FSUIPC";
            //lblFsuipcStatus.Text = "FSUIPC: Disconnected";
         }

         if (simConnection.IsConnected)
         {
            //simConnectToolStripMenuItem.Text = "Disconnect SimConnect";
            //lblSimConnectStatus.Text = "SimConnect: Connected";
         }
         else
         {
            //simConnectToolStripMenuItem.Text = "Connect SimConnect";
            //lblSimConnectStatus.Text = "SimConnect: Disconnected";
         }
      });
   }

   private void LightButton_CheckedChanged(object sender, EventArgs e)
   {
      if (suppressLightButtonCheckChangedEvent)
      {
         return;
      }

      if (sender is CheckButton CheckButton)
      {
         if (CheckButton == checkBeaconLight)
            simConnection.SendEvent(SimEvent.TOGGLE_BEACON_LIGHTS);
         else if (CheckButton == checkCabinLight)
            simConnection.SendEvent(SimEvent.TOGGLE_CABIN_LIGHTS);
         else if (CheckButton == checkGlareshieldLight)
            simConnection.SendEvent(SimEvent.GLARESHIELD_LIGHTS_TOGGLE);
         else if (CheckButton == checkLandingLight)
            simConnection.SendEvent(SimEvent.LANDING_LIGHTS_TOGGLE);
         else if (CheckButton == checkLogoLight)
            simConnection.SendEvent(SimEvent.TOGGLE_LOGO_LIGHTS);
         else if (CheckButton == checkNavLight)
            simConnection.SendEvent(SimEvent.TOGGLE_NAV_LIGHTS);
         else if (CheckButton == checkPanelLight)
            simConnection.SendEvent(SimEvent.PANEL_LIGHTS_TOGGLE);
         else if (CheckButton == checkPedestralLight)
            simConnection.SendEvent(SimEvent.PEDESTRAL_LIGHTS_TOGGLE);
         else if (CheckButton == checkRecognitionLight)
            simConnection.SendEvent(SimEvent.TOGGLE_RECOGNITION_LIGHTS);
         else if (CheckButton == checkStrobeLight)
            simConnection.SendEvent(SimEvent.STROBES_TOGGLE);
         else if (CheckButton == checkTaxiLight)
            simConnection.SendEvent(SimEvent.TOGGLE_TAXI_LIGHTS);
         else if (CheckButton == checkWingLight)
            simConnection.SendEvent(SimEvent.TOGGLE_WING_LIGHTS);
      }
      ActivateFlightSimulator();
   }

   private void RefreshSerialPortsToolStripMenuItem_Click(object sender, EventArgs e)
   {
      GetComPorts();
   }

   private void PresetEventsToolStripMenuItem_Click(object sender, EventArgs e)
   {
      using PresetEventForm dlg = new PresetEventForm(fsuipcConnection.PresetEvents);

      if (dlg.ShowDialog() == DialogResult.OK)
      {

      }
   }

   private void ApButton_Click(object sender, EventArgs e)
   {
      if (sender == null)
         return;
      if (sender is SimpleButton button)
      {
         if (button == btnHdgSel)
         {
            fsuipcConnection.SendPresetEvent("AP_HDG_SYNC");
         }
         else if (button == btnCrs1Sel)
         {
            fsuipcConnection.SendPresetEvent("AP_CRS1_SYNC");
         }
         else if (button == btnCrs2Sel)
         {
            fsuipcConnection.SendPresetEvent("AP_CRS2_SYNC");
         }
         else if (button == btnAltSel)
         {
            fsuipcConnection.SendPresetEvent("AP_ALT_SYNC");
         }
      }
      ActivateFlightSimulator();
   }

   private void FmsButton_Click(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (sender is SimpleButton button)
      {
         string preset = string.Empty;

         if (button == btnFmsClr)
         {
            preset = "AS1000_PFD_CLR";
         }
         else if (button == btnFmsDirect)
         {
            preset = "AS1000_PFD_DIRECTTO";
         }
         else if (button == btnFmsEnt)
         {
            preset = "AS1000_PFD_ENT_Push";
         }
         else if (button == btnFmsFpl)
         {
            preset = "AS1000_PFD_FPL_Push";
         }
         else if (button == btnFmsMenu)
         {
            preset = "AS1000_PFD_MENU_Push";
         }
         else if (button == btnFmsProc)
         {
            preset = "AS1000_PFD_PROC_Push";
         }

         if (!string.IsNullOrWhiteSpace(preset))
         {
            fsuipcConnection.SendPresetEvent(preset);
         }
      }
      ActivateFlightSimulator();
   }

   private void BtnPause_Click(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (sender is SimpleButton btnPause)
      {
         PauseState pauseState = fsuipcConnection.GetPauseStatus();

         if (btnPause == btnPauseFull)
         {
            if (pauseState.HasFlag(PauseState.FullPause))
               fsuipcConnection.SetPauseStatus(PauseState.NoPause);
            else
               fsuipcConnection.SetPauseStatus(PauseState.FullPause);
         }
         else if (btnPause == btnPauseSim)
         {
            if (pauseState.HasFlag(PauseState.SimPause))
               fsuipcConnection.SetPauseStatus(PauseState.NoPause);
            else
               fsuipcConnection.SetPauseStatus(PauseState.SimPause);
         }
      }
      ActivateFlightSimulator();
   }

   private void FmsButton_MouseWheel(object? sender, MouseEventArgs e)
   {
      if (sender is null)
         return;

      if (sender is SimpleButton button)
      {
         bool up = (e.Delta > 0);
         string preset = string.Empty;

         if (button == btnFmsPfdInner)
         {
            preset = up ? "AS1000_PFD_FMS_Inner_INC" : "AS1000_PFD_FMS_Inner_DEC";
         }
         else if (button == btnFmsPfdOuter)
         {
            preset = up ? "AS1000_PFD_FMS_Outer_INC" : "AS1000_PFD_FMS_Outer_DEC";
         }
         if (button == btnFmsMfdInner)
         {
            preset = up ? "AS1000_MFD_FMS_Inner_INC" : "AS1000_MFD_FMS_Inner_DEC";
         }
         else if (button == btnFmsMfdOuter)
         {
            preset = up ? "AS1000_MFD_FMS_Outer_INC" : "AS1000_MFD_FMS_Outer_DEC";
         }

         if (!string.IsNullOrWhiteSpace(preset))
         {
            fsuipcConnection.SendPresetEvent(preset);
         }
      }
   }

   private void ApButton_MouseWheel(object? sender, MouseEventArgs e)
   {
      if (sender is null)
         return;

      if (sender is SimpleButton button)
      {
         bool up = (e.Delta > 0);
         SimEvent simEvent = SimEvent.NONE;

         if (button == btnAltSel)
         {
            simEvent = up ? SimEvent.AP_ALT_VAR_INC : SimEvent.AP_ALT_VAR_DEC;
         }
         else if (button == btnHdgSel)
         {
            simEvent = up ? SimEvent.HEADING_BUG_INC : SimEvent.HEADING_BUG_DEC;
         }
         else if (button == btnCrs1Sel)
         {
            simEvent = up ? SimEvent.VOR1_OBI_INC : SimEvent.VOR1_OBI_DEC;
         }
         else if (button == btnCrs2Sel)
         {
            simEvent = up ? SimEvent.VOR2_OBI_INC : SimEvent.VOR2_OBI_DEC;
         }
         else if (button == btnNoseUpDn)
         {
            if (up)
               simEvent = SimEvent.AP_VS_VAR_INC;
            else
               simEvent = SimEvent.AP_VS_VAR_DEC;
         }

         if (simEvent != SimEvent.NONE)
         {
            simConnection.SendEvent(simEvent);
         }
      }
   }

   private void Autopilot_CheckedChanged(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (suppressAutopilotButtonCheckChangedEvent)
         return;

      SimEvent simEvent = SimEvent.NONE;

      if (sender is CheckButton CheckButton)
      {
         if (CheckButton == checkApMaster)
         {
            simEvent = SimEvent.AP_MASTER;
         }
         else if (CheckButton == checkApHdgHold)
         {
            simEvent = SimEvent.AP_HDG_HOLD;
         }
         else if (CheckButton == checkApAprHold)
         {
            simEvent = SimEvent.AP_APR_HOLD;
         }
         else if (CheckButton == checkApBcHold)
         {
            simEvent = SimEvent.AP_BC_HOLD;
         }
         else if (CheckButton == checkApNavHold)
         {
            simEvent = SimEvent.AP_NAV1_HOLD;
         }
         else if (CheckButton == checkApFd)
         {
            simEvent = SimEvent.TOGGLE_FLIGHT_DIRECTOR;
         }
         else if (CheckButton == checkApYd)
         {
            simEvent = SimEvent.YAW_DAMPER_TOGGLE;
         }
         else if (CheckButton == checkApAltHold)
         {
            simEvent = SimEvent.AP_ALT_HOLD;
         }
         else if (CheckButton == checkApVsHold)
         {
            simEvent = SimEvent.AP_VS_HOLD;
         }
         else if (CheckButton == checkApVnv)
         {
            simEvent = SimEvent.NONE;
         }
         else if (CheckButton == checkApFlc)
         {
            simEvent = SimEvent.FLIGHT_LEVEL_CHANGE;
         }
         else if (CheckButton == checkApSpd)
         {
            simEvent = SimEvent.AP_AIRSPEED_HOLD;
         }

         if (simEvent != SimEvent.NONE)
         {
            simConnection.SendEvent(simEvent);
         }
      }
      ActivateFlightSimulator();
   }

   private void btnAddFuel_Click(object sender, EventArgs e)
   {
      fsuipcConnection.SendPresetEvent("ADD_FUEL");
      ActivateFlightSimulator();
      BringMainWindowToFront("flight simulator");
   }

   private void btnFuelDump_Click(object sender, EventArgs e)
   {
      fsuipcConnection.SendPresetEvent("FUEL_DUMP_TOGGLE");
      ActivateFlightSimulator();
   }

   private int lastCockpitPilotCamera = 1;
   private int lastCockpitInstrumentCamera = 0;
   private int lastCockpitQuickViewCamera = 0;
   private int lastCockpitSmartCamCamera = 0;
   private int lastExternalDefaultCamera = 0;
   private int lastExternalQuickViewCamera = 0;
   private int lastExternalSmartCamCamera = 0;
   private int lastShowcaseFreeCamera = 0;
   private int lastShowcaseFixedCamera = 0;
   private int lastShowcaseSmartCamCamera = 0;
   private int previousCustomCamera = 5;
   private int currentCustomCamera = 0;

   private void CameraButton_CheckChanged(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (programmaticallyChangingCameraCheckButtones)
         return;

      if (sender is CheckButton c)
      {
         if (c == checkSmartcam)
         {
            CamerasStruct temp = simConnection.CamerasData;
            CamerasStruct newCamera = simConnection.CamerasData;
            if (simConnection.CamerasData.IsSmartCamActive)
            {
               newCamera.IsSmartCamActive = false;
            }
            else
            {
               newCamera.IsSmartCamActive = true;
               if (newCamera.CameraState == CameraState.Cockpit)
               {
                  newCamera.SmartCameraTargetIndex = previousCockpitSmartcamTarget;
               }
               else if (newCamera.CameraState == CameraState.External)
               {
                  newCamera.SmartCameraTargetIndex = previousExtSmartcamTarget;
               }
            }
            simConnection.SetCamera(newCamera);
            previousCamera = temp;
         }
         else if (c == checkCockpitPilotSubState)
         {
            if (simConnection.CamerasData.IsCockpitPilotSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CockpitPilotCameraInc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               CameraViewIndex1Pilot pilotCamera = (CameraViewIndex1Pilot)(lastCockpitPilotCamera + 1);
               newCamera.SetCamera(2, 5, 2, 0);
               simConnection.SetCamera(newCamera);
               Thread.Sleep(10);
               newCamera.SetPilotCamera(pilotCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkCockpitInstrumentSubState)
         {
            if (simConnection.CamerasData.IsCockpitInstrumentSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               CameraViewIndex1Instrument instrumentCamera = (CameraViewIndex1Instrument)(lastCockpitInstrumentCamera + 1);
               newCamera.SetInstrumentCamera(instrumentCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkCockpitQuickViewSubState)
         {
            if (simConnection.CamerasData.IsCockpitQuickViewSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               newCamera.SetCockpitQuickViewCamera(lastCockpitQuickViewCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkExternalDefaultSubState)
         {
            if (simConnection.CamerasData.IsExternalDefaultSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               newCamera.SetExternalDefaultCamera(lastExternalDefaultCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkExternalQuickViewSubState)
         {
            if (simConnection.CamerasData.IsExternalQuickViewSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               newCamera.SetExternalQuickViewCamera(lastExternalQuickViewCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkShowcaseDroneSubState)
         {
            if (simConnection.CamerasData.IsShowcaseDroneSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               newCamera.SetShowcaseDroneCamera(lastExternalQuickViewCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkShowcaseFixedSubState)
         {
            if (simConnection.CamerasData.IsShowcaseFixedSubState)
            {
               CamerasStruct temp = simConnection.CamerasData;
               temp.CameraViewTypeIndex1Inc();
               simConnection.SetCamera(temp);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               CamerasStruct newCamera = new CamerasStruct();
               newCamera.SetShowcaseFixedCamera(lastExternalQuickViewCamera);
               simConnection.SetCamera(newCamera);
               previousCamera = temp;
            }
         }
         else if (c == checkCustomCameraState)
         {
            if (simConnection.CamerasData.IsCustomCamera)
            {
               CamerasStruct temp = simConnection.CamerasData;
               int newCamera = previousCustomCamera + 1;
               if (newCamera == 10)
                  newCamera = 0;
               currentCustomCamera = newCamera;
               previousCustomCamera = newCamera;
               SendKeystrokeToSimulator(newCamera);
               previousCamera = temp;
            }
            else
            {
               CamerasStruct temp = simConnection.CamerasData;
               SendKeystrokeToSimulator(previousCustomCamera);
               currentCustomCamera = previousCustomCamera;
               previousCamera = temp;
            }
         }
         else if (c == checkCameraPilotNormal)
         {
            CamerasStruct temp = simConnection.CamerasData;
            CamerasStruct newCamera = new CamerasStruct();
            CameraViewIndex1Pilot pilotCamera = CameraViewIndex1Pilot.Pilot;
            newCamera.SetCamera(2, 5, 2, 0);
            simConnection.SetCamera(newCamera);
            Thread.Sleep(10);
            newCamera.SetPilotCamera(pilotCamera);
            simConnection.SetCamera(newCamera);
            previousCamera = temp;
         }
         else if (c == checkCameraPilotClose)
         {
            CamerasStruct temp = simConnection.CamerasData;
            CamerasStruct newCamera = new CamerasStruct();
            CameraViewIndex1Pilot pilotCamera = CameraViewIndex1Pilot.Close;
            newCamera.SetCamera(2, 5, 2, 0);
            simConnection.SetCamera(newCamera);
            Thread.Sleep(10);
            newCamera.SetPilotCamera(pilotCamera);
            simConnection.SetCamera(newCamera);
            previousCamera = temp;
         }
         else if (c == checkCameraPilotLand)
         {
            CamerasStruct temp = simConnection.CamerasData;
            CamerasStruct newCamera = new CamerasStruct();
            CameraViewIndex1Pilot pilotCamera = CameraViewIndex1Pilot.Landing;
            newCamera.SetCamera(2, 5, 2, 0);
            simConnection.SetCamera(newCamera);
            Thread.Sleep(10);
            newCamera.SetPilotCamera(pilotCamera);
            simConnection.SetCamera(newCamera);
            previousCamera = temp;
         }
         else if (c == checkCameraPilotCoPilot)
         {
            CamerasStruct temp = simConnection.CamerasData;
            CamerasStruct newCamera = new CamerasStruct();
            CameraViewIndex1Pilot pilotCamera = CameraViewIndex1Pilot.Copilot;
            newCamera.SetCamera(2, 5, 2, 0);
            simConnection.SetCamera(newCamera);
            Thread.Sleep(10);
            newCamera.SetPilotCamera(pilotCamera);
            simConnection.SetCamera(newCamera);
            previousCamera = temp;
         }
         else
         {
            if (c.Tag is null)
               return;

            if (c.Tag is string tagStr)
            {
               if (!int.TryParse(tagStr, out int newCamera))
                  return;

               SetCameraNumber(newCamera);
            }
         }
      }

      ActivateFlightSimulator();
   }

   private void SetCameraNumber(int newCameraNumber)
   {
      newCameraNumber--;
      if (simConnection.CamerasData.IsCustomCamera)
      {
         SendKeystrokeToSimulator(newCameraNumber);
      }
      else
      {
         CamerasStruct newCamerasStruct = new CamerasStruct();
         newCamerasStruct.cameraState = simConnection.CamerasData.cameraState;
         newCamerasStruct.cameraSubState = simConnection.CamerasData.cameraSubState;
         newCamerasStruct.cameraViewTypeIndex0 = simConnection.CamerasData.cameraViewTypeIndex0;
         newCamerasStruct.cameraViewTypeIndex1 = newCameraNumber;
         simConnection.SetCamera(newCamerasStruct);
      }
   }

   private void SendKeystrokeToSimulator(int camera)
   {
      if (camera == 10)
         camera = 0;
      string keystrokes = "^" + camera.ToString();
      ActivateFlightSimulator();
      SendKeys.SendWait(keystrokes);
   }

   private void CameraViewButton_Click(object sender, EventArgs e)
   {
      if (sender is null)
         return;

      if (sender is SimpleButton button)
      {
         if (button == btnNextView)
         {
            simConnection.CameraTypeNext();
            CamerasStruct newCamerasStruct = CamerasStruct.FromCameraType(simConnection.CameraType);
            simConnection.SetDataOnSimObject(SimStructDefinition.CamerasStruct, newCamerasStruct);
            txtCameraState.Text = newCamerasStruct.cameraState.ToString();
            txtCameraSubState.Text = newCamerasStruct.cameraSubState.ToString();
            txtCameraIndex0.Text = newCamerasStruct.cameraViewTypeIndex0.ToString();
            txtCameraIndex1.Text = newCamerasStruct.cameraViewTypeIndex1.ToString();
         }
         else if (button == btnPreviousView)
         {
            simConnection.CameraTypePrevious();
            CamerasStruct newCamerasStruct = CamerasStruct.FromCameraType(simConnection.CameraType);
            simConnection.SetDataOnSimObject(SimStructDefinition.CamerasStruct, newCamerasStruct);
            txtCameraState.Text = newCamerasStruct.cameraState.ToString();
            txtCameraSubState.Text = newCamerasStruct.cameraSubState.ToString();
            txtCameraIndex0.Text = newCamerasStruct.cameraViewTypeIndex0.ToString();
            txtCameraIndex1.Text = newCamerasStruct.cameraViewTypeIndex1.ToString();
         }
         else if (button == btnNextSubView)
         {
            var newCamera = simConnection.CamerasData;
            newCamera.CameraViewIndex1++;
            simConnection.SetCamera(newCamera);
            //simConnection.SendEvent(SimEvent.NEXT_SUB_VIEW);
         }
         else if (button == btnPreviousSubView)
         {
            var newCamera = simConnection.CamerasData;
            newCamera.CameraViewIndex1--;
            if (newCamera.CameraViewIndex1 < 0)
               newCamera.CameraViewIndex1 = 0;
            simConnection.SetCamera(newCamera);
            //simConnection.SendEvent(SimEvent.PREV_SUB_VIEW);
         }
      }
      ActivateFlightSimulator();
   }

   private void SimRateButton_Click(object sender, EventArgs e)
   {
      if (sender is null)
         return;

      if (sender is SimpleButton button)
      {
         if (button == btnSimRateInc)
         {
            simConnection.SendEvent(SimEvent.SIM_RATE_INCR);
         }
         else if (button == btnSimRateDec)
         {
            simConnection.SendEvent(SimEvent.SIM_RATE_DECR);
         }
         else if (button == btnSimRateReset)
         {
            double newSimRate = simConnection.TimeData.simulationRate;
            while (newSimRate > 1)
            {
               newSimRate /= 2;
               simConnection.SendEvent(SimEvent.SIM_RATE_DECR);
            }
            while (newSimRate < 1)
            {
               newSimRate *= 2;
               simConnection.SendEvent(SimEvent.SIM_RATE_INCR);
            }
         }
      }
      ActivateFlightSimulator();
   }

   private void btnSetCamera_Click(object sender, EventArgs e)
   {
      try
      {
         int state = int.Parse(txtCameraState.Text);
         int subState = int.Parse(txtCameraSubState.Text);
         int index0 = int.Parse(txtCameraIndex0.Text);
         int index1 = int.Parse(txtCameraIndex1.Text);

         CamerasStruct newCamerasStruct = new CamerasStruct(state, subState, index0, index1);
         simConnection.SetDataOnSimObject(SimStructDefinition.CamerasStruct, newCamerasStruct);
      }
      catch { }

      ActivateFlightSimulator();
   }



   // https://stackoverflow.com/a/2315589/1667195

   [System.Runtime.InteropServices.DllImport("user32.dll")]
   [return: MarshalAs(UnmanagedType.Bool)]
   private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

   [System.Runtime.InteropServices.DllImport("user32.dll")]
   private static extern int SetForegroundWindow(IntPtr hwnd);

   private enum ShowWindowEnum
   {
      Hide = 0,
      ShowNormal = 1,
      ShowMinimized = 2,
      ShowMaximized = 3,
      Maximize = 3,
      ShowNormalNoActivate = 4,
      Show = 5,
      Minimize = 6,
      ShowMinNoActivate = 7,
      ShowNoActivate = 8,
      Restore = 9,
      ShowDefault = 10,
      ForceMinimized = 11
   };

   public void BringMainWindowToFront(string processName)
   {
      // get the process
      var bProcess = Process.GetProcessesByName(processName).FirstOrDefault();

      // check if the process is running
      if (bProcess != null)
      {
         // check if the window is hidden / minimized
         if (bProcess.MainWindowHandle == IntPtr.Zero)
         {
            // the window is hidden so try to restore it before setting focus.
            ShowWindow(bProcess.Handle, ShowWindowEnum.Restore);
         }

         // set user the focus to the window
         SetForegroundWindow(bProcess.MainWindowHandle);
      }
      else
      {
         // the process is not running, so start it
         //Process.Start(processName);
      }
   }

   private void TrackFlaps_ValueChanged(object sender, EventArgs e)
   {
      trackFlaps.Value = -1 * simConnection.AircraftControlData.flapsHandleIndex;
   }

   private void SmartcamCycleButton_Click(object sender, EventArgs e)
   {
      if (sender is null)
         return;

      if (!simConnection.CamerasData.IsSmartCamActive)
      {
         simConnection.SetSmartcamera(true);
         //return;
      }

      if (sender is Button button)
      {
         if (sender == btnNextSmartcam)
         {
            CamerasStruct newCamera = simConnection.CamerasData;
            newCamera.SmartCameraTargetIndex++;
            simConnection.SetCamera(newCamera);
         }
         else if (sender == btnPreviousSmartcam)
         {
            CamerasStruct newCamera = simConnection.CamerasData;
            newCamera.SmartCameraTargetIndex--;
            if (newCamera.SmartCameraTargetIndex < 0)
               newCamera.SmartCameraTargetIndex = 0;
            simConnection.SetCamera(newCamera);
         }
      }
   }
}
