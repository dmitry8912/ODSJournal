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
    public partial class ChangePassword : Form
    {
        private int UserId;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
        }

        private void tbx_NewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_PConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (tbx_NewPassword.Text.ToString().Trim() == tbx_PConfirm.Text.ToString().Trim())
            {
                UserModel m = new UserModel("",tbx_NewPassword.Text.ToString().Trim(),this.UserId);
                m.ChangeUserPassword();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            };
        }
    }
}
