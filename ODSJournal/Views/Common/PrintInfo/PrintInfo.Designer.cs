namespace ODSJournal.Views.Common.PrintInfo
{
    partial class PrintInfo
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
            this.Tab_Print = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Print
            // 
            this.Tab_Print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tab_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Print.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.User});
            this.Tab_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Print.Location = new System.Drawing.Point(0, 0);
            this.Tab_Print.Name = "Tab_Print";
            this.Tab_Print.Size = new System.Drawing.Size(292, 273);
            this.Tab_Print.TabIndex = 0;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Дата и время";
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 94;
            // 
            // User
            // 
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            this.User.Width = 105;
            // 
            // PrintInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Tab_Print);
            this.Name = "PrintInfo";
            this.Text = "Информация о печати заявки";
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridView Tab_Print;
    }
}