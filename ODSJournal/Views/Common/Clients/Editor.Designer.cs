namespace ODSJournal.Views.Common.Clients
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
            this.FIO_lbl = new System.Windows.Forms.Label();
            this.tbx_FIO = new System.Windows.Forms.TextBox();
            this.CPhone_lbl = new System.Windows.Forms.Label();
            this.tbx_CPhone = new System.Windows.Forms.TextBox();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.HNum_lbl = new System.Windows.Forms.Label();
            this.Liter_lbl = new System.Windows.Forms.Label();
            this.Entrance_lbl = new System.Windows.Forms.Label();
            this.Room_lbl = new System.Windows.Forms.Label();
            this.cbx_Address = new System.Windows.Forms.ComboBox();
            this.num_HNum = new System.Windows.Forms.NumericUpDown();
            this.num_EntrNum = new System.Windows.Forms.NumericUpDown();
            this.num_RoomNum = new System.Windows.Forms.NumericUpDown();
            this.tbx_Liter = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddNewAddr = new System.Windows.Forms.Button();
            this.btn_Addr_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_HNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EntrNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomNum)).BeginInit();
            this.SuspendLayout();
            // 
            // FIO_lbl
            // 
            this.FIO_lbl.AutoSize = true;
            this.FIO_lbl.Location = new System.Drawing.Point(12, 9);
            this.FIO_lbl.Name = "FIO_lbl";
            this.FIO_lbl.Size = new System.Drawing.Size(43, 13);
            this.FIO_lbl.TabIndex = 0;
            this.FIO_lbl.Text = "Ф.И.О.";
            // 
            // tbx_FIO
            // 
            this.tbx_FIO.Location = new System.Drawing.Point(91, 6);
            this.tbx_FIO.Name = "tbx_FIO";
            this.tbx_FIO.Size = new System.Drawing.Size(289, 20);
            this.tbx_FIO.TabIndex = 1;
            this.tbx_FIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_FIO_KeyDown);
            // 
            // CPhone_lbl
            // 
            this.CPhone_lbl.AutoSize = true;
            this.CPhone_lbl.Location = new System.Drawing.Point(12, 35);
            this.CPhone_lbl.Name = "CPhone_lbl";
            this.CPhone_lbl.Size = new System.Drawing.Size(73, 13);
            this.CPhone_lbl.TabIndex = 2;
            this.CPhone_lbl.Text = "№ телефона:";
            // 
            // tbx_CPhone
            // 
            this.tbx_CPhone.Location = new System.Drawing.Point(91, 32);
            this.tbx_CPhone.Name = "tbx_CPhone";
            this.tbx_CPhone.Size = new System.Drawing.Size(289, 20);
            this.tbx_CPhone.TabIndex = 3;
            this.tbx_CPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_CPhone_KeyDown);
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Location = new System.Drawing.Point(12, 61);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(41, 13);
            this.Address_lbl.TabIndex = 4;
            this.Address_lbl.Text = "Адрес:";
            // 
            // HNum_lbl
            // 
            this.HNum_lbl.AutoSize = true;
            this.HNum_lbl.Location = new System.Drawing.Point(12, 87);
            this.HNum_lbl.Name = "HNum_lbl";
            this.HNum_lbl.Size = new System.Drawing.Size(50, 13);
            this.HNum_lbl.TabIndex = 5;
            this.HNum_lbl.Text = "№ дома:";
            // 
            // Liter_lbl
            // 
            this.Liter_lbl.AutoSize = true;
            this.Liter_lbl.Location = new System.Drawing.Point(12, 114);
            this.Liter_lbl.Name = "Liter_lbl";
            this.Liter_lbl.Size = new System.Drawing.Size(47, 13);
            this.Liter_lbl.TabIndex = 6;
            this.Liter_lbl.Text = "Литера:";
            // 
            // Entrance_lbl
            // 
            this.Entrance_lbl.AutoSize = true;
            this.Entrance_lbl.Location = new System.Drawing.Point(133, 88);
            this.Entrance_lbl.Name = "Entrance_lbl";
            this.Entrance_lbl.Size = new System.Drawing.Size(73, 13);
            this.Entrance_lbl.TabIndex = 7;
            this.Entrance_lbl.Text = "№ подъезда:";
            // 
            // Room_lbl
            // 
            this.Room_lbl.AutoSize = true;
            this.Room_lbl.Location = new System.Drawing.Point(133, 114);
            this.Room_lbl.Name = "Room_lbl";
            this.Room_lbl.Size = new System.Drawing.Size(73, 13);
            this.Room_lbl.TabIndex = 8;
            this.Room_lbl.Text = "№ квартиры:";
            // 
            // cbx_Address
            // 
            this.cbx_Address.FormattingEnabled = true;
            this.cbx_Address.Location = new System.Drawing.Point(91, 58);
            this.cbx_Address.Name = "cbx_Address";
            this.cbx_Address.Size = new System.Drawing.Size(258, 21);
            this.cbx_Address.TabIndex = 9;
            this.cbx_Address.TextChanged += new System.EventHandler(this.cbx_Address_TextChanged);
            this.cbx_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Address_KeyDown);
            // 
            // num_HNum
            // 
            this.num_HNum.Location = new System.Drawing.Point(91, 85);
            this.num_HNum.Name = "num_HNum";
            this.num_HNum.Size = new System.Drawing.Size(36, 20);
            this.num_HNum.TabIndex = 10;
            this.num_HNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_HNum_KeyDown);
            // 
            // num_EntrNum
            // 
            this.num_EntrNum.Location = new System.Drawing.Point(212, 86);
            this.num_EntrNum.Name = "num_EntrNum";
            this.num_EntrNum.Size = new System.Drawing.Size(36, 20);
            this.num_EntrNum.TabIndex = 11;
            this.num_EntrNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_EntrNum_KeyDown);
            // 
            // num_RoomNum
            // 
            this.num_RoomNum.Location = new System.Drawing.Point(212, 112);
            this.num_RoomNum.Name = "num_RoomNum";
            this.num_RoomNum.Size = new System.Drawing.Size(36, 20);
            this.num_RoomNum.TabIndex = 12;
            this.num_RoomNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_RoomNum_KeyDown);
            // 
            // tbx_Liter
            // 
            this.tbx_Liter.Location = new System.Drawing.Point(91, 111);
            this.tbx_Liter.Name = "tbx_Liter";
            this.tbx_Liter.Size = new System.Drawing.Size(36, 20);
            this.tbx_Liter.TabIndex = 13;
            this.tbx_Liter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Liter_KeyDown);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(274, 87);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 21);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_KeyDown);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(274, 86);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(106, 21);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_KeyDown);
            // 
            // btn_AddNewAddr
            // 
            this.btn_AddNewAddr.Location = new System.Drawing.Point(274, 114);
            this.btn_AddNewAddr.Name = "btn_AddNewAddr";
            this.btn_AddNewAddr.Size = new System.Drawing.Size(106, 21);
            this.btn_AddNewAddr.TabIndex = 16;
            this.btn_AddNewAddr.Text = "Добавить Адрес";
            this.btn_AddNewAddr.UseVisualStyleBackColor = true;
            this.btn_AddNewAddr.Click += new System.EventHandler(this.btn_AddNewAddr_Click);
            this.btn_AddNewAddr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddNewAddr_KeyDown);
            // 
            // btn_Addr_Refresh
            // 
            this.btn_Addr_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Addr_Refresh.Image")));
            this.btn_Addr_Refresh.Location = new System.Drawing.Point(355, 58);
            this.btn_Addr_Refresh.Name = "btn_Addr_Refresh";
            this.btn_Addr_Refresh.Size = new System.Drawing.Size(25, 21);
            this.btn_Addr_Refresh.TabIndex = 17;
            this.btn_Addr_Refresh.UseVisualStyleBackColor = true;
            this.btn_Addr_Refresh.Click += new System.EventHandler(this.btn_Addr_Refresh_Click);
            this.btn_Addr_Refresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Addr_Refresh_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 145);
            this.Controls.Add(this.btn_Addr_Refresh);
            this.Controls.Add(this.btn_AddNewAddr);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_Liter);
            this.Controls.Add(this.num_RoomNum);
            this.Controls.Add(this.num_EntrNum);
            this.Controls.Add(this.num_HNum);
            this.Controls.Add(this.cbx_Address);
            this.Controls.Add(this.Room_lbl);
            this.Controls.Add(this.Entrance_lbl);
            this.Controls.Add(this.Liter_lbl);
            this.Controls.Add(this.HNum_lbl);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.tbx_CPhone);
            this.Controls.Add(this.CPhone_lbl);
            this.Controls.Add(this.tbx_FIO);
            this.Controls.Add(this.FIO_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Потребители";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_HNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EntrNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIO_lbl;
        private System.Windows.Forms.TextBox tbx_FIO;
        private System.Windows.Forms.Label CPhone_lbl;
        private System.Windows.Forms.TextBox tbx_CPhone;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label HNum_lbl;
        private System.Windows.Forms.Label Liter_lbl;
        private System.Windows.Forms.Label Entrance_lbl;
        private System.Windows.Forms.Label Room_lbl;
        private System.Windows.Forms.ComboBox cbx_Address;
        private System.Windows.Forms.NumericUpDown num_HNum;
        private System.Windows.Forms.NumericUpDown num_EntrNum;
        private System.Windows.Forms.NumericUpDown num_RoomNum;
        private System.Windows.Forms.TextBox tbx_Liter;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddNewAddr;
        private System.Windows.Forms.Button btn_Addr_Refresh;
    }
}