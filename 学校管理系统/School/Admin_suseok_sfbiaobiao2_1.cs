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
    public partial class Admin_suseok_sfbiaobiao2_1 : Form
    {
        public Admin_suseok_sfbiaobiao2_1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            did = (int)comlm.SelectedValue;
            flos.Controls.Clear();
            susesfbaob u = new susesfbaob(did, comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }
        int did = 0;
        private void Admin_suseok_sfbiaobiao2_1_Load(object sender, EventArgs e)
        {
            lc();
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susesfbaob u = new susesfbaob(did, comnf.Text, comyf.Text);
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
            ((Admin_suseok_sfok_1)this.ParentForm).FormShow(new Admin_suseok_6_sfbaobiao_3());
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            did = (int)comlm.SelectedValue;
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susesfbaob u = new susesfbaob(did, comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_sfok_1)this.ParentForm).FormShow(new Admin_suseok_sfbiaobiao1());
        }
    }
}
