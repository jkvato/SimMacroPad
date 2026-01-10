using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
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
         aircraftList.Insert(0, "ANY");

         gridLookUpEditAircraft.Properties.DataSource = aircraftList;
         gridLookUpEditAircraft.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
         gridLookUpEditAircraft.EditValue = "Select Aircraft";

         searchControl1.Client = listPresets;

         btnSendCalculatorCode.Enabled = false;
      }

      private void btnClearAircraft_Click(object sender, EventArgs e)
      {
         gridLookUpEditAircraft.EditValue = "";
         txtCalculatorCode.Text = "";
         txtActiveAircraft.Text = "";
      }

      private void listPresets_SelectedIndexChanged(object sender, EventArgs e)
      {
         var evt = (Event)listPresets.SelectedItem;
         if (evt != null)
         {
            txtCalculatorCode.Text = evt.CalculatorCode;
            txtParameter.Enabled = evt.IsParameterized;

            txtActiveAircraft.Text = evt.Developer + " | " + evt.Aircraft + " | " + evt.Classification;
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

         string ac = (string)gridLookUpEditAircraft.EditValue;

         if (ac == "ANY")
         {
            listPresets.DataSource = PresetEvents;
            listPresets.DisplayMember = "PresetName";
         }
         else
         {
            var presets = PresetEvents.GetEventsForAircraft(ac);
            listPresets.DataSource = presets;
            listPresets.DisplayMember = "PresetName";
         }
      }
   }
}
