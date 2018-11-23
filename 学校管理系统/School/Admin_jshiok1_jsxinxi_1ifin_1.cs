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
    public partial class Admin_jshiok1_jsxinxi_1ifin_1 : Form
    {
        public Admin_jshiok1_jsxinxi_1ifin_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("职位名称不能为空");
                return;
            }


            string sele = "select * from TeaPosition";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtname.Text == dr["PName"].ToString())
                {
                    MessageBox.Show("已有职位名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string sql = "insert into TeaPosition values(@PName)";
            SqlParameter[] p = { new SqlParameter("@PName", txtname.Text) };
            int ds = DBHelper.ExecuteNonQuery(sql, p);
            if (ds > 0)
            {
                if ((MessageBox.Show("添加成功") == DialogResult.OK))
                    this.Close();
            }
            else
            {
                if ((MessageBox.Show("添加失败") == DialogResult.OK))
                    this.Close();
            }
        }

        private void Admin_jshiok1_jsxinxi_1ifin_1_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }
    }
}
