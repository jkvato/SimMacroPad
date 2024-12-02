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

   private void SimConnection_DataReceivedFromSim(object sender, MacroSimStruct macroSimStruct)
   {
      //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Data received from simulator");

      macroPadDevice.UpdateData(macroSimStruct);

      // Update UI via Invoke
      InvokeAction(form =>
      {
         string newFormText = $"MacroSimPad - {macroSimStruct.Title}";
         if (Text != newFormText)
         {
            Text = newFormText;
         }

         // COM1
         if (macroSimStruct.com1standbyIdent == "")
            form.lblCom1Standby.Text = "Standby";
         else
            form.lblCom1Standby.Text = macroSimStruct.com1standbyIdent + " " + macroSimStruct.com1standbyType;

         if (macroSimStruct.com1activeIdent == "")
            form.lblCom1Active.Text = "Active";
         else
            form.lblCom1Active.Text = macroSimStruct.com1activeIdent + " " + macroSimStruct.com1activeType;

         form.lblCom1StandbyValue.Text = string.Format("{0:000.000}", macroSimStruct.com1standby);
         form.lblCom1ActiveValue.Text = string.Format("{0:000.000}", macroSimStruct.com1active);

         // COM2
         if (macroSimStruct.com2standbyIdent == "")
            form.lblCom2Standby.Text = "Standby";
         else
            form.lblCom2Standby.Text = macroSimStruct.com2standbyIdent + " " + macroSimStruct.com2standbyType;

         if (macroSimStruct.com2activeIdent == "")
            form.lblCom2Active.Text = "Active";
         else
            form.lblCom2Active.Text = macroSimStruct.com2activeIdent + " " + macroSimStruct.com2activeType;

         form.lblCom2StandbyValue.Text = string.Format("{0:000.000}", macroSimStruct.com2standby);
         form.lblCom2ActiveValue.Text = string.Format("{0:000.000}", macroSimStruct.com2active);

         // NAV1
         if (macroSimStruct.nav1Ident == "")
            form.lblNav1Active.Text = "Active";
         else
            form.lblNav1Active.Text = macroSimStruct.nav1Ident + " " + macroSimStruct.nav1Name;

         form.lblNav1StandbyValue.Text = string.Format("{0:000.00}", macroSimStruct.nav1standby);
         form.lblNav1ActiveValue.Text = string.Format("{0:000.00}", macroSimStruct.nav1active);

         // NAV2
         if (macroSimStruct.nav2Ident == "")
            form.lblNav2Active.Text = "Active";
         else
            form.lblNav2Active.Text = macroSimStruct.nav2Ident + " " + macroSimStruct.nav2Name;

         form.lblNav2StandbyValue.Text = string.Format("{0:000.00}", macroSimStruct.nav2standby);
         form.lblNav2ActiveValue.Text = string.Format("{0:000.00}", macroSimStruct.nav2active);

         // AP Heading
         form.lblHeadingValue.Text = string.Format("{0:000}", macroSimStruct.apHeading);

         // AP Course
         form.lblCourseValue.Text = string.Format("{0:000}", macroSimStruct.apNav1Obs);

         // AP Altitude
         form.lblAltitudeValue.Text = string.Format("{0:00000}", macroSimStruct.apAltitude);

         // AP Vertical Speed
         form.lblVerticalSpeedValue.Text = string.Format("{0:0000}", macroSimStruct.apVerticalSpeed);

         // Transponder
         form.lblTransponder.Text = string.Format("{0:0000}", macroSimStruct.transponderCode);

         // Lights
         form.lblBeaconLight.Text = "Beacon " + (macroSimStruct.lightBeacon == 1 ? "On" : "Off");
         form.lblCabinLight.Text = "Cabin " + (macroSimStruct.lightCabin == 1 ? "On" : "Off");
         form.lblGlareshieldLight.Text = "Glareshield " + (macroSimStruct.lightGlareshield == 1 ? "On" : "Off");
         form.lblLandingLight.Text = "Landing " + (macroSimStruct.lightLanding == 1 ? "On" : "Off");
         form.lblLogoLight.Text = "Logo " + (macroSimStruct.lightLogo == 1 ? "On" : "Off");
         form.lblNavLight.Text = "Nav " + (macroSimStruct.lightNav == 1 ? "On" : "Off");
         form.lblPanelLight.Text = "Panel " + (macroSimStruct.lightPanel == 1 ? "On" : "Off");
         form.lblPedestralLight.Text = "Pedestral " + (macroSimStruct.lightPedestral == 1 ? "On" : "Off");
         form.lblRecognitionLight.Text = "Recognition " + (macroSimStruct.lightRecognition == 1 ? "On" : "Off");
         form.lblStrobeLight.Text = "Strobe " + (macroSimStruct.lightStrobe == 1 ? "On" : "Off");
         form.lblTaxiLight.Text = "Taxi " + (macroSimStruct.lightTaxi == 1 ? "On" : "Off");
         form.lblWingLight.Text = "Wing " + (macroSimStruct.lightWing == 1 ? "On" : "Off");

         form.lblLightOnStates.Text = macroSimStruct.lightOnStates.ToString();
      });
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

   private void LblLight_DoubleClick(object sender, EventArgs e)
   {
      if (sender is Label label)
      {
         if (label == lblBeaconLight)
            simConnection.SendEvent(SimEvents.TOGGLE_BEACON_LIGHTS);
         else if (label == lblCabinLight)
            simConnection.SendEvent(SimEvents.TOGGLE_CABIN_LIGHTS);
         else if (label == lblGlareshieldLight)
            simConnection.SendEvent(SimEvents.GLARESHIELD_LIGHTS_TOGGLE);
         else if (label == lblLandingLight)
            simConnection.SendEvent(SimEvents.LANDING_LIGHTS_TOGGLE);
         else if (label == lblLogoLight)
            simConnection.SendEvent(SimEvents.TOGGLE_LOGO_LIGHTS);
         else if (label == lblNavLight)
            simConnection.SendEvent(SimEvents.TOGGLE_NAV_LIGHTS);
         else if (label == lblPanelLight)
            simConnection.SendEvent(SimEvents.PANEL_LIGHTS_TOGGLE);
         else if (label == lblPedestralLight)
            simConnection.SendEvent(SimEvents.PEDESTRAL_LIGHTS_TOGGLE);
         else if (label == lblRecognitionLight)
            simConnection.SendEvent(SimEvents.TOGGLE_RECOGNITION_LIGHTS);
         else if (label == lblStrobeLight)
            simConnection.SendEvent(SimEvents.STROBES_TOGGLE);
         else if (label == lblTaxiLight)
            simConnection.SendEvent(SimEvents.TOGGLE_TAXI_LIGHTS);
         else if (label == lblWingLight)
            simConnection.SendEvent(SimEvents.TOGGLE_WING_LIGHTS);
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
   private void RefreshSerialPortsToolStripMenuItem_Click(object sender, EventArgs e)
   {
      GetComPorts();
   }
}
