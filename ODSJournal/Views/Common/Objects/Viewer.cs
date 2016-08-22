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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadData();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            Tab_Uchs.Rows.Clear();
            ObjectModel m = new ObjectModel();
            var uchs = m.GetObjects();
            foreach (var element in uchs)
            {
                string[] el = new string[2];
                el[0] = element.ObjectId.ToString();
                el[1] = element.Object.Trim();
                Tab_Uchs.Rows.Add(el);
            }
        }

        private void Tool_LoadBtn_Click(object sender, EventArgs e)
        {
            Tab_Uchs.Rows.Clear();
            ObjectModel m = new ObjectModel();
            var uchs = m.GetObjects();
            foreach (var element in uchs)
            {
                string[] el = new string[2];
                el[0] = element.ObjectId.ToString();
                el[1] = element.Object.Trim();
                Tab_Uchs.Rows.Add(el);
            }
        }

        private void Tool_AddBtn_Click(object sender, EventArgs e)
        {
            Editor a = new Editor();
            a.Show();
        }

        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            if (Global.CheckRole((new RoleActionAssign()).UchDel))
            {
                return;
            };

            try
            {
                int id = Convert.ToInt32(Tab_Uchs.Rows[Tab_Uchs.SelectedRows[0].Index].Cells[0].Value.ToString());
                ObjectModel m = new ObjectModel(id);
                m.Delete();
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Uchs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Tab_Uchs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Tab_Uchs.Rows[Tab_Uchs.SelectedRows[0].Index].Cells[0].Value.ToString());
                string name = Tab_Uchs.Rows[Tab_Uchs.SelectedRows[0].Index].Cells[1].Value.ToString();
                Editor ed = new Editor(id, name);
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void Tab_Uchs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }
    }
}
