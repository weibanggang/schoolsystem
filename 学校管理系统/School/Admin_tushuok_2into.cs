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
    public partial class Admin_tushuok_2into : Form
    {
        public Admin_tushuok_2into()
        {
            InitializeComponent();
        }

        private void btnhuanzhi_Click(object sender, EventArgs e)
        {
            
        }
        
        string jieshushenf = "学生";
        
        public void into(int jiehuan)
        {
            if (jiehuan == 0)
            {
                string into = "insert into BorrowBook([IDT],[LenTime],[huihuan],[xuehao],[BID]) Values(@IDT,@LenTime,@Return,@xuehao,@BID)";
                SqlParameter[] p = {
                new SqlParameter("@IDT",  jieshushenf),//身份
                new SqlParameter("@LenTime", sjjs.Value),
                new SqlParameter("@Return", jiehuan),
                new SqlParameter("@xuehao", xhjs.Text),
                new SqlParameter("@BID", bhjs.Text)
            };
                int dr = DBHelper.ExecuteNonQuery(into, p);
                if (dr > 0)
                {
                    MessageBox.Show("录入成功", "提示", MessageBoxButtons.OK);
                    xhjs.Text = "";
                    bhjs.Text = "";
                    xhjs.Focus();
                }
                else
                    MessageBox.Show("录入失败");
            }
            if (jiehuan == 1)
            {
                string sw = "select count(*) from BorrowBook  where huihuan=0 and BID=@BID";
                SqlParameter[] ps = {
                    new SqlParameter("@BID", bhhs.Text)
                };
                int asd = (int)DBHelper.ExecuteScalar(sw, ps);
                if (asd == 0)
                {
                    MessageBox.Show("没有这本书");
                    return;
                }

                else
                {
                    string into = "update BorrowBook set huihuan=@Return , ReturnTime=@ReturnTime where BID=@BID";
                    SqlParameter[] p = {
                     new SqlParameter("@ReturnTime", sjhs.Value),
                    new SqlParameter("@Return", jiehuan),
                    new SqlParameter("@BID", bhhs.Text)
                     };
                    int dr = DBHelper.ExecuteNonQuery(into, p);
                    if (dr > 0)
                    {
                        MessageBox.Show("还书成功", "提示", MessageBoxButtons.OK);
                        bhhs.Text = null;
                        bhhs.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("还书失败");
                        return;
                    }
                }

            }
        }

        private void Admin_tushuok_2into_Load(object sender, EventArgs e)
        {

        }

        private void btnjiego_Click_1(object sender, EventArgs e)
        {
            if (xhjs.Text == "")
            {
                 MessageBox.Show("学号不能为空");
                xhjs.Focus();
                return;
            }
            if (bhjs.Text == "")
            {
                MessageBox.Show("借书编号不能为空");
                bhjs.Focus();
                return;
            }

            into(0);
        }

        private void btnjiezhongz_Click_1(object sender, EventArgs e)
        {
            xhjs.Text = "";
            bhjs.Text = "";
        }

        private void xueshengj_CheckedChanged(object sender, EventArgs e)
        {
            jieshushenf = "学生";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            jieshushenf = "教师";
        }

        private void btnhuan_Click_1(object sender, EventArgs e)
        {
            if(bhhs.Text=="")
            {
                MessageBox.Show("还书编号不能为空");
                return;
            }
            into(1);
        }

        private void btnhuanzhi_Click_1(object sender, EventArgs e)
        {
            bhhs.Text = "";
        }

        private void ranss_Click(object sender, EventArgs e)
        {
            jieshushenf = "员工";
        }
    }
}
