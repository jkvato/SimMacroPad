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

   public MainForm()
   {
      InitializeComponent();

      simConnection = new SimConnection.SimConnection();
      simConnection.DataReceived += SimConnection_DataReceived;

      macroPadDevice = new MacroPadDevice.MacroPadDevice(simConnection);
      macroPadDevice.EventProcessed += MacroPadDevice_EventProcessed;

      lblVerticalSpeedValue.AutoSize = false;

      GetComPorts();
   }

   private void MacroPadDevice_EventProcessed(object sender, EventProcessedEventArgs e)
   {
      InvokeAction(form =>
      {
         form.lblMacroPadState.Text = e.NewState.ToString();
         form.txtOutput.AppendText($"Component {e.Component}, event {e.Event} \r\n");
      });
   }

   private void SimConnection_DataReceived(object sender, MacroSimStruct macroSimStruct)
   {
      System.Diagnostics.Debug.WriteLine("Data received");

      macroPadDevice.UpdateData(macroSimStruct);

      // Update UI via Invoke
      InvokeAction(form =>
      {
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
         connectToSimToolStripMenuItem.Text = "Connect to Sim";
         lblSimConnectionStatus.Text = "Disconnected from Sim";

         System.Diagnostics.Debug.WriteLine("Disconnected");
      }
      else
      {
         simConnection.ConnectToSim(Handle);
         connectToSimToolStripMenuItem.Text = "Disconnect from Sim";
         lblSimConnectionStatus.Text = "Connected to Sim";

         System.Diagnostics.Debug.WriteLine("Connected");

         simConnection.RequestDataOnSimObject();
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
      if (sender is ToolStripMenuItem menuItem)
      {
         string comPortName = menuItem.ToString();
         macroPadDevice.SetSerialPort(comPortName);
      }
   }
}
