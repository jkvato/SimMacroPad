using System.ComponentModel;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using FSUIPC;
using MacroSim.Fsuipc;
using MacroSim.MacroPadDevice;
using MacroSim.Properties;
using MacroSim.SimConnection;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.AxHost;
using static MacroSim.SimConnection.SimConnection;

namespace MacroSim;

public partial class MainForm : Form
{
   private readonly SimConnection.SimConnection simConnection;
   private readonly MacroPadDevice.MacroPadDevice macroPadDevice;

   private readonly System.Windows.Forms.Timer timerConnection;
   private readonly System.Windows.Forms.Timer timerFsuipcProcess;

   private bool suppressLightButtonCheckChangedEvent = true;
   private bool suppressAutopilotButtonCheckChangedEvent = true;
   private bool suppressCameraButtonCheckChangedEvent = true;

   private FsuipcConnection fsuipcConnection;

   private CamerasStruct previousCamera;

   public MainForm()
   {
      InitializeComponent();

      previousCamera.cameraState = 2;
      previousCamera.cameraSubstate = 1;
      previousCamera.cameraViewTypeIndex0 = 1;
      previousCamera.cameraViewTypeIndex1 = 1;

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
      fsuipcConnection = new FsuipcConnection();

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
   }

   private void MacroPadDevice_EventProcessed(object sender, EventProcessedEventArgs e)
   {
      InvokeAction(form =>
      {
         form.lblMacroPadState.Text = e.NewState.ToString();
         //form.txtOutput.AppendText($"Component {e.Component}, event {e.Event} \r\n");
      });
      UpdateConnectionStatus();
   }

