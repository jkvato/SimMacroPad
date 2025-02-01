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
public struct EngineStruct
{
   private static readonly double PoundFootToPSIFactor = 87.4;

   public int numberOfEngines;
   public int engineType;
   public double generalEngineRpm1;
   public double generalEngineRpm2;
   public double generalEngineRpm3;
   public double generalEngineRpm4;
   public double engineManifoldPressure1;
   public double engineManifoldPressure2;
   public double engineManifoldPressure3;
   public double engineManifoldPressure4;
   public double propRpm1;
   public double propRpm2;
   public double propRpm3;
   public double propRpm4;
   public double engineN1rpm1;
   public double engineN1rpm2;
   public double engineN1rpm3;
   public double engineN1rpm4;
   public double turbEngN1_1;
   public double turbEngN1_2;
   public double turbEngN1_3;
   public double turbEngN1_4;
   public double turbEngITT1;
   public double turbEngITT2;
   public double turbEngITT3;
   public double turbEngITT4;
   public double engTorque1;
   public double engTorque2;
   public double engTorque3;
   public double engTorque4;
   public double turbEngMaxTorquePct1;
   public double turbEngMaxTorquePct2;
   public double turbEngMaxTorquePct3;
   public double turbEngMaxTorquePct4;
   public double turbEngCorrectedN1_1;
   public double turbEngCorrectedN1_2;
   public double turbEngCorrectedN1_3;
   public double turbEngCorrectedN1_4;
   public double engExhaustGasTemp1;
   public double engExhaustGasTemp2;
   public double engExhaustGasTemp3;
   public double engExhaustGasTemp4;
   public double turbEngCorrectedN2_1;
   public double turbEngCorrectedN2_2;
   public double turbEngCorrectedN2_3;
   public double turbEngCorrectedN2_4;
   public double propThrust1;
   public double propThrust2;
   public double propThrust3;
   public double propThrust4;

   public int tubEngConditionLever1;
   public int tubEngConditionLever2;
   public int tubEngConditionLever3;
   public int tubEngConditionLever4;
   public float genEngThrottleLever1;
   public float genEngThrottleLever2;
   public float genEngThrottleLever3;
   public float genEngThrottleLever4;
   public float genEngPropellerLever1;
   public float genEngPropellerLever2;
   public float genEngPropellerLever3;
   public float genEngPropellerLever4;
   public float genEngMixtureLever1;
   public float genEngMixtureLever2;
   public float genEngMixtureLever3;
   public float genEngMixtureLever4;

   public int propFeathered1;
   public int propFeathered2;
   public int propFeathered3;
   public int propFeathered4;
   public double propBeta1;
   public double propBeta2;
   public double propBeta3;
   public double propBeta4;

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "NUMBER OF ENGINES", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENGINE TYPE", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG RPM:1", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG RPM:2", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG RPM:3", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG RPM:4", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG MANIFOLD PRESSURE:1", "inHg", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG MANIFOLD PRESSURE:2", "inHg", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG MANIFOLD PRESSURE:3", "inHg", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG MANIFOLD PRESSURE:4", "inHg", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP RPM:1", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP RPM:2", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP RPM:3", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP RPM:4", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG N1 RPM:1", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG N1 RPM:2", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG N1 RPM:3", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG N1 RPM:4", "RPM", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG N1:1", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG N1:2", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG N1:3", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG N1:4", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG ITT:1", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG ITT:2", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG ITT:3", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG ITT:4", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG TORQUE:1", "FOOT POUNDS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG TORQUE:2", "FOOT POUNDS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG TORQUE:3", "FOOT POUNDS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG TORQUE:4", "FOOT POUNDS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG MAX TORQUE PERCENT:1", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG MAX TORQUE PERCENT:2", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG MAX TORQUE PERCENT:3", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG MAX TORQUE PERCENT:4", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N1:1", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N1:2", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N1:3", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N1:4", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG EXHAUST GAS TEMPERATURE:1", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG EXHAUST GAS TEMPERATURE:2", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG EXHAUST GAS TEMPERATURE:3", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ENG EXHAUST GAS TEMPERATURE:4", "CELSIUS", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N2:1", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N2:2", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N2:3", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CORRECTED N2:4", "PERCENT", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP THRUST:1", "Pounds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP THRUST:2", "Pounds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP THRUST:3", "Pounds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP THRUST:4", "Pounds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "TURB ENG CONDITION LEVER POSITION:1", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CONDITION LEVER POSITION:2", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CONDITION LEVER POSITION:3", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TURB ENG CONDITION LEVER POSITION:4", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG THROTTLE LEVER POSITION:1", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG THROTTLE LEVER POSITION:2", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG THROTTLE LEVER POSITION:3", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG THROTTLE LEVER POSITION:4", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG PROPELLER LEVER POSITION:1", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG PROPELLER LEVER POSITION:2", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG PROPELLER LEVER POSITION:3", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG PROPELLER LEVER POSITION:4", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG MIXTURE LEVER POSITION:1", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG MIXTURE LEVER POSITION:2", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG MIXTURE LEVER POSITION:3", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "GENERAL ENG MIXTURE LEVER POSITION:4", "Percent", SIMCONNECT_DATATYPE.FLOAT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.AddToDataDefinition(simStructure, "PROP FEATHERED:1", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP FEATHERED:2", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP FEATHERED:3", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP FEATHERED:4", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP BETA:1", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP BETA:2", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP BETA:3", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "PROP BETA:4", "Degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<EngineStruct>(simStructure);
   }

   public readonly EngineType EngineType => (EngineType)engineType;
   public readonly double EngTorquePsi1 => engTorque1 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi2 => engTorque2 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi3 => engTorque3 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi4 => engTorque4 / PoundFootToPSIFactor;

   public readonly EngineCondition EngineCondition1 => (EngineCondition)tubEngConditionLever1;
   public readonly EngineCondition EngineCondition2 => (EngineCondition)tubEngConditionLever2;
   public readonly EngineCondition EngineCondition3 => (EngineCondition)tubEngConditionLever3;
   public readonly EngineCondition EngineCondition4 => (EngineCondition)tubEngConditionLever4;


   public EngineStruct()
   {
   }
}
