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
    public partial class Admin_jshiok1_jsxinxi : Form
    {
        #region#
        string ces;
        string id;
        #region#家庭地址
        string[] files = null;
        string bin = Application.StartupPath;//获取文件路径
        string[] w = null;//市
        string ss;//获取点击市

        #endregion
        public Admin_jshiok1_jsxinxi(string ces)
        {
            InitializeComponent();
            this.ces = ces;
        }
        public Admin_jshiok1_jsxinxi(string ces, string id)
        {
            InitializeComponent();
            this.ces = ces;
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
                txtNation.Items.Add(str);
            }
            sr.Close();
            sw.Close();
            txtNation.SelectedIndex = 0;
        }
#endregion
        private void Admin_jiaoshi_ok1_ifs_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(bin + "\\Area\\", "*.txt");//获取文件路径赋值
            foreach (string shen in files)
                comsheng.Items.Add(Path.GetFileNameWithoutExtension(shen));//添加省份   获取文件的名称没有后缀
            txtName.Focus();
            zm();
            sele();
            if (ces == "录入信息")
            {
            
                EUid.Text = DateTime.Now.ToString(0 + "yyyymmddss");
            }
            if(ces=="修改")
            {
                this.Text = "修改教师个人信息";
                btnAdd.Text = "修改";
                moren.Visible = true;
                pic();
                seles();
            }
            if(ces=="教师")
            {
                this.Text = "修改教师个人信息";
                btnAdd.Text = "修改";
                moren.Visible = true;
                this.FormBorderStyle = FormBorderStyle.None;
                pics();
                selesw();
            }


        }

        public void sele()
        {
            cboType.Controls.Clear();
            cboPosition.Controls.Clear();
            string sele1 = "select * from TeaType order by ID";
            DataSet ds1 = DBHelper.GetDataSet(sele1);
            cboType.DisplayMember = "TypeName";
            cboType.ValueMember = "ID";
            cboType.DataSource = ds1.Tables[0];
            string sele2 = "select * from TeaPosition order by ID";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            cboPosition.DisplayMember = "PName";
            cboPosition.ValueMember = "ID";
            cboPosition.DataSource = ds2.Tables[0];
            txtFace.SelectedIndex = 2;
        }
        int mv = 0;
        public void seles()
        {
            string sele1 = "select * from TeaInfo where ID=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele1);
            while (dr.Read())
            {
                mv = 1;
                txtName.Text = dr["TName"].ToString();
                txtsex.Text=dr["TSex"].ToString();
                EUid.Text = dr["TUid"].ToString();
                cboPosition.SelectedIndex = (int)dr["Position"] - 1;
                txtSID.Text = dr["TID"].ToString();
                comsheng.Text = dr["THoome"].ToString().Split('$')[0];
                cons.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[0];
                comsj.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                txtdz.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                cs.Text = Convert.ToDateTime(dr["TCS"]).ToString("yyyy-MM-dd");
                txtFace.Text = dr["TFace"].ToString();
                txtTell.Text = dr["TPhone"].ToString();
                rz.Value = Convert.ToDateTime(dr["TTimeRZ"]); 
                lz.Value = Convert.ToDateTime(dr["TTimeLZ"]);
                txtReason.Text = dr["TLZReason"].ToString();
                txtPhone.Text = dr["TJTPhone"].ToString();
                txtPhone.Text = dr["TNation"].ToString();
                txtQQMailbox.Text = dr["TQQMailbox"].ToString();
                txtRemarks.Text = dr["TRemarks"].ToString();
                txtGJ.Text = dr["TJG"].ToString();
            }
            dr.Close();
            txtAge.Text = DBHelper.Age(cs.Text).ToString();
            mv = 0;
        }
        public void selesw()
        {
            string sele1 = "select * from TeaInfo where TUid=" + id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele1);
            while (dr.Read())
            {
                txtName.Text = dr["TName"].ToString();
               txtsex.Text=dr["TSex"].ToString();
                EUid.Text = dr["TUid"].ToString();
                cboType.SelectedIndex = (int)dr["Type"] - 1;
                cboPosition.SelectedIndex = (int)dr["Position"] - 1;
                txtSID.Text = dr["TID"].ToString();
                comsheng.Text = dr["THoome"].ToString().Split('$')[0];
                cons.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[0];
                comsj.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                txtdz.Text = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
           cs.Text = Convert.ToDateTime(dr["TCS"]).ToString("yyyy-mm-dd");
                txtFace.Text = dr["TFace"].ToString();
                txtTell.Text = dr["TPhone"].ToString();
                rz.Value = Convert.ToDateTime(dr["TTimeRZ"]);
                lz.Value = Convert.ToDateTime(dr["TTimeLZ"]);
                txtReason.Text = dr["TLZReason"].ToString();
                txtPhone.Text = dr["TJTPhone"].ToString();
                txtPhone.Text = dr["TNation"].ToString();
                txtQQMailbox.Text = dr["TQQMailbox"].ToString();
                txtRemarks.Text = dr["TRemarks"].ToString();
                txtGJ.Text = dr["TJG"].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_jshiok1_jsxinxi_1ifin_1().ShowDialog();
            sele();
        }
        string State = "男";
        string ssw;
        string ids;
        string hong;
        int wre = 0;
        public void bd()
        {
            if (txtName.Text == "")
            {
                mzs.Text = "名字不能为空";
                return;
            }
            if (txtSID.Text.Length != 18)
            {
                sfz.Text = "身份证不正确";
                txtSID.Focus();
                return;
            }
             if (txtTell.Text != "")
            {
                if (txtTell.Text.Length != 11)
                {
                    sj.Visible = true;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bd();
            if (wre != 1)
                return;
            if (btnAdd.Text == "提交")
                intos();
            if (btnAdd.Text == "修改")
            {
                pic();
                ups();
            }

        }
        public void intos()
        {
          
              if (sw != null)
            {
                string sql = "insert into TeaInfo([TName],[TSex],[TUid],[TPwd],[Type],[Position],[TID],[THoome]," +
                         "[TCS],[TFace],[TPhone],[TTimeRZ],[TTimeLZ],[TLZReason],[TJTPhone],[TNation],[TQQMailbox]," +
                         "[TRemarks],[TJG],IMGF)";
                sql += "values(@TName,@TSex,@TUid,@TPwd,@Type,@Position,@TID,@THoome," +
                    "@TCS,@TFace,@TPhone,@TTimeRZ,@TTimeLZ,@TLZReason," +
                    "@TJTPhone,@TNation,@TQQMailbox,@TRemarks,@TJG,@IMGF)";
                SqlParameter[] p = {
                new SqlParameter("@TName",txtName.Text),
                new SqlParameter("@TSex",State),
                new SqlParameter("@TUid",EUid.Text),
                new SqlParameter("@TPwd",DBHelper.Md5(txtpwd.Text)),
                new SqlParameter("@Type",(int)cboType.SelectedValue),
                new SqlParameter("@Position",(int)cboPosition.SelectedValue),
                new SqlParameter("@TID",txtSID.Text),
                new SqlParameter("@THoome",hong),
                new SqlParameter("@TCS",ids),
                new SqlParameter("@TFace",txtFace.Text),
                new SqlParameter("@TPhone",txtTell.Text),
                new SqlParameter("@TTimeRZ",rz.Value),
                new SqlParameter("@TTimeLZ",lz.Value),
                new SqlParameter("@TLZReason",txtReason.Text),
                new SqlParameter("@TJTPhone",txtPhone.Text),
                new SqlParameter("@TNation",txtNation.Text),
                new SqlParameter("@TQQMailbox",txtQQMailbox.Text),
                new SqlParameter("@TRemarks",txtRemarks.Text),
                new SqlParameter("@TJG",txtGJ.Text),
               new SqlParameter("@IMGF",sw)
            };
                int dr = DBHelper.ExecuteNonQuery(sql, p);
                if (dr > 0)
                {
                    MessageBox.Show("提交成功");
                    no();
                }
                else
                    MessageBox.Show("提交失败");
            }
            else
            {
                string sql = "insert into TeaInfo([TName],[TSex],[TUid],[TPwd],[Type],[Position],[TID],[THoome]," +
                "[TCS],[TFace],[TPhone],[TTimeRZ],[TTimeLZ],[TLZReason],[TJTPhone],[TNation],[TQQMailbox]," +
                "[TRemarks],[TJG])";
                sql += "values(@TName,@TSex,@TUid,@TPwd,@Type,@Position,@TID,@THoome," +
                    "@TCS,@TFace,@TPhone,@TTimeRZ,@TTimeLZ,@TLZReason," +
                    "@TJTPhone,@TNation,@TQQMailbox,@TRemarks,@TJG)";
                SqlParameter[] p = {
                new SqlParameter("@TName",txtName.Text),
                new SqlParameter("@TSex",State),
                new SqlParameter("@TUid",EUid.Text),
                new SqlParameter("@TPwd",DBHelper.Md5(txtpwd.Text)),
                new SqlParameter("@Type",(int)cboType.SelectedValue),
                new SqlParameter("@Position",(int)cboPosition.SelectedValue),
                new SqlParameter("@TID",txtSID.Text),
                new SqlParameter("@THoome",hong),
                new SqlParameter("@TCS",ids),
                new SqlParameter("@TFace",txtFace.Text),
                new SqlParameter("@TPhone",txtTell.Text),
                new SqlParameter("@TTimeRZ",rz.Value),
                new SqlParameter("@TTimeLZ",lz.Value),
                new SqlParameter("@TLZReason",txtReason.Text),
                new SqlParameter("@TJTPhone",txtPhone.Text),
                new SqlParameter("@TNation",txtNation.Text),
                new SqlParameter("@TQQMailbox",txtQQMailbox.Text),
                new SqlParameter("@TRemarks",txtRemarks.Text),
                new SqlParameter("@TJG",txtGJ.Text)
            };
                int dr = DBHelper.ExecuteNonQuery(sql, p);
                if (dr > 0)
                {
                    MessageBox.Show("提交成功");
                    no();
                }
                else
                    MessageBox.Show("提交失败");
            }
        }
        
        private void pic()
        {
            string sele1 = "select IMGF from TeaInfo where ID=" + id;
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
            pictureBox2.Visible = true;
            button3.Text = "更换照片";
            pictureBox2.Image = DBHelper.Read(sele1);
        }
        private void pics()
        {
            string sele1 = "select IMGF from TeaInfo where TUid=" + id;
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
            pictureBox2.Visible = true;
            button3.Text = "更换照片";
            pictureBox2.Image = DBHelper.Read(sele1);
        }
        public void ups()
        {
            
            if (sw!=null)
            {
                string up = "update TeaInfo set [TName]=@TName,[TSex]=@TSex,[Type]=@Type,[Position]=@Position," +
      "[TID]=@TID,[THoome]=@THoome,[TCS]=@TCS,[TFace]=@TFace,TRemarks=@TRemarks,TJG=@TJG,[TPhone]=@TPhone,[TTimeRZ]=@TTimeRZ,[TTimeLZ]=@TTimeLZ,[TLZReason]=@TLZReason,[TJTPhone]=@TJTPhone,[TNation]=@TNation,[TQQMailbox]=@TQQMailbox,IMGF=@IMGF where ID=" + id;
                SqlParameter[] p = {
                new SqlParameter("@TName",txtName.Text),
                new SqlParameter("@TSex",State),
                new SqlParameter("@Type",(int)cboType.SelectedValue),
                new SqlParameter("@Position",(int)cboPosition.SelectedValue),
                new SqlParameter("@TID",txtSID.Text),
                new SqlParameter("@THoome",hong),
                new SqlParameter("@TCS",ids),
                new SqlParameter("@TFace",txtFace.Text),
                new SqlParameter("@TPhone",txtTell.Text),
                new SqlParameter("@TTimeRZ",rz.Value),
                new SqlParameter("@TTimeLZ",lz.Value),
                new SqlParameter("@TLZReason",txtReason.Text),
                new SqlParameter("@TJTPhone",txtPhone.Text),
                new SqlParameter("@TNation",txtNation.Text),
                new SqlParameter("@TQQMailbox",txtQQMailbox.Text),
                new SqlParameter("@TRemarks",txtRemarks.Text),
                new SqlParameter("@TJG",txtGJ.Text),
                new SqlParameter("@IMGF",sw),

            };
                int dr = DBHelper.ExecuteNonQuery(up, p);
                if (dr > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败");
            }
            else
            {
                string up = "update TeaInfo set [TName]=@TName,[TSex]=@TSex,[Type]=@Type,[Position]=@Position," +
      "[TID]=@TID,[THoome]=@THoome,[TCS]=@TCS,[TFace]=@TFace,TRemarks=@TRemarks,TJG=@TJG,[TPhone]=@TPhone,[TTimeRZ]=@TTimeRZ,[TTimeLZ]=@TTimeLZ,[TLZReason]=@TLZReason,[TJTPhone]=@TJTPhone,[TNation]=@TNation,[TQQMailbox]=@TQQMailbox where ID=" + id;
                SqlParameter[] p = {
                new SqlParameter("@TName",txtName.Text),
                new SqlParameter("@TSex",State),
                new SqlParameter("@Type",(int)cboType.SelectedValue),
                new SqlParameter("@Position",(int)cboPosition.SelectedValue),
                new SqlParameter("@TID",txtSID.Text),
                new SqlParameter("@THoome",hong),
                new SqlParameter("@TCS",ids),
                new SqlParameter("@TFace",txtFace.Text),
                new SqlParameter("@TPhone",txtTell.Text),
                new SqlParameter("@TTimeRZ",rz.Value),
                new SqlParameter("@TTimeLZ",lz.Value),
                new SqlParameter("@TLZReason",txtReason.Text),
                new SqlParameter("@TJTPhone",txtPhone.Text),
                new SqlParameter("@TNation",txtNation.Text),
                new SqlParameter("@TQQMailbox",txtQQMailbox.Text),
                new SqlParameter("@TRemarks",txtRemarks.Text),
                new SqlParameter("@TJG",txtGJ.Text)

            };
                int dr = DBHelper.ExecuteNonQuery(up, p);
                if (dr > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败");

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_jshiok1_jsxinxi_2ifin().ShowDialog();
            sele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
             

        }
        public void no()
        {
            sw = null;
            cons.Text = "";
            comsj.Text = "";
            comsheng.SelectedIndex = 0;

            button3.Text = "选择图片";
            pictureBox2.Visible = false;
            EUid.Text = DateTime.Now.ToString(0 + "yyyymmddss");
            txtName.Text = "";
            cboType.Text = "";
            cboPosition.Text = "";
            txtFace.Text = "";
            txtSID.Text = "";
            txtdz.Text = "";
            txtFace.Text = "";
            txtTell.Text = "";
            txtPhone.Text = "";
            txtdz.Text = "";
            txtPhone.Text = "";
            txtQQMailbox.Text = "";
            txtGJ.Text = "";
            txtRemarks.Text = "";
            txtReason.Text = "";
        }
        
        private void moren_Click(object sender, EventArgs e)
        {
            string up = "update TeaInfo set TPwd=@pwd where ID=" + id;
            SqlParameter[] p = {
                new SqlParameter ("@pwd",DBHelper.Md5( txtpwd.Text))
            };
            if (DBHelper.ExecuteNonQuery(up, p) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
                MessageBox.Show("修改失败");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mzs.Text = "*";
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtTID_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSID.ImeMode = ImeMode.Off;
            if (txtSID.Text.Length < 17)
            {
                if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    e.Handled = true;
            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8&& e.KeyChar != 'X')
                    e.Handled = true;
                
            }
        }

        private void txtQQMailbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;

        }
        byte[] sw = null;
        private void button3_Click(object sender, EventArgs e)
        {
            sw = DBHelper.byPictureBox(pictureBox2);
            if (sw != null)
                button3.Text = "更换照片";
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

        private void txtHome_TextChanged(object sender, EventArgs e)
        {
            lanxx.Visible = false;
        }

        private void lanxx_Click(object sender, EventArgs e)
        {
            lanxx.Visible = false;
            txtdz.Focus();
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
                    cs.Text = sw=(ssw.Substring(0, 4) + "-" + ssw.Substring(4, 2) + "-" + ssw.Substring(6, 2));
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

        private void txtTell_TextChanged(object sender, EventArgs e)
        {
            sj.Visible = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
