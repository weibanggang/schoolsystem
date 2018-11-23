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
    public partial class Admin_xueshengok_1xx : Form
    {
        public Admin_xueshengok_1xx()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FormShow(new Admin_xueshengok_1sele("查询"));
        }
        public void FormShow(Form form)
        {
            panzhuangti.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Parent = panzhuangti;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_xueshengok_2_1ifin frm = new Admin_xueshengok_2_1ifin("录入信息");
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from Stulnfo", "StudentSex"));
            
        }

        private void Admin_xueshengok_1xx_Load(object sender, EventArgs e)
        {
            FormShow(new Admin_xueshengok_1baobiao("select * from Stulnfo", "StudentSex"));
        }
    }
}
