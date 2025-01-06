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

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "LIGHT BEACON", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT CABIN", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT GLARESHIELD", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT LANDING", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT LOGO", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT NAV", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT PANEL", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT PEDESTRAL", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT RECOGNITION", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT STROBE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT TAXI", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT WING", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LIGHT ON STATES", "Mask", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<LightsStruct>(simStructure);
   }

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
