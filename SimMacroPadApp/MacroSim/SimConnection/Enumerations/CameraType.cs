using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum CameraType : int
{
   Undefined = 0,
   CockpitPilot = 1,
   CockpitInstrument = 2,
   CockpitQuickView = 3,
   ExternalDefault = 4,
   ExternalQuickView = 5,
   ShowcaseFree = 6,
   ShowcaseFixed = 7,
   Custom = 8,
   CockpitSmartcam = 104,
   ExternalSmartcam = 107,
   CustomSmartcam = 108,
   ShowcaseSmartcam = 110, 
}

public class CameraTypeClass
{
   public static readonly CameraTypeClass[] StandardCameras;

   public CameraType CameraType { get; set; }

   public CameraState CameraState { get; set; }

   public CameraSubState CameraSubState { get; set; }

   public CameraViewIndex0 CameraViewIndex0 { get; set; }

   public int CameraViewIndex1 { get; set; }

   public CameraTypeClass()
   {

   }

   public CameraTypeClass(
      CameraType cameraType,
      CameraState cameraState,
      CameraSubState cameraSubState,
      CameraViewIndex0 cameraViewIndex0,
      int cameraViewIndex1)
   {
      CameraType = cameraType;
      CameraState = cameraState;
      CameraSubState = cameraSubState;
      CameraViewIndex0 = cameraViewIndex0;
      CameraViewIndex1 = cameraViewIndex1;
   }

   static CameraTypeClass()
   {
      List<CameraTypeClass> list = new List<CameraTypeClass>();

      list.Add(new CameraTypeClass(
         CameraType.CockpitPilot,
         CameraState.Cockpit,
         CameraSubState.Locked,
         CameraViewIndex0.PilotView,
         1));

      list.Add(new CameraTypeClass(
         CameraType.CockpitInstrument,
         CameraState.Cockpit,
         CameraSubState.Instrument,
         CameraViewIndex0.Instruments,
         0));

      list.Add(new CameraTypeClass(
         CameraType.CockpitQuickView,
         CameraState.Cockpit,
         CameraSubState.QuickView,
         CameraViewIndex0.QuickView,
         0));

      list.Add(new CameraTypeClass(
         CameraType.ExternalDefault,
         CameraState.External,
         CameraSubState.Locked,
         CameraViewIndex0.Default,
         0));

      list.Add(new CameraTypeClass(
         CameraType.ExternalQuickView,
         CameraState.External,
         CameraSubState.QuickView,
         CameraViewIndex0.QuickViewExternal,
         0));

      list.Add(new CameraTypeClass(
         CameraType.ShowcaseFree,
         CameraState.Drone,
         CameraSubState.None,
         CameraViewIndex0.Default,
         0));

      list.Add(new CameraTypeClass(
         CameraType.ShowcaseFixed,
         CameraState.Plane,
         CameraSubState.None,
         CameraViewIndex0.View,
         0));

      list.Add(new CameraTypeClass(
         CameraType.Custom,
         CameraState.Cockpit,
         CameraSubState.Locked,
         CameraViewIndex0.PilotView,
         7));

      StandardCameras = list.ToArray();
   }

}
