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

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "NUMBER OF ENGINES", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
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

      simConnect.RegisterDataDefineStruct<EngineStruct>(simStructure);
   }

   public readonly double EngTorquePsi1 => engTorque1 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi2 => engTorque2 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi3 => engTorque3 / PoundFootToPSIFactor;
   public readonly double EngTorquePsi4 => engTorque4 / PoundFootToPSIFactor;

   public EngineStruct()
   {
   }
}
