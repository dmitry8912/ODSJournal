namespace ODSJournal.Views.Common.Substations
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
            this.Tab_Stations = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_LoadBtn = new System.Windows.Forms.ToolStripButton();
            this.Tool_AddBtn = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Stations)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Stations
            // 
            this.Tab_Stations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Stations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Stations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tab_Stations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Stations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SId,
            this.Subs,
            this.Uch});
            this.Tab_Stations.Location = new System.Drawing.Point(0, 28);
            this.Tab_Stations.MultiSelect = false;
            this.Tab_Stations.Name = "Tab_Stations";
            this.Tab_Stations.ReadOnly = true;
            this.Tab_Stations.Size = new System.Drawing.Size(239, 318);
            this.Tab_Stations.TabIndex = 0;
            this.Tab_Stations.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Stations_RowHeaderMouseClick);
            this.Tab_Stations.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Stations_RowHeaderMouseDoubleClick);
            this.Tab_Stations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab_Stations_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_LoadBtn,
            this.Tool_AddBtn,
            this.Tool_Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(240, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_LoadBtn
            // 
            this.Tool_LoadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_LoadBtn.Image = ((System.Drawing.Image)(resources.GetObject("Tool_LoadBtn.Image")));
            this.Tool_LoadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_LoadBtn.Name = "Tool_LoadBtn";
            this.Tool_LoadBtn.Size = new System.Drawing.Size(63, 22);
            this.Tool_LoadBtn.Text = "Загрузить";
            this.Tool_LoadBtn.Click += new System.EventHandler(this.Tool_LoadBtn_Click);
            // 
            // Tool_AddBtn
            // 
            this.Tool_AddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("Tool_AddBtn.Image")));
            this.Tool_AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_AddBtn.Name = "Tool_AddBtn";
            this.Tool_AddBtn.Size = new System.Drawing.Size(61, 22);
            this.Tool_AddBtn.Text = "Добавить";
            this.Tool_AddBtn.Click += new System.EventHandler(this.Tool_AddBtn_Click);
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
            // SId
            // 
            this.SId.HeaderText = "UchId";
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            this.SId.Visible = false;
            this.SId.Width = 61;
            // 
            // Subs
            // 
            this.Subs.HeaderText = "Подстанция";
            this.Subs.Name = "Subs";
            this.Subs.ReadOnly = true;
            this.Subs.Width = 93;
            // 
            // Uch
            // 
            this.Uch.HeaderText = "Участок";
            this.Uch.Name = "Uch";
            this.Uch.ReadOnly = true;
            this.Uch.Width = 74;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 347);
            this.Controls.Add(this.Tab_Stations);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Viewer";
            this.ShowInTaskbar = false;
            this.Text = "Подстанции";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Stations)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tab_Stations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_LoadBtn;
        private System.Windows.Forms.ToolStripButton Tool_AddBtn;
        private System.Windows.Forms.ToolStripButton Tool_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uch;
    }
}