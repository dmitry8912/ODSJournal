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
    public partial class Editor : Form
    {
        private int UserId;
        private int[] RoleIds;
        public Editor()
        {
            InitializeComponent();
            btn_Edit.Visible = false;
            this.AcceptButton = btn_Add;
            this.RefreshRoles();
        }

        public Editor(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            UserModel m = new UserModel(this.UserId);
            var user = m.GetUserById();
            tbx_Login.Text = user.Login.ToString().Trim();
            tbx_Password.Enabled = false;
            tbx_FIO.Text = user.FIO.ToString().Trim();
            btn_Add.Visible = false;
            this.AcceptButton = btn_Edit;
            this.RefreshRoles();
            cbx_Roles.SelectedIndex = this.RoleIds.ToList().IndexOf(user.RoleId);
        }

        public void RefreshRoles()
        {
            RoleModel r = new RoleModel();
            var roles = r.GetRoles();
            this.RoleIds = new int[roles.Count()];
            foreach (var a in roles)
            {
                cbx_Roles.Items.Add(a.Role);
                this.RoleIds[cbx_Roles.Items.Count - 1] = a.RoleId;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UserModel m = new UserModel(tbx_Login.Text.ToString(), tbx_Password.Text.ToString(), tbx_FIO.Text.ToString(), this.RoleIds[cbx_Roles.SelectedIndex]);
            m.AddNewUser();
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UserModel m = new UserModel(this.UserId, tbx_Login.Text.ToString().Trim(), tbx_FIO.Text.ToString().Trim(), this.RoleIds[cbx_Roles.SelectedIndex]);
            m.ModifyUserData();
            this.Close();
        }

        private void tbx_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_FIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void cbx_Roles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }
    }
}
