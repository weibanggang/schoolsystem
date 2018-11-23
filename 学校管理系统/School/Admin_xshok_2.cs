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
    public partial class Admin_xshok_2 : Form
    {
        public Admin_xshok_2()
        {
            InitializeComponent();
        }

        private void Admin_xueshengok_3_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = dataGridView2.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = dataGridView1.DefaultCellStyle.Alignment = dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sws();
        }
        public void sws()
        {
            string sq = "select* from AssPName";
            DataSet ds = DBHelper.GetDataSet(sq);
            dataGridView1.DataSource = ds.Tables[0];
            string sqq = "select * from AssociationType";
            DataSet dss = DBHelper.GetDataSet(sqq);
            dataGridView2.DataSource = dss.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString() == "")
                return;
                 
            if (e.ColumnIndex == 2)
            {
                string s = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from AssPName where ID='" + s + "'";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
                if (dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString() == "")
                    return;

            if (e.ColumnIndex == 2)
            {
                string s = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from AssociationType where ID='" + s + "'";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
