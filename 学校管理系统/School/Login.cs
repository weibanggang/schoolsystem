using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;

namespace School
{
    public partial class Login : Form
    {
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        /// <summary>  
        /// 窗体动画函数    注意：要引用System.Runtime.InteropServices;  
        /// </summary>  
        /// <param name="hwnd">指定产生动画的窗口的句柄</param>  
        /// <param name="dwTime">指定动画持续的时间</param>  
        /// <param name="dwFlags">指定动画类型，可以是一个或多个标志的组合。</param>  
        /// <returns></returns>
        #region 窗体动画
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        //下面是可用的常量，根据不同的动画效果声明自己需要的  
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志  
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展  
        private const int AW_HIDE = 0x10000;//隐藏窗口  
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志  
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略  
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果
        #endregion
        public Login()
        {
            InitializeComponent();
            
        }
        public void bdss()
        {
            if (File.Exists(bin + "\\账号\\其他\\自动登录.txt"))
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(bin + "\\账号\\其他\\自动登录.txt", FileMode.Open);
                    sr = new StreamReader(fs);
                    zh.Text = sr.ReadLine();
                    if (zh.Text == "no")
                        zh.Text = "";
                    else {
                        chdl.Checked = true;
                        timer1.Enabled = true;
                    }
                }
                catch {

                }
                sr.Close();
                fs.Close();
            }
        }
        private void Login2_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 350, AW_VER_NEGATIVE | AW_ACTIVE | AW_CENTER);//由内向外扩展
            this.skin.SkinFile = Application.StartupPath + @"\Skins\office2007.ssk";
            KeyPreview = true;
            duqu();
            zh.Focus();
            bdss();
            try
            {
                zh.SelectedIndex = 0;
            }
            catch {
            }
          
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(this.pictureBox1.ClientRectangle);
            //Region reg = new Region(path);
            //this.pictureBox1.Region = reg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s = 0;
            if (button1.Text == "安全登录")
            {
                
                mas();
            }
            else {
                button1.Text = "安全登录";
                timer1.Enabled = false;
                progressBar1.Visible = false;
            }
        }
        string bin = Application.StartupPath;//获取文件路径
        string[] files = null;
        public void duqu() {
            zh.Items.Clear();
            files = Directory.GetFiles(bin + "\\账号\\", "*.txt");//获取文件路径赋值
            foreach (string shen in files)
                zh.Items.Add(Path.GetFileNameWithoutExtension(shen));//添加账号   获取文件的名称没有后缀
        }
        /// <summary>
        /// 记住密码
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        private void SavePassword(string name, string pwd)
        {
            try
            {
                FileStream fs = new FileStream("账号\\" + name + ".txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(pwd);
                fs.Flush();
                if (sw != null && fs != null)
                {
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 自动登录
        /// </summary>
        /// <param name="no">判断是否</param>
        private void zddl(string no)
        {
            try
            {
              FileStream fs = new FileStream("账号\\其他\\自动登录.txt", FileMode.Create);
              StreamWriter sw = new StreamWriter(fs);
                 sw.WriteLine(no);
               
                fs.Flush();
              if (sw != null && fs != null)
              {
                  sw.Close();
                  fs.Close();
              }
            }
            catch
            {
            }
        }
        public void mas()
        {
            if (zh.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空");
                return;
            }
            if (mm.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            string sele = "select count(*) from AdminInfo where Uid=@Uid";
            SqlParameter[] p = { new SqlParameter("@Uid", zh.Text) };
            int s = (int)DBHelper.ExecuteScalar(sele, p);
            if (s == 0)
            {  MessageBox.Show("账号不正确");
            return;
            }
            else
            {
                string se = "select count(*) from AdminInfo where Uid=@Uid and Pwd=@Pwd and State='可用'";
                SqlParameter[] ps = {
                   new SqlParameter("@Uid", zh.Text),
                   new SqlParameter("@Pwd", DBHelper.Md5(mm.Text))
                };
                int sw = (int)DBHelper.ExecuteScalar(se, ps);
                if (sw == 0) {
                  MessageBox.Show("密码不正确");
                    return;
                }
                   
                else
                {
                    timer1.Enabled = true;
                }
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void zh_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = "安全登录";
            timer1.Enabled = false;
            progressBar1.Visible = false;
            ReadUserAndPwd();
            
        }
        private void ReadUserAndPwd()
        {
            
            if (File.Exists(bin + "\\账号\\" + zh.Text + ".txt"))
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(bin + "\\账号\\" + zh.Text + ".txt", FileMode.Open);
                    sr = new StreamReader(fs);
                    mm.Text = sr.ReadLine();
                    chjz.Checked = true;
                }
                catch { }
                sr.Close();
                fs.Close();
            }
            else {
                chjz.Checked = false;
                mm.Text = "";
            }
        }

        private void zh_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "安全登录";
            timer1.Enabled = false;
            progressBar1.Visible = false;
            ReadUserAndPwd();
            
        }
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Visible = true;
            progressBar1.Value = s++;
            if (s == 10) {
                button1.Text = "正在登录中.";
            }
            if (s == 40)
            {
                button1.Text = "正在登录中..";
            }
            if (s == 90)
            {
                button1.Text = "正在登录中...";
            }
            if (s ==95)
            {
                button1.Text = "登录成功";
            }
            if (s > 100)
            {
                timer1.Enabled = false;
                string sew = "select * from AdminInfo where Uid=@Uid and Pwd=@Pwd and State='可用'";
                SqlParameter[] psw = {
                   new SqlParameter("@Uid", zh.Text),
                   new SqlParameter("@Pwd", DBHelper.Md5(mm.Text))
                };
                SqlDataReader drw = DBHelper.ExecuteReader(sew, psw);
                string us = null;
                int ID = 0;
                string uids = null;
                while (drw.Read())
                {
                    us = drw["Tid"].ToString();
                    ID = ((int)drw["ID"]);
                    uids = drw["Uid"].ToString();
                }
                drw.Close();

                    if (chjz.Checked)
                    {
                        SavePassword(zh.Text, mm.Text);
                    }
                if (chdl.Checked)
                {
                    zddl(zh.Text);
                }
                else {
                    zddl("no");
                }
                    if (us == "管理员")
                    {
                        this.Hide();
                        new Login1(us, uids).Show();
                    }
                    else
                    {
                        this.Hide();
                        new Admin_Adminok_2(us, uids).Show();

                    }

                    string dly = "insert into denglu Values(@times,@AMID,@Uids,@us)";
                    SqlParameter[] dlyp = {
                        new SqlParameter("@times",DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")),
                        new SqlParameter("@AMID",ID),
                        new SqlParameter("@Uids",uids),
                        new SqlParameter("@us",us)
                    };
                    DBHelper.ExecuteNonQuery(dly, dlyp);
                }
            }

        private void chdl_Click(object sender, EventArgs e)
        {
            if (chdl.Checked)
                chjz.Checked = true;
        }

        private void chjz_Click(object sender, EventArgs e)
        {
            if (chjz.Checked==false)
                chdl.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mm_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "安全登录";
            timer1.Enabled = false;
            progressBar1.Visible = false;
        }
    }
    }

