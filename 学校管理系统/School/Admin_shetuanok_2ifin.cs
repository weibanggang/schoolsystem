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
    public partial class Admin_shetuanok_2ifin : Form
    {
        public Admin_shetuanok_2ifin()
        {
            InitializeComponent();
        }

        private void btnst_Click(object sender, EventArgs e)
        {
            Admin_shetuanok_2ifin_1ifin ss = new Admin_shetuanok_2ifin_1ifin();
            ss.ShowDialog();
            DDB();
        }

        private void btnzw_Click(object sender, EventArgs e)
        {
            Admin_shetuanok_2ifin_2ifin ss = new Admin_shetuanok_2ifin_2ifin();
            ss.ShowDialog();
            DDB();
        }
        string name = null;
        string bjs = null;
        private void Admin_shetuanok_2ifin_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            DDB();
        }
        public void DDB()
        {
            #region#类型
            string sele1 = "select * from CollegeType";
            DataSet ds1 = DBHelper.GetDataSet(sele1);
            st.DisplayMember = "TypeName";
            st.ValueMember = "ID";
            st.DataSource = ds1.Tables[0];




            string sele2 = "select * from CollegePosition";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            zw.DisplayMember = "CPName";
            zw.ValueMember = "ID";
            zw.DataSource = ds2.Tables[0];
            #endregion
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "自动识别")
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            if (bj.Text == "")
            {
                MessageBox.Show("班级不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
          if (st.Text == "")
            {
                MessageBox.Show("名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }if (zw.Text == "")
            {
                MessageBox.Show("职位不能为空", "提示", MessageBoxButtons.OK);
                return;
            }

               
            string into = "insert into CEmplnfo(TeacherID,SID,[Name],[CollegeName],[CPNameID],[CJoinTime])values(@TeacherID,@SID,@Name,@CollegeName,@CPNameID,@CJoinTime)";
            SqlParameter[] p =
            {
                new SqlParameter ("@Name",txtname.Text.ToString()),
                new SqlParameter ("@TeacherID",bj.Text),
                 new SqlParameter ("@SID",txtxh.Text),
                new SqlParameter ("@CollegeName",st.SelectedValue),
                new SqlParameter ("@CPNameID",zw.SelectedValue),
                new SqlParameter ("@CJoinTime",sj.Value.ToString())
            };
            int d = DBHelper.ExecuteNonQuery(into,p);
            if (d > 0)
            {
            MessageBox.Show("录入成功","提示",MessageBoxButtons.OK);
                this.Close();
            }
                
            else
                MessageBox.Show("失败成功", "提示", MessageBoxButtons.OK);
        }
       

        private void sj_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtxh.Text == "")
            {
                MessageBox.Show("学号不能为空");
                return;
            }
            string sq = "select* from Stulnfo where TeacherID = '" + txtxh.Text + "'";

            if (DBHelper.ExecuteScalar(sq) != null)
            {
                string str = "select * from Stulnfo where TeacherID=" + txtxh.Text;
                SqlDataReader dr = DBHelper.ExecuteReader(str);
                while (dr.Read())
                {
                    name = dr["SStudentName"].ToString();
                    bjs = dr["Cid"].ToString();
                }
                dr.Close();
                string classw = "select CName from Class where ID=" + bjs;
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
    }
}
