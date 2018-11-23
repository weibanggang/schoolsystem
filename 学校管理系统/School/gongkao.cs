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
    public partial class gongkao : UserControl
    {
        public gongkao()
        {
            InitializeComponent();
        }
        private Label label = new Label();
        public string text = "csdn baihe_591按实际电话卡时间段将卡仕达尽快哈数据库等哈说就好打卡上登记卡圣诞节卡时间段卡萨";//文字
        
        PointF p;
        Font f = new Font("宋体", 20);
        Color c = Color.FromArgb(216, 229, 250);
        string temp;
        private void gongkao_Load(object sender, EventArgs e)
        {
            string selec = "select gname from gk  ";
           SqlDataReader dr=DBHelper.ExecuteReader(selec);
            while (dr.Read())
            {
                if(dr["gname"].ToString()!=null)
                text = dr["gname"].ToString();
            }dr.Close();
            this.label.Location = new Point(0, 0);
            this.label.Size = new Size(681, 30);
            this.Controls.Add(label);
            this.label.Text = "";
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.label.CreateGraphics();
            SizeF s = new SizeF();
            s = g.MeasureString(text, f);//测量文字长度  
            Brush brush = Brushes.RoyalBlue;
            g.Clear(c);//清除背景 
            if (temp != text)//文字改变时,重新显示  
            {
                p = new PointF(this.label.Size.Width, 0);
                temp = text;
            }
            else
                p = new PointF(p.X - 10, 0);//每次偏移10  


            if (p.X <= -s.Width)
                p = new PointF(this.label.Size.Width, 0);
            g.DrawString(text, f, brush, p);

        }
    }
}
