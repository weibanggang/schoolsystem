using Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_suseok_4 : Form
    {
        public Admin_suseok_4()
        {
            InitializeComponent();
        }
        string Tags;//宿舍楼ID
        string name;//楼名
        public Admin_suseok_4(string Tag, string name)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Tags = Tag;
            this.name = name;
        }
        
        private void zhushuguanl3_Load(object sender, EventArgs e)
        {
            PercentProcessOperator process = new PercentProcessOperator();
            process.BackgroundWork = this.DoWithProcess;
            process.MessageInfo = "正在执行中";
            process.BackgroundWorkerCompleted += new EventHandler<BackgroundWorkerEventArgs>(process_BackgroundWorkerCompleted);
            process.Start();
            seles();
           
        }

        void DoWithProcess(Action<int> percent)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
                percent(i);
            }
        }

        void process_BackgroundWorkerCompleted(object sender, BackgroundWorkerEventArgs e)
        {
            if (e.BackGroundException == null)
            {
               
            }
            else
            {
                MessageBox.Show("异常:" + e.BackGroundException.Message);
            }
        }
        
        public void seles()
        {
          int sww = 0;
          
            string sele = "select * from tb_Dormitory  where Did=" + Tags ; //宿舍楼ID
             SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                try
                {
                    Usshuse sw = new Usshuse((int)dr["ID"], dr["DonID"].ToString(), (int)dr["Count"], (int)dr["YCount"], dr["BCount"].ToString(), dr["zt"].ToString(), Tags, name);
                    sww += Convert.ToInt32(dr["YCount"]);
                    flos.Controls.Add(sw);
                }
                catch
                {

                }
               
               
                
            }
            dr.Close();
            
            string ssw = "select ID from tb_Dormitory where Did=" + Tags.ToString();
            string s = DBHelper.ExecuteNonQuery(ssw).ToString();
            lanrens.Text ="楼名:"+name + " | 一共:" + sww + "人";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_suseok_2 frm = new School.Admin_suseok_2();
            ((Admin_suseok_1)this.ParentForm).FormShow(frm);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Admin_suseok_4ifin ss = new Admin_suseok_4ifin(Tags);
            if (ss.ShowDialog() == DialogResult.OK)
            {
                seles();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            string na = "select DormitoryNO from Dormitory_information where  Name like '" + txtok.Text + "%'";
            SqlDataReader dr2 = DBHelper.ExecuteReader(na);
            string[] swws = new string[100];
            int s = 0;
            while (dr2.Read())
            {

                swws[s] = dr2["DormitoryNO"].ToString();
                s++;

            }
            dr2.Close();
         
            if (s ==0)
            {
                MessageBox.Show("你好，没有这个人");
                return;
            }
            flos.Controls.Clear();
            for(int i= 0;i <s;i++)
            {
                if(swws[i]=="")
                    return;
                string sele = "select * from tb_Dormitory  where ID=" + swws[i];
                SqlDataReader dr = DBHelper.ExecuteReader(sele);
                while (dr.Read())
                {
                    if(dr["DonID"].ToString()=="")
                    {
                        return;
                    }
                    Usshuse sw = new Usshuse((int)dr["ID"], dr["DonID"].ToString(), (int)dr["Count"], (int)dr["YCount"], dr["BCount"].ToString(), dr["zt"].ToString(), Tags, name);
                   flos.Controls.Add(sw);
                    flos.Controls.SetChildIndex(sw, flos.Controls.Count - 2);
                }
                dr.Close();
            }

        }

        private void flos_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flos_MouseClick(object sender, MouseEventArgs e)
        {
            this.flos.Focus();
            
            //MessageBox.Show(i.ToString());
        }
    }
}
                
               
