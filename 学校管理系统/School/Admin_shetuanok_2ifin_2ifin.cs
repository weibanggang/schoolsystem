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
    public partial class Admin_shetuanok_2ifin_2ifin : Form
    {
        public Admin_shetuanok_2ifin_2ifin()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("职位名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from CollegePosition";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtName.Text == dr["CPName"].ToString())
                {
                    MessageBox.Show("已有职位名称", "提示", MessageBoxButtons.OK);
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string into = "insert into CollegePosition([CPName]) Values(@CPName)";
            SqlParameter[] p = {
                new SqlParameter("@CPName", txtName.Text)
            };
            int dr2 = DBHelper.ExecuteNonQuery(into, p);
            if (dr2 > 0)
            {
                if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("添加失败");
        }


        private void Admin_shetuanok_2ifin_2ifin_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
