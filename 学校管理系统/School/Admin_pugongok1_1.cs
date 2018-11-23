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
    public partial class Admin_pugongok1_1 : Form
    {
        public Admin_pugongok1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_pugongok1_into1("录入").ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_pugong_1ok());
        }
        public void FormShow(Form form)
        {
            panzhuangti.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Top;
            form.Parent = panzhuangti;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from EmpInfo", "ESet"));
        }

        private void Admin_pugongok1_1_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from EmpInfo", "ESet"));
        }
    }
}
