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
    public partial class Admin_xueshengok2_1sele : Form
    {
        string id;
        public Admin_xueshengok2_1sele(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Admin_xueshengok2_1sele_Load(object sender, EventArgs e)
        {

            pic();
            string sele = "select S.[ID],SStudentName,TeacherID,StudentSex,Cid,SFName,SFPhone,SMName,SMPhone,[SID],SHome,SCS,SFace,SPhone,STimeRZ,SNation,SQQMailbox,SRemarks,SJG,P.PName,C.CName from Stulnfo S join Class C on S.Cid=C.ID  join StuPosition P on S.Pid=P.ID where S.ID="+id;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                bh1.Text = dr["ID"].ToString();//编号
                xh1.Text= dr["TeacherID"].ToString();//学号
                xb1.Text = dr["StudentSex"].ToString();//性别
                zw1.Text = dr["PName"].ToString();//职位
                xm1.Text = dr["SStudentName"].ToString();//姓名
                this.Text = dr["SStudentName"].ToString() + "的详细信息";
                bj1.Text = dr["CName"].ToString();//班级
                fjmz.Text = dr["SFName"].ToString();//父亲姓名
                mjmz.Text = dr["SMName"].ToString();//母亲姓名
                sjhm1.Text = dr["SFPhone"].ToString();//手机号码1
                sjhm2.Text = dr["SMPhone"].ToString();//手机号码2
                sfz1.Text = dr["SID"].ToString();//身份证Convert.ToDateTime(dr["SCS"]).ToString("yyyy-MM-dd")
                string sw = dr["SHome"].ToString().Split('$')[1].Split('%')[0];
                string ss = dr["SHome"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                string sa = dr["SHome"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                jdzz1.Text = sw+ss+sa;//家庭住址
                csrj1.Text = Convert.ToDateTime(dr["SCS"]).ToString("yyyy-MM-dd");//出生日期
                zzmm1.Text = dr["SFace"].ToString();//政治面貌
                sjhm.Text = dr["SPhone"].ToString();//手机号码
                rxsj1.Text = Convert.ToDateTime(dr["STimeRZ"]).ToString("yyyy-MM-dd");//入校时间
                qq1.Text = dr["SQQMailbox"].ToString();
                mz1.Text = dr["SNation"].ToString();
                bz.Text = dr["SRemarks"].ToString();
                jg1.Text = dr["SJG"].ToString();
                
            }
dr.Close();
            labage.Text = DBHelper.Age(csrj1.Text).ToString();
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
            pics.Visible = true;
            pics.Image = DBHelper.Read(sele1);
        }
        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
