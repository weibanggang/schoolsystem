using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace School
{
    public partial class dlqk : UserControl
    {
        public dlqk()
        {
            InitializeComponent();
            uid = "dsa";
        }
        string id = null;
        string uid = null;
        public dlqk(string id)
        {
            InitializeComponent();
            this.id = id;

        }
        public dlqk(string id, string uid)
        {
            InitializeComponent();
            this.id = id;
            this.uid = uid;
        }
        private void dlqk_Load(object sender, EventArgs e)
        {
            if (uid == null)
            {
                string sele = "select * from denglu where us='" + id + "'";
                SqlDataReader dr = DBHelper.ExecuteReader(sele);
                int s = 0;
                string Uids = null;
                string[] arr = new string[14];
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    arr[s] = dr["times"].ToString();
                    Uids = dr["Uids"].ToString();
                    if (s == 13)
                        s = 0;
                    s++;
                }
                dr.Close();
                string sele1 = "select * from AdminInfo where Uid='" + Uids + "'";
                SqlDataReader dr1 = DBHelper.ExecuteReader(sele1);
                string Name = null;
                while (dr1.Read())
                {
                    Name = dr1["Name"].ToString();
                }
                dr1.Close();

                if (arr[0] != null)
                    label1.Text = arr[0].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[1] != null)
                    label2.Text = arr[1].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[2] != null)
                    label3.Text = arr[2].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[3] != null)
                    label4.Text = arr[3].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[4] != null)
                    label5.Text = arr[4].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[5] != null)
                    label6.Text = arr[5].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[6] != null)
                    label7.Text = arr[6].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[7] != null)
                    label8.Text = arr[7].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[8] != null)
                    label9.Text = arr[8].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[9] != null)
                    label10.Text = arr[9].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[10] != null)
                    label11.Text = arr[10].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[11] != null)
                    label12.Text = arr[11].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[12] != null)
                    label13.Text = arr[12].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
                if (arr[13] != null)
                    label14.Text = arr[13].ToString() + " " + id + "(" + Name.Substring(0, 1) + "**)登录";
            }
            else
            {
                string sele = "select * from denglu";
                SqlDataReader dr = DBHelper.ExecuteReader(sele);
                int s = 0;
                string[] Uids = new string[14];
                string[] arr = new string[14];
                string[] id = new string[14];
                while (dr.Read())
                {
                    arr[s] = dr["times"].ToString();
                    id[s] = dr["us"].ToString();
                    Uids[s] = dr["Uids"].ToString();
                    if (s == 13)
                        s = 0;
                    s++;
                }
                dr.Close();
                string[] Name = new string[14];
                for (int i = 0; i < id.Length; i++)
                {
                    string sele1 = "select * from AdminInfo where Uid='" + Uids[i] + "'";
                    SqlDataReader dr1 = DBHelper.ExecuteReader(sele1);
                    while (dr1.Read())
                    {
                        Name[i] = dr1["Name"].ToString();
                    }
                    dr1.Close();
                }
              
                
                if (Name[0] != null)
                    label1.Text = arr[0].ToString() + " " + id[0].ToString() + "(" + Name[0].Substring(0, 1) + "**)登录";
                if (Name[1] != null)
                    label2.Text = arr[1].ToString() + " " + id[1].ToString() + "(" + Name[1].Substring(0, 1) + "**)登录";
                if (arr[2] != null)
                    label3.Text = arr[2].ToString() + " " + id[2].ToString() + "(" + Name[2].Substring(0, 1) + "**)登录";
                if (arr[3] != null)
                    label4.Text = arr[3].ToString() + " " + id[3].ToString() + "(" + Name[3].Substring(0, 1) + "**)登录";
                if (arr[4] != null)
                    label5.Text = arr[4].ToString() + " " + id[4].ToString() + "(" + Name[4].Substring(0, 1) + "**)登录";
                if (arr[5] != null)
                    label6.Text = arr[5].ToString() + " " + id[5].ToString() + "(" + Name[5].Substring(0, 1) + "**)登录";
                if (arr[6] != null)
                    label7.Text = arr[6].ToString() + " " + id[6].ToString() + "(" + Name[6].Substring(0, 1) + "**)登录";
                if (arr[7] != null)
                    label8.Text = arr[7].ToString() + " " + id[7].ToString() + "(" + Name[7].Substring(0, 1) + "**)登录";
                if (arr[8] != null)
                    label9.Text = arr[8].ToString() + " " + id[8].ToString() + "(" + Name[8].Substring(0, 1) + "**)登录";
                if (arr[9] != null)
                    label10.Text = arr[9].ToString() + " " + id[9].ToString() + "(" + Name[9].Substring(0, 1) + "**)登录";
                if (arr[10] != null)
                    label11.Text = arr[10].ToString() + " " + id[10].ToString() + "(" + Name[10].Substring(0, 1) + "**)登录";
                if (arr[11] != null)
                    label12.Text = arr[11].ToString() + " " + id[11].ToString() + "(" + Name[11].Substring(0, 1) + "**)登录";
                if (arr[12] != null)
                    label13.Text = arr[12].ToString() + " " + id[12].ToString() + "(" + Name[12].Substring(0, 1) + "**)登录";
                if (arr[13] != null)
                    label14.Text = arr[13].ToString() + " " + id[13].ToString() + "(" + Name[13].Substring(0, 1) + "**)登录";
            }
            
            this.timer1.Enabled = true;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 3);
            if (panel1.Location.Y < -240)
            {
                panel1.Location = new Point(panel1.Location.X, 240);
            }
        }
    }
}
