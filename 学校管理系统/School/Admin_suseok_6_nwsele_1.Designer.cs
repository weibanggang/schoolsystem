namespace School
{
    partial class Admin_suseok_6_nwsele_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datatime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comlm = new System.Windows.Forms.ComboBox();
            this.datas = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lansw = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.compo = new System.Windows.Forms.ComboBox();
            this.carl = new System.Windows.Forms.CheckBox();
            this.cardata = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.SuspendLayout();
            // 
            // datatime
            // 
            this.datatime.CalendarFont = new System.Drawing.Font("宋体", 20F);
            this.datatime.Font = new System.Drawing.Font("宋体", 9F);
            this.datatime.Location = new System.Drawing.Point(271, 2);
            this.datatime.Name = "datatime";
            this.datatime.Size = new System.Drawing.Size(107, 21);
            this.datatime.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(185, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "检查日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(18, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "宿舍楼:";
            // 
            // comlm
            // 
            this.comlm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comlm.Font = new System.Drawing.Font("宋体", 9F);
            this.comlm.FormattingEnabled = true;
            this.comlm.Location = new System.Drawing.Point(81, 2);
            this.comlm.Name = "comlm";
            this.comlm.Size = new System.Drawing.Size(81, 20);
            this.comlm.TabIndex = 9;
            this.comlm.SelectedIndexChanged += new System.EventHandler(this.comlm_SelectedIndexChanged);
            // 
            // datas
            // 
            this.datas.AllowUserToAddRows = false;
            this.datas.BackgroundColor = System.Drawing.Color.White;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column10,
            this.Column11});
            this.datas.Location = new System.Drawing.Point(-1, 24);
            this.datas.Name = "datas";
            this.datas.RowTemplate.Height = 23;
            this.datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datas.Size = new System.Drawing.Size(936, 440);
            this.datas.TabIndex = 16;
            this.datas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datas_CellContentClick);
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ID";
            this.Column9.HeaderText = "编号";
            this.Column9.Name = "Column9";
            this.Column9.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "楼名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "class";
            this.Column5.HeaderText = "班级";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DormitoryNO";
            this.Column2.HeaderText = "房间号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Point";
            this.Column3.HeaderText = "总分";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "KPiont";
            this.Column4.HeaderText = "扣分";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FuZe";
            this.Column6.HeaderText = "检查人";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "times";
            this.Column8.HeaderText = "日期";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.NullValue = "删除";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column10.HeaderText = "操作";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            dataGridViewCellStyle2.NullValue = "详细";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "操作";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "报表";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lansw
            // 
            this.lansw.AutoSize = true;
            this.lansw.Font = new System.Drawing.Font("宋体", 15F);
            this.lansw.Location = new System.Drawing.Point(-1, 467);
            this.lansw.Name = "lansw";
            this.lansw.Size = new System.Drawing.Size(489, 20);
            this.lansw.TabIndex = 19;
            this.lansw.Text = "查询到10个宿舍申请维修，5个宿舍未修，5个宿舍已修";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 21);
            this.button3.TabIndex = 22;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(457, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "检查人:";
            // 
            // compo
            // 
            this.compo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compo.Font = new System.Drawing.Font("宋体", 9F);
            this.compo.FormattingEnabled = true;
            this.compo.Location = new System.Drawing.Point(527, 1);
            this.compo.Name = "compo";
            this.compo.Size = new System.Drawing.Size(110, 20);
            this.compo.TabIndex = 20;
            this.compo.SelectedIndexChanged += new System.EventHandler(this.compo_SelectedIndexChanged);
            // 
            // carl
            // 
            this.carl.AutoSize = true;
            this.carl.Checked = true;
            this.carl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.carl.Location = new System.Drawing.Point(2, 6);
            this.carl.Name = "carl";
            this.carl.Size = new System.Drawing.Size(15, 14);
            this.carl.TabIndex = 23;
            this.carl.UseVisualStyleBackColor = true;
            // 
            // cardata
            // 
            this.cardata.AutoSize = true;
            this.cardata.Location = new System.Drawing.Point(167, 6);
            this.cardata.Name = "cardata";
            this.cardata.Size = new System.Drawing.Size(15, 14);
            this.cardata.TabIndex = 23;
            this.cardata.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(652, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 21);
            this.button5.TabIndex = 22;
            this.button5.Text = "全部查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 21);
            this.button2.TabIndex = 22;
            this.button2.Text = "按日查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(864, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 21);
            this.button4.TabIndex = 22;
            this.button4.Text = "导出Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin_suseok_6_nwsele_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(935, 489);
            this.Controls.Add(this.cardata);
            this.Controls.Add(this.carl);
            this.Controls.Add(this.comlm);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compo);
            this.Controls.Add(this.lansw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datas);
            this.Controls.Add(this.datatime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_suseok_6_nwsele_1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Admin_suseok_6_nwsele_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datatime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comlm;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lansw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox compo;
        private System.Windows.Forms.CheckBox carl;
        private System.Windows.Forms.CheckBox cardata;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewLinkColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Column11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}