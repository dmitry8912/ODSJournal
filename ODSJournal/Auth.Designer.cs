namespace ODSJournal
{
    partial class Auth
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
            this.tbx_Login = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_Auth = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Layout_General = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_General.SuspendLayout();
            this.Layout_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_Login
            // 
            this.tbx_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Login.Location = new System.Drawing.Point(115, 3);
            this.tbx_Login.Name = "tbx_Login";
            this.tbx_Login.Size = new System.Drawing.Size(206, 20);
            this.tbx_Login.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_password.Location = new System.Drawing.Point(115, 29);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(206, 20);
            this.tbx_password.TabIndex = 1;
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(3, 3);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(106, 20);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Имя пользователя:";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(3, 29);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(106, 20);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Пароль:";
            // 
            // btn_Auth
            // 
            this.btn_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Auth.AutoSize = true;
            this.btn_Auth.Location = new System.Drawing.Point(3, 3);
            this.btn_Auth.Name = "btn_Auth";
            this.btn_Auth.Size = new System.Drawing.Size(63, 23);
            this.btn_Auth.TabIndex = 4;
            this.btn_Auth.Text = "Войти";
            this.btn_Auth.UseVisualStyleBackColor = true;
            this.btn_Auth.Click += new System.EventHandler(this.btn_Auth_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.AutoSize = true;
            this.btn_Clear.Location = new System.Drawing.Point(72, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(64, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Location = new System.Drawing.Point(142, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(61, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Выйти";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Layout_General
            // 
            this.Layout_General.AutoSize = true;
            this.Layout_General.ColumnCount = 2;
            this.Layout_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_General.Controls.Add(this.Layout_Buttons, 1, 2);
            this.Layout_General.Controls.Add(this.lbl_login, 0, 0);
            this.Layout_General.Controls.Add(this.tbx_Login, 1, 0);
            this.Layout_General.Controls.Add(this.lbl_password, 0, 1);
            this.Layout_General.Controls.Add(this.tbx_password, 1, 1);
            this.Layout_General.Location = new System.Drawing.Point(12, 12);
            this.Layout_General.Name = "Layout_General";
            this.Layout_General.RowCount = 3;
            this.Layout_General.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout_General.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout_General.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout_General.Size = new System.Drawing.Size(324, 87);
            this.Layout_General.TabIndex = 7;
            // 
            // Layout_Buttons
            // 
            this.Layout_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_Buttons.AutoSize = true;
            this.Layout_Buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Layout_Buttons.ColumnCount = 3;
            this.Layout_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout_Buttons.Controls.Add(this.btn_Auth, 0, 0);
            this.Layout_Buttons.Controls.Add(this.btn_Exit, 2, 0);
            this.Layout_Buttons.Controls.Add(this.btn_Clear, 1, 0);
            this.Layout_Buttons.Location = new System.Drawing.Point(115, 55);
            this.Layout_Buttons.Name = "Layout_Buttons";
            this.Layout_Buttons.RowCount = 1;
            this.Layout_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Buttons.Size = new System.Drawing.Size(206, 29);
            this.Layout_Buttons.TabIndex = 0;
            // 
            // Auth
            // 
            this.AcceptButton = this.btn_Auth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(344, 105);
            this.ControlBox = false;
            this.Controls.Add(this.Layout_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Layout_General.ResumeLayout(false);
            this.Layout_General.PerformLayout();
            this.Layout_Buttons.ResumeLayout(false);
            this.Layout_Buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_Auth;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TableLayoutPanel Layout_General;
        private System.Windows.Forms.TableLayoutPanel Layout_Buttons;
    }
}