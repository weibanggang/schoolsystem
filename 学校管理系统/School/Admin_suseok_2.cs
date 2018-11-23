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
    public partial class Admin_suseok_2 : Form
    {
        public Admin_suseok_2()
        {
            InitializeComponent();
        }
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        int id;
        private void zhushuguanl2_Load(object sender, EventArgs e)
        {
         se();
        }


        public void se()
        {

            #region#第一次加载
            flos.Controls.Clear();
            string sele = "select * from Dormitory";
             int Au = 0;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                id = (int)dr["ID"];

                Userzhusu1 c = new Userzhusu1(dr["Name"].ToString(),dr["DName"].ToString(), (int)dr["Count"], (int)dr["YCount"], (int)dr["ZZACount"],(int)dr["Lount"], dr["TypeLount"].ToString(), dr["ID"].ToString(), (byte[])dr["IMGF"]);
                Au += Convert.ToInt32(dr["Count"]);

                flos.Controls.Add(c);
            }
            dr.Close();
            string sele1 = "select count(*) from Dormitory";
            int sww = Convert.ToInt32(DBHelper.ExecuteScalar(sele1));
            string sele2 = "select count(*) from Dormitory_information";
            int sww2 = Convert.ToInt32(DBHelper.ExecuteScalar(sele2));
        string sele22 = "select count(*) from tb_Dormitory";
            int sww22 = Convert.ToInt32(DBHelper.ExecuteScalar(sele22));

            lans.Text = "一共:"+sww+"栋楼|"+ sww22 + "间宿舍|可住人数:"+Au+"人|已住人数:"+sww2+"人";
            #endregion
        }

        private void flos_Scroll(object sender, ScrollEventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text=="报表")
            {
               flos.Controls.Clear();
                string db = "select d.Count y,d.YCount p,d.Count-d.YCount o,d.Name b from  Dormitory d";
                SqlDataReader dr = DBHelper.ExecuteReader(db);
            while (dr.Read())
            {
                suselbaob u = new suselbaob(dr["p"].ToString(), dr["o"].ToString(), dr["b"].ToString());
                flos.Controls.Add(u);
            }
            dr.Close();
                button3.Text = "3D模式";
            }

            else
            {
                se();
                button3.Text = "报表";
            }
                
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_suseok_2lfin ss = new School.Admin_suseok_2lfin();
            if (ss.ShowDialog() == DialogResult.OK)
                se();
        }
    }
}
