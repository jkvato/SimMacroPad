using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MacroSim.SimAircraft;

internal class SimAircraftCollection : IList<SimAircraft>
{
   public static readonly SimAircraftCollection DefaultAircraft;

   private readonly List<SimAircraft> aircraftList = new List<SimAircraft>();

   static SimAircraftCollection()
   {
      DefaultAircraft = new SimAircraftCollection();
      //DefaultAircraft.Add(new SimAircraft("")
      //{
      //});

      DefaultAircraft.Add(new SimAircraft("Asobo Cessna Citation Longitude *")
      {
         HasAS3000Vert4x = true,
      });

      DefaultAircraft.Add(new SimAircraft("DoubleEnder: *")
      {
         HasGTN650 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Diamond DA40NG*")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Diamond DA40TDI *")
      {
         HasAS430 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Diamond DV20*")
      {
         HasAS430 = true,
      });

      DefaultAircraft.Add(new SimAircraft("DA62 *")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Hercules H-4*")
      {
         HasAS530 = true,
      });

      DefaultAircraft.Add(new SimAircraft("DHC-2 Beaver * GPS")
      {
         HasAS530 = true,
         HasAS430 = true,
      });

      DefaultAircraft.Add(new SimAircraft("C208B *")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft(@"DHC-2 Beaver * Radio \+ ADF")
      {
      });

      DefaultAircraft.Add(new SimAircraft("DHC-2 Beaver * Radios")
      {
      });

      DefaultAircraft.Add(new SimAircraft("C172SP Classic *")
      {
         HasAS530 = true,
         HasAS430 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Zenith 701*")
      {
         HasAS530 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Van's RV-14A *")
      {
         HasG3X2x = true,
         HasAS530 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Van's RV-14 *")
      {
         HasG3X2x = true,
         HasAS530 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Van's RV-10 *")
      {
         HasG3X2x = true,
         HasAS430 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Kodiak 100 *")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("C400 Corvalis*")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Beech Baron G58*")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Cirrus SR22T*")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Pilatus PC-6 G950 *")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Blackbird Turbo Porter * Glass")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("C172SP G1000 *")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Midnight*")
      {
         HasAS3000Horiz1x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Beechcraft Bonanza*")
      {
         HasAS1000 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Asobo TBM 930 *")
      {
         HasAS3000Horiz2x = true,
      });

      DefaultAircraft.Add(new SimAircraft("ES30 *")
      {
         HasAS3000Vert2x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Microsoft Vision Jet *")
      {
         HasAS3000Horiz3x = true,
      });

      DefaultAircraft.Add(new SimAircraft("PC-12 NGX *")
      {
      });

      DefaultAircraft.Add(new SimAircraft("PC-12NGX *")
      {
      });

      DefaultAircraft.Add(new SimAircraft("JMB Aviation VL3*")
      {
         HasG3X2x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Draco X: *")
      {
         HasG3X2x = true,
         HasGTN650 = true,
      });

      DefaultAircraft.Add(new SimAircraft("Vertigo:*")
      {
         HasG3X2x = true,
      });

      DefaultAircraft.Add(new SimAircraft("CGS Hawk Arrow II*")
      {
         HasG3X1x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Extra 330 *")
      {
         HasAS3XPortrait2x = true,
         HasGTN650 = true,
      });

      DefaultAircraft.Add(new SimAircraft("XCub*")
      {
         HasG3X1x = true,
      });

      DefaultAircraft.Add(new SimAircraft("NXCub*")
      {
         HasG3X1x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Zlin Aviation Savage Cub*")
      {
         HasG3X1x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Virus SW Pipistrel*")
      {
         HasG3X2x = true,
      });

      DefaultAircraft.Add(new SimAircraft("Beechcraft King Air*")
      {
      });

      DefaultAircraft.Add(new SimAircraft("MonsterNX**")
      {
         HasG3X1x = true,
      });


   }

   public SimAircraftCollection()
   {
   }

   public SimAircraft? GetByTitle(string title)
   {
      return aircraftList.FirstOrDefault(x => x.Title == title);
   }

   public SimAircraft? GetByTitleStartsWith(string title)
   {
      return aircraftList.FirstOrDefault(x => x.Title.StartsWith(title));
   }

   public SimAircraft? GetByTitleWildcard(string title)
   {
      Regex regex;
      Match match;

      foreach (SimAircraft ac in aircraftList)
      {
         string search = "^" + ac.Title.Replace("*", @".*");
         regex = new Regex(search);
         match = regex.Match(title);
         if (match.Success)
            return ac;
      }

      return null;
   }

   //public bool Contains(string title)
   //{
   //   return GetByTitle(title) != null;
   //}

   #region Interface Implementation

   public SimAircraft this[int index] { get => ((IList<SimAircraft>)aircraftList)[index]; set => ((IList<SimAircraft>)aircraftList)[index] = value; }

   public int Count => ((ICollection<SimAircraft>)aircraftList).Count;

   public bool IsReadOnly => ((ICollection<SimAircraft>)aircraftList).IsReadOnly;

   public void Add(SimAircraft item)
   {
      ((ICollection<SimAircraft>)aircraftList).Add(item);
   }

   public void Clear()
   {
      ((ICollection<SimAircraft>)aircraftList).Clear();
   }

   public bool Contains(SimAircraft item)
   {
      return ((ICollection<SimAircraft>)aircraftList).Contains(item);
   }

   public void CopyTo(SimAircraft[] array, int arrayIndex)
   {
      ((ICollection<SimAircraft>)aircraftList).CopyTo(array, arrayIndex);
   }

   public IEnumerator<SimAircraft> GetEnumerator()
   {
      return ((IEnumerable<SimAircraft>)aircraftList).GetEnumerator();
   }

   public int IndexOf(SimAircraft item)
   {
      return ((IList<SimAircraft>)aircraftList).IndexOf(item);
   }

   public void Insert(int index, SimAircraft item)
   {
      ((IList<SimAircraft>)aircraftList).Insert(index, item);
   }

   public bool Remove(SimAircraft item)
   {
      return ((ICollection<SimAircraft>)aircraftList).Remove(item);
   }

   public void RemoveAt(int index)
   {
      ((IList<SimAircraft>)aircraftList).RemoveAt(index);
   }

   IEnumerator IEnumerable.GetEnumerator()
   {
      return ((IEnumerable)aircraftList).GetEnumerator();
   }

   #endregion
}
