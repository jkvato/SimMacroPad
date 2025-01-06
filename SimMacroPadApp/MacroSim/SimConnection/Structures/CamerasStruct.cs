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
public struct CamerasStruct
{
   public int cameraState;             // RW
   public int cameraSubState;          // RW
   public int cameraViewTypeIndex0;    // RW
   public int cameraViewTypeIndex1;    // RW
   public int cameraviewTypeMax0;
   public int cameraviewTypeMax1;
   public int cameraviewTypeMax2;
   public int cameraviewTypeMax3;
   public int cameraviewTypeMax4;
   public int cameraviewTypeMax5;
   public int cameraviewTypeMax6;
   public int cameraviewTypeMax7;
   public int cameraviewTypeMax8;
   public int cameraviewTypeMax9;
   public int smartCameraActive;       // RW
   public int smartCameraInfo0;        // R
   public int smartCameraInfo1;        // RW
   public int smartCameraList1;        // R

   public static void InitializeSimConnect(SimConnect simConnect, SimStructure simStructure)
   {
      simConnect.AddToDataDefinition(simStructure, "CAMERA STATE", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA SUBSTATE", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX:0", "Enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX:1", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:0", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:1", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:2", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:3", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:4", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:5", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:6", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:7", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:8", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "CAMERA VIEW TYPE AND INDEX MAX:9", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SMART CAMERA ACTIVE", "Bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SMART CAMERA INFO:0", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SMART CAMERA INFO:1", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
      simConnect.AddToDataDefinition(simStructure, "SMART CAMERA LIST:1", "Number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

      simConnect.RegisterDataDefineStruct<CamerasStruct>(simStructure);
   }

   public CamerasStruct()
   {
      CameraState = CameraState.Cockpit;
      CameraSubState = CameraSubState.Locked;
      CameraViewIndex0 = CameraViewIndex0.PilotView;
      CameraViewIndex1 = (int)CameraViewIndex1Pilot.Pilot;
   }

   public CamerasStruct(int state, int substate, int index0, int index1)
   {
      cameraState = state;
      cameraSubState = substate;
      cameraViewTypeIndex0 = index0;
      cameraViewTypeIndex1 = index1;
   }

   public bool IsSmartCamActive
   {
      get { return !(smartCameraActive == 0); }
      set { smartCameraActive = value ? 1 : 0; }
   }

   public CameraState CameraState
   {
      get => (CameraState)cameraState;
      set => cameraState = (int)value;
   }

   public CameraSubState CameraSubState
   {
      get => (CameraSubState)cameraSubState;
      set => cameraSubState = (int)value;
   }

   public CameraViewIndex0 CameraViewIndex0
   {
      get => (CameraViewIndex0)cameraViewTypeIndex0;
      set => cameraViewTypeIndex0 = (int)value;
   }

   public int CameraViewIndex1
   {
      get => cameraViewTypeIndex1;
      set => cameraViewTypeIndex1 = value;
   }

   public int SmartCameraTargetIndex
   {
      get => smartCameraInfo1;
      set => smartCameraInfo1 = value;
   }

   public void SetInstrumentCamera(CameraViewIndex1Instrument instrumentCamera)
   {
      CameraState = CameraState.Cockpit;
      CameraSubState = CameraSubState.Instrument;
      CameraViewIndex0 = CameraViewIndex0.Instruments;
      CameraViewIndex1 = (int)instrumentCamera - 1;
   }

   public void SetPilotCamera(CameraViewIndex1Pilot pilotCamera)
   {
      CameraState = CameraState.Cockpit;
      CameraSubState = CameraSubState.Locked;
      CameraViewIndex0 = CameraViewIndex0.PilotView;
      CameraViewIndex1 = ((int)pilotCamera) - 1;
   }

   public void SetCockpitQuickViewCamera(int cameraIndex)
   {
      CameraState = CameraState.Cockpit;
      CameraSubState = CameraSubState.QuickView;
      CameraViewIndex0 = CameraViewIndex0.QuickView;
      cameraViewTypeIndex1 = cameraIndex;
   }

   public void SetExternalDefaultCamera(int cameraIndex)
   {
      CameraState = CameraState.External;
      CameraSubState = CameraSubState.Locked;
      CameraViewIndex0 = CameraViewIndex0.Default;
      cameraViewTypeIndex1 = cameraIndex;
   }

   public void SetExternalQuickViewCamera(int cameraIndex)
   {
      CameraState = CameraState.External;
      CameraSubState = CameraSubState.QuickView;
      CameraViewIndex0 = CameraViewIndex0.QuickViewExternal;
      cameraViewTypeIndex1 = cameraIndex;
   }

   public void SetShowcaseDroneCamera(int cameraIndex)
   {
      CameraState = CameraState.Drone;
      cameraSubState = 0;
      CameraViewIndex0 = CameraViewIndex0.Default;
      cameraViewTypeIndex1 = cameraIndex;
   }

   public void SetShowcaseFixedCamera(int cameraIndex)
   {
      CameraState = CameraState.Plane;
      cameraSubState = 0;
      CameraViewIndex0 = CameraViewIndex0.View;
      cameraViewTypeIndex1 = cameraIndex;
   }

   public void SetCamera(int state, int substate, int index0, int index1)
   {
      cameraState = state;
      cameraSubState = substate;
      cameraViewTypeIndex0 = index0;
      cameraViewTypeIndex1 = index1;
   }

   public readonly bool IsInstrumentCamera1Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 0 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera2Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 1 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera3Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 2 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera4Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 3 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera5Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 4 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera6Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 5 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera7Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 6 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera8Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 7 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera9Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 8 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsInstrumentCamera10Active
      => (cameraViewTypeIndex0 == 2 && cameraViewTypeIndex1 == 9 && cameraState == 2 && cameraSubState == 5);
   public readonly bool IsPilotNormalCameraActive
      => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 1 && cameraState == 2 && cameraSubState == 1);
   public readonly bool IsPilotCloseCameraActive
      => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 0 && cameraState == 2 && cameraSubState == 1);
   public readonly bool IsPilotLandingCameraActive
      => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 2 && cameraState == 2 && cameraSubState == 1);
   public readonly bool IsPilotCoPilotCameraActive
      => (cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 4 && cameraState == 2 && cameraSubState == 1);

   public readonly bool IsCockpitPilotSubState
      => (cameraState == 2 && cameraSubState == 1 && cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 != 7);

   public readonly bool IsCockpitInstrumentSubState
      => (cameraState == 2 && cameraSubState == 5 && cameraViewTypeIndex0 == 2);

   public readonly bool IsCockpitQuickViewSubState
      => (cameraState == 2 && cameraSubState == 3 && cameraViewTypeIndex0 == 3);

   public readonly bool IsExternalDefaultSubState
      => (cameraState == 3 && cameraSubState == 1 && cameraViewTypeIndex0 == 0);

   public readonly bool IsExternalQuickViewSubState
      => (cameraState == 3 && cameraSubState == 3 && cameraViewTypeIndex0 == 4);

   public readonly bool IsShowcaseDroneSubState
      => (cameraState == 4 && cameraSubState == 0 && cameraViewTypeIndex0 == 0);

   public readonly bool IsShowcaseFixedSubState
      => (cameraState == 5 && cameraSubState == 0 && cameraViewTypeIndex0 == 5);

   public readonly bool IsCustomCamera
      => (cameraState == 2 && cameraSubState == 1 && cameraViewTypeIndex0 == 1 && cameraViewTypeIndex1 == 7);

   public void CockpitPilotCameraInc()
   {
      if (!IsCockpitPilotSubState)
         return;

      switch (cameraViewTypeIndex1)
      {
         case 0:
            cameraViewTypeIndex1 = 1;
            break;
         case 1:
            cameraViewTypeIndex1 = 2;
            break;
         case 2:
            cameraViewTypeIndex1 = 4;
            break;
         case 4:
            cameraViewTypeIndex1 = 0;
            break;
      }
   }

   public void CockpitPilotCameraDec()
   {
      if (!IsCockpitPilotSubState)
         return;

      switch (cameraViewTypeIndex1)
      {
         case 0:
            cameraViewTypeIndex1 = 4;
            break;
         case 1:
            cameraViewTypeIndex1 = 0;
            break;
         case 2:
            cameraViewTypeIndex1 = 1;
            break;
         case 4:
            cameraViewTypeIndex1 = 2;
            break;
      }
   }

   public void CameraViewTypeIndex1Inc()
   {
      cameraViewTypeIndex1++;
      if (cameraViewTypeIndex1 == 10)
         cameraViewTypeIndex1 = 0;
   }

   public void CameraViewTypeIndex1Dec()
   {
      cameraViewTypeIndex1--;
      if (cameraViewTypeIndex1 == -1)
         cameraViewTypeIndex1 = 9;
   }

   public static CamerasStruct FromCameraType(CameraType cameraType)
   {
      switch (cameraType)
      {
         case CameraType.CockpitPilot:
         default:
            return new CamerasStruct(2, 1, 1, 1);
         case CameraType.CockpitInstrument:
            return new CamerasStruct(2, 5, 2, 0);
         case CameraType.CockpitQuickView:
            return new CamerasStruct(2, 3, 3, 0);
         case CameraType.CockpitSmartcam:
            return new CamerasStruct(2, 4, 1, 1);
         case CameraType.ExternalDefault:
            return new CamerasStruct(3, 1, 0, 0);
         case CameraType.ExternalQuickView:
            return new CamerasStruct(3, 3, 4, 0);
         case CameraType.ExternalSmartcam:
            return new CamerasStruct(3, 4, 0, 0);
         case CameraType.ShowcaseFree:
            return new CamerasStruct(4, 0, 0, 0);
         case CameraType.ShowcaseFixed:
            return new CamerasStruct(5, 0, 5, 0);
         case CameraType.ShowcaseSmartcam:
            return new CamerasStruct(4, 0, 0, 0);
      }
   }

   //public static CamerasStruct FromCameraType(CameraType cameraType)
   //{
   //   CamerasStruct result = new CamerasStruct();
   //   string cameraTypeStr = string.Format("0:00000000", (int)cameraType);
   //   result.cameraState = int.Parse(cameraTypeStr.Substring(0, 2));
   //   result.cameraSubState = int.Parse(cameraTypeStr.Substring(2, 2));
   //   result.cameraViewTypeIndex0 = int.Parse(cameraTypeStr.Substring(4, 2));
   //   result.cameraViewTypeIndex1 = int.Parse(cameraTypeStr.Substring(6, 2));
   //   return result;
   //}

   //public int GetCurrentCameraTypeInt()
   //{
   //   string cameraTypeStr = string.Format("{0:00}{1:00}{2:00}", cameraState, cameraSubState, cameraViewTypeIndex0);
   //   return int.Parse(cameraTypeStr);
   //}

   //public CameraType GetCurrentCameraType()
   //{
   //   try
   //   {
   //      return (CameraType)GetCurrentCameraTypeInt();
   //   }
   //   catch
   //   {
   //      return CameraType.Undefined;
   //   }
   //}

   //public CameraType NextCameraType()
   //{
   //   CameraType cameraType = GetCurrentCameraType();
   //   CameraType newCameraType = CameraType.Undefined;
   //   switch (cameraType)
   //   {
   //      case CameraType.CockpitPilot:
   //         newCameraType = CameraType.CockpitInstrument;
   //         break;
   //      case CameraType.CockpitInstrument:
   //         newCameraType = CameraType.CockpitQuickView;
   //         break;
   //      case CameraType.CockpitQuickView:
   //         newCameraType = CameraType.ExternalDefault;
   //         break;
   //      case CameraType.ExternalDefault:
   //         newCameraType = CameraType.ExternalQuickView;
   //         break;
   //      case CameraType.ExternalQuickView:
   //         newCameraType = CameraType.ShowcaseFree;
   //         break;
   //      case CameraType.ShowcaseFree:
   //         newCameraType = CameraType.ShowcaseFixed;
   //         break;
   //      case CameraType.ShowcaseFixed:
   //      default:
   //         newCameraType = CameraType.CockpitPilot;
   //         break;
   //   }
   //   return newCameraType;
   //}
   //}
}
