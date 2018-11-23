namespace School
{
    partial class Admin_Adminok_1ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Adminok_1ifin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comlx = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lanname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.comzt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(163, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "账号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(163, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(163, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "状态:";
            // 
            // comlx
            // 
            this.comlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comlx.Font = new System.Drawing.Font("宋体", 12F);
            this.comlx.FormattingEnabled = true;
            this.comlx.Items.AddRange(new object[] {
            "管理员",
            "教师管理",
            "学生管理",
            "员工管理",
            "图书管理",
            "社团管理",
            "宿舍管理",
            "学生会管理"});
            this.comlx.Location = new System.Drawing.Point(228, 40);
            this.comlx.Name = "comlx";
            this.comlx.Size = new System.Drawing.Size(208, 24);
            this.comlx.TabIndex = 1;
            this.comlx.TabStop = false;
            this.comlx.SelectedIndexChanged += new System.EventHandler(this.comlx_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(228, 86);
            this.txtName.MaxLength = 12;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtuid
            // 
            this.txtuid.Font = new System.Drawing.Font("宋体", 12F);
            this.txtuid.Location = new System.Drawing.Point(228, 176);
            this.txtuid.MaxLength = 15;
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(208, 26);
            this.txtuid.TabIndex = 2;
            this.txtuid.TextChanged += new System.EventHandler(this.txtuid_TextChanged);
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtpwd.Location = new System.Drawing.Point(228, 220);
            this.txtpwd.MaxLength = 20;
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(208, 26);
            this.txtpwd.TabIndex = 3;
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lanname
            // 
            this.lanname.AutoSize = true;
            this.lanname.Font = new System.Drawing.Font("新宋体", 9F);
            this.lanname.ForeColor = System.Drawing.Color.Red;
            this.lanname.Location = new System.Drawing.Point(447, 228);
            this.lanname.Name = "lanname";
            this.lanname.Size = new System.Drawing.Size(11, 12);
            this.lanname.TabIndex = 0;
            this.lanname.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(163, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "性别:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton1.Location = new System.Drawing.Point(228, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton2.Location = new System.Drawing.Point(276, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(335, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comzt
            // 
            this.comzt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comzt.Font = new System.Drawing.Font("宋体", 12F);
            this.comzt.FormattingEnabled = true;
            this.comzt.Items.AddRange(new object[] {
            "可用",
            "禁用"});
            this.comzt.Location = new System.Drawing.Point(228, 260);
            this.comzt.Name = "comzt";
            this.comzt.Size = new System.Drawing.Size(208, 24);
            this.comzt.TabIndex = 1;
            this.comzt.TabStop = false;
            this.comzt.SelectedIndexChanged += new System.EventHandler(this.comlx_SelectedIndexChanged);
            // 
            // Admin_Adminok_1ifin
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comzt);
            this.Controls.Add(this.comlx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lanname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Adminok_1ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加管理员";
            this.Load += new System.EventHandler(this.Admglgl_3tj__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comlx;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lanname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comzt;
    }
}