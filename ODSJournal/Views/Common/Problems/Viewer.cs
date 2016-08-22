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
    public partial class Viewer : Form
    {
        public int id;
        public Viewer()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadData();
        }

        public void LoadData()
        {
            Tab_Problems.Rows.Clear();
            ProblemsModel m = new ProblemsModel();
            var problems = m.GetProblems();
            string[] str = new string[2];
            foreach (var a in problems)
            {
                str[0] = a.ProblemId.ToString();
                str[1] = a.Problem.ToString().Trim();
                Tab_Problems.Rows.Add(str);
            }
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            Tab_Problems.Rows.Clear();
            ProblemsModel m = new ProblemsModel();
            var problems = m.GetProblems();
            string[] str = new string[2];
            foreach (var a in problems)
            {
                str[0] = a.ProblemId.ToString();
                str[1] = a.Problem.ToString().Trim();
                Tab_Problems.Rows.Add(str);
            }
        }



        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (this.id != null && !Global.CheckRole((new RoleActionAssign()).ProblemDel))
            {
                ProblemsModel m = new ProblemsModel(this.id);
                m.Delete();
            };
        }

        private void Tab_Problems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(Tab_Problems.Rows[Tab_Problems.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Problems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Tab_Problems.Rows[Tab_Problems.SelectedRows[0].Index].Cells[0].Value.ToString());
                string name = Tab_Problems.Rows[Tab_Problems.SelectedRows[0].Index].Cells[1].Value.ToString();
                Editor ed = new Editor(id, name.Trim());
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }
    }
}
