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
    public partial class Admin_xueshengok_2_1_1 : Form
    {
        string tj = null;
        string bd = null;
        public Admin_xueshengok_2_1_1(string tj,string bd)
        {
            InitializeComponent();
            this.tj = tj;
            this.bd = bd;
        }

        private void Admin_xueshengok_2_1_1_Load(object sender, EventArgs e)
        {
            this.xiugais.DefaultCellStyle.Alignment = xiugais.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            xiugais.AutoGenerateColumns = false;
            my();
        }
        public void my()
        {
            string sw = null;
            if(tj=="年级")
            {
                 sw = "select * from Class c join Stulnfo s on c.ID = s.Cid  join StuPosition st on st.ID=s.Pid join Grade g on g.ID = c.Gid where g.ID ="+ bd;
            }
            else if (tj == "班级")
            {
                sw = "select * from Class c join Stulnfo s on c.ID = s.Cid  join StuPosition st on st.ID=s.Pid join Grade g on g.ID = c.Gid where c.ID = "+ bd;
            }
            else if (tj == "职位")
            {
                sw = "select * from Class c join Stulnfo s on c.ID = s.Cid  join StuPosition st on st.ID=s.Pid join Grade g on g.ID = c.Gid where st.ID ="+ bd;
            }
            else if (tj == "姓名")
            {
                sw = "select * from Class c join Stulnfo s on c.ID = s.Cid join StuPosition st on st.ID=s.Pid join Grade g on g.ID = c.Gid where s.SStudentName like '%" + bd + "%'";
            }
            DataSet ds = DBHelper.GetDataSet(sw);
            xiugais.DataSource = ds.Tables[0];
        }

        private void xiugais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                int s = (int)xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value;
                new Admin_xueshengok2_1sele(s.ToString()).ShowDialog();
            }
        }
    }
}
