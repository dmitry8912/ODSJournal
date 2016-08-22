namespace ODSJournal.Views.Common.Monters
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
            this.Tab_Addresses = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_Load = new System.Windows.Forms.ToolStripButton();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Del = new System.Windows.Forms.ToolStripButton();
            this.MonterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Addresses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Addresses
            // 
            this.Tab_Addresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Addresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Addresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Addresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonterId,
            this.Monter,
            this.Phone});
            this.Tab_Addresses.Location = new System.Drawing.Point(0, 28);
            this.Tab_Addresses.Name = "Tab_Addresses";
            this.Tab_Addresses.ReadOnly = true;
            this.Tab_Addresses.Size = new System.Drawing.Size(358, 434);
            this.Tab_Addresses.TabIndex = 0;
            this.Tab_Addresses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Addresses_RowHeaderMouseClick);
            this.Tab_Addresses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Addresses_RowHeaderMouseDoubleClick);
            this.Tab_Addresses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab_Addresses_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Load,
            this.Tool_Add,
            this.Tool_Del});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 25);
            this.toolStrip1.TabIndex = 1;
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
            // MonterId
            // 
            this.MonterId.HeaderText = "MonterId";
            this.MonterId.Name = "MonterId";
            this.MonterId.ReadOnly = true;
            this.MonterId.Visible = false;
            this.MonterId.Width = 74;
            // 
            // Monter
            // 
            this.Monter.HeaderText = "Ф.И.О.";
            this.Monter.Name = "Monter";
            this.Monter.ReadOnly = true;
            this.Monter.Width = 68;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "№ телефона";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 95;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Tab_Addresses);
            this.Name = "Viewer";
            this.ShowInTaskbar = false;
            this.Text = "Монтеры";
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Addresses)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tab_Addresses;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}