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
using System.IO;
using Process;
using System.Threading;

namespace School
{
    public partial class Userzhusu1 : UserControl
    {
        public Userzhusu1()
        {
            InitializeComponent();
        }


        
        public Userzhusu1(string LName,string dh, int Kzrs, int Yz, int Js, int v, string Cs, string Tig, byte[] sele1)
        {
            
            InitializeComponent();
            labnumbers.Text = LName;//--楼名称
            labzks.Text = Kzrs.ToString();//可住人数
            labpeops.Text = Js.ToString();//总间数
            cs.Text = v.ToString();//宿舍楼总楼层
            labyzrs.Text = Yz.ToString();//已住人数
            btngo.Tag = Tig;//宿舍楼ID
            lanlx.Text = Cs;
            bls.Text = dh;
            MemoryStream ms = new MemoryStream(sele1);
            Bitmap bmp = new Bitmap(ms);
           shushetp.Image = bmp;//图片
            if(Yz==0)
            {
                pros.Value = 0;
                labbl.Text = "0%";//入住比率
            }
            else
            {

                pros.Maximum = Kzrs;
                if ((Convert.ToDouble(Yz) / Convert.ToDouble(Kzrs) * 100).ToString().Trim().Length > 4)
                {
                    labbl.Text = (Convert.ToDouble(Yz) / Convert.ToDouble(Kzrs) * 100).ToString().Substring(0, 3) + "%";//入住比率
                 
                }
                else
                {
                    labbl.Text = (Convert.ToDouble(Yz) / Convert.ToDouble(Kzrs) * 100).ToString() + "%";//入住比率
                }
                  
                pros.Value = Yz;

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

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_suseok_4 frm = new School.Admin_suseok_4(btngo.Tag.ToString(), labnumbers.Text);
            
            ((Admin_suseok_1)this.ParentForm.ParentForm).FormShow(frm);
            
          
            
        }
        void Do()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void Userzhusu1_Load(object sender, EventArgs e)
        {
            

        }
   

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             byte[] sw = DBHelper.byPictureBox(shushetp);
            if (sw == null)
                return;
            string up = "update Dormitory set IMGF=@IMGF where ID=" + btngo.Tag;
            SqlParameter[] p = {
                new SqlParameter("@IMGF",sw)
            };
            int dr = DBHelper.ExecuteNonQuery(up, p);
        }
    }
}
