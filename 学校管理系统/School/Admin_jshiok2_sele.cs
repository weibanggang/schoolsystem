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
    public partial class Admin_jshiok2_sele : Form
    {
        string uid;
        public Admin_jshiok2_sele(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_jiaoshiok2_sele_Load(object sender, EventArgs e)
        {
            pic();
            sele();
        }
        private void pic()
        {
            string sele1 = "select IMGF from TeaInfo where ID=" + uid;
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
        public void sele()
        {
            string sele = "select T.TSex,TUid,TName,TID,TCS,TFace,TPhone,TPhone,TNation,TQQMailbox,TJG,TTimeRZ,TNation,TTimeLZ,TJTPhone,THoome,TRemarks,TLZReason,C.TypeName,D.PName from TeaInfo T join TeaType C on T.Type=C.ID join TeaPosition D on T.Position=D.ID  where T.ID=" + uid;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                xb.Text = dr["TSex"].ToString();
                zh.Text = dr["TUid"].ToString();
                xm.Text = dr["TName"].ToString();
                this.Text = "教师:"+dr["TName"].ToString() + "的详细信息";
                sfz.Text = dr["TID"].ToString();
                jslx.Text = dr["TypeName"].ToString();
                jszc.Text = dr["PName"].ToString();
                csrq.Text = Convert.ToDateTime(dr["TCS"]).ToString("yyyy-MM-dd");
                zzmm.Text = dr["TFace"].ToString();
                sjhm.Text = dr["TPhone"].ToString();
                string sw = dr["THoome"].ToString().Split('$')[1].Split('%')[0];
                string ss = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                string sa = dr["THoome"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                jdzz.Text = sw + ss + sa;//家庭住址
                mz.Text = dr["TNation"].ToString();
                qqyx.Text = dr["TQQMailbox"].ToString();
                jg.Text = dr["TJG"].ToString();
                rzsj.Text = Convert.ToDateTime(dr["TTimeRZ"]).ToString("yyyy-MM-dd");
                mz.Text = dr["TNation"].ToString();
                lzsj.Text = Convert.ToDateTime(dr["TTimeLZ"]).ToString("yyyy-MM-dd");
                jddh.Text = dr["TJTPhone"].ToString();
                bz.Text = dr["TRemarks"].ToString();
                lzyy.Text = dr["TLZReason"].ToString();
            }
            dr.Close();
            labage.Text = DBHelper.Age(csrq.Text).ToString();
        }
    

        private void btnno_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
