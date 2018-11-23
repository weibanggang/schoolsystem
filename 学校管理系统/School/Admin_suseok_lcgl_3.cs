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
    public partial class Admin_suseok_lcgl_3 : Form
    {
        int id;
        int Tags;
        string mu = null;
        public Admin_suseok_lcgl_3(int id,int tag,string mu)
        {
            InitializeComponent();
            this.id = id;
            this.Tags = tag;
            this.mu = mu;
        }

        private void Admin_suseok_lcgl_3_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
           dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            Loads(id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Se();
            if (bdw != 0)
                return;
            Admin_suseok_4_1_ifin frm = new Admin_suseok_4_1_ifin(id, Tags.ToString());//宿舍ID  楼ID

            if (frm.ShowDialog() == DialogResult.OK)
            {
                sele();
                Loads(id);
            }
        }

        public void sele()
        {
            string se = "select COUNT(*) from Dormitory_information where DormitoryNO= " + id;  //宿舍信息表--+房号
            int s = (int)DBHelper.ExecuteScalar(se);
            string up = "update tb_Dormitory set YCount =" + s + " where ID= " + id;
            DBHelper.ExecuteScalar(up);
            string lh = "select COUNT(*) from Dormitory_information where Did=" + Tags;
            int s1 = (int)DBHelper.ExecuteScalar(lh);
            string up1 = "update Dormitory set YCount =" + s1 + " where ID= " + Tags;
            DBHelper.ExecuteScalar(up1);
        }
        public void Se()
        {
           
            string se = "select Count,YCount from Dormitory  where ID= " + Tags;//楼ID
            SqlDataReader dr = DBHelper.ExecuteReader(se);
            while (dr.Read())
            {
                if ((int)dr["Count"] == (int)dr["YCount"])
                {
                    MessageBox.Show("该楼人数已满", "提示", MessageBoxButtons.OK);
                    bdw = 10;
                    dr.Close();
                    return;
                }
            }
            dr.Close();
            string sw = "select Count,YCount from tb_Dormitory where id="+ id;
            SqlDataReader drs = DBHelper.ExecuteReader(sw);
            while (drs.Read())
            {
                if ((int)drs["Count"] == (int)drs["YCount"])
                {
                    MessageBox.Show("该宿舍人数已满", "提示", MessageBoxButtons.OK);
                    drs.Close();
                    bdw = 10;
                    return;
                }
            }
            drs.Close();
        }
        int bdw = 0;
            string s1 = null, s2 = null;
        public void Loads(int id)
        {
            
            string se = "select D.[Name],RZtime,Tell,BedNo,C.[CName], T.DonID  from Dormitory_information D join  Class C   on C.ID=D.Class join tb_Dormitory T  on D.DormitoryNO=T.ID where DormitoryNO=" + id;//房号ID
            DataSet dr = DBHelper.GetDataSet(se);
            dataGridView1.Controls.Clear();
            dataGridView1.DataSource = dr.Tables[0];
            string my = "select * from tb_Dormitory where ID="+id;
            SqlDataReader drs = DBHelper.ExecuteReader(my);
           
            while(drs.Read())
            {
               s1=drs["DonID"].ToString();
                s2 = drs["BCount"].ToString();
            }
            drs.Close();
            lanbs.Text =mu+"栋,"+ s2+"班,"+s1+"宿舍信息表";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&& e.ColumnIndex == 6)
            {
                string s = (string)dataGridView1.Rows[e.RowIndex].Cells["cname"].Value;
                if (s == "")
                    return;
                string sw = dataGridView1.Rows[e.RowIndex].Cells["cph"].Value.ToString();
                if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string dele = "delete from Dormitory_information where Name='" + s + "'" + "and [BedNO]='" + sw + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        sele();
                        Loads(id);
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_lcgl)this.ParentForm).FormShow(new Admin_suseok_lcgl_2(Tags));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要清空" + s1 + "所有社员", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string dele = "delete from Dormitory_information where DormitoryNO=" + id;
                int d = DBHelper.ExecuteNonQuery(dele);
                if (d > 0)
                {
                    MessageBox.Show("清空成功");
                    Loads(id);
                    sele();
                }


                else
                    MessageBox.Show("清空失败");
            }
        }
    }
}
