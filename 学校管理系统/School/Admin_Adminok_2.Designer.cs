namespace School
{
    partial class Admin_Adminok_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Adminok_2));
            this.panzhuangti = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panzhuangti
            // 
            this.panzhuangti.AutoSize = true;
            this.panzhuangti.BackColor = System.Drawing.Color.Transparent;
            this.panzhuangti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panzhuangti.ForeColor = System.Drawing.Color.Black;
            this.panzhuangti.Location = new System.Drawing.Point(0, 0);
            this.panzhuangti.Name = "panzhuangti";
            this.panzhuangti.Size = new System.Drawing.Size(1071, 578);
            this.panzhuangti.TabIndex = 13;
            // 
            // Admin_Adminok_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1070, 580);
            this.Controls.Add(this.panzhuangti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Adminok_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校管家";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Adminok_2_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Adminok_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panzhuangti;
    }
}