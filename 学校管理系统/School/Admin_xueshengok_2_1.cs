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
    public partial class Admin_xueshengok_2_1 : Form
    {
        public Admin_xueshengok_2_1()
        {
            InitializeComponent();
        }

        private void Admin_xueshengok_2_1_Load(object sender, EventArgs e)
        {
           this.dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
      
            dataGridView1.AutoGenerateColumns = false;
            mys();
        }
        public void mys()
        {
            string myw = "select * from Grade";
            DataSet ds = DBHelper.GetDataSet(myw);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 &&  e.ColumnIndex == 4)
            {
                int s = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
                if(new Admin_xueshengok2_1if_1if_1(s).ShowDialog() == DialogResult.OK)
                {
                    mys();
                }
                

            }
            if (e.RowIndex >= 0 &&e.ColumnIndex == 5 )
            {
                  int sd = (int)dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value;
                if (sd > 0)
                {
                    MessageBox.Show("该年级还存有其他班级，请清空班级后删除！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                int s = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
               string name = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                if (MessageBox.Show("是否删除"+name+"?删除后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string dele = "delete from Grade where id=" + s;
                    if (DBHelper.ExecuteNonQuery(dele) > 0)
                    {
                        MessageBox.Show("删除成功");
                        mys();
                    }
                    else
                        MessageBox.Show("删除失败");
                }

            }
            if (e.RowIndex >= 0 &&  e.ColumnIndex == 6)
            {
                int s = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
                ((Admin_xueshengok_2)this.ParentForm).FormShow(new Admin_xueshengok_2_2(s));
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_xueshengok2_1if_1if_1().ShowDialog();
            mys();
        }
    }
}

