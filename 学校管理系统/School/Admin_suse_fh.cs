using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_suse_fh : Form
    {
        string LName;
        string FH;
        int fhid;

        int s = 0;
        public Admin_suse_fh(int Fhid,string Lname,string fh)
        {
            InitializeComponent();
            this.LName = Lname;
            this.FH = fh;
            this.fhid = Fhid;
        }
        public Admin_suse_fh(int Fhid, string Lname, string fh,int s)
        {
            InitializeComponent();
            this.LName = Lname;
            this.FH = fh;
            this.fhid = Fhid;
            this.s = s;
        }

        private void Admin_suse_fh_Load(object sender, EventArgs e)
        {
            if (s == 0)
            {
                lansw.Text = string.Format("请选择{0}楼,{1}宿舍入住的班级", LName, FH);
            }

            else
            {
                lansw.Text = string.Format("请选择{0}楼,{1}宿舍修改的班级", LName, FH);
                this.Text = "修改班级设定";
            }
                
            string st = "select * from Class";
            DataSet ds = DBHelper.GetDataSet(st);
            coms.DisplayMember = "CName";
            coms.ValueMember = "ID";
            coms.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (coms.Text == "")
            {
                MessageBox.Show("班级不能为空");
                return;
            }
            string se = "update tb_Dormitory set BCount='"+coms.Text+ "' , zt=1 where ID=" + fhid;
            int s = DBHelper.ExecuteNonQuery(se);
            if (s > 0)
            {
                MessageBox.Show("提交成功");
                this.DialogResult = DialogResult.OK;
            }
                
            else
                MessageBox.Show("提交失败");
        }
    }
}
