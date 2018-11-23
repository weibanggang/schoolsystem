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
    public partial class Admin_xueshengok2_2if_1if : Form
    {
        int id;
        public Admin_xueshengok2_2if_1if(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("班级名称不能为空","提示",MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from Class";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtName.Text == dr["CName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();
            string upda = "update Class set CName=@CName where ID="+id;
            SqlParameter[] p = { new SqlParameter("@CName", txtName.Text) };
            if (DBHelper.ExecuteNonQuery(upda, p) > 0)
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
