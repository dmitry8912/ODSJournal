using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminTools.DataModel.Model;
namespace AdminTools.Views.Roles
{
    public partial class Viewer : Form
    {
        public int RoleIds;
        public Viewer()
        {
            InitializeComponent();
        }

        private void Tab_Roles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.RoleIds = Convert.ToInt32(Tab_Roles.Rows[Tab_Roles.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

            };
        }

        private void Tab_Roles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.RoleIds = Convert.ToInt32(Tab_Roles.Rows[Tab_Roles.SelectedRows[0].Index].Cells[0].Value.ToString());
                Editor ed = new Editor(this.RoleIds, Tab_Roles.Rows[Tab_Roles.SelectedRows[0].Index].Cells[1].Value.ToString());
                ed.Show();
            }
            catch (Exception ex)
            {

            };
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            Tab_Roles.Rows.Clear();
            RoleModel r = new RoleModel();
            var roles = r.GetRoles();
            string[] str = new string[2];
            foreach (var role in roles)
            {
                str = new string[2];
                str[0] = role.RoleId.ToString();
                str[1] = role.Role.ToString().Trim();
                Tab_Roles.Rows.Add(str);
            };
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_Del_Click(object sender, EventArgs e)
        {
            RoleModel r = new RoleModel(this.RoleIds);
            r.DeleteRole();
        }

    }
}
