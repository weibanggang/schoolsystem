namespace School
{
    partial class Admin_suseok_2
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
            this.flos = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lans = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flos
            // 
            this.flos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flos.AutoScroll = true;
            this.flos.Location = new System.Drawing.Point(0, 27);
            this.flos.Name = "flos";
            this.flos.Size = new System.Drawing.Size(1058, 462);
            this.flos.TabIndex = 3;
            this.flos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flos_Scroll);
            this.flos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lans
            // 
            this.lans.AutoSize = true;
            this.lans.Font = new System.Drawing.Font("宋体", 18F);
            this.lans.Location = new System.Drawing.Point(2, 1);
            this.lans.Name = "lans";
            this.lans.Size = new System.Drawing.Size(250, 24);
            this.lans.TabIndex = 4;
            this.lans.Text = "一共:1栋楼 500间宿舍";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "添加楼层";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "报表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin_suseok_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1058, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lans);
            this.Controls.Add(this.flos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_suseok_2";
            this.Text = "Admin_shuse3_";
            this.Load += new System.EventHandler(this.zhushuguanl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.FlowLayoutPanel flos;
        private System.Windows.Forms.Label lans;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}