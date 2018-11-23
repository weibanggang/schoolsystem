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
    public partial class Admin_suseok_6_nwsele_1 : Form
    {
        public Admin_suseok_6_nwsele_1()
        {
            InitializeComponent();
        }

        private void Admin_suseok_6_nwsele_1_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.datas.DefaultCellStyle.Alignment=datas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            datas.AutoGenerateColumns = false;
            sw();
            //compo.SelectedIndex=1;
        }
        public void sw()
        {
            string se = "select * from Dormitory";
            DataSet ds1 = DBHelper.GetDataSet(se);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds1.Tables[0];

            string se1 = "select Fuze from Neiwu group by Fuze";
            DataSet ds2 = DBHelper.GetDataSet(se1);
            compo.DisplayMember = "Fuze";
            compo.DataSource = ds2.Tables[0];

            
            my();

        }
        public void sa() {
            string sele = " select * from Neiwu n join Dormitory d on n.Did=d.Name";
            DataSet ds = DBHelper.GetDataSet(sele);
            datas.DataSource = ds.Tables[0];
        }
        public void my()
        {
            int qb = 0;
            int wx = 0;
            int yx = 0;
            for (int i = 0; i < datas.Rows.Count; i++)
           {
              qb++;

           if (datas.Rows[i].Cells[4].Value.ToString() == "100")
               wx++;
              else
                yx++;
         }
            lansw.Text = "查询到:" + qb + "条数据,满分:" + wx + "条，被扣分:" + yx + "条!";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (carl.Checked == true  && cardata.Checked == true)
            {
                string sele = " select * from Neiwu n join Dormitory D on n.Did=D.Name  where Did='" + comlm.Text + "' and convert(nvarchar(10),times,120)='" + datatime.Value.ToString("yyyy-MM-dd") + "'";

                Seleshow(sele);
                return;
            }
            else if (carl.Checked == true)
            {

                string sele = " select * from Neiwu n join Dormitory D on n.Did=D.Name where Did='" + comlm.Text+"'";
                Seleshow(sele);
                return;
            }

            
           else if (cardata.Checked == true)
            {
           string   sele = " select * from Neiwu n join Dormitory D on n.Did=D.Name  where convert(nvarchar(10),times,120)='" + datatime.Value.ToString("yyyy-MM-dd") + "'";
                Seleshow(sele);
                return;
            }
           
        }
        public  void Seleshow(string sele)
        {
            DataSet ds = DBHelper.GetDataSet(sele);
            datas.DataSource = ds.Tables[0];
            my();
        }

        private void compo_SelectedIndexChanged(object sender, EventArgs e)
        {
             string  sele = " select * from Neiwu n join Dormitory D on n.Did=D.Name  where FuZe='" + compo.Text + "'";

            Seleshow(sele);
        }

        private void datas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
                int s = (int)datas.Rows[e.RowIndex].Cells["Column9"].Value;
                string lm = datas.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string fh = datas.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                string bj = datas.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                string sw = datas.Rows[e.RowIndex].Cells["Column8"].Value.ToString();
                ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_5nwsele2s("查询", sw, s, lm, fh, bj));
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                int bh = (int)datas.Rows[e.RowIndex].Cells["Column9"].Value;
                string lm = datas.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string fh = datas.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                string bj = datas.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                string sj = datas.Rows[e.RowIndex].Cells["Column8"].Value.ToString();

                if (MessageBox.Show("时间：" + sj + "\n是否删除:" + lm + "楼-" + fh + "房-" + bj + "班?删除后不可恢复!", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    dele(bh);
                }
            }
       
        }
        public void dele(int bh)
        {
            string sql = "delete from Neiwu where ID=" + bh;
            if (DBHelper.ExecuteNonQuery(sql) > 0)
            {
                sa();
                lansw.Text = "删除成功";
            }
            else
            {
                lansw.Text = "删除失败";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            sa();
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           DBHelper. ExportExcel(datas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_5nwsele2s_1());
        }
    }
}
