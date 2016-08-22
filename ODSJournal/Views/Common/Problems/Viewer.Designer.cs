namespace ODSJournal.Views.Common.Problems
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
            this.Tab_Problems = new System.Windows.Forms.DataGridView();
            this.ProblemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Problems)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(195, 25);
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
            // Tab_Problems
            // 
            this.Tab_Problems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Problems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Problems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Problems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProblemId,
            this.Problem});
            this.Tab_Problems.Location = new System.Drawing.Point(0, 28);
            this.Tab_Problems.Name = "Tab_Problems";
            this.Tab_Problems.ReadOnly = true;
            this.Tab_Problems.Size = new System.Drawing.Size(195, 361);
            this.Tab_Problems.TabIndex = 1;
            this.Tab_Problems.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Problems_RowHeaderMouseClick);
            this.Tab_Problems.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tab_Problems_RowHeaderMouseDoubleClick);
            // 
            // ProblemId
            // 
            this.ProblemId.HeaderText = "ProblemId";
            this.ProblemId.Name = "ProblemId";
            this.ProblemId.ReadOnly = true;
            this.ProblemId.Visible = false;
            // 
            // Problem
            // 
            this.Problem.HeaderText = "Обращение";
            this.Problem.Name = "Problem";
            this.Problem.ReadOnly = true;
            this.Problem.Width = 91;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 389);
            this.Controls.Add(this.Tab_Problems);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Viewer";
            this.Text = "Обращения";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Problems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_Load;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Del;
        private System.Windows.Forms.DataGridView Tab_Problems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problem;
    }
}