using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Address
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
            AddressModel m = new AddressModel();
            var addr = m.GetAddresses();
            string[] ad = new string[4];
            foreach (var a in addr)
            {
                ad[0] = a.AddressId.ToString();
                ad[1] = a.Address.ToString().Trim();
                ad[2] = a.UchId.ToString();
                ad[3] = a.ODS_Uchs.UchName.ToString().Trim();
                Tab_Addresses.Rows.Add(ad);
            }
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            Tab_Addresses.Rows.Clear();
            AddressModel m = new AddressModel();
            var addr = m.GetAddresses();
            string[] ad = new string[4];
            foreach (var a in addr)
            {
                ad[0] = a.AddressId.ToString();
                ad[1] = a.Address.ToString().Trim();
                ad[2] = a.UchId.ToString();
                ad[3] = a.ODS_Uchs.UchName.ToString().Trim();
                Tab_Addresses.Rows.Add(ad);
            }
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Views.Common.Address.Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (!Global.CheckRole((new RoleActionAssign()).AddrDel))
            {
                AddressModel m = new AddressModel(this.AddrId);
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
                int uid = Convert.ToInt32(Tab_Addresses.Rows[Tab_Addresses.SelectedRows[0].Index].Cells[2].Value.ToString());
                Views.Common.Address.Editor ed = new Editor(id, name, uid);
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