   private void SimConnection_DataReceivedFromSim(object sender, object structure)
   {
      //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Data received from simulator");

      if (structure is AvionicsStruct avionicsStruct)
      {
         macroPadDevice.UpdateData(avionicsStruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            string newFormText = $"MacroSimPad - {avionicsStruct.Title}";
            if (Text != newFormText)
            {
               Text = newFormText;
            }

            // COM1
            if (avionicsStruct.com1standbyIdent == "")
               form.lblCom1Standby.Text = "Standby";
            else
               form.lblCom1Standby.Text = avionicsStruct.com1standbyIdent + " " + avionicsStruct.com1standbyType;

            if (avionicsStruct.com1activeIdent == "")
               form.lblCom1Active.Text = "Active";
            else
               form.lblCom1Active.Text = avionicsStruct.com1activeIdent + " " + avionicsStruct.com1activeType;

            form.lblCom1StandbyValue.Text = string.Format("{0:000.000}", avionicsStruct.com1standby);
            form.lblCom1ActiveValue.Text = string.Format("{0:000.000}", avionicsStruct.com1active);

            // COM2
            if (avionicsStruct.com2standbyIdent == "")
               form.lblCom2Standby.Text = "Standby";
            else
               form.lblCom2Standby.Text = avionicsStruct.com2standbyIdent + " " + avionicsStruct.com2standbyType;

            if (avionicsStruct.com2activeIdent == "")
               form.lblCom2Active.Text = "Active";
            else
               form.lblCom2Active.Text = avionicsStruct.com2activeIdent + " " + avionicsStruct.com2activeType;

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

            // Fuel
            form.lblTotalFuelPct.Text = string.Format("Total Fuel: {0:00.0}%", avionicsStruct.TotalFuelPct);
            form.lblFuelDumpSwitch.Text = avionicsStruct.FuelDumpSwitch ? "DUMP" : "off";
            form.btnFuelDump.Enabled = avionicsStruct.FuelDumpActive;

            suppressAutopilotButtonCheckChangedEvent = true;
            form.checkApMaster.Checked = avionicsStruct.ApMasterEngaged;
            form.checkApAltHold.Checked = avionicsStruct.ApAltitudeHoldEngaged;
            form.checkApHdgHold.Checked = avionicsStruct.ApHeadingHoldEngaged;
            form.checkApVsHold.Checked = avionicsStruct.ApVerticalSpeedHoldEngaged;
            form.checkApNavHold.Checked = avionicsStruct.ApNav1HoldEngaged;
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
      else if (structure is TrimStruct trimStruct)
      {
         macroPadDevice.UpdateData(trimStruct);

         // Update UI via Invoke
         InvokeAction(form =>
         {
            form.txtElevatorTrimMin.Text = string.Format("{0:000.00}", trimStruct.ElevatorTrimMinDegrees);
            form.txtElevatorTrimNeutral.Text = string.Format("{0:000.00}", trimStruct.ElevatorTrimNeutralDegrees);
            form.txtElevatorTrim.Text = string.Format("{0:000.00}", trimStruct.ElevatorTrimPositionDegrees);
            form.txtElevatorTrimMax.Text = string.Format("{0:000.00}", trimStruct.ElevatorTrimMaxDegrees);

            form.txtAileronTrimDisabled.Text = trimStruct.AileronTrimDisabled ? "Disabled" : "Enabled";
            form.txtAileronTrimMin.Text = string.Format("{0:000.00}", trimStruct.AileronTrimMinDegrees);
            form.txtAileronTrimPosition.Text = string.Format("{0:000.00}", trimStruct.AileronTrimPositionDegrees);
            form.txtAileronTrimMax.Text = string.Format("{0:000.00}", trimStruct.AileronTrimMaxDegrees);

            form.txtRudderTrimDisabled.Text = trimStruct.RudderTrimDisabled ? "Disabled" : "Enabled";
            form.txtRudderTrimMin.Text = string.Format("{0:000.00}", trimStruct.RudderTrimMinDegrees);
            form.txtRudderTrimPosition.Text = string.Format("{0:000.00}", trimStruct.RudderTrimPositionDegrees);
            form.txtRudderTrimMax.Text = string.Format("{0:000.00}", trimStruct.RudderTrimMaxDegrees);
         });
      }
      else if (structure is CamerasStruct camerasStruct)
      {
         macroPadDevice.UpdateData(camerasStruct);

         //previousCamera = camerasStruct;

         // Update UI via Invoke
         InvokeAction(form =>
         {
            suppressCameraButtonCheckChangedEvent = true;
            form.checkCamera1.Checked = camerasStruct.IsInstrumentCamera1Active;
            form.checkCamera2.Checked = camerasStruct.IsInstrumentCamera2Active;
            form.checkCamera3.Checked = camerasStruct.IsInstrumentCamera3Active;
            form.checkCamera4.Checked = camerasStruct.IsInstrumentCamera4Active;
            form.checkCamera5.Checked = camerasStruct.IsInstrumentCamera5Active;
            form.checkCamera6.Checked = camerasStruct.IsInstrumentCamera6Active;
            form.checkCamera7.Checked = camerasStruct.IsInstrumentCamera7Active;
            form.checkCamera8.Checked = camerasStruct.IsInstrumentCamera8Active;
            form.checkCamera9.Checked = camerasStruct.IsInstrumentCamera9Active;
            form.checkCamera10.Checked = camerasStruct.IsInstrumentCamera10Active;
            form.checkCameraPilotNormal.Checked = camerasStruct.IsPilotNormalCameraActive;
            form.checkCameraPilotClose.Checked = camerasStruct.IsPilotCloseCameraActive;
            form.checkCameraPilotLand.Checked = camerasStruct.IsPilotLandingCameraActive;
            form.checkCameraPilotCoPilot.Checked = camerasStruct.IsPilotCoPilotCameraActive;

            form.lblCameraCurrentView.Text = $"{camerasStruct.cameraViewTypeIndex0}, {camerasStruct.cameraViewTypeIndex1}, {camerasStruct.cameraState}, {camerasStruct.cameraSubstate}";

            suppressCameraButtonCheckChangedEvent = false;
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
      for (int i = macroPadToolStripMenuItem.DropDownItems.Count - 1; i >= 0; i--)
      {
         var item = macroPadToolStripMenuItem.DropDownItems[i];
         if (item is ToolStripMenuItem menuItem)
         {
            if (menuItem.Text.StartsWith("COM", StringComparison.CurrentCultureIgnoreCase))
            {
               macroPadToolStripMenuItem.DropDownItems.RemoveAt(i);
            }
         }
      }

      // Add new list of com ports to the menu.
      foreach (string port in portList)
      {
         ToolStripMenuItem item = new ToolStripMenuItem(port);   // create a new menu item
         item.Click += ComPortsStripMenuItem_Click;  // add event handler
         macroPadToolStripMenuItem.DropDownItems.Add(item);  // add to the menu of COM ports
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
            lblSerialPortStatus.Text = $"Serial: {macroPadDevice.SerialPort.PortName}";
         }
         else
         {
            lblSerialPortStatus.Text = $"Serial: Disconnected";
         }

         if (fsuipcConnection.IsConnected)
         {
            fsuipcConnectToolStripMenuItem.Text = "Disconnect FSUIPC";
            lblFsuipcStatus.Text = "FSUIPC: Connected";
         }
         else
         {
            fsuipcConnectToolStripMenuItem.Text = "Connect FSUIPC";
            lblFsuipcStatus.Text = "FSUIPC: Disconnected";
         }

         if (simConnection.IsConnected)
         {
            simConnectToolStripMenuItem.Text = "Disconnect SimConnect";
            lblSimConnectStatus.Text = "SimConnect: Connected";
         }
         else
         {
            simConnectToolStripMenuItem.Text = "Connect SimConnect";
            lblSimConnectStatus.Text = "SimConnect: Disconnected";
         }
      });
   }

   private void LightButton_CheckedChanged(object sender, EventArgs e)
   {
      if (suppressLightButtonCheckChangedEvent)
      {
         return;
      }

      if (sender is CheckBox checkBox)
      {
         if (checkBox == checkBeaconLight)
            simConnection.SendEvent(SimEvent.TOGGLE_BEACON_LIGHTS);
         else if (checkBox == checkCabinLight)
            simConnection.SendEvent(SimEvent.TOGGLE_CABIN_LIGHTS);
         else if (checkBox == checkGlareshieldLight)
            simConnection.SendEvent(SimEvent.GLARESHIELD_LIGHTS_TOGGLE);
         else if (checkBox == checkLandingLight)
            simConnection.SendEvent(SimEvent.LANDING_LIGHTS_TOGGLE);
         else if (checkBox == checkLogoLight)
            simConnection.SendEvent(SimEvent.TOGGLE_LOGO_LIGHTS);
         else if (checkBox == checkNavLight)
            simConnection.SendEvent(SimEvent.TOGGLE_NAV_LIGHTS);
         else if (checkBox == checkPanelLight)
            simConnection.SendEvent(SimEvent.PANEL_LIGHTS_TOGGLE);
         else if (checkBox == checkPedestralLight)
            simConnection.SendEvent(SimEvent.PEDESTRAL_LIGHTS_TOGGLE);
         else if (checkBox == checkRecognitionLight)
            simConnection.SendEvent(SimEvent.TOGGLE_RECOGNITION_LIGHTS);
         else if (checkBox == checkStrobeLight)
            simConnection.SendEvent(SimEvent.STROBES_TOGGLE);
         else if (checkBox == checkTaxiLight)
            simConnection.SendEvent(SimEvent.TOGGLE_TAXI_LIGHTS);
         else if (checkBox == checkWingLight)
            simConnection.SendEvent(SimEvent.TOGGLE_WING_LIGHTS);
      }

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
      if (sender is Button button)
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
   }

   private void FmsButton_Click(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (sender is Button button)
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
   }

   private void BtnPause_Click(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (sender is Button btnPause)
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
   }

   private void FmsButton_MouseWheel(object? sender, MouseEventArgs e)
   {
      if (sender is null)
         return;

      if (sender is Button button)
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

      if (sender is Button button)
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
               fsuipcConnection.SendPresetEvent("C_172_AP_NOSE_UP");
            else
               fsuipcConnection.SendPresetEvent("C_172_AP_NOSE_DN");
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

      if (sender is CheckBox checkBox)
      {
         if (checkBox == checkApMaster)
         {
            simEvent = SimEvent.AP_MASTER;
         }
         else if (checkBox == checkApHdgHold)
         {
            simEvent = SimEvent.AP_HDG_HOLD;
         }
         else if (checkBox == checkApAprHold)
         {
            simEvent = SimEvent.AP_APR_HOLD;
         }
         else if (checkBox == checkApBcHold)
         {
            simEvent = SimEvent.AP_BC_HOLD;
         }
         else if (checkBox == checkApNavHold)
         {
            simEvent = SimEvent.AP_NAV1_HOLD;
         }
         else if (checkBox == checkApFd)
         {
            simEvent = SimEvent.TOGGLE_FLIGHT_DIRECTOR;
         }
         else if (checkBox == checkApYd)
         {
            simEvent = SimEvent.YAW_DAMPER_TOGGLE;
         }
         else if (checkBox == checkApAltHold)
         {
            simEvent = SimEvent.AP_ALT_HOLD;
         }
         else if (checkBox == checkApVsHold)
         {
            simEvent = SimEvent.AP_VS_HOLD;
         }
         else if (checkBox == checkApVnv)
         {
            simEvent = SimEvent.NONE;
         }

         if (simEvent != SimEvent.NONE)
         {
            simConnection.SendEvent(simEvent);
         }
      }
   }

   private void btnAddFuel_Click(object sender, EventArgs e)
   {
      fsuipcConnection.SendPresetEvent("ADD_FUEL");
   }

   private void btnFuelDump_Click(object sender, EventArgs e)
   {
      fsuipcConnection.SendPresetEvent("FUEL_DUMP_TOGGLE");
   }

   private void CameraButton_CheckChanged(object sender, EventArgs e)
   {
      if (sender == null)
         return;

      if (suppressCameraButtonCheckChangedEvent)
         return;

      string previousCalcCode =
         $"{previousCamera.cameraState} (>A:CAMERA STATE,Enum) " +
         $"{previousCamera.cameraSubstate} (>A:CAMERA SUBSTATE,Enum) " +
         $"{previousCamera.cameraViewTypeIndex0} (>A:CAMERA VIEW TYPE AND INDEX:0,Enum) " +
         $"{previousCamera.cameraViewTypeIndex1} (>A:CAMERA VIEW TYPE AND INDEX:1,Enum)";

      if (sender is CheckBox checkBox)
      {
         if (checkBox == checkCamera1)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera1Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_1");
            previousCamera = temp;
         }
         if (checkBox == checkCamera2)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera2Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_2");
            previousCamera = temp;
         }
         if (checkBox == checkCamera3)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera3Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_3");
            previousCamera = temp;
         }
         if (checkBox == checkCamera4)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera4Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_4");
            previousCamera = temp;
         }
         if (checkBox == checkCamera5)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera5Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_5");
            previousCamera = temp;
         }
         if (checkBox == checkCamera6)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera6Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_6");
            previousCamera = temp;
         }
         if (checkBox == checkCamera7)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera7Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_7");
            previousCamera = temp;
         }
         if (checkBox == checkCamera8)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera8Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_8");
            previousCamera = temp;
         }
         if (checkBox == checkCamera9)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera9Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_9");
            previousCamera = temp;
         }
         if (checkBox == checkCamera10)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsInstrumentCamera10Active)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("VIEW_CAMERA_SELECT_10");
            previousCamera = temp;
         }
         if (checkBox == checkCameraPilotNormal)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsPilotNormalCameraActive)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("Pilot_View_-_Normal");
            previousCamera = temp;
         }
         if (checkBox == checkCameraPilotClose)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsPilotCloseCameraActive)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("Pilot_View_-_Close");
            previousCamera = temp;
         }
         if (checkBox == checkCameraPilotLand)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsPilotLandingCameraActive)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("Pilot_View_-_Landing");
            previousCamera = temp;
         }
         if (checkBox == checkCameraPilotCoPilot)
         {
            CamerasStruct temp = simConnection.CamerasData;
            if (simConnection.CamerasData.IsPilotCoPilotCameraActive)
               FsuipcConnection.SendCalculatorCode(previousCalcCode);
            else
               fsuipcConnection.SendPresetEvent("Pilot_View_-_Copilot");
            previousCamera = temp;
         }
      }
   }
}
