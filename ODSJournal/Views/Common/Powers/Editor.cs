using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Powers
{
    public partial class Editor : Form
    {
        public int id;
        public int fid;
        public int[] FiderIDs;
        public int[] SubsIDs;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_TP.Visible = false;
            this.AcceptButton = btn_Add_TP;
            this.LoadSubstations();
        }

        public Editor(int id, string name, int fid)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Add_TP.Visible = false;
            this.AcceptButton = btn_Edit_TP;
            this.id = id;
            this.fid = fid;
            tbx_TP.Text = name;
            this.LoadSubstations(id);
        }

        public void LoadFiders()
        {
            cbx_Fiders.Items.Clear();
            cbx_Fiders.Text = "";
            FiderModel m = new FiderModel();
            var a = m.GetFiders();
            this.FiderIDs = new int[a.Count()];
            foreach (var b in a)
            {
                cbx_Fiders.Items.Add(b.FiderName.Trim());
                this.FiderIDs[cbx_Fiders.Items.Count - 1] = b.FiderId;
            };
        }

        public void LoadFiders(int id)
        {
            cbx_Fiders.Items.Clear();
            cbx_Fiders.Text = "";
            FiderModel m = new FiderModel();
            var a = m.GetFiders();
            this.FiderIDs = new int[a.Count()];
            foreach (var b in a)
            {
                cbx_Fiders.Items.Add(b.FiderName.Trim());
                this.FiderIDs[cbx_Fiders.Items.Count - 1] = b.FiderId;
                if (b.FiderId == id)
                {
                    cbx_Fiders.SelectedIndex = cbx_Fiders.Items.Count - 1;
                }
            };
        }

        public void LoadFidersBySID()
        {
            FiderModel m = new FiderModel();
            cbx_Fiders.Text = "";
            cbx_Fiders.Items.Clear();
            var res = m.GetFidersBySId(this.SubsIDs[cbx_Substations.SelectedIndex]);
            this.FiderIDs = new int[res.Count()];
            foreach (var b in res)
            {
                cbx_Fiders.Items.Add(b.FiderName.Trim());
                this.FiderIDs[cbx_Fiders.Items.Count - 1] = b.FiderId;
            };
        }

        public void LoadSubstations()
        {
            cbx_Fiders.Items.Clear();
            cbx_Fiders.Text = "";
            cbx_Substations.Items.Clear();
            cbx_Substations.Text = "";
            SubstationModel m = new SubstationModel();
            var res = m.GetStations();
            this.SubsIDs = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Substations.Items.Add(a.SubstationName.Trim());
                this.SubsIDs[cbx_Substations.Items.Count - 1] = a.SubstationId;
            };
        }

        public void LoadSubstationsById(int id)
        {
            cbx_Fiders.Items.Clear();
            cbx_Fiders.Text = "";
            cbx_Substations.Items.Clear();
            cbx_Substations.Text = "";
            SubstationModel m = new SubstationModel();
            var res = m.GetStations();
            this.SubsIDs = new int[res.Count()];
            foreach (var a in res)
            {
                cbx_Substations.Items.Add(a.SubstationName.Trim());
                this.SubsIDs[cbx_Substations.Items.Count - 1] = a.SubstationId;
                if (a.SubstationId == id)
                {
                    cbx_Substations.SelectedIndex = cbx_Substations.Items.Count - 1;
                };
            };
        }

        public void LoadFidersIdBySID(int fid)
        {
            FiderModel m = new FiderModel();
            cbx_Fiders.Text = "";
            cbx_Fiders.Items.Clear();
            var res = m.GetFidersBySId(this.SubsIDs[cbx_Substations.SelectedIndex]);
            this.FiderIDs = new int[res.Count()];
            foreach (var b in res)
            {
                cbx_Fiders.Items.Add(b.FiderName.Trim());
                this.FiderIDs[cbx_Fiders.Items.Count - 1] = b.FiderId;
                if (b.FiderId == fid)
                {
                    cbx_Fiders.SelectedIndex = cbx_Fiders.Items.Count - 1;
                };
            };
        }

        public void LoadSubstations(int pid)
        {
            PowersModel m = new PowersModel();
            var rpower = m.GetPowerById(pid);
            int fid = this.fid;
            int sid = rpower.ODS_Fidres.ODS_Substations.SubstationId;
            this.LoadSubstationsById(sid);
            this.LoadFidersIdBySID(fid);
        }


        private void btn_Edit_TP_Click(object sender, EventArgs e)
        {
            if (tbx_TP.Text.ToString().Trim() != "" && cbx_Fiders.SelectedIndex != -1)
            {
                PowersModel m = new PowersModel(this.id, this.FiderIDs[cbx_Fiders.SelectedIndex], tbx_TP.Text.ToString());
                m.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели источник питания или не выбрали фидер!");
            };
        }

        private void btn_Add_TP_Click(object sender, EventArgs e)
        {
            if (tbx_TP.Text.ToString().Trim() != "" && cbx_Fiders.SelectedIndex != -1)
            {
                PowersModel m = new PowersModel(0, this.FiderIDs[cbx_Fiders.SelectedIndex], tbx_TP.Text.ToString());
                m.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели источник питания или не выбрали фидер!");
            };
        }

        private void btn_Edit_TP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_TP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_TP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).PowerAddE)) { this.Close(); };
        }

        private void btn_Refresh_Fiders_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadFidersBySID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите подстанцию.");
            };
        }

        private void cbx_Substations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.LoadFidersBySID();
        }

        private void btn_RefreshSubstations_Click(object sender, EventArgs e)
        {
            this.LoadSubstations();
        }
    }
}
