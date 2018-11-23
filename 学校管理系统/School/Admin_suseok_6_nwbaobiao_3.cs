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
    public partial class Admin_suseok_6_nwbaobiao_3 : Form
    {
        public Admin_suseok_6_nwbaobiao_3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();
            suseneiwbaobxx u = new suseneiwbaobxx(comnf.Text, comyf.Text, comfh.Text, comlm.Text);
            flos.Controls.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwbaobiao_2());
        }

        private void Admin_suseok_6_nwbaobiao_3_Load(object sender, EventArgs e)
        {
            lc();
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            suseneiwbaobxx u = new suseneiwbaobxx(comnf.Text, comyf.Text, comfh.Text, comlm.Text);
            flos.Controls.Add(u);
        }
        public void lc()
        {
            string sele = "select d.ID,d.Name from Neiwu n join Dormitory d  on n.Did=d.Name group by Name,d.ID";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
        }
        public void fh()
        {
            string fh = "  select DormitoryNO from Neiwu n join Dormitory d  on n.Did=d.Name   where Did='"+comlm.Text+"' group by DormitoryNO,Did" ;
            DataSet ds = DBHelper.GetDataSet(fh);
            comfh.DisplayMember = "DormitoryNO";
            comfh.ValueMember = "ID";
            comfh.DataSource = ds.Tables[0];
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            fh();
        }

        private void comfh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
