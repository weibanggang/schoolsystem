namespace School
{
    partial class Admin_Adminok_1ifin_ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Adminok_1ifin_ifin));
            this.btngo = new System.Windows.Forms.Button();
            this.txtlx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(274, 26);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(56, 26);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "添加";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // txtlx
            // 
            this.txtlx.Font = new System.Drawing.Font("宋体", 12F);
            this.txtlx.Location = new System.Drawing.Point(117, 26);
            this.txtlx.MaxLength = 12;
            this.txtlx.Name = "txtlx";
            this.txtlx.Size = new System.Drawing.Size(139, 26);
            this.txtlx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型名称:";
            // 
            // Admin_Adminok_1ifin_ifin
            // 
            this.AcceptButton = this.btngo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(373, 87);
            this.Controls.Add(this.txtlx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Adminok_1ifin_ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加类型";
            this.Load += new System.EventHandler(this.Admgly_tjlx1__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox txtlx;
        private System.Windows.Forms.Label label2;
    }
}