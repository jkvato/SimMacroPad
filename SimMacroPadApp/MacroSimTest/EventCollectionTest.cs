using MacroSim;
using MacroSim.Fsuipc;

namespace MacroSimTest
{
   [TestClass]
   public sealed class EventCollectionTest
   {
      private readonly EventCollection events;

      public EventCollectionTest()
      {
         events = new EventCollection();

         events.Add("Asobo", "Cessna", "Radios", "Preset1", "Calculate");
         events.Add("Asobo", "Cessna", "Electrical", "Preset2", "Calculate");
         events.Add("Asobo", "Cessna", "Electrical", "Preset3", "Calculate");
         events.Add("Asobo", "Daher", "Radios", "Preset4", "Calculate");
         events.Add("Carenado", "Piper", "GPS", "Preset5", "Calculate");
         events.Add("Microsoft", "Cessna", "Lights", "Preset6", "Calculate");
      }

      [TestMethod]
      public void DistinctDevelopers()
      {
         var c = events.GetDevelopers().ToList();
         Assert.AreEqual(3, c.Count);
         Assert.AreEqual("Asobo", c[0]);
         Assert.AreEqual("Carenado", c[1]);
         Assert.AreEqual("Microsoft", c[2]);
      }

      [TestMethod]
      public void DistinctAircraftAll()
      {
         var c = events.GetAircraft().ToList();
         Assert.AreEqual(3, c.Count);
         Assert.AreEqual("Cessna", c[0]);
         Assert.AreEqual("Daher", c[1]);
         Assert.AreEqual("Piper", c[2]);
      }

      [TestMethod]
      public void DistinctAircraftByDeveloper()
      {
         var c = events.GetAircraft("Asobo").ToList();
         Assert.AreEqual(2, c.Count);
         Assert.AreEqual("Cessna", c[0]);
         Assert.AreEqual("Daher", c[1]);
      }

      [TestMethod]
      public void DistinctClassificationsByDeveloper()
      {
         var c = events.GetClassifications("Asobo", "Cessna").ToList();
         Assert.AreEqual(2, c.Count);
         Assert.AreEqual("Radios", c[0]);
         Assert.AreEqual("Electrical", c[1]);
      }

      [TestMethod]
      public void DistinctClassificationsAllDevelopers()
      {
         var c = events.GetClassifications(null, "Cessna").ToList();
         Assert.AreEqual(3, c.Count);
         Assert.AreEqual("Radios", c[0]);
         Assert.AreEqual("Electrical", c[1]);
         Assert.AreEqual("Lights", c[2]);
      }

      [TestMethod]
      public void ReadEventsFile()
      {
         var eventsFile = EventCollection.ReadCollection(@"C:\FSUIPC7\events.txt");

         Assert.AreEqual(17586, eventsFile.Count);
         Assert.AreEqual(44, eventsFile.GetDevelopers().Count());
         Assert.AreEqual(102, eventsFile.GetAircraft().Count());

         Assert.AreEqual(19, eventsFile.GetEventsForAircraft("SR22T").Count);
      }
   }
}
