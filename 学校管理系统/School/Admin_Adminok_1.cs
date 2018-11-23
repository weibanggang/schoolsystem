using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm;

namespace School
{
    public partial class Admin_Adminok_1 : Form
    {
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        string gly;//管理员
         string uid;//管理员
        public Admin_Adminok_1(string uid,string gly)
        {
            InitializeComponent();
            this.gly = gly;
            this.uid = uid;
        }
        
        private void Admin_Adminok_1_Load(object sender, EventArgs e)
        {
            this.skin.SkinFile = Application.StartupPath + @"\Skins\office2007.ssk";
            panel3.Controls.Add(new dlqk(gly));
            panel1.Controls.Add(new gongkao());
           Formtq(new FrmMain());
             KeyPreview = true;
           this.Focus();
           


        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panzhuangti;
            frm.Show();

        }
         public void Formtq(Form frm)
        {
            pantq.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = pantq;
            frm.Show();

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DBHelper.Hide(this);
        }
        

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            Admin_xueshengok_1 frm = new Admin_xueshengok_1("高级管理");
            FormShow(frm);
        }
        

        private void 社团管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new Admin_shetuanok_1("高级管理"));
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new Admin_tushuok_1("高级管理"));
     
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panzhuangti.Visible = false;
          
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new frmAAxgpwd(uid).ShowDialog() == DialogResult.OK)
            {
                DBHelper.Hide(this);
            }

        }

        private void Admin_Adminok_1_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.F1:
            //        panzhuangti.Visible = true;
            //        Admin_xueshengok_1 frm = new School.Admin_xueshengok_1("2");
            //        FormShow(frm);
            //        break;
            //    case Keys.F2:
            //        panzhuangti.Visible = true;
            //        Admin_pugongok1 frms = new School.Admin_pugongok1("2");
            //        FormShow(frms);
            //        break;
            //    case Keys.F3:
            //        panzhuangti.Visible = true;
            //        Admin_jshiok1 frma = new School.Admin_jshiok1("2");
            //        FormShow(frma);
            //        break;
            //    case Keys.F4:
            //        panzhuangti.Visible = true;
            //        Admin_suseok_1 frmd = new School.Admin_suseok_1("管理员");
            //        FormShow(frmd);
            //        break;
            //    case Keys.F5:
            //        panzhuangti.Visible = true;
            //        Admin_shetuanok_1 frmg = new School.Admin_shetuanok_1("2");
            //        FormShow(frmg);
            //        break;
            //    case Keys.F6:
            //        panzhuangti.Visible = true;
            //        Admin_tushuok_1 frmw = new School.Admin_tushuok_1("2");
            //        FormShow(frmw);
            //        break;
            //}
        }
        
        

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new Admin_pugongok1("高级管理"));
        }

        private void 教师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new Admin_jshiok1("高级管理"));
        }

       
        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            Admin_suseok_1 frm = new School.Admin_suseok_1("高级管理");
            FormShow(frm);
           
           
        }

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new Admin_Adminok_1_go());


        }
        

        private void 学生会管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panzhuangti.Visible = true;
            FormShow(new  Admin_xshok("高级管理"));
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 版本更新().ShowDialog();
        }
        

        private void panzhuangti_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textgk.Text.Trim() == null) {
                MessageBox.Show("公告不能为空");
                return;
            }
            string into = "insert into gk values(@gname)";
            SqlParameter[] p = { new SqlParameter("@gname", textgk.Text) };
            if (DBHelper.ExecuteNonQuery(into, p) > 0) {
                panel1.Controls.Clear();
                panel1.Controls.Add(new gongkao());
                MessageBox.Show("发布成功");
                textgk.Text = "";
            }
        }
    }
}
