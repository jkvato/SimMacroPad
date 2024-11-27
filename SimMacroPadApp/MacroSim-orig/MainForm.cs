using Microsoft.FlightSimulator.SimConnect;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MacroSim
{
   public partial class MainForm : Form
   {
      private const int WM_USER_SIMCONNECT = 0x402;

      private SimConnect? simconnect;
      private readonly System.Windows.Forms.Timer timer;
      private readonly SerialPort serialPort1 = new SerialPort();
      private int baudRate = 115200;

      private MacroPadState state = MacroPadState.None;

      private readonly Font APEnabledFont;
      private readonly Font APDisabledFont;

      public MainForm()
      {
         InitializeComponent();
         com1standby.Value = 123.456m;
         //com1standby.Selection = FrequencySelection.MHz;
         com1standby.SetNewSize();
         com1active.SetNewSize();
         com2standby.SetNewSize();
         com2active.SetNewSize();
         nav1standby.SetNewSize();
         nav1active.SetNewSize();
         nav2standby.SetNewSize();
         nav2active.SetNewSize();
         heading.SetNewSize();
         course.SetNewSize();
         altitude.SetNewSize();
         verticalspeed.SetNewSize();
         System.Diagnostics.Debug.WriteLine($"com1standby.Value is {com1standby.Value}");

         APEnabledFont = new Font("Segoe", 12, FontStyle.Bold);
         APDisabledFont = new Font("Segoe", 12, FontStyle.Regular);

         setTextDelegate = new SetTextDelegate(SetStateLabel);

         serialPort1.DataReceived += SerialPort1_DataReceived;

         connectToolStripMenuItem.Enabled = true;

         simconnect = null;

         timer = new System.Windows.Forms.Timer();
         timer.Interval = 100;
         //timer.Interval = 2500;
         timer.Enabled = false;
         timer.Tick += Timer_Tick;

         GetComPorts();
      }

      private void Timer_Tick(object? sender, EventArgs e)
      {
         try
         {
            if (simconnect != null)
            {
               simconnect.RequestDataOnSimObjectType(SimDataRequests.Request1, SimDefinitions.MacroSimStruct, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            }
         }
         catch (Exception ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
         }
      }

      private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (simconnect == null)
         {
            ConnectToSim();
         }
         else
         {
            DisconnectFromSim();
         }
      }

      private bool ConnectToSim()
      {
         if (simconnect == null)
         {
            try
            {
               simconnect = new SimConnect("Managed Data Request", Handle, WM_USER_SIMCONNECT, null, 0);
               connectedToSimLabel.Text = "Connected to sim";
               connectToolStripMenuItem.Text = "Disconnect from Sim";
               InitDataRequest();
               return true;
            }
            catch (COMException)
            {
               connectedToSimLabel.Text = "Disconnected from sim";
               connectToolStripMenuItem.Text = "Connect to Sim";
               return false;
            }
         }
         else
         {
            return true;
         }
      }

      private void DisconnectFromSim()
      {
         if (simconnect != null)
         {
            simconnect.Dispose();
            simconnect = null;
            connectedToSimLabel.Text = "Disconnected from sim";
            connectToolStripMenuItem.Text = "Connect to Sim";
         }
         timer.Stop();
      }

      protected override void DefWndProc(ref Message m)
      {
         if (m.Msg == WM_USER_SIMCONNECT)
         {
            try
            {
               if (simconnect != null)
               {
                  simconnect.ReceiveMessage();
               }
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


      private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         DisconnectFromSim();
      }

      private void InitDataRequest()
      {
         try
         {
            if (simconnect != null)
            {
               simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
               simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);
               simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(Simconnect_OnRecvException);

               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT ALTITUDE LOCK VAR", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT VERTICAL HOLD VAR", "feet per minute", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT HEADING LOCK DIR", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV OBS:1", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT MASTER", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT ALTITUDE LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT VERTICAL HOLD", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT HEADING LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "AUTOPILOT NAV1 LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM ACTIVE FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "COM STANDBY FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV NAME:1", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "NAV NAME:2", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

               // NAV IDENT
               // NAV NAME


               //simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               //simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               //simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               //simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Plane Heading Degrees True", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               //simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "Ground Altitude", "meters", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
               simconnect.RegisterDataDefineStruct<MacroSimStruct>(SimStructures.MacroSimStruct);
               simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(Simconnect_OnRecvSimobjectDataBytype);
            }
         }
         catch (COMException)
         {
         }
      }

      private void Simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
      {
         if (data.dwRequestID == 0)
         {
            MacroSimStruct s = (MacroSimStruct)data.dwData[0];

            lblTitle.Text = s.Title.Trim();

            com1standby.Value = Convert.ToDecimal(s.com1standby);
            com1active.Value = Convert.ToDecimal(s.com1active);
            com2standby.Value = Convert.ToDecimal(s.com2standby);
            com2active.Value = Convert.ToDecimal(s.com2active);
            nav1standby.Value = Convert.ToDecimal(s.nav1standby);
            nav1active.Value = Convert.ToDecimal(s.nav1active);
            nav2standby.Value = Convert.ToDecimal(s.nav2standby);
            nav2active.Value = Convert.ToDecimal(s.nav2active);
            altitude.Value = s.apAltitude;
            verticalspeed.Value = s.apVerticalSpeed;
            heading.Value = s.apHeading;
            course.Value = s.apNav1Obs;

            //System.Diagnostics.Debug.WriteLine($"TITLE: {s.Title}");
            //System.Diagnostics.Debug.WriteLine($"AP_MASTER: {s.apMaster}");

            //System.Diagnostics.Debug.WriteLine($"COM1_IDENT: {s.com1activeIdent}");
            //System.Diagnostics.Debug.WriteLine($"COM2_IDENT: {s.com2activeIdent}");
            //System.Diagnostics.Debug.WriteLine($"COM1_TYPE: {s.com1activeType}");
            //System.Diagnostics.Debug.WriteLine($"COM2_TYPE: {s.com2activeType}");
            //System.Diagnostics.Debug.WriteLine($"NAV1_IDENT: {s.nav1Ident}");
            //System.Diagnostics.Debug.WriteLine($"NAV2_IDENT: {s.nav2Ident}");
            //System.Diagnostics.Debug.WriteLine($"NAV1_NAME: {s.nav1Name}");
            //System.Diagnostics.Debug.WriteLine($"NAV2_NAME: {s.nav2Name}");

            s.com1activeIdent = s.com1activeIdent.Trim();
            s.com2activeIdent = s.com2activeIdent.Trim();
            s.com1standbyIdent = s.com1standbyIdent.Trim();
            s.com2standbyIdent = s.com2standbyIdent.Trim();

            try
            {
               if (string.IsNullOrWhiteSpace(s.com1standbyType) || s.com1standbyType == "ACTIVE")
               {
                  lblCom1Standby.Text = "COM1 Standby";
               }
               else
               {
                  lblCom1Standby.Text = $"COM1 Standby: {s.com1standbyIdent} {s.com1standbyType}";
               }

               if (string.IsNullOrWhiteSpace(s.com1activeType) || s.com1activeType == "ACTIVE")
               {
                  lblCom1Standby.Text = "COM1 Active";
               }
               else
               {
                  lblCom1Active.Text = $"COM1 Active: {s.com1activeIdent} {s.com1activeType}";
               }

               if (string.IsNullOrWhiteSpace(s.com2standbyType) || s.com2standbyType == "ACTIVE")
               {
                  lblCom2Standby.Text = "COM2 Standby";
               }
               else
               {
                  lblCom2Standby.Text = $"COM2 Standby: {s.com2standbyIdent} {s.com2standbyType}";
               }

               if (string.IsNullOrWhiteSpace(s.com2activeType) || s.com2activeType == "ACTIVE")
               {
                  lblCom2Standby.Text = "COM2 Active";
               }
               else
               {
                  lblCom2Active.Text = $"COM2 Active: {s.com2activeIdent} {s.com2activeType}";
               }

               lblNav1Active.Text = $"NAV1 Active: {s.nav1Ident} {s.nav1Name}";
               lblNav2Active.Text = $"NAV2 Active: {s.nav2Ident} {s.nav2Name}";

               if (s.apMaster == 0)
               {
                  lblAPMaster.ForeColor = Color.Gray;
                  lblAPMaster.Font = APDisabledFont;
               }
               else
               {
                  lblAPMaster.ForeColor = Color.Red;
                  lblAPMaster.Font = APEnabledFont;
               }

               if (s.apAltHold == 0)
               {
                  lblAltHold.ForeColor = Color.Gray;
                  lblAltHold.Font = APDisabledFont;
               }
               else
               {
                  lblAltHold.ForeColor = Color.Red;
                  lblAltHold.Font = APEnabledFont;
               }

               if (s.apVsHold == 0)
               {
                  lblVSHold.ForeColor = Color.Gray;
                  lblVSHold.Font = APDisabledFont;
               }
               else
               {
                  lblVSHold.ForeColor = Color.Red;
                  lblVSHold.Font = APEnabledFont;
               }

               if (s.apHdgHold == 0)
               {
                  lblHdgHold.ForeColor = Color.Gray;
                  lblHdgHold.Font = APDisabledFont;
               }
               else
               {
                  lblHdgHold.ForeColor = Color.Red;
                  lblHdgHold.Font = APEnabledFont;
               }

               if (s.apNav1Hold == 0)
               {
                  lblNavHold.ForeColor = Color.Gray;
                  lblNavHold.Font = APDisabledFont;
               }
               else
               {
                  lblNavHold.ForeColor = Color.Red;
                  lblNavHold.Font = APEnabledFont;
               }
            }
            catch { }
         }
      }

      private void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
      {
         connectedToSimLabel.Text = "Connected to Sim";
         timer.Enabled = true;
      }

      private void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
      {
         DisconnectFromSim();
         connectedToSimLabel.Text = "Sim has exited";
      }

      private void Simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
      {
      }

      private void altitudeIncrease1000ToolStripMenuItem_Click(object sender, EventArgs e)
      {
      }

      private void altitudeDecrease1000ToolStripMenuItem_Click(object sender, EventArgs e)
      {
      }

      private void BaudRateMenuItem_Click(object sender, EventArgs e)
      {
         var menuItem = (ToolStripMenuItem)sender;
         baudRate = int.Parse((string)menuItem.Tag);
         System.Diagnostics.Debug.WriteLine($"Baud={baudRate}");
         menuItem.Checked = true;
         if (menuItem == baud9600ToolStripMenuItem)
         {
            baud115200ToolStripMenuItem.Checked = false;
         }
         else if (menuItem == baud115200ToolStripMenuItem)
         {
            baud9600ToolStripMenuItem.Checked = false;
         }
      }

      private enum SimStructures
      {
         MacroSimStruct
      }

      private enum SimDefinitions
      {
         MacroSimStruct
      }

      private enum SimDataRequests
      {
         Request1
      }

      private enum SimEvents
      {
         KEY_PAUSE_ON,
         KEY_PAUSE_OFF,
         AP_ALT_VAR_SET_ENGLISH,
         COM_RADIO_WHOLE_INC,
         COM_RADIO_FRACT_INC,
         COM_RADIO_WHOLE_DEC,
         COM_RADIO_FRACT_DEC,
         COM2_RADIO_WHOLE_INC,
         COM2_RADIO_FRACT_INC,
         COM2_RADIO_WHOLE_DEC,
         COM2_RADIO_FRACT_DEC,
         NAV1_RADIO_WHOLE_INC,
         NAV1_RADIO_FRACT_INC,
         NAV1_RADIO_WHOLE_DEC,
         NAV1_RADIO_FRACT_DEC,
         NAV2_RADIO_WHOLE_INC,
         NAV2_RADIO_FRACT_INC,
         NAV2_RADIO_WHOLE_DEC,
         NAV2_RADIO_FRACT_DEC,
         COM_RADIO_SWAP,
         COM2_RADIO_SWAP,
         NAV1_RADIO_SWAP,
         NAV2_RADIO_SWAP,
         HEADING_BUG_INC,
         HEADING_BUG_DEC,
         AP_HDG_HOLD,
         VOR1_OBI_INC,
         VOR1_OBI_DEC,
         TOGGLE_GPS_DRIVES_NAV1,
         AP_ALT_HOLD,
         AP_PANEL_VS_HOLD,
         AP_VS_VAR_SET_ENGLISH,
         XPNDR_1000_INC,
         XPNDR_100_INC,
         XPNDR_10_INC,
         XPNDR_1_INC,
         XPNDR_1000_DEC,
         XPNDR_100_DEC,
         XPNDR_10_DEC,
         XPNDR_1_DEC,
         XPNDR_IDENT_TOGGLE,
         GPS_CURSOR_BUTTON,
         GPS_GROUP_KNOB_INC,
         GPS_GROUP_KNOB_DEC,
         GPS_PAGE_KNOB_INC,
         GPS_PAGE_KNOB_DEC,
         G1000_PFD_CURSOR_BUTTON,
         G1000_PFD_GROUP_KNOB_INC,
         G1000_PFD_GROUP_KNOB_DEC,
         G1000_PFD_PAGE_KNOB_INC,
         G1000_PFD_PAGE_KNOB_DEC,
         G1000_MFD_CURSOR_BUTTON,
         G1000_MFD_GROUP_KNOB_INC,
         G1000_MFD_GROUP_KNOB_DEC,
         G1000_MFD_PAGE_KNOB_INC,
         G1000_MFD_PAGE_KNOB_DEC,
         AP_VS_VAR_INC,
         AP_VS_VAR_DEC,
         AP_APR_HOLD,
         AP_ATT_HOLD,
         AP_BANK_HOLD,
         AP_BC_HOLD,
         AP_LOC_HOLD,
         AP_MACH_HOLD,
         AP_MASTER,
         AP_VS_HOLD,
         AP_WING_LEVELER,
         FLIGHT_LEVEL_CHANGE,
         AP_NAV1_HOLD
      }

      private enum SimNotificationGroups
      {
         Group0
      }

      //[StructLayout(LayoutKind.Sequential, Pack = 1)]
      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      private struct MacroSimStruct
      {
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
         public string Title;
         public double com1standby;
         public double com1active;
         public double com2standby;
         public double com2active;
         public double nav1standby;
         public double nav1active;
         public double nav2standby;
         public double nav2active;
         public int apAltitude;
         public int apVerticalSpeed;
         public int apHeading;
         public int apNav1Obs;

         public int apMaster;
         public int apAltHold;
         public int apVsHold;
         public int apHdgHold;
         public int apNav1Hold;

         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com1activeIdent;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com2activeIdent;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com1activeType;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com2activeType;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com1standbyIdent;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com2standbyIdent;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com1standbyType;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string com2standbyType;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string nav1Ident;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
         public string nav2Ident;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
         public string nav1Name;
         [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
         public string nav2Name;
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
               if (menuItem.Text.ToUpper().Contains("COM"))
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
         try
         {
            serialPort1.Close();
            serialPort1.PortName = sender?.ToString();
            serialPort1.RtsEnable = true;
            serialPort1.DtrEnable = true;
            serialPort1.Open();
         }
         catch { }
      }

      private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
      {
         int data = serialPort1.ReadByte();
         var bytes = BitConverter.GetBytes(data);
         var b = bytes[0];

         //byte[] displayBytes = new[] { b };
         //System.Diagnostics.Debug.WriteLine($"{data}");
         //System.Diagnostics.Debug.WriteLine($"{Convert.ToHexString(displayBytes)}");

         int deviceID = b & 0b11111000;
         deviceID = deviceID >> 3;
         MacroPadDevice deviceType = (MacroPadDevice)deviceID;

         int eventID = b & 0b00000111;
         MacroPadEvent eventType = (MacroPadEvent)eventID;

         ProcessMacroPadEvent(deviceType, eventType);
      }

      private void SendSimConnectEvent(Enum eventType, uint dwData = 0)
      {
         SendSimConnectEvent(eventType, eventType.ToString(), dwData);
      }

      private void SendSimConnectEvent(Enum eventType, string eventName, uint dwData = 0)
      {
         try
         {
            if (simconnect != null)
            {
               simconnect.MapClientEventToSimEvent(eventType, eventName);
               simconnect.TransmitClientEvent(0U, eventType, dwData, SimNotificationGroups.Group0, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

               System.Diagnostics.Debug.WriteLine("Sending " + eventName);
               //txtOutput.Text += "Sending " + eventName + "\r\n";

               try
               {
                  txtOutput.AppendText("Sending " + eventName + "\r\n");
               }
               catch { }
            }
         }
         catch (COMException ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
         }
      }

      private void ProcessMacroPadEvent(MacroPadDevice deviceType, MacroPadEvent eventType)
      {
         MacroPadState previousState = state;

         string eventStr = eventType.ToString();

         System.Diagnostics.Debug.WriteLine($"Device {deviceType}, event {eventStr}");
         //txtOutput.Text += $"Device {deviceType}, event {eventStr} \r\n";
         try
         {
            txtOutput.AppendText($"Device {deviceType}, event {eventStr} \r\n");
         }
         catch { }

         switch (deviceType)
         {
            case MacroPadDevice.COM1:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.COM1_MHZ ? MacroPadState.COM1_KHZ : MacroPadState.COM1_MHZ;
               break;
            case MacroPadDevice.COM2:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.COM2_MHZ ? MacroPadState.COM2_KHZ : MacroPadState.COM2_MHZ;
               break;
            case MacroPadDevice.NAV1:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.NAV1_MHZ ? MacroPadState.NAV1_KHZ : MacroPadState.NAV1_MHZ;
               break;
            case MacroPadDevice.NAV2:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.NAV2_MHZ ? MacroPadState.NAV2_KHZ : MacroPadState.NAV2_MHZ;
               break;

            case MacroPadDevice.HDG:
               if (eventType == MacroPadEvent.Clicked)
                  state = MacroPadState.HEADING;
               break;

            case MacroPadDevice.CRS:
               if (eventType == MacroPadEvent.Clicked)
                  state = MacroPadState.COURSE;
               break;

            case MacroPadDevice.ALT:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.ALTITUDE_1000 ? MacroPadState.ALTITUDE_100 : MacroPadState.ALTITUDE_1000;
               break;

            case MacroPadDevice.VS:
               if (eventType == MacroPadEvent.Clicked)
                  state = MacroPadState.VERTICAL_SPEED;
               break;

            case MacroPadDevice.XPND:
               if (eventType == MacroPadEvent.Clicked)
                  switch (state)
                  {
                     case MacroPadState.XPND_1000:
                        state = MacroPadState.XPND_100;
                        break;
                     case MacroPadState.XPND_100:
                        state = MacroPadState.XPND_10;
                        break;
                     case MacroPadState.XPND_10:
                        state = MacroPadState.XPND_1;
                        break;
                     case MacroPadState.XPND_1:
                     default:
                        state = MacroPadState.XPND_1000;
                        break;
                  }
               break;

            case MacroPadDevice.GPS:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.GPS_GROUP ? MacroPadState.GPS_PAGE : MacroPadState.GPS_GROUP;
               break;

            case MacroPadDevice.PFD:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.PFD_GROUP ? MacroPadState.PFD_PAGE : MacroPadState.PFD_GROUP;
               break;

            case MacroPadDevice.MFD:
               if (eventType == MacroPadEvent.Clicked)
                  state = state == MacroPadState.MFD_GROUP ? MacroPadState.MFD_PAGE : MacroPadState.MFD_GROUP;
               break;

            case MacroPadDevice.Rotary:
               switch (state)
               {
                  case MacroPadState.COM1_MHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.COM_RADIO_WHOLE_INC, "COM_RADIO_WHOLE_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.COM_RADIO_WHOLE_DEC, "COM_RADIO_WHOLE_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.COM_RADIO_SWAP, "COM1_RADIO_SWAP");
                     break;
                  case MacroPadState.COM1_KHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.COM_RADIO_FRACT_INC, "COM_RADIO_FRACT_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.COM_RADIO_FRACT_DEC, "COM_RADIO_FRACT_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.COM_RADIO_SWAP, "COM1_RADIO_SWAP");
                     break;
                  case MacroPadState.COM2_MHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_WHOLE_INC, "COM2_RADIO_WHOLE_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_WHOLE_DEC, "COM2_RADIO_WHOLE_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_SWAP, "COM2_RADIO_SWAP");
                     break;
                  case MacroPadState.COM2_KHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_FRACT_INC, "COM2_RADIO_FRACT_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_FRACT_DEC, "COM2_RADIO_FRACT_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.COM2_RADIO_SWAP, "COM2_RADIO_SWAP");
                     break;
                  case MacroPadState.NAV1_MHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_WHOLE_INC, "NAV1_RADIO_WHOLE_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_WHOLE_DEC, "NAV1_RADIO_WHOLE_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_SWAP, "NAV1_RADIO_SWAP");
                     break;
                  case MacroPadState.NAV1_KHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_FRACT_INC, "NAV1_RADIO_FRACT_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_FRACT_DEC, "NAV1_RADIO_FRACT_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.NAV1_RADIO_SWAP, "NAV1_RADIO_SWAP");
                     break;
                  case MacroPadState.NAV2_MHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_WHOLE_INC, "NAV2_RADIO_WHOLE_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_WHOLE_DEC, "NAV2_RADIO_WHOLE_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_SWAP, "NAV2_RADIO_SWAP");
                     break;
                  case MacroPadState.NAV2_KHZ:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_FRACT_INC, "NAV2_RADIO_FRACT_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_FRACT_DEC, "NAV2_RADIO_FRACT_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.NAV2_RADIO_SWAP, "NAV2_RADIO_SWAP");
                     break;

                  case MacroPadState.HEADING:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.HEADING_BUG_INC, "HEADING_BUG_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.HEADING_BUG_DEC, "HEADING_BUG_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.AP_HDG_HOLD, "AP_HDG_HOLD");
                     break;

                  case MacroPadState.COURSE:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.VOR1_OBI_INC, "VOR1_OBI_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.VOR1_OBI_DEC, "VOR1_OBI_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.TOGGLE_GPS_DRIVES_NAV1, "TOGGLE_GPS_DRIVES_NAV1");
                     break;

                  case MacroPadState.ALTITUDE_1000:
                     if (eventType == MacroPadEvent.Increment)
                     {
                        uint newAltSetting = Convert.ToUInt32(altitude.Value + 1000);
                        SendSimConnectEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, "AP_ALT_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Decrement)
                     {
                        uint newAltSetting = Convert.ToUInt32(altitude.Value - 1000);
                        SendSimConnectEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, "AP_ALT_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.AP_ALT_HOLD, "AP_ALT_HOLD");
                     break;

                  case MacroPadState.ALTITUDE_100:
                     if (eventType == MacroPadEvent.Increment)
                     {
                        uint newAltSetting = Convert.ToUInt32(altitude.Value + 100);
                        SendSimConnectEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, "AP_ALT_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Decrement)
                     {
                        uint newAltSetting = Convert.ToUInt32(altitude.Value - 100);
                        SendSimConnectEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, "AP_ALT_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.AP_ALT_HOLD, "AP_ALT_HOLD");
                     break;

                  case MacroPadState.VERTICAL_SPEED:
                     if (eventType == MacroPadEvent.Increment)
                     {
                        SendSimConnectEvent(SimEvents.AP_VS_VAR_INC, "AP_VS_VAR_INC");
                        //uint newAltSetting = Convert.ToUInt32(verticalspeed.Value + 100);
                        //SendSimConnectEvent(SimEvents.AP_VS_VAR_SET_ENGLISH, "AP_VS_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Decrement)
                     {
                        SendSimConnectEvent(SimEvents.AP_VS_VAR_DEC, "AP_VS_VAR_DEC");
                        //uint newAltSetting = Convert.ToUInt32(verticalspeed.Value - 100);
                        //SendSimConnectEvent(SimEvents.AP_VS_VAR_SET_ENGLISH, "AP_VS_VAR_SET_ENGLISH", newAltSetting);
                     }
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.AP_PANEL_VS_HOLD, "AP_PANEL_VS_HOLD");
                     break;

                  case MacroPadState.XPND_1000:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.XPNDR_1000_INC, "XPNDR_1000_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.XPNDR_1000_DEC, "XPNDR_1000_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.XPNDR_IDENT_TOGGLE, "XPNDR_IDENT_TOGGLE");
                     break;
                  case MacroPadState.XPND_100:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.XPNDR_100_INC, "XPNDR_100_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.XPNDR_100_DEC, "XPNDR_100_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.XPNDR_IDENT_TOGGLE, "XPNDR_IDENT_TOGGLE");
                     break;
                  case MacroPadState.XPND_10:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.XPNDR_10_INC, "XPNDR_10_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.XPNDR_10_DEC, "XPNDR_10_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.XPNDR_IDENT_TOGGLE, "XPNDR_IDENT_TOGGLE");
                     break;
                  case MacroPadState.XPND_1:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.XPNDR_1_INC, "XPNDR_1_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.XPNDR_1_DEC, "XPNDR_1_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.XPNDR_IDENT_TOGGLE, "XPNDR_IDENT_TOGGLE");
                     break;

                  case MacroPadState.GPS_GROUP:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.GPS_GROUP_KNOB_INC, "GPS_GROUP_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.GPS_GROUP_KNOB_DEC, "GPS_GROUP_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.GPS_CURSOR_BUTTON, "GPS_CURSOR_BUTTON");
                     break;
                  case MacroPadState.GPS_PAGE:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.GPS_PAGE_KNOB_INC, "GPS_PAGE_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.GPS_PAGE_KNOB_DEC, "GPS_PAGE_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.GPS_CURSOR_BUTTON, "GPS_CURSOR_BUTTON");
                     break;

                  case MacroPadState.PFD_GROUP:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.G1000_PFD_GROUP_KNOB_INC, "G1000_PFD_GROUP_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.G1000_PFD_GROUP_KNOB_DEC, "G1000_PFD_GROUP_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.G1000_PFD_CURSOR_BUTTON, "G1000_PFD_CURSOR_BUTTON");
                     break;
                  case MacroPadState.PFD_PAGE:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.G1000_PFD_PAGE_KNOB_INC, "G1000_PFD_PAGE_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.G1000_PFD_PAGE_KNOB_DEC, "G1000_PFD_PAGE_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.G1000_PFD_CURSOR_BUTTON, "G1000_PFD_CURSOR_BUTTON");
                     break;

                  case MacroPadState.MFD_GROUP:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.G1000_MFD_GROUP_KNOB_INC, "G1000_MFD_GROUP_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.G1000_MFD_GROUP_KNOB_DEC, "G1000_MFD_GROUP_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.G1000_MFD_CURSOR_BUTTON, "G1000_MFD_CURSOR_BUTTON");
                     break;
                  case MacroPadState.MFD_PAGE:
                     if (eventType == MacroPadEvent.Increment)
                        SendSimConnectEvent(SimEvents.G1000_MFD_PAGE_KNOB_INC, "G1000_MFD_PAGE_KNOB_INC");
                     else if (eventType == MacroPadEvent.Decrement)
                        SendSimConnectEvent(SimEvents.G1000_MFD_PAGE_KNOB_DEC, "G1000_MFD_PAGE_KNOB_DEC");
                     else if (eventType == MacroPadEvent.Clicked)
                        SendSimConnectEvent(SimEvents.G1000_MFD_CURSOR_BUTTON, "G1000_MFD_CURSOR_BUTTON");
                     break;

               }
               break;
         }

         switch (previousState)
         {
            case MacroPadState.COM1_MHZ:
            case MacroPadState.COM1_KHZ:
               com1standby.Selection = FrequencySelection.None;
               break;
            case MacroPadState.COM2_MHZ:
            case MacroPadState.COM2_KHZ:
               com2standby.Selection = FrequencySelection.None;
               break;
            case MacroPadState.NAV1_MHZ:
            case MacroPadState.NAV1_KHZ:
               nav1standby.Selection = FrequencySelection.None;
               break;
            case MacroPadState.NAV2_MHZ:
            case MacroPadState.NAV2_KHZ:
               nav2standby.Selection = FrequencySelection.None;
               break;
            case MacroPadState.HEADING:
               heading.Selection = FrequencySelection.None;
               break;
            case MacroPadState.COURSE:
               course.Selection = FrequencySelection.None;
               break;
         }

         switch (state)
         {
            case MacroPadState.COM1_MHZ:
               com1standby.Selection = FrequencySelection.MHz;
               break;
            case MacroPadState.COM1_KHZ:
               com1standby.Selection = FrequencySelection.KHz;
               break;
            case MacroPadState.COM2_MHZ:
               com2standby.Selection = FrequencySelection.MHz;
               break;
            case MacroPadState.COM2_KHZ:
               com2standby.Selection = FrequencySelection.KHz;
               break;
            case MacroPadState.NAV1_MHZ:
               nav1standby.Selection = FrequencySelection.MHz;
               break;
            case MacroPadState.NAV1_KHZ:
               nav1standby.Selection = FrequencySelection.KHz;
               break;
            case MacroPadState.NAV2_MHZ:
               nav2standby.Selection = FrequencySelection.MHz;
               break;
            case MacroPadState.NAV2_KHZ:
               nav2standby.Selection = FrequencySelection.KHz;
               break;
            case MacroPadState.HEADING:
               heading.Selection = FrequencySelection.MHz;
               break;
            case MacroPadState.COURSE:
               course.Selection = FrequencySelection.MHz;
               break;
         }

         //stateLabel.Text = state.ToString();
         Invoke(setTextDelegate, new object[] { state.ToString() });

         byte[] buffer = new byte[1];
         buffer[0] = (byte)state;
         serialPort1.Write(buffer, 0, 1);
      }

      public void SetStateLabel(string text)
      {
         stateLabel.Text = text;
      }

      public delegate void SetTextDelegate(string myString);
      public SetTextDelegate setTextDelegate;

      private void APIndicator_DoubleClick(object sender, EventArgs e)
      {
         if (sender is Label label)
         {
            if (label == lblAPMaster)
            {
               SendSimConnectEvent(SimEvents.AP_MASTER);
            }
            else if (label == lblAltHold)
            {
               SendSimConnectEvent(SimEvents.AP_ALT_HOLD);
            }
            else if (label == lblVSHold)
            {
               SendSimConnectEvent(SimEvents.AP_VS_HOLD);
            }
            else if (label == lblHdgHold)
            {
               SendSimConnectEvent(SimEvents.AP_HDG_HOLD);
            }
            else if (label == lblNavHold)
            {
               SendSimConnectEvent(SimEvents.AP_NAV1_HOLD);
            }
         }
      }
   }
}

