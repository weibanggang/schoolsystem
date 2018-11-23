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
    public partial class Admin_xueshengok_2_2 : Form
    {
        int id = 0;
        public Admin_xueshengok_2_2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_xueshengok_2_2_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            dataGridView1.AutoGenerateColumns = false;
            sh();
        }
        public void sh()
        {
            string my = "select C.ID,CName,CsCount,bzrname,TTell,czt,G.GName from Class C join Grade G on C.Gid=G.ID where C.Gid=" + id;
            DataSet sa = DBHelper.GetDataSet(my);
            dataGridView1.DataSource = sa.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_xueshengok_2_2ifin ss = new Admin_xueshengok_2_2ifin(id);
            if (ss.ShowDialog() == DialogResult.OK)
                sh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_xueshengok_2)this.ParentForm).FormShow(new Admin_xueshengok_2_1());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
                int bid = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
                ((Admin_xueshengok_2)this.ParentForm).FormShow(new Admin_xueshengok_2_3(bid,id));
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                int sd = (int)dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].Value;
                if (sd > 0)
                {
                    MessageBox.Show("该班级还有学生，请清空后删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int s = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
                string name = dataGridView1.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                if (MessageBox.Show("是否删除班级：" + name + "?删除后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string dele = "delete from Class where id=" + s;
                    if (DBHelper.ExecuteNonQuery(dele) > 0)
                    {
                        MessageBox.Show("删除成功");
                        sh();
                    }
                    else
                        MessageBox.Show("删除失败");
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                int s = (int)dataGridView1.Rows[e.RowIndex].Cells["Column7"].Value;
                if(new Admin_xueshengok2_2if_1if(s).ShowDialog() == DialogResult.OK)
                {
                    sh();
                }


            }
        }
    }
}
