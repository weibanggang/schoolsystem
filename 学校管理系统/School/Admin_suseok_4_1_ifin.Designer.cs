namespace School
{
    partial class Admin_suseok_4_1_ifin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_suseok_4_1_ifin));
            this.cuanghao = new System.Windows.Forms.NumericUpDown();
            this.fanghao = new System.Windows.Forms.ComboBox();
            this.ruzhu = new System.Windows.Forms.DateTimePicker();
            this.txtph = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.cmGrade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cuanghao)).BeginInit();
            this.SuspendLayout();
            // 
            // cuanghao
            // 
            this.cuanghao.Location = new System.Drawing.Point(335, 50);
            this.cuanghao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cuanghao.Name = "cuanghao";
            this.cuanghao.Size = new System.Drawing.Size(142, 21);
            this.cuanghao.TabIndex = 17;
            this.cuanghao.Tag = "";
            this.cuanghao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fanghao
            // 
            this.fanghao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fanghao.FormattingEnabled = true;
            this.fanghao.Location = new System.Drawing.Point(335, 81);
            this.fanghao.Name = "fanghao";
            this.fanghao.Size = new System.Drawing.Size(142, 20);
            this.fanghao.TabIndex = 18;
            // 
            // ruzhu
            // 
            this.ruzhu.Location = new System.Drawing.Point(335, 22);
            this.ruzhu.Name = "ruzhu";
            this.ruzhu.Size = new System.Drawing.Size(142, 21);
            this.ruzhu.TabIndex = 15;
            this.ruzhu.Value = new System.DateTime(2018, 3, 27, 0, 0, 0, 0);
            // 
            // txtph
            // 
            this.txtph.Location = new System.Drawing.Point(93, 51);
            this.txtph.MaxLength = 11;
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(142, 21);
            this.txtph.TabIndex = 14;
            this.txtph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtph_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(93, 24);
            this.txtname.MaxLength = 12;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(142, 21);
            this.txtname.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "联系方式:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "床号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "入住时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "班级:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "房号:";
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(508, 19);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(77, 31);
            this.btnno.TabIndex = 19;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(508, 69);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(77, 32);
            this.btngo.TabIndex = 20;
            this.btngo.Text = "提交";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // cmGrade
            // 
            this.cmGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmGrade.FormattingEnabled = true;
            this.cmGrade.Location = new System.Drawing.Point(93, 82);
            this.cmGrade.Name = "cmGrade";
            this.cmGrade.Size = new System.Drawing.Size(142, 20);
            this.cmGrade.TabIndex = 18;
            // 
            // Admin_suseok_4_1_ifin
            // 
            this.AcceptButton = this.btngo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(611, 133);
            this.Controls.Add(this.cuanghao);
            this.Controls.Add(this.cmGrade);
            this.Controls.Add(this.fanghao);
            this.Controls.Add(this.ruzhu);
            this.Controls.Add(this.txtph);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btngo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_suseok_4_1_ifin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加住宿";
            this.Load += new System.EventHandler(this.Admin_suseok_4_1_ifin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuanghao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cuanghao;
        private System.Windows.Forms.ComboBox fanghao;
        private System.Windows.Forms.DateTimePicker ruzhu;
        private System.Windows.Forms.TextBox txtph;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.ComboBox cmGrade;
    }
}