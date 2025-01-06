using MacroSim.SimConnection.Enumerations;
using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Structures;

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

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV STANDBY FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV ACTIVE FREQUENCY:1", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV STANDBY FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV ACTIVE FREQUENCY:2", "Megahertz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT ALTITUDE LOCK VAR", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT VERTICAL HOLD VAR", "feet per minute", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT HEADING LOCK DIR", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV OBS:1", "degrees", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT MASTER", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT ALTITUDE LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT VERTICAL HOLD", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT HEADING LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AUTOPILOT NAV1 LOCK", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM ACTIVE FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQ IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQ IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQ TYPE:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "COM STANDBY FREQ TYPE:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV IDENT:1", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV IDENT:2", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV NAME:1", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "NAV NAME:2", null, SIMCONNECT_DATATYPE.STRING64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "TRANSPONDER CODE:1", "enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "FUEL TOTAL CAPACITY", "Gallons", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "FUEL TOTAL QUANTITY", "Gallons", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "FUEL DUMP ACTIVE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "FUEL DUMP SWITCH", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<AvionicsStruct>(simStructure);
   }

   public readonly bool ApMasterEngaged => apMaster == 1;
   public readonly bool ApAltitudeHoldEngaged => apAltHold == 1;
   public readonly bool ApVerticalSpeedHoldEngaged => apVsHold == 1;
   public readonly bool ApHeadingHoldEngaged => apHdgHold == 1;
   public readonly bool ApNav1HoldEngaged => apNav1Hold == 1;
   public readonly bool FuelDumpActive => fuelDumpActive == 1;
   public readonly bool FuelDumpSwitch => fuelDumpSwitch == 1;

   public readonly float TotalFuelPct => ((float)totalFuelQuantity / (float)totalFuelCapacity) * 100;


   public string Com1ActiveName => com1activeIdent + " " + Com1ActiveType;
   public string Com1StandbyName => com1standbyIdent + " " + Com1StandbyType;
   public string Com2ActiveName => com2activeIdent + " " + Com2ActiveType;
   public string Com2StandbyName => com2standbyIdent + " " + Com2StandbyType;

   public string Com1ActiveType => InterpretComType(com1activeType);
   public string Com2ActiveType => InterpretComType(com2activeType);
   public string Com1StandbyType => InterpretComType(com1standbyType);
   public string Com2StandbyType => InterpretComType(com2standbyType);

   private string InterpretComType(string comType)
   {
      switch (comType.ToUpper())
      {
         case "ATIS":
         case "CTAF":
            break;
         case "UNI":
            comType = "UNICOM";
            break;
         case "GND":
            comType = "GROUND";
            break;
         case "TWR":
            comType = "TOWER";
            break;
         case "CLR":
            comType = "CLEARANCE";
            break;
         case "APPR":
            comType = "APPROACH";
            break;
         case "DEP":
            comType = "DEPARTURE";
            break;
         case "BLANK":
            comType = "Unspecified";
            break;
         case "STANDBY":
            comType = "Standby";
            break;
         case "ACTIVE":
            comType = "Active";
            break;
      }
      return comType;
   }
}
