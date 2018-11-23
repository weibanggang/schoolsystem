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
    public partial class Admin_suseok_4_1 : Form
    {
        int id;//房号ID
        string name;//房号
        string Tags; //宿舍楼ID
        string sww;//楼名
        string bj;//班级
        public Admin_suseok_4_1(string bj,int id ,string name,string Tags,string sww) ////房号ID  房号//宿舍楼ID 楼名
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.Tags = Tags;
            this.sww = sww;
            this.bj = bj;
        }
        private void picfanhui_Click(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Se();
            
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
                    dr.Close();
                    return;
                }
            }
            dr.Close();
            string sw = "select Count,YCount from tb_Dormitory where ID=" + id; ;
            SqlDataReader drs = DBHelper.ExecuteReader(sw);
            while (drs.Read())
            {
                if ((int)drs["Count"] == (int)drs["YCount"])
                {
                    MessageBox.Show("该宿舍人数已满", "提示", MessageBoxButtons.OK);
                    drs.Close();
                    return;
                }
            }
            drs.Close();
            Admin_suseok_4_1_ifin frm = new Admin_suseok_4_1_ifin(id, Tags);//宿舍ID  楼ID

            if (frm.ShowDialog() == DialogResult.OK)
            {
                sele();
                Loads();
            }
        }

        private void Admin_suseok_4_1_Load(object sender, EventArgs e)
        {
            DataVies.AutoGenerateColumns = false;
            DataVies.ColumnHeadersDefaultCellStyle.Alignment = DataVies.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Loads();
        }
        public void Loads()
        {
            lanbs.Text =bj+"班"+ name + "宿舍信息表";
            string se = "select D.[Name],RZtime,Tell,BedNo,C.[CName], T.DonID  from Dormitory_information D join  Class C   on C.ID=D.Class join tb_Dormitory T  on D.DormitoryNO=T.ID where DormitoryNO=" + id;//房号ID
            DataSet dr = DBHelper.GetDataSet(se);
            DataVies.Controls.Clear();
            DataVies.DataSource = dr.Tables[0];
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
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        if (MessageBox.Show("是否要清空" + name+"所有社员", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string dele = "delete from Dormitory_information where DormitoryNO="+id;
                int d = DBHelper.ExecuteNonQuery(dele);
                if (d > 0)
                {
                    MessageBox.Show("清空成功");
                    sele();
                    Loads();
                }

                else
                    MessageBox.Show("清空失败");
            }
        }

        private void DataVies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                string s = (string)DataVies.Rows[e.RowIndex].Cells["cname"].Value;
                if (s == "")
                    return;
                string sw = DataVies.Rows[e.RowIndex].Cells["cph"].Value.ToString();
                if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string dele = "delete from Dormitory_information where Name='" + s + "'" + "and [BedNO]='" + sw + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        sele();
                        Loads();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_suseok_4 frm = new School.Admin_suseok_4(Tags, sww);//宿舍楼ID 楼名
            ((Admin_suseok_1)this.ParentForm).FormShow(frm);
        }
    }
}
