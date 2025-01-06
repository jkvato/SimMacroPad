using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum SmartcamTargetType : int
{
   Unknown = 0,
   FollowPOI = 1,
   UserPOI = 2,
   GeneralPOI = 3,
   EndOfRunway = 4,
   LandingRunway = 5,
   FlightPath = 6,
   ObjectInteraction = 7,
   MultiplayerOOI = 8,
   ActiveRunway = 9,
   Waypoint = 10,
   AirportOOI = 11,
   FlightAssistantDestination = 12,
}
