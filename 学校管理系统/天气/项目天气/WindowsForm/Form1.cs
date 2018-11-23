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
using WindowsForm.WeatherNameSpace;
using System.IO;
namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string 市区;
        

        public string[] WeatherData(string city)
        {
            try
            {
                string[] data = null;

                WeatherNameSpace.WeatherWebService services = new WeatherWebService();
                data = services.getWeatherbyCityName(city);
                return data;
            }
            catch(Exception)
            {
                MessageBox.Show("网络已断开，请连接网络！");
                return null;
            }
        }

        public void outPutData(string [] data)
        {
            if (data != null && data.Length > 0)
            {
                string a = data[0];
                string a2 = data[1];
                string a3 = data[2];
                string a4 = data[3];
                string a5 = data[4];
                string a6 = data[5];
                string a7 = data[6];
                string a8 = data[7];
                string a9 = data[8];
                string a10 = data[9];
                string a11 = data[10];
                string a12 = data[11];
                string a13 = data[12];
                string a14 = data[13];
                string a15 = data[14];
                string a16 = data[15];
                string a17 = data[16];
                string a18 = data[17];
                string a19 = data[18];
                string a20 = data[19];
                string a21 = data[20];

                string 地区 = data[0] +" "+ data[1];  //1
                string 城市 = data[1];                //2
                string 时间 = data[4];                //3
                string 温度区间 = data[5];            //4
                string 天气区间 = data[6];            //5
                string 天气图片1 = data[8];           //A
                string 天气图片2 = data[9];           //B
                string 风向=data[7];                  //6
                string 天气详情=data[10];             //7


                this.label1.Text = 地区;
                this.label2.Text=城市;
                this.label3.Text=时间;
                this.label4.Text=温度区间;
                this.label5.Text=天气区间;
                this.label6.Text = 风向;
                this.label7.Text = 天气详情;
              try
                {
                    this.pictureBox2.Image = Image.FromFile(@"weather\a_" + data[8] + "");
                }
                catch(Exception)
                {
                    this.pictureBox2.Image = Image.FromFile(@"weather\a_1.gif");
                }
            }        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          // pictureBox1.ImageLocation = Application.StartupPath + "~/Resources/0.gif";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1_Click(null, EventArgs.Empty);

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            comboBox1.Text = "省份";
            comboBox2.Text = "市区";

            using (SqlConnection conn = new SqlConnection("server=.\\SQLEXPRESS;database=SchSystem;uid=sa;password=123456"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select proName from promary";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("proName"));
                            comboBox1.Items.Add(name);
                        }
                    }
                }
            }
            ShowNew();
        }
        private void ShowNew()
        {
            restore();
            string city = 市区.Trim();
            string[] weatherData = null;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("请选择您想要查找的城市！");
            }
            else
            {
                weatherData = WeatherData(city);
                outPutData(weatherData);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox2.Items.Clear();
            using (SqlConnection conn = new SqlConnection("server=.\\SQLEXPRESS;database=SchSystem;uid=sa;password=123456"))
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select cityName from city,promary where city.proID=promary.proID and promary.proName=@pname";
                    cmd.Parameters.Add(new SqlParameter("pname", comboBox1.SelectedItem));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("cityName"));
                            
                            comboBox2.Items.Add(name);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
            this.DialogResult = DialogResult.OK;
            this.Close();
            //FrmMain main = new FrmMain();
            //main.showNew();
            //main.FrmMain_Load(null, null);
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
            string 温度 = restore[0];
            string 省份 = restore[1];
            市区 = restore[2];
        }
        private void save()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "天气的数据.txt";
            string path = @".\天气的数据.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(label4.Text + " " + label1.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string a = comboBox2.SelectedItem.ToString();
                if (a != "")
                {
                    string b = a.Substring(0, 2);
                    string city = b.Trim();
                    string[] weatherData = null;
                    if (string.IsNullOrEmpty(city))
                    {
                        MessageBox.Show("请选择您想要查找的城市！");
                    }
                    else
                    {
                        weatherData = WeatherData(city);
                        outPutData(weatherData);
                    }
                }
            }
            catch (Exception)
            {
                restore();
                string city = 市区.Trim();
                string[] weatherData = null;
                if (string.IsNullOrEmpty(city))
                {
                    MessageBox.Show("请选择您想要查找的城市！");
                }
                else
                {
                    weatherData = WeatherData(city);
                    outPutData(weatherData);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
