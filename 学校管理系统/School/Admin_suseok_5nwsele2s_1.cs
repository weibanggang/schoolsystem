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
    public partial class Admin_suseok_5nwsele2s_1 : Form
    {
        public Admin_suseok_5nwsele2s_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(dgvSource);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sele = "select * from Neiwu n join Dormitory D on n.Did=D.name where convert(nvarchar(10),times,120)='" + datatime.Value.ToString("yyyy-MM-dd") + "'";
            DataSet ds = DBHelper.GetDataSet(sele);
            dgvSource.DataSource = ds.Tables[0];
        }

        private void Admin_suseok_5nwsele2s_1_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.dgvSource.DefaultCellStyle.Alignment = dgvSource.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            dgvSource.AutoGenerateColumns = false;
            string sele = "select * from Neiwu n join Dormitory D on n.Did=D.name ";
            DataSet ds = DBHelper.GetDataSet(sele);
            dgvSource.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwsele_1());
        }
    }
}
