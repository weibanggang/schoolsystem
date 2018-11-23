namespace School
{
    partial class xiugaiss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comlx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comzw = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xiugais = new System.Windows.Forms.DataGridView();
            this.xiugaiid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.是 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.conxb = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xiugais)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comlx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按职位类型查询";
            // 
            // comlx
            // 
            this.comlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comlx.FormattingEnabled = true;
            this.comlx.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comlx.Location = new System.Drawing.Point(80, 15);
            this.comlx.Name = "comlx";
            this.comlx.Size = new System.Drawing.Size(70, 20);
            this.comlx.TabIndex = 2;
            this.comlx.SelectedIndexChanged += new System.EventHandler(this.comlx_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "职位类型:";
            // 
            // comzw
            // 
            this.comzw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comzw.FormattingEnabled = true;
            this.comzw.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comzw.Location = new System.Drawing.Point(89, 18);
            this.comzw.Name = "comzw";
            this.comzw.Size = new System.Drawing.Size(70, 20);
            this.comzw.TabIndex = 2;
            this.comzw.SelectedIndexChanged += new System.EventHandler(this.comzw_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "职位名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "性别:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(61, 16);
            this.txtname.MaxLength = 12;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(88, 21);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名:";
            // 
            // xiugais
            // 
            this.xiugais.AllowUserToAddRows = false;
            this.xiugais.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xiugais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xiugais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xiugaiid,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewButtonColumn3,
            this.是,
            this.Column2});
            this.xiugais.Location = new System.Drawing.Point(0, 49);
            this.xiugais.Name = "xiugais";
            this.xiugais.RowTemplate.Height = 23;
            this.xiugais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xiugais.Size = new System.Drawing.Size(942, 419);
            this.xiugais.TabIndex = 2;
            this.xiugais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xiugais_CellClick);
            this.xiugais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xiugais_CellContentClick);
            // 
            // xiugaiid
            // 
            this.xiugaiid.DataPropertyName = "ID";
            this.xiugaiid.HeaderText = "编号";
            this.xiugaiid.Name = "xiugaiid";
            this.xiugaiid.ReadOnly = true;
            this.xiugaiid.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TName";
            this.dataGridViewTextBoxColumn3.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TSex";
            this.dataGridViewTextBoxColumn8.HeaderText = "性别";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TUid";
            this.dataGridViewTextBoxColumn10.HeaderText = "工号";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TPhone";
            this.dataGridViewTextBoxColumn15.HeaderText = "手机号码";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "THoome";
            this.dataGridViewTextBoxColumn16.HeaderText = "家庭住址";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TTimeRZ";
            this.dataGridViewTextBoxColumn17.HeaderText = "入职时间";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TNation";
            this.dataGridViewTextBoxColumn18.HeaderText = "民族";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 40;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle4.NullValue = "修改";
            this.dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn3.HeaderText = "操作";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.Width = 83;
            // 
            // 是
            // 
            dataGridViewCellStyle5.NullValue = "删除";
            this.是.DefaultCellStyle = dataGridViewCellStyle5;
            this.是.HeaderText = "操作";
            this.是.Name = "是";
            this.是.Width = 82;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.NullValue = "详细";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "操作";
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(-2, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "总数据：20条，男：20，女：10";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comzw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(173, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 43);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按职位名称查询";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.conxb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(354, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 43);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "按性别查询";
            // 
            // conxb
            // 
            this.conxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conxb.FormattingEnabled = true;
            this.conxb.Items.AddRange(new object[] {
            "男",
            "女"});
            this.conxb.Location = new System.Drawing.Point(69, 17);
            this.conxb.Name = "conxb";
            this.conxb.Size = new System.Drawing.Size(70, 20);
            this.conxb.TabIndex = 2;
            this.conxb.SelectedIndexChanged += new System.EventHandler(this.conxb_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtname);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(520, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 43);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "按性别查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 22);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(751, 15);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(84, 25);
            this.btnsele.TabIndex = 17;
            this.btnsele.Text = "全部查询";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnsele);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 48);
            this.panel1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "导出Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xiugaiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(942, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xiugais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xiugaiss";
            this.Text = "Admin_jshiok1_upda1";
            this.Load += new System.EventHandler(this.Admin_jshiok1_upda1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xiugais)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView xiugais;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox comlx;
        private System.Windows.Forms.ComboBox comzw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox conxb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnsele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiugaiid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn 是;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.Button button2;
    }
}