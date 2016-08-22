using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Substations
{
    public partial class Editor : Form
    {
        protected int id;
        protected string name;
        protected int[] uchId;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit.Visible = false;
            this.AcceptButton = btn_AddUch;
            UchModel m = new UchModel();
            var uchs = m.GetUchs();
            this.uchId = new int[uchs.Count()];
            foreach (var a in uchs)
            {
                cbx_Uch.Items.Add(a.UchName.ToString().Trim());
                this.uchId[cbx_Uch.Items.Count - 1] = a.UchId;
            };
        }

        public Editor(int id, string name)
        {
            SubstationModel sm = new SubstationModel();
            var sub = sm.GetStation(id);

            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            tbx_uname.Text = name;
            btn_AddUch.Text = "Изменить";
            this.id = id;
            this.name = name;
            btn_AddUch.Visible = false;
            this.AcceptButton = btn_Edit;


            UchModel m = new UchModel();
            var uchs = m.GetUchs();
            this.uchId = new int[uchs.Count()];
            foreach (var a in uchs)
            {
                cbx_Uch.Items.Add(a.UchName.ToString().Trim());
                this.uchId[cbx_Uch.Items.Count - 1] = a.UchId;
                if (sub.UchId == a.UchId)
                {
                    cbx_Uch.SelectedIndex = cbx_Uch.Items.Count - 1;
                };
            };
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).UchAddE)) { this.Close(); };
        }

        private void btn_AddUch_Click(object sender, EventArgs e)
        {
            if (tbx_uname.Text.ToString().Trim() != "")
            {
                SubstationModel m = new SubstationModel(0, tbx_uname.Text.ToString(), this.uchId[cbx_Uch.SelectedIndex]);
                m.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели название подстанции.");
            };
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tbx_uname.Text.ToString().Trim() != "")
            {
                SubstationModel m = new SubstationModel(this.id, tbx_uname.Text.ToString(),this.uchId[cbx_Uch.SelectedIndex]);
                m.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели название подстанции.");
            };
        }

        private void Editor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_AddUch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }
    }
}
