using MacroSim.SimConnection;
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

   private MacroPadState state = MacroPadState.None;
   private int apAltitude = 0;

   public delegate void EventProcessedEventHandler(object sender, EventProcessedEventArgs e);
   public event EventProcessedEventHandler? EventProcessed;


   public MacroPadDevice(SimConnection.SimConnection simConnection)
   {
      SerialPort = new SerialPort();
      SerialPort.DataReceived += SerialPort_DataReceived;
      SimConnection = simConnection;
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

   public void UpdateData(MacroSimStruct macroSimStruct)
   {
      apAltitude = macroSimStruct.apAltitude;
   }

   protected virtual void OnEventProcessed(EventProcessedEventArgs e)
   {
      EventProcessed?.Invoke(this, e);
   }

   private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
   {
      int data = SerialPort.ReadByte();
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
                     SimConnection.SendEvent(SimEvents.COM_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.COM_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.COM1_RADIO_SWAP);
                  break;
               case MacroPadState.COM1_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.COM_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.COM_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.COM1_RADIO_SWAP);
                  break;
               case MacroPadState.COM2_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_SWAP);
                  break;
               case MacroPadState.COM2_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.COM2_RADIO_SWAP);
                  break;
               case MacroPadState.NAV1_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_SWAP);
                  break;
               case MacroPadState.NAV1_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.NAV1_RADIO_SWAP);
                  break;
               case MacroPadState.NAV2_MHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_WHOLE_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_WHOLE_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_SWAP);
                  break;
               case MacroPadState.NAV2_KHZ:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_FRACT_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_FRACT_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.NAV2_RADIO_SWAP);
                  break;

               case MacroPadState.HEADING:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.HEADING_BUG_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.HEADING_BUG_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.AP_HDG_HOLD);
                  break;

               case MacroPadState.COURSE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.VOR1_OBI_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.VOR1_OBI_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.TOGGLE_GPS_DRIVES_NAV1);
                  break;

               case MacroPadState.ALTITUDE_1000:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     uint newAltSetting = Convert.ToUInt32(apAltitude + 1000);
                     SimConnection.SendEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     uint newAltSetting = Convert.ToUInt32(Math.Max(0, apAltitude - 1000));
                     SimConnection.SendEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.AP_ALT_HOLD);
                  break;

               case MacroPadState.ALTITUDE_100:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     uint newAltSetting = Convert.ToUInt32(apAltitude + 100);
                     SimConnection.SendEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     uint newAltSetting = Convert.ToUInt32(Math.Max(0, apAltitude - 100));
                     SimConnection.SendEvent(SimEvents.AP_ALT_VAR_SET_ENGLISH, newAltSetting);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.AP_ALT_HOLD);
                  break;

               case MacroPadState.VERTICAL_SPEED:
                  if (eventType == MacroPadEvent.Increment)
                  {
                     SimConnection.SendEvent(SimEvents.AP_VS_VAR_INC);
                  }
                  else if (eventType == MacroPadEvent.Decrement)
                  {
                     SimConnection.SendEvent(SimEvents.AP_VS_VAR_DEC);
                  }
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.AP_PANEL_VS_HOLD);
                  break;

               case MacroPadState.XPND_1000:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.XPNDR_1000_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.XPNDR_1000_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_100:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.XPNDR_100_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.XPNDR_100_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_10:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.XPNDR_10_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.XPNDR_10_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.XPNDR_IDENT_TOGGLE);
                  break;
               case MacroPadState.XPND_1:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.XPNDR_1_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.XPNDR_1_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.XPNDR_IDENT_TOGGLE);
                  break;

               case MacroPadState.GPS_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.GPS_GROUP_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.GPS_GROUP_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.GPS_CURSOR_BUTTON);
                  break;
               case MacroPadState.GPS_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.GPS_PAGE_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.GPS_PAGE_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.GPS_CURSOR_BUTTON);
                  break;

               case MacroPadState.PFD_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_GROUP_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_GROUP_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_CURSOR_BUTTON);
                  break;
               case MacroPadState.PFD_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_PAGE_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_PAGE_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.G1000_PFD_CURSOR_BUTTON);
                  break;

               case MacroPadState.MFD_GROUP:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_GROUP_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_GROUP_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_CURSOR_BUTTON);
                  break;
               case MacroPadState.MFD_PAGE:
                  if (eventType == MacroPadEvent.Increment)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_PAGE_KNOB_INC);
                  else if (eventType == MacroPadEvent.Decrement)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_PAGE_KNOB_DEC);
                  else if (eventType == MacroPadEvent.Clicked)
                     SimConnection.SendEvent(SimEvents.G1000_MFD_CURSOR_BUTTON);
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

      byte[] buffer = new byte[1];
      buffer[0] = (byte)state;
      SerialPort.Write(buffer, 0, 1);

      OnEventProcessed(
         new EventProcessedEventArgs(
            macroPadEvent: eventType,
            component: component,
            newState: state));
   }
}

public class EventProcessedEventArgs : EventArgs
{
   public MacroPadComponent Component { get; private set; }
   public MacroPadEvent Event { get; private set; }
   public MacroPadState NewState { get; private set; }

   public EventProcessedEventArgs(MacroPadEvent macroPadEvent, MacroPadComponent component, MacroPadState newState)
   {
      Component = component;
      Event = macroPadEvent;
      NewState = newState;
   }
}

public enum MacroPadComponent : byte
{
   Rotary = 0,
   COM1 = 1,
   COM2 = 2,
   GPS = 3,
   NAV1 = 4,
   NAV2 = 5,
   PFD = 6,
   HDG = 7,
   CRS = 8,
   MFD = 9,
   ALT = 10,
   VS = 11,
   XPND = 12
}

public enum MacroPadEvent : byte
{
   Clicked = 0,
   DoubleClicked = 1,
   LongPressed = 2,
   RepeatPressed = 3,
   Increment = 4,
   Decrement = 5
}

public enum MacroPadState : byte
{
   None = 0b000000_00,
   COM1_MHZ = 0b000001_00,
   COM1_KHZ = 0b000001_01,
   COM2_MHZ = 0b000010_00,
   COM2_KHZ = 0b000010_01,
   NAV1_MHZ = 0b000011_00,
   NAV1_KHZ = 0b000011_01,
   NAV2_MHZ = 0b000100_00,
   NAV2_KHZ = 0b000100_01,
   HEADING = 0b000101_00,
   COURSE = 0b000110_00,
   ALTITUDE_1000 = 0b000111_00,
   ALTITUDE_100 = 0b000111_01,
   VERTICAL_SPEED = 0b001000_00,
   XPND_1000 = 0b001001_00,
   XPND_100 = 0b001001_01,
   XPND_10 = 0b001001_10,
   XPND_1 = 0b001001_11,
   GPS_GROUP = 0b001010_00,
   GPS_PAGE = 0b001010_01,
   PFD_GROUP = 0b001011_00,
   PFD_PAGE = 0b001011_01,
   MFD_GROUP = 0b001100_00,
   MFD_PAGE = 0b001100_01,
}
