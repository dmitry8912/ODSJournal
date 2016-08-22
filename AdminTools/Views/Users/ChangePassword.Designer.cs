namespace AdminTools.Views.Users
{
    partial class ChangePassword
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
            this.NewPass_lbl = new System.Windows.Forms.Label();
            this.tbx_NewPassword = new System.Windows.Forms.TextBox();
            this.tbx_PConfirm = new System.Windows.Forms.TextBox();
            this.NPconfirm_lbl = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPass_lbl
            // 
            this.NewPass_lbl.AutoSize = true;
            this.NewPass_lbl.Location = new System.Drawing.Point(12, 9);
            this.NewPass_lbl.Name = "NewPass_lbl";
            this.NewPass_lbl.Size = new System.Drawing.Size(83, 13);
            this.NewPass_lbl.TabIndex = 0;
            this.NewPass_lbl.Text = "Новый пароль:";
            // 
            // tbx_NewPassword
            // 
            this.tbx_NewPassword.Location = new System.Drawing.Point(109, 6);
            this.tbx_NewPassword.Name = "tbx_NewPassword";
            this.tbx_NewPassword.PasswordChar = '*';
            this.tbx_NewPassword.Size = new System.Drawing.Size(186, 20);
            this.tbx_NewPassword.TabIndex = 1;
            this.tbx_NewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_NewPassword_KeyDown);
            // 
            // tbx_PConfirm
            // 
            this.tbx_PConfirm.Location = new System.Drawing.Point(109, 32);
            this.tbx_PConfirm.Name = "tbx_PConfirm";
            this.tbx_PConfirm.PasswordChar = '*';
            this.tbx_PConfirm.Size = new System.Drawing.Size(186, 20);
            this.tbx_PConfirm.TabIndex = 2;
            this.tbx_PConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_PConfirm_KeyDown);
            // 
            // NPconfirm_lbl
            // 
            this.NPconfirm_lbl.AutoSize = true;
            this.NPconfirm_lbl.Location = new System.Drawing.Point(12, 35);
            this.NPconfirm_lbl.Name = "NPconfirm_lbl";
            this.NPconfirm_lbl.Size = new System.Drawing.Size(91, 13);
            this.NPconfirm_lbl.TabIndex = 3;
            this.NPconfirm_lbl.Text = "Подтверждение:";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(301, 6);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(69, 37);
            this.btn_ChangePassword.TabIndex = 4;
            this.btn_ChangePassword.Text = "Изменить пароль";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            this.btn_ChangePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_ChangePassword_KeyDown);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 62);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.NPconfirm_lbl);
            this.Controls.Add(this.tbx_PConfirm);
            this.Controls.Add(this.tbx_NewPassword);
            this.Controls.Add(this.NewPass_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.Text = "Сменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPass_lbl;
        private System.Windows.Forms.TextBox tbx_NewPassword;
        private System.Windows.Forms.TextBox tbx_PConfirm;
        private System.Windows.Forms.Label NPconfirm_lbl;
        private System.Windows.Forms.Button btn_ChangePassword;
    }
}