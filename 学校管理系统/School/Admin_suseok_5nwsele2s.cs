using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_suseok_5nwsele2s : Form
    {
        int id;

        public Admin_suseok_5nwsele2s(string cx, string my, int id, string lm, string fh, string bj)
        {
            InitializeComponent();
            this.id = id;
                label1.Text = string.Format("{0}-{1}班-{2}宿舍内务信息    时间：{3}", lm, bj, fh, my);

        }

        private void dgvSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                lblStatus.Text = @"状态栏：当前共有 " + (dgvSource.RowCount) + @" 条记录，当前选中检查日期： " + dgvSource.Rows[e.RowIndex].Cells["Column27"].Value.ToString() + "----" + dgvSource.Columns[dgvSource.CurrentCell.ColumnIndex].HeaderText.ToString() + @" ，坐标（" +
                 (dgvSource.CurrentCell.RowIndex + 1) + @"，" + (dgvSource.CurrentCell.ColumnIndex + 1) +
                 @"）";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Admin_suseok_5nwsele2s_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.dgvSource.DefaultCellStyle.Alignment = dgvSource.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            dgvSource.AutoGenerateColumns = false;
            string sele = "select * from Neiwu n join Dormitory D on n.Did=D.name  where n.ID=" + id;
            DataSet ds = DBHelper.GetDataSet(sele);
            dgvSource.DataSource = ds.Tables[0];
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwsele_1());
        }
      
    }
}
