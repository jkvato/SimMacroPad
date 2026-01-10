using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim;

public class DeviceUtils
{
   public static List<DeviceInfo> GetDevices()
   {
      List<DeviceInfo> devices = new List<DeviceInfo>();

      ManagementObjectCollection collection;
      using var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
      collection = searcher.Get();

      foreach (ManagementBaseObject? moObj in searcher.Get())
      {
         string? name = moObj.GetPropertyValue("Name")?.ToString();
         string? classGuid = moObj.GetPropertyValue("ClassGuid")?.ToString();
         string? deviceId = moObj.GetPropertyValue("DeviceId")?.ToString();

         if (name is null)
            name = string.Empty;
         if (classGuid is null)
            classGuid = string.Empty;
         if (deviceId is null)
            deviceId = string.Empty;

         devices.Add(new DeviceInfo(name, classGuid, deviceId));
      }

      collection.Dispose();
      return devices;
   }

   public static DeviceInfo? GetDeviceInfoByName(string name)
   {
      var devices = GetDevices();
      var device = devices.FirstOrDefault(x => x.Name.Contains(name));
      return device;
   }
}

public class DeviceInfo
{
   public string Name { get; private set; }
   public string ClassGUID { get; private set; }
   public string DeviceID { get; private set; }

   public DeviceInfo(string name, string classGuid, string deviceID)
   {
      Name = name;
      ClassGUID = classGuid;
      DeviceID = deviceID;
   }
}