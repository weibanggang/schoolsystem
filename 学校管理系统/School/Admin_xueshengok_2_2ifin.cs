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
    public partial class Admin_xueshengok_2_2ifin : Form
    {
        int id = 0;
        public Admin_xueshengok_2_2ifin(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_xueshengok_2_2ifin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sh();
           
        }
        public void sh()
        {
            if(txtcq.Text=="")
            {
                MessageBox.Show("班级名称不能为空");
                return;
            }
            if (comzbr.Text == "")
            {
                MessageBox.Show("班主任名称不能为空");
                return;
            }
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "";
            }
             string sele = "select * from Class";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtcq.Text == dr["CName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();
            string my = "insert into Class Values(@CName,@Gid,0,@bzrname,@TTell,1)";
            SqlParameter[] p = {
                                new SqlParameter ("@CName",txtcq.Text),
                                new SqlParameter ("@Gid",id),
                                new SqlParameter ("@bzrname",comzbr.Text),
                                new SqlParameter ("@TTell",txtpwd.Text)
            };
            int s = DBHelper.ExecuteNonQuery(my,p);
            if(s>0)
            {
                string se = "select count(*) from Class where Gid=" + id;
                int sq = (int)DBHelper.ExecuteScalar(se);
                string se2 = "update Grade set Cclass=" + sq + " where ID=" + id;
                DBHelper.ExecuteNonQuery(se2);
                MessageBox.Show("添加成功");
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("添加失败");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
