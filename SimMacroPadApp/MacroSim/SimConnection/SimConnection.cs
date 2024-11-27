﻿using Microsoft.FlightSimulator.SimConnect;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacroSim.SimConnection
{
   internal class SimConnection
   {
      public delegate void DataReceivedEventHandler(object sender, MacroSimStruct macroSimStruct);
      public event DataReceivedEventHandler? DataReceived;

      public const int WM_USER_SIMCONNECT = 0x402;

      private SimConnect? simconnect = null;

      public SimConnection()
      {
      }

      public bool IsConnected => simconnect != null;

      protected virtual void OnDataReceived(MacroSimStruct macroSimStruct)
      {
         DataReceived?.Invoke(this, macroSimStruct);
      }

      public bool ConnectToSim(nint handle)
      {
         if (simconnect == null)
         {
            try
            {
               simconnect = new SimConnect("Managed Data Request", handle, WM_USER_SIMCONNECT, null, 0);
               Initialize();
               return true;
            }
            catch (COMException)
            {
               return false;
            }
         }
         else
         {
            return true;
         }
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

            simconnect.AddToDataDefinition(SimStructures.MacroSimStruct, "TRANSPONDER CODE:1", "enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

            simconnect.RegisterDataDefineStruct<MacroSimStruct>(SimStructures.MacroSimStruct);
         }
      }

      private void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
      {
         if (data.dwRequestID == (uint)SimDataRequests.Request1)
         {
            MacroSimStruct macroSimStruct = (MacroSimStruct)data.dwData[0];

            CleanUpMacroSimStruct(ref macroSimStruct);

            OnDataReceived(macroSimStruct);
         }
      }

      private void CleanUpMacroSimStruct(ref MacroSimStruct macroSimStruct)
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
         if (data.dwRequestID == (uint)SimDataRequests.Request1)
         {
            MacroSimStruct s = (MacroSimStruct)data.dwData[0];

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

      private enum SimStructures
      {
         MacroSimStruct
      }

      private enum SimDefinitions
      {
         MacroSimStruct
      }

      private enum SimDataRequests : uint
      {
         Request1
      }

      public enum SimEvents
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
         COM1_RADIO_SWAP,
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

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
      public struct MacroSimStruct
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

         public int transponderCode;
      }

      public void RequestDataOnSimObjectType()
      {
         simconnect?.RequestDataOnSimObjectType(
            RequestID: SimDataRequests.Request1,
            DefineID: SimDefinitions.MacroSimStruct,
            dwRadiusMeters: 0,
            type: SIMCONNECT_SIMOBJECT_TYPE.USER);
      }

      public void RequestDataOnSimObject()
      {
         simconnect?.RequestDataOnSimObject(
            RequestID: SimDataRequests.Request1,
            DefineID: SimDefinitions.MacroSimStruct,
            ObjectID: (uint)SIMCONNECT_SIMOBJECT_TYPE.USER,
            Period: SIMCONNECT_PERIOD.SIM_FRAME,
            Flags: SIMCONNECT_DATA_REQUEST_FLAG.CHANGED,
            origin: 0,
            interval: 5,
            limit: 0);
      }

      public void ReceiveMessage()
      {
         simconnect?.ReceiveMessage();
      }

      public void SendEvent(Enum eventType, uint dwData = 0)
      {
         SendEvent(eventType, eventType.ToString(), dwData);
      }

      public void SendEvent(Enum eventType, string eventName, uint dwData = 0)
      {
         try
         {
            if (simconnect != null)
            {
               simconnect.MapClientEventToSimEvent(eventType, eventName);
               simconnect.TransmitClientEvent(0U, eventType, dwData, SimNotificationGroups.Group0, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

               System.Diagnostics.Debug.WriteLine("Sending " + eventName);
            }
         }
         catch (COMException ex)
         {
            System.Diagnostics.Debug.WriteLine(ex.Message);
         }
      }
   }
}
