namespace School
{
    partial class Admin_suseok_lcgl_2
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
            this.button2 = new System.Windows.Forms.Button();
            this.lanrens = new System.Windows.Forms.Label();
            this.das = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.das)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lanrens
            // 
            this.lanrens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lanrens.AutoSize = true;
            this.lanrens.Font = new System.Drawing.Font("宋体", 15F);
            this.lanrens.Location = new System.Drawing.Point(77, 1);
            this.lanrens.Name = "lanrens";
            this.lanrens.Size = new System.Drawing.Size(99, 20);
            this.lanrens.TabIndex = 1;
            this.lanrens.Text = "一共:1000";
            // 
            // das
            // 
            this.das.AllowUserToAddRows = false;
            this.das.BackgroundColor = System.Drawing.Color.White;
            this.das.ColumnHeadersHeight = 20;
            this.das.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.Column9,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column10,
            this.Column2,
            this.Column11,
            this.dataGridViewButtonColumn3});
            this.das.Location = new System.Drawing.Point(1, 24);
            this.das.Name = "das";
            this.das.RowTemplate.Height = 23;
            this.das.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.das.Size = new System.Drawing.Size(820, 283);
            this.das.TabIndex = 0;
            this.das.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.das_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "楼名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DName";
            this.Column1.HeaderText = "楼栋";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DonID";
            this.dataGridViewTextBoxColumn2.HeaderText = "房号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "BCount";
            this.Column9.HeaderText = "班级";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn4.HeaderText = "可住人数";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YCount";
            this.dataGridViewTextBoxColumn5.HeaderText = "已住人数";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "zt";
            this.Column10.HeaderText = "状态";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.Width = 40;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.NullValue = "修改班级";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "操作";
            this.Column2.Name = "Column2";
            this.Column2.Width = 93;
            // 
            // Column11
            // 
            dataGridViewCellStyle5.NullValue = "删除";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column11.HeaderText = "操作";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.Width = 93;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle6.NullValue = "详细信息";
            this.dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn3.HeaderText = "操作";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn3.Width = 93;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "导出Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_suseok_lcgl_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(822, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lanrens);
            this.Controls.Add(this.das);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_suseok_lcgl_2";
            this.Text = "Admin_suseok_lcgl_2";
            this.Load += new System.EventHandler(this.Admin_suseok_lcgl_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.das)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lanrens;
        private System.Windows.Forms.DataGridView das;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column11;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.Button button1;
    }
}