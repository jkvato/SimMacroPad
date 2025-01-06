using MacroSim.SimConnection.Enumerations;
using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Structures;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct SmartcamTargetsStruct
{
   public const int MaxTargetCount = 60;

   //public int smartCameraActive;    // RW : Gets or sets whether the smartcam is active
   //public int smartCameraInfo0;     // R  : Gets the number of smartcam targets
   //public int smartCameraInfo1;     // RW : Gets or sets the index of the current smartcam target

   public int smartCameraList00;    // R  : Gets the smartcam target type
   public int smartCameraList01;    // R  : Gets the smartcam target type
   public int smartCameraList02;    // R  : Gets the smartcam target type
   public int smartCameraList03;    // R  : Gets the smartcam target type
   public int smartCameraList04;    // R  : Gets the smartcam target type
   public int smartCameraList05;    // R  : Gets the smartcam target type
   public int smartCameraList06;    // R  : Gets the smartcam target type
   public int smartCameraList07;    // R  : Gets the smartcam target type
   public int smartCameraList08;    // R  : Gets the smartcam target type
   public int smartCameraList09;    // R  : Gets the smartcam target type
   public int smartCameraList10;    // R  : Gets the smartcam target type
   public int smartCameraList11;    // R  : Gets the smartcam target type
   public int smartCameraList12;    // R  : Gets the smartcam target type
   public int smartCameraList13;    // R  : Gets the smartcam target type
   public int smartCameraList14;    // R  : Gets the smartcam target type
   public int smartCameraList15;    // R  : Gets the smartcam target type
   public int smartCameraList16;    // R  : Gets the smartcam target type
   public int smartCameraList17;    // R  : Gets the smartcam target type
   public int smartCameraList18;    // R  : Gets the smartcam target type
   public int smartCameraList19;    // R  : Gets the smartcam target type
   public int smartCameraList20;    // R  : Gets the smartcam target type
   public int smartCameraList21;    // R  : Gets the smartcam target type
   public int smartCameraList22;    // R  : Gets the smartcam target type
   public int smartCameraList23;    // R  : Gets the smartcam target type
   public int smartCameraList24;    // R  : Gets the smartcam target type
   public int smartCameraList25;    // R  : Gets the smartcam target type
   public int smartCameraList26;    // R  : Gets the smartcam target type
   public int smartCameraList27;    // R  : Gets the smartcam target type
   public int smartCameraList28;    // R  : Gets the smartcam target type
   public int smartCameraList29;    // R  : Gets the smartcam target type
   public int smartCameraList30;    // R  : Gets the smartcam target type
   public int smartCameraList31;    // R  : Gets the smartcam target type
   public int smartCameraList32;    // R  : Gets the smartcam target type
   public int smartCameraList33;    // R  : Gets the smartcam target type
   public int smartCameraList34;    // R  : Gets the smartcam target type
   public int smartCameraList35;    // R  : Gets the smartcam target type
   public int smartCameraList36;    // R  : Gets the smartcam target type
   public int smartCameraList37;    // R  : Gets the smartcam target type
   public int smartCameraList38;    // R  : Gets the smartcam target type
   public int smartCameraList39;    // R  : Gets the smartcam target type
   public int smartCameraList40;    // R  : Gets the smartcam target type
   public int smartCameraList41;    // R  : Gets the smartcam target type
   public int smartCameraList42;    // R  : Gets the smartcam target type
   public int smartCameraList43;    // R  : Gets the smartcam target type
   public int smartCameraList44;    // R  : Gets the smartcam target type
   public int smartCameraList45;    // R  : Gets the smartcam target type
   public int smartCameraList46;    // R  : Gets the smartcam target type
   public int smartCameraList47;    // R  : Gets the smartcam target type
   public int smartCameraList48;    // R  : Gets the smartcam target type
   public int smartCameraList49;    // R  : Gets the smartcam target type
   public int smartCameraList50;    // R  : Gets the smartcam target type
   public int smartCameraList51;    // R  : Gets the smartcam target type
   public int smartCameraList52;    // R  : Gets the smartcam target type
   public int smartCameraList53;    // R  : Gets the smartcam target type
   public int smartCameraList54;    // R  : Gets the smartcam target type
   public int smartCameraList55;    // R  : Gets the smartcam target type
   public int smartCameraList56;    // R  : Gets the smartcam target type
   public int smartCameraList57;    // R  : Gets the smartcam target type
   public int smartCameraList58;    // R  : Gets the smartcam target type
   public int smartCameraList59;    // R  : Gets the smartcam target type

   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription00;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription01;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription02;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription03;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription04;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription05;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription06;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription07;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription08;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription09;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription10;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription11;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription12;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription13;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription14;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription15;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription16;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription17;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription18;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription19;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription20;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription21;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription22;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription23;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription24;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription25;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription26;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription27;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription28;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription29;   // R  : Gets the smartcam target description

   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription30;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription31;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription32;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription33;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription34;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription35;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription36;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription37;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription38;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription39;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription40;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription41;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription42;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription43;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription44;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription45;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription46;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription47;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription48;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription49;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription50;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription51;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription52;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription53;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription54;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription55;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription56;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription57;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription58;   // R  : Gets the smartcam target description
   [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
   public string smartCameraListDescription59;   // R  : Gets the smartcam target description

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      //simConnect.AddToDataDefinition(simStructure, "SMART CAMERA ACTIVE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      //simConnect.AddToDataDefinition(simStructure, "SMART CAMERA INFO:0", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      //simConnect.AddToDataDefinition(simStructure, "SMART CAMERA INFO:1", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      for (int i = 0; i < MaxTargetCount; i++)
      {
         simConnect.AddToDataDefinition(simStructure, $"SMART CAMERA LIST:{i}", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      }

      for (int i = 0; i < MaxTargetCount; i++)
      {
         simConnect.AddToDataDefinition(simStructure, $"SMART CAMERA LIST DESCRIPTION:{i}", null, SIMCONNECT_DATATYPE.STRING32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      }

      simConnect.RegisterDataDefineStruct<SmartcamTargetsStruct>(simStructure);
   }

   //public bool IsSmartCamActive
   //{
   //   get { return smartCameraActive == 1; }
   //   set { smartCameraActive = value ? 1 : 0; }
   //}

   //public readonly int AvailableTargets => smartCameraInfo0;

   //public int CurrentTarget
   //{
   //   get { return smartCameraInfo1; }
   //   set { smartCameraInfo1 = value; }
   //}

   public SmartcamTargetType GetTargetType(int index)
   {
      Type targetsType = typeof(SmartcamTargetsStruct);

      FieldInfo[] fields = targetsType.GetFields(BindingFlags.Instance | BindingFlags.Public);
      FieldInfo? field = fields.FirstOrDefault(x => x.Name == $"smartCameraList{index:00}");
      if (field != null)
      {
         var result = field.GetValue(this);
         if (result != null)
         {
            return (SmartcamTargetType)(int)result;
         }
      }

      return SmartcamTargetType.Unknown;
   }

   public string GetTargetDescription(int index)
   {
      Type targetsType = typeof(SmartcamTargetsStruct);

      FieldInfo[] fields = targetsType.GetFields(BindingFlags.Instance | BindingFlags.Public);
      FieldInfo? field = fields.FirstOrDefault(x => x.Name == $"smartCameraListDescription{index:00}");
      if (field != null)
      {
         var result = field.GetValue(this);
         if (result != null)
         {
            return (string)result;
         }
      }

      return string.Empty;
   }

   public Tuple<SmartcamTargetType, string> GetSmartcamTarget(int index)
   {
      SmartcamTargetType resultTargetType = SmartcamTargetType.Unknown;
      string resultDescription = string.Empty;

      if (index < 0 || index >= MaxTargetCount)
      {
         return new Tuple<SmartcamTargetType, string>(resultTargetType, string.Empty);
      }

      Type targetsType = typeof(SmartcamTargetsStruct);

      FieldInfo[] fields = targetsType.GetFields(BindingFlags.Instance | BindingFlags.Public);

      // Get SmartcamTargetType
      FieldInfo? targetTypeField = fields.FirstOrDefault(x => x.Name == $"smartCameraList{index:00}");
      if (targetTypeField != null)
      {
         object? result = targetTypeField.GetValue(this);
         if (result != null)
         {
            resultTargetType = (SmartcamTargetType)(int)result;
         }
      }

      // Get Description
      FieldInfo? descriptionField = fields.FirstOrDefault(x => x.Name == $"smartCameraListDescription{index:00}");
      if (descriptionField != null)
      {
         object? result = descriptionField.GetValue(this);
         if (result != null)
         {
            resultDescription = (string)result;
         }
      }

      return new Tuple<SmartcamTargetType, string>(resultTargetType, resultDescription);
   }

}
