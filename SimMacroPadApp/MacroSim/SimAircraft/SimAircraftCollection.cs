using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimAircraft;

internal class SimAircraftCollection : IList<SimAircraft>
{
   private readonly List<SimAircraft> aircraftList = new List<SimAircraft>();

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
}