//////////////////////////
// COM1 // COM2 // GPS  //
//////////////////////////
// NAV1 // NAV2 // PFD  //
//////////////////////////
// HDG  // CRS  // MFD  //
//////////////////////////
// ALT  //  VS  // XPND //
//////////////////////////

// COM1 First press : COM1_MHZ
// COM1 Second press: COM1_KHZ
// COM1 Rotary press: Swap standby with active
// COM2 First press : COM2_MHZ
// COM2 Second press: COM2_KHZ
// COM2 Rotary press: Swap standby with active
// NAV1 First press : NAV1_MHZ
// NAV1 Second press: NAV1_KHZ
// NAV1 Rotary press: Swap standby with active
// NAV2 First press : NAV2_MHZ
// NAV2 Second press: NAV2_KHZ
// NAV2 Rotary press: Swap standby with active
// HDG press        : HEADING
// HDG Rotary press : Toggle AP heading hold
// CRS press        : COURSE / OBS
// ALT First press  : Thousands
// ALT Second press : Hundreds
// ALT Rotary press : Toggle AP altitude hold
// VS press         : Hundreds
// VS Rotary press  : Toggle AP VS hold
// XPND First press : Thousands
// XPND Second press: Hundreds
// XPND Third press : Tens
// XPND Fourth press: Ones
// XPND Rotary press: Turn transponder on
// GPS First press  : GPS_GROUP
// GPS Second press : GPS_PAGE
// GPS Rotary press : GPS_CURSOR_BUTTON
// PFD First press  : G1000_PFD_GROUP_KNOB
// PFD Second press : G1000_PFD_PAGE_KNOB
// PFD Rotary press : G1000_PFD_CURSOR_BUTTON
// MFD First press  : G1000_MFD_GROUP_KNOB
// MFD Second press : G1000_MFD_PAGE_KNOB
// MFD Rotary press : G1000_MFD_CURSOR_BUTTON

