using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Fiders
{
    public partial class Editor : Form
    {
        protected int FiderId;
        protected int SubId;
        protected string FiderName;
        protected int[] sids;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_Addr.Visible = false;
            this.AcceptButton = btn_Add_Addr;
            this.UchLoad();
        }

        public Editor(int id, string FiderName, int SubId)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.FiderId = id;
            this.SubId = SubId;
            this.FiderName = FiderName;
            tbx_Address.Text = this.FiderName;
            btn_Add_Addr.Visible = false;
            this.AcceptButton = btn_Edit_Addr;
            this.UchLoad(SubId);
        }

        public void UchLoad()
        {
            SubstationModel m = new SubstationModel();
            var uch = m.GetStations();
            string uchName = "";
            int SubId = 0;
            this.sids = new int[uch.Count()];
            foreach (var a in uch)
            {
                uchName = a.SubstationName;
                SubId = a.SubstationId;
                cbx_Uchs.Items.Add(uchName.Trim());
                this.sids[cbx_Uchs.Items.Count - 1] = SubId;
            };
        }

        public void UchLoad(int SubId)
        {
            SubstationModel m = new SubstationModel();
            var uch = m.GetStations();
            string uchName = "";
            this.sids = new int[uch.Count()];
            foreach (var a in uch)
            {
                uchName = a.SubstationName;
                int aSubId = a.SubstationId;
                cbx_Uchs.Items.Add(uchName.Trim());
                this.sids[cbx_Uchs.Items.Count - 1] = aSubId;
                if (a.SubstationId == SubId)
                {
                    cbx_Uchs.SelectedIndex = cbx_Uchs.Items.Count - 1;
                };
            };
        }

        private void btn_Edit_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_Address.Text.Trim() != "" && cbx_Uchs.SelectedIndex != -1)
            {
                FiderModel ad = new FiderModel(this.FiderId, this.sids[cbx_Uchs.SelectedIndex], tbx_Address.Text.ToString().Trim());
                ad.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели Фидер или не выбрали Подстанцию!");
            };
        }

        private void btn_Add_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_Address.Text.Trim() != "" && cbx_Uchs.SelectedIndex != -1)
            {
                FiderModel ad = new FiderModel(0, this.sids[cbx_Uchs.SelectedIndex], tbx_Address.Text.ToString().Trim());
                ad.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели Фидер или не выбрали Подстанцию!");
            };
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Edit_Addr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_Addr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void cbx_Uchs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).AddrAddE)) { this.Close(); };
        }
    }
}
