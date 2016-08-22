namespace ODSJournal.Views.Common.Powers
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
            this.Tab_Powers = new System.Windows.Forms.DataGridView();
            this.PowerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Substation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Powers)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(344, 25);
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
            // Tab_Powers
            // 
            this.Tab_Powers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Powers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Powers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Powers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PowerId,
            this.Power,
            this.FiderId,
            this.Fider,
            this.Substation});
            this.Tab_Powers.Location = new System.Drawing.Point(0, 28);
            this.Tab_Powers.Name = "Tab_Powers";
            this.Tab_Powers.ReadOnly = true;
            this.Tab_Powers.Size = new System.Drawing.Size(344, 391);
            this.Tab_Powers.TabIndex = 1;
            this.Tab_Powers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Powers_RowHeaderMouseClick);
            this.Tab_Powers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Powers_RowHeaderMouseDoubleClick);
            // 
            // PowerId
            // 
            this.PowerId.HeaderText = "PowerId";
            this.PowerId.Name = "PowerId";
            this.PowerId.ReadOnly = true;
            this.PowerId.Visible = false;
            this.PowerId.Width = 71;
            // 
            // Power
            // 
            this.Power.HeaderText = "Источник питания";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            this.Power.Width = 114;
            // 
            // FiderId
            // 
            this.FiderId.HeaderText = "FiderId";
            this.FiderId.Name = "FiderId";
            this.FiderId.ReadOnly = true;
            this.FiderId.Visible = false;
            this.FiderId.Width = 64;
            // 
            // Fider
            // 
            this.Fider.HeaderText = "Фидер";
            this.Fider.Name = "Fider";
            this.Fider.ReadOnly = true;
            this.Fider.Width = 67;
            // 
            // Substation
            // 
            this.Substation.HeaderText = "Подстанция";
            this.Substation.Name = "Substation";
            this.Substation.ReadOnly = true;
            this.Substation.Width = 93;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 417);
            this.Controls.Add(this.Tab_Powers);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Viewer";
            this.Text = "Источники питания";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Powers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Del;
        private System.Windows.Forms.DataGridView Tab_Powers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Substation;
    }
}