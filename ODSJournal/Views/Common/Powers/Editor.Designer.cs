namespace ODSJournal.Views.Common.Powers
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.btn_Add_TP = new System.Windows.Forms.Button();
            this.TP_lbl = new System.Windows.Forms.Label();
            this.tbx_TP = new System.Windows.Forms.TextBox();
            this.btn_Edit_TP = new System.Windows.Forms.Button();
            this.Fider_lbl = new System.Windows.Forms.Label();
            this.cbx_Fiders = new System.Windows.Forms.ComboBox();
            this.btn_Refresh_Fiders = new System.Windows.Forms.Button();
            this.btn_RefreshSubstations = new System.Windows.Forms.Button();
            this.cbx_Substations = new System.Windows.Forms.ComboBox();
            this.Substations_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add_TP
            // 
            this.btn_Add_TP.Location = new System.Drawing.Point(295, 2);
            this.btn_Add_TP.Name = "btn_Add_TP";
            this.btn_Add_TP.Size = new System.Drawing.Size(82, 20);
            this.btn_Add_TP.TabIndex = 2;
            this.btn_Add_TP.Text = "Добавить";
            this.btn_Add_TP.UseVisualStyleBackColor = true;
            this.btn_Add_TP.Click += new System.EventHandler(this.btn_Add_TP_Click);
            this.btn_Add_TP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_TP_KeyDown);
            // 
            // TP_lbl
            // 
            this.TP_lbl.AutoSize = true;
            this.TP_lbl.Location = new System.Drawing.Point(12, 9);
            this.TP_lbl.Name = "TP_lbl";
            this.TP_lbl.Size = new System.Drawing.Size(102, 13);
            this.TP_lbl.TabIndex = 0;
            this.TP_lbl.Text = "Источник питания:";
            // 
            // tbx_TP
            // 
            this.tbx_TP.Location = new System.Drawing.Point(120, 2);
            this.tbx_TP.Name = "tbx_TP";
            this.tbx_TP.Size = new System.Drawing.Size(169, 20);
            this.tbx_TP.TabIndex = 1;
            this.tbx_TP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_TP_KeyDown);
            // 
            // btn_Edit_TP
            // 
            this.btn_Edit_TP.Location = new System.Drawing.Point(295, 2);
            this.btn_Edit_TP.Name = "btn_Edit_TP";
            this.btn_Edit_TP.Size = new System.Drawing.Size(82, 20);
            this.btn_Edit_TP.TabIndex = 3;
            this.btn_Edit_TP.Text = "Изменить";
            this.btn_Edit_TP.UseVisualStyleBackColor = true;
            this.btn_Edit_TP.Click += new System.EventHandler(this.btn_Edit_TP_Click);
            this.btn_Edit_TP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_TP_KeyDown);
            // 
            // Fider_lbl
            // 
            this.Fider_lbl.AutoSize = true;
            this.Fider_lbl.Location = new System.Drawing.Point(12, 31);
            this.Fider_lbl.Name = "Fider_lbl";
            this.Fider_lbl.Size = new System.Drawing.Size(45, 13);
            this.Fider_lbl.TabIndex = 4;
            this.Fider_lbl.Text = "Фидер:";
            // 
            // cbx_Fiders
            // 
            this.cbx_Fiders.FormattingEnabled = true;
            this.cbx_Fiders.Location = new System.Drawing.Point(120, 28);
            this.cbx_Fiders.Name = "cbx_Fiders";
            this.cbx_Fiders.Size = new System.Drawing.Size(169, 21);
            this.cbx_Fiders.TabIndex = 5;
            // 
            // btn_Refresh_Fiders
            // 
            this.btn_Refresh_Fiders.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh_Fiders.Image")));
            this.btn_Refresh_Fiders.Location = new System.Drawing.Point(295, 28);
            this.btn_Refresh_Fiders.Name = "btn_Refresh_Fiders";
            this.btn_Refresh_Fiders.Size = new System.Drawing.Size(21, 21);
            this.btn_Refresh_Fiders.TabIndex = 11;
            this.btn_Refresh_Fiders.UseVisualStyleBackColor = true;
            this.btn_Refresh_Fiders.Click += new System.EventHandler(this.btn_Refresh_Fiders_Click);
            // 
            // btn_RefreshSubstations
            // 
            this.btn_RefreshSubstations.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshSubstations.Image")));
            this.btn_RefreshSubstations.Location = new System.Drawing.Point(295, 55);
            this.btn_RefreshSubstations.Name = "btn_RefreshSubstations";
            this.btn_RefreshSubstations.Size = new System.Drawing.Size(21, 21);
            this.btn_RefreshSubstations.TabIndex = 14;
            this.btn_RefreshSubstations.UseVisualStyleBackColor = true;
            this.btn_RefreshSubstations.Click += new System.EventHandler(this.btn_RefreshSubstations_Click);
            // 
            // cbx_Substations
            // 
            this.cbx_Substations.FormattingEnabled = true;
            this.cbx_Substations.Location = new System.Drawing.Point(120, 55);
            this.cbx_Substations.Name = "cbx_Substations";
            this.cbx_Substations.Size = new System.Drawing.Size(169, 21);
            this.cbx_Substations.TabIndex = 13;
            this.cbx_Substations.SelectionChangeCommitted += new System.EventHandler(this.cbx_Substations_SelectionChangeCommitted);
            // 
            // Substations_lbl
            // 
            this.Substations_lbl.AutoSize = true;
            this.Substations_lbl.Location = new System.Drawing.Point(12, 58);
            this.Substations_lbl.Name = "Substations_lbl";
            this.Substations_lbl.Size = new System.Drawing.Size(71, 13);
            this.Substations_lbl.TabIndex = 12;
            this.Substations_lbl.Text = "Подстанция:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 83);
            this.Controls.Add(this.btn_RefreshSubstations);
            this.Controls.Add(this.cbx_Substations);
            this.Controls.Add(this.Substations_lbl);
            this.Controls.Add(this.btn_Refresh_Fiders);
            this.Controls.Add(this.cbx_Fiders);
            this.Controls.Add(this.Fider_lbl);
            this.Controls.Add(this.btn_Edit_TP);
            this.Controls.Add(this.btn_Add_TP);
            this.Controls.Add(this.tbx_TP);
            this.Controls.Add(this.TP_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Источники питания";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_TP;
        private System.Windows.Forms.Label TP_lbl;
        private System.Windows.Forms.TextBox tbx_TP;
        private System.Windows.Forms.Button btn_Edit_TP;
        private System.Windows.Forms.Label Fider_lbl;
        private System.Windows.Forms.ComboBox cbx_Fiders;
        private System.Windows.Forms.Button btn_Refresh_Fiders;
        private System.Windows.Forms.Button btn_RefreshSubstations;
        private System.Windows.Forms.ComboBox cbx_Substations;
        private System.Windows.Forms.Label Substations_lbl;
    }
}