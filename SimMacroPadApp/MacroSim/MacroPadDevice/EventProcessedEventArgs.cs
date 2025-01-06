using MacroSim.MacroPadDevice.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.MacroPadDevice;

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
