using MacroSim.Fsuipc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroSim
{
   public partial class PresetEventForm : Form
   {

      private AutoCompleteStringCollection autoCompleteStrings;

      public EventCollection PresetEvents { get; private set; }

      private FsuipcConnection fsuipcConnection;

      public PresetEventForm(EventCollection events)
      {
         InitializeComponent();

         fsuipcConnection = new FsuipcConnection((MainForm)ParentForm);
         PresetEvents = events;

         autoCompleteStrings = new AutoCompleteStringCollection();

         List<string> aircraftList = new List<string>(PresetEvents.GetAircraft());
         aircraftList.Sort();
         foreach (string s in aircraftList)
         {
            autoCompleteStrings.Add(s);
         }
         txtAircraft.AutoCompleteCustomSource = autoCompleteStrings;
         txtAircraft.AutoCompleteMode = AutoCompleteMode.None;
         txtAircraft.AutoCompleteSource = AutoCompleteSource.CustomSource;

         btnSendCalculatorCode.Enabled = false;

         txtAircraft_TextChanged(new object(), new EventArgs());
      }

      private void txtAircraft_TextChanged(object sender, EventArgs e)
      {
         listAircraft.Items.Clear();
         listPresets.Items.Clear();

         if (txtAircraft.Text.Length == 0)
         {
            //HideResults();
            //return;

            foreach (string s in txtAircraft.AutoCompleteCustomSource)
            {
               listAircraft.Items.Add(s);
            }
            return;
         }

         foreach (string s in txtAircraft.AutoCompleteCustomSource)
         {
            if (s.Contains(txtAircraft.Text, StringComparison.OrdinalIgnoreCase))
            {
               listAircraft.Items.Add(s);
               listAircraft.Visible = true;
            }
         }

         var presets = PresetEvents.GetEventsForAircraft(txtAircraft.Text);
         if (presets != null && presets.Count > 0)
         {
            foreach (var preset in presets)
            {
               listPresets.Items.Add(preset.PresetName);
            }
         }
      }

      private void HideResults()
      {
         //listAircraft.Visible = false;
      }

      private void listAircraft_SelectedIndexChanged(object sender, EventArgs e)
      {
         txtAircraft.Text = listAircraft.Items[listAircraft.SelectedIndex].ToString();
         HideResults();
      }

      private void listAircraft_Leave(object sender, EventArgs e)
      {
         HideResults();
      }

      private void btnClearAircraft_Click(object sender, EventArgs e)
      {
         txtAircraft.Text = "";
         txtCalculatorCode.Text = "";
      }

      private void listPresets_SelectedIndexChanged(object sender, EventArgs e)
      {
         var ev = PresetEvents.GetEvent(listPresets.Text);
         if (ev != null)
         {
            txtCalculatorCode.Text = ev.CalculatorCode;
            txtParameter.Enabled = ev.IsParameterized;
         }
      }

      private void txtCalculatorCode_TextChanged(object sender, EventArgs e)
      {
         btnSendCalculatorCode.Enabled = (txtCalculatorCode.Text.Length > 0);
      }

      private void btnSendCalculatorCode_Click(object sender, EventArgs e)
      {
         fsuipcConnection.SendCalculatorCode(txtCalculatorCode.Text);
      }
   }
}
