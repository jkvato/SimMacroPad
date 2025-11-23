using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using System.Security;
using System.Runtime.ConstrainedExecution;
using DeviceManagement;

// https://dotnet-experience.blogspot.com/2012/05/resetting-local-ports-and-devices-from.html

namespace MacroSim;

public class ComPortUtils
{
   public static bool IsPortAvailable(string portName)
   {
      // Retrieve the list of ports currently mounted by
      // the operating system (sorted by name)
      string[] ports = SerialPort.GetPortNames();
      if (ports != null && ports.Length > 0)
      {
         return ports.Where(new Func<string, bool>((s) =>
         {
            return s.Equals(portName, StringComparison.InvariantCultureIgnoreCase);
         })).Count() == 1;
      }
      return false;
   }

   //public static string? GetInstanceId(string portName)
   //{
   //   ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_SerialPort");
   //   foreach (ManagementObject port in searcher.Get())
   //   {
   //      if (port["DeviceID"].ToString().Equals(portName))
   //      {
   //         return port["PNPDeviceID"].ToString();
   //      }
   //   }
   //   return null;
   //}



   //public static bool TryResetPortByInstanceId(string instanceId)
   //{
   //   SafeDeviceInfoSetHandle diSetHandle = null;

   //   if (!string.IsNullOrEmpty(instanceId))
   //   {
   //      try
   //      {
   //         Guid[] guidArray = GetGuidFromName("Ports");

   //         //Get the handle to a device information set for all
   //         //devices matching classGuid that are present on the
   //         //system.
   //         diSetHandle = NativeMethods.SetupDiGetClassDevs(
   //             ref guidArray[0],
   //             null,
   //             IntPtr.Zero,
   //             SetupDiGetClassDevsFlags.DeviceInterface);

   //         //Get the device information data for each matching device.
   //         DeviceInfoData[] diData = DeviceHelper.GetDeviceInfoData(diSetHandle);

   //         //Try to find the object with the same instance Id.
   //         foreach (var infoData in diData)
   //         {
   //            var instanceIds =
   //                    GetInstanceIdsFromClassGuid(infoData.ClassGuid);
   //            foreach (var id in instanceIds)
   //            {
   //               if (id.Equals(instanceId))
   //               {
   //                  //disable port
   //                  SetDeviceEnabled(infoData.ClassGuid, id, false);
   //                  //wait some milliseconds
   //                  Thread.Sleep(200);
   //                  //enable port
   //                  SetDeviceEnabled(infoData.ClassGuid, id, true);
   //                  return true;
   //               }
   //            }
   //         }
   //      }
   //      catch (Exception)
   //      {
   //         return false;
   //      }
   //      finally
   //      {
   //         if (diSetHandle != null)
   //         {
   //            if (diSetHandle.IsClosed == false)
   //            {
   //               diSetHandle.Close();
   //            }
   //            diSetHandle.Dispose();
   //         }
   //      }
   //   }
   //   return false;
   //}






   /// <summary>
   /// The SetupDiGetClassDevs function returns a <see cref="SafeDeviceInfoSetHandle" /> handle to a device information set
   /// that contains requested device information elements for a local computer.
   /// </summary>
   /// <param name="classGuid">
   /// A pointer to the GUID for a device setup class or a device interface class. This pointer is
   /// optional and can be <see langword="null" />. For more information about how to set ClassGuid, see the following Remarks
   /// section.
   /// </param>
   /// <param name="enumerator">
   /// A pointer to a NULL-terminated string that specifies:
   /// <list type="bullet">
   ///     <item>
   ///         <description>
   ///         An identifier(ID) of a Plug and Play(PnP) enumerator.This ID can either be the value's globally
   ///         unique identifier (GUID) or symbolic name. For example, "PCI" can be used to specify the PCI PnP value. Other
   ///         examples of symbolic names for PnP values include "USB," "PCMCIA," and "SCSI".
   ///         </description>
   ///     </item>
   ///     <item>
   ///         <description>
   ///         A PnP device instance ID.When specifying a PnP device instance ID, DIGCF_DEVICEINTERFACE must be
   ///         set in the Flags parameter.
   ///         </description>
   ///     </item>
   /// </list>
   /// This pointer is optional and can be <see langword="null" />.If an enumeration value is not used to select devices, set
   /// Enumerator to <see langword="null" />.
   /// </param>
   /// <param name="hwndParent">
   /// A handle to the top-level window to be used for a user interface that is associated with
   /// installing a device instance in the device information set. This handle is optional and can be <see langword="null" />.
   /// </param>
   /// <param name="flags">
   /// A variable of type DWORD that specifies control options that filter the device information elements
   /// that are added to the device information set. This parameter can be a bitwise OR of zero or more of the flags.
   /// </param>
   /// <returns>
   /// If the operation succeeds, SetupDiGetClassDevs returns a handle to a device information set that contains all
   /// installed devices that matched the supplied parameters. If the operation fails, the function returns an invalid handle.
   /// </returns>
   /// 

   //[DllImport(nameof(SetupApi), SetLastError = true, CharSet = CharSet.Unicode)]
   //public static extern unsafe SafeDeviceInfoSetHandle SetupDiGetClassDevs(
   //    [Friendly(FriendlyFlags.In | FriendlyFlags.Optional)] Guid* classGuid,
   //    string enumerator,
   //    IntPtr hwndParent,
   //    GetClassDevsFlags flags);








}
