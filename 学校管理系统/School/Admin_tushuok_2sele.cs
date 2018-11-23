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
    public partial class Admin_tushuok_2sele : Form
    {
        public Admin_tushuok_2sele()
        {
            InitializeComponent();
        }
        DataSet ds;
        SqlDataAdapter da;
        
        private void Admin_tushuok_2sele_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.dadas.DefaultCellStyle.Alignment = dadas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            dadas.AutoGenerateColumns = false;
            sele();
            string sele1 = "select *from BorrowBook";
            DataSet ds1 = DBHelper.GetDataSet(sele1);
            comsxh.DataSource = ds1.Tables[0];
            comsxh.DisplayMember = "xuehao";
            comsxh.ValueMember= "ID";
            sow();
        }
        public void sow()
        {
            int nan = 0;
            int nv = 0;
            for (int i = 0; i < dadas.Rows.Count; i++)
            {
                if ("False" == dadas.Rows[i].Cells[6].Value.ToString())
                {
                    nan++;
                }
                else
                    nv++;
            }
           label4.Text = "查到总数量:" + dadas.Rows.Count + "|未还数量:" + nan + "|已还数量:" + nv + ",执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        public void sele()
        {
            string sql = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            SqlConnection con = new SqlConnection(sql);
            string sele = "select *from BorrowBook";
            ds = new DataSet();
            da = new SqlDataAdapter(sele, con);
            da.Fill(ds);
            dadas.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnsele_Click(object sender, EventArgs e)
        {
            sele();
            sow();
        }
        
        private void dadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 7)
            {
                return;
            }
            String saw=dadas.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            if(saw=="False")
            {
                MessageBox.Show("未还的记录不能删除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
           
            string s = (string)dadas.Rows[e.RowIndex].Cells["mc"].Value;
            string sw = dadas.Rows[e.RowIndex].Cells["csid"].Value.ToString();
                   
                 
      if (MessageBox.Show("是否要删除学号为" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dele = "delete from BorrowBook where xuehao='" + s + "'" + "and ID='" + sw + "'";
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

        private void comsf_SelectedIndexChanged(object sender, EventArgs e)
        {
            string se = "select * from BorrowBook where IDT='" + comsf.Text + "'";
            DataSet ds = DBHelper.GetDataSet(se);
            dadas.DataSource = ds.Tables[0];
            sow();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string se = "select * from BorrowBook where  xuehao  like '" + comsxh.Text+"%'"; ;
            DataSet ds = DBHelper.GetDataSet(se);
            dadas.DataSource = ds.Tables[0];
            sow();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string se = "select * from BorrowBook where  huihuan="+ huihuan; ;
            DataSet ds = DBHelper.GetDataSet(se);
            dadas.DataSource = ds.Tables[0];
            sow();
        }
       int huihuan=0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            huihuan = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            huihuan = 0;
        }

        private void btnsele_Click_1(object sender, EventArgs e)
        {
            string dele = "delete from BorrowBook where huihuan=1";
            int d = DBHelper.ExecuteNonQuery(dele);
            if (d > 0)
            {
                MessageBox.Show("清除成功");
                sele();
                sow();
            }

            else
                MessageBox.Show("清除失败");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
