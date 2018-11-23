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
    public partial class Admin_xsh4 : Form
    {
        public Admin_xsh4()
        {
            InitializeComponent();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("社团名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string into = "insert into AssociationType([TypeName]) Values(@TypeName)";
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
    }
}
