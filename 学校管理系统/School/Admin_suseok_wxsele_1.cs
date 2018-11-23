using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_suseok_wxsele_1 : Form
    {
        public Admin_suseok_wxsele_1()
        {
            InitializeComponent();
        }

        private void Admin_suseok_wxsele_1_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.datas.DefaultCellStyle.Alignment = datas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            datas.AutoGenerateColumns = false;
            #region 年月控件
            //绑定年
            ArrayList alyear = new ArrayList();
            int i;
            for (i = 1990; i <= 2090; i++)
                alyear.Add(i);
            this.comboYear.DataSource = alyear;
            comboYear.Text = DateTime.Now.Year.ToString(); //默认选中当前年
            //绑定月  
            ArrayList almonth = new ArrayList();
            for (i = 1; i <= 12; i++)
                almonth.Add(i);
            this.comboMonth.DataSource = almonth;
            comboMonth.Text = DateTime.Now.Month.ToString(); //默认选中当前月
            #endregion
            sw();
        }
        public void sw()
        {
            string se = "select * from Dormitory";
            DataSet ds1 = DBHelper.GetDataSet(se);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds1.Tables[0];

            string sele = " select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID";
            DataSet ds = DBHelper.GetDataSet(sele);
            datas.DataSource = ds.Tables[0];
            int qb = 0;
            int wx = 0;
            int yx = 0;
            string qbq = "select count(*) from weixiuwu ";
            qb = (int)DBHelper.ExecuteScalar(qbq);
            string swq = "select count(*) from  weixiuwu where Stata='未修'";
            wx =(int) DBHelper.ExecuteScalar(swq);
            string yxq = "select count(*) from weixiuwu  where Stata='已修'";
            yx = (int)DBHelper.ExecuteScalar(yxq);
            lansw.Text= "查询到申请维修宿舍:" + qb + "个,未修宿舍:" + wx+ "个，已修宿舍:" + yx+"个!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //楼名
            if (chlm.Checked == true)
            {
                string cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue;
                show(cx);

            }
            //年份
            if (chnf.Checked == true)
            {
                string cx = null;
                if (chyf.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text;
                }
                else
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text;
                show(cx);
            }
            //状态
            if (chzt.Checked == true)
            {
                string cx = null;
                if (radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID  where Stata='未修'";
                }
                else
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where Stata='已修'";
                }
                show(cx);
            }
            //楼名加年份
            if (chlm.Checked == true && chnf.Checked == true)
            {
                string cx = null;
                if (chyf.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text;
                }
                else
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text;
                show(cx);
            }
            //楼名加状态
            if (chlm.Checked == true && chzt.Checked == true)
            {
                string cx = null;
                if (radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + "and Stata ='未修'";
                }
                else
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and  Stata ='已修'";
                }
                show(cx);
            }
            //楼名加年份加状态
            if (chlm.Checked == true && chzt.Checked == true && chnf.Checked == true)
            {
                string cx = null;
                //月份
                if (chyf.Checked == true && radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='未修'";
                }
                if (radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='未修'";
                }

                if (chyf.Checked == true && rady.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='已修'";
                }
                if (rady.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where LID=" + comlm.SelectedValue + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='已修'";
                }
                show(cx);
            }
            //年份加状态
            if (chzt.Checked == true && chnf.Checked == true)
            {
                string cx = null;
                if (chyf.Checked == true && radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where  convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='未修'";
                }
                if (radw.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where  convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='未修'";
                }

                if (chyf.Checked == true && rady.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where  convert(nvarchar(4),BaoXiuSheBei,120)=" + comboYear.Text + " and convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='已修'";
                }
                if (rady.Checked == true)
                {
                    cx = "select w.bh,w.BaoXiuSheBei,w.other,WRemark,w.Remark,w.weixname,w.Stata,w.date,w.bxname,w.weixhou,w.weixname,w.renwei,w.hx,t.DonID,d.Name from weixiuwu w join tb_Dormitory t on FNo=t.ID join Dormitory D  on d.ID=w.LID where  convert(nvarchar(2),BaoXiuSheBei,110)=" + comboMonth.Text + "and Stata ='已修'";
                }
                show(cx);
            }
        }
        public void show(string my)
        {
            DataSet ds = DBHelper.GetDataSet(my);
            datas.DataSource = ds.Tables[0];
            int qb = 0;
            int wx = 0;
            int yx = 0;
            for (int i = 0; i < datas.Rows.Count; i++)
            {
                qb++;

                if (datas.Rows[i].Cells[6].Value.ToString() == "未修")
                    wx++;
                else
                    yx++;
            }
            lansw.Text = "查询到申请维修宿舍:" + qb + "个,未修宿舍:" + wx + "个，已修宿舍:" + yx + "个!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw();
        }

        private void datas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 14)
            {
                int s = (int)datas.Rows[e.RowIndex].Cells["Column14"].Value;
                string lm = datas.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string fh = datas.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                if (MessageBox.Show("删除-" + lm + "楼-" + fh + "房号\n删除后不可恢复是否删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string sql = "delete from weixiuwu where ID=" + s;
                    if (DBHelper.ExecuteNonQuery(sql) > 0)
                    {
                        MessageBox.Show("删除成功!");
                        sw();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
        }
    }
}
