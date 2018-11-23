namespace School
{
    partial class Admin_Adminok_2ck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Adminok_2ck));
            this.label1 = new System.Windows.Forms.Label();
            this.textzt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texttime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "主题:";
            // 
            // textzt
            // 
            this.textzt.Font = new System.Drawing.Font("宋体", 12F);
            this.textzt.Location = new System.Drawing.Point(96, 99);
            this.textzt.Name = "textzt";
            this.textzt.ReadOnly = true;
            this.textzt.Size = new System.Drawing.Size(219, 26);
            this.textzt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "内容:";
            // 
            // textnr
            // 
            this.textnr.Font = new System.Drawing.Font("宋体", 12F);
            this.textnr.Location = new System.Drawing.Point(96, 145);
            this.textnr.Multiline = true;
            this.textnr.Name = "textnr";
            this.textnr.ReadOnly = true;
            this.textnr.Size = new System.Drawing.Size(460, 176);
            this.textnr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(35, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "名字:";
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("宋体", 12F);
            this.textname.Location = new System.Drawing.Point(96, 13);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(219, 26);
            this.textname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(35, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "时间:";
            // 
            // texttime
            // 
            this.texttime.Font = new System.Drawing.Font("宋体", 12F);
            this.texttime.Location = new System.Drawing.Point(96, 53);
            this.texttime.Name = "texttime";
            this.texttime.ReadOnly = true;
            this.texttime.Size = new System.Drawing.Size(219, 26);
            this.texttime.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(481, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Adminok_2ck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textnr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texttime);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textzt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Adminok_2ck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理反馈";
            this.Load += new System.EventHandler(this.Admin_Adminok_2ck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textzt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttime;
        private System.Windows.Forms.Button button1;
    }
}