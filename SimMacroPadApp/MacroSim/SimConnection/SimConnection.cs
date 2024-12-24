using Microsoft.FlightSimulator.SimConnect;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MacroSim.SimConnection.SimConnection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacroSim.SimConnection
{
   internal class SimConnection
   {
      public delegate void DataReceivedEventHandler(object sender, object structure);
      public event DataReceivedEventHandler? DataReceived;

      public const int WM_USER_SIMCONNECT = 0x402;

      private SimConnect? simconnect = null;

      private readonly BackgroundWorker simConnectionBackgroundWorker = new BackgroundWorker();

      public AvionicsStruct AvionicsData { get; private set; }
      public TrimStruct TrimData { get; private set; }
      public LightsStruct LightsData { get; private set; }
      public CamerasStruct CamerasData { get; private set; }

      public SimConnection()
      {
         simConnectionBackgroundWorker.DoWork += SimConnectionBackgroundWorker_DoWork;
         simConnectionBackgroundWorker.RunWorkerCompleted += SimConnectionBackgroundWorker_RunWorkerCompleted;
      }

      private void SimConnectionBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
      {
         if (e.Argument != null && e.Argument is nint handle)
         {
            DateTime startTime = DateTime.Now;
            if (simconnect == null)
            {
               try
               {
                  simconnect = new SimConnect("Managed Data Request", handle, WM_USER_SIMCONNECT, null, 0);
                  Initialize();
                  System.Diagnostics.Debug.WriteLine($"Requesting Avionics");
                  RequestDataOnSimObject(SimDataRequest.AvionicsRequest);
                  System.Diagnostics.Debug.WriteLine($"Requesting Lights");
                  RequestDataOnSimObject(SimDataRequest.LightsRequest);
                  System.Diagnostics.Debug.WriteLine($"Requesting Trim");
                  RequestDataOnSimObject(SimDataRequest.TrimRequest);
                  System.Diagnostics.Debug.WriteLine($"Requesting Cameras");
                  RequestDataOnSimObject(SimDataRequest.CamerasRequest);
                  return;
               }
               catch (COMException)
               {
                  var elapsedTime = DateTime.Now - startTime;
                  System.Diagnostics.Debug.WriteLine($"Elapsed time: {elapsedTime.TotalSeconds} s");
                  return;
               }
            }
         }
      }

      private void SimConnectionBackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
      {

      }

      public bool IsConnected => simconnect != null;

      protected virtual void OnDataReceived(object structure)
      {
         DataReceived?.Invoke(this, structure);
         //if (structure is AvionicsStruct avionicsStruct)
         //{
         //   DataReceived?.Invoke(this, avionicsStruct);
         //}
      }

      public bool ConnectToSim(nint handle)
      {
         simConnectionBackgroundWorker.RunWorkerAsync(handle);
         return false;
      }

      public void DisconnectFromSim()
      {
         if (simconnect != null)
         {
            simconnect.Dispose();
            simconnect = null;
         }
      }

      private void Initialize()
      {
         if (simconnect != null)
         {
            simconnect.OnRecvOpen += Simconnect_OnRecvOpen;
            simconnect.OnRecvQuit += Simconnect_OnRecvQuit;
            simconnect.OnRecvException += Simconnect_OnRecvException;
            simconnect.OnRecvSimobjectDataBytype += Simconnect_OnRecvSimobjectDataBytype;
            simconnect.OnRecvSimobjectData += Simconnect_OnRecvSimobjectData;

            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT ALTITUDE LOCK VAR", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT VERTICAL HOLD VAR", "feet per minute", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT HEADING LOCK DIR", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV OBS:1", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT MASTER", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT ALTITUDE LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT VERTICAL HOLD", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT HEADING LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "AUTOPILOT NAV1 LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM ACTIVE FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "COM STANDBY FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV NAME:1", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "NAV NAME:2", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "TRANSPONDER CODE:1", "enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "FUEL TOTAL CAPACITY", "Gallons", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "FUEL TOTAL QUANTITY", "Gallons", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "FUEL DUMP ACTIVE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.AvionicsStruct, "FUEL DUMP SWITCH", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.RegisterDataDefineStruct<AvionicsStruct>(SimStructure.AvionicsStruct);

            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT BEACON", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT CABIN", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT GLARESHIELD", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT LANDING", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT LOGO", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT NAV", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT PANEL", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT PEDESTRAL", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT RECOGNITION", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT STROBE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT TAXI", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT WING", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.LightsStruct, "LIGHT ON STATES", "Mask", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.RegisterDataDefineStruct<LightsStruct>(SimStructure.LightsStruct);

            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "ELEVATOR TRIM MIN", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "ELEVATOR TRIM NEUTRAL", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "ELEVATOR TRIM POSITION", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "ELEVATOR TRIM MAX", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "AILERON TRIM DISABLED", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "AILERON TRIM", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "AILERON TRIM MIN", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "AILERON TRIM MAX", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "RUDDER TRIM DISABLED", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "RUDDER TRIM", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "RUDDER TRIM MIN", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.TrimStruct, "RUDDER TRIM MAX", "Radians", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.RegisterDataDefineStruct<TrimStruct>(SimStructure.TrimStruct);

            simconnect.AddToDataDefinition(SimStructure.CamerasStruct, "CAMERA VIEW TYPE AND INDEX:0", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.CamerasStruct, "CAMERA VIEW TYPE AND INDEX:1", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.CamerasStruct, "CAMERA STATE", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
            simconnect.AddToDataDefinition(SimStructure.CamerasStruct, "CAMERA SUBSTATE", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.RegisterDataDefineStruct<CamerasStruct>(SimStructure.CamerasStruct);
         }
      }

      private void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
      {
         if (data.dwRequestID == (uint)SimDataRequest.AvionicsRequest)
         {
            AvionicsStruct avionicsStruct = (AvionicsStruct)data.dwData[0];
            CleanUpMacroSimStruct(ref avionicsStruct);
            AvionicsData = avionicsStruct;
            OnDataReceived(avionicsStruct);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.LightsRequest)
         {
            LightsStruct lightsStruct = (LightsStruct)data.dwData[0];
            LightsData = lightsStruct;
            OnDataReceived(lightsStruct);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.TrimRequest)
         {
            TrimStruct trimStruct = (TrimStruct)data.dwData[0];
            TrimData = trimStruct;
            OnDataReceived(trimStruct);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.CamerasRequest)
         {
            CamerasStruct camerasStruct = (CamerasStruct)data.dwData[0];
            CamerasData = camerasStruct;
            OnDataReceived(camerasStruct);
         }
      }

      private void CleanUpMacroSimStruct(ref AvionicsStruct macroSimStruct)
      {
         if (macroSimStruct.com1standbyIdent == "COM") macroSimStruct.com1standbyIdent = "";
         if (macroSimStruct.com2standbyIdent == "COM") macroSimStruct.com2standbyIdent = "";
         if (macroSimStruct.com1activeIdent == "COM") macroSimStruct.com1activeIdent = "";
         if (macroSimStruct.com2activeIdent == "COM") macroSimStruct.com2activeIdent = "";

         switch (macroSimStruct.com1standbyType.ToUpper())
         {
            case "ATIS":
            case "CTAF":
               break;
            case "UNI":
               macroSimStruct.com1standbyType = "UNICOM";
               break;
            case "GND":
               macroSimStruct.com1standbyType = "GROUND";
               break;
            case "TWR":
               macroSimStruct.com1standbyType = "TOWER";
               break;
            case "CLR":
               macroSimStruct.com1standbyType = "CLEARANCE";
               break;
            case "APPR":
               macroSimStruct.com1standbyType = "APPROACH";
               break;
            case "DEP":
               macroSimStruct.com1standbyType = "DEPARTURE";
               break;
            case "BLANK":
               macroSimStruct.com1standbyType = "Unspecified";
               break;
            case "STANDBY":
               macroSimStruct.com1standbyType = "";
               break;
         }

         switch (macroSimStruct.com2standbyType.ToUpper())
         {
            case "ATIS":
            case "CTAF":
               break;
            case "UNI":
               macroSimStruct.com2standbyType = "UNICOM";
               break;
            case "GND":
               macroSimStruct.com2standbyType = "GROUND";
               break;
            case "TWR":
               macroSimStruct.com2standbyType = "TOWER";
               break;
            case "CLR":
               macroSimStruct.com2standbyType = "CLEARANCE";
               break;
            case "APPR":
               macroSimStruct.com2standbyType = "APPROACH";
               break;
            case "DEP":
               macroSimStruct.com2standbyType = "DEPARTURE";
               break;
            case "BLANK":
               macroSimStruct.com2standbyType = "Unspecified";
               break;
            case "STANDBY":
               macroSimStruct.com2standbyType = "";
               break;
         }

         switch (macroSimStruct.com1activeType.ToUpper())
         {
            case "ATIS":
            case "CTAF":
               break;
            case "UNI":
               macroSimStruct.com1activeType = "UNICOM";
               break;
            case "GND":
               macroSimStruct.com1activeType = "GROUND";
               break;
            case "TWR":
               macroSimStruct.com1activeType = "TOWER";
               break;
            case "CLR":
               macroSimStruct.com1activeType = "CLEARANCE";
               break;
            case "APPR":
               macroSimStruct.com1activeType = "APPROACH";
               break;
            case "DEP":
               macroSimStruct.com1activeType = "DEPARTURE";
               break;
            case "BLANK":
               macroSimStruct.com1activeType = "Unspecified";
               break;
            case "ACTIVE":
               macroSimStruct.com1activeType = "";
               break;
         }

         switch (macroSimStruct.com2activeType.ToUpper())
         {
            case "ATIS":
            case "CTAF":
               break;
            case "UNI":
               macroSimStruct.com2activeType = "UNICOM";
               break;
            case "GND":
               macroSimStruct.com2activeType = "GROUND";
               break;
            case "TWR":
               macroSimStruct.com2activeType = "TOWER";
               break;
            case "CLR":
               macroSimStruct.com2activeType = "CLEARANCE";
               break;
            case "APPR":
               macroSimStruct.com2activeType = "APPROACH";
               break;
            case "DEP":
               macroSimStruct.com2activeType = "DEPARTURE";
               break;
            case "BLANK":
               macroSimStruct.com2activeType = "Unspecified";
               break;
            case "ACTIVE":
               macroSimStruct.com2activeType = "";
               break;
         }
      }

      private void Simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
      {
         if (data.dwRequestID == (uint)SimDataRequest.AvionicsRequest)
         {
            AvionicsStruct s = (AvionicsStruct)data.dwData[0];

            OnDataReceived(s);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.LightsRequest)
         {
            LightsStruct s = (LightsStruct)data.dwData[0];

            OnDataReceived(s);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.TrimRequest)
         {
            TrimStruct s = (TrimStruct)data.dwData[0];

            OnDataReceived(s);
         }
         else if (data.dwRequestID == (uint)SimDataRequest.CamerasRequest)
         {
            CamerasStruct s = (CamerasStruct)data.dwData[0];

            OnDataReceived(s);
         }
      }

      private void Simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
      {
      }

      private void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
      {
         DisconnectFromSim();
      }

      private void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
      {
         System.Diagnostics.Debug.WriteLine(data.szApplicationName);
         System.Diagnostics.Debug.WriteLine($"Version: {data.dwVersion}");
         System.Diagnostics.Debug.WriteLine(
            $"Application v {data.dwApplicationVersionMajor}.{data.dwApplicationVersionMinor}.{data.dwApplicationBuildMajor}.{data.dwApplicationBuildMinor}");
         System.Diagnostics.Debug.WriteLine(
            $"SimConnect v {data.dwSimConnectVersionMajor}.{data.dwSimConnectVersionMinor}.{data.dwSimConnectBuildMajor}.{data.dwSimConnectBuildMinor}");
      }

      private enum SimStructure
      {
         AvionicsStruct,
         LightsStruct,
         TrimStruct,
         CamerasStruct,
      }

      private enum SimStructDefinition
      {
         AvionicsStruct,
         LightsStruct,
         TrimStruct,
         CamerasStruct,
      }

      public enum SimDataRequest : uint
      {
         AvionicsRequest,
         LightsRequest,
         TrimRequest,
         CamerasRequest,
      }

      public enum SimEvent
      {
         NONE,
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
         COM1_RADIO_SWAP,
         COM2_RADIO_SWAP,
         NAV1_RADIO_SWAP,
         NAV2_RADIO_SWAP,
         HEADING_BUG_INC,
         HEADING_BUG_DEC,
         AP_HDG_HOLD,
         VOR1_OBI_INC,
         VOR1_OBI_DEC,
         VOR2_OBI_INC,
         VOR2_OBI_DEC,
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
         AP_NAV1_HOLD,
         ALL_LIGHTS_TOGGLE,
         GLARESHIELD_LIGHTS_TOGGLE,
         LANDING_LIGHTS_TOGGLE,
         PANEL_LIGHTS_TOGGLE,
         PEDESTRAL_LIGHTS_TOGGLE,
         STROBES_TOGGLE,
         TOGGLE_BEACON_LIGHTS,
         TOGGLE_CABIN_LIGHTS,
         TOGGLE_LOGO_LIGHTS,
         TOGGLE_NAV_LIGHTS,
         TOGGLE_RECOGNITION_LIGHTS,
         TOGGLE_TAXI_LIGHTS,
         TOGGLE_WING_LIGHTS,
         AP_ALT_VAR_DEC,
         AP_ALT_VAR_INC,
         HEADING_BUG_SET,
         TOGGLE_FLIGHT_DIRECTOR,
         YAW_DAMPER_TOGGLE,
      }

      private enum SimNotificationGroups
      {
         Group0
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      public struct LightsStruct
      {
         public int lightBeacon;
         public int lightCabin;
         public int lightGlareshield;
         public int lightLanding;
         public int lightLogo;
         public int lightNav;
         public int lightPanel;
         public int lightPedestral;
         public int lightRecognition;
         public int lightStrobe;
         public int lightTaxi;
         public int lightWing;
         public int lightOnStates;

         public readonly bool LightBeaconOn => lightBeacon == 1;
         public readonly bool LightCabinOn => lightCabin == 1;
         public readonly bool LightGlareshieldOn => lightGlareshield == 1;
         public readonly bool LightLandingOn => lightLanding == 1;
         public readonly bool LightLogoOn => lightLogo == 1;
         public readonly bool LightNavOn => lightNav == 1;
         public readonly bool LightPanelOn => lightPanel == 1;
         public readonly bool LightPedestralOn => lightPedestral == 1;
         public readonly bool LightRecognitionOn => lightRecognition == 1;
         public readonly bool LightStrobeOn => lightStrobe == 1;
         public readonly bool LightTaxiOn => lightTaxi == 1;
         public readonly bool LightWingOn => lightWing == 1;
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      public struct AvionicsStruct
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
         public int apAltitudeSel;
         public int apVerticalSpeedSel;
         public int apHeadingSel;
         public int apNav1ObsSel;

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

         public int transponderCode;

         public int totalFuelCapacity;
         public int totalFuelQuantity;
         public int fuelDumpActive;
         public int fuelDumpSwitch;

         public readonly bool ApMasterEngaged => apMaster == 1;
         public readonly bool ApAltitudeHoldEngaged => apAltHold == 1;
         public readonly bool ApVerticalSpeedHoldEngaged => apVsHold == 1;
         public readonly bool ApHeadingHoldEngaged => apHdgHold == 1;
         public readonly bool ApNav1HoldEngaged => apNav1Hold == 1;
         public readonly bool FuelDumpActive => fuelDumpActive == 1;
         public readonly bool FuelDumpSwitch => fuelDumpSwitch == 1;

         public readonly float TotalFuelPct => ((float)totalFuelQuantity / (float)totalFuelCapacity) * 100;
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      public struct CamerasStruct
      {
         public int cameraViewTypeIndex0;
         public int cameraViewTypeIndex1;
         public int cameraState;
         public int cameraSubstate;

         public readonly bool IsInstrumentCamera1Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 0);
         public readonly bool IsInstrumentCamera2Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 1);
         public readonly bool IsInstrumentCamera3Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 2);
         public readonly bool IsInstrumentCamera4Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 3);
         public readonly bool IsInstrumentCamera5Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 4);
         public readonly bool IsInstrumentCamera6Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 5);
         public readonly bool IsInstrumentCamera7Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 6);
         public readonly bool IsInstrumentCamera8Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 7);
         public readonly bool IsInstrumentCamera9Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 8);
         public readonly bool IsInstrumentCamera10Active
            => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 9);
         public readonly bool IsPilotNormalCameraActive
            => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 1);
         public readonly bool IsPilotCloseCameraActive
            => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 0);
         public readonly bool IsPilotLandingCameraActive
            => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 2);
         public readonly bool IsPilotCoPilotCameraActive
            => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 4);
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      public struct TrimStruct
      {
         public double elevatorTrimMin;
         public double elevatorTrimNeutral;
         public double elevatorTrimPosition;
         public double elevatorTrimMax;

         public int aileronTrimDisabled;
         public double aileronTrimPosition;
         public double aileronTrimMax;
         public double aileronTrimMin;

         public int rudderTrimDisabled;
         public double rudderTrimPosition;
         public double rudderTrimMax;
         public double rudderTrimMin;

         public readonly double ElevatorTrimMinDegrees => RadiansToDegrees(elevatorTrimMin);
         public readonly double ElevatorTrimNeutralDegrees => RadiansToDegrees(elevatorTrimNeutral);
         public readonly double ElevatorTrimPositionDegrees => RadiansToDegrees(elevatorTrimPosition);
         public readonly double ElevatorTrimMaxDegrees => RadiansToDegrees(elevatorTrimMax);

         public readonly bool AileronTrimDisabled => aileronTrimDisabled == 1;
         public readonly double AileronTrimPositionDegrees => RadiansToDegrees(aileronTrimPosition);
         public readonly double AileronTrimMinDegrees => RadiansToDegrees(aileronTrimMin);
         public readonly double AileronTrimMaxDegrees => RadiansToDegrees(aileronTrimMax);

         public readonly bool RudderTrimDisabled => rudderTrimDisabled == 1;
         public readonly double RudderTrimPositionDegrees => RadiansToDegrees(rudderTrimPosition);
         public readonly double RudderTrimMinDegrees => RadiansToDegrees(rudderTrimMin);
         public readonly double RudderTrimMaxDegrees => RadiansToDegrees(rudderTrimMax);


         public static double RadiansToDegrees(double radians)
         {
            return radians * (180d / Math.PI);
         }
      }

      public void RequestDataOnSimObjectType()
      {
         simconnect?.RequestDataOnSimObjectType(
            RequestID: SimDataRequest.AvionicsRequest,
            DefineID: SimStructDefinition.AvionicsStruct,
            dwRadiusMeters: 0,
            type: SIMCONNECT_SIMOBJECT_TYPE.USER);
      }

      public void RequestDataOnSimObject(SimDataRequest requestId)
      {
         SimStructDefinition defineId;
         switch (requestId)
         {
            case SimDataRequest.AvionicsRequest:
            default:
               defineId = SimStructDefinition.AvionicsStruct;
               break;
            case SimDataRequest.LightsRequest:
               defineId = SimStructDefinition.LightsStruct;
               break;
            case SimDataRequest.TrimRequest:
               defineId = SimStructDefinition.TrimStruct;
               break;
            case SimDataRequest.CamerasRequest:
               defineId = SimStructDefinition.CamerasStruct;
               break;
         }
         simconnect?.RequestDataOnSimObject(
            RequestID: requestId,
            DefineID: defineId,
            ObjectID: (uint)SIMCONNECT_SIMOBJECT_TYPE.USER,
            Period: SIMCONNECT_PERIOD.SIM_FRAME,
            //Flags: SIMCONNECT_DATA_REQUEST_FLAG.CHANGED,
            Flags: 0,
            origin: 0,
            //interval: 5,
            interval: 0,
            limit: 0);
      }

      public void Set(SimDataRequest requestId, object dataSet)
      {
         SimStructDefinition defineId;
         switch (requestId)
         {
            case SimDataRequest.AvionicsRequest:
            default:
               defineId = SimStructDefinition.AvionicsStruct;
               break;
            case SimDataRequest.LightsRequest:
               defineId = SimStructDefinition.LightsStruct;
               break;
            case SimDataRequest.TrimRequest:
               defineId = SimStructDefinition.TrimStruct;
               break;
            case SimDataRequest.CamerasRequest:
               defineId = SimStructDefinition.CamerasStruct;
               break;
         }
         simconnect?.SetDataOnSimObject(
            DefineID: defineId,
            ObjectID: SimConnect.SIMCONNECT_OBJECT_ID_USER,
            Flags: SIMCONNECT_DATA_SET_FLAG.DEFAULT,
            pDataSet: dataSet);
      }

      public void ReceiveMessage()
      {
         simconnect?.ReceiveMessage();
      }

      public void SendEvent(SimEvent simEvent, uint dwData = 0)
      {
         if (simEvent == SimEvent.NONE)
            return;

         SendEvent(simEvent, simEvent.ToString(), dwData);
      }

      public void SendEvent(SimEvent simEvent, string eventName, uint dwData = 0)
      {
         if (simEvent == SimEvent.NONE)
            return;

         try
         {
            if (simconnect != null)
            {
               simconnect.MapClientEventToSimEvent(simEvent, eventName);
               simconnect.TransmitClientEvent(0U, simEvent, dwData, SimNotificationGroups.Group0, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

               System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending " + eventName);
            }
         }
         catch (COMException ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
         }
      }
   }
}
