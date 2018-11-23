namespace School
{
    partial class Usshuse
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lanName = new System.Windows.Forms.Label();
            this.labbj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lanrens = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnif
            // 
            this.btnif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnif.Location = new System.Drawing.Point(27, 136);
            this.btnif.Name = "btnif";
            this.btnif.Size = new System.Drawing.Size(75, 23);
            this.btnif.TabIndex = 4;
            this.btnif.Text = "入住";
            this.btnif.UseVisualStyleBackColor = true;
            this.btnif.Click += new System.EventHandler(this.btnif_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lanName);
            this.panel1.Controls.Add(this.labbj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lanrens);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnif);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 165);
            this.panel1.TabIndex = 7;
            // 
            // lanName
            // 
            this.lanName.AutoSize = true;
            this.lanName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.lanName.ForeColor = System.Drawing.Color.White;
            this.lanName.Location = new System.Drawing.Point(55, 89);
            this.lanName.Name = "lanName";
            this.lanName.Size = new System.Drawing.Size(23, 12);
            this.lanName.TabIndex = 1;
            this.lanName.Text = "410";
            // 
            // labbj
            // 
            this.labbj.AutoSize = true;
            this.labbj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.labbj.Font = new System.Drawing.Font("宋体", 8F);
            this.labbj.Location = new System.Drawing.Point(51, 56);
            this.labbj.Name = "labbj";
            this.labbj.Size = new System.Drawing.Size(38, 11);
            this.labbj.TabIndex = 1;
            this.labbj.Text = "未入住";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("宋体", 8F);
            this.label4.Location = new System.Drawing.Point(70, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 11);
            this.label4.TabIndex = 1;
            this.label4.Text = ")人";
            // 
            // lanrens
            // 
            this.lanrens.AutoSize = true;
            this.lanrens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.lanrens.Font = new System.Drawing.Font("宋体", 8F);
            this.lanrens.Location = new System.Drawing.Point(59, 73);
            this.lanrens.Name = "lanrens";
            this.lanrens.Size = new System.Drawing.Size(11, 11);
            this.lanrens.TabIndex = 1;
            this.lanrens.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("宋体", 8F);
            this.label3.Location = new System.Drawing.Point(47, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 11);
            this.label3.TabIndex = 1;
            this.label3.Text = "(";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Usshuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Usshuse";
            this.Size = new System.Drawing.Size(141, 165);
            this.Load += new System.EventHandler(this.Usshuse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lanName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lanrens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labbj;
    }
}
