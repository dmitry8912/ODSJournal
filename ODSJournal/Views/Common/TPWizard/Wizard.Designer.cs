namespace ODSJournal.Views.Common.TPWizard
{
    partial class Wizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.gb_Substations = new System.Windows.Forms.GroupBox();
            this.gb_Fiders = new System.Windows.Forms.GroupBox();
            this.gb_TP = new System.Windows.Forms.GroupBox();
            this.cbx_Stations = new System.Windows.Forms.ComboBox();
            this.tbx_Station = new System.Windows.Forms.TextBox();
            this.tbx_Fider = new System.Windows.Forms.TextBox();
            this.cbx_Fiders = new System.Windows.Forms.ComboBox();
            this.tbx_TP = new System.Windows.Forms.TextBox();
            this.btn_Add_Substation = new System.Windows.Forms.Button();
            this.btn_Refresh_Substations = new System.Windows.Forms.Button();
            this.btn_AddFider = new System.Windows.Forms.Button();
            this.btn_Refresh_Fiders = new System.Windows.Forms.Button();
            this.btn_Add_TP = new System.Windows.Forms.Button();
            this.gb_Substations.SuspendLayout();
            this.gb_Fiders.SuspendLayout();
            this.gb_TP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Substations
            // 
            this.gb_Substations.Controls.Add(this.btn_Add_Substation);
            this.gb_Substations.Controls.Add(this.tbx_Station);
            this.gb_Substations.Controls.Add(this.btn_Refresh_Substations);
            this.gb_Substations.Controls.Add(this.cbx_Stations);
            this.gb_Substations.Location = new System.Drawing.Point(12, 12);
            this.gb_Substations.Name = "gb_Substations";
            this.gb_Substations.Size = new System.Drawing.Size(231, 74);
            this.gb_Substations.TabIndex = 0;
            this.gb_Substations.TabStop = false;
            this.gb_Substations.Text = "Выберите или введите Подстанцию";
            // 
            // gb_Fiders
            // 
            this.gb_Fiders.Controls.Add(this.btn_AddFider);
            this.gb_Fiders.Controls.Add(this.tbx_Fider);
            this.gb_Fiders.Controls.Add(this.btn_Refresh_Fiders);
            this.gb_Fiders.Controls.Add(this.cbx_Fiders);
            this.gb_Fiders.Location = new System.Drawing.Point(12, 92);
            this.gb_Fiders.Name = "gb_Fiders";
            this.gb_Fiders.Size = new System.Drawing.Size(231, 75);
            this.gb_Fiders.TabIndex = 1;
            this.gb_Fiders.TabStop = false;
            this.gb_Fiders.Text = "Выберите или введите Фидер";
            // 
            // gb_TP
            // 
            this.gb_TP.Controls.Add(this.btn_Add_TP);
            this.gb_TP.Controls.Add(this.tbx_TP);
            this.gb_TP.Location = new System.Drawing.Point(12, 173);
            this.gb_TP.Name = "gb_TP";
            this.gb_TP.Size = new System.Drawing.Size(231, 52);
            this.gb_TP.TabIndex = 2;
            this.gb_TP.TabStop = false;
            this.gb_TP.Text = "Введите название ТП";
            // 
            // cbx_Stations
            // 
            this.cbx_Stations.FormattingEnabled = true;
            this.cbx_Stations.Location = new System.Drawing.Point(6, 19);
            this.cbx_Stations.Name = "cbx_Stations";
            this.cbx_Stations.Size = new System.Drawing.Size(187, 21);
            this.cbx_Stations.TabIndex = 0;
            this.cbx_Stations.SelectionChangeCommitted += new System.EventHandler(this.cbx_Stations_SelectionChangeCommitted);
            // 
            // tbx_Station
            // 
            this.tbx_Station.Location = new System.Drawing.Point(6, 46);
            this.tbx_Station.Name = "tbx_Station";
            this.tbx_Station.Size = new System.Drawing.Size(187, 20);
            this.tbx_Station.TabIndex = 1;
            // 
            // tbx_Fider
            // 
            this.tbx_Fider.Location = new System.Drawing.Point(6, 46);
            this.tbx_Fider.Name = "tbx_Fider";
            this.tbx_Fider.Size = new System.Drawing.Size(187, 20);
            this.tbx_Fider.TabIndex = 4;
            // 
            // cbx_Fiders
            // 
            this.cbx_Fiders.FormattingEnabled = true;
            this.cbx_Fiders.Location = new System.Drawing.Point(6, 19);
            this.cbx_Fiders.Name = "cbx_Fiders";
            this.cbx_Fiders.Size = new System.Drawing.Size(187, 21);
            this.cbx_Fiders.TabIndex = 3;
            // 
            // tbx_TP
            // 
            this.tbx_TP.Location = new System.Drawing.Point(6, 19);
            this.tbx_TP.Name = "tbx_TP";
            this.tbx_TP.Size = new System.Drawing.Size(187, 20);
            this.tbx_TP.TabIndex = 5;
            // 
            // btn_Add_Substation
            // 
            this.btn_Add_Substation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_Substation.Image")));
            this.btn_Add_Substation.Location = new System.Drawing.Point(199, 45);
            this.btn_Add_Substation.Name = "btn_Add_Substation";
            this.btn_Add_Substation.Size = new System.Drawing.Size(21, 21);
            this.btn_Add_Substation.TabIndex = 13;
            this.btn_Add_Substation.UseVisualStyleBackColor = true;
            this.btn_Add_Substation.Click += new System.EventHandler(this.btn_Add_Substation_Click);
            // 
            // btn_Refresh_Substations
            // 
            this.btn_Refresh_Substations.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh_Substations.Image")));
            this.btn_Refresh_Substations.Location = new System.Drawing.Point(199, 18);
            this.btn_Refresh_Substations.Name = "btn_Refresh_Substations";
            this.btn_Refresh_Substations.Size = new System.Drawing.Size(21, 21);
            this.btn_Refresh_Substations.TabIndex = 12;
            this.btn_Refresh_Substations.UseVisualStyleBackColor = true;
            this.btn_Refresh_Substations.Click += new System.EventHandler(this.btn_Refresh_Substations_Click);
            // 
            // btn_AddFider
            // 
            this.btn_AddFider.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddFider.Image")));
            this.btn_AddFider.Location = new System.Drawing.Point(199, 46);
            this.btn_AddFider.Name = "btn_AddFider";
            this.btn_AddFider.Size = new System.Drawing.Size(21, 21);
            this.btn_AddFider.TabIndex = 15;
            this.btn_AddFider.UseVisualStyleBackColor = true;
            this.btn_AddFider.Click += new System.EventHandler(this.btn_AddFider_Click);
            // 
            // btn_Refresh_Fiders
            // 
            this.btn_Refresh_Fiders.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh_Fiders.Image")));
            this.btn_Refresh_Fiders.Location = new System.Drawing.Point(199, 19);
            this.btn_Refresh_Fiders.Name = "btn_Refresh_Fiders";
            this.btn_Refresh_Fiders.Size = new System.Drawing.Size(21, 21);
            this.btn_Refresh_Fiders.TabIndex = 14;
            this.btn_Refresh_Fiders.UseVisualStyleBackColor = true;
            this.btn_Refresh_Fiders.Click += new System.EventHandler(this.btn_Refresh_Fiders_Click);
            // 
            // btn_Add_TP
            // 
            this.btn_Add_TP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_TP.Image")));
            this.btn_Add_TP.Location = new System.Drawing.Point(199, 18);
            this.btn_Add_TP.Name = "btn_Add_TP";
            this.btn_Add_TP.Size = new System.Drawing.Size(21, 21);
            this.btn_Add_TP.TabIndex = 15;
            this.btn_Add_TP.UseVisualStyleBackColor = true;
            this.btn_Add_TP.Click += new System.EventHandler(this.btn_Add_TP_Click);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 239);
            this.Controls.Add(this.gb_TP);
            this.Controls.Add(this.gb_Fiders);
            this.Controls.Add(this.gb_Substations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Wizard";
            this.Text = "Добавить ТП";
            this.gb_Substations.ResumeLayout(false);
            this.gb_Substations.PerformLayout();
            this.gb_Fiders.ResumeLayout(false);
            this.gb_Fiders.PerformLayout();
            this.gb_TP.ResumeLayout(false);
            this.gb_TP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Substations;
        private System.Windows.Forms.TextBox tbx_Station;
        private System.Windows.Forms.ComboBox cbx_Stations;
        private System.Windows.Forms.GroupBox gb_Fiders;
        private System.Windows.Forms.TextBox tbx_Fider;
        private System.Windows.Forms.ComboBox cbx_Fiders;
        private System.Windows.Forms.GroupBox gb_TP;
        private System.Windows.Forms.TextBox tbx_TP;
        private System.Windows.Forms.Button btn_Add_Substation;
        private System.Windows.Forms.Button btn_Refresh_Substations;
        private System.Windows.Forms.Button btn_AddFider;
        private System.Windows.Forms.Button btn_Refresh_Fiders;
        private System.Windows.Forms.Button btn_Add_TP;
    }
}