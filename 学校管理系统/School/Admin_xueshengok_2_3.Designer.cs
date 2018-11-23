namespace School
{
    partial class Admin_xueshengok_2_3
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
            this.xiugais = new System.Windows.Forms.DataGridView();
            this.xiugaiid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.lanrens = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xiugais)).BeginInit();
            this.SuspendLayout();
            // 
            // xiugais
            // 
            this.xiugais.AllowUserToAddRows = false;
            this.xiugais.AllowUserToDeleteRows = false;
            this.xiugais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xiugais.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xiugais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xiugais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xiugaiid,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewButtonColumn3,
            this.Column1,
            this.Column2});
            this.xiugais.Location = new System.Drawing.Point(0, 23);
            this.xiugais.Name = "xiugais";
            this.xiugais.RowTemplate.Height = 23;
            this.xiugais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xiugais.Size = new System.Drawing.Size(825, 284);
            this.xiugais.TabIndex = 12;
            this.xiugais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xiugais_CellContentClick);
            // 
            // xiugaiid
            // 
            this.xiugaiid.DataPropertyName = "ID";
            this.xiugaiid.HeaderText = "编号";
            this.xiugaiid.Name = "xiugaiid";
            this.xiugaiid.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SStudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StudentSex";
            this.dataGridViewTextBoxColumn8.HeaderText = "性别";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn10.HeaderText = "账号";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SPhone";
            this.dataGridViewTextBoxColumn15.HeaderText = "手机号码";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 90;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CName";
            this.dataGridViewTextBoxColumn16.HeaderText = "班级";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 90;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "STimeRZ";
            this.dataGridViewTextBoxColumn17.HeaderText = "入校时间";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 90;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SNation";
            this.dataGridViewTextBoxColumn18.HeaderText = "民族";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 40;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle1.NullValue = "修改";
            this.dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewButtonColumn3.HeaderText = "操作";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.Width = 67;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.NullValue = "删除";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "操作";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.NullValue = "详细";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "操作";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 68;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lanrens
            // 
            this.lanrens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lanrens.AutoSize = true;
            this.lanrens.Font = new System.Drawing.Font("宋体", 15F);
            this.lanrens.Location = new System.Drawing.Point(77, 3);
            this.lanrens.Name = "lanrens";
            this.lanrens.Size = new System.Drawing.Size(119, 20);
            this.lanrens.TabIndex = 13;
            this.lanrens.Text = "一共:1000人";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 21);
            this.button3.TabIndex = 14;
            this.button3.Text = "导出Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "清空学生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_xueshengok_2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(826, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lanrens);
            this.Controls.Add(this.xiugais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_xueshengok_2_3";
            this.Text = "Admin_xueshengok_2_3";
            this.Load += new System.EventHandler(this.Admin_xueshengok_2_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xiugais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView xiugais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lanrens;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xiugaiid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}