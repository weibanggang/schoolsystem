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
using Sys

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
                for (int i = 0; i < dgvSource.Rows.Count - 1; i++)
                {
                        Money += Convert.ToSingle(dgvSource.Rows[i].Cells[7].Value);
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
                for (int i = 0; i < dgvSource.Rows.Count - 1; i++)
                {
                    Price += Convert.ToSingle(dgvSource.Rows[i].Cells[12].Value);
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
                for (int i = 0; i < dgvSource.Rows.Count - 1; i++)
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
            electricAndWater();
            for (int i = 0; i < dgvSource.Rows.Count; i++)//循环dataGridView1的行
            {
                dgvSource.Rows[i].Cells[2].Value = dateTimePicker1.Text;//将dataGridView1中的第一列存入s中
            }
            dgvSource.AutoGenerateColumns = false;
            dgvSource.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
               lm();
        }
    public void lm()
    {

        string sele = "select * from Dormitory";
        DataSet ds = DBHelper.GetDataSet(sele);
        comlm.DisplayMember = "Name";
        comlm.ValueMember = "ID";
        comlm.DataSource = ds.Tables[0];

        CountMoney();
    }
    public void electricAndWater()
        {
            string sql = "select * from electricAndWater";
            string Sqlcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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
        public void sfintoshow()
        {
           
            string Sqlcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(Sqlcon))
            {
                try
                {
                    conn.Open();
                    //SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvSource.DataSource = ds.Tables[0];
                }
                catch(Exception ex)
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
            string Sqlcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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

        private void button2_Click(object sender, EventArgs e)
        {
            fee();
            label11.Text= TotalMoney();
            label12.Text =TotalPrice();
            label13.Text = string.Format("{0:N2}", (float.Parse(TotalMoney()) + float.Parse(TotalPrice())));
        }

        private void dgvSource_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label7.Text = @"状态栏：当前共有 " + (dgvSource.RowCount - 1) + @" 条记录，金额合计为 " + string.Format("{0:N2}", (float.Parse(TotalMoney()) + float.Parse(TotalPrice()))) + @" 元，坐标（" +
                 (dgvSource.CurrentCell.RowIndex + 1) + @"，" + (dgvSource.CurrentCell.ColumnIndex + 1) +
                 @"）";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSource.Rows)
            {
                for (int i = 0; i < dgvSource.RowCount - 1; i++)
                {
                    for (int j = 0; j < dgvSource.ColumnCount; j++)
                    {
                       
                        dgvSource.Rows[i].Cells[j].Value = dgvSource.Rows[i].Cells[j].Value == null ? "" : dgvSource.Rows[i].Cells[j].Value.ToString();
                       
                    }
                }
                try
                { 
                string build = row.Cells["Column1"].Value.ToString();
                string room = row.Cells["Column2"].Value.ToString();
                string datefee = row.Cells["Column3"].Value.ToString();
                string electricstart = row.Cells["Column4"].Value.ToString();
                string electricend = row.Cells["Column5"].Value.ToString();
                string electriccharg = row.Cells["Column6"].Value.ToString();
                string electricunit = row.Cells["Column7"].Value.ToString();
                string electricprice = row.Cells["Column8"].Value.ToString();
                string waterstart = row.Cells["Column9"].Value.ToString();
                string waterend = row.Cells["Column10"].Value.ToString();
                string watercharg = row.Cells["Column11"].Value.ToString();
                string waterunit = row.Cells["Column12"].Value.ToString();
                string waterprice = row.Cells["Column13"].Value.ToString();
                string sql = "insert into sfinto values(@built,@room,@datefee,@electricstart,@electricend,@electriccharg,@electricunit,@electricprice,@waterstart,@waterend,@watercharg,@waterunit,@waterprice)";
                SqlParameter[] p = {
                                    new SqlParameter("@built",build),
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
                string Sqlcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(Sqlcon))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddRange(p);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            this.DialogResult = MessageBox.Show("提交成功", "添加提示", MessageBoxButtons.OK);
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                }
                catch(Exception)
                {
                    this.DialogResult = MessageBox.Show("您输入的信息不完整", "提交失败", MessageBoxButtons.OK);
                    
                }
            }
            
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
            string Sqlcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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

        private void dgvSource_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            fee();
            label11.Text = TotalMoney();
            label12.Text = TotalPrice();
            label13.Text = string.Format("{0:N2}", (float.Parse(TotalMoney()) + float.Parse(TotalPrice())));
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
