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
    public partial class Editor : Form
    {
        protected int AddressId;
        protected int UchId;
        protected string AddrName;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_Addr.Visible = false;
            this.AcceptButton = btn_Add_Addr;
            this.UchLoad();
        }

        public Editor(int id, string AddrName, int UchId)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.AddressId = id;
            this.UchId = UchId;
            this.AddrName = AddrName;
            tbx_Address.Text = this.AddrName;
            btn_Add_Addr.Visible = false;
            this.AcceptButton = btn_Edit_Addr;
            this.UchLoad(UchId);

        }

        public void UchLoad()
        {
            
            UchModel m = new UchModel();
            var uch = m.GetUchs();
            string uchName = "";
            int uchid = 0;
            foreach (var a in uch)
            {
                uchName = a.UchName;
                uchid = a.UchId;
                cbx_UIDs.Items.Add(uchid);
                cbx_Uchs.Items.Add(uchName.Trim());
            };
        }

        public void UchLoad(int UchId)
        {
            UchModel m = new UchModel();
            var uch = m.GetUchs();
            string uchName = "";
            int uchid = 0;
            foreach (var a in uch)
            {
                uchName = a.UchName;
                uchid = a.UchId;
                cbx_UIDs.Items.Add(uchid);
                cbx_Uchs.Items.Add(uchName.Trim());
                if (a.UchId == UchId)
                {
                    cbx_Uchs.SelectedIndex = cbx_Uchs.Items.Count-1;
                }
            };
        }

        private void btn_Edit_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_Address.Text.Trim() != "" && cbx_Uchs.SelectedIndex != -1)
            {
                AddressModel ad = new AddressModel(this.AddressId, Convert.ToInt32(cbx_UIDs.Items[cbx_Uchs.SelectedIndex].ToString()), tbx_Address.Text.ToString().Trim());
                ad.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели адрес или не выбрали участок!");
            };
        }

        private void btn_Add_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_Address.Text.Trim() != "" && cbx_Uchs.SelectedIndex != -1)
            {
                AddressModel ad = new AddressModel(0, Convert.ToInt32(cbx_UIDs.Items[cbx_Uchs.SelectedIndex].ToString()), tbx_Address.Text.ToString().Trim());
                ad.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели адрес или не выбрали участок!");
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
