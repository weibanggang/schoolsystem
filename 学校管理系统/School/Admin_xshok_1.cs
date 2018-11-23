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
    public partial class Admin_xshok_1 : Form
    {
        public Admin_xshok_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xsh_select());
        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhuangti;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_xsh2().ShowDialog();
        }

        private void Admin_xshok_1_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_xsh_select());
        }
    }
}
