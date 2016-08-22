namespace ODSJournal.Views.Common.Monters
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
            this.tbx_FIO = new System.Windows.Forms.TextBox();
            this.btn_Add_Addr = new System.Windows.Forms.Button();
            this.btn_Edit_Addr = new System.Windows.Forms.Button();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.Object_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Location = new System.Drawing.Point(12, 9);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(46, 13);
            this.Address_lbl.TabIndex = 0;
            this.Address_lbl.Text = "Ф.И.О.:";
            // 
            // tbx_FIO
            // 
            this.tbx_FIO.Location = new System.Drawing.Point(68, 6);
            this.tbx_FIO.Name = "tbx_FIO";
            this.tbx_FIO.Size = new System.Drawing.Size(161, 20);
            this.tbx_FIO.TabIndex = 1;
            this.tbx_FIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Address_KeyDown);
            // 
            // btn_Add_Addr
            // 
            this.btn_Add_Addr.Location = new System.Drawing.Point(469, 6);
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
            this.btn_Edit_Addr.Location = new System.Drawing.Point(469, 6);
            this.btn_Edit_Addr.Name = "btn_Edit_Addr";
            this.btn_Edit_Addr.Size = new System.Drawing.Size(72, 21);
            this.btn_Edit_Addr.TabIndex = 5;
            this.btn_Edit_Addr.Text = "Изменить";
            this.btn_Edit_Addr.UseVisualStyleBackColor = true;
            this.btn_Edit_Addr.Click += new System.EventHandler(this.btn_Edit_Addr_Click);
            this.btn_Edit_Addr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_Addr_KeyDown);
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(293, 7);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(170, 20);
            this.tbx_Phone.TabIndex = 10;
            // 
            // Object_lbl
            // 
            this.Object_lbl.AutoSize = true;
            this.Object_lbl.Location = new System.Drawing.Point(232, 10);
            this.Object_lbl.Name = "Object_lbl";
            this.Object_lbl.Size = new System.Drawing.Size(55, 13);
            this.Object_lbl.TabIndex = 9;
            this.Object_lbl.Text = "Телефон:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 35);
            this.Controls.Add(this.tbx_Phone);
            this.Controls.Add(this.Object_lbl);
            this.Controls.Add(this.btn_Edit_Addr);
            this.Controls.Add(this.btn_Add_Addr);
            this.Controls.Add(this.tbx_FIO);
            this.Controls.Add(this.Address_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Монтер";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.TextBox tbx_FIO;
        private System.Windows.Forms.Button btn_Add_Addr;
        private System.Windows.Forms.Button btn_Edit_Addr;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.Label Object_lbl;
    }
}