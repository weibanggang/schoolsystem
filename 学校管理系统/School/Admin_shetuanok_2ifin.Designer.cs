namespace School
{
    partial class Admin_shetuanok_2ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_shetuanok_2ifin));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsada = new System.Windows.Forms.Label();
            this.btnst = new System.Windows.Forms.Button();
            this.btnzw = new System.Windows.Forms.Button();
            this.sj = new System.Windows.Forms.DateTimePicker();
            this.st = new System.Windows.Forms.ComboBox();
            this.zw = new System.Windows.Forms.ComboBox();
            this.btngo = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxh = new System.Windows.Forms.TextBox();
            this.bj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(289, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "入团时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(289, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "职位名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(289, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "社团名称：";
            // 
            // dsada
            // 
            this.dsada.AutoSize = true;
            this.dsada.Font = new System.Drawing.Font("宋体", 15F);
            this.dsada.Location = new System.Drawing.Point(41, 193);
            this.dsada.Name = "dsada";
            this.dsada.Size = new System.Drawing.Size(69, 20);
            this.dsada.TabIndex = 8;
            this.dsada.Text = "班级：";
            // 
            // btnst
            // 
            this.btnst.Location = new System.Drawing.Point(548, 73);
            this.btnst.Name = "btnst";
            this.btnst.Size = new System.Drawing.Size(42, 24);
            this.btnst.TabIndex = 16;
            this.btnst.Text = "添加";
            this.btnst.UseVisualStyleBackColor = true;
            this.btnst.Click += new System.EventHandler(this.btnst_Click);
            // 
            // btnzw
            // 
            this.btnzw.Location = new System.Drawing.Point(548, 131);
            this.btnzw.Name = "btnzw";
            this.btnzw.Size = new System.Drawing.Size(42, 25);
            this.btnzw.TabIndex = 16;
            this.btnzw.Text = "添加";
            this.btnzw.UseVisualStyleBackColor = true;
            this.btnzw.Click += new System.EventHandler(this.btnzw_Click);
            // 
            // sj
            // 
            this.sj.Font = new System.Drawing.Font("宋体", 12F);
            this.sj.Location = new System.Drawing.Point(396, 190);
            this.sj.Name = "sj";
            this.sj.Size = new System.Drawing.Size(143, 26);
            this.sj.TabIndex = 7;
            this.sj.Value = new System.DateTime(2017, 11, 2, 0, 0, 0, 0);
            this.sj.ValueChanged += new System.EventHandler(this.sj_ValueChanged);
            // 
            // st
            // 
            this.st.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.st.Font = new System.Drawing.Font("宋体", 12F);
            this.st.FormattingEnabled = true;
            this.st.Location = new System.Drawing.Point(396, 73);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(143, 24);
            this.st.TabIndex = 5;
            // 
            // zw
            // 
            this.zw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zw.Font = new System.Drawing.Font("宋体", 12F);
            this.zw.FormattingEnabled = true;
            this.zw.Location = new System.Drawing.Point(396, 132);
            this.zw.Name = "zw";
            this.zw.Size = new System.Drawing.Size(143, 24);
            this.zw.TabIndex = 6;
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(182, 265);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(87, 33);
            this.btngo.TabIndex = 8;
            this.btngo.Text = "提交";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(369, 265);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(87, 33);
            this.btnno.TabIndex = 9;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(41, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名：";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 12F);
            this.txtname.Location = new System.Drawing.Point(95, 132);
            this.txtname.MaxLength = 12;
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(188, 26);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "自动识别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(41, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "学号：";
            // 
            // txtxh
            // 
            this.txtxh.Font = new System.Drawing.Font("宋体", 12F);
            this.txtxh.Location = new System.Drawing.Point(95, 71);
            this.txtxh.MaxLength = 12;
            this.txtxh.Name = "txtxh";
            this.txtxh.Size = new System.Drawing.Size(143, 26);
            this.txtxh.TabIndex = 1;
            // 
            // bj
            // 
            this.bj.Font = new System.Drawing.Font("宋体", 12F);
            this.bj.Location = new System.Drawing.Point(95, 190);
            this.bj.MaxLength = 12;
            this.bj.Name = "bj";
            this.bj.ReadOnly = true;
            this.bj.Size = new System.Drawing.Size(188, 26);
            this.bj.TabIndex = 1;
            this.bj.Text = "自动识别";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_shetuanok_2ifin
            // 
            this.AcceptButton = this.btngo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zw);
            this.Controls.Add(this.st);
            this.Controls.Add(this.sj);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnzw);
            this.Controls.Add(this.btnst);
            this.Controls.Add(this.txtxh);
            this.Controls.Add(this.bj);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_shetuanok_2ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加社团学员";
            this.Load += new System.EventHandler(this.Admin_shetuanok_2ifin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dsada;
        private System.Windows.Forms.Button btnst;
        private System.Windows.Forms.Button btnzw;
        private System.Windows.Forms.DateTimePicker sj;
        private System.Windows.Forms.ComboBox st;
        private System.Windows.Forms.ComboBox zw;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxh;
        private System.Windows.Forms.TextBox bj;
        private System.Windows.Forms.Button button1;
    }
}