using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_Adminok_1ifin_ifin : Form
    {
        public Admin_Adminok_1ifin_ifin()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if(txtlx.Text=="")
            {
                MessageBox.Show("名称不能为空");
                return;
            }
            string sele = "select * from AdminType";
            SqlDataReader drss = DBHelper.ExecuteReader(sele);
            while (drss.Read())
            {
                if (txtlx.Text == drss["TypeName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    drss.Close();
                    return;
                }

            }
            drss.Close();
            string into = "insert into AdminType Values(@TypeName)";
            SqlParameter[] p = { new SqlParameter("@TypeName", txtlx.Text) };
            int dr = DBHelper.ExecuteNonQuery(into, p);
            if(dr>0)
            {
                if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.Close();

            }
            else
            {
                if ((MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.Close();
            }
            
        }

        private void Admgly_tjlx1__Load(object sender, EventArgs e)
        {
            txtlx.Focus();
        }
    }
}
