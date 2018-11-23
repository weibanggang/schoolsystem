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
    public partial class Admin_xueshengok2_1if_1if : Form
    {
        public Admin_xueshengok2_1if_1if()
        {
            InitializeComponent();
        }

        private void btnnj_Click(object sender, EventArgs e)
        {
            Admin_xueshengok2_1if_1if_1 ss = new Admin_xueshengok2_1if_1if_1();
            ss.ShowDialog();
            sele();
        }

        private void Admin_xueshengok2_1if_1if_Load(object sender, EventArgs e)
        {
            txtcq.Focus();
            sele();
        }
        public void sele()
        {
            cmGrade.Controls.Clear();
            string se = "select * from Grade";
            DataSet dr = DBHelper.GetDataSet(se);
           cmGrade.DisplayMember= "GName";
            cmGrade.ValueMember = "ID";
             cmGrade.DataSource = dr.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmGrade.Text == "")
            {
                MessageBox.Show("年级不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (txtcq.Text == "")
            {
                MessageBox.Show("班级不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (comzbr.Text == "")
            {
                MessageBox.Show("班主任名字不能为空", "提示", MessageBoxButtons.OK);
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
            string into = "insert into Class Values(@CName,@Gid,0,@bzrname,@TTell,1)";
            SqlParameter[] p = {
                new SqlParameter("@CName", txtcq.Text.ToString()),
                new SqlParameter("@Gid", cmGrade.SelectedValue.ToString()),
                new SqlParameter("@bzrname", comzbr.Text.ToString()),
                new SqlParameter("@TTell", txtpwd.Text.ToString())
            };
            int s = DBHelper.ExecuteNonQuery(into, p);
            if (s > 0)
            {
                string se = "select count(*) from Class where Gid=" + cmGrade.SelectedValue;
                int sq = (int)DBHelper.ExecuteScalar(se);
                string se2 = "update Grade set Cclass="+sq+ " where ID=" + cmGrade.SelectedValue;
                DBHelper.ExecuteNonQuery(se2);
                MessageBox.Show("添加成功");
                this.DialogResult = DialogResult.OK;
            }

            else
                MessageBox.Show("添加失败");
        }

        private void cmGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
