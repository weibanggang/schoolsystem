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
    public partial class Admin_suseok_6_sfbaobiao_3 : Form
    {
        public Admin_suseok_6_sfbaobiao_3()
        {
            InitializeComponent();
        }

        private void Admin_suseok_6_sfbaobiao_3_Load(object sender, EventArgs e)
        {
            lc();
            comnf.Text = DateTime.Now.ToString("yyyy");
            flos.Controls.Clear();
            susesfbaobxx u = new susesfbaobxx(comnf.Text, comfh.Text, (int)comlm.SelectedValue);
           flos.Controls.Add(u);
        }
        public void lc()
        {
            string sele = "select d.ID,d.Name from sfinto n join Dormitory d  on n.Did=d.ID group by Name,d.ID";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();
            susesfbaobxx u = new susesfbaobxx(comnf.Text, comfh.Text, (int)comlm.SelectedValue);
            flos.Controls.Add(u);
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            fh();
        }
        public void fh()
        {
            string fh = "  select DormitoryNO from sfinto n join Dormitory d  on n.Did=d.ID   where Did=" + comlm.SelectedValue + " group by DormitoryNO,Did";
            DataSet ds = DBHelper.GetDataSet(fh);
            comfh.DisplayMember = "DormitoryNO";
            comfh.ValueMember = "ID";
            comfh.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_sfok_1)this.ParentForm).FormShow(new Admin_suseok_sfbiaobiao2_1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();
            susesfbaobxx u = new susesfbaobxx("钱",comnf.Text, comfh.Text, (int)comlm.SelectedValue);
            flos.Controls.Add(u);
        }
    }
}
