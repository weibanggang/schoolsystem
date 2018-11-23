namespace School
{
    partial class frmAAxgpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAAxgpwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtpwds = new System.Windows.Forms.TextBox();
            this.txtpwdss = new System.Windows.Forms.TextBox();
            this.btngo = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(151, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(151, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(131, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次确认：";
            // 
            // txtuid
            // 
            this.txtuid.Font = new System.Drawing.Font("宋体", 12F);
            this.txtuid.Location = new System.Drawing.Point(236, 69);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(226, 26);
            this.txtuid.TabIndex = 1;
            // 
            // txtpwds
            // 
            this.txtpwds.Font = new System.Drawing.Font("宋体", 12F);
            this.txtpwds.Location = new System.Drawing.Point(236, 122);
            this.txtpwds.Name = "txtpwds";
            this.txtpwds.PasswordChar = '*';
            this.txtpwds.Size = new System.Drawing.Size(226, 26);
            this.txtpwds.TabIndex = 2;
            // 
            // txtpwdss
            // 
            this.txtpwdss.Font = new System.Drawing.Font("宋体", 12F);
            this.txtpwdss.Location = new System.Drawing.Point(236, 174);
            this.txtpwdss.Name = "txtpwdss";
            this.txtpwdss.PasswordChar = '*';
            this.txtpwdss.Size = new System.Drawing.Size(226, 26);
            this.txtpwdss.TabIndex = 3;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(197, 234);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(87, 33);
            this.btngo.TabIndex = 4;
            this.btngo.Text = "提交";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(369, 234);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(87, 33);
            this.btnno.TabIndex = 5;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAAxgpwd
            // 
            this.AcceptButton = this.btngo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(610, 313);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.txtpwdss);
            this.Controls.Add(this.txtpwds);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAAxgpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.xueshengdenglok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtpwds;
        private System.Windows.Forms.TextBox txtpwdss;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnno;
    }
}