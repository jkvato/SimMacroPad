using MacroSim.MacroPadDevice.Enumerations;
using MacroSim.SimConnection.Enumerations;
using MacroSim.SimConnection.Structures;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MacroSim.SimConnection.SimConnection;
using static System.Windows.Forms.AxHost;

namespace MacroSim.MacroPadDevice;

internal class MacroPadDevice
{
   public readonly SerialPort SerialPort;

   public SimConnection.SimConnection SimConnection { get; private set; }
   public Fsuipc.FsuipcConnection FsuipcConnection { get; private set; }

   private MacroPadState state = MacroPadState.None;
   private int apAltitude = 0;

   public delegate void EventProcessedEventHandler(object sender, EventProcessedEventArgs e);
   public event EventProcessedEventHandler? EventProcessed;

   private readonly SimMessage simMessage;

   public MacroPadDevice(SimConnection.SimConnection simConnection, Fsuipc.FsuipcConnection fsuipcConnection)
   {
      SerialPort = new SerialPort();
      SerialPort.DataReceived += SerialPort_DataReceivedFromDevice;
      SimConnection = simConnection;
      FsuipcConnection = fsuipcConnection;
      simMessage = new SimMessage();
   }

   public bool SetSerialPort(string portName)
   {
      try
      {
         SerialPort.Close();
         SerialPort.PortName = portName;
         SerialPort.RtsEnable = true;
         SerialPort.DtrEnable = true;
         SerialPort.Open();
         return true;
      }
      catch
      {
         return false;
      }
   }

