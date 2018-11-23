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
using System.Configuration;
using System.Collections;

namespace School
{
    public partial class Admin_suseok_sfintoshow : Form
    {

        public Admin_suseok_sfintoshow()
        {
            InitializeComponent();
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lms((int)comlm.SelectedValue);

        }
      
        public void lms(int s)
        {
            string sele = "select  Lount from Dormitory where ID=" + s;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            int sw = 0;
            while (dr.Read())
            {
                sw = (int)dr["Lount"];
            }
            dr.Close();
            if (sw == 1)
            {
                string sele2 = string.Format("select  * from lc where id=2");//查询楼层数量
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comlc.DisplayMember = "Name";
                comlc.ValueMember = "ID";
                comlc.DataSource = ds2.Tables[0];
            }

            else
            {
                string sele2 = string.Format("select top {0} * from lc", sw + 1);
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comlc.DisplayMember = "Name";
                comlc.ValueMember = "ID";
                comlc.DataSource = ds2.Tables[0];
            }
      

        }
        private void Lcs(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue;

            }
            else
            {
                sq = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue + " and convert(nvarchar(1),t.DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            dgvSource.DataSource = ds.Tables[0];

        }
        private float Money;
        private float Price;
        private string TotalMoney()
        {
            try
            {
                Money = 0.00f;
                for (int i = 0; i < dgvSource.Rows.Count ; i++)
                {
                    Money += Convert.ToSingle(dgvSource.Rows[i].Cells[8].Value);
                }
                return string.Format("{0:N2}", Money);
            }
            catch (Exception)
            {
                return "0.00";
            }
        }
        private string TotalPrice()
        {
            
            try
            {
                Price = 0.00f;
                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    Price += Convert.ToSingle(dgvSource.Rows[i].Cells[13].Value);
                }
               
                return string.Format("{0:N2}", Price);
            }
            catch (Exception)
            {
                return "0.00";
            }
        }
        private void fee()
        {
            try
            {
                label11.Text = TotalMoney();
                label12.Text = TotalPrice();
                label13.Text = string.Format("{0:N2}", (float.Parse(TotalMoney()) + float.Parse(TotalPrice())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        private void Admin_suseok_sfintoshow_Load(object sender, EventArgs e)
        {
            comboYear.Text = DateTime.Now.ToString("yyyy");
            comboMonth.Text = DateTime.Now.ToString("MM");
            dgvSource.AutoGenerateColumns = false;
            dgvSource.DefaultCellStyle.Alignment =dgvSource.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            lm();
            fee();
            label13.ForeColor = Color.Red;
        }

        public void lm()
        {
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];

        }

        private void comlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lcs((int)comlc.SelectedValue);
        }

        private void dgvSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 15)
            {
                int s = (int)dgvSource.Rows[e.RowIndex].Cells["Column16"].Value;
                string lm = dgvSource.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string fh = dgvSource.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                if (MessageBox.Show("删除-" + lm + "楼-" + fh + "房号\n删除后不可恢复是否删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string sql = "delete from sfinto where sfintoID=" + s;
                    if (DBHelper.ExecuteNonQuery(sql) > 0)
                    {
                        MessageBox.Show("删除成功!");
                        Lcs((int)comlc.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 14)
            {
                int s = (int)dgvSource.Rows[e.RowIndex].Cells["Column16"].Value;
                string electricstart = dgvSource.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                string electricend = dgvSource.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                string waterstart = dgvSource.Rows[e.RowIndex].Cells["Column9"].Value.ToString();
                string waterend = dgvSource.Rows[e.RowIndex].Cells["Column10"].Value.ToString();
                string df = dgvSource.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                string sf = dgvSource.Rows[e.RowIndex].Cells["Column12"].Value.ToString();
                new Admin_suseok_sfupdateshow(s, electricstart, electricend, waterstart, waterend,df,sf).ShowDialog();
                Lcs((int)comlc.SelectedValue);
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = null;
            if(checkBox1.Checked==true&& checkBox2.Checked == true)
            {
                int w = (int)comlc.SelectedValue;
                if (w == 1)
                {
                    sql = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue+" and convert(varchar(4),dateFee,120)="+comboYear.Text+ "and convert(varchar(2),dateFee,110)=" + comboMonth.Text;
                }
                else
                {
                    sql = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue + " and convert(nvarchar(1),t.DonID)=" + (w - 1) + " and convert(varchar(4),dateFee,120)=" + comboYear.Text + "and convert(varchar(2),dateFee,110)=" + comboMonth.Text;

                }
                shmy(sql);
                return;
            }
            if (checkBox1.Checked == true )
            {
                int w = (int)comlc.SelectedValue;
                if ( w== 1)
                {
                    sql = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue;
                }
                else
                {
                    sql = "select *  from sfinto s  join tb_Dormitory t on s.DormitoryNO=t.DonID join Dormitory d on d.ID=s.Did where t.Did=" + comlm.SelectedValue + " and convert(nvarchar(1),t.DonID)=" + (w - 1);

                }
                shmy(sql);
                return;
            }
            if (checkBox2.Checked == true)
            {
                sql = " select * from sfinto where convert(varchar(4),dateFee,120)="+comboYear.Text+ "and convert(varchar(2),dateFee,110)=" + comboMonth.Text;
                shmy(sql);
                return;
            }
        }
        public void shmy(string sq)
        {
            DataSet ds = DBHelper.GetDataSet(sq);
            dgvSource.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(dgvSource);
        }
    }
}
