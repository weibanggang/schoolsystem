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
    public partial class Admin_shetuanok_2ifin_1ifin : Form
    {
        public Admin_shetuanok_2ifin_1ifin()
        {
            InitializeComponent();
        }


        private void btngo_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                MessageBox.Show("社团名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from CollegeType";
            SqlDataReader drww = DBHelper.ExecuteReader(sele);
            while (drww.Read())
            {
                if (txtName.Text == drww["TypeName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    drww.Close();
                    return;
                }

            }
            drww.Close();


            string into = "insert into CollegeType([TypeName]) Values(@TypeName)";
            SqlParameter[] p = {
                new SqlParameter("@TypeName", txtName.Text)
            };
            int dr = DBHelper.ExecuteNonQuery(into, p);
            if (dr > 0)
            {
                if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                   
                    this.Close();
            }
            else
                MessageBox.Show("添加失败");

        }

        private void Admin_shetuanok_2ifin_1ifin_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
