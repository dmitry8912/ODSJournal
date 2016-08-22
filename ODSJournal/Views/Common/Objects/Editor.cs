using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Objects
{
    public partial class Editor : Form
    {
        protected int id;
        protected string name;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit.Visible = false;
            this.AcceptButton = btn_AddUch;
        }

        public Editor(int id, string name)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            tbx_uname.Text = name;
            btn_AddUch.Text = "Изменить";
            this.id = id;
            this.name = name;
            btn_AddUch.Visible = false;
            this.AcceptButton = btn_Edit;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).UchAddE)) { this.Close(); };
        }

        private void btn_AddUch_Click(object sender, EventArgs e)
        {
            if (tbx_uname.Text.ToString().Trim() != "")
            {
                ObjectModel m = new ObjectModel(0, tbx_uname.Text.ToString());
                m.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели название объекта!");
            };
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tbx_uname.Text.ToString().Trim() != "")
            {
                ObjectModel m = new ObjectModel(this.id, tbx_uname.Text.ToString());
                m.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели название объекта!");
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
