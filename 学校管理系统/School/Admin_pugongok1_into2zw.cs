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
    public partial class Admin_pugongok1_into2zw : Form
    {
        public Admin_pugongok1_into2zw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("名称不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            string sele = "select * from EmpPosition";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (txtname.Text == dr["PName"].ToString())
                {
                    MessageBox.Show("已有该名称", "提示", MessageBoxButtons.OK);
                    dr.Close();
                    return;
                }

            }
            dr.Close();

            string into = "insert into EmpPosition Values(@name)";
            SqlParameter[] p = { new SqlParameter("@name", txtname.Text) };
            int d = DBHelper.ExecuteNonQuery(into, p);
            if (d > 0)
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
            else
                MessageBox.Show("添加失败");
        }

        private void Admin_pugongok1_into2zw_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }
    }
}
