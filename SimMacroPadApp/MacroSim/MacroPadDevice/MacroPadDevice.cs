using Hds.MacroLink.Serial;
using Hds.MacroPad;
using MacroSim.MacroPadDevice.Enumerations;
using MacroSim.SimConnection.Enumerations;
using MacroSim.SimConnection.Structures;
using Serilog;
using System.Diagnostics;
using System.IO.Ports;

namespace MacroSim.MacroPadDevice;

internal class MacroPadDevice
{
   //public readonly SerialPort SerialPort;
   public SerialMacroLinkTransport? Transport;
   public MacroPadClient? MacroPadClient;

   public SimConnection.SimConnection SimConnection { get; private set; }
   public Fsuipc.FsuipcConnection FsuipcConnection { get; private set; }

   public SimAircraft.SimAircraft? CurrentAircraft { get; set; }

   public MacroPadState State { get; private set; } = MacroPadState.None;

   public bool LogEnabled { get; set; } = false;

   private int apAltitude = 0;

   public delegate void EventProcessedEventHandler(object sender, EventProcessedEventArgs e);
   public event EventProcessedEventHandler? EventProcessed;

   private readonly SimMessage simMessage;

   private readonly ILogger logger;

   public MacroPadDevice(SimConnection.SimConnection simConnection, Fsuipc.FsuipcConnection fsuipcConnection)
   {
      logger = Log.ForContext<MacroPadDevice>();

      CurrentAircraft = null;
      //SerialPort = new SerialPort();
      //SerialPort.DataReceived += SerialPort_DataReceivedFromDevice;
      SimConnection = simConnection;
      FsuipcConnection = fsuipcConnection;
      simMessage = new SimMessage();

      Transport = null;
      MacroPadClient = null;
   }

   public async Task<bool> SetSerialPort(string portName)
   {
      if (Transport != null)
      {
         await Transport.CloseAsync();
         Transport = null;
      }

      if (MacroPadClient != null)
      {
         MacroPadClient = null;
      }

      Transport = new SerialMacroLinkTransport(portName, 115200);
      logger.Information("Opening MacroPad on port {PortName}", portName);

      MacroPadClient = new MacroPadClient(Transport);
      logger.Information("MacroPad Client created");

      MacroPadClient.PadInputEventReceived += MacroPad_DataReceivedFromDevice;

      await MacroPadClient.OpenAsync();
      logger.Information("MacroPad Client opened");

      return true;

      //try
      //{
      //   SerialPort.Close();
      //   SerialPort.PortName = portName;
      //   SerialPort.RtsEnable = true;
      //   SerialPort.DtrEnable = true;
      //   SerialPort.Open();
      //   return true;
      //}
      //catch
      //{
      //   return false;
      //}
   }

   private void MacroPad_DataReceivedFromDevice(object? sender, byte eByte)
   {
      int componentID = eByte & 0b11111000;
      componentID = componentID >> 3;
      MacroPadComponent component = (MacroPadComponent)componentID;

      int eventID = eByte & 0b00000111;
      MacroPadEvent eventType = (MacroPadEvent)eventID;

      Stopwatch sw = Stopwatch.StartNew();
      if (LogEnabled)
         logger.Information("MacroPad event received: Component: {Component}, Event: {EventType}", component, eventType);
      
      ProcessMacroPadEvent(component, eventType);
      
      if (LogEnabled)
         logger.Information("MacroPad event processed in {ElapsedMilliseconds} ms", sw.ElapsedMilliseconds);
   }

