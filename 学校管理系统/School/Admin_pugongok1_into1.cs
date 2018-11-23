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
using System.IO;
using System.Text.RegularExpressions;

namespace School
{
    public partial class Admin_pugongok1_into1 : Form
    {
        string lur;
        string id;
        string[] files = null;
        string bin = Application.StartupPath;
        string[] w = null;
        string ss;
        public Admin_pugongok1_into1(string lur)
        {
            InitializeComponent();
            this.lur = lur;
        }
        public Admin_pugongok1_into1(string lur, string id)
        {
            InitializeComponent();
            this.lur = lur;
            this.id = id;
        }
        private void Admin_pugongok1_into1_Load(object sender, EventArgs e)
        {
            zm();
            EName.Focus();
            sele();
            if (lur == "录入")
            {
                EUid.Text = DateTime.Now.ToString(0 + "yyyymmddss");
            }

            if (lur == "修改")
            {
                btngo.Text = "修改";
                this.Text = "修改员工信息";
                pic();
                up();
            }
            if (lur == "普工")
            {
                btngogo.Visible = false;
                btngos.Visible = false;
                moren.Visible = false;
                btngo.Text = "修改";
                this.Text = "修改员工信息";
                pics();
                ups();
            }

        }
        public void zm()
        {
            string[] ss = Directory.GetFiles(Application.StartupPath, "民族.txt");
            FileStream sr = new FileStream(ss[0], FileMode.Open);//读取文件路径
            StreamReader sw = new StreamReader(sr, Encoding.Default);//文件翻译
            string str = null;
            while ((str = sw.ReadLine()) != null)
            {
                EmpNation.Items.Add(str);
            }
            sr.Close();
            sw.Close();
            EmpNation.SelectedIndex = 0;
            files = Directory.GetFiles(bin + "\\Area\\", "*.txt");//获取文件路径赋值
            foreach (string shen in files)
                comsheng.Items.Add(Path.GetFileNameWithoutExtension(shen));//添加省份   获取文件的名称没有后缀
            EmpFace.SelectedIndex = 0;
            EmpEducate.SelectedIndex = 1;
        }
        private void pic()
        {
            string sele1 = "select IMGF from EmpInfo where ID=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele1);
            while (dr.Read())
            {
                if (dr["IMGF"].ToString() == "")
                {
                    dr.Close();
                    return;
                }
            }
            dr.Close();
            pictureBox1.Visible = true;
            button3.Text = "更换照片";
            pictureBox1.Image = DBHelper.Read(sele1);
        }
        private void pics()
        {
            string sele1 = "select IMGF from EmpInfo where EUid=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele1);
            while (dr.Read())
            {
                if (dr["IMGF"].ToString() == "")
                {
                    dr.Close();
                    return;
                }
            }
            dr.Close();
            pictureBox1.Visible = true;
            button3.Text = "更换照片";
            pictureBox1.Image = DBHelper.Read(sele1);
        }
       
      
        public void into()
        {

            string hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            if (sw != null)
            {
                string into = "insert into EmpInfo([EUid],[EPwd],[EName],[ESet],[EBirthday],[Tid]," +
     "[Pid],[EmpNation],[EmpFace],[EmpIDT],[EmpEducate],[EWedding],[ETell],[EPhone],[EIDAd],[EJG],[TRemarks],[IMGF])" +
     " values(@EUid,@EPwd,@EName,@ESet,@EBirthday,@Tid,@Pid,@EmpNation,@EmpFace,@EmpIDT,@EmpEducate,@EWedding,@ETell," +
     "@EPhone,@EIDAd,@EJG,@TRemarks,@IMGF)";
                SqlParameter[] p =
                {
                new SqlParameter("@EUid",EUid.Text),
                new SqlParameter("@EPwd", DBHelper.Md5(txtpwd.Text)),
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
               new SqlParameter("@EBirthday",ids.ToString()),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text),
                new SqlParameter("@IMGF",sw)
            };
                int d = DBHelper.ExecuteNonQuery(into, p);
                if (d > 0)
                {
                    MessageBox.Show("录入成功", "提示", MessageBoxButtons.OK);
                    qk();
                }
                else
                    MessageBox.Show("录入失败", "提示", MessageBoxButtons.OK);

            }
            else
            {
                string into = "insert into EmpInfo([EUid],[EPwd],[EName],[ESet],[EBirthday],[Tid]," +
     "[Pid],[EmpNation],[EmpFace],[EmpIDT],[EmpEducate],[EWedding],[ETell],[EPhone],[EIDAd],[EJG],[TRemarks])" +
     " values(@EUid,@EPwd,@EName,@ESet,@EBirthday,@Tid,@Pid,@EmpNation,@EmpFace,@EmpIDT,@EmpEducate,@EWedding,@ETell," +
     "@EPhone,@EIDAd,@EJG,@TRemarks)";
                SqlParameter[] p =
                {
                new SqlParameter("@EUid",EUid.Text),
                new SqlParameter("@EPwd", DBHelper.Md5(txtpwd.Text)),
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
                new SqlParameter("@EBirthday",ids.ToString()),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text)
            };
                int d = DBHelper.ExecuteNonQuery(into, p);
                if (d > 0)
                {
                    MessageBox.Show("录入成功");
                    qk();
                }
                else
                    MessageBox.Show("录入失败");

            }



        }
        public void sele()
        {
            string sele1 = "select * from EmpType order by ID";
            DataSet ds = DBHelper.GetDataSet(sele1);
            Tid.DisplayMember = "Type";
            Tid.ValueMember = "ID";
            Tid.DataSource = ds.Tables[0];

            string sele2 = "select * from EmpPosition order by ID";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            Pid.DisplayMember = "PName";
            Pid.ValueMember = "ID";
            Pid.DataSource = ds2.Tables[0];

        }
        private void btngogo_Click(object sender, EventArgs e)
        {
            new Admin_pugongok1_into2lx().ShowDialog();
            sele();
        }

        private void btngos_Click(object sender, EventArgs e)
        {
            new Admin_pugongok1_into2zw().ShowDialog();
            sele();
        }
        
        public void qk()
        {
            sw = null;
            pictureBox1.Visible = false;
            EUid.Text = DateTime.Now.ToString(0 + "yyyymmddss");
            EWedding = ETell.Text = EPhone.Text = txtdz.Text = EJG.Text =
        EmpEducate.Text = TRemarks.Text =
        EName.Text = EmpIDT.Text =
       EmpNation.Text = EmpFace.Text = "";
        }
       
        string ssw;
        string ids;
        string hong;
        int wre = 0;
        public void bd()
        {
            if (EName.Text == "")
            {
                mzs.Text = "名字不能为空";
                return;
            }
            if (EmpIDT.Text.Length != 18)
            {
                sfzs.Text = "身份证不正确";
                EmpIDT.Focus();
                return;
            }
            if (ETell.Text != "")
            {
                if (ETell.Text.Length != 11)
                {
                    fj.Visible = true;
                    return;
                }
            }

            if (txtAge.Text == "自动识别")
            {
                sfzs.Text = "身份证不正确";
                EmpIDT.Focus();
                return;
            }
            if (comsheng.Text == "" || cons.Text == "" || cons.Text == "" || comsj.Text == "" || txtdz.Text == "")
            {
                MessageBox.Show("地址有误,请重新输入");
                txtdz.Focus();
                return;
            }
            ssw = EmpIDT.Text.Substring(6, 8).ToString();
            ids = (ssw.Substring(0, 4) + "/" + ssw.Substring(4, 2) + "/" + ssw.Substring(6, 2));
            hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            wre = 1;
            
        }
        private void btngo_Click(object sender, EventArgs e)
        {
            bd();
            if (wre != 1)
                return;
            if (Tid.Text == "")
            {
                MessageBox.Show("类型不能为空");
                txtdz.Focus();
                return;
            }

            if (Pid.Text == "")
            {
                MessageBox.Show("职位不能为空");
                txtdz.Focus();
                return;
            }
            if (lur == "录入")
                into();
            if (lur == "修改")
                upda1();
            if (lur == "普工")
                upda1s();
        }
        byte[] sw = null;
        public void upda1()
        {
            string hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            if (sw != null)
            {
                string up = "update EmpInfo set [EName]=@EName,[ESet]=@ESet,[EBirthday]=@EBirthday,[Tid]=@Tid," +
      "[Pid]=@Pid,[EmpNation]=@EmpNation,[EmpFace]=@EmpFace,[EmpIDT]=@EmpIDT,[EmpEducate]=@EmpEducate,[EWedding]=@EWedding,[ETell]=@ETell,[EPhone]=@EPhone,[EIDAd]=@EIDAd,[EJG]=@EJG,[TRemarks]=@TRemarks,[IMGF]=@IMGF where ID=" + id;
                SqlParameter[] p =
                           {
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
                new SqlParameter("@EBirthday",ids),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text),
            new SqlParameter("@IMGF",sw)
            };
                int d = DBHelper.ExecuteNonQuery(up, p);
                if (d > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
            }
            else
            {
                string up = "update EmpInfo set [EName]=@EName,[ESet]=@ESet,[EBirthday]=@EBirthday,[Tid]=@Tid," +
     "[Pid]=@Pid,[EmpNation]=@EmpNation,[EmpFace]=@EmpFace,[EmpIDT]=@EmpIDT,[EmpEducate]=@EmpEducate,[EWedding]=@EWedding,[ETell]=@ETell,[EPhone]=@EPhone,[EIDAd]=@EIDAd,[EJG]=@EJG,[TRemarks]=@TRemarks where ID=" + id;
                SqlParameter[] p =
                           {
                   
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
                new SqlParameter("@EBirthday",ids),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text)
            };
                int d = DBHelper.ExecuteNonQuery(up, p);
                if (d > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
            }

        }
        public void upda1s()
        {
            string hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            if (sw != null)
            {
                string up = "update EmpInfo set [EName]=@EName,[ESet]=@ESet,[EBirthday]=@EBirthday,[Tid]=@Tid," +
      "[Pid]=@Pid,[EmpNation]=@EmpNation,[EmpFace]=@EmpFace,[EmpIDT]=@EmpIDT,[EmpEducate]=@EmpEducate,[EWedding]=@EWedding,[ETell]=@ETell,[EPhone]=@EPhone,[EIDAd]=@EIDAd,[EJG]=@EJG,[TRemarks]=@TRemarks,[IMGF]=@IMGF where EUid=" + id;
                SqlParameter[] p =
                           {
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
                new SqlParameter("@EBirthday",ids),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text),
            new SqlParameter("@IMGF",sw)
            };
                int d = DBHelper.ExecuteNonQuery(up, p);
                if (d > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
            }
            else
            {
                string up = "update EmpInfo set [EName]=@EName,[ESet]=@ESet,[EBirthday]=@EBirthday,[Tid]=@Tid," +
     "[Pid]=@Pid,[EmpNation]=@EmpNation,[EmpFace]=@EmpFace,[EmpIDT]=@EmpIDT,[EmpEducate]=@EmpEducate,[EWedding]=@EWedding,[ETell]=@ETell,[EPhone]=@EPhone,[EIDAd]=@EIDAd,[EJG]=@EJG,[TRemarks]=@TRemarks where EUid=" + id;
                SqlParameter[] p =
                           {
                new SqlParameter("@EName",EName.Text),
                new SqlParameter("@ESet",ESet),
                new SqlParameter("@EBirthday",ids),
                new SqlParameter("@Tid",Tid.SelectedValue),
                new SqlParameter("@Pid",Pid.SelectedValue),
                new SqlParameter("@EmpNation",EmpNation.Text),
                new SqlParameter("@EmpFace",EmpFace.Text),
                new SqlParameter("@EmpIDT",EmpIDT.Text),
                new SqlParameter("@EmpEducate",EmpEducate.Text),
                new SqlParameter("@EWedding",EWedding),
                new SqlParameter("@ETell",ETell.Text),
                new SqlParameter("@EPhone",EPhone.Text),
                new SqlParameter("@EIDAd",hong),
                new SqlParameter("@EJG",EJG.Text),
                new SqlParameter("@TRemarks",TRemarks.Text)
            };
                int d = DBHelper.ExecuteNonQuery(up, p);
                if (d > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
            }

        }
        public void up()
        {
            string up = "select * from EmpInfo where ID=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(up);
            while (dr.Read())
            {
                mv = 1;
                EUid.Text = dr["EUid"].ToString();
                EName.Text = dr["EName"].ToString();
                cs.Text = Convert.ToDateTime(dr["EBirthday"]).ToString("yyyy-MM-dd");
                txtsex.Text = dr["ESet"].ToString();
                 EmpNation.Text = dr["EmpNation"].ToString();
                EmpFace.Text = dr["EmpFace"].ToString();
                EmpIDT.Text = dr["EmpIDT"].ToString();
                Tid.SelectedIndex = (int)dr["Tid"] - 1;
                Pid.SelectedIndex = (int)dr["Pid"] - 1;
                EmpEducate.Text = dr["EmpEducate"].ToString();
                if (dr["EWedding"].ToString() == "未婚")
                    ranw.Checked = true;
                ETell.Text = dr["ETell"].ToString();
                comsheng.Text = dr["EIDAd"].ToString().Split('$')[0];
                cons.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[0];
                comsj.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                txtdz.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                EPhone.Text = dr["EPhone"].ToString();
                EJG.Text = dr["EJG"].ToString();
                TRemarks.Text = dr["TRemarks"].ToString();
            }
            dr.Close();
            txtAge.Text = DBHelper.Age(cs.Text).ToString();
        }
        public void ups()
        {
            string up = "select * from EmpInfo where EUid=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(up);
            while (dr.Read())
            {
                mv = 1;
                EUid.Text = dr["EUid"].ToString();
                EName.Text = dr["EName"].ToString();
                txtsex.Text = dr["ESet"].ToString();
                   
                cs.Text = Convert.ToDateTime(dr["EBirthday"]).ToString("yyyy-MM-dd");
                EmpNation.Text = dr["EmpNation"].ToString();
                EmpFace.Text = dr["EmpFace"].ToString();
                EmpIDT.Text = dr["EmpIDT"].ToString();
                Tid.SelectedIndex = (int)dr["Tid"] - 1;
                Pid.SelectedIndex = (int)dr["Pid"] - 1;
                EmpEducate.Text = dr["EmpEducate"].ToString();
                if (dr["EWedding"].ToString() == "未婚")
                    ranw.Checked = true;
                ETell.Text = dr["ETell"].ToString();
                EPhone.Text = dr["EPhone"].ToString();
                comsheng.Text = dr["EIDAd"].ToString().Split('$')[0];
                cons.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[0];
                comsj.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                txtdz.Text = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                EJG.Text = dr["EJG"].ToString();
                TRemarks.Text = dr["TRemarks"].ToString();
            }
            dr.Close();
        }

        private void sfzs_Click(object sender, EventArgs e)
        {
            string up = "update EmpInfo set [EPwd]=@EPwd  where EUid=" + EUid.Text;
            SqlParameter[] p =
                       {
                new SqlParameter("@EPwd", DBHelper.Md5(txtpwd.Text)),
        };
            int d = DBHelper.ExecuteNonQuery(up, p);
            if (d > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK);
        }

        private void EmpIDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.EmpIDT.ImeMode = ImeMode.Off;
            if (EmpIDT.Text.Length < 17)
            {
                if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    e.Handled = true;
            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != 'X')
                    e.Handled = true;

            }
        }

        private void ETell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;

        }

        private void EPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }
        //判断是录入信息还是修改信息 1代表修改信息
        int mv = 0;
        private void EmpIDT_TextChanged(object sender, EventArgs e)
        {
            //如果是修改信息跳出
            if (mv == 1)
                return;
            //提示身份证是否错误
            sfzs.Text = "*";
            //身份证输入等于18位时
            if (EmpIDT.Text.Length == 18)
            {
              
                string sw = null;                           //定义于获取年月日
                ssw = EmpIDT.Text.Substring(6, 8).ToString();//从身份证的第六位开始获取后面8位
                int s = DBHelper.Sid(ssw);
                if (s == 0)
                {
                    sfzs.Text = "身份证不正确";   //提示身份证错误
                    EmpIDT.Focus();               //光标跳到输入身份证框
                    return;
                }
                else
                {
                    //把出生日期放入文本框
                    cs.Text = sw = (ssw.Substring(0, 4) + "-" + ssw.Substring(4, 2) + "-" + ssw.Substring(6, 2));

                    txtAge.Text = DBHelper.Age(sw).ToString();
                }

                int c = int.Parse(EmpIDT.Text.Substring(16, 1));
                if (c % 2 != 0)
                    ESet = txtsex.Text = "男";
                else
                    ESet = txtsex.Text = "女";
            }
            //否则让年龄出生等于自动识别
            else
            {
                txtsex.Text = "自动识别";
                cs.Text = "自动识别";
                txtAge.Text = "自动识别";
            }


        }

        private void EName_TextChanged(object sender, EventArgs e)
        {
            mzs.Text = "*";
        }

        private void EName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw = DBHelper.byPictureBox(pictureBox1);
            if (sw != null)
                button3.Text = "更换照片";
        }
        string ESet = "男";
        string EWedding = "已婚";
        private void ranw_CheckedChanged(object sender, EventArgs e)
        {
            EWedding = "未婚";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            EWedding = "已婚";
        }

        private void btnno_Click(object sender, EventArgs e)
        {

        }

        private void btnno_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comsheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            cons.Items.Clear();
            comsj.Items.Clear();
            txtdz.Text = "";
            ss = comsheng.SelectedItem.ToString();
            w = Directory.GetFiles(bin + "\\Area\\", ss + ".txt");//获取文件路径赋值
            FileStream sr = new FileStream(w[0], FileMode.Open);//读取文件路径
            StreamReader sw = new StreamReader(sr, Encoding.Default);//文件翻译
            string str = null;
            while ((str = sw.ReadLine()) != null)
                cons.Items.Add(str.Split('：')[0]);

            sr.Close();
            sw.Close();
        }

        private void cons_SelectedIndexChanged(object sender, EventArgs e)
        {
            comsj.Items.Clear();
            txtdz.Text = "";
            string sws = cons.SelectedItem.ToString();
            w = Directory.GetFiles(bin + "\\Area\\", ss + ".txt");//获取文件路径赋值
            FileStream sr = new FileStream(w[0], FileMode.Open);//读取文件路径
            StreamReader sw = new StreamReader(sr, Encoding.Default);//文件翻译
            string str = null;
            while ((str = sw.ReadLine()) != null)
            {
                if (sws == str.Split('：')[0])
                {
                    if (str.Split('：')[1].Split('、') != null)
                    {
                        foreach (string ss in str.Split('：')[1].Split('、'))
                            comsj.Items.Add(ss);
                    }

                }
            }
            sr.Close();
            sw.Close();
        }

        private void comsj_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdz.Text = "";
        }

        private void lanxx_Click(object sender, EventArgs e)
        {
            lanxx.Visible = false;
            txtdz.Focus();
        }

        private void txtdz_TextChanged(object sender, EventArgs e)
        {
            lanxx.Visible = false;
        }

        private void ETell_TextChanged(object sender, EventArgs e)
        {
            fj.Visible = false;
        }

        private void moren_Click(object sender, EventArgs e)
        {
            string up = "update EmpInfo set EPwd=@EPwd where ID=" + id;
            SqlParameter[] p =
                {
                new SqlParameter("@EPwd", DBHelper.Md5(txtpwd.Text))
                };
            int dr = DBHelper.ExecuteNonQuery(up, p);
            if (dr > 0)
            {
                if ((MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("修改失败");
        }
    }
}
