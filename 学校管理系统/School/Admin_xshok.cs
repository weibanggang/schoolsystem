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
    public partial class Admin_xshok : Form
    {
        string id;
        string uid;
        public Admin_xshok(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Admin_xshok(string id,string uid)
        {
            InitializeComponent();
            this.id = id;
            this.uid = uid;
        }
        public void Formshow(Form frm)
        {
            panzhus.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhus;
            frm.Show();
        }

        private void Admin_xshok_Load(object sender, EventArgs e)
        {
            mas();
        }
        public void mas()
        {
            panel4.Controls.Add(new dlqk("学生会管理"));
            panel3.Controls.Add(new gongkao());
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panzhus.Visible = true;
            Formshow(new Admin_xshok_1());
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panzhus.Visible = true;
            Formshow(new Admin_xshok_2());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (id != "高级管理") { 
                if (new frmAAxgpwd(uid).ShowDialog() == DialogResult.OK)
            {
                DBHelper.Hide(this);
            }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           if(id!="高级管理")
            new 版本更新().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("反馈失败");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panzhus.Visible = false;
        }
    }
}
