namespace AdminTools.Views.Users
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Load = new System.Windows.Forms.ToolStripButton();
            this.Tool_ChangePassword = new System.Windows.Forms.ToolStripButton();
            this.Tool_RoleEditor = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tab_Users = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Load,
            this.Tool_Add,
            this.Tool_ChangePassword,
            this.Tool_Delete,
            this.Tool_RoleEditor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_Add
            // 
            this.Tool_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Add.Image")));
            this.Tool_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Size = new System.Drawing.Size(61, 22);
            this.Tool_Add.Text = "Добавить";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Load
            // 
            this.Tool_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Load.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Load.Image")));
            this.Tool_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Load.Name = "Tool_Load";
            this.Tool_Load.Size = new System.Drawing.Size(63, 22);
            this.Tool_Load.Text = "Загрузить";
            this.Tool_Load.Click += new System.EventHandler(this.Tool_Load_Click);
            // 
            // Tool_ChangePassword
            // 
            this.Tool_ChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("Tool_ChangePassword.Image")));
            this.Tool_ChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_ChangePassword.Name = "Tool_ChangePassword";
            this.Tool_ChangePassword.Size = new System.Drawing.Size(93, 22);
            this.Tool_ChangePassword.Text = "Сменить пароль";
            this.Tool_ChangePassword.Click += new System.EventHandler(this.Tool_ChangePassword_Click);
            // 
            // Tool_RoleEditor
            // 
            this.Tool_RoleEditor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tool_RoleEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_RoleEditor.Image = ((System.Drawing.Image)(resources.GetObject("Tool_RoleEditor.Image")));
            this.Tool_RoleEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_RoleEditor.Name = "Tool_RoleEditor";
            this.Tool_RoleEditor.Size = new System.Drawing.Size(93, 22);
            this.Tool_RoleEditor.Text = "Редактор ролей";
            this.Tool_RoleEditor.Click += new System.EventHandler(this.Tool_RoleEditor_Click);
            // 
            // Tool_Delete
            // 
            this.Tool_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Delete.Image")));
            this.Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Delete.Name = "Tool_Delete";
            this.Tool_Delete.Size = new System.Drawing.Size(55, 22);
            this.Tool_Delete.Text = "Удалить";
            this.Tool_Delete.Click += new System.EventHandler(this.Tool_Delete_Click);
            // 
            // Tab_Users
            // 
            this.Tab_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.RoleId,
            this.Login,
            this.Role,
            this.FIO});
            this.Tab_Users.Location = new System.Drawing.Point(0, 28);
            this.Tab_Users.Name = "Tab_Users";
            this.Tab_Users.ReadOnly = true;
            this.Tab_Users.Size = new System.Drawing.Size(728, 335);
            this.Tab_Users.TabIndex = 1;
            this.Tab_Users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Users_RowHeaderMouseClick);
            this.Tab_Users.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Users_RowHeaderMouseDoubleClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            this.UserId.Width = 63;
            // 
            // RoleId
            // 
            this.RoleId.HeaderText = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            this.RoleId.Visible = false;
            this.RoleId.Width = 63;
            // 
            // Login
            // 
            this.Login.HeaderText = "Имя пользователя";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 117;
            // 
            // Role
            // 
            this.Role.HeaderText = "Роль";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 57;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Ф.И.О.";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 68;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 364);
            this.Controls.Add(this.Tab_Users);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Viewer";
            this.Text = "Редактор пользователей";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_ChangePassword;
        private System.Windows.Forms.ToolStripButton Tool_Delete;
        private System.Windows.Forms.ToolStripButton Tool_RoleEditor;
        private System.Windows.Forms.DataGridView Tab_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
    }
}