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
    public partial class Admin_suseok_weixiu_1 : Form
    {
        public Admin_suseok_weixiu_1()
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

        private void Admin_suseok_weixiu_1_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_suseok_wxinto_1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_suseok_wxinto_1());
        }

        private void button5_Click(object sender, EventArgs e)
        {
           FormShow(new Admin_suseok_wxupda_1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
                FormShow(new Admin_suseok_wxsele_1());
        }
        
    }
}
