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
    public partial class Viewer : Form
    {
        protected int AddrId;
        public Viewer()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            Tab_Addresses.Rows.Clear();
            this.LoadData();
        }

        public void LoadData()
        {
            Tab_Addresses.Rows.Clear();
            FiderModel m = new FiderModel();
            var addr = m.GetFiders();
            string[] ad = new string[4];
            foreach (var a in addr)
            {
                ad[0] = a.FiderId.ToString();
                ad[1] = a.FiderName.ToString().Trim();
                ad[2] = a.SubstationId.ToString();
                ad[3] = a.ODS_Substations.SubstationName.ToString().Trim();
                Tab_Addresses.Rows.Add(ad);
            }
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Views.Common.Fiders.Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (!Global.CheckRole((new RoleActionAssign()).AddrDel))
            {
                FiderModel m = new FiderModel(this.AddrId);
                m.Delete();
                this.LoadData();
            };

        }

        private void Tab_Addresses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Tab_Addresses.Rows[Tab_Addresses.SelectedRows[0].Index].Cells[0].Value.ToString());
                string name = Tab_Addresses.Rows[Tab_Addresses.SelectedRows[0].Index].Cells[1].Value.ToString();
                int sid = Convert.ToInt32(Tab_Addresses.Rows[Tab_Addresses.SelectedRows[0].Index].Cells[2].Value.ToString());
                Views.Common.Fiders.Editor ed = new Editor(id, name, sid);
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Addresses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.AddrId = Convert.ToInt32(Tab_Addresses.Rows[Tab_Addresses.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Addresses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }
    }
}
