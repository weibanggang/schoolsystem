using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School
{
    public partial class Admin_xueshengok_2 : Form
    {
        public Admin_xueshengok_2()
        {
            InitializeComponent();
        }

        private void Admin_xueshengok_2_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1());
            Fse();
        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panzhuangti;
            frm.Show();
        }
        public void Fse()
        {
            string Grade = "select * from Grade";
            DataSet ds = DBHelper.GetDataSet(Grade);
            comname.DisplayMember = "GName";
            comname.ValueMember = "ID";
            comname.DataSource = ds.Tables[0];
            string Grade1 = "select * from Grade";
            DataSet ds1 = DBHelper.GetDataSet(Grade1);
            comnqs.DisplayMember = "GName";
            comnqs.ValueMember = "ID";
            comnqs.DataSource = ds1.Tables[0];
            string Class = "select * from Class";
            DataSet Classsw = DBHelper.GetDataSet(Class);
            combj.DisplayMember = "CName";
            combj.ValueMember = "ID";
            combj.DataSource = Classsw.Tables[0];
            string Colle = "select * from StuPosition";
            DataSet Colles = DBHelper.GetDataSet(Colle);
           comzws.DisplayMember = "PName";
           comzws.ValueMember = "ID";
            comzws.DataSource = Colles.Tables[0];


        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1_1("姓名", txtxm.Text.ToString()));
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        public void xm()
        {
            string name = "select SStudentName,ID from Stulnfo where Cid=" + comname.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(name);
           comlc.DisplayMember = "SStudentName";
           comlc.ValueMember = "ID";
            comlc.DataSource = ds.Tables[0];
        
        }
        public void xh()
        {
            string name = "select TeacherID,ID from Stulnfo where ID=" + comlc.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(name);
           comfh.DisplayMember = "TeacherID";
           comfh.ValueMember = "ID";
            comfh.DataSource = ds.Tables[0];

        }
        public void bj()
        {
            string bjs = "select * from Class where Gid=" + comname.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(bjs);
            comlm.DisplayMember = "CName";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
            

        }
        private void comname_SelectedIndexChanged(object sender, EventArgs e)
        {
            bj();
        }
       
        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
                xm();
        }

        private void comlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            xh();
        }

        private void comlcs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comfh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bjs = "select * from Class where Gid=" + comname.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(bjs);
            comlcs.DisplayMember = "CName";
            comlcs.ValueMember = "ID";
            comlcs.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1_1("班级", combj.SelectedValue.ToString()));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1_1("年级", comnqs.SelectedValue.ToString()));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1_1("职位", comzws.SelectedValue.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_2_1());
        }
    }
}
