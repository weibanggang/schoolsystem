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
    public partial class Admin_suseok_sfok_1 : Form
    {
        public Admin_suseok_sfok_1()
        {
            InitializeComponent();
        }
        
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panzhuangti;
            frm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_suseok_sfinto());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           FormShow(new Admin_suseok_sfintoshow());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_suseok_sfbiaobiao1());
        }

        private void Admin_suseok_sfok_1_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_suseok_sfbiaobiao1());
        }

    }
}
