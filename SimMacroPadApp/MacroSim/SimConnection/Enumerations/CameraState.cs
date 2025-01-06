using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.SimConnection.Enumerations;

public enum CameraState : int
{
   Cockpit = 2,
   External = 3,
   Drone = 4,
   Plane = 5,
   Environment = 6,
   SixDoF = 7,
   Gameplay = 8,
   Showcase = 9,
   DroneAC = 10,
   Waiting = 11,
   WorldMap = 12,
   HangarRTC = 13,
   HangarCustom = 14,
   MenuRTC = 15,
   InGameRTC = 16,
   Replay = 17,
   DroneTopDown = 19,
   Hangar = 21,
   Ground = 24,
   FollowTrafficAC = 25
}
