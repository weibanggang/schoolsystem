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
    public partial class Admin_suseok_sfupdateshow : Form
    {
        public Admin_suseok_sfupdateshow()
        {
            InitializeComponent();
        }
        int id;
        string electricstart;
        string electricend;
        string waterstart;
        string waterend;
        string df;
        string sf;
        public Admin_suseok_sfupdateshow(int id,string electricstart, string electricend, string waterstart, string waterend,string df,string sf)
        {
            InitializeComponent();
            this.id = id;
            textBox1.Text=this.electricstart = electricstart;
            textBox2.Text= this.electricend = electricend;
            textBox4.Text = this.waterstart = waterstart;
            textBox5.Text= this.waterend = waterend;
            this.df = df;
            this.sf = sf;
            textBox7.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(df)).ToString();
            textBox8.Text = (Convert.ToDouble(textBox6.Text) * Convert.ToDouble(sf)).ToString();
        }

        private void Admin_suseok_sfupdateshow_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.textBox1.ImeMode = ImeMode.Off;
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.textBox2.ImeMode = ImeMode.Off;
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.textBox4.ImeMode = ImeMode.Off;
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.textBox5.ImeMode = ImeMode.Off;
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try{ 
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            double s1 = Convert.ToDouble(textBox1.Text);
            double s2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (s1 + s2).ToString();
        }
            catch
            {
                MessageBox.Show("输入有误");
                textBox1.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                double s1 = Convert.ToDouble(textBox1.Text);
                double s2 = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (s1 + s2).ToString();
            }
            catch
            {
                MessageBox.Show("输入有误");
                textBox2.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";
                }
                if (textBox5.Text == "")
                {
                    textBox5.Text = "0";
                }
                double s4 = Convert.ToDouble(textBox4.Text);
                double s5 = Convert.ToDouble(textBox5.Text);
                textBox6.Text = (s4 + s5).ToString();
            }
            catch
            {
                MessageBox.Show("输入有误");
                textBox4.Text = "0";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";
                }
                if (textBox5.Text == "")
                {
                    textBox5.Text = "0";
                }
                double s4 = Convert.ToDouble(textBox4.Text);
                double s5 = Convert.ToDouble(textBox5.Text);
                textBox6.Text = (s4 + s5).ToString();
            }
            catch
            {
                MessageBox.Show("输入有误");
                textBox5.Text = "0";
            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "0";
            textBox7.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(df)).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update sfinto set electricstart=@electricstart,electricend=@electricend,electriccharg=@electriccharg,electricprice=@electricprice,waterstart=@waterstart,waterend=@waterend,watercharg=@watercharg,waterprice=@waterprice where sfintoID="+id;
            SqlParameter[] p =
            {
                new SqlParameter("@electricstart", textBox1.Text),
                 new SqlParameter("@electricend", textBox2.Text),
                  new SqlParameter("@electriccharg", textBox3.Text),
                   new SqlParameter("@electricprice", textBox7.Text),
                   new SqlParameter("@waterstart", textBox4.Text),
                    new SqlParameter("@waterend", textBox5.Text),
                    new SqlParameter("@watercharg", textBox6.Text),
                     new SqlParameter("@waterprice", textBox8.Text)
            };
            if (DBHelper.ExecuteNonQuery(sql, p) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
           else
            {
                MessageBox.Show("修改失败");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                textBox6.Text = "0";
          
            textBox8.Text = (Convert.ToDouble(textBox6.Text) * Convert.ToDouble(sf)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
