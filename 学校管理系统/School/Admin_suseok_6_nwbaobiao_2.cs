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
    public partial class Admin_suseok_6_nwbaobiao_2 : Form
    {
        public Admin_suseok_6_nwbaobiao_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwbaobiao_1());
        }

        private void Admin_suseok_6_nwbaobiao_2_Load(object sender, EventArgs e)
        {
            lc();
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susenwbaob u = new susenwbaob(did,comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }
        public void lc()
        {
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwbaobiao_3());
          
        }
        string did=null;
        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
             did = comlm.Text;
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susenwbaob u = new susenwbaob(did,comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            did = comlm.Text;
            flos.Controls.Clear();
            susenwbaob u = new susenwbaob(did,comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }
    }
}
