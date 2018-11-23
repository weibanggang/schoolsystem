using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class frmAAxgpwd : Form
    {
        string uid;
        public frmAAxgpwd(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if(txtuid.Text=="")
            {
                MessageBox.Show("旧密码不能为空");
                return;
            }
            if (txtpwds.Text == "")
            {
                MessageBox.Show("新密码不能为空");
                return;
            }
            if (txtpwdss.Text == "")
            {
                MessageBox.Show("确认不能为空");
                return;
            }
           
                gly(uid);
            
        }
        #region#客户端修改密码
        //private void xs()
        //{
        //    string sele = "select count(*) from Stulnfo where TeacherID=" + id + " and SPwd=@SPwd";
        //    SqlParameter[] p =
        //    {
        //            new SqlParameter("@SPwd",DBHelper.Md5( txtuid.Text.Trim()))
        //        };
        //    int o = (int)DBHelper.ExecuteScalar(sele, p);
        //    if (o > 0)
        //    {
        //        if (txtpwds.Text != txtpwdss.Text)
        //        {
        //            MessageBox.Show("两次密码不一致，请重新输入");
        //            return;
        //        }
        //        else
        //        {
        //            string up = "update Stulnfo set SPwd=@SPwd where TeacherID=" + id;
        //            SqlParameter[] s =
        //                      {
        //                          new SqlParameter("@SPwd",DBHelper.Md5( txtpwds.Text))
        //                            };
        //            int w = DBHelper.ExecuteNonQuery(up, s);
        //            if (w > 0)
        //            {
        //                if (MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
        //                    this.DialogResult = DialogResult.OK;
        //            }
        //            else
        //                MessageBox.Show("修改失败");



        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("旧密码有误");
        //        txtuid.Text = "";
        //        txtuid.Focus();
        //        return;
        //    }
        //}
        
        //private void js()
        //{
        //    string sele = "select count(*) from TeaInfo where TUid=" + id + " and TPwd=@TPwd";
        //    SqlParameter[] p =
        //    {
        //            new SqlParameter("@TPwd",DBHelper.Md5( txtuid.Text.Trim()))
        //        };
        //    int o = (int)DBHelper.ExecuteScalar(sele, p);
        //    if (o > 0)
        //    {
        //        if (txtpwds.Text != txtpwdss.Text)
        //        {
        //            MessageBox.Show("两次密码不一致，请重新输入");
        //            return;
        //        }
        //        else
        //        {
        //            string up = "update TeaInfo set TPwd=@SPwd where TUid=" + id;
        //            SqlParameter[] s =
        //                      {
        //                          new SqlParameter("@SPwd",DBHelper.Md5( txtpwds.Text))
        //                            };
        //            int w = DBHelper.ExecuteNonQuery(up, s);
        //            if (w > 0)
        //            {
        //                if (MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
        //                    this.DialogResult = DialogResult.OK;
        //            }
        //            else
        //                MessageBox.Show("修改失败");



        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("旧密码有误");
        //        txtuid.Text = "";
        //        txtuid.Focus();
        //        return;
        //    }
        //}
        //private void pg()
        //{
        //    string sele = "select count(*) from EmpInfo where EUid=" + id + " and EPwd=@SPwd";
        //    SqlParameter[] p =
        //    {
        //            new SqlParameter("@SPwd",DBHelper.Md5( txtuid.Text.Trim()))
        //        };
        //    int o = (int)DBHelper.ExecuteScalar(sele, p);
        //    if (o > 0)
        //    {
        //        if (txtpwds.Text != txtpwdss.Text)
        //        {
        //            MessageBox.Show("两次密码不一致，请重新输入");
        //            return;
        //        }
        //        else
        //        {
        //            string up = "update EmpInfo set EPwd=@SPwd where EUid=" + id;
        //            SqlParameter[] s =
        //                      {
        //                          new SqlParameter("@SPwd",DBHelper.Md5( txtpwds.Text))
        //                            };
        //            int w = DBHelper.ExecuteNonQuery(up, s);
        //            if (w > 0)
        //            {
        //                if (MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
        //                    this.DialogResult = DialogResult.OK;
        //            }
        //            else
        //                MessageBox.Show("修改失败");



        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("旧密码有误");
        //        txtuid.Text = "";
        //        txtuid.Focus();
        //        return;
        //    }
        //}
        #endregion

        
        #region#管理修改密码
        private void gly(string uid)//管理员
        {
            string sele = "select count(*) from AdminInfo where Uid='" + uid + "' and Pwd=@SPwd";
            SqlParameter[] p =
            {
                    new SqlParameter("@SPwd",DBHelper.Md5( txtuid.Text.Trim()))
                };
            int o = (int)DBHelper.ExecuteScalar(sele, p);
            if (o > 0)
            {
                if (txtpwds.Text != txtpwdss.Text)
                {
                    MessageBox.Show("两次密码不一致，请重新输入");
                    txtpwdss.Text = "";
                    return;
                }
                else
                {
                    string up = "update AdminInfo set Pwd=@Pwd where Uid='" + uid+"'" ;
                    SqlParameter[] s =
                              {
                                  new SqlParameter("@Pwd",DBHelper.Md5( txtpwds.Text))
                                    };
                    int w = DBHelper.ExecuteNonQuery(up, s);
                    if (w > 0)
                    {
                        if (MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                            this.DialogResult = DialogResult.OK;
                        return;
                    }
                    else
                        MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("旧密码有误");
            }
                
        }
        #endregion
        private void xueshengdenglok_Load(object sender, EventArgs e)
        {
            txtuid.Focus();
        }
    }
}
    

