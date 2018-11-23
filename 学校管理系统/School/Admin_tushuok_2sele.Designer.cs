namespace School
{
    partial class Admin_tushuok_2sele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dadas = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comsf = new System.Windows.Forms.ComboBox();
            this.comsxh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsele = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.csid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadas
            // 
            this.dadas.AllowUserToAddRows = false;
            this.dadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dadas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csid,
            this.Column6,
            this.mc,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9});
            this.dadas.Location = new System.Drawing.Point(1, 38);
            this.dadas.Name = "dadas";
            this.dadas.RowTemplate.Height = 23;
            this.dadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadas.Size = new System.Drawing.Size(1059, 428);
            this.dadas.TabIndex = 4;
            this.dadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadas_CellContentClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton2.Location = new System.Drawing.Point(355, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "未还";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton1.Location = new System.Drawing.Point(419, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "已还";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comsf
            // 
            this.comsf.AutoCompleteCustomSource.AddRange(new string[] {
            "学生",
            "教师",
            "普工"});
            this.comsf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comsf.Font = new System.Drawing.Font("宋体", 12F);
            this.comsf.FormattingEnabled = true;
            this.comsf.Items.AddRange(new object[] {
            "学生",
            "教师",
            "员工"});
            this.comsf.Location = new System.Drawing.Point(618, 6);
            this.comsf.Name = "comsf";
            this.comsf.Size = new System.Drawing.Size(96, 24);
            this.comsf.TabIndex = 2;
            this.comsf.SelectedIndexChanged += new System.EventHandler(this.comsf_SelectedIndexChanged);
            // 
            // comsxh
            // 
            this.comsxh.Font = new System.Drawing.Font("宋体", 12F);
            this.comsxh.FormattingEnabled = true;
            this.comsxh.Location = new System.Drawing.Point(90, 6);
            this.comsxh.Name = "comsxh";
            this.comsxh.Size = new System.Drawing.Size(106, 24);
            this.comsxh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(290, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "状态:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(557, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "身份:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "学/工号:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnsele
            // 
            this.btnsele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsele.Location = new System.Drawing.Point(851, 6);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(68, 25);
            this.btnsele.TabIndex = 7;
            this.btnsele.Text = "清除已还";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(955, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "全部查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.btnsele);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.comsf);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comsxh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 37);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // csid
            // 
            this.csid.DataPropertyName = "ID";
            this.csid.HeaderText = "编号";
            this.csid.Name = "csid";
            this.csid.Width = 40;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IDT";
            this.Column6.HeaderText = "身份";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // mc
            // 
            this.mc.DataPropertyName = "xuehao";
            this.mc.HeaderText = "学号/工号";
            this.mc.Name = "mc";
            this.mc.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BID";
            this.Column2.HeaderText = "书编号";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LenTime";
            this.Column3.HeaderText = "借书时间";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ReturnTime";
            this.Column4.HeaderText = "还书时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "huihuan";
            this.Column5.HeaderText = "是否归还";
            this.Column5.Name = "Column5";
            this.Column5.Width = 85;
            // 
            // Column9
            // 
            dataGridViewCellStyle10.NullValue = "删除";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column9.HeaderText = "操作";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.Width = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(-2, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "执行时间:查到总数量:8|未还数量:4|已还数量:4 ";
            // 
            // Admin_tushuok_2sele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_tushuok_2sele";
            this.Text = "Admin_tushuok_2sele";
            this.Load += new System.EventHandler(this.Admin_tushuok_2sele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadas;
        private System.Windows.Forms.ComboBox comsxh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsele;
        private System.Windows.Forms.ComboBox comsf;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn csid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column9;
        private System.Windows.Forms.Label label4;
    }
}