   public void UpdateData(object structure)
   {
      if (structure is AvionicsStruct avionicsStruct)
      {
         apAltitude = avionicsStruct.apAltitudeSel;

         switch (state)
         {
            case MacroPadState.COM1_MHZ:
            case MacroPadState.COM1_KHZ:
               simMessage.Text1 = string.Format("{0:000.000}", avionicsStruct.com1standby);
               simMessage.Text2 = string.Format("{0:000.000}", avionicsStruct.com1active);
               break;
            case MacroPadState.COM2_MHZ:
            case MacroPadState.COM2_KHZ:
               simMessage.Text1 = string.Format("{0:000.000}", avionicsStruct.com2standby);
               simMessage.Text2 = string.Format("{0:000.000}", avionicsStruct.com2active);
               break;
            case MacroPadState.NAV1_MHZ:
            case MacroPadState.NAV1_KHZ:
               simMessage.Text1 = string.Format("{0:000.000}", avionicsStruct.nav1standby);
               simMessage.Text2 = string.Format("{0:000.000}", avionicsStruct.nav1active);
               break;
            case MacroPadState.NAV2_MHZ:
            case MacroPadState.NAV2_KHZ:
               simMessage.Text1 = string.Format("{0:000.000}", avionicsStruct.nav2standby);
               simMessage.Text2 = string.Format("{0:000.000}", avionicsStruct.nav2active);
               break;
            case MacroPadState.HEADING:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apHeadingSel);
               break;
            case MacroPadState.COURSE:
               simMessage.Text1 = string.Format("{0:000}", avionicsStruct.apNav1ObsSel);
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
            case MacroPadState.PFD_GROUP:
               simMessage.Text1 = "        ";
               break;
            case MacroPadState.PFD_PAGE:
               simMessage.Text1 = "        ";
               break;
            case MacroPadState.MFD_GROUP:
               simMessage.Text1 = "        ";
               break;
            case MacroPadState.MFD_PAGE:
               simMessage.Text1 = "        ";
               break;
            default:
               simMessage.Text1 = string.Empty;
               break;
         }

         simMessage.MacroPadState = state;

         //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending SimMessage via SerialPort ");

         simMessage.Send(SerialPort);
      }
      else if (structure is LightsStruct lightsStruct)
      {
      }
   }

   protected virtual void OnEventProcessed(EventProcessedEventArgs e)
   {
      EventProcessed?.Invoke(this, e);
   }

   private void SerialPort_DataReceivedFromDevice(object sender, SerialDataReceivedEventArgs e)
   {
      int data = 0;
      try
      {
         data = SerialPort.ReadByte();
      }
      catch
      {
         return;
      }
      var bytes = BitConverter.GetBytes(data);
      var b = bytes[0];

      int componentID = b & 0b11111000;
      componentID = componentID >> 3;
      MacroPadComponent component = (MacroPadComponent)componentID;

      int eventID = b & 0b00000111;
      MacroPadEvent eventType = (MacroPadEvent)eventID;

      ProcessMacroPadEvent(component, eventType);
   }

   private void ProcessMacroPadEvent(MacroPadComponent component, MacroPadEvent eventType)
   {
      MacroPadState previousState = state;

      string eventStr = eventType.ToString();

      System.Diagnostics.Debug.WriteLine($"ProcessMacroPadEvent");
      System.Diagnostics.Debug.WriteLine($"Component {component}, event {eventStr}");

      switch (component)
      {
         case MacroPadComponent.COM1:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.COM1_MHZ ? MacroPadState.COM1_KHZ : MacroPadState.COM1_MHZ;
            break;
         case MacroPadComponent.COM2:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.COM2_MHZ ? MacroPadState.COM2_KHZ : MacroPadState.COM2_MHZ;
            break;
         case MacroPadComponent.NAV1:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.NAV1_MHZ ? MacroPadState.NAV1_KHZ : MacroPadState.NAV1_MHZ;
            break;
         case MacroPadComponent.NAV2:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.NAV2_MHZ ? MacroPadState.NAV2_KHZ : MacroPadState.NAV2_MHZ;
            break;

         case MacroPadComponent.HDG:
            if (eventType == MacroPadEvent.Clicked)
               state = MacroPadState.HEADING;
            break;

         case MacroPadComponent.CRS:
            if (eventType == MacroPadEvent.Clicked)
               state = MacroPadState.COURSE;
            break;

         case MacroPadComponent.ALT:
            if (eventType == MacroPadEvent.Clicked)
               switch (state)
               {
                  case MacroPadState.ALTITUDE_1000:
                     state = MacroPadState.ALTITUDE_100;
                     break;
                  case MacroPadState.ALTITUDE_100:
                  default:
                     state = MacroPadState.ALTITUDE_1000;
                     break;
               }
            break;

         case MacroPadComponent.VS:
            if (eventType == MacroPadEvent.Clicked)
               state = MacroPadState.VERTICAL_SPEED;
            break;

         case MacroPadComponent.XPND:
            if (eventType == MacroPadEvent.Clicked)
               switch (state)
               {
                  case MacroPadState.XPND_1000:
                     state = MacroPadState.XPND_100;
                     break;
                  case MacroPadState.XPND_100:
                     state = MacroPadState.XPND_10;
                     break;
                  case MacroPadState.XPND_10:
                     state = MacroPadState.XPND_1;
                     break;
                  case MacroPadState.XPND_1:
                  default:
                     state = MacroPadState.XPND_1000;
                     break;
               }
            break;

         case MacroPadComponent.GPS:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.GPS_GROUP ? MacroPadState.GPS_PAGE : MacroPadState.GPS_GROUP;
            break;

         case MacroPadComponent.PFD:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.PFD_GROUP ? MacroPadState.PFD_PAGE : MacroPadState.PFD_GROUP;
            break;

         case MacroPadComponent.MFD:
            if (eventType == MacroPadEvent.Clicked)
               state = state == MacroPadState.MFD_GROUP ? MacroPadState.MFD_PAGE : MacroPadState.MFD_GROUP;
            break;

         case MacroPadComponent.Rotary:
            switch (state)
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

               case MacroPadState.COURSE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvent.VOR1_OBI_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvent.VOR1_OBI_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvent.TOGGLE_GPS_DRIVES_NAV1);
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
                     SimConnection.SendEvent(SimEvent.AP_PANEL_VS_HOLD);
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

               case MacroPadState.PFD_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Lower_INC");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Lower_DEC");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Upper_PUSH");
                  break;
               case MacroPadState.PFD_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Upper_INC");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Upper_DEC");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendPresetEvent("AS1000_PFD_FMS_Upper_PUSH");
                  break;

               case MacroPadState.MFD_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Lower_INC");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Lower_DEC");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Upper_PUSH");
                  break;
               case MacroPadState.MFD_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Upper_INC");
                  else if (eventType == MacroPadEvent.Decrement)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Upper_DEC");
                  else if (eventType == MacroPadEvent.Clicked)
                     FsuipcConnection.SendPresetEvent("AS1000_MFD_FMS_Upper_PUSH");
                  break;
            }
            break;
      }

      switch (previousState)
      {
         case MacroPadState.COM1_MHZ:
         case MacroPadState.COM1_KHZ:
            //com1standby.Selection = FrequencySelection.None;
            break;
         case MacroPadState.COM2_MHZ:
         case MacroPadState.COM2_KHZ:
            //com2standby.Selection = FrequencySelection.None;
            break;
         case MacroPadState.NAV1_MHZ:
         case MacroPadState.NAV1_KHZ:
            //nav1standby.Selection = FrequencySelection.None;
            break;
         case MacroPadState.NAV2_MHZ:
         case MacroPadState.NAV2_KHZ:
            //nav2standby.Selection = FrequencySelection.None;
            break;
         case MacroPadState.HEADING:
            //heading.Selection = FrequencySelection.None;
            break;
         case MacroPadState.COURSE:
            //course.Selection = FrequencySelection.None;
            break;
      }

      switch (state)
      {
         case MacroPadState.COM1_MHZ:
            //com1standby.Selection = FrequencySelection.MHz;
            break;
         case MacroPadState.COM1_KHZ:
            //com1standby.Selection = FrequencySelection.KHz;
            break;
         case MacroPadState.COM2_MHZ:
            //com2standby.Selection = FrequencySelection.MHz;
            break;
         case MacroPadState.COM2_KHZ:
            //com2standby.Selection = FrequencySelection.KHz;
            break;
         case MacroPadState.NAV1_MHZ:
            //nav1standby.Selection = FrequencySelection.MHz;
            break;
         case MacroPadState.NAV1_KHZ:
            //nav1standby.Selection = FrequencySelection.KHz;
            break;
         case MacroPadState.NAV2_MHZ:
            //nav2standby.Selection = FrequencySelection.MHz;
            break;
         case MacroPadState.NAV2_KHZ:
            //nav2standby.Selection = FrequencySelection.KHz;
            break;
         case MacroPadState.HEADING:
            //heading.Selection = FrequencySelection.MHz;
            break;
         case MacroPadState.COURSE:
            //course.Selection = FrequencySelection.MHz;
            break;
      }

      if (state != previousState)
      {
         //System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} Sending SimMessage state via SerialPort ");

         //simMessage.MacroPadState = state;
         //simMessage.Send(SerialPort);
      }

      OnEventProcessed(
         new EventProcessedEventArgs(
            macroPadEvent: eventType,
            component: component,
            newState: state));
   }
}
