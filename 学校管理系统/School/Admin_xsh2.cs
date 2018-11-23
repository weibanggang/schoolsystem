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
    public partial class Admin_xsh2 : Form
    {
        public Admin_xsh2()
        {
            InitializeComponent();
        }

        private void btnst_Click(object sender, EventArgs e)
        {
            new Admin_xsh4().ShowDialog();
            sele();
        }
        public void sele()
        {
            string sele1 = "select * from AssociationType order by ID";
            DataSet dr = DBHelper.GetDataSet(sele1);
            st.DisplayMember = "TypeName";
            st.ValueMember = "ID";
            st.DataSource = dr.Tables[0];
            string sele2 = "select * from AssPName order by ID";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            zw.DisplayMember = "PName";
            zw.ValueMember = "ID";
            zw.DataSource = ds2.Tables[0];

        }
        private void btnzw_Click(object sender, EventArgs e)
        {
            new Admin_xsh3().ShowDialog();
            sele();
        }

        private void Admin_xsh2_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            sele();
        }
       

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (st.Text == "")
            {
                MessageBox.Show("部门不能为空");
                return;
            }
            if (zw.Text == "")
            {
                MessageBox.Show("职位不能为空");
                return;
            }
            if (txtname.Text == "自动识别")
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            string sqq = "select count(*) from Stulnfo where TeacherID=" + txtxh.Text + " and SStudentName='" + txtname.Text + "'";
            int s = (int)DBHelper.ExecuteScalar(sqq);
            if (s > 0)
            {
                string into = "insert into AssEmpInfo([Name],[AssID],[bj],[Tid],[Pid]) values(@Name,@AssID,@bj,@Tid,@Pid)";
                SqlParameter[] p =
                {
                new SqlParameter("@Name",txtname.Text.ToString()),
                new SqlParameter("@AssID",txtxh.Text),
                new SqlParameter("@bj",bj.Text),
                new SqlParameter("@Tid",st.SelectedValue),
                new SqlParameter("@Pid",zw.SelectedValue)
            };
                int q = DBHelper.ExecuteNonQuery(into, p);
                if (q > 0)
                {
                    MessageBox.Show("录入成功");
                    txtxh.Text = "";
                }

                else
                    MessageBox.Show("录入失败", "提示", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("姓名与学号没有匹配！");
                return;
            }
        }
        string name = null;
        string bjs = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtxh.Text == "")
            {
                MessageBox.Show("学号不能为空");
                return;
            }
            string sq = "select* from Stulnfo where TeacherID = "+ txtxh.Text;
            int DS = (int)DBHelper.ExecuteScalar(sq);
            if (DS>0)
            {
                string str = "select * from Stulnfo where TeacherID="+ txtxh.Text;
                SqlDataReader dr = DBHelper.ExecuteReader(str);
            while (dr.Read())
            {
                name = dr["SStudentName"].ToString();
                bjs = dr["Cid"].ToString();
            }
            dr.Close();
            string classw = "select CName from Class where ID="+bjs;
            SqlDataReader drs = DBHelper.ExecuteReader(classw);
            while (drs.Read())
            {
                bjs = drs["CName"].ToString();
            }
            drs.Close();
            txtname.Text = name;
            bj.Text = bjs;
            }
            else
            {
                MessageBox.Show("学号输入有误！");
                return;
            }
        }

        private void txtxh_TextChanged(object sender, EventArgs e)
        {
            txtname.Text = bj.Text = "自动识别";
        }
    }
}
