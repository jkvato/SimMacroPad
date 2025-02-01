using DevExpress.XtraEditors;
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
   public partial class PresetEventForm : XtraForm
   {

      private AutoCompleteStringCollection autoCompleteStrings;

      public EventCollection PresetEvents { get; private set; }

      private FsuipcConnection fsuipcConnection;

      List<string> aircraftList;

      public PresetEventForm(EventCollection events)
      {
         InitializeComponent();

         fsuipcConnection = new FsuipcConnection((MainForm)ParentForm);
         PresetEvents = events;

         aircraftList = new List<string>(PresetEvents.GetAircraft());
         aircraftList.Sort();

         gridLookUpEditAircraft.Properties.DataSource = aircraftList;
         gridLookUpEditAircraft.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
         gridLookUpEditAircraft.EditValue = "Select Aircraft";

         btnSendCalculatorCode.Enabled = false;
      }

      private void btnClearAircraft_Click(object sender, EventArgs e)
      {
         //txtAircraft.Text = "";
         gridLookUpEditAircraft.EditValue = "";
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

      private void gridLookUpEditAircraft_EditValueChanged(object sender, EventArgs e)
      {
         listPresets.Items.Clear();

         var presets = PresetEvents.GetEventsForAircraft(gridLookUpEditAircraft.EditValue.ToString());
         if (presets != null && presets.Count > 0)
         {
            foreach (var preset in presets)
            {
               listPresets.Items.Add(preset.PresetName);
            }
         }
      }
   }
}
