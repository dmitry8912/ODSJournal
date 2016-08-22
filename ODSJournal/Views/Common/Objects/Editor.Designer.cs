namespace ODSJournal.Views.Common.Objects
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
            this.btn_AddUch = new System.Windows.Forms.Button();
            this.tbx_uname = new System.Windows.Forms.TextBox();
            this.lbl_UchName = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddUch
            // 
            this.btn_AddUch.Location = new System.Drawing.Point(201, 6);
            this.btn_AddUch.Name = "btn_AddUch";
            this.btn_AddUch.Size = new System.Drawing.Size(71, 20);
            this.btn_AddUch.TabIndex = 0;
            this.btn_AddUch.Text = "Добавить";
            this.btn_AddUch.UseVisualStyleBackColor = true;
            this.btn_AddUch.Click += new System.EventHandler(this.btn_AddUch_Click);
            this.btn_AddUch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddUch_KeyDown);
            // 
            // tbx_uname
            // 
            this.tbx_uname.Location = new System.Drawing.Point(78, 6);
            this.tbx_uname.Name = "tbx_uname";
            this.tbx_uname.Size = new System.Drawing.Size(117, 20);
            this.tbx_uname.TabIndex = 1;
            this.tbx_uname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_uname_KeyDown);
            // 
            // lbl_UchName
            // 
            this.lbl_UchName.AutoSize = true;
            this.lbl_UchName.Location = new System.Drawing.Point(12, 9);
            this.lbl_UchName.Name = "lbl_UchName";
            this.lbl_UchName.Size = new System.Drawing.Size(60, 13);
            this.lbl_UchName.TabIndex = 2;
            this.lbl_UchName.Text = "Название:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(201, 6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(71, 20);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 35);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lbl_UchName);
            this.Controls.Add(this.tbx_uname);
            this.Controls.Add(this.btn_AddUch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.ShowInTaskbar = false;
            this.Text = "Редактор Объектов";
            this.Load += new System.EventHandler(this.Add_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Editor_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddUch;
        private System.Windows.Forms.TextBox tbx_uname;
        private System.Windows.Forms.Label lbl_UchName;
        private System.Windows.Forms.Button btn_Edit;
    }
}