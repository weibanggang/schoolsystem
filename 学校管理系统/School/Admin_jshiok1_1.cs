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
    public partial class Admin_jshiok1_1 : Form
    {
        public Admin_jshiok1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_jshiok1_jsxinxi frm = new Admin_jshiok1_jsxinxi("录入信息");
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow(new xiugaiss());
        }

        private void Admin_jshiok1_1_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from TeaInfo", "TSex"));
        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Top;
            frm.Parent = panzhuangti;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from TeaInfo", "TSex"));
        }
    }
}
