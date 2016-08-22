using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
using ODSJournal.DataModel;
namespace ODSJournal.Views.Common.Clients
{
    public partial class Editor : Form
    {
        private int[] addId;
        private int cid;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit.Visible = false;
            this.AcceptButton = btn_Add;
            this.RefreshAddrList();
        }

        public Editor(int ClientId)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Add.Visible = false;
            this.cid = ClientId;
            this.AcceptButton = btn_Edit;
            this.RefreshAddrList();
            ClientsModel m = new ClientsModel();
            ODS_Clients cl = m.GetClientById(ClientId);
            tbx_FIO.Text = cl.ClientFIO.ToString().Trim();
            tbx_CPhone.Text = cl.ClientPhone.ToString().Trim();
            tbx_Liter.Text = cl.Liter.ToString().Trim();
            num_EntrNum.Value = cl.Entrance.Value;
            num_HNum.Value = cl.ClientHomeNum.Value;
            num_RoomNum.Value = cl.Room.Value;
            this.SetCBoxItem(cl.AddressId.Value);
        }

        protected void SetCBoxItem(int id)
        {
            for (int i = 0; i < this.addId.Count(); i++)
            {
                if (addId[i] == id)
                {
                    cbx_Address.SelectedIndex = i;
                };
            };
        }

        protected bool CheckFields()
        {
            if (tbx_FIO.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Вы не заполнили необходимые поля!");
                return false;
            };
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.CheckFields())
            {
                ClientsModel m = new ClientsModel(0, tbx_FIO.Text.ToString(), tbx_CPhone.Text.ToString(),
                    Convert.ToInt32(num_HNum.Value), addId[cbx_Address.SelectedIndex], tbx_Liter.Text.ToString(), Convert.ToInt32(num_EntrNum.Value), Convert.ToInt32(num_RoomNum.Value));
                m.Add();
                this.Close();
            };
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (this.CheckFields())
            {
                ClientsModel m = new ClientsModel(this.cid, tbx_FIO.Text.ToString(), tbx_CPhone.Text.ToString(),
                    Convert.ToInt32(num_HNum.Value), addId[cbx_Address.SelectedIndex], tbx_Liter.Text.ToString(), Convert.ToInt32(num_EntrNum.Value), Convert.ToInt32(num_RoomNum.Value));
                m.Change();
                this.Close();
            };
        }

        private void btn_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_AddNewAddr_Click(object sender, EventArgs e)
        {
            Views.Common.Address.Editor ed = new Address.Editor();
            ed.Show();
        }

        private void btn_Addr_Refresh_Click(object sender, EventArgs e)
        {
            this.RefreshAddrList();
        }

        protected void RefreshAddrList()
        {
            cbx_Address.Items.Clear();
            AddressModel am = new AddressModel();
            var addr = am.GetAddresses();
            this.addId = new int[addr.Count()];
            foreach (var a in addr)
            {
                cbx_Address.Items.Add(a.Address.ToString().Trim());
                this.addId[cbx_Address.Items.Count - 1] = a.AddressId;
            };
        }

        private void btn_Addr_Refresh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_AddNewAddr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_FIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_CPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void cbx_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void num_HNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void num_EntrNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Liter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void num_RoomNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).ClientAddE)) { this.Close(); };
        }

        private void cbx_Address_TextChanged(object sender, EventArgs e)
        {
            cbx_Address.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx_Address.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbx_Address.SelectionLength = 0;
            cbx_Address.SelectionStart = cbx_Address.Text.Length;
        }
    }
}
