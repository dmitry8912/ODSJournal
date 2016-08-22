using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Monters
{
    public partial class Editor : Form
    {
        protected int MonterId;
        protected string FIO;
        protected string phone;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_Addr.Visible = false;
            this.AcceptButton = btn_Add_Addr;
        }

        public Editor(int id, string FIO, string phone)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.MonterId = id;
            this.FIO = FIO;
            this.phone = phone;
            tbx_FIO.Text = this.FIO.Trim();
            tbx_Phone.Text = this.phone.Trim();
            btn_Add_Addr.Visible = false;
            this.AcceptButton = btn_Edit_Addr;
        }

        private void btn_Edit_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_FIO.Text.Trim() != "" && tbx_Phone.Text.Trim() != "")
            {
                MonterModel m = new MonterModel(this.MonterId, tbx_FIO.Text.Trim(), tbx_Phone.Text.Trim());
                m.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели Ф.И.О. или номер телефона!");
            };
        }

        private void btn_Add_Addr_Click(object sender, EventArgs e)
        {
            if (tbx_FIO.Text.Trim() != "" && tbx_Phone.Text.Trim() != "")
            {
                MonterModel ad = new MonterModel(0, tbx_FIO.Text.Trim(), tbx_Phone.Text.Trim());
                ad.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели Ф.И.О. или номер телефона!");
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
