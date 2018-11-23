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

namespace School
{
    public partial class Admin_jshiok1_jsxinxi_2ifin : Form
    {
        public Admin_jshiok1_jsxinxi_2ifin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("类型名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from TeaType";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtname.Text == dr["TypeName"].ToString())
                {
                    MessageBox.Show("已有该名称", "提示", MessageBoxButtons.OK);
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string sql = "insert into TeaType values(@PName)";
            SqlParameter[] p = { new SqlParameter("@PName", txtname.Text) };
            int ds = DBHelper.ExecuteNonQuery(sql, p);
            if (ds > 0)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_jshiok1_jsxinxi_2ifin_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }
    }
}
