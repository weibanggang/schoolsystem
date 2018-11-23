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
    public partial class Admin_suse_lh : Form
    {
        string name;
        public Admin_suse_lh(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Admin_suse_lh_Load(object sender, EventArgs e)
        {
            lansw.Text= "请输入"+name+"栋楼名称";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("楼名不能为空");
                return;
            }
            string se = "select Name from Dormitory";
            SqlDataReader drs = DBHelper.ExecuteReader(se);
            while (drs.Read())
            {
                if (drs["Name"].ToString() == txtname.Text)
                {
                    MessageBox.Show("已存在该公寓名！", "提示", MessageBoxButtons.OK);
                    drs.Close();
                    return;
                }
            }
            drs.Close();
            string upda = "update Dormitory set Name=@Name where DName='"+ name+"'";
            SqlParameter[] p = { new SqlParameter("@Name", txtname.Text) };
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
