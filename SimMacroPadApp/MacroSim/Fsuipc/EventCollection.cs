using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.Fsuipc;

public class EventCollection : ICollection<Event>, IList<Event>, IEnumerable<Event>
{
   private readonly List<Event> events;

   public EventCollection()
   {
      events = new List<Event>();
   }

   public EventCollection(ICollection<Event> collection)
   {
      events = new List<Event>(collection);
   }

   public EventCollection(IEnumerable<Event> collection)
   {
      events = new List<Event>(collection);
   }

   public EventCollection(IList<Event> list)
   {
      events = new List<Event>(list);
   }

   /// <summary>
   /// Gets an event from the collection matching the parameters.
   /// </summary>
   /// <param name="developer"></param>
   /// <param name="aircraft"></param>
   /// <param name="presetName"></param>
   /// <returns>the <see cref="Event"/> specified or null</returns>
   public Event? GetEvent(string? developer, string aircraft, string presetName)
   {
      if (developer == null)
         return events.FirstOrDefault(x =>
            x.Aircraft == aircraft && x.PresetName == presetName);
      else
         return events.FirstOrDefault(x =>
            x.Developer == developer && x.Aircraft == aircraft && x.PresetName == presetName);
   }

   /// <summary>
   /// Gets an event from the collection with the specified preset name.
   /// </summary>
   /// <param name="presetName"></param>
   /// <returns>the <see cref="Event"/> specified or null</returns>
   public Event? GetEvent(string presetName)
   {
      return events.FirstOrDefault(x=> x.PresetName == presetName);
   }

   public EventCollection GetEventsForAircraft(string aircraft)
   {
      return new EventCollection(
         events.Where(e =>
            e.Aircraft == aircraft));
   }

   public EventCollection GetEventsForAircraft(string developer, string aircraft)
   {
      return new EventCollection(
         events.Where(e =>
            e.Developer == developer &&
            e.Aircraft == aircraft));
   }

   public EventCollection GetEventsForClassification(string aircraft, string classification)
   {
      return new EventCollection(
         events.Where(e =>
            e.Aircraft == aircraft &&
            e.Classification == classification));
   }

   public EventCollection GetEventsForClassification(string developer, string aircraft, string classification)
   {
      return new EventCollection(
         events.Where(e =>
            e.Developer == developer &&
            e.Aircraft == aircraft &&
            e.Classification == classification));
   }

   /// <summary>
   /// Gets a unique collection of developers in the collection.
   /// </summary>
   /// <returns>an <see cref="IEnumerable"/> containing the developers.</returns>
   public IEnumerable<string> GetDevelopers()
   {
      return events
         .Select(e => e.Developer)
         .Distinct();
   }

   /// <summary>
   /// Gets a unique collection of aircraft in the collection.
   /// </summary>
   /// <param name="developer">An optional parameter to specify the developer.</param>
   /// <returns>an <see cref="IEnumerable"/> containing the aircraft.</returns>
   public IEnumerable<string> GetAircraft(string? developer = null)
   {
      if (developer == null)
      {
         return events.Select(e => e.Aircraft).Distinct();
      }
      return events
         .Where(e => e.Developer == developer)
         .DistinctBy(e => e.Aircraft)
         .Select(e => e.Aircraft);
   }

   /// <summary>
   /// Gets a unique collection of classifications for a specific aircraft.
   /// </summary>
   /// <param name="developer">The developer of the aircraft. (optional)</param>
   /// <param name="aircraft">The aircraft.</param>
   /// <returns>An <see cref="IEnumerable"/> containing the classifications.</returns>
   public IEnumerable<string> GetClassifications(string? developer, string aircraft)
   {
      IEnumerable<Event> where;

      if (developer == null)
         where = events.Where(e => e.Aircraft == aircraft);
      else
         where = events.Where(e => e.Developer == developer && e.Aircraft == aircraft);

      return where
         .DistinctBy(e => e.Classification)
         .Select(e => e.Classification);
   }

