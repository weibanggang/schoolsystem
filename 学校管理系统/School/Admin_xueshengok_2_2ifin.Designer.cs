namespace School
{
    partial class Admin_xueshengok_2_2ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_xueshengok_2_2ifin));
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtcq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comzbr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtpwd.Location = new System.Drawing.Point(224, 120);
            this.txtpwd.MaxLength = 11;
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(202, 26);
            this.txtpwd.TabIndex = 3;
            // 
            // txtcq
            // 
            this.txtcq.Font = new System.Drawing.Font("宋体", 12F);
            this.txtcq.Location = new System.Drawing.Point(224, 28);
            this.txtcq.MaxLength = 10;
            this.txtcq.Name = "txtcq";
            this.txtcq.Size = new System.Drawing.Size(202, 26);
            this.txtcq.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(113, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "联系方式：";
            // 
            // comzbr
            // 
            this.comzbr.Font = new System.Drawing.Font("宋体", 12F);
            this.comzbr.FormattingEnabled = true;
            this.comzbr.Location = new System.Drawing.Point(224, 76);
            this.comzbr.Name = "comzbr";
            this.comzbr.Size = new System.Drawing.Size(202, 24);
            this.comzbr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(133, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "班主任：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "班级名称：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "提交";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(346, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_xueshengok_2_2ifin
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(595, 250);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtcq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comzbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_xueshengok_2_2ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级添加";
            this.Load += new System.EventHandler(this.Admin_xueshengok_2_2ifin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtcq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comzbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}