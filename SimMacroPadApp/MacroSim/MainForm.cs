using System.ComponentModel;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MacroSim.MacroPadDevice;
using MacroSim.SimConnection;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.AxHost;
using static MacroSim.SimConnection.SimConnection;

namespace MacroSim;

public partial class MainForm : Form
{
   private readonly SimConnection.SimConnection simConnection;
   private readonly MacroPadDevice.MacroPadDevice macroPadDevice;

   private readonly System.Windows.Forms.Timer timer;

   private bool suppressLightButtonCheckChangedEvent = true;

   public MainForm()
   {
      InitializeComponent();

      simConnection = new SimConnection.SimConnection();
      simConnection.DataReceived += SimConnection_DataReceivedFromSim;

      macroPadDevice = new MacroPadDevice.MacroPadDevice(simConnection);
      macroPadDevice.EventProcessed += MacroPadDevice_EventProcessed;

      lblVerticalSpeedValue.AutoSize = false;

      GetComPorts();

      timer = new System.Windows.Forms.Timer();
      timer.Interval = 1000;
      timer.Tick += Timer_Tick;
      timer.Start();
   }

   private void Timer_Tick(object? sender, EventArgs e)
   {
      if (!simConnection.IsConnected)
      {
         try
         {
            simConnection.ConnectToSim(Handle);
         }
         catch { }
      }

      UpdateConnectionStatus();
   }

   private void MacroPadDevice_EventProcessed(object sender, EventProcessedEventArgs e)
   {
      InvokeAction(form =>
      {
         form.lblMacroPadState.Text = e.NewState.ToString();
         form.txtOutput.AppendText($"Component {e.Component}, event {e.Event} \r\n");
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
            form.lblHeadingValue.Text = string.Format("{0:000}", avionicsStruct.apHeading);

            // AP Course
            form.lblCourseValue.Text = string.Format("{0:000}", avionicsStruct.apNav1Obs);

            // AP Altitude
            form.lblAltitudeValue.Text = string.Format("{0:00000}", avionicsStruct.apAltitude);

            // AP Vertical Speed
            form.lblVerticalSpeedValue.Text = string.Format("{0:0000}", avionicsStruct.apVerticalSpeed);

            // Transponder
            form.lblTransponder.Text = string.Format("{0:0000}", avionicsStruct.transponderCode);
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
            lblSerialPortStatus.Text = $"Serial port is connected to {macroPadDevice.SerialPort.PortName}";
         }
         else
         {
            lblSerialPortStatus.Text = "Serial port is disconnected";
         }

         if (simConnection.IsConnected)
         {
            connectToSimToolStripMenuItem.Text = "Disconnect from Sim";
            lblSimConnectionStatus.Text = "Simulator is connected";
         }
         else
         {
            connectToSimToolStripMenuItem.Text = "Connect to Sim";
            lblSimConnectionStatus.Text = "Disconnected from Sim";
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
            simConnection.SendEvent(SimEvents.TOGGLE_BEACON_LIGHTS);
         else if (checkBox == checkCabinLight)
            simConnection.SendEvent(SimEvents.TOGGLE_CABIN_LIGHTS);
         else if (checkBox == checkGlareshieldLight)
            simConnection.SendEvent(SimEvents.GLARESHIELD_LIGHTS_TOGGLE);
         else if (checkBox == checkLandingLight)
            simConnection.SendEvent(SimEvents.LANDING_LIGHTS_TOGGLE);
         else if (checkBox == checkLogoLight)
            simConnection.SendEvent(SimEvents.TOGGLE_LOGO_LIGHTS);
         else if (checkBox == checkNavLight)
            simConnection.SendEvent(SimEvents.TOGGLE_NAV_LIGHTS);
         else if (checkBox == checkPanelLight)
            simConnection.SendEvent(SimEvents.PANEL_LIGHTS_TOGGLE);
         else if (checkBox == checkPedestralLight)
            simConnection.SendEvent(SimEvents.PEDESTRAL_LIGHTS_TOGGLE);
         else if (checkBox == checkRecognitionLight)
            simConnection.SendEvent(SimEvents.TOGGLE_RECOGNITION_LIGHTS);
         else if (checkBox == checkStrobeLight)
            simConnection.SendEvent(SimEvents.STROBES_TOGGLE);
         else if (checkBox == checkTaxiLight)
            simConnection.SendEvent(SimEvents.TOGGLE_TAXI_LIGHTS);
         else if (checkBox == checkWingLight)
            simConnection.SendEvent(SimEvents.TOGGLE_WING_LIGHTS);
      }

   }

   private void RefreshSerialPortsToolStripMenuItem_Click(object sender, EventArgs e)
   {
      GetComPorts();
   }
}