   public void ImportEvents(string filename)
   {
      var newEvents = ReadCollection(filename);
      if (newEvents != null)
         Add(newEvents);
   }

   /// <summary>
   /// Creates a new <see cref="EventCollection"/> from a file.
   /// </summary>
   /// <param name="filename"></param>
   /// <returns>the newly created <see cref="EventCollection"/>.</returns>
   public static EventCollection? ReadCollection(string filename)
   {
      try
      {
         TextReader reader = new StreamReader(filename);
         return ReadCollection(reader);
      }
      catch
      {
         return null;
      }
   }

   /// <summary>
   /// Creates a new <see cref="EventCollection"/> from a <see cref="TextReader"/> object.
   /// </summary>
   /// <param name="reader"></param>
   /// <returns>the newly created <see cref="EventCollection"/>.</returns>
   public static EventCollection ReadCollection(TextReader reader)
   {
      EventCollection events = new EventCollection();

      string? line;
      string developer = string.Empty;
      string aircraft = string.Empty;
      string classification = string.Empty;
      string[] lines;

      while ((line = reader.ReadLine()) != null)
      {
         if (line.StartsWith(@"///"))
            continue;
         else if (line.StartsWith(@"//"))
         {
            line = line.Substring(2);
            lines = line.Split('/');
            developer = lines[0];
            aircraft = lines[1];
            classification = lines[2];
         }
         else
         {
            lines = line.Split('#', 2);
            events.Add(developer, aircraft, classification, lines[0], lines[1]);
         }
      }

      return events;
   }

   /// <summary>
   /// Adds a new <see cref="Event"/> to the collection.
   /// </summary>
   /// <param name="developer"></param>
   /// <param name="aircraft"></param>
   /// <param name="classification"></param>
   /// <param name="presetName"></param>
   /// <param name="calculatorCode"></param>
   /// <returns>the newly created <see cref="Event"/></returns>
   public Event Add(string developer, string aircraft, string classification, string presetName, string calculatorCode)
   {
      Event e = new Event(developer, aircraft, classification, presetName, calculatorCode);
      events.Add(e);
      return e;
   }

   /// <summary>
   /// Adds all <see cref="Event"/>s in an <see cref="EventCollection"/> to the
   /// current collection.
   /// </summary>
   /// <param name="eventCollection"></param>
   public void Add(EventCollection eventCollection)
   {
      foreach (Event e in eventCollection)
      {
         Add(e);
      }
   }

   #region Interface Implementation

   public int Count => ((ICollection<Event>)events).Count;

   public bool IsReadOnly => ((ICollection<Event>)events).IsReadOnly;

   public Event this[int index] { get => ((IList<Event>)events)[index]; set => ((IList<Event>)events)[index] = value; }

   public void Add(Event item)
   {
      ((ICollection<Event>)events).Add(item);
   }

   public void Clear()
   {
      ((ICollection<Event>)events).Clear();
   }

   public bool Contains(Event item)
   {
      return ((ICollection<Event>)events).Contains(item);
   }

   public void CopyTo(Event[] array, int arrayIndex)
   {
      ((ICollection<Event>)events).CopyTo(array, arrayIndex);
   }

   public IEnumerator<Event> GetEnumerator()
   {
      return ((IEnumerable<Event>)events).GetEnumerator();
   }

   public bool Remove(Event item)
   {
      return ((ICollection<Event>)events).Remove(item);
   }

   IEnumerator IEnumerable.GetEnumerator()
   {
      return ((IEnumerable)events).GetEnumerator();
   }

   public int IndexOf(Event item)
   {
      return ((IList<Event>)events).IndexOf(item);
   }

   public void Insert(int index, Event item)
   {
      ((IList<Event>)events).Insert(index, item);
   }

   public void RemoveAt(int index)
   {
      ((IList<Event>)events).RemoveAt(index);
   }

   #endregion
}
