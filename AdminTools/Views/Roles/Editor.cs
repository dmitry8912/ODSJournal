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
    public partial class Editor : Form
    {
        public int RoleID;
        public Editor()
        {
            InitializeComponent();
            this.AcceptButton = btn_Add;
            btn_Edit.Visible = false;
        }

        public Editor(int RoleID,string rolename)
        {
            InitializeComponent();
            this.RoleID = RoleID;
            this.AcceptButton = btn_Edit;
            btn_Add.Visible = false;
            tbx_Role.Text = rolename;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RoleModel r = new RoleModel(0, tbx_Role.Text.ToString().Trim());
            r.AddRole();
            this.Close();
        }

        private void Editor_Load(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            RoleModel r = new RoleModel(this.RoleID, tbx_Role.Text.ToString().Trim());
            r.EditRole();
            this.Close();
        }

        private void btn_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void btn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }

        private void tbx_Role_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); };
        }


    }
}