   public void UpdateData(object structure)
   {
      Stopwatch sw = Stopwatch.StartNew();
      if (LogEnabled)
         logger.Information("Updating MacroPad display for state {State}", State);

      if (structure is AvionicsStruct avionicsStruct)
      {
         apAltitude = avionicsStruct.apAltitudeSel;

         switch (State)
         {
            case MacroPadState.COM1_MHZ:
            case MacroPadState.COM1_KHZ:
               simMessage.Text1 = string.Format("{0:000.000} s", avionicsStruct.com1standby);
               simMessage.Text2 = string.Format("{0:000.000} A", avionicsStruct.com1active);
               break;
            case MacroPadState.COM2_MHZ:
            case MacroPadState.COM2_KHZ:
               simMessage.Text1 = string.Format("{0:000.000} s", avionicsStruct.com2standby);
               simMessage.Text2 = string.Format("{0:000.000} A", avionicsStruct.com2active);
               break;
            case MacroPadState.NAV1_MHZ:
            case MacroPadState.NAV1_KHZ:
               simMessage.Text1 = string.Format("{0:000.00} s", avionicsStruct.nav1standby);
               simMessage.Text2 = string.Format("{0:000.00} A", avionicsStruct.nav1active);
               break;
            case MacroPadState.NAV2_MHZ:
            case MacroPadState.NAV2_KHZ:
               simMessage.Text1 = string.Format("{0:000.00} s", avionicsStruct.nav2standby);
               simMessage.Text2 = string.Format("{0:000.00} A", avionicsStruct.nav2active);
               break;
            case MacroPadState.HEADING:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apHeadingSel);
               break;
            case MacroPadState.COURSE1:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apNav1ObsSel);
               break;
            case MacroPadState.COURSE2:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apNav2ObsSel);
               break;
            case MacroPadState.BAROMETER:
               simMessage.Text1 = string.Format("{0:00.00}", avionicsStruct.baro1Setting);
               break;
            case MacroPadState.ALTITUDE_1000:
            case MacroPadState.ALTITUDE_100:
               simMessage.Text1 = string.Format("{0:00000}", avionicsStruct.apAltitudeSel);
               break;
            case MacroPadState.VERTICAL_SPEED:
               simMessage.Text1 = string.Format("{0:+0000;-0000; 0000}", avionicsStruct.apVerticalSpeedSel);
               break;
            case MacroPadState.XPND_1000:
            case MacroPadState.XPND_100:
            case MacroPadState.XPND_10:
            case MacroPadState.XPND_1:
               simMessage.Text1 = string.Format("{0:0000}", avionicsStruct.transponderCode);
               break;
            case MacroPadState.IAS:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apAirspeedHoldSel);
               break;
            case MacroPadState.MACH:
               simMessage.Text1 = string.Format("{0:0.00}", avionicsStruct.apMachHoldSel);
               break;
            case MacroPadState.AS530_RT_SM:
            case MacroPadState.AS530_RT_LG:
            case MacroPadState.AS430_RT_SM:
            case MacroPadState.AS430_RT_LG:
            case MacroPadState.AS530_LF_SM:
            case MacroPadState.AS530_LF_LG:
            case MacroPadState.AS430_LF_SM:
            case MacroPadState.AS430_LF_LG:
               simMessage.Text1 = "        ";
               break;
            case MacroPadState.AS1000_PFD_LG:
            case MacroPadState.AS1000_PFD_SM:
            case MacroPadState.AS1000_MFD_LG:
            case MacroPadState.AS1000_MFD_SM:
               simMessage.Text1 = "        ";
               break;
            case MacroPadState.PFD_GROUP:
            case MacroPadState.PFD_PAGE:
            case MacroPadState.MFD_GROUP:
            case MacroPadState.MFD_PAGE:
               simMessage.Text1 = "        ";
               break;
            default:
               simMessage.Text1 = string.Empty;
               break;
         }

         simMessage.MacroPadState = State;

         //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending SimMessage via SerialPort ");

         // SEND THE MESSAGE TO THE MACROPAD
         //simMessage.Send(SerialPort);

         if (MacroPadClient != null)
         {
            MacroPadClient.SendSimMessageAsync(simMessage);
         }
      }
      else if (structure is LightsStruct lightsStruct)
      {
      }

      if (LogEnabled)
         logger.Information("MacroPad display updated in {ElapsedMilliseconds} ms", sw.ElapsedMilliseconds);
   }

   protected virtual void OnEventProcessed(EventProcessedEventArgs e)
   {
      EventProcessed?.Invoke(this, e);
   }

   //private void SerialPort_DataReceivedFromDevice(object sender, SerialDataReceivedEventArgs e)
   //{
   //   int data = 0;
   //   try
   //   {
   //      //data = SerialPort.ReadByte();
   //   }
   //   catch
   //   {
   //      return;
   //   }
   //   var bytes = BitConverter.GetBytes(data);
   //   var b = bytes[0];

   //   int componentID = b & 0b11111000;
   //   componentID = componentID >> 3;
   //   MacroPadComponent component = (MacroPadComponent)componentID;

   //   int eventID = b & 0b00000111;
   //   MacroPadEvent eventType = (MacroPadEvent)eventID;

   //   ProcessMacroPadEvent(component, eventType);
   //}

   private MacroPadState GetNewState(
      MacroPadComponent component,
      MacroPadState currentState,
      MacroPadEvent eventType,
      SimAircraft.SimAircraft? currentAircraft)
   {
      if (eventType != MacroPadEvent.Clicked)
      {
         return MacroPadState.None;
      }

      if (currentAircraft == null)
      {
         return MacroPadState.None;
      }

      MacroPadState newState = MacroPadState.None;

      switch (component)
      {
         // AV1 BUTTON
         case MacroPadComponent.AV1:
            if (currentAircraft.HasAS530)
            {
               switch (State)
               {
                  case MacroPadState.AS530_LF_LG:
                     newState = MacroPadState.AS530_LF_SM;
                     break;
                  case MacroPadState.AS530_LF_SM:
                  default:
                     newState = MacroPadState.AS530_LF_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS1000)
            {
               switch (State)
               {
                  case MacroPadState.AS1000_PFD_LG:
                     newState = MacroPadState.AS1000_PFD_SM;
                     break;
                  case MacroPadState.AS1000_PFD_SM:
                  default:
                     newState = MacroPadState.AS1000_PFD_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Horiz1x || currentAircraft.HasAS3000Horiz2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000H_TSC1_TOP_LG:
                     newState = MacroPadState.AS3000H_TSC1_TOP_SM;
                     break;
                  case MacroPadState.AS3000H_TSC1_TOP_SM:
                  default:
                     newState = MacroPadState.AS3000H_TSC1_TOP_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Vert1x || currentAircraft.HasAS3000Vert2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000V_TSC1_LF:
                     newState = MacroPadState.AS3000V_TSC1_MD;
                     break;
                  case MacroPadState.AS3000V_TSC1_MD:
                  default:
                     newState = MacroPadState.AS3000V_TSC1_LF;
                     break;
               }
            }
            else if (currentAircraft.HasG3X1x || currentAircraft.HasG3X2x)
            {
               switch (State)
               {
                  case MacroPadState.G3X_1_LF_LG:
                     newState = MacroPadState.G3X_1_LF_SM;
                     break;
                  case MacroPadState.G3X_1_LF_SM:
                  default:
                     newState = MacroPadState.G3X_1_LF_LG;
                     break;
               }
            }
            break;

         // AV2 BUTTON
         case MacroPadComponent.AV2:
            if (currentAircraft.HasAS530)
            {
               switch (State)
               {
                  case MacroPadState.AS530_RT_LG:
                     newState = MacroPadState.AS530_RT_SM;
                     break;
                  case MacroPadState.AS530_RT_SM:
                  default:
                     newState = MacroPadState.AS530_RT_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS1000)
            {
               switch (State)
               {
                  default:
                     newState = MacroPadState.AS1000_PFD_RANGE;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Horiz1x || currentAircraft.HasAS3000Horiz2x)
            {
               switch (State)
               {
                  default:
                     newState = MacroPadState.AS3000H_TSC1_BTM;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Vert1x || currentAircraft.HasAS3000Vert2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000V_TSC1_LG:
                     newState = MacroPadState.AS3000V_TSC1_SM;
                     break;
                  case MacroPadState.AS3000V_TSC1_SM:
                  default:
                     newState = MacroPadState.AS3000V_TSC1_LG;
                     break;
               }
            }
            else if (currentAircraft.HasG3X1x || currentAircraft.HasG3X2x)
            {
               switch (State)
               {
                  case MacroPadState.G3X_1_RT_LG:
                     newState = MacroPadState.G3X_1_RT_SM;
                     break;
                  case MacroPadState.G3X_1_RT_SM:
                  default:
                     newState = MacroPadState.G3X_1_RT_LG;
                     break;
               }
            }
            break;

         // AV3 BUTTON
         case MacroPadComponent.AV3:
            if (currentAircraft.HasAS430)
            {
               switch (State)
               {
                  case MacroPadState.AS430_LF_LG:
                     newState = MacroPadState.AS430_LF_SM;
                     break;
                  case MacroPadState.AS430_LF_SM:
                  default:
                     newState = MacroPadState.AS430_LF_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS1000)
            {
               switch (State)
               {
                  case MacroPadState.AS1000_MFD_LG:
                     newState = MacroPadState.AS1000_MFD_SM;
                     break;
                  case MacroPadState.AS1000_MFD_SM:
                  default:
                     newState = MacroPadState.AS1000_MFD_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Horiz1x || currentAircraft.HasAS3000Horiz2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000H_TSC2_TOP_LG:
                     newState = MacroPadState.AS3000H_TSC2_TOP_SM;
                     break;
                  case MacroPadState.AS3000H_TSC2_TOP_SM:
                  default:
                     newState = MacroPadState.AS3000H_TSC2_TOP_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Vert1x || currentAircraft.HasAS3000Vert2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000V_TSC2_LF:
                     newState = MacroPadState.AS3000V_TSC2_MD;
                     break;
                  case MacroPadState.AS3000V_TSC2_MD:
                  default:
                     newState = MacroPadState.AS3000V_TSC2_LF;
                     break;
               }
            }
            else if (currentAircraft.HasG3X1x || currentAircraft.HasG3X2x)
            {
               switch (State)
               {
                  case MacroPadState.G3X_2_LF_LG:
                     newState = MacroPadState.G3X_2_LF_SM;
                     break;
                  case MacroPadState.G3X_2_LF_SM:
                  default:
                     newState = MacroPadState.G3X_2_LF_LG;
                     break;
               }
            }
            break;

         // AV4 BUTTON
         case MacroPadComponent.AV4:
            if (currentAircraft.HasAS430)
            {
               switch (State)
               {
                  case MacroPadState.AS430_RT_LG:
                     newState = MacroPadState.AS430_RT_SM;
                     break;
                  case MacroPadState.AS430_RT_SM:
                  default:
                     newState = MacroPadState.AS430_RT_LG;
                     break;
               }
            }
            else if (currentAircraft.HasAS1000)
            {
               switch (State)
               {
                  default:
                     newState = MacroPadState.AS1000_MFD_RANGE;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Horiz1x || currentAircraft.HasAS3000Horiz2x)
            {
               switch (State)
               {
                  default:
                     newState = MacroPadState.AS3000H_TSC2_BTM;
                     break;
               }
            }
            else if (currentAircraft.HasAS3000Vert1x || currentAircraft.HasAS3000Vert2x)
            {
               switch (State)
               {
                  case MacroPadState.AS3000V_TSC2_LG:
                     newState = MacroPadState.AS3000V_TSC2_SM;
                     break;
                  case MacroPadState.AS3000V_TSC2_SM:
                  default:
                     newState = MacroPadState.AS3000V_TSC2_LG;
                     break;
               }
            }
            else if (currentAircraft.HasG3X1x || currentAircraft.HasG3X2x)
            {
               switch (State)
               {
                  case MacroPadState.G3X_2_RT_LG:
                     newState = MacroPadState.G3X_2_RT_SM;
                     break;
                  case MacroPadState.G3X_2_RT_SM:
                  default:
                     newState = MacroPadState.G3X_2_RT_LG;
                     break;
               }
            }
            break;
      }
      return newState;
   }

   private void ProcessMacroPadEvent(MacroPadComponent component, MacroPadEvent eventType)
   {
      MacroPadState previousState = State;

      string eventStr = eventType.ToString();

      System.Diagnostics.Debug.WriteLine($"ProcessMacroPadEvent");
      System.Diagnostics.Debug.WriteLine($"Component {component}, event {eventStr}");

      switch (component)
      {
         case MacroPadComponent.COM1:
            if (eventType == MacroPadEvent.Clicked)
               State = State == MacroPadState.COM1_MHZ ? MacroPadState.COM1_KHZ : MacroPadState.COM1_MHZ;
            break;
         case MacroPadComponent.COM2:
            if (eventType == MacroPadEvent.Clicked)
               State = State == MacroPadState.COM2_MHZ ? MacroPadState.COM2_KHZ : MacroPadState.COM2_MHZ;
            break;
         case MacroPadComponent.NAV:
            if (eventType == MacroPadEvent.Clicked)
            {
               switch (State)
               {
                  case MacroPadState.NAV1_MHZ:
                     State = MacroPadState.NAV1_KHZ;
                     break;
                  case MacroPadState.NAV1_KHZ:
                     State = MacroPadState.NAV2_MHZ;
                     break;
                  case MacroPadState.NAV2_MHZ:
                     State = MacroPadState.NAV2_KHZ;
                     break;
                  case MacroPadState.NAV2_KHZ:
                  default:
                     State = MacroPadState.NAV1_MHZ;
                     break;
               }
            }
            break;

         case MacroPadComponent.HDG_CRS:
            if (eventType == MacroPadEvent.Clicked)
            {
               switch (State)
               {
                  case MacroPadState.HEADING:
                     State = MacroPadState.COURSE1;
                     break;
                  case MacroPadState.COURSE1:
                     State = MacroPadState.COURSE2;
                     break;
                  case MacroPadState.COURSE2:
                  default:
                     State = MacroPadState.HEADING;
                     break;
               }
            }
            break;

         case MacroPadComponent.SPD_MCH:
            if (eventType == MacroPadEvent.Clicked)
            {
               switch (State)
               {
                  case MacroPadState.IAS:
                     State = MacroPadState.MACH;
                     break;
                  case MacroPadState.MACH:
                  default:
                     State = MacroPadState.IAS;
                     break;
               }
            }
            break;

         case MacroPadComponent.ALT_VS:
            if (eventType == MacroPadEvent.Clicked)
               switch (State)
               {
                  case MacroPadState.ALTITUDE_1000:
                     State = MacroPadState.ALTITUDE_100;
                     break;
                  case MacroPadState.ALTITUDE_100:
                     State = MacroPadState.VERTICAL_SPEED;
                     break;
                  case MacroPadState.VERTICAL_SPEED:
                  default:
                     State = MacroPadState.ALTITUDE_1000;
                     break;
               }
            break;

         case MacroPadComponent.XPND:
            if (eventType == MacroPadEvent.Clicked)
               switch (State)
               {
                  case MacroPadState.XPND_1000:
                     State = MacroPadState.XPND_100;
                     break;
                  case MacroPadState.XPND_100:
                     State = MacroPadState.XPND_10;
                     break;
                  case MacroPadState.XPND_10:
                     State = MacroPadState.XPND_1;
                     break;
                  case MacroPadState.XPND_1:
                  default:
                     State = MacroPadState.XPND_1000;
                     break;
               }
            break;

         case MacroPadComponent.BAR:
            if (eventType == MacroPadEvent.Clicked)
               State = MacroPadState.BAROMETER;
            break;

         case MacroPadComponent.AV1:
         case MacroPadComponent.AV2:
         case MacroPadComponent.AV3:
         case MacroPadComponent.AV4:
            State = GetNewState(component, State, eventType, CurrentAircraft);
            break;

         case MacroPadComponent.Rotary:
            switch (State)
            {
               case MacroPadState.COM1_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.COM_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.COM_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.COM1_RADIO_SWAP);
                  break;
               case MacroPadState.COM1_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.COM_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.COM_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.COM1_RADIO_SWAP);
                  break;
               case MacroPadState.COM2_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_SWAP);
                  break;
               case MacroPadState.COM2_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.COM2_RADIO_SWAP);
                  break;
               case MacroPadState.NAV1_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_SWAP);
                  break;
               case MacroPadState.NAV1_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.NAV1_RADIO_SWAP);
                  break;
               case MacroPadState.NAV2_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_SWAP);
                  break;
               case MacroPadState.NAV2_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.NAV2_RADIO_SWAP);
                  break;

               case MacroPadState.HEADING:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.HEADING_BUG_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.HEADING_BUG_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.AP_HDG_HOLD);
                  break;

               case MacroPadState.COURSE1:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.VOR1_OBI_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.VOR1_OBI_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.TOGGLE_GPS_DRIVES_NAV1);
                  break;

               case MacroPadState.COURSE2:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.VOR2_OBI_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.VOR2_OBI_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.TOGGLE_GPS_DRIVES_NAV1);
                  break;

               case MacroPadState.BAROMETER:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>K:KOHLSMAN_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>K:KOHLSMAN_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.BAROMETRIC_STD_PRESSURE, 1);
                  break;

               case MacroPadState.ALTITUDE_1000:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     uint newAltSetting = Convert.ToUInt32(apAltitude + 1000);
                     SimConnection.SendEvent(SimEvent.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     uint newAltSetting = Convert.ToUInt32(Math.Max(0, apAltitude - 1000));
                     SimConnection.SendEvent(SimEvent.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.AP_ALT_HOLD);
                  break;

               case MacroPadState.ALTITUDE_100:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     uint newAltSetting = Convert.ToUInt32(apAltitude + 100);
                     SimConnection.SendEvent(SimEvent.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     uint newAltSetting = Convert.ToUInt32(Math.Max(0, apAltitude - 100));
                     SimConnection.SendEvent(SimEvent.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.AP_ALT_HOLD);
                  break;

               case MacroPadState.VERTICAL_SPEED:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     SimConnection.SendEvent(SimEvent.AP_VS_VAR_INC);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     SimConnection.SendEvent(SimEvent.AP_VS_VAR_DEC);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                  {
                     SimConnection.SendEvent(SimEvent.AP_PANEL_VS_HOLD);
                  }
                  break;

               case MacroPadState.IAS:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     SimConnection.SendEvent(SimEvent.AP_SPD_VAR_INC);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     SimConnection.SendEvent(SimEvent.AP_SPD_VAR_DEC);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                  {
                     SimConnection.SendEvent(SimEvent.AP_AIRSPEED_HOLD);
                  }
                  break;

               case MacroPadState.MACH:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     SimConnection.SendEvent(SimEvent.AP_MACH_VAR_INC);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     SimConnection.SendEvent(SimEvent.AP_MACH_VAR_DEC);
                  }
                  else if (eventType != MacroPadEvent.Clicked)
                  {
                     SimConnection.SendEvent(SimEvent.AP_MACH_HOLD);
                  }
                  break;

               case MacroPadState.XPND_1000:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.XPNDR_1000_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.XPNDR_1000_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_100:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.XPNDR_100_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.XPNDR_100_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_10:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.XPNDR_10_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.XPNDR_10_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_1:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.XPNDR_1_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.XPNDR_1_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.XPNDR_IDENT_TOGGLE);
                  break;

               case MacroPadState.AS530_LF_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftLargeKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftLargeKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftSmallKnob_Push)");
                  break;
               case MacroPadState.AS530_LF_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftSmallKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftSmallKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_LeftSmallKnob_Push)");
                  break;
               case MacroPadState.AS530_RT_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightSmallKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightSmallKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightSmallKnob_Push)");
                  break;
               case MacroPadState.AS530_RT_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightLargeKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightLargeKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS530_RightSmallKnob_Push)");
                  break;

               case MacroPadState.AS430_LF_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftLargeKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftLargeKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftSmallKnob_Push)");
                  break;
               case MacroPadState.AS430_LF_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftSmallKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftSmallKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_LeftSmallKnob_Push)");
                  break;
               case MacroPadState.AS430_RT_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightLargeKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightLargeKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightSmallKnob_Push)");
                  break;
               case MacroPadState.AS430_RT_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightSmallKnob_Right)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightSmallKnob_Left)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS430_RightSmallKnob_Push)");
                  break;


               case MacroPadState.GPS_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.GPS_GROUP_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.GPS_GROUP_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.GPS_CURSOR_BUTTON);
                  break;
               case MacroPadState.GPS_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.GPS_PAGE_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.GPS_PAGE_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.GPS_CURSOR_BUTTON);
                  break;

               case MacroPadState.AS1000_PFD_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Lower_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Lower_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Upper_PUSH)");
                  break;
               case MacroPadState.AS1000_PFD_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Upper_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Upper_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_FMS_Upper_PUSH)");
                  break;
               case MacroPadState.AS1000_PFD_RANGE:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_RANGE_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_PFD_RANGE_DEC)");
                  break;

               case MacroPadState.AS1000_MFD_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Lower_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Lower_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Upper_PUSH)");
                  break;
               case MacroPadState.AS1000_MFD_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Upper_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Upper_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_FMS_Upper_PUSH)");
                  break;
               case MacroPadState.AS1000_MFD_RANGE:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_RANGE_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS1000_MFD_RANGE_DEC)");
                  break;


               case MacroPadState.AS3000H_TSC1_TOP_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_DEC)");
                  break;
               case MacroPadState.AS3000H_TSC1_TOP_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_DEC)");
                  break;
               case MacroPadState.AS3000H_TSC1_BTM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_1_BottomKnob_Push)");
                  break;

               case MacroPadState.AS3000H_TSC2_TOP_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_TopKnob_Large_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_TopKnob_Large_DEC)");
                  break;
               case MacroPadState.AS3000H_TSC2_TOP_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_TopKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_TopKnob_Small_DEC)");
                  break;
               case MacroPadState.AS3000H_TSC2_BTM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_BottomKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_BottomKnob_Small_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Horizontal_2_BottomKnob_Push)");
                  break;


               case MacroPadState.AS3000V_TSC1_LF:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_Joystick_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_Joystick_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_Joystick_Push)");
                  break;
               case MacroPadState.AS3000V_TSC1_MD:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_MiddleKnob_Inc)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_MiddleKnob_Dec)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_MiddleKnob_Push)");
                  break;
               case MacroPadState.AS3000V_TSC1_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Large_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Large_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Push)");
                  break;
               case MacroPadState.AS3000V_TSC1_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Small_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_1_RightKnob_Push)");
                  break;

               case MacroPadState.AS3000V_TSC2_LF:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_Joystick_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_Joystick_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_Joystick_Push)");
                  break;
               case MacroPadState.AS3000V_TSC2_MD:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_MiddleKnob_Inc)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_MiddleKnob_Dec)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_MiddleKnob_Push)");
                  break;
               case MacroPadState.AS3000V_TSC2_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Large_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Large_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Push)");
                  break;
               case MacroPadState.AS3000V_TSC2_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Small_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Small_DEC)");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3000_TSC_Vertical_2_RightKnob_Push)");
                  break;


               case MacroPadState.G3X_1_LF_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Outer_L_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Outer_L_DEC)");
                  break;
               case MacroPadState.G3X_1_LF_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Inner_L_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Inner_L_DEC)");
                  break;
               case MacroPadState.G3X_1_RT_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Outer_R_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_1_Knob_Outer_R_DEC)");
                  break;
               case MacroPadState.G3X_1_RT_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_TOUCH_1_Knob_Inner_R_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_TOUCH_1_Knob_Inner_R_DEC)");
                  break;

               case MacroPadState.G3X_2_LF_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Outer_L_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Outer_L_DEC)");
                  break;
               case MacroPadState.G3X_2_LF_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Inner_L_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Inner_L_DEC)");
                  break;
               case MacroPadState.G3X_2_RT_LG:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Outer_R_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_Touch_2_Knob_Outer_R_DEC)");
                  break;
               case MacroPadState.G3X_2_RT_SM:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_TOUCH_2_Knob_Inner_R_INC)");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendCalculatorCode("(>H:AS3X_TOUCH_2_Knob_Inner_R_DEC)");
                  break;

            }
            break;
      }

      switch (previousState)
      {
         case MacroPadState.COM1_MHZ:
         case MacroPadState.COM1_KHZ:
            break;
         case MacroPadState.COM2_MHZ:
         case MacroPadState.COM2_KHZ:
            break;
         case MacroPadState.NAV1_MHZ:
         case MacroPadState.NAV1_KHZ:
            break;
         case MacroPadState.NAV2_MHZ:
         case MacroPadState.NAV2_KHZ:
            break;
         case MacroPadState.HEADING:
            break;
         case MacroPadState.COURSE1:
            break;
         case MacroPadState.COURSE2:
            break;
      }

      switch (State)
      {
         case MacroPadState.COM1_MHZ:
            break;
         case MacroPadState.COM1_KHZ:
            break;
         case MacroPadState.COM2_MHZ:
            break;
         case MacroPadState.COM2_KHZ:
            break;
         case MacroPadState.NAV1_MHZ:
            break;
         case MacroPadState.NAV1_KHZ:
            break;
         case MacroPadState.NAV2_MHZ:
            break;
         case MacroPadState.NAV2_KHZ:
            break;
         case MacroPadState.HEADING:
            break;
         case MacroPadState.COURSE1:
            break;
         case MacroPadState.COURSE2:
            break;
      }

      if (State != previousState)
      {
         //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending SimMessage state via SerialPort ");
      }

      OnEventProcessed(
         new EventProcessedEventArgs(
            macroPadEvent: eventType,
            component: component,
            newState: State));
   }
}


