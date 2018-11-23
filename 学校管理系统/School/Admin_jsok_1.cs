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
    public partial class Admin_jsok_1 : Form
    {
        public Admin_jsok_1()
        {
            InitializeComponent();
        }

        private void jiaoshigl6_1__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void FormShow(Form frm)
        {
            panzhus.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhus;
            frm.Show();

        }
    }
}
