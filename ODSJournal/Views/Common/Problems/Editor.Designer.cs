namespace ODSJournal.Views.Common.Problems
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
            this.btn_Add_Problem = new System.Windows.Forms.Button();
            this.btn_Edit_Problem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Problem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Add_Problem
            // 
            this.btn_Add_Problem.Location = new System.Drawing.Point(406, 6);
            this.btn_Add_Problem.Name = "btn_Add_Problem";
            this.btn_Add_Problem.Size = new System.Drawing.Size(69, 20);
            this.btn_Add_Problem.TabIndex = 0;
            this.btn_Add_Problem.Text = "Добавить";
            this.btn_Add_Problem.UseVisualStyleBackColor = true;
            this.btn_Add_Problem.Click += new System.EventHandler(this.btn_Add_Problem_Click);
            this.btn_Add_Problem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_Problem_KeyDown);
            // 
            // btn_Edit_Problem
            // 
            this.btn_Edit_Problem.Location = new System.Drawing.Point(406, 6);
            this.btn_Edit_Problem.Name = "btn_Edit_Problem";
            this.btn_Edit_Problem.Size = new System.Drawing.Size(69, 20);
            this.btn_Edit_Problem.TabIndex = 1;
            this.btn_Edit_Problem.Text = "Изменить";
            this.btn_Edit_Problem.UseVisualStyleBackColor = true;
            this.btn_Edit_Problem.Click += new System.EventHandler(this.btn_Edit_Problem_Click);
            this.btn_Edit_Problem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Edit_Problem_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обращение:";
            // 
            // tbx_Problem
            // 
            this.tbx_Problem.Location = new System.Drawing.Point(87, 6);
            this.tbx_Problem.Name = "tbx_Problem";
            this.tbx_Problem.Size = new System.Drawing.Size(313, 20);
            this.tbx_Problem.TabIndex = 3;
            this.tbx_Problem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Problem_KeyDown);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 34);
            this.Controls.Add(this.tbx_Problem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Edit_Problem);
            this.Controls.Add(this.btn_Add_Problem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Обращения";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Problem;
        private System.Windows.Forms.Button btn_Edit_Problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Problem;
    }
}