namespace School
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            this.panzhuangti = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panzhuangti
            // 
            this.panzhuangti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panzhuangti.AutoSize = true;
            this.panzhuangti.BackColor = System.Drawing.Color.Transparent;
            this.panzhuangti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panzhuangti.ForeColor = System.Drawing.Color.Black;
            this.panzhuangti.Location = new System.Drawing.Point(0, -2);
            this.panzhuangti.Name = "panzhuangti";
            this.panzhuangti.Size = new System.Drawing.Size(1068, 600);
            this.panzhuangti.TabIndex = 12;
            this.panzhuangti.Paint += new System.Windows.Forms.PaintEventHandler(this.panzhuangti_Paint);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 595);
            this.Controls.Add(this.panzhuangti);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校管家";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login1_FormClosing);
            this.Load += new System.EventHandler(this.Login1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panzhuangti;
    }
}