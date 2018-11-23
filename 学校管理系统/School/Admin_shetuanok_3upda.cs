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
    public partial class Admin_shetuanok_3upda : Form
    {
        public Admin_shetuanok_3upda()
        {
            InitializeComponent();
        }
        string name;
        public Admin_shetuanok_3upda(string name)
        {
            InitializeComponent();
            this.name = name;
        }


        private void Admin_shetuanok_3upda_Load(object sender, EventArgs e)
        {
            xxm.Focus();
            das();
            sele();
        }
        public void sele()
        {
            string seles = "select * from CEmplnfo where ID="+name;
            SqlDataReader dr = DBHelper.ExecuteReader(seles);
            while(dr.Read())
            {
                xxm.Text =dr["Name"].ToString();
                zw.SelectedIndex=(int)dr["CPNameID"]-1;
                sj.Value = Convert.ToDateTime(dr["CJoinTime"]);
                bj.Text = dr["TeacherID"].ToString();
                sd.SelectedIndex = (int)dr["CollegeName"] - 1;
                bianhao.Text =dr["ID"].ToString();
            }
            dr.Close();
        }
        public void das()
        {
            string seles = "select * from CollegePosition order by ID";
            DataSet ds = DBHelper.GetDataSet(seles);
            zw.DisplayMember = "CPName";
            zw.ValueMember = "ID";
            zw.DataSource = ds.Tables[0];

            string seles1 = "select * from CollegeType order by ID";
            DataSet ds1 = DBHelper.GetDataSet(seles1);
            sd.DisplayMember = "TypeName";
            sd.ValueMember = "ID";
            sd.DataSource = ds1.Tables[0];
        }

        
            

        private void button3_Click(object sender, EventArgs e)
        {
            if(xxm.Text=="")
            {
                return;
            }
            string up = "update CEmplnfo set CollegeName=@CollegeName,CPNameID=@CPNameID,CJoinTime=@CJoinTime where ID=" + bianhao.Text;
            SqlParameter[] p =
            {
                new SqlParameter("@CollegeName",sd.SelectedValue),
                new SqlParameter("@CPNameID",zw.SelectedValue),
                new SqlParameter("@CJoinTime",sj.Value.ToString())
            };
            int d = DBHelper.ExecuteNonQuery(up,p);
            if (d > 0)
            {
             MessageBox.Show("修改成功","提示",MessageBoxButtons.OK);
            this.Close();
            }
                
            else
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

