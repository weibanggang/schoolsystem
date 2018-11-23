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
    public partial class Admin_suseok_lcgl_1 : Form
    {
        public Admin_suseok_lcgl_1()
        {
            InitializeComponent();
        }
        
        private void Admin_suseok_lcgl_1_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.DataVies.DefaultCellStyle.Alignment = DataVies.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            DataVies.AutoGenerateColumns = false;
           
            swh();
        }
      
        public void swh()
        {
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            DataVies.DataSource = ds.Tables[0];
            string sele1 = "select count(*) from Dormitory";//楼数
            int sww = Convert.ToInt32(DBHelper.ExecuteScalar(sele1));//楼数
            string sele2 = "select count(*) from Dormitory_information";//已住人数
            int sww2 = Convert.ToInt32(DBHelper.ExecuteScalar(sele2));//已住人数
            string sele22 = "select count(*) from tb_Dormitory";//宿舍间数
            int sww22 = Convert.ToInt32(DBHelper.ExecuteScalar(sele22));//宿舍间数
            int Au = 0;//可住人数
            string kez = "select Count from Dormitory";
            SqlDataReader dr = DBHelper.ExecuteReader(kez);
            while (dr.Read())
            {
                Au += (int)dr["Count"];
            }
            dr.Close();


            lans.Text = "楼数:" + sww + "栋|总间数：" + sww22 + "间|可住人数:" + Au + "人|已住人数:" + sww2 + "人";
        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_1)this.ParentForm).FormShow(new Admin_suseok_2()); 
        }
        
        int id = 0;//宿舍楼房号
        int Tags = 0;//楼号ID
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >0&&e.ColumnIndex==2)
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
                     
                    }

                    else
                        MessageBox.Show("删除失败");
                }
           
            }
        }
      
        private void DataVies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                string s = (string)DataVies.Rows[e.RowIndex].Cells["Column10"].Value;
               
                if ((new Admin_suse_lh(s).ShowDialog()) == DialogResult.OK)
                {
                    swh();
                }
                
            }
                if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                string s = (string)DataVies.Rows[e.RowIndex].Cells["Column2"].Value;
                if (s == "")
                    return;
                if ((int)DataVies.Rows[e.RowIndex].Cells["Column4"].Value > 0)
                {
                    MessageBox.Show("该楼层还有人住，不可删除！请先把所有人转出");
                    return;
                }
                if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {

                    string sele = "select ID from Dormitory where Name='" + s + "'";
                    int d = (int)DBHelper.ExecuteScalar(sele);
                    string delet = "delete from tb_Dormitory where Did=" + d;
                    DBHelper.ExecuteNonQuery(delet);
                    string delete = "delete from Dormitory where ID=" + d;
                    int sw = DBHelper.ExecuteNonQuery(delete);

                    if (sw > 0)
                    {
                        MessageBox.Show("删除成功");
                        swh();

                    }
                    else
                        MessageBox.Show("删除失败");
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
                string s = (string)DataVies.Rows[e.RowIndex].Cells["Column2"].Value;
                string sele = "select ID from Dormitory where Name='" + s + "'";
                int d = (int)DBHelper.ExecuteScalar(sele);
                ((Admin_suseok_lcgl)this.ParentForm).FormShow(new Admin_suseok_lcgl_2(d,s));
              

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin_suseok_2lfin ss = new School.Admin_suseok_2lfin();
            if (ss.ShowDialog() == DialogResult.OK)
                swh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(DataVies);
        }
    }
}
