using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacroSim.SimConnection;

public class SimulationRate
{
   public double RateOfTime { get; set; }

   public bool IsFaster
   {
      get => RateOfTime >= 1;
   }

   public int Factor
   {
      get
      {
         if (IsFaster)
         {
            return Convert.ToInt32(RateOfTime);
         }
         else
         {
            return Convert.ToInt32(1 / RateOfTime) * -1;
         }
      }
   }

   public override string ToString()
   {
      return $"{Factor:+#;-#;0}x";

      //return string.Format("{0:0}x", Factor);

      //if (RateOfTime == 1)
      //{
      //   return " 1x";
      //}
      //else if (RateOfTime > 1)
      //{
      //   return $"+{Factor}x";
      //}
      //else
      //{
      //   return $"-{Factor}x";
      //}

      //string faster = IsFaster ? "Faster" : "Slower";
      //return string.Format($"{Factor}x {faster}");
   }

   public SimulationRate(double simulationRate)
   {
      if (simulationRate == 0)
      {
         //throw new ArgumentException(nameof(simulationRate));
      }

      RateOfTime = simulationRate;
   }

   public double Increase()
   {
      RateOfTime *= 2;
      return RateOfTime;
   }

   public double Decrease()
   {
      RateOfTime /= 2;
      return RateOfTime;
   }
}