/*
 * //Asobo/TBM 930/Avionics (WTG3000 in 2020)   AS3000H 2X CONTROL PANELS
 * 
   G3000_TSC_1_Bottom_Knob_DEC#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_DEC)
   G3000_TSC_1_Bottom_Knob_Inc#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_INC)
   G3000_TSC_1_Bottom_Knob_Push#(>H:AS3000_TSC_Horizontal_1_BottomKnob_Push)
   G3000_TSC_1_Top_Knob_Large_Dec#(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_DEC)
   G3000_TSC_1_Top_Knob_Large_Inc#(>H:AS3000_TSC_Horizontal_1_TopKnob_Large_INC)
   G3000_TSC_1_Top_Knob_Long_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push_Long)
   G3000_TSC_1_Top_Knob_Short_Press#(>H:AS3000_TSC_Horizontal_1_TopKnob_Push)
   G3000_TSC_1_Top_Knob_Small_Dec#(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_DEC)
   G3000_TSC_1_Top_Knob_Small_Inc#(>H:AS3000_TSC_Horizontal_1_TopKnob_Small_INC)
 * 
 * (>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_DEC)
 * (>H:AS3000_TSC_Horizontal_1_BottomKnob_Small_INC)
 * (>H:AS3000_TSC_Horizontal_1_BottomKnob_Push)
 * 
 * 
 * 
 * //Asobo/Longitude/Avionics (WTG3000 in 2020)    AS3000V 4X CONTROL PANELS
   AS3000_TSC_Vertical_1_Joystick_Push#(>H:AS3000_TSC_Vertical_1_Joystick_Push)
   AS3000_TSC_Vertical_1_Joystick_Range_Pan_X_Left# (>H:AS3000_TSC_Vertical_1_Joystick_Left)
   AS3000_TSC_Vertical_1_Joystick_Range_Pan_X_Right# (>H:AS3000_TSC_Vertical_1_Joystick_Right)
   AS3000_TSC_Vertical_1_Joystick_Range_Pan_Y_Down#(>H:AS3000_TSC_Vertical_1_Joystick_Down)
   AS3000_TSC_Vertical_1_Joystick_Range_Pan_Y_Up#(>AS3000_TSC_Vertical_1_Joystick_Up)
   AS3000_TSC_Vertical_1_Joystick_Range_Zoom_Dec# (>H:AS3000_TSC_Vertical_1_Joystick_DEC)
   AS3000_TSC_Vertical_1_Joystick_Range_Zoom_Inc# (>H:AS3000_TSC_Vertical_1_Joystick_INC)
   AS3000_TSC_Vertical_1_Middle_Knob_Button# (>H:AS3000_TSC_Vertical_1_MiddleKnob_Push)
   AS3000_TSC_Vertical_1_Middle_Knob_Dec#(>H:AS3000_TSC_Vertical_1_MiddleKnob_Dec)
   AS3000_TSC_Vertical_1_Middle_Knob_Inc#(>H:AS3000_TSC_Vertical_1_MiddleKnob_Inc)
   AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Press#(E:SIMULATION TIME, second) 2 + (>L:myTimer)
   AS3000_TSC_Vertical_1_Right_Inner_Knob_Button_Release#(E:SIMULATION TIME, second) (L:myTimer) < if{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push) } els{ (>H:AS3000_TSC_Vertical_1_RightKnob_Push_Long) } 
   AS3000_TSC_Vertical_1_Right_Inner_Knob_Dec#(>H:AS3000_TSC_Vertical_1_RightKnob_Small_DEC)
   AS3000_TSC_Vertical_1_Right_Inner_Knob_Inc#(>H:AS3000_TSC_Vertical_1_RightKnob_Small_INC)
   AS3000_TSC_Vertical_1_Right_Outer_Knob_Dec#(>H:AS3000_TSC_Vertical_1_RightKnob_Large_DEC)
   AS3000_TSC_Vertical_1_Right_Outer_Knob_Inc#(>H:AS3000_TSC_Vertical_1_RightKnob_Large_INC)



   //Working Title/G3X-Touch/Avionics
   (>H:AS3X_TOUCH_1_KNOB_INNER_L_DEC)
   (>H:AS3X_TOUCH_1_KNOB_INNER_L_INC)
   (>H:AS3X_TOUCH_1_KNOB_OUTER_L_DEC)
   (>H:AS3X_TOUCH_1_KNOB_OUTER_L_INC)
   (>H:AS3X_TOUCH_1_KNOB_INNER_R_DEC)
   (>H:AS3X_TOUCH_1_KNOB_INNER_R_INC)
   (>H:AS3X_TOUCH_1_KNOB_OUTER_R_DEC)
   (>H:AS3X_TOUCH_1_KNOB_OUTER_R_INC)




   // Kodiak 100
   (>H:AS1000_PFD_RANGE_DEC)
   (>H:AS1000_PFD_RANGE_INC)
   (>H:AS1000_PFD_FMS_Lower_DEC)
   (>H:AS1000_PFD_FMS_Lower_INC)
   (>H:AS1000_PFD_FMS_Upper_PUSH)
   (>H:AS1000_PFD_FMS_Upper_DEC)
   (>H:AS1000_PFD_FMS_Upper_INC)

   (>H:AS1000_MFD_RANGE_DEC)
   (>H:AS1000_MFD_RANGE_INC)
   (>H:AS1000_MFD_FMS_Lower_DEC)
   (>H:AS1000_MFD_FMS_Lower_INC)
   (>H:AS1000_MFD_FMS_Upper_PUSH)
   (>H:AS1000_MFD_FMS_Upper_DEC)
   (>H:AS1000_MFD_FMS_Upper_INC)

*/