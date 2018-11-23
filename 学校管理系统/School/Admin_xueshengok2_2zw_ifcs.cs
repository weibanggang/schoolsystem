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
    public partial class Admin_xueshengok2_2zw_ifcs : Form
    {
        public Admin_xueshengok2_2zw_ifcs()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from StuPosition";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtName.Text == dr["PName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string into = "insert into StuPosition Values(@CName,'')";
            SqlParameter[] p = {
                new SqlParameter("@CName", txtName.Text.ToString())
            };
            int s = DBHelper.ExecuteNonQuery(into, p);
            if (s > 0)
                MessageBox.Show("添加成功");
            this.DialogResult = DialogResult.OK;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void Admin_xueshengok2_2zw_ifcs_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
