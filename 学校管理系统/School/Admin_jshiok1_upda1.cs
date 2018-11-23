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
    public partial class xiugaiss : Form
    {
        
        public xiugaiss()
        {
            InitializeComponent();
        }
        int cs = 0;
        private void Admin_jshiok1_upda1_Load(object sender, EventArgs e)
        {
            xiugais.DefaultCellStyle.Alignment = xiugais.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            xiugais.AutoGenerateColumns = false;
            conxb.SelectedIndex = 0;
            seles();
            cs = 1;
        }
        public void seles()
        {
            string sele = "select *from TeaInfo";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            string se = "select * from TeaType";
            DataSet ds1 = DBHelper.GetDataSet(se);
            comlx.DisplayMember = "TypeName";
            comlx.ValueMember = "ID";
            comlx.DataSource = ds1.Tables[0];
            string sw = "select * from TeaPosition";
            DataSet ds2= DBHelper.GetDataSet(sw);
            comzw.DisplayMember = "PName";
            comzw.ValueMember = "ID";
            comzw.DataSource = ds2.Tables[0];
            xh();
        }

        private void xiugais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 8)
            {
                new Admin_jshiok1_jsxinxi("修改", xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString()).ShowDialog();
                seles();
            }
            if (e.ColumnIndex == 9)
            {
                    string s = (string)xiugais.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value;
                    string sw = xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString();
                    if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        string dele = "delete from Stulnfo where TeaInfo='" + s + "'" + "and ID='" + sw + "'";
                        int d = DBHelper.ExecuteNonQuery(dele);
                        if (d > 0)
                        {
                            MessageBox.Show("删除成功");
                            seles();
                        }

                        else
                            MessageBox.Show("删除失败");
                  
                }
                seles();
            }
            if (e.ColumnIndex == 10)
            {
                new Admin_jshiok2_sele(xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString()).ShowDialog();
                seles();
            }

        }

        private void comlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cs > 0)
            {
                string sele = "select *from TeaInfo where Type="+ comlx.SelectedValue;
                DataSet ds = DBHelper.GetDataSet(sele);
                xiugais.DataSource = ds.Tables[0];
                xh();
            }
           
        }

        private void comzw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cs > 0)
            {
                string sele = "select *from TeaInfo where Position=" + comzw.SelectedValue;
                DataSet ds = DBHelper.GetDataSet(sele);
                xiugais.DataSource = ds.Tables[0];
                xh();
            }
        }

        private void conxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cs > 0)
            {
                string sele = "select *from TeaInfo where TSex='"+ conxb.Text+"'";
                DataSet ds = DBHelper.GetDataSet(sele);
                xiugais.DataSource = ds.Tables[0];
                xh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sele = "select *from TeaInfo where TName like '%" + txtname.Text + "%'";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
            xh();


        }
        public void xh()
        {
            int nan = 0;
            int nv = 0;
            for (int i = 0; i < xiugais.Rows.Count; i++)
            {
                if ("男" == xiugais.Rows[i].Cells[2].Value.ToString())
                {
                    nan++;
                }
                else
                    nv++;
            }
            label2.Text = string.Format("执行时间:{3} | 总数据:{0}条|男:{1}|女:{2}", nan + nv, nan, nv, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

        }
        private void btnsele_Click(object sender, EventArgs e)
        {
            seles();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xiugais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(xiugais);
        }
    }
}
