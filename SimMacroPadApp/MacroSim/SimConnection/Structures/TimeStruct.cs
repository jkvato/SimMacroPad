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
public struct TimeStruct
{
   public double simulationRate;
   public double simulationTime;
   public double localTime;
   public int localDayOfMonth;
   public int localMonthOfYear;
   public int localYear;
   public double timeZoneOffset;
   public double absoluteTime;

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "SIMULATION RATE", "Number", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SIMULATION TIME", "Seconds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LOCAL TIME", "Seconds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LOCAL DAY OF MONTH", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LOCAL MONTH OF YEAR", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "LOCAL YEAR", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "TIME ZONE OFFSET", "Seconds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "ABSOLUTE TIME", "Seconds", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<TimeStruct>(simStructure);
   }

   public readonly DateTime LocalDateTime
   {
      get
      {
         TimeSpan span = TimeSpan.FromSeconds(localTime);
         DateTime dateTime = new DateTime(
            localYear,
            localMonthOfYear,
            localDayOfMonth);
         dateTime += span;
         return dateTime;
      }
   }

   public readonly TimeOnly LocalTime
   {
      get
      {
         TimeSpan span = TimeSpan.FromSeconds(localTime);
         return TimeOnly.FromTimeSpan(span);
      }
   }

   public readonly DateTime AbsoluteTime
   {
      get
      {
         TimeSpan span = TimeSpan.FromSeconds(absoluteTime);
         DateTime dateTime = new DateTime(0, DateTimeKind.Utc);
         dateTime += span;
         return dateTime;
      }
   }

   public SimulationRate SimulationRate
   {
      get => new SimulationRate(simulationRate);
      set => simulationRate = value.RateOfTime;
   }
}
