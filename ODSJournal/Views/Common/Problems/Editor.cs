using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Problems
{
    public partial class Editor : Form
    {
        public int id;
        public Editor()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Edit_Problem.Visible = false;
            this.AcceptButton = btn_Add_Problem;
        }

        public Editor(int id, string name)
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            btn_Add_Problem.Visible = false;
            this.AcceptButton = btn_Edit_Problem;
            this.id = id;
            tbx_Problem.Text = name.Trim();
        }

        private void btn_Edit_Problem_Click(object sender, EventArgs e)
        {
            if (tbx_Problem.Text.ToString().Trim() != "")
            {
                ProblemsModel m = new ProblemsModel(this.id, tbx_Problem.Text.ToString().Trim());
                m.Change();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не заполнены необходимые поля!");
            };
        }

        private void btn_Add_Problem_Click(object sender, EventArgs e)
        {
            if (tbx_Problem.Text.ToString().Trim() != "")
            {
                ProblemsModel m = new ProblemsModel(0, tbx_Problem.Text.ToString().Trim());
                m.Add();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не заполнены необходимые поля!");
            };
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Problem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Edit_Problem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_Problem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).ProblemAddE)) { this.Close(); };
        }
    }
}
