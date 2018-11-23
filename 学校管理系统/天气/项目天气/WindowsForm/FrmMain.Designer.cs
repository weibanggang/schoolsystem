namespace WindowsForm
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labtime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labsj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lanxq = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(21, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtime.Location = new System.Drawing.Point(141, 200);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(109, 21);
            this.labtime.TabIndex = 1;
            this.labtime.Text = "12月18日 周一";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(146, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labsj
            // 
            this.labsj.AutoSize = true;
            this.labsj.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsj.Location = new System.Drawing.Point(-2, -13);
            this.labsj.Name = "labsj";
            this.labsj.Size = new System.Drawing.Size(271, 124);
            this.labsj.TabIndex = 1;
            this.labsj.Text = "20:18";
            this.labsj.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "2018年12月18日";
            // 
            // lanxq
            // 
            this.lanxq.AutoSize = true;
            this.lanxq.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lanxq.Location = new System.Drawing.Point(190, 94);
            this.lanxq.Name = "lanxq";
            this.lanxq.Size = new System.Drawing.Size(54, 28);
            this.lanxq.TabIndex = 1;
            this.lanxq.Text = "周一";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(260, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lanxq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labsj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labsj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lanxq;
        private System.Windows.Forms.Timer timer1;
    }
}