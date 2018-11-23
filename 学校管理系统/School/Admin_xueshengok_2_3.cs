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
    public partial class Admin_xueshengok_2_3 : Form
    {
        int bid = 0;
        int nid = 0;
        public Admin_xueshengok_2_3(int bid,int nid)
        {
            InitializeComponent();
            this.bid = bid;
            this.nid = nid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_xueshengok_2)this.ParentForm).FormShow(new Admin_xueshengok_2_2(nid));
        }

        private void Admin_xueshengok_2_3_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.xiugais.DefaultCellStyle.Alignment = xiugais.ColumnHeadersDefaultCellStyle.Alignment  = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            xiugais.AutoGenerateColumns = false;
            seles();
        }
        public void seles()
        {
            string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID where C.id="+bid;
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清空班级：" + xiugais.Rows[1].Cells["dataGridViewTextBoxColumn16"].Value+ " ? ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
           string dele = "delete from Stulnfo where Cid=" + bid;
            if (DBHelper.ExecuteNonQuery(dele) > 0)
          {
           MessageBox.Show("删除成功");
                    seles();
          }
           else
             MessageBox.Show("删除失败");
          }
        }

        private void xiugais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                int s= (int)xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value;
                new Admin_xueshengok2_1sele(s.ToString()).ShowDialog();
            }
            if (e.RowIndex >= 0&&e.ColumnIndex == 9)
            {

                string s = (string)xiugais.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value;

                string sw = xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString();
                if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string dele = "delete from Stulnfo where SStudentName='" + s + "'" + "and ID='" + sw + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        seles();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
            if (e.RowIndex >= 0&&e.ColumnIndex == 8)
            {
                if (xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString() == "")
                    return;
                new Admin_xueshengok_2_1ifin("修改", xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString()).ShowDialog();
                seles();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(xiugais);
        }
    }
}
