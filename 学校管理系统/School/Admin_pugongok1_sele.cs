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
    public partial class Admin_pugongok1_sele : Form
    {
        string uid;
        public Admin_pugongok1_sele(string uid)
        {
            InitializeComponent();
            this.uid = uid;
     
    }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_pugongok1_sele_Load(object sender, EventArgs e)
        {
            pic();
            sle();


        }
        private void pic()
        {
            string sele1 = "select IMGF from EmpInfo where ID=" + uid;
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
        public void sle()
        {
            string sele = "select I.[ID],[EUid],EName,ESet,EBirthday,EmpNation,EmpFace,EmpIDT,EmpEducate,EWedding,EJG,ETell,EPhone,EIDAd,TRemarks,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID  where I.ID=" + uid;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                bh.Text = dr["ID"].ToString();
                xb.Text = dr["ESet"].ToString();
                zh.Text = dr["EUid"].ToString();
                xm.Text = dr["EName"].ToString();
                this.Text = dr["EName"].ToString() + "的详细信息";
                sfz.Text = dr["EmpIDT"].ToString();
                jslx.Text = dr["Type"].ToString();
                jszc.Text = dr["PName"].ToString();
                csrq.Text = dr["EBirthday"].ToString();
                zzmm.Text = dr["EmpFace"].ToString();
                sjhm.Text = dr["ETell"].ToString();
                string sw = dr["EIDAd"].ToString().Split('$')[1].Split('%')[0];
                string ss = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[0];
                string sa = dr["EIDAd"].ToString().Split('$')[1].Split('%')[1].Split('#')[1];
                jdzz.Text = sw + ss + sa;//家庭住址
                
                mz.Text = dr["EmpNation"].ToString();
                jg.Text = dr["EJG"].ToString();
                rzsj.Text = dr["EmpEducate"].ToString();
                lzsj.Text = dr["EWedding"].ToString();
                jddh.Text = dr["EPhone"].ToString();
                bz.Text = dr["TRemarks"].ToString();
            }
            dr.Close();
        }
    }
}
