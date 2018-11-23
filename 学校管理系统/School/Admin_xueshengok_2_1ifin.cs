using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_xueshengok_2_1ifin : Form
    {
        string names;
        string id;
        string[] files = null;
        string bin = Application.StartupPath;
        string[] w = null;
        string d;
        public Admin_xueshengok_2_1ifin(string names)
        {
            InitializeComponent();
            this.names = names;
        }
        public Admin_xueshengok_2_1ifin()
        {
            InitializeComponent();

        }
        public Admin_xueshengok_2_1ifin(string names, string id)
        {
            InitializeComponent();
            this.names = names;
            this.id = id;
        }
        public void zm()
        {
            string[] ss = Directory.GetFiles(Application.StartupPath, "民族.txt");
            FileStream sr = new FileStream(ss[0], FileMode.Open);//读取文件路径
            StreamReader sw = new StreamReader(sr, Encoding.Default);//文件翻译
            string str = null;
            while ((str = sw.ReadLine()) != null)
            {
                txtmz.Items.Add(str);
            }
            sr.Close();
            sw.Close();
            txtmz.SelectedIndex = 0;
            files = Directory.GetFiles(bin + "\\Area\\", "*.txt");//获取文件路径赋值
            foreach (string shen in files)
                comsheng.Items.Add(Path.GetFileNameWithoutExtension(shen));//添加省份   获取文件的名称没有后缀

        }
        private void pic()
        {
            string sele1 = "select IMGF from Stulnfo where ID=" + id;
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
            button2.Text = "更换照片";
            pictureBox1.Image = DBHelper.Read(sele1);
        }
        private void Admin_xueshengok_1_Load(object sender, EventArgs e)
        {
            zm();
            sele();
            if (names == "录入信息")
            {
                xh.Text = DateTime.Now.ToString(0 + "yyyymmddss");
                zz.Visible = true;
            }

            if (names == "修改")
            {
                moren.Visible = true;
                this.Text = "修改学生个人信息";
                btngo.Text = "修改";
                pic();
                upda();
            }
        }
        public void upda()
        {

            
            string st = "select * from Stulnfo where ID=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(st);
            while (dr.Read())
            {
                mv = 1;
                txtName.Text = dr["SStudentName"].ToString();
                xh.Text = dr["TeacherID"].ToString();
               txtsex.Text= dr["StudentSex"].ToString();
                txtPid.SelectedIndex = (int)dr["Pid"] - 1;
                cmGrade.SelectedIndex = (int)dr["Cid"] - 1;
                txtSPName.Text = dr["SFName"].ToString();
                txtSFPhone.Text = dr["SFPhone"].ToString();
                txtSMName.Text = dr["SMName"].ToString();
                txtSMPhone.Text = dr["SMPhone"].ToString();
                txtSID.Text = dr["SID"].ToString();
                comsheng.Text = dr["SHome"].ToString().Split('$')[0];
                cons.Text = dr["SHome"].ToString().Split('$')[1].Split('%')[0];
                comsj.Text = dr["SHome"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                txtdz.Text = dr["SHome"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                cs.Text = Convert.ToDateTime(dr["SCS"]).ToString("yyyy-MM-dd");
                txtSFace.Text = dr["SFace"].ToString();
                txtSPhone.Text = dr["SPhone"].ToString();
                dataStimeRZ.Value = Convert.ToDateTime(dr["STimeRZ"]);
                txtmz.Text = dr["SNation"].ToString();
                txtSQQMailBox.Text = dr["SQQMailbox"].ToString();
                txtSRemarks.Text = dr["SRemarks"].ToString();
                txtJG.Text = dr["SJG"].ToString();
            }
            dr.Close();
            txtAge.Text = DBHelper.Age(cs.Text).ToString();
            mv = 0;
        }
        public void sele()
        {
            txtSFace.SelectedIndex = 0;
            cmGrade.Controls.Clear();
            string se = "select * from Class order by ID";
            DataSet dr = DBHelper.GetDataSet(se);
            cmGrade.DisplayMember = "CName";
            cmGrade.ValueMember = "ID";
            cmGrade.DataSource = dr.Tables[0];

            txtPid.Controls.Clear();
            string ses = "select * from StuPosition order by ID";
            DataSet drs = DBHelper.GetDataSet(ses);
            txtPid.DisplayMember = "PName";
            txtPid.ValueMember = "ID";
            txtPid.DataSource = drs.Tables[0];

        }
        public void update()
        {
            string hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            if (sw != null)
            {
                string up = "update Stulnfo set [SStudentName]=@SStudentName,[StudentSex]=@StudentSex,[Pid]=@Pid,[Cid]=@Cid," +
             "[SFName]=@SFName,[SFPhone]=@SFPhone,[SMName]=@SMName,[SMPhone]=@SMPhone,[SID]=@SID,[SHome]=@SHome,[SCS]=@SCS,[SFace]=@SFace,[SPhone]=@SPhone,[STimeRZ]=@STimeRZ,[SNation]=@SNation," +
             "[SQQMailbox]=@SQQMailbox,[SRemarks]=@SRemarks,[SJG]=@SJG,IMGF=@IMGF where ID=" + id;
                SqlParameter[] p = {
                new SqlParameter("@SStudentName", txtName.Text),//1
                new SqlParameter("@StudentSex",State),//3
                new SqlParameter("@Pid", txtPid.SelectedValue),//4
                new SqlParameter("@Cid", cmGrade.SelectedValue),//4
                new SqlParameter("@SFName", txtSPName.Text),//9
                new SqlParameter("@SFPhone", txtSFPhone.Text),//10
                new SqlParameter("@SMName", txtSMName.Text),//11
                new SqlParameter("@SMPhone", txtSMPhone.Text),//12
                new SqlParameter("@SID", txtSID.Text),//13
                new SqlParameter("@SHome",hong),//14
                new SqlParameter("@SCS", ids),//15
                new SqlParameter("@SFace", txtSFace.Text),//16
                new SqlParameter("@SPhone", txtSPhone.Text),//18
                new SqlParameter("@STimeRZ", dataStimeRZ.Value),//19
                new SqlParameter("@SNation", txtmz.Text),//20
                new SqlParameter("@SQQMailbox", txtSQQMailBox.Text),//21
                new SqlParameter("@SRemarks", txtSRemarks.Text),//22
                new SqlParameter("@SJG", txtJG.Text),//23
                new SqlParameter("@IMGF", sw),

            };
                int dr = DBHelper.ExecuteNonQuery(up, p);
                if (dr > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败");

            }
            else
            {
                string up = "update Stulnfo set [SStudentName]=@SStudentName,[StudentSex]=@StudentSex,[Pid]=@Pid,[Cid]=@Cid," +
             "[SFName]=@SFName,[SFPhone]=@SFPhone,[SMName]=@SMName,[SMPhone]=@SMPhone,[SID]=@SID,[SHome]=@SHome,[SCS]=@SCS,[SFace]=@SFace,[SPhone]=@SPhone,[STimeRZ]=@STimeRZ,[SNation]=@SNation," +
             "[SQQMailbox]=@SQQMailbox,[SRemarks]=@SRemarks,[SJG]=@SJG where ID=" + id;
                SqlParameter[] p = {
                new SqlParameter("@SStudentName", txtName.Text),//1
                new SqlParameter("@StudentSex",State),//3
                new SqlParameter("@Pid", txtPid.SelectedValue),//4
                new SqlParameter("@Cid", cmGrade.SelectedValue),//4
                new SqlParameter("@SFName", txtSPName.Text),//9
                new SqlParameter("@SFPhone", txtSFPhone.Text),//10
                new SqlParameter("@SMName", txtSMName.Text),//11
                new SqlParameter("@SMPhone", txtSMPhone.Text),//12
                new SqlParameter("@SID", txtSID.Text),//13
                new SqlParameter("@SHome",hong),//14
                new SqlParameter("@SCS", ids),//15
                new SqlParameter("@SFace", txtSFace.Text),//16
                new SqlParameter("@SPhone", txtSPhone.Text),//18
                new SqlParameter("@STimeRZ", dataStimeRZ.Value),//19
                new SqlParameter("@SNation", txtmz.Text),//20
                new SqlParameter("@SQQMailbox", txtSQQMailBox.Text),//21
                new SqlParameter("@SRemarks", txtSRemarks.Text),//22
                new SqlParameter("@SJG", txtJG.Text),

            };
                int dr = DBHelper.ExecuteNonQuery(up, p);
                if (dr > 0)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败");
            }


        }
        byte[] sw = null;
        public void into()
        {
            if (sw != null)
            {
                string into = "insert into Stulnfo([SStudentName],[TeacherID],[StudentSex],[Pid],[Cid],[SPwd]," +
             "[SFName],[SFPhone],[SMName],[SMPhone],[SID],[SHome],[SCS],[SFace],[SPhone],[STimeRZ],[SNation]," +
             "[SQQMailbox],[SRemarks],[SJG],[IMGF]) " +
             "Values(@SStudentName,@TeacherID,@StudentSex,@Pid,@Cid,@SPwd,@SFName,@SFPhone,@SMName,@SMPhone,@SID," +
             "@SHome,@SCS,@SFace,@SPhone,@STimeRZ,@SNation,@SQQMailbox,@SRemarks,@SJG,@IMGF)";
                SqlParameter[] p = {
                new SqlParameter("@SStudentName", txtName.Text),//1
                new SqlParameter("@TeacherID",  xh.Text),//2
                new SqlParameter("@StudentSex",State),//3
                new SqlParameter("@Pid", txtPid.SelectedValue),//4
                new SqlParameter("@Cid", cmGrade.SelectedValue),//4
                new SqlParameter("@SPwd", DBHelper.Md5(txtpwd.Text)),//8
                new SqlParameter("@SFName", txtSPName.Text),//9
                new SqlParameter("@SFPhone", txtSFPhone.Text),//10
                new SqlParameter("@SMName", txtSMName.Text),//11
                new SqlParameter("@SMPhone", txtSMPhone.Text),//12
                new SqlParameter("@SID", txtSID.Text),//13
                new SqlParameter("@SHome",hong),//14
                new SqlParameter("@SCS", ids),//15
                new SqlParameter("@SFace", txtSFace.Text),//16
                new SqlParameter("@SPhone", txtSPhone.Text),//18
                new SqlParameter("@STimeRZ", dataStimeRZ.Value),//19
                new SqlParameter("@SNation", txtmz.Text),//20
                new SqlParameter("@SQQMailbox", txtSQQMailBox.Text),//21
                new SqlParameter("@SRemarks", txtSRemarks.Text),//22
                new SqlParameter("@SJG", txtJG.Text),//23
                new SqlParameter("@IMGF", sw)
                 };
                int f = DBHelper.ExecuteNonQuery(into, p);
                if (f > 0)
                {
                    string my = "select count(*) from Stulnfo where Cid=" + cmGrade.SelectedValue;//查询学生人数
                    int cas = (int)DBHelper.ExecuteScalar(my);//获取人数
                    string up = "update Class set CsCount=" + cas + " where ID=" + cmGrade.SelectedValue;//修改班级人数
                    DBHelper.ExecuteNonQuery(up);
                    string my1 = "select Gid from Class where ID=" + cmGrade.SelectedValue;//查询年级ID
                    int cas1 = (int)DBHelper.ExecuteScalar(my1);//获取
                    string sum = "select sum(CsCount) from Class  where Gid=" + cas1;//查询年级所有人数
                    int cssum = (int)DBHelper.ExecuteScalar(sum);//获取
                    string up1 = "update Grade set CCount=" + cssum + " where ID=" + cas1;//修改年级人数
                    DBHelper.ExecuteNonQuery(up1);
                    MessageBox.Show("录取成功");
                    qk();
                }

                else
                    MessageBox.Show("录取失败");
            }
            else
            {
                string into = "insert into Stulnfo([SStudentName],[TeacherID],[StudentSex],[Pid],[Cid],[SPwd]," +
             "[SFName],[SFPhone],[SMName],[SMPhone],[SID],[SHome],[SCS],[SFace],[SPhone],[STimeRZ],[SNation]," +
             "[SQQMailbox],[SRemarks],[SJG]) " +
             "Values(@SStudentName,@TeacherID,@StudentSex,@Pid,@Cid,@SPwd,@SFName,@SFPhone,@SMName,@SMPhone,@SID," +
             "@SHome,@SCS,@SFace,@SPhone,@STimeRZ,@SNation,@SQQMailbox,@SRemarks,@SJG)";
                SqlParameter[] p = {
                new SqlParameter("@SStudentName", txtName.Text),//1
                new SqlParameter("@TeacherID",  xh.Text),//2
                new SqlParameter("@StudentSex",State),//3
                new SqlParameter("@Pid", txtPid.SelectedValue),//4
                new SqlParameter("@Cid", cmGrade.SelectedValue),//4
                new SqlParameter("@SPwd", DBHelper.Md5(txtpwd.Text)),//8
                new SqlParameter("@SFName", txtSPName.Text),//9
                new SqlParameter("@SFPhone", txtSFPhone.Text),//10
                new SqlParameter("@SMName", txtSMName.Text),//11
                new SqlParameter("@SMPhone", txtSMPhone.Text),//12
                new SqlParameter("@SID", txtSID.Text),//13
                new SqlParameter("@SHome",hong),//14
                new SqlParameter("@SCS", ids),//15
                new SqlParameter("@SFace", txtSFace.Text),//16
                new SqlParameter("@SPhone", txtSPhone.Text),//18
                new SqlParameter("@STimeRZ", dataStimeRZ.Value),//19
                new SqlParameter("@SNation", txtmz.Text),//20
                new SqlParameter("@SQQMailbox", txtSQQMailBox.Text),//21
                new SqlParameter("@SRemarks", txtSRemarks.Text),//22
                new SqlParameter("@SJG", txtJG.Text),//23
                 };
                int f = DBHelper.ExecuteNonQuery(into, p);
                if (f > 0)
                {
                    string my = "select count(*) from Stulnfo where Cid=" + cmGrade.SelectedValue;//查询学生人数
                    int cas =(int) DBHelper.ExecuteScalar(my);//获取人数
                    string up = "update Class set CsCount=" + cas + " where ID=" + cmGrade.SelectedValue;//修改班级人数
                    DBHelper.ExecuteNonQuery(up);
                    string my1 = "select Gid from Class where ID=" + cmGrade.SelectedValue;//查询年级ID
                    int cas1 = (int)DBHelper.ExecuteScalar(my1);//获取
                    string sum = "select sum(CsCount) from Class  where Gid=" + cas1;//查询年级所有人数
                    int cssum = (int)DBHelper.ExecuteScalar(sum);//获取
                       string up1 = "update Grade set CCount=" + cssum + " where ID=" + cas1;//修改年级人数
                    DBHelper.ExecuteNonQuery(up1);
                    MessageBox.Show("录取成功");
                    qk();
                }

                else
                    MessageBox.Show("录取失败");
            }

        }
        
        public void qk()
        {
            sw = null;
            pictureBox1.Visible = false;
            button2.Text = "选择图片";
            xh.Text = DateTime.Now.ToString(0 + "yyyymmddss");
            txtName.Text = "";
            txtSPName.Text = "";
            txtSFPhone.Text = "";
            txtSMName.Text = "";
            txtSMPhone.Text = "";
            txtSID.Text = "";
            txtSPhone.Text = "";
            txtSQQMailBox.Text = "";
            txtJG.Text = "";
            txtdz.Text = "";
            txtSRemarks.Text = "";
            txtdz.Text = "";
            lanxx.Visible = true;
            comsheng.SelectedIndex = 1;
            txtName.Focus();

        }

        private void comsheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            cons.Items.Clear();
            comsj.Items.Clear();
            txtdz.Text = "";
            d = comsheng.SelectedItem.ToString();
            w = Directory.GetFiles(bin + "\\Area\\", d + ".txt");//获取文件路径赋值
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
            w = Directory.GetFiles(bin + "\\Area\\", d + ".txt");//获取文件路径赋值
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

        private void lanxx_Click(object sender, EventArgs e)
        {
            lanxx.Visible = false;
            txtdz.Focus();
        }

        private void txtdz_TextChanged(object sender, EventArgs e)
        {
            lanxx.Visible = false;
        }

        private void comsj_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdz.Text = "";
        }

        private void btnif_Click(object sender, EventArgs e)
        {
            Admin_xueshengok2_1if_1if ss = new Admin_xueshengok2_1if_1if();
            if (ss.ShowDialog() == DialogResult.OK)
                sele();
        }

        private void btns_Click_1(object sender, EventArgs e)
        {
            Admin_xueshengok2_2zw_ifcs ss = new Admin_xueshengok2_2zw_ifcs();
            if (ss.ShowDialog() == DialogResult.OK)
                sele();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sw = DBHelper.byPictureBox(pictureBox1);
            if (sw != null)
                button2.Text = "更换照片";
        }

        private void btngo_Click(object sender, EventArgs e)
        {

            bd();
            if (wre != 1)
                return;
            if (names == "录入信息")
                into();
            else
                update();
        }

        private void zz_Click(object sender, EventArgs e)
        {
            qk();
        }
        

        private void moren_Click(object sender, EventArgs e)
        {
            string up = "update Stulnfo set SPwd=@SPwd where ID=" + id;
            SqlParameter[] p =
                {
                new SqlParameter("@SPwd", DBHelper.Md5(txtpwd.Text))
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

        private void txtSMPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSFPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSQQMailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtSFPhone_TextChanged(object sender, EventArgs e)
        {
            fj.Visible = false;
        }

        private void txtSMPhone_TextChanged(object sender, EventArgs e)
        {
            mj.Visible = false;
        }

        private void txtSPhone_TextChanged(object sender, EventArgs e)
        {
            lansas.Visible = false;
        }
        int mv = 0;
        string State = "男";
        string ssw;
        string ids;
        string hong;
        int wre = 0;
        public void bd()
        {
            if (cmGrade.Text == "")
            {
                MessageBox.Show("班级不能为空");
                return;
            }
            if (txtPid.Text == "")
            {
                MessageBox.Show("职位不能为空");
                return;
            }

            if (txtName.Text == "")
            {
                x.Text = "名字不能为空";
                txtName.Focus();
                return;
            }
            
            if (txtSFPhone.Text != "")
            {
                if (txtSFPhone.Text.Length != 11)
                {
                    fj.Visible = true;
                    return;
                }
            }
            if (txtSMPhone.Text != "")
            {
                if (txtSMPhone.Text.Length != 11)
                {
                    mj.Visible = true;
                    return;
                }
            }
            if (txtSPhone.Text != "")
            {
                if (txtSPhone.Text.Length != 11)
                {
                    lansas.Visible = true;
                    return;
                }
            }
if (txtName.Text == "")
            {
                x.Text = "名字不能为空";
                return;
            }
            if (txtSID.Text.Length != 18)
            {
                sfz.Text = "身份证不正确";
                txtSID.Focus();
                return;
            }
            if (txtSPhone.Text != "")
            {
                if (txtSPhone.Text.Length != 11)
                {
                    fj.Visible = true;
                    return;
                }
            }

            if (txtAge.Text == "自动识别")
            {
                sfz.Text = "身份证不正确";
                txtSID.Focus();
                return;
            }
            if (comsheng.Text == "" || cons.Text == "" || cons.Text == "" || comsj.Text == "" || txtdz.Text == "")
            {
                MessageBox.Show("地址有误,请重新输入");
                txtdz.Focus();
                return;
            }
            ssw = txtSID.Text.Substring(6, 8).ToString();
            ids = (ssw.Substring(0, 4) + "/" + ssw.Substring(4, 2) + "/" + ssw.Substring(6, 2));
            hong = comsheng.Text + "$" + cons.Text + "%" + comsj.Text + "#" + txtdz.Text;
            wre = 1;

        }
        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            if (mv == 1)
                return;
            sfz.Text = "*";

            if (txtSID.Text.Length == 18)
            {
                string sw = null;
                ssw = txtSID.Text.Substring(6, 8).ToString();
                int s = DBHelper.Sid(ssw);
                if (s == 0)
                {
                    sfz.Text = "身份证不正确";
                    txtSID.Focus();
                    return;
                }
                else
                {
                    cs.Text = sw = (ssw.Substring(0, 4) + "-" + ssw.Substring(4, 2) + "-" + ssw.Substring(6, 2));
                    txtAge.Text = DBHelper.Age(sw).ToString();
                }

                int c = int.Parse(txtSID.Text.Substring(16, 1));
                if (c % 2 != 0)
                    State = txtsex.Text = "男";
                else
                    State = txtsex.Text = "女";
            }
            else
            {
                txtsex.Text = "自动识别";
                cs.Text = "自动识别";
                txtAge.Text = "自动识别";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            x.Text = "*";
        }

        private void txtSID_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSID.ImeMode = ImeMode.Off;
            if (txtSID.Text.Length < 17)
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
    }
}



;