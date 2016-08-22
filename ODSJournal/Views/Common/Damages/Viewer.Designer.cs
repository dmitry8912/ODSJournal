namespace ODSJournal.Views.Common.Damages
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
            this.Tool_Load = new System.Windows.Forms.ToolStripButton();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Del = new System.Windows.Forms.ToolStripButton();
            this.Tab_Damages = new System.Windows.Forms.DataGridView();
            this.DamageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Damage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Damages)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Load,
            this.Tool_Add,
            this.Tool_Del});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(203, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // Tab_Damages
            // 
            this.Tab_Damages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Damages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Damages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Damages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DamageId,
            this.Damage});
            this.Tab_Damages.Location = new System.Drawing.Point(0, 28);
            this.Tab_Damages.Name = "Tab_Damages";
            this.Tab_Damages.ReadOnly = true;
            this.Tab_Damages.Size = new System.Drawing.Size(203, 393);
            this.Tab_Damages.TabIndex = 1;
            this.Tab_Damages.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Damages_RowHeaderMouseClick);
            this.Tab_Damages.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Damages_RowHeaderMouseDoubleClick);
            // 
            // DamageId
            // 
            this.DamageId.HeaderText = "Damage";
            this.DamageId.Name = "DamageId";
            this.DamageId.ReadOnly = true;
            this.DamageId.Visible = false;
            // 
            // Damage
            // 
            this.Damage.HeaderText = "Повреждения";
            this.Damage.Name = "Damage";
            this.Damage.ReadOnly = true;
            this.Damage.Width = 102;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(203, 421);
            this.Controls.Add(this.Tab_Damages);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Viewer";
            this.Text = "Повреждения";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Damages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.DataGridView Tab_Damages;
        private System.Windows.Forms.ToolStripButton Tool_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn DamageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Damage;
    }
}