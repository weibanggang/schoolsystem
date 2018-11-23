using System;
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
    public partial class Admin_pugongok1zw : Form
    {
        public Admin_pugongok1zw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_pugongok1_into2lx().ShowDialog();
            sws();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_pugongok1_into2zw().ShowDialog();
            sws();
        }

        private void Admin_pugongok1zw_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = dataGridView2.AutoGenerateColumns = false;
            dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sws();
        }
        public void sws()
        {
            string sq = "select* from EmpType";
            DataSet ds = DBHelper.GetDataSet(sq);
            dataGridView1.DataSource = ds.Tables[0];
            string sqq = "select * from EmpPosition";
            DataSet dss = DBHelper.GetDataSet(sqq);
            dataGridView2.DataSource = dss.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string s = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                string se = "select* from EmpInfo where Tid=" + s;
                if (DBHelper.ExecuteScalar(se) != null)
                {
                    MessageBox.Show("该类型还有使用中,无法删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from EmpType where ID='" + s + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        sws();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string s = dataGridView2.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView2.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                string se = "select* from EmpInfo where Pid=" + s;
                if (DBHelper.ExecuteScalar(se) != null)
                {
            MessageBox.Show("该职位还有使用中,无法删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
               
                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from EmpPosition where ID='" + s + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        sws();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
        }
    }
}
