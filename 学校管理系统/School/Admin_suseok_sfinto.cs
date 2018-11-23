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
    public partial class Admin_suseok_sfinto : Form
    {
        private float Money;
        private float Price;

        public Admin_suseok_sfinto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private string TotalMoney()
        {
            try
            {
                Money = 0.00f;
                for (int i = 0; i < dgvSource.Rows.Count ; i++)
                {
                        Money += Convert.ToSingle(dgvSource.Rows[i].Cells[7].Value);
                }
                return string.Format("{0:N2}", Money);
            }
            catch (Exception )
            {
                
                return "0.00";
            }
        }
        private string TotalPrice()
        {
            try
            {
                Price = 0.00f;
                for (int i = 0; i < dgvSource.Rows.Count ; i++)
                {
                    Price += Convert.ToSingle(dgvSource.Rows[i].Cells[12].Value);
                }
                return string.Format("{0:N2}", Price);
            }
            catch (Exception )
            {
                
                return "0.00";
            }
        }
        private void fee()
        {
            try
            {
                for (int i = 0; i < dgvSource.Rows.Count ; i++)
                {
                    dgvSource.Rows[i].Cells[5].Value = Convert.ToSingle(dgvSource.Rows[i].Cells[4].Value) - Convert.ToSingle(dgvSource.Rows[i].Cells[3].Value);
                    dgvSource.Rows[i].Cells[7].Value = string.Format("{0:N2}",Convert.ToSingle(dgvSource.Rows[i].Cells[5].Value) * Convert.ToSingle(dgvSource.Rows[i].Cells[6].Value));
                    dgvSource.Rows[i].Cells[10].Value = Convert.ToSingle(dgvSource.Rows[i].Cells[9].Value) - Convert.ToSingle(dgvSource.Rows[i].Cells[8].Value);
                    dgvSource.Rows[i].Cells[12].Value = string.Format("{0:N2}",Convert.ToSingle(dgvSource.Rows[i].Cells[10].Value) * Convert.ToSingle(dgvSource.Rows[i].Cells[11].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Admin_suseok_sfinto_Load(object sender, EventArgs e)
        {
            dgvSource.DefaultCellStyle.Alignment = dgvSource.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            electricAndWater();
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[2].Value = dateTimePicker1.Text;//将dataGridView1中的第一列存入s中
            }
            dgvSource.AutoGenerateColumns = false;
           
               lm();
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
    public void electricAndWater()
        {
            string sql = "select * from electricAndWater";
            string Sqlcon = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(Sqlcon))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        textBox1.Text = dr["electricPrice"].ToString();
                        textBox2.Text = dr["WaterPrice"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[6].Value=textBox1.Text;//将dataGridView1中的第一列存入s中
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            string sql = "update electricAndWater set electricPrice="+textBox1.Text+"";
            string Sqlcon = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(Sqlcon))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        
        public void Into()
        {
            int s = 0;
            try
            {
                string sql = "insert into sfinto values(@built,@room,@datefee,@electricstart,@electricend,@electriccharg,@electricunit,@electricprice,@waterstart,@waterend,@watercharg,@waterunit,@waterprice)";

                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    dgvSource.Rows[i].Cells[3].Value = dgvSource.Rows[i].Cells[3].Value == null ? "0" : dgvSource.Rows[i].Cells[3].Value.ToString();
                    dgvSource.Rows[i].Cells[4].Value = dgvSource.Rows[i].Cells[4].Value == null ? "0" : dgvSource.Rows[i].Cells[4].Value.ToString();
                    dgvSource.Rows[i].Cells[8].Value = dgvSource.Rows[i].Cells[8].Value == null ? "0" : dgvSource.Rows[i].Cells[8].Value.ToString();
                    dgvSource.Rows[i].Cells[9].Value = dgvSource.Rows[i].Cells[9].Value == null ? "0" : dgvSource.Rows[i].Cells[9].Value.ToString();
               
                     string room = (dgvSource.Rows[i].Cells[1].Value).ToString();//房间号
                string datefee = dateTimePicker1.Value.ToString();//日期
                string electricstart = (dgvSource.Rows[i].Cells[3].Value).ToString();
                string electricend = (dgvSource.Rows[i].Cells[4].Value).ToString();
                string electriccharg = (dgvSource.Rows[i].Cells[5].Value).ToString();
                string electricunit = (dgvSource.Rows[i].Cells[6].Value).ToString();
                string electricprice = (dgvSource.Rows[i].Cells[7].Value).ToString();
                string waterstart = (dgvSource.Rows[i].Cells[8].Value).ToString();
                string waterend = (dgvSource.Rows[i].Cells[9].Value).ToString();
                string watercharg = (dgvSource.Rows[i].Cells[10].Value).ToString();
                string waterunit = (dgvSource.Rows[i].Cells[11].Value).ToString();
                string waterprice = (dgvSource.Rows[i].Cells[12].Value).ToString();
                 SqlParameter[] p = {
                                    new SqlParameter("@built",comlm.SelectedValue.ToString()),
                                    new SqlParameter("@room",room),
                                    new SqlParameter("@datefee",datefee),
                                    new SqlParameter("@electricstart",electricstart),
                                    new SqlParameter("@electricend",electricend),
                                    new SqlParameter("@electriccharg",electriccharg),
                                    new SqlParameter("@electricunit",electricunit),
                                    new SqlParameter("@electricprice",electricprice),
                                    new SqlParameter("@waterstart",waterstart),
                                    new SqlParameter("@waterend",waterend),
                                    new SqlParameter("@watercharg",watercharg),
                                    new SqlParameter("@waterunit",waterunit),
                                    new SqlParameter("@waterprice",waterprice)
                                   };

                    int c = DBHelper.ExecuteNonQuery(sql, p);
                    if (c > 0)
                    {

                        s++;
                    }
                   
                }
                if (s == dgvSource.Rows.Count)
                {
                    
                    MessageBox.Show("录入成功");

                }


            }
            catch 
            {
              
              
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Into();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[11].Value = textBox2.Text;//将dataGridView1中的第一列存入s中
            }
            if(textBox2.Text=="")
            {
                textBox2.Text = "0";
            }
            string sql = "update electricAndWater set WaterPrice =" + textBox2.Text + "";
            string Sqlcon = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(Sqlcon))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                       
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        int c = 0;
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
            c = s;

        }
        private void Lcs(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from tb_Dormitory where YCount>0 and Did=" + c;

            }
            else
            {
                sq = "select *  from tb_Dormitory where Did=" + c + "and YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            dgvSource.DataSource = ds.Tables[0];

        }
        private void comlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lcs((int)comlc.SelectedValue);
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[0].Value = comlm.Text.ToString(); ;//将dataGridView1中的第一列存入s中
                dgvSource.Rows[i].Cells[2].Value = dateTimePicker1.Text; ;//将dataGridView1中的第一列存入s中
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
            }
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[6].Value = textBox1.Text;//将dataGridView1中的第一列存入s中
                dgvSource.Rows[i].Cells[11].Value = textBox2.Text;//将dataGridView1中的第一列存入s中
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[2].Value = dateTimePicker1.Text; ;//将dataGridView1中的第一列存入s中
            }
        }

        private void dgvSource_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            fee();
            label11.Text = TotalMoney();
            label12.Text = TotalPrice();
            label13.Text = string.Format("{0:N2}", (float.Parse(TotalMoney()) + float.Parse(TotalPrice())));
        }

    }
}
