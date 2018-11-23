using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.WeatherNameSpace;
using System.IO;

namespace WindowsForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        string 市区 = null;
        string 温度 = null;
        string 省份 = null;
        public void FrmMain_Load(object sender, EventArgs e)
        {
            showNew();
            timer1.Start();
            DateTime dt = DateTime.Now;
            string XingQi = Convert.ToString(dt.DayOfWeek);//星期
            if (XingQi == "Monday")//星期判断
            {
                lanxq.Text = "周一";
            }
            else if (XingQi == "Tuesday")
            {
                lanxq.Text = "周二";
            }
            else if (XingQi == "Wednesday")
            {
                lanxq.Text = "周三";
            }
            else if (XingQi == "Thursday")
            {
                lanxq.Text = "周四";
            }
            else if (XingQi == "Friday")
            {
                lanxq.Text = "周五";
            }
            else if (XingQi == "Saturday")
            {
                lanxq.Text = "周六";
            }
            else if (XingQi == "Sunday")
            {
                lanxq.Text = "周日";
            }

            string yyyy = DateTime.Now.ToString("yyyy");
                string mm = DateTime.Now.ToString("MM");
            string dd = DateTime.Now.ToString("dd");

            label1.Text =yyyy+"年"+mm+"月"+ dd+"日";
        }
        public void showNew()
        {
            restore();
            string city = 市区.Trim();
            string[] weatherData = null;
            if (string.IsNullOrEmpty(city))
            {
            }
            else
            {
                weatherData = WeatherData(city);
                outPutData(weatherData);
            }
            save();
        }
        public string[] WeatherData(string city)
        {
            try
            {
                string[] data = null;
                WeatherNameSpace.WeatherWebService services = new WeatherWebService();
                data = services.getWeatherbyCityName(city);
                return data;
            }
            catch (Exception)
            {
                this.label2.Text = 省份 + " " + 市区;
                this.labtime.Text = 温度;
                this.pictureBox1.Image = Image.FromFile(@"weather\a_1.gif");
                save();
                return null;
            }
        }
        public void outPutData(string[] data)
        {
            if (data != null && data.Length > 0)
            {
                if (data[0] != "访问被限制！")
                {
                    this.label2.Text = data[0] + " " + data[1];
                    this.labtime.Text = data[5];
                   //this.lantq.Text = data[6].Split(' ')[1];

                }
                if (data[0] != "系统维护中！")
                {
                    this.label2.Text = data[0] + " " + data[1];
                    this.labtime.Text = data[5];
                    //this.lantq.Text = data[6].Split(' ')[1];

                }
                else
                {
                    this.label2.Text = 省份+ " " +市区 ;
                    this.labtime.Text = 温度;
                    this.pictureBox1.Image = Image.FromFile(@"weather\a_1.gif");
                    save();
                }
                try
                {
                    this.pictureBox1.Image = Image.FromFile(@"weather\a_" + data[8] + "");
                }
                catch (Exception)
                {
                    this.pictureBox1.Image = Image.FromFile(@"weather\a_1.gif");
                }
            }
        }
        private void save()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "天气的数据.txt";
            string path = @".\天气的数据.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(labtime.Text + " " +label2.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        private void restore()
        {
            string path = @".\天气的数据.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string message = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            string[] restore = message.Split(' ');
            温度 = restore[0];
            省份= restore[1];
            市区= restore[2];
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.showNew();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lantq_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labsj.Text = DateTime.Now.ToString("HH") + ":" + DateTime.Now.ToString("mm");
        }
    }
}
