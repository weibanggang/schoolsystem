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
    public partial class Admin_shetuanok_2s : Form
    {
        public Admin_shetuanok_2s()
        {
            InitializeComponent();
        }

        private void Admin_shetuanok_2s_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = dataGridView2.AutoGenerateColumns = false;
            dataGridView1.DefaultCellStyle.Alignment= dataGridView2.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment=dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            show();
        }
        public void show()
        {
            string lx = "select * from CollegeType";
            DataSet ds = DBHelper.GetDataSet(lx);
            dataGridView1.DataSource = ds.Tables[0];
            string zw = "select * from CollegePosition";
            DataSet ds1 = DBHelper.GetDataSet(zw);
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string s = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from CollegeType where ID='" + s + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        show();
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
            if (e.ColumnIndex == 2)
            {
                string s = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                if (s == "")
                    return;
                string sw = dataGridView2.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from CollegePosition where ID='" + s + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        show();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
        }
    }
}
