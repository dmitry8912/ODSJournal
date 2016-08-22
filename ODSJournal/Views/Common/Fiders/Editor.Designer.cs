namespace ODSJournal.Views.Common.Fiders
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
            this.Address_lbl = new System.Windows.Forms.Label();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.Uch_lbl = new System.Windows.Forms.Label();
            this.cbx_Uchs = new System.Windows.Forms.ComboBox();
            this.btn_Add_Addr = new System.Windows.Forms.Button();
            this.btn_Edit_Addr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Location = new System.Drawing.Point(12, 9);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(45, 13);
            this.Address_lbl.TabIndex = 0;
            this.Address_lbl.Text = "Фидер:";
            // 
            // tbx_Address
            // 
            this.tbx_Address.Location = new System.Drawing.Point(68, 6);
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(161, 20);
            this.tbx_Address.TabIndex = 1;
            this.tbx_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Address_KeyDown);
            // 
            // Uch_lbl
            // 
            this.Uch_lbl.AutoSize = true;
            this.Uch_lbl.Location = new System.Drawing.Point(235, 9);
            this.Uch_lbl.Name = "Uch_lbl";
            this.Uch_lbl.Size = new System.Drawing.Size(71, 13);
            this.Uch_lbl.TabIndex = 2;
            this.Uch_lbl.Text = "Подстанция:";
            // 
            // cbx_Uchs
            // 
            this.cbx_Uchs.FormattingEnabled = true;
            this.cbx_Uchs.Location = new System.Drawing.Point(312, 6);
            this.cbx_Uchs.Name = "cbx_Uchs";
            this.cbx_Uchs.Size = new System.Drawing.Size(170, 21);
            this.cbx_Uchs.TabIndex = 3;
            this.cbx_Uchs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Uchs_KeyDown);
            // 
            // btn_Add_Addr
            // 
            this.btn_Add_Addr.Location = new System.Drawing.Point(488, 5);
            this.btn_Add_Addr.Name = "btn_Add_Addr";
            this.btn_Add_Addr.Size = new System.Drawing.Size(72, 21);
            this.btn_Add_Addr.TabIndex = 4;
            this.btn_Add_Addr.Text = "Добавить";
            this.btn_Add_Addr.UseVisualStyleBackColor = true;
            this.btn_Add_Addr.Click += new System.EventHandler(this.btn_Add_Addr_Click);
            this.btn_Add_Addr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_Addr_KeyDown);
            // 
            // btn_Edit_Addr
            // 
            this.btn_Edit_Addr.Location = new System.Drawing.Point(488, 5);
            this.btn_Edit_Addr.Name = "btn_Edit_Addr";
            this.btn_Edit_Addr.Size = new System.Drawing.Size(72, 21);
            this.btn_Edit_Addr.TabIndex = 5;
            this.btn_Edit_Addr.Text = "Изменить";
            this.btn_Edit_Addr.UseVisualStyleBackColor = true;
            this.btn_Edit_Addr.Click += new System.EventHandler(this.btn_Edit_Addr_Click);
            this.btn_Edit_Addr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_Addr_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 38);
            this.Controls.Add(this.btn_Edit_Addr);
            this.Controls.Add(this.btn_Add_Addr);
            this.Controls.Add(this.cbx_Uchs);
            this.Controls.Add(this.Uch_lbl);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.Address_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Фидеры";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.Label Uch_lbl;
        private System.Windows.Forms.ComboBox cbx_Uchs;
        private System.Windows.Forms.Button btn_Add_Addr;
        private System.Windows.Forms.Button btn_Edit_Addr;
    }
}