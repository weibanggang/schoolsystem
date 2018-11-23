namespace School
{
    partial class Admin_suseok_4_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lanbs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DataVies = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataVies)).BeginInit();
            this.SuspendLayout();
            // 
            // lanbs
            // 
            this.lanbs.AutoSize = true;
            this.lanbs.Font = new System.Drawing.Font("宋体", 15F);
            this.lanbs.Location = new System.Drawing.Point(450, 5);
            this.lanbs.Name = "lanbs";
            this.lanbs.Size = new System.Drawing.Size(89, 20);
            this.lanbs.TabIndex = 1;
            this.lanbs.Text = "个人信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(962, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(856, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "全部清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataVies
            // 
            this.DataVies.AllowUserToAddRows = false;
            this.DataVies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataVies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataVies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cname,
            this.cph,
            this.Column7,
            this.Column8,
            this.ss,
            this.Column10,
            this.Column11});
            this.DataVies.Location = new System.Drawing.Point(-1, 30);
            this.DataVies.Name = "DataVies";
            this.DataVies.RowTemplate.Height = 23;
            this.DataVies.Size = new System.Drawing.Size(1057, 402);
            this.DataVies.TabIndex = 19;
            this.DataVies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVies_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(0, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cname
            // 
            this.cname.DataPropertyName = "Name";
            this.cname.HeaderText = "姓名";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 145;
            // 
            // cph
            // 
            this.cph.DataPropertyName = "BedNO";
            this.cph.HeaderText = "床号";
            this.cph.Name = "cph";
            this.cph.ReadOnly = true;
            this.cph.Width = 145;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tell";
            this.Column7.HeaderText = "电话号码";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DonID";
            this.Column8.HeaderText = "宿舍号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 145;
            // 
            // ss
            // 
            this.ss.DataPropertyName = "CName";
            this.ss.HeaderText = "班级";
            this.ss.Name = "ss";
            this.ss.ReadOnly = true;
            this.ss.Width = 145;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "RZtime";
            this.Column10.HeaderText = "入住时间";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 145;
            // 
            // Column11
            // 
            dataGridViewCellStyle3.NullValue = "删除";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "操作";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.Width = 148;
            // 
            // Admin_suseok_4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1058, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lanbs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataVies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_suseok_4_1";
            this.Text = "zhuangshuguanl4";
            this.Load += new System.EventHandler(this.Admin_suseok_4_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataVies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lanbs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataVies;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Column11;
    }
}