using MacroSim.SimConnection.Enumerations;
using MacroSim.SimConnection.Structures;
using Microsoft.FlightSimulator.SimConnect;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MacroSim.SimConnection.SimConnection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacroSim.SimConnection;

public class SimConnection
{
   public delegate void DataReceivedEventHandler(object sender, object structure);
   public event DataReceivedEventHandler? DataReceived;

   public const int WM_USER_SIMCONNECT = 0x402;

   private SimConnect? simConnect = null;

   private readonly BackgroundWorker simConnectionBackgroundWorker = new BackgroundWorker();

   public AvionicsStruct AvionicsData { get; private set; }
   public TrimStruct TrimData { get; private set; }
   public LightsStruct LightsData { get; private set; }
   public CamerasStruct CamerasData { get; private set; }
   public TimeStruct TimeData { get; private set; }
   public EngineStruct EngineData { get; private set; }
   public SmartcamTargetsStruct SmartcamTargetData { get; private set; }
   public CameraType CameraType { get; set; } = CameraType.CockpitPilot;

   public SimConnection()
   {
      simConnectionBackgroundWorker.DoWork += SimConnectionBackgroundWorker_DoWork;
      simConnectionBackgroundWorker.RunWorkerCompleted += SimConnectionBackgroundWorker_RunWorkerCompleted;
   }

   public CameraType CameraTypeNext()
   {
      if (CameraType == CameraType.ShowcaseSmartcam)
         CameraType = CameraType.CockpitPilot;
      else
         CameraType++;

      return CameraType;
   }

   public CameraType CameraTypePrevious()
   {
      if (CameraType == CameraType.CockpitPilot)
         CameraType = CameraType.ShowcaseSmartcam;
      else
         CameraType--;

      return CameraType;
   }

   private void SimConnectionBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
   {
      if (e.Argument != null && e.Argument is nint handle)
      {
         DateTime startTime = DateTime.Now;
         if (simConnect == null)
         {
            try
            {
               simConnect = new SimConnect("Managed Data Request", handle, WM_USER_SIMCONNECT, null, 0);
               Initialize();
               System.Diagnostics.Debug.WriteLine($"Requesting Avionics");
               RequestDataOnSimObject(SimDataRequest.AvionicsRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Lights");
               RequestDataOnSimObject(SimDataRequest.LightsRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Trim");
               RequestDataOnSimObject(SimDataRequest.TrimRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Cameras");
               RequestDataOnSimObject(SimDataRequest.CamerasRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Time");
               RequestDataOnSimObject(SimDataRequest.TimeRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Engines");
               RequestDataOnSimObject(SimDataRequest.EngineRequest);
               System.Diagnostics.Debug.WriteLine($"Requesting Smartcam Targets");
               RequestDataOnSimObject(SimDataRequest.SmartcamTargetsRequest);
               return;
            }
            catch (COMException)
            {
               var elapsedTime = DateTime.Now - startTime;
               System.Diagnostics.Debug.WriteLine($"Elapsed time: {elapsedTime.TotalSeconds} s");
               return;
            }
         }
      }
   }

   private void SimConnectionBackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
   {

   }

   public bool IsConnected => simConnect != null;

   protected virtual void OnDataReceived(object structure)
   {
      DataReceived?.Invoke(this, structure);
   }

   public bool ConnectToSim(nint handle)
   {
      simConnectionBackgroundWorker.RunWorkerAsync(handle);
      return false;
   }

   public void DisconnectFromSim()
   {
      if (simConnect != null)
      {
         simConnect.Dispose();
         simConnect = null;
      }
   }

   private void Initialize()
   {
      if (simConnect != null)
      {
         simConnect.OnRecvOpen += Simconnect_OnRecvOpen;
         simConnect.OnRecvQuit += Simconnect_OnRecvQuit;
         simConnect.OnRecvException += Simconnect_OnRecvException;
         simConnect.OnRecvSimobjectDataBytype += Simconnect_OnRecvSimobjectDataBytype;
         simConnect.OnRecvSimobjectData += Simconnect_OnRecvSimobjectData;

         AvionicsStruct.InitializeSimConnect(simConnect, SimStructure.AvionicsStruct);
         CamerasStruct.InitializeSimConnect(simConnect, SimStructure.CamerasStruct);
         LightsStruct.InitializeSimConnect(simConnect, SimStructure.LightsStruct);
         TimeStruct.InitializeSimConnect(simConnect, SimStructure.TimeStruct);
         TrimStruct.InitializeSimConnect(simConnect, SimStructure.TrimStruct);
         EngineStruct.InitializeSimConnect(simConnect, SimStructure.EngineStruct);
         SmartcamTargetsStruct.InitializeSimConnect(simConnect, SimStructure.SmartcamTargetsStruct);
      }
   }

   private void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
   {
      //OnDataReceived(data.dwData[0]);
      //return;

      //if (data.dwData[0] is AvionicsStruct s)
      //{
      //}

      SimDataRequest simDataRequest = (SimDataRequest)data.dwRequestID;

      switch (simDataRequest)
      {
         case SimDataRequest.AvionicsRequest:
            AvionicsStruct avionicsStruct = (AvionicsStruct)data.dwData[0];
            AvionicsData = avionicsStruct;
            OnDataReceived(avionicsStruct);
            break;
         case SimDataRequest.LightsRequest:
            LightsStruct lightsStruct = (LightsStruct)data.dwData[0];
            LightsData = lightsStruct;
            OnDataReceived(lightsStruct);
            break;
         case SimDataRequest.TrimRequest:
            TrimStruct trimStruct = (TrimStruct)data.dwData[0];
            TrimData = trimStruct;
            OnDataReceived(trimStruct);
            break;
         case SimDataRequest.CamerasRequest:
            CamerasStruct camerasStruct = (CamerasStruct)data.dwData[0];
            CamerasData = camerasStruct;
            OnDataReceived(camerasStruct);
            break;
         case SimDataRequest.TimeRequest:
            TimeStruct timeStruct = (TimeStruct)data.dwData[0];
            TimeData = timeStruct;
            OnDataReceived(timeStruct);
            break;
         case SimDataRequest.EngineRequest:
            EngineStruct engineStruct = (EngineStruct)data.dwData[0];
            EngineData = engineStruct;
            OnDataReceived(engineStruct);
            break;
         case SimDataRequest.SmartcamTargetsRequest:
            SmartcamTargetsStruct smartcamTargetsStruct = (SmartcamTargetsStruct)data.dwData[0];
            SmartcamTargetData = smartcamTargetsStruct;
            OnDataReceived(smartcamTargetsStruct);
            break;
      }

      return;

      if (data.dwRequestID == (uint)SimDataRequest.AvionicsRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.LightsRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.TrimRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.CamerasRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.TimeRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.EngineRequest)
      {
      }
      else if (data.dwRequestID == (uint)SimDataRequest.SmartcamTargetsRequest)
      {
      }
   }


   private void Simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
   {
      OnDataReceived(data.dwData[0]);
      return;

      if (data.dwRequestID == (uint)SimDataRequest.AvionicsRequest)
      {
         AvionicsStruct s = (AvionicsStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.LightsRequest)
      {
         LightsStruct s = (LightsStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.TrimRequest)
      {
         TrimStruct s = (TrimStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.CamerasRequest)
      {
         CamerasStruct s = (CamerasStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.TimeRequest)
      {
         TimeStruct s = (TimeStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.EngineRequest)
      {
         EngineStruct s = (EngineStruct)data.dwData[0];
         OnDataReceived(s);
      }
      else if (data.dwRequestID == (uint)SimDataRequest.SmartcamTargetsRequest)
      {
         SmartcamTargetsStruct s = (SmartcamTargetsStruct)data.dwData[0];
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

   public void SetDataOnSimObject(Enum defineId, object dataSet)
   {
      simConnect?.SetDataOnSimObject(
         DefineID: defineId,
         ObjectID: SimConnect.SIMCONNECT_OBJECT_ID_USER,
         Flags: SIMCONNECT_DATA_SET_FLAG.DEFAULT,
         pDataSet: dataSet);
   }

   public void SetCamera(int state, int subState, int index0, int index1)
   {
      CamerasStruct newCamera = new CamerasStruct(state, subState, index0, index1);
      newCamera.IsSmartCamActive = CamerasData.IsSmartCamActive;
      SetCamera(newCamera);
   }

   public void SetCamera(CamerasStruct camera)
   {
      SetDataOnSimObject(SimStructDefinition.CamerasStruct, camera);
   }

   public void SetSmartcamera(bool? enabled = null)
   {
      if (enabled == null)
      {
         enabled = !CamerasData.IsSmartCamActive;
      }

      CamerasStruct newCamera = CamerasData;
      newCamera.IsSmartCamActive = enabled.Value;
      SetCamera(newCamera);
   }

   public void RequestDataOnSimObjectType()
   {
      simConnect?.RequestDataOnSimObjectType(
         RequestID: SimDataRequest.AvionicsRequest,
         DefineID: SimStructDefinition.AvionicsStruct,
         dwRadiusMeters: 0,
         type: SIMCONNECT_SIMOBJECT_TYPE.USER);
   }

   public void RequestDataOnSimObject(SimDataRequest requestId)
   {
      SimStructDefinition defineId;
      switch (requestId)
      {
         case SimDataRequest.AvionicsRequest:
         default:
            defineId = SimStructDefinition.AvionicsStruct;
            break;
         case SimDataRequest.LightsRequest:
            defineId = SimStructDefinition.LightsStruct;
            break;
         case SimDataRequest.TrimRequest:
            defineId = SimStructDefinition.TrimStruct;
            break;
         case SimDataRequest.CamerasRequest:
            defineId = SimStructDefinition.CamerasStruct;
            break;
         case SimDataRequest.TimeRequest:
            defineId = SimStructDefinition.TimeStruct;
            break;
         case SimDataRequest.EngineRequest:
            defineId = SimStructDefinition.EngineStruct;
            break;
         case SimDataRequest.SmartcamTargetsRequest:
            defineId = SimStructDefinition.SmartcamTargetsStruct;
            break;
      }
      simConnect?.RequestDataOnSimObject(
         RequestID: requestId,
         DefineID: defineId,
         ObjectID: (uint)SIMCONNECT_SIMOBJECT_TYPE.USER,
         Period: SIMCONNECT_PERIOD.SIM_FRAME,
         //Flags: SIMCONNECT_DATA_REQUEST_FLAG.CHANGED,
         Flags: 0,
         origin: 0,
         //interval: 5,
         interval: 0,
         limit: 0);
   }

   public void ReceiveMessage()
   {
      simConnect?.ReceiveMessage();
   }

   public void SendEvent(SimEvent simEvent, uint dwData = 0)
   {
      if (simEvent == SimEvent.NONE)
         return;

      SendEvent(simEvent, simEvent.ToString(), dwData);
   }

   public void SendEvent(SimEvent simEvent, string eventName, uint dwData = 0)
   {
      if (simEvent == SimEvent.NONE)
         return;

      try
      {
         if (simConnect != null)
         {
            simConnect.MapClientEventToSimEvent(simEvent, eventName);
            simConnect.TransmitClientEvent(0U, simEvent, dwData, SimNotificationGroup.Group0, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending " + eventName);
         }
      }
      catch (COMException ex)
      {
         System.Diagnostics.Debug.WriteLine(ex.Message);
      }
   }
}


//public enum CameraType : int
//{
//   Undefined = 0,
//   CockpitPilot = 02010101,
//   CockpitInstrument = 02050200,
//   CockpitQuickView = 02030300,
//   CockpitSmartcam = 02000000,
//   ExternalDefault = 03010000,
//   ExternalQuickView = 03030400,
//   ExternalSmartcam = 03000000,
//   ShowcaseFree = 04000000,
//   ShowcaseFixed = 05000500,
//   ShowcaseSmartcam = 05000000
//}