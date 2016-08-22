using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.TPWizard
{
    public partial class Wizard : Form
    {
        private int[] StatIds;
        private int[] FiderIds;
        bool Changing;
        public Wizard()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadStations();
            this.Changing = false;
        }

        public Wizard(int TPid)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadStations();
            PowersModel m = new PowersModel();
            var power = m.GetPowerById(TPid);
            this.Changing = true;
        }

        public void LoadStations()
        {
            cbx_Stations.Items.Clear();
            SubstationModel m = new SubstationModel();
            var res = m.GetStations();
            this.StatIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Stations.Items.Add(a.SubstationName.Trim());
                this.StatIds[cbx_Stations.Items.Count - 1] = a.SubstationId;
            };
        }

        public void LoadFiders(int StationId)
        {
            cbx_Fiders.Items.Clear();
            FiderModel m = new FiderModel();
            var res = m.GetFidersBySId(StationId);
            this.FiderIds = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Fiders.Items.Add(a.FiderName.Trim());
                this.FiderIds[cbx_Fiders.Items.Count - 1] = a.FiderId;
            };
        }

        private void btn_Refresh_Substations_Click(object sender, EventArgs e)
        {
            this.LoadStations();
        }

        private void btn_Add_Substation_Click(object sender, EventArgs e)
        {
            if (tbx_Station.Text.Trim() != "")
            {
                SubstationModel m = new SubstationModel(0, tbx_Station.Text.Trim());
                m.Add();
            };
            tbx_Station.Clear();
            this.LoadStations();
        }

        private void cbx_Stations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.LoadFiders(this.StatIds[cbx_Stations.SelectedIndex]);
        }

        private void btn_Refresh_Fiders_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadFiders(this.StatIds[cbx_Stations.SelectedIndex]);
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void btn_AddFider_Click(object sender, EventArgs e)
        {
            if (tbx_Fider.Text.Trim() != "" && cbx_Stations.SelectedIndex != -1)
            {
                FiderModel m = new FiderModel(0, this.StatIds[cbx_Stations.SelectedIndex], tbx_Fider.Text.Trim());
                m.Add();
            };
            tbx_Fider.Clear();
            this.LoadFiders(this.StatIds[cbx_Stations.SelectedIndex]);
        }

        private void btn_Add_TP_Click(object sender, EventArgs e)
        {
            if (tbx_TP.Text.Trim() != "" && cbx_Fiders.SelectedIndex != -1)
            {
                PowersModel m = new PowersModel(0, this.FiderIds[cbx_Fiders.SelectedIndex], tbx_TP.Text.Trim());
                m.Add();
                this.Close();
            };
        }
    }
}
