using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal.Views.Common.Powers
{
    public partial class Viewer : Form
    {
        protected int id;
        public Viewer()
        {
            InitializeComponent();
            this.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            toolStrip1.Font = new Font(FontFamily.GenericSansSerif, GlobalSettings.FontSize);
            this.LoadData();
        }

        public void LoadData()
        {
            Tab_Powers.Rows.Clear();
            PowersModel m = new PowersModel();
            var tps = m.GetPowers();
            string[] str = new string[5];
            foreach (var a in tps)
            {
                str[0] = a.PowerId.ToString();
                str[1] = a.Power.ToString().Trim();
                str[2] = a.FiderId.ToString();
                str[3] = a.ODS_Fidres.FiderName.ToString().Trim();
                str[4] = a.ODS_Fidres.ODS_Substations.SubstationName.ToString().Trim();
                Tab_Powers.Rows.Add(str);
            };
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            //Editor ed = new Editor();
            Views.Common.TPWizard.Wizard ed = new TPWizard.Wizard();
            ed.Show(); 
        }

        private void Tab_Powers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(Tab_Powers.Rows[Tab_Powers.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tab_Powers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Tab_Powers.Rows[Tab_Powers.SelectedRows[0].Index].Cells[0].Value.ToString());
                string name = Tab_Powers.Rows[Tab_Powers.SelectedRows[0].Index].Cells[1].Value.ToString();
                int fid = Convert.ToInt32(Tab_Powers.Rows[Tab_Powers.SelectedRows[0].Index].Cells[2].Value.ToString());
                Editor ed = new Editor(id, name.Trim(), fid);
                ed.Show();
            }
            catch (Exception ex)
            {
                return;
            };
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            if (!Global.CheckRole((new RoleActionAssign()).PowerDel))
            {
                PowersModel m = new PowersModel(this.id);
                m.Delete();
            };
        }
    }
}
