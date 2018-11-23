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
    public partial class Admin_suseok_1 : Form
    {
        string id;//管理员
        string uid;//账号
        public Admin_suseok_1(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Admin_suseok_1(string id, string uid)
        {
            InitializeComponent();
            this.id = id;
            this.uid = uid;
        }
        public Admin_suseok_1()
        {
            InitializeComponent();
           
        }
        
        public  void FormShow(Form frm)
        {
            try
            {
                panel3.Controls.Clear();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.Parent = panel3;
                frm.Show();
            }
            catch(Exception)
            {

            }
            

        }
        private void glsuse2_Load(object sender, EventArgs e)
        {

            mas();
        }
        public void mas()
        {
            panel4.Controls.Add(new dlqk("宿舍管理"));
            panel5.Controls.Add(new gongkao());
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            FormShow(new Admin_suseok_2());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Admin_suseok_lcgl frm = new Admin_suseok_lcgl();
            FormShow(frm);
           
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (id != "高级管理")
                DBHelper.Hide(this);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (id != "高级管理")
                new 版本更新().ShowDialog();
        }
        

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            FormShow(new Admin_suseok_5nw());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            FormShow(new Admin_suseok_weixiu_1());
        }
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            FormShow(new Admin_suseok_sfok_1());
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
            panel3.Visible = false;
        }
    }
}
