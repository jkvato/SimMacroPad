using MacroSim.SimConnection.Enumerations;
using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Structures;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct AircraftControlStruct
{
   public double elevatorTrimMin;
   public double elevatorTrimNeutral;
   public double elevatorTrimPosition;
   public double elevatorTrimMax;

   public int aileronTrimDisabled;
   public double aileronTrimPosition;
   public double aileronTrimMin;
   public double aileronTrimMax;

   public int rudderTrimDisabled;
   public double rudderTrimPosition;
   public double rudderTrimMin;
   public double rudderTrimMax;

   public double flapsCurrentLimitation;
   public int flapsNumHandlePositions;
   public int flapsHandleIndex;
   public double flapsTrailingEdgeLeft;
   public double flapsTrailingEdgeRight;

   public int spoilersAvailable;
   public int spoilersArmed;
   public double spoilersHandlePosition;
   public double spoilersLeftPosition;
   public double spoilersRightPosition;


   // FLAPS NUM HANDLE POSITIONS

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "ELEVATOR TRIM MIN", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ELEVATOR TRIM NEUTRAL", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ELEVATOR TRIM POSITION", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ELEVATOR TRIM MAX", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "AILERON TRIM DISABLED", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AILERON TRIM", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AILERON TRIM MIN", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "AILERON TRIM MAX", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "RUDDER TRIM DISABLED", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "RUDDER TRIM", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "RUDDER TRIM MIN", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "RUDDER TRIM MAX", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "FLAPS CURRENT SPEED LIMITATION", "Knots", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "FLAPS NUM HANDLE POSITIONS", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "FLAPS HANDLE INDEX", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TRAILING EDGE FLAPS LEFT ANGLE", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TRAILING EDGE FLAPS RIGHT ANGLE", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "SPOILER AVAILABLE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SPOILERS ARMED", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SPOILERS HANDLE POSITION", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SPOILERS LEFT POSITION", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SPOILERS RIGHT POSITION", "percent", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<AircraftControlStruct>(simStructure);
   }

   public readonly bool AileronTrimDisabled => aileronTrimDisabled == 1;
   public readonly bool RudderTrimDisabled => rudderTrimDisabled == 1;
   public readonly bool SpoilersAvailable => spoilersAvailable == 1;
   public readonly bool SpoilersArmed => spoilersArmed == 1;
}
