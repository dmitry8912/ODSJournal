using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdminTools.DataModel.Model;
namespace AdminTools.Views.Users
{
    public partial class Viewer : Form
    {
        private int UserIdS;
        public Viewer()
        {
            InitializeComponent();
        }

        public void Load_Users()
        {
            UserModel m = new UserModel(0);
            var users = m.GetUsers();
            Tab_Users.Rows.Clear();
            string[] str = new string[5];
            foreach (var a in users)
            {
                str[0] = a.UserId.ToString();
                str[1] = a.RoleId.ToString();
                str[2] = a.Login.ToString().Trim();
                str[3] = a.ODS_Roles.Role.ToString().Trim();
                str[4] = a.FIO.ToString().Trim();
                Tab_Users.Rows.Add(str);
            };
        }

        private void Tool_Load_Click(object sender, EventArgs e)
        {
            this.Load_Users();
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor();
            ed.Show();
        }

        private void Tool_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword ChP = new ChangePassword(this.UserIdS);
            ChP.Show();
        }

        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            UserModel m = new UserModel(this.UserIdS);
            m.DeleteUser();
        }

        private void Tool_RoleEditor_Click(object sender, EventArgs e)
        {
            Views.Roles.Viewer v = new Roles.Viewer();
            v.Show();
        }

        private void Tab_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.UserIdS = Convert.ToInt32(Tab_Users.Rows[Tab_Users.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

            };
        }

        private void Tab_Users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.UserIdS = Convert.ToInt32(Tab_Users.Rows[Tab_Users.SelectedRows[0].Index].Cells[0].Value.ToString());
                Editor ed = new Editor(this.UserIdS);
                ed.Show();
            }
            catch (Exception ex)
            {

            };
        }
    }
}
