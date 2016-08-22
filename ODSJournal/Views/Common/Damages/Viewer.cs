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
            Tab_Damages.Rows.Clear();
            DamagesModel dm = new DamagesModel();
            var dList = dm.GetDamages();
            string[] str = new string[2];
            foreach (var a in dList)
            {
                str[0] = a.DamageId.ToString();
                str[1] = a.Damage.ToString().Trim(); ;
                Tab_Damages.Rows.Add(str);
            };
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            Tab_Damages.Rows.Clear();
            DamagesModel dm = new DamagesModel();
            var dList = dm.GetDamages();
            string[] str = new string[2];
            foreach (var a in dList)
            {
                str[0] = a.DamageId.ToString();
                str[1] = a.Damage.ToString().Trim(); ;
                Tab_Damages.Rows.Add(str);
            };
        }

        private void Tab_Damages_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Tab_Damages.Rows[Tab_Damages.SelectedRows[0].Index].Cells[0].Value.ToString());
                string name = Tab_Damages.Rows[Tab_Damages.SelectedRows[0].Index].Cells[1].Value.ToString();
                Editor ed = new Editor(id, name);
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (!Global.CheckRole((new RoleActionAssign()).DamageDel))
            {
                DamagesModel dm = new DamagesModel(this.id);
                dm.Delete();
            };
        }

        private void Tab_Damages_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(Tab_Damages.Rows[Tab_Damages.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };
        }
    }
}
