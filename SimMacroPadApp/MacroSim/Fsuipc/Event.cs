using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.Fsuipc;

public class Event
{
   /// <summary>
   /// Gets or sets the name of the aircraft developer.
   /// </summary>
   public string Developer {  get; set; }

   /// <summary>
   /// Gets or sets the name of the aircraft.
   /// </summary>
   public string Aircraft { get; set; }

   /// <summary>
   /// Gets or sets the event classification.
   /// </summary>
   public string Classification { get; set; }

   /// <summary>
   /// Gets or sets the name of the preset.
   /// </summary>
   public string PresetName { get; set; }

   /// <summary>
   /// Gets or sets the calculator code for the event.
   /// </summary>
   public string CalculatorCode { get; set; }

   /// <summary>
   /// Gets a value indicating whether an event expects
   /// a parameter.
   /// </summary>
   public bool IsParameterized {  get; set; }

   public Event()
   {
      Developer = string.Empty;
      Aircraft = string.Empty;
      Classification = string.Empty;
      PresetName = string.Empty;
      CalculatorCode = string.Empty;
      IsParameterized = false;
   }

   public Event(string developer, string aircraft, string classification, string presetName, string calculatorCode)
   {
      Developer = developer;
      Aircraft = aircraft;
      Classification = classification;
      PresetName = presetName;
      CalculatorCode = calculatorCode;
   }
}
