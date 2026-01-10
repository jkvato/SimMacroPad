using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.Controls;

public class ControlBase : UserControl
{
   protected virtual (int X1, int Y1, int X2, int Y2, int regionId)[] Regions { get; }

   protected int GetRegionIdFromPoint(Point p)
   {
      foreach (var region in Regions)
      {
         if (p.X >= region.X1 && p.X <= region.X2 &&
             p.Y >= region.Y1 && p.Y <= region.Y2)
         {
            return region.regionId;
         }
      }
      return -1;
   }
}
