namespace AdminTools.Views.Users
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.tbx_Login = new System.Windows.Forms.TextBox();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.FIO_lbl = new System.Windows.Forms.Label();
            this.tbx_FIO = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Roles = new System.Windows.Forms.ComboBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.Location = new System.Drawing.Point(5, 9);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(41, 13);
            this.Login_lbl.TabIndex = 0;
            this.Login_lbl.Text = "Логин:";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(5, 35);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(48, 13);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "Пароль:";
            // 
            // tbx_Login
            // 
            this.tbx_Login.Location = new System.Drawing.Point(59, 6);
            this.tbx_Login.Name = "tbx_Login";
            this.tbx_Login.Size = new System.Drawing.Size(172, 20);
            this.tbx_Login.TabIndex = 2;
            this.tbx_Login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Login_KeyDown);
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(59, 32);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.PasswordChar = '*';
            this.tbx_Password.Size = new System.Drawing.Size(172, 20);
            this.tbx_Password.TabIndex = 3;
            this.tbx_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Password_KeyDown);
            // 
            // FIO_lbl
            // 
            this.FIO_lbl.AutoSize = true;
            this.FIO_lbl.Location = new System.Drawing.Point(5, 61);
            this.FIO_lbl.Name = "FIO_lbl";
            this.FIO_lbl.Size = new System.Drawing.Size(46, 13);
            this.FIO_lbl.TabIndex = 4;
            this.FIO_lbl.Text = "Ф.И.О.:";
            // 
            // tbx_FIO
            // 
            this.tbx_FIO.Location = new System.Drawing.Point(59, 58);
            this.tbx_FIO.Name = "tbx_FIO";
            this.tbx_FIO.Size = new System.Drawing.Size(172, 20);
            this.tbx_FIO.TabIndex = 5;
            this.tbx_FIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_FIO_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Add.Location = new System.Drawing.Point(237, 6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 20);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Роль:";
            // 
            // cbx_Roles
            // 
            this.cbx_Roles.FormattingEnabled = true;
            this.cbx_Roles.Location = new System.Drawing.Point(59, 84);
            this.cbx_Roles.Name = "cbx_Roles";
            this.cbx_Roles.Size = new System.Drawing.Size(172, 21);
            this.cbx_Roles.TabIndex = 8;
            this.cbx_Roles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Roles_KeyDown);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Location = new System.Drawing.Point(237, 6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(66, 20);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 116);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.cbx_Roles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_FIO);
            this.Controls.Add(this.FIO_lbl);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_Login);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Login_lbl);
            this.Name = "Editor";
            this.Text = "Редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox tbx_Login;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label FIO_lbl;
        private System.Windows.Forms.TextBox tbx_FIO;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Roles;
        private System.Windows.Forms.Button btn_Edit;
    }
}