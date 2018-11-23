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
    public partial class Admin_Adminok_1ifin : Form
    {
        public Admin_Adminok_1ifin()
        {
            InitializeComponent();
        }
        
        private void Admglgl_3tj__Load(object sender, EventArgs e)
        {

            comzt.SelectedIndex=comlx.SelectedIndex = 0;
            txtName.Focus();
         

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                lanname.Text = "姓名不能为空";
                return;
            }
            if(txtuid.Text=="")
            {
                lanname.Text = "账号不能为空";
                return;
            }
            if(txtpwd.Text=="")
            {
                lanname.Text = "密码不能为空";
                return;
            }
            string sele = "select Uid from AdminInfo";
            SqlDataReader drs = DBHelper.ExecuteReader(sele);
            while (drs.Read())
            {
                if (txtuid.Text == drs["Uid"].ToString())
                {
                    MessageBox.Show("已有该账号");
                    drs.Close();
                    return;
                }

            }
            drs.Close();
            string into = "insert into AdminInfo([Name],[Tid],Sex,[Uid],[Pwd],[State]) Values(@Name,@Tid,@Sex,@Uid,@Pwd,@State)";
            SqlParameter[] p = {
                new SqlParameter("@Name", txtName.Text),
                 new SqlParameter("@Sex", sex),
                new SqlParameter("@Tid", comlx.Text),
                new SqlParameter("@Uid", txtuid.Text),
                new SqlParameter("@Pwd", DBHelper.Md5(txtpwd.Text)),
                new SqlParameter("@State", comzt.Text)
            };
            int dr = DBHelper.ExecuteNonQuery(into, p);
            if (dr > 0)
            {
                if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
                    this.Close();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lanname.Text = "*";
        }

        private void comlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        string sex = "男";
        private void radioButton1_Click(object sender, EventArgs e)
        {
            sex = "男";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            sex = "女";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuid_TextChanged(object sender, EventArgs e)
        {
            lanname.Text = "*";
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            lanname.Text = "*";
        }
    }
}
