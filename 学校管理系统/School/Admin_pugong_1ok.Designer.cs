namespace School
{
    partial class Admin_pugong_1ok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtname = new System.Windows.Forms.TextBox();
            this.xingbie = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dadas = new System.Windows.Forms.DataGridView();
            this.btnsele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comzw = new System.Windows.Forms.ComboBox();
            this.comlx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.counl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(508, 8);
            this.txtname.MaxLength = 12;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 3;
            // 
            // xingbie
            // 
            this.xingbie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xingbie.FormattingEnabled = true;
            this.xingbie.Items.AddRange(new object[] {
            "男",
            "女"});
            this.xingbie.Location = new System.Drawing.Point(388, 8);
            this.xingbie.Name = "xingbie";
            this.xingbie.Size = new System.Drawing.Size(64, 20);
            this.xingbie.TabIndex = 2;
            this.xingbie.SelectedIndexChanged += new System.EventHandler(this.xingbie_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dadas
            // 
            this.dadas.AllowUserToAddRows = false;
            this.dadas.AllowUserToDeleteRows = false;
            this.dadas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.sname,
            this.dataGridViewTextBoxColumn2,
            this.cuid,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.dataGridViewTextBoxColumn6,
            this.EmpNation,
            this.dataGridViewButtonColumn1,
            this.counl,
            this.Column2});
            this.dadas.Location = new System.Drawing.Point(1, 35);
            this.dadas.Name = "dadas";
            this.dadas.RowTemplate.Height = 23;
            this.dadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadas.Size = new System.Drawing.Size(933, 459);
            this.dadas.TabIndex = 7;
            this.dadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadas_CellContentClick);
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(738, 4);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(85, 25);
            this.btnsele.TabIndex = 5;
            this.btnsele.Text = "全部查询";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnsele);
            this.panel1.Controls.Add(this.xingbie);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comzw);
            this.panel1.Controls.Add(this.comlx);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 34);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(463, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "姓名:";
            // 
            // comzw
            // 
            this.comzw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comzw.FormattingEnabled = true;
            this.comzw.Location = new System.Drawing.Point(260, 7);
            this.comzw.Name = "comzw";
            this.comzw.Size = new System.Drawing.Size(70, 20);
            this.comzw.TabIndex = 2;
            this.comzw.SelectedIndexChanged += new System.EventHandler(this.comzw_SelectedIndexChanged);
            // 
            // comlx
            // 
            this.comlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comlx.FormattingEnabled = true;
            this.comlx.Location = new System.Drawing.Point(94, 5);
            this.comlx.Name = "comlx";
            this.comlx.Size = new System.Drawing.Size(70, 20);
            this.comlx.TabIndex = 2;
            this.comlx.SelectedIndexChanged += new System.EventHandler(this.comlx_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(176, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "职位名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(10, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "职位类型:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "导出Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "EName";
            this.sname.HeaderText = "姓名";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ESet";
            this.dataGridViewTextBoxColumn2.HeaderText = "性别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // cuid
            // 
            this.cuid.DataPropertyName = "EUid";
            this.cuid.HeaderText = "工号";
            this.cuid.Name = "cuid";
            this.cuid.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ETell";
            this.dataGridViewTextBoxColumn4.HeaderText = "手机号码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EIDAd";
            this.dataGridViewTextBoxColumn5.HeaderText = "家庭住址";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn6.HeaderText = "职位";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // EmpNation
            // 
            this.EmpNation.DataPropertyName = "EmpNation";
            this.EmpNation.HeaderText = "民族";
            this.EmpNation.Name = "EmpNation";
            this.EmpNation.ReadOnly = true;
            this.EmpNation.Width = 40;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle1.NullValue = "修改";
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn1.HeaderText = "操作";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // counl
            // 
            dataGridViewCellStyle2.NullValue = "删除";
            this.counl.DefaultCellStyle = dataGridViewCellStyle2;
            this.counl.HeaderText = "操作";
            this.counl.Name = "counl";
            this.counl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.counl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.counl.Width = 80;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.NullValue = "详细";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "操作";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Admin_pugong_1ok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(935, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_pugong_1ok";
            this.Text = "Admin_pugong_1ok";
            this.Load += new System.EventHandler(this.Admin_pugong_1ok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dadas;
        private System.Windows.Forms.Button btnsele;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox xingbie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comzw;
        private System.Windows.Forms.ComboBox comlx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNation;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn counl;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}