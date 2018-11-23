using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_shetuanok_3 : Form
    {
        string name;
        public Admin_shetuanok_3(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        public List<DBHelper.CollegeType> cole()
        {
            string se = "select * from CollegeType";
            SqlDataReader dr = DBHelper.ExecuteReader(se);
            List<DBHelper.CollegeType> Coll = new List<DBHelper.CollegeType>();
            DBHelper.CollegeType Col= null;
            while(dr.Read())
            {
                Col = new DBHelper.CollegeType();
                Col.ID = (int)dr["ID"];
                Col.TypeName = dr["TypeName"].ToString();
                Coll.Add(Col);
            }
                dr.Close();
            return Coll;
            
        }
        private void Admin_shetuanok_3_Load(object sender, EventArgs e)
        {
            xiugais.AutoGenerateColumns = false;
            xiugais.ColumnHeadersDefaultCellStyle.Alignment = xiugais.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            seles();
            sow();
        }
        public void sow()
        {
            label4.Text = "查到数据:" + xiugais.Rows.Count + "条,执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        public void seles()
        {
            
            string sele = "select * from CEmplnfo C join CollegePosition t on C.CPNameID=t.ID join CollegeType P on C.CollegeName=P.ID ";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            List<DBHelper.CollegeType> cs = cole();
            commz.DisplayMember = "TypeName";
            commz.ValueMember = "ID";
            commz.DataSource = cs;
            string sele4 = "select * from CollegePosition";
            DataSet dsa = DBHelper.GetDataSet(sele4);
            comsd.DisplayMember = "CPName";
            comsd.ValueMember = "ID";
            comsd.DataSource = dsa.Tables[0];

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            seles();
            sow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == null)
                return;
            string sele = "select * from CEmplnfo C join CollegePosition t on C.CPNameID=t.ID join CollegeType P on C.CollegeName=P.ID  where  Name like  '" + txtname.Text + "%'";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            sow();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
            {
                return;
            }
            if (xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString() == "")
                return;
            if (e.ColumnIndex == 7)
            {
                new Admin_shetuanok_3upda(xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString()).ShowDialog();
                seles();
            }
            if (e.ColumnIndex == 8)
            {
                string s = xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString();
                if (s == "")
                    return;
                string sw = xiugais.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from CEmplnfo where ID='" + s + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        seles();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
            if (e.ColumnIndex == 9)
            {
                string s = xiugais.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                string sw = "select ID from Stulnfo where TeacherID='" + s + "'";
                SqlDataReader dr = DBHelper.ExecuteReader(sw);
                string sg = null;
                while (dr.Read())
                {
                    sg = dr["ID"].ToString();
                }
                dr.Close();
                new Admin_xueshengok2_1sele(sg).ShowDialog();
            }

        }

        private void commz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sele = "select * from CEmplnfo C join CollegePosition t on C.CPNameID=t.ID join CollegeType P on C.CollegeName=P.ID   where CollegeName=" + commz.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            sow();
        }

        private void comsd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sele = "select * from CEmplnfo C join CollegePosition t on C.CPNameID=t.ID join CollegeType P on C.CollegeName=P.ID   where CPNameID=" + comsd.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            sow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(xiugais);
        }
    }
}
