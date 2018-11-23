using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School
{
    public partial class Admin_Adminok_2ck : Form
    {
        string id = null;
        public Admin_Adminok_2ck(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Adminok_2ck_Load(object sender, EventArgs e)
        {
            string sele = "select * from fangui where id="+id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                textname.Text = dr["Name"].ToString();
                texttime.Text = dr["times"].ToString();
                textzt.Text = dr["zhiti"].ToString();
                textnr.Text = dr["neir"].ToString();
            }
            dr.Close();

        }
    }
}
