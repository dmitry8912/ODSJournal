namespace ODSJournal.Views.Common.Damages
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
            this.Damage_lbl = new System.Windows.Forms.Label();
            this.tbx_Damage = new System.Windows.Forms.TextBox();
            this.btn_Add_Dmg = new System.Windows.Forms.Button();
            this.btn_Edit_Dmg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Damage_lbl
            // 
            this.Damage_lbl.AutoSize = true;
            this.Damage_lbl.Location = new System.Drawing.Point(12, 9);
            this.Damage_lbl.Name = "Damage_lbl";
            this.Damage_lbl.Size = new System.Drawing.Size(80, 13);
            this.Damage_lbl.TabIndex = 0;
            this.Damage_lbl.Text = "Повреждение:";
            // 
            // tbx_Damage
            // 
            this.tbx_Damage.Location = new System.Drawing.Point(98, 6);
            this.tbx_Damage.Name = "tbx_Damage";
            this.tbx_Damage.Size = new System.Drawing.Size(178, 20);
            this.tbx_Damage.TabIndex = 1;
            this.tbx_Damage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Damage_KeyDown);
            // 
            // btn_Add_Dmg
            // 
            this.btn_Add_Dmg.Location = new System.Drawing.Point(282, 6);
            this.btn_Add_Dmg.Name = "btn_Add_Dmg";
            this.btn_Add_Dmg.Size = new System.Drawing.Size(74, 20);
            this.btn_Add_Dmg.TabIndex = 2;
            this.btn_Add_Dmg.Text = "Добавить";
            this.btn_Add_Dmg.UseVisualStyleBackColor = true;
            this.btn_Add_Dmg.Click += new System.EventHandler(this.btn_Add_Dmg_Click);
            // 
            // btn_Edit_Dmg
            // 
            this.btn_Edit_Dmg.Location = new System.Drawing.Point(282, 6);
            this.btn_Edit_Dmg.Name = "btn_Edit_Dmg";
            this.btn_Edit_Dmg.Size = new System.Drawing.Size(74, 20);
            this.btn_Edit_Dmg.TabIndex = 3;
            this.btn_Edit_Dmg.Text = "Изменить";
            this.btn_Edit_Dmg.UseVisualStyleBackColor = true;
            this.btn_Edit_Dmg.Click += new System.EventHandler(this.btn_Edit_Dmg_Click);
            this.btn_Edit_Dmg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_Dmg_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 29);
            this.Controls.Add(this.btn_Edit_Dmg);
            this.Controls.Add(this.btn_Add_Dmg);
            this.Controls.Add(this.tbx_Damage);
            this.Controls.Add(this.Damage_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Повреждения";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Damage_lbl;
        private System.Windows.Forms.TextBox tbx_Damage;
        private System.Windows.Forms.Button btn_Add_Dmg;
        private System.Windows.Forms.Button btn_Edit_Dmg;
    }
}