namespace ODSJournal.Views.Common.Address
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
            this.AddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_Load = new System.Windows.Forms.ToolStripButton();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Del = new System.Windows.Forms.ToolStripButton();
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
            this.AddressId,
            this.Address,
            this.UchId,
            this.UchName});
            this.Tab_Addresses.Location = new System.Drawing.Point(0, 31);
            this.Tab_Addresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Addresses.Name = "Tab_Addresses";
            this.Tab_Addresses.ReadOnly = true;
            this.Tab_Addresses.Size = new System.Drawing.Size(374, 671);
            this.Tab_Addresses.TabIndex = 0;
            this.Tab_Addresses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Addresses_RowHeaderMouseClick);
            this.Tab_Addresses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Addresses_RowHeaderMouseDoubleClick);
            this.Tab_Addresses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tab_Addresses_KeyDown);
            // 
            // AddressId
            // 
            this.AddressId.HeaderText = "AddressId";
            this.AddressId.Name = "AddressId";
            this.AddressId.ReadOnly = true;
            this.AddressId.Visible = false;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 82;
            // 
            // UchId
            // 
            this.UchId.HeaderText = "UchId";
            this.UchId.Name = "UchId";
            this.UchId.ReadOnly = true;
            this.UchId.Visible = false;
            // 
            // UchName
            // 
            this.UchName.HeaderText = "Участок";
            this.UchName.Name = "UchName";
            this.UchName.ReadOnly = true;
            this.UchName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UchName.Width = 96;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Load,
            this.Tool_Add,
            this.Tool_Del});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(374, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_Load
            // 
            this.Tool_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Load.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Load.Image")));
            this.Tool_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Load.Name = "Tool_Load";
            this.Tool_Load.Size = new System.Drawing.Size(86, 23);
            this.Tool_Load.Text = "Загрузить";
            this.Tool_Load.Click += new System.EventHandler(this.Tool_Load_Click);
            // 
            // Tool_Add
            // 
            this.Tool_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Add.Image")));
            this.Tool_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Size = new System.Drawing.Size(83, 23);
            this.Tool_Add.Text = "Добавить";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Del
            // 
            this.Tool_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tool_Del.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Del.Image")));
            this.Tool_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Del.Name = "Tool_Del";
            this.Tool_Del.Size = new System.Drawing.Size(73, 23);
            this.Tool_Del.Text = "Удалить";
            this.Tool_Del.Click += new System.EventHandler(this.Tool_Del_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 718);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Tab_Addresses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Viewer";
            this.ShowInTaskbar = false;
            this.Text = "Адреса";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn UchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UchName;
    }
}