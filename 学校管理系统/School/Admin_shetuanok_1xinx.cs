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
    public partial class Admin_shetuanok_1xinx : Form
    {
        public Admin_shetuanok_1xinx()
        {
            InitializeComponent();
        }

        private void Admin_shetuanok_1xinx_Load(object sender, EventArgs e)
        {
            panzhuangti.Visible = true;
            FormShow(new Admin_shetuanok_3("修改"));
        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhuangti;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panzhuangti.Visible = true;
            FormShow(new Admin_shetuanok_3("修改"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_shetuanok_2ifin ss = new Admin_shetuanok_2ifin();
            ss.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
