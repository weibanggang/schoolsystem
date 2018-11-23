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
    public partial class Admin_suseok_lcgl_2 : Form
    {
        int id = 0;
        string name;
        public Admin_suseok_lcgl_2(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Admin_suseok_lcgl_2(int id,string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        private void Admin_suseok_lcgl_2_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.das.DefaultCellStyle.Alignment = das.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            das.AutoGenerateColumns = false;
            selesa(name, id);

        }
        public void selesa(string name, int Tags)
        {


            string msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did=" + Tags;
            DataSet ds = DBHelper.GetDataSet(msq);
            das.DataSource = ds.Tables[0];

            string sele2 = "select * from Dormitory where ID=" + Tags;//已住人数
            SqlDataReader dr = DBHelper.ExecuteReader(sele2);
            int sww22 = 0, Au = 0, sww2 = 0;
            while(dr.Read())
            {
                sww2=(int)dr["YCount"];
                Au = (int)dr["Count"];
                sww22 = (int)dr["ZZACount"];
            }
            dr.Close();
            
            string ssw = "select SUM(YCount) from tb_Dormitory where Did=" + Tags;
            string s = DBHelper.ExecuteScalar(ssw).ToString();
            
                lanrens.Text = name + "楼|总间数：" + sww22 + "间|可住人数:" + Au + "人|已住人数:" + sww2 + "人";
        }

        private void das_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
                string s = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value;
                string sele = "select ID from Dormitory where Name='" + s + "' ";
                int d = (int)DBHelper.ExecuteScalar(sele);
                string sd = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value;
                string sd1 = (string)das.Rows[e.RowIndex].Cells["Column1"].Value;
                string classs = das.Rows[e.RowIndex].Cells["Column9"].Value.ToString();
                string my = "select ID from tb_Dormitory where Did=" + d + " and DonID=" + sd;

                int jk = (int)DBHelper.ExecuteScalar(my); //宿舍表ID
                if (classs=="0")
                {              //房号ID楼名//房号
                    if ((new Admin_suse_fh((int)jk, s, sd).ShowDialog()) == DialogResult.OK)
                    {
                        selesa(name, id);
                    }
                }
                else
                ((Admin_suseok_lcgl)this.ParentForm).FormShow(new Admin_suseok_lcgl_3(jk,id,sd1));

            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                string s = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value;
                string sele = "select ID from Dormitory where Name='" + s + "' ";
                int d = (int)DBHelper.ExecuteScalar(sele);
                string sd = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value;
                string sd1 = (string)das.Rows[e.RowIndex].Cells["Column1"].Value;
                string my = "select ID from tb_Dormitory where Did=" + d + " and DonID=" + sd;

                int jk = (int)DBHelper.ExecuteScalar(my); //宿舍表ID
                           //房号ID楼名//房号
                    if ((new Admin_suse_fh((int)jk, s, sd,2).ShowDialog()) == DialogResult.OK)
                    {
                        selesa(name, id);
                    }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                string s = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value;
                string sd = (string)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value;

                int bd2 = (int)das.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value;
                if (bd2 > 0)
                {
                    MessageBox.Show("不可删除！请先转出所有人再删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                string sele = "select ID from Dormitory where Name='" + s + "' ";
                int d = (int)DBHelper.ExecuteScalar(sele);

                if (MessageBox.Show("是否删除“" + s + "”楼 ," + sd + "房号" + ",删除后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string seles = "delete  from tb_Dormitory where Did=" + d + " and DonID=" + sd;
                    int dbh = DBHelper.ExecuteNonQuery(seles);
                    int kz = 0, yz = 0, da = 0;//可住人数
                    string kez = "select Count,YCount from tb_Dormitory where Did=" + d;
                    SqlDataReader dr = DBHelper.ExecuteReader(kez);
                    while (dr.Read())
                    {
                        kz += (int)dr["Count"];
                        yz += (int)dr["YCount"];
                        da++;
                    }
                    dr.Close();
                    
                    string selesw = "update Dormitory  set ZZACount=" + da + " ,Count="+kz+ " ,YCount="+ yz+ " where ID=" + d;
                    int dbhw = DBHelper.ExecuteNonQuery(selesw);
                    if (dbhw > 0)
                    {
                        MessageBox.Show("删除成功");
                        string msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did=" + d;
                        DataSet ds = DBHelper.GetDataSet(msq);
                        das.DataSource = ds.Tables[0];
                        selesa(s, d);
                    }
                    else
                        MessageBox.Show("删除失败");
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_lcgl)this.ParentForm).FormShow(new Admin_suseok_lcgl_1());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(das);
        }
    }
}