public enum MacroPadDevice : byte
{
    Rotary = 0,
    COM1 = 1,
    COM2 = 2,
    GPS = 3,
    NAV1 = 4,
    NAV2 = 5,
    PFD = 6,
    HDG = 7,
    CRS = 8,
    MFD = 9,
    ALT = 10,
    VS = 11,
    XPND = 12
}
public enum MacroPadEvent : byte
{
    Clicked = 0,
    DoubleClicked = 1,
    LongPressed = 2,
    RepeatPressed = 3,
    Increment = 4,
    Decrement = 5
}

public enum MacroPadState : byte
{
    None            = 0b000000_00,
    COM1_MHZ        = 0b000001_00,
    COM1_KHZ        = 0b000001_01,
    COM2_MHZ        = 0b000010_00,
    COM2_KHZ        = 0b000010_01,
    NAV1_MHZ        = 0b000011_00,
    NAV1_KHZ        = 0b000011_01,
    NAV2_MHZ        = 0b000100_00,
    NAV2_KHZ        = 0b000100_01,
    HEADING         = 0b000101_00,
    COURSE          = 0b000110_00,
    ALTITUDE_1000   = 0b000111_00,
    ALTITUDE_100    = 0b000111_01,
    VERTICAL_SPEED  = 0b001000_00,
    XPND_1000       = 0b001001_00,
    XPND_100        = 0b001001_01,
    XPND_10         = 0b001001_10,
    XPND_1          = 0b001001_11,
    GPS_GROUP       = 0b001010_00,
    GPS_PAGE        = 0b001010_01,
    PFD_GROUP       = 0b001011_00,
    PFD_PAGE        = 0b001011_01,
    MFD_GROUP       = 0b001100_00,
    MFD_PAGE        = 0b001100_01,
}
