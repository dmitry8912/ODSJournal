namespace AdminTools.Views.Roles
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
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Load = new System.Windows.Forms.ToolStripButton();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Del = new System.Windows.Forms.ToolStripButton();
            this.Tab_Roles = new System.Windows.Forms.DataGridView();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // Tool
            // 
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Load,
            this.Tool_Add,
            this.Tool_Del});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(649, 25);
            this.Tool.TabIndex = 0;
            this.Tool.Text = "toolStrip1";
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
            // Tool_Del
            // 
            this.Tool_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Del.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Del.Image")));
            this.Tool_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Del.Name = "Tool_Del";
            this.Tool_Del.Size = new System.Drawing.Size(55, 22);
            this.Tool_Del.Text = "Удалить";
            this.Tool_Del.Click += new System.EventHandler(this.Tool_Del_Click);
            // 
            // Tab_Roles
            // 
            this.Tab_Roles.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Tab_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleId,
            this.Role});
            this.Tab_Roles.Location = new System.Drawing.Point(0, 28);
            this.Tab_Roles.Name = "Tab_Roles";
            this.Tab_Roles.Size = new System.Drawing.Size(649, 340);
            this.Tab_Roles.TabIndex = 1;
            this.Tab_Roles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Roles_RowHeaderMouseClick);
            this.Tab_Roles.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Roles_RowHeaderMouseDoubleClick);
            // 
            // RoleId
            // 
            this.RoleId.HeaderText = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.Visible = false;
            // 
            // Role
            // 
            this.Role.HeaderText = "Роль";
            this.Role.Name = "Role";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 370);
            this.Controls.Add(this.Tab_Roles);
            this.Controls.Add(this.Tool);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Del;
        private System.Windows.Forms.DataGridView Tab_Roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}