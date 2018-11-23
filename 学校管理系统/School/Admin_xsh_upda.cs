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
    public partial class Admin_xsh_upda : Form
    {
        public Admin_xsh_upda()
        {
            InitializeComponent();
        }
        string name;
        public Admin_xsh_upda(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Admin_xsh_upda_Load(object sender, EventArgs e)
        {
            xxm.Focus();
            das();
            sele();
        }
        public void sele()
        {
            string seles = "select * from AssEmpInfo where ID=" + name;
            SqlDataReader dr = DBHelper.ExecuteReader(seles);
            while (dr.Read())
            {
                xxm.Text = dr["Name"].ToString();
                txtbj.Text= dr["bj"].ToString();
                bianhao.Text = dr["ID"].ToString();
            }
            dr.Close();
        }
        public void das()
        {
            string seles = "select * from AssociationType order by ID";
            DataSet ds = DBHelper.GetDataSet(seles);
            sd.DisplayMember = "TypeName";
            sd.ValueMember = "ID";
            sd.DataSource = ds.Tables[0];

            string seles1 = "select * from AssPName order by ID";
            DataSet ds1 = DBHelper.GetDataSet(seles1);
            zw.DisplayMember = "PName";
            zw.ValueMember = "ID";
            zw.DataSource = ds1.Tables[0];
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (xxm.Text == "")
            {
                return;
            }
            string up = "update AssEmpInfo set Tid=@Tid,Pid=@Pid where ID=" + bianhao.Text;
            SqlParameter[] p =
            {
                new SqlParameter("@Name",xxm.Text.ToString()),
                new SqlParameter("@Tid",sd.SelectedValue),
                new SqlParameter("@Pid",zw.SelectedValue)
            };
            int d = DBHelper.ExecuteNonQuery(up, p);
            if (d > 0)
            {
                MessageBox.Show("修改成功");
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
