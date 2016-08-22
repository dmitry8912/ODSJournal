using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODSJournal.DataModel.Model;
namespace ODSJournal
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

            db_ctx.db = new DataModel.ODS_db();

            Layout_General.AutoSize = true;
            Layout_Buttons.AutoSize = true;
            GlobalSettings.FontSize = 12;
            this.SetElementSize();
        }

        public void SetElementSize()
        {
            int size = GlobalSettings.FontSize;
            var controlsTbx = this.Layout_General.Controls.OfType<TextBox>();
            foreach (var a in controlsTbx)
            {
                a.Font = new Font(FontFamily.GenericSansSerif, size);
                a.AutoSize = true;
            };
            var controlsLbl = this.Layout_General.Controls.OfType<Label>();
            foreach (var a in controlsLbl)
            {
                a.Font = new Font(FontFamily.GenericSansSerif, size);
                a.AutoSize = true;
            };
            var controlsCbx = this.Layout_General.Controls.OfType<ComboBox>();
            foreach (var a in controlsCbx)
            {
                a.Font = new Font(FontFamily.GenericSansSerif, size);
                a.AutoSize = true;
            };
            var controlsCheck = this.Layout_General.Controls.OfType<CheckBox>();
            foreach (var a in controlsCheck)
            {
                a.Font = new Font(FontFamily.GenericSansSerif, size);
                a.AutoSize = true;
            };
            var controlsBtn = this.Layout_Buttons.Controls.OfType<Button>();
            foreach (var a in controlsBtn)
            {
                a.Font = new Font(FontFamily.GenericSansSerif, size);
                a.AutoSizeMode = AutoSizeMode.GrowOnly;
                a.AutoSize = true;
            };
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_Login.Clear();
            tbx_password.Clear();
        }

        private void btn_Auth_Click(object sender, EventArgs e)
        {
            UserModel m = new UserModel(tbx_Login.Text.ToString(), tbx_password.Text.ToString());
            if (m.AuthUser())
            {
                m.GlobalUser();
                Main form = new Main(this);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Повторите попытку!");
            };
        }

        public void Relogin()
        {
            this.Show();
            tbx_password.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
