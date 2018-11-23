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
namespace School
{
    public partial class Admin_Adminok_1_go : Form
    {
        public Admin_Adminok_1_go()
        {
            InitializeComponent();
        }
        
        public void sele()
        {
            string ss = "select * from AdminInfo";
            string sql = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(sql))
            {
                try
                {
                    con.Open();
                    da = new SqlDataAdapter(ss, con);
                    ds = new DataSet();
                    da.Fill(ds);
                    dada1.DataSource = ds.Tables[0];

                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                    return;
                }
            }
            string ssw = "select count(*) from AdminInfo";
            lblStatus.Text = "一共有:" + DBHelper.ExecuteScalar(ssw).ToString() + "条数据 | 本次执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            


        }
        public void sl() {

            string asd = "select * from fangui";
            DataSet ds2 = DBHelper.GetDataSet(asd);
            dataGridView1.DataSource = ds2.Tables[0];
        }
        private void Admin_Adminok_1_go_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns=dada1.AutoGenerateColumns = false;
            dada1.ColumnHeadersDefaultCellStyle.Alignment = dada1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            comsw.SelectedIndex=coms.SelectedIndex=comzt.SelectedIndex=comxb.SelectedIndex = 0;
             sele();
            ms();
            s = 1;
            panel4.Controls.Add(new dlqk());


        }
       public void ms()
        {
            string se = "select * from AdminInfo";
            DataSet ds = DBHelper.GetDataSet(se);
            comzh.DisplayMember = "uid";
            comzh.ValueMember = "ID";
            comzh.DataSource = ds.Tables[0];
            string se1 = "select * from AdminInfo";
            DataSet ds1 = DBHelper.GetDataSet(se1);
            comzh1.DisplayMember = "uid";
            comzh1.ValueMember = "ID";
            comzh1.DataSource = ds1.Tables[0];
            sl();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            sele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = "select * from AdminInfo where  Name  like '%" + txtname.Text+"%'";
            ds = DBHelper.GetDataSet(ss);
            dada1.DataSource = ds.Tables[0];
            string ssw = "select count(*) from  AdminInfo where  Name  like '%" + txtname.Text + "%'";
            lblStatus.Text = "一共有:" + DBHelper.ExecuteScalar(ssw).ToString() + "条数据,执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        

        DataSet ds;
        SqlDataAdapter da;
        

        private void dada1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex!=6)
            {
                return;
            }
            if (dada1.Rows[e.RowIndex].Cells["sc"].Value.ToString() == "")
                return;
            string ss = dada1.Rows[e.RowIndex].Cells["sc"].Value.ToString();
            string sw = dada1.Rows[e.RowIndex].Cells["cs"].Value.ToString();
                string swww = dada1.Rows[e.RowIndex].Cells["scs"].Value.ToString();
            if(swww=="manager")
            {
                MessageBox.Show("不能删除默认管理员","提示",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            if (MessageBox.Show("是否要删除" + sw, "删除", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string de = "delete from AdminInfo where ID=" + ss;
                int s=DBHelper.ExecuteNonQuery(de);
                if ( s> 0)
                {
                    MessageBox.Show("删除成功");
                    sele();

                }

                else
                    MessageBox.Show("删除失败");
            }
        }
        private void comxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s == 0)
                return;
            string ss = "select * from AdminInfo where  Sex='" + comxb.Text+"'";
            ds = DBHelper.GetDataSet(ss);
            dada1.DataSource = ds.Tables[0];
            string ssw = "select count(*) from  AdminInfo where   Sex='" + comxb.Text + "'";
            lblStatus.Text = "一共有:" + DBHelper.ExecuteScalar(ssw).ToString() + "条数据,执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( new Admin_Adminok_1ifin().ShowDialog() == DialogResult.OK) {
                sele();
            }
              
        }
        int s = 0;
        private void comzt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s == 0)
                return;
            string ss = "select * from AdminInfo where  State='"+comzt.Text+"'";
            ds = DBHelper.GetDataSet(ss);
            dada1.DataSource = ds.Tables[0];
            string ssw = "select count(*) from  AdminInfo where   State='" + comzt.Text + "'";
            lblStatus.Text = "一共有:" + DBHelper.ExecuteScalar(ssw).ToString() + "条数据,执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void coms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s == 0)
                return;
            string ss = "select * from AdminInfo where  Tid='" + coms.Text+"'";
            ds = DBHelper.GetDataSet(ss);
            dada1.DataSource = ds.Tables[0];
            string ssw = "select count(*) from  AdminInfo where   Tid='" + coms.Text + "'";
            lblStatus.Text = "一共有:" + DBHelper.ExecuteScalar(ssw).ToString() + "条数据,执行时间:" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void dada1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                lblStatus.Text = @"状态栏：当前共有 " + (dada1.RowCount) + @" 条记录，当前选中： " + dada1.Rows[e.RowIndex].Cells["cs"].Value.ToString() + @" ，坐标（" +
                 (dada1.CurrentCell.RowIndex + 1) + @"，" + (dada1.CurrentCell.ColumnIndex + 1) +
                 @"）";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string se = "select count(*) from AdminInfo where Uid=" + comzh.Text;
            if ((int)DBHelper.ExecuteScalar(se) > 0)
            {
                if (MessageBox.Show("是否禁用账号:" + comzh.Text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sad = "update AdminInfo set State='禁用' where Uid='" + comzh.Text + "'";
                    if (DBHelper.ExecuteNonQuery(sad) > 0)
                    {
                        MessageBox.Show("禁用成功");
                        sele();
                    }
                    else
                        MessageBox.Show("禁用失败");
                }
            }
            else
            {
                MessageBox.Show("没有该账号！");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string se = "select count(*) from AdminInfo where Uid=" + comzh.Text;
            if ((int)DBHelper.ExecuteScalar(se) > 0)
            {
                if (MessageBox.Show("是否启用账号:" + comzh.Text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sad = "update AdminInfo set State='可用' where Uid='"+ comzh.Text+ "'";
                    if (DBHelper.ExecuteNonQuery(sad) > 0)
                    {
                        MessageBox.Show("启用成功");
                        sele();
                    }
                    else
                        MessageBox.Show("启用失败");
                }
            }
            else
            {
                MessageBox.Show("没有该账号！");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string se = "select count(*) from AdminInfo where Uid=" + comzh1.Text;
            if ((int)DBHelper.ExecuteScalar(se) > 0)
            {
                string sw = "select Tid from AdminInfo where Uid=" + comzh1.Text;
                SqlDataReader dr = DBHelper.ExecuteReader(sw);
                string sd = null;
                while(dr.Read())
                {
                    sd = dr["Tid"].ToString();
                }
                dr.Close();
                if (MessageBox.Show("是否把账号:" + comzh1.Text+"|当前类型:"+sd+"转换成:"+ comsw.Text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    panel1.Visible = false;
                    string upda = "update AdminInfo set Tid='"+ comsw .Text+ "' where Uid=" + comzh1.Text;
                    if(DBHelper.ExecuteNonQuery(upda)>0)
                    {
                        label10.Text = "当前管理类型："+comsw.Text;
                        label9.Text = "转换前管理类型："+ sd;
                        sele();
                    }
                    else
                    {
                        label11.Text = "转换失败";
                        label10.Visible = label9.Visible = false;
                    }
                }
            }
            else
            {
                panel1.Visible = true;
                MessageBox.Show("没有该账号！");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string ss = dataGridView1.Rows[e.RowIndex].Cells["ids"].Value.ToString();
            if (e.ColumnIndex == 4)
            {
                new Admin_Adminok_2ck(ss).ShowDialog();
            }
           
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("是否删除" , "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string dele = "delete from fangui where id=" + ss;
                    if (DBHelper.ExecuteNonQuery(dele) > 0)
                    {
                        MessageBox.Show("删除成功");
                        sl();
                    }
                    else
                        MessageBox.Show("删除失败");
                }
            }
        }
    }
}
