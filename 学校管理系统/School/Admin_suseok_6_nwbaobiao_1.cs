﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_suseok_6_nwbaobiao_1 : Form
    {
        public Admin_suseok_6_nwbaobiao_1()
        {
            InitializeComponent();
        }

        private void Admin_suseok_6_nwbaobiao_1_Load(object sender, EventArgs e)
        {
         
            comnf.Text = DateTime.Now.ToString("yyyy");
            comyf.Text = DateTime.Now.ToString("MM");
            flos.Controls.Clear();
            susenwbaob u = new susenwbaob(comnf.Text,comyf.Text);
                flos.Controls.Add(u);
        }

        private void comyf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flos.Controls.Clear();
            susenwbaob u = new susenwbaob(comnf.Text, comyf.Text);
            flos.Controls.Add(u);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Admin_suseok_5nw)this.ParentForm).FormShow(new Admin_suseok_6_nwbaobiao_2()); 
        }
       
    }
}
