using System;
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
    public partial class Admin_xueshengok_1baobiao : Form
    {
        string sele = null;
        string sex = null;
        public Admin_xueshengok_1baobiao(string sele,string sex)
        {
            InitializeComponent();
            this.sele = sele;
            this.sex = sex;
        }

        private void Admin_xueshengok_1baobiao_Load(object sender, EventArgs e)
        {
            int y = 0;
            int k = 0;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (dr[sex].ToString() == "男")
                    y++;
                else
                    k++;
            }
            dr.Close();
            xueshengxinxibaobiao u = new xueshengxinxibaobiao(y, k);
                panel1.Controls.Add(u);
        }
    }
}
