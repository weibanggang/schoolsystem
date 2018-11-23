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
    public partial class Admin_xsh3 : Form
    {
        public Admin_xsh3()
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
            string sele = "select * from AssPName";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtName.Text == dr["PName"].ToString())
                {
                    MessageBox.Show("已有职位名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string into = "insert into AssPName([PName]) Values(@PName)";
            SqlParameter[] p = {
                new SqlParameter("@PName", txtName.Text)
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

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_xsh3_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
