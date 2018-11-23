namespace School
{
    partial class Admin_suseok_4
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
            this.flos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtok = new System.Windows.Forms.TextBox();
            this.lanrens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flos
            // 
            this.flos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flos.AutoScroll = true;
            this.flos.Location = new System.Drawing.Point(1, 36);
            this.flos.Name = "flos";
            this.flos.Size = new System.Drawing.Size(1052, 452);
            this.flos.TabIndex = 0;
            this.flos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flos_Scroll);
            this.flos.Paint += new System.Windows.Forms.PaintEventHandler(this.flos_Paint);
            this.flos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flos_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtok);
            this.panel3.Controls.Add(this.lanrens);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 31);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtok
            // 
            this.txtok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtok.Font = new System.Drawing.Font("宋体", 12F);
            this.txtok.Location = new System.Drawing.Point(432, 2);
            this.txtok.MaxLength = 20;
            this.txtok.Name = "txtok";
            this.txtok.Size = new System.Drawing.Size(153, 26);
            this.txtok.TabIndex = 2;
            // 
            // lanrens
            // 
            this.lanrens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lanrens.AutoSize = true;
            this.lanrens.Font = new System.Drawing.Font("宋体", 15F);
            this.lanrens.Location = new System.Drawing.Point(92, 5);
            this.lanrens.Name = "lanrens";
            this.lanrens.Size = new System.Drawing.Size(99, 20);
            this.lanrens.TabIndex = 1;
            this.lanrens.Text = "一共:1000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(330, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名查询:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(964, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "添加宿舍";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(591, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_suseok_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1058, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_suseok_4";
            this.Text = "Admin_suseok_4";
            this.Load += new System.EventHandler(this.zhushuguanl3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.FlowLayoutPanel flos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lanrens;
    }
}