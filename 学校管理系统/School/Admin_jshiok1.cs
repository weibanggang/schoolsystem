using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm;

namespace School
{
    public partial class Admin_jshiok1 : Form
    {
        string id;
        string uid;
        public Admin_jshiok1(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Admin_jshiok1(string id,string uid)
        {
            InitializeComponent();
            this.id = id;
            this.uid = uid;
        }
        public void FormShow(Form frm)
        {
            panzhus.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhus;
            frm.Show();

        }
        private void Admin_jshiok1_Load(object sender, EventArgs e)
        {
            mas();
        }
        public void mas() {
            panzhus.Controls.Clear();
            panel4.Controls.Add(new dlqk("教师管理"));
            panel2.Controls.Add(new gongkao());
            Formtq(new FrmMain());
        }
        public void Formtq(Form frm)
        {
            pantq.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = pantq;
            frm.Show();

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
             panzhus.Visible = true;
            FormShow(new Admin_jshiok1_1());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panzhus.Visible = true;
            FormShow(new Admin_jshiok1_2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panzhus.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (id != "高级管理")
            {
                if (new frmAAxgpwd(uid).ShowDialog() == DialogResult.OK)
                {
                    DBHelper.Hide(this);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (id != "高级管理")
                new 版本更新().ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (id != "高级管理")
                DBHelper.Hide(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == "高级管理")
                return;
                if (neirong.Text.Trim() == "")
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            if (zhuti.Text.Trim() == "")
            {
                MessageBox.Show("主题不能为空");
                return;
            }

            if (DBHelper.fangui(zhuti.Text, neirong.Text, uid) > 0)
            {
                zhuti.Text = neirong.Text = "";
                MessageBox.Show("反馈成功");
            }
            else {
                MessageBox.Show("反馈失败");
            }
        }
    }
}
