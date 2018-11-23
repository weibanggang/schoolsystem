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
    public partial class Admin_suseok_sfbiaobiao1 : Form
    {
        public Admin_suseok_sfbiaobiao1()
        {
            InitializeComponent();
        }

        private void Admin_suseok_sfbiaobiao1_Load(object sender, EventArgs e)
        {
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susesfbaob u = new susesfbaob("水量",comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();

            susesfbaob u = new susesfbaob("水量",comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_sfok_1)this.ParentForm).FormShow(new Admin_suseok_sfbiaobiao2_1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();
            susesfbaob u = new susesfbaob("价钱", comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }
    }
}
