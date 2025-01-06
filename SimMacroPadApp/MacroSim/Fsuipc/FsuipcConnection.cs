using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim.Fsuipc;

internal class FsuipcConnection
{
   public Offset<ushort> pauseWriteStatus = new Offset<ushort>(0x0262);
   public Offset<ushort> pauseReadStatus = new Offset<ushort>(0x0264);

   public EventCollection PresetEvents { get; private set; }

   public MainForm MainForm { get; private set; }

   public FsuipcConnection(MainForm mainForm, string? fsuipcDirectory = null)
   {
      MainForm = mainForm;
      if (fsuipcDirectory != null)
      {
         try
         {
            var newEvents = EventCollection.ReadCollection(fsuipcDirectory);
            if (newEvents != null)
            {
               PresetEvents = newEvents;
               return;
            }
         }
         catch
         {
            PresetEvents = new EventCollection();
         }
      }
      PresetEvents = new EventCollection();
   }


   public bool ConnectToSim()
   {
      try
      {
         FSUIPCConnection.Open();
      }
      catch
      {
      }

      if (FSUIPCConnection.IsOpen)
      {
         return true;
      }
      return false;
   }

   public bool IsConnected => FSUIPCConnection.IsOpen;

   public void DisconnectFromSim()
   {
      FSUIPCConnection.Close();
   }

   public void Process(string? groupName = null)
   {
      if (FSUIPCConnection.IsOpen)
      {
         if (groupName == null)
            FSUIPCConnection.Process();
         else
            FSUIPCConnection.Process(groupName);
      }
   }

   public static double IntToFrequency(uint value)
   {
      double result = value / 1000000d;
      return result;
   }

   public void SendPresetEvent(string presetName, int? param = null)
   {
      var e = PresetEvents.GetEvent(presetName);
      if (e == null)
         return;

      SendCalculatorCode(e.CalculatorCode, param);
   }

   public void SendCalculatorCode(string calculatorCode)
   {
      System.Diagnostics.Debug.WriteLine($"Executing: {calculatorCode}");
      MSFSVariableServices.ExecuteCalculatorCode(calculatorCode);
   }

   public void SendCalculatorCode(string calculatorCode, int? param = null)
   {
      if (calculatorCode.Length == 0)
         throw new ArgumentException(nameof(calculatorCode));

      if (calculatorCode[0] == '@')
      {
         if (param == null)
            throw new ArgumentNullException(nameof(param));

         calculatorCode = calculatorCode.Replace("@", param.ToString());
      }

      System.Diagnostics.Debug.WriteLine($"Executing: {calculatorCode}");
      MainForm.InvokeAction(form =>
      {
         form.txtOutput.Text = calculatorCode;
      });
      MSFSVariableServices.ExecuteCalculatorCode(calculatorCode);
   }

   public void SetPauseStatus(PauseState pauseState)
   {
      pauseWriteStatus.SetValue((ushort)pauseState);
   }

   public PauseState GetPauseStatus()
   {
      ushort result = pauseReadStatus.GetValue<ushort>();
      return (PauseState)result;
   }
}

[Flags]
public enum PauseState : ushort
{
   NoPause = 0x0,
   FullPause = 0x1,
   FsxLegacyPause = 0x2,
   ActivePause = 0x4,
   SimPause = 0x8,
   EscPause = 0x10,
}