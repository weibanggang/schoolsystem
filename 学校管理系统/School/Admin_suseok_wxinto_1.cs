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
    public partial class Admin_suseok_wxinto_1 : Form
    {
        public Admin_suseok_wxinto_1()
        {
            InitializeComponent();
        }

        private void Admin_suseok_wxinto_1_Load(object sender, EventArgs e)
        {
            lm();

        }
        public void lm()
        {

            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
            string sebh = "select top 1 bh from weixiuwu order by bh desc";
           object s = DBHelper.ExecuteScalar(sebh);
            if (s == null)
                bhs.Text = "1";
            else
                bhs.Text = ((int)s+1).ToString();


        }
        string bxxm = null;
        private void button2_Click(object sender, EventArgs e)
        {
            go();
        }
        public void go()
        {

            if(cmfh.Text=="")
            {
                MessageBox.Show("报修地点不正确");
                return;
            }
            xm();
            if(sld.Checked != true && rsq.Checked != true && kt.Checked != true && z.Checked != true && zhuang.Checked != true && xsj.Checked != true && thb.Checked != true && fs.Checked != true && men.Checked != true && teng.Checked != true && qt.Checked != true)
            {
                MessageBox.Show("请输入报修项目");
                return;
            }
            if(bxname.Text== "")
            {
                MessageBox.Show("请输入报修人");
                return;
            }
            if (bz.Text == "")
                bz.Text = "无";
            into();

        }
       
        string s1 = null; string s2 = null; string s3 = null; string s4 = null; string s5 = null;
        string s6 = null; string s7 = null; string s8= null; string s9 = null; string s10 = null; string s11 = null;

        public void xm()
        {
            if (sld.Checked == true) 
                s1 = sld.Text+" ";
            if (rsq.Checked == true)
                s2 = rsq.Text + " ";
            if (kt.Checked == true)
                s3 = kt.Text + " ";
            if (z.Checked == true)
                s4 = z.Text + " ";
            if (zhuang.Checked == true)
                s5 = zhuang.Text + " ";
            if (xsj.Checked == true)
                s6 = xsj.Text + " ";
            if (thb.Checked == true)
                s7 = thb.Text + " ";
            if (fs.Checked == true)
                s8 = fs.Text + " ";
            if (men.Checked == true)
                s9 = men.Text + " ";
            if (teng.Checked == true)
                s10 = teng.Text + " ";
            if (qt.Checked == true)
                s11 = qt.Text;
            bxxm = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
        }
        public void into()
        {               //宿舍楼名 宿舍房号 维修项目 报修人备注 报修日期  报修人 编号
            string into = "insert into weixiuwu(LID,FNo,other,Remark,BaoXiuSheBei,bxname,bh) values(@LID,@FNo,@other,@Remark,@BaoXiuSheBei,@weixname,@bh)";
            SqlParameter[] p = {
                new SqlParameter("@LID",comlm.SelectedValue),
                new SqlParameter("@FNo",cmfh.SelectedValue),
                new SqlParameter("@other",bxxm),
                new SqlParameter("@Remark",bz.Text),
                new SqlParameter("@BaoXiuSheBei",bxrq.Value),
                new SqlParameter("@weixname",bxname.Text),
                new SqlParameter("@bh",bhs.Text)
            };
            int s=DBHelper.ExecuteNonQuery(into,p);
            if (s > 0)
                MessageBox.Show("提交成功");
            else
                MessageBox.Show("提交失败");
        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lms((int)comlm.SelectedValue);
        }
        int c;
        public void lms(int s)
        {
            string sele = "select  Lount from Dormitory where ID=" + s;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            int sw = 0;
            while (dr.Read())
            {
                sw = (int)dr["Lount"];
            }
            dr.Close();
            if (sw == 1)
            {
                string sele2 = string.Format("select  * from lc where id=2");//查询楼层数量
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comlc.DisplayMember = "Name";
                comlc.ValueMember = "ID";
                comlc.DataSource = ds2.Tables[0];
            }

            else
            {
                string sele2 = string.Format("select top {0} * from lc", sw + 1);
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comlc.DisplayMember = "Name";
                comlc.ValueMember = "ID";
                comlc.DataSource = ds2.Tables[0];
            }
            c = s;

        }

        private void comlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lcs((int)comlc.SelectedValue);
        }
        private void Lcs(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from  tb_Dormitory t join Dormitory d on t.Did=d.ID where t.YCount>0 and Did=" + c;

            }
            else
            {
                sq = "select *  from tb_Dormitory t join Dormitory d on t.Did=d.ID  where Did=" + c + "and t.YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            cmfh.DisplayMember = "DonID";
            cmfh.ValueMember = "ID";
           cmfh.DataSource = ds.Tables[0];



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
