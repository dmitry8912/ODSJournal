using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Damages
{
    public partial class Editor : Form
    {
        public int id;
        public string name;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_Dmg.Visible = false;
            this.AcceptButton = btn_Add_Dmg;
        }

        public Editor(int id, string name)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Add_Dmg.Visible = false;
            this.AcceptButton = btn_Edit_Dmg;
            this.id = id;
            this.name = name;
            tbx_Damage.Text = name.Trim();
        }

        private void btn_Add_Dmg_Click(object sender, EventArgs e)
        {
            if (tbx_Damage.Text.ToString().Trim() != "")
            {
                DamagesModel dm = new DamagesModel(0, tbx_Damage.Text.ToString().Trim());
                dm.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели повреждение!");
            };
        }

        private void btn_Edit_Dmg_Click(object sender, EventArgs e)
        {
            if (tbx_Damage.Text.ToString().Trim() != "")
            {
                DamagesModel dm = new DamagesModel(this.id, tbx_Damage.Text.ToString().Trim());
                dm.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели повреждение!");
            };
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Damage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Edit_Dmg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).DamageAddE)) { this.Close(); };
        }

    }
}
