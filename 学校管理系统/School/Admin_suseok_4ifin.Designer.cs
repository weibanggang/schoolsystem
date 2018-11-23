namespace School
{
    partial class Admin_suseok_4ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_suseok_4ifin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtfh = new System.Windows.Forms.TextBox();
            this.btnno = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lansw = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.lansw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号码:";
            // 
            // txtfh
            // 
            this.txtfh.Location = new System.Drawing.Point(91, 23);
            this.txtfh.MaxLength = 12;
            this.txtfh.Name = "txtfh";
            this.txtfh.Size = new System.Drawing.Size(138, 21);
            this.txtfh.TabIndex = 1;
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(166, 101);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(63, 25);
            this.btnno.TabIndex = 3;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(91, 101);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(69, 25);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "提交";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "可住人数:";
            // 
            // lansw
            // 
            this.lansw.Location = new System.Drawing.Point(91, 65);
            this.lansw.Name = "lansw";
            this.lansw.Size = new System.Drawing.Size(138, 21);
            this.lansw.TabIndex = 4;
            this.lansw.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Admin_suseok_4ifin
            // 
            this.AcceptButton = this.btngo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(273, 160);
            this.Controls.Add(this.lansw);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.txtfh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_suseok_4ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加房号";
            this.Load += new System.EventHandler(this.admin_shuse5if__Load);
            ((System.ComponentModel.ISupportInitialize)(this.lansw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfh;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lansw;
    }
}