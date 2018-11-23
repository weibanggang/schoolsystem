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
    public partial class Admin_xueshengok2_1if_1if_1 : Form
    {
        public Admin_xueshengok2_1if_1if_1()
        {
            InitializeComponent();
        }
        int id = 0;
        public Admin_xueshengok2_1if_1if_1(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_xueshengok2_1if_1if_1_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                this.Text = "修改年级名称";
            }
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("名称不能为空");
                return;
            }
           string sele = "select * from Grade";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtName.Text == dr["GName"].ToString())
                {
                    MessageBox.Show("已有该名称");
                    dr.Close();
                    return;
                }

            }
            dr.Close();


            if (id == 0)
            {
               
                string into = "insert into Grade Values(@Name,0,0)";
                SqlParameter[] p = { new SqlParameter("@Name", txtName.Text) };
                int s = DBHelper.ExecuteNonQuery(into, p);
                if (s > 0)
                {
                    MessageBox.Show("添加成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("添加失败");
            }
            else
            {
                string upda = "update Grade set GName=@Name where ID=" + id;
                SqlParameter[] p = { new SqlParameter("@Name", txtName.Text) };
                int s = DBHelper.ExecuteNonQuery(upda, p);
                if (s > 0)
                {
                    MessageBox.Show("修改成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("修改失败");
            }
          
        }
        
    }
}
