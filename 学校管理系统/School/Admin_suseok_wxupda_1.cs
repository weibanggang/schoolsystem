using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace School
{
    public partial class Admin_suseok_wxupda_1 : Form
    {
        public Admin_suseok_wxupda_1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_suseok_wxupda_1_Load(object sender, EventArgs e)
        {
            lm();
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string qk = null;
        string qj ="否";
        public void didian()
        {
            
            if(wxr.Text.Trim()=="")
            {
                MessageBox.Show("请填写维修人");
                return;
            }
            if (bzs.Text.Trim() == "")
                bzs.Text = "无";
            if (ranbh.Checked == true)
                ID = BHID;
            else
                ID = BHID;
           if (ranzr.Checked == true)
                qk = ranzr.Text;
            else
                qk = ranrw.Text;
            if (ghbq.Checked == true)
                qj = "是";
            upda();

        }
        public void upda()
        {      
         

            //维修人备注 维修日期 维修后确认时间 维修人 维修人 人为自然v 是否换新
            string upda = "update weixiuwu set WRemark=@WRemark,Stata='已修',date=@date,weixhou=@weixhou,weixname=@weixname,renwei=@renwei,hx=@hx where ID="+ ID;
            SqlParameter[] p = {
                new SqlParameter("@WRemark",bzs.Text),
                new SqlParameter("@date",date.Value),
                new SqlParameter("@weixhou",jrsj.Value),
                new SqlParameter("@weixname",wxr.Text),
                new SqlParameter("@renwei",qk),
                new SqlParameter("@hx",qj),
                };
            int s = DBHelper.ExecuteNonQuery(upda, p);
            if (s > 0)
            {
                    MessageBox.Show("提交成功");
            }
                
            else
            {
                MessageBox.Show("提交失败");
            }
                
        }
        string ID=null;
        public void lm()
        {
            string sw = "select bh from weixiuwu where Stata='未修'";
            DataSet dsw = DBHelper.GetDataSet(sw);
            bh.DisplayMember = "bh";
            bh.ValueMember = "ID";
            bh.DataSource = dsw.Tables[0];
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            didian();


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sw = "select DonID,w.ID from weixiuwu w join tb_Dormitory t on w.FNo=t.ID where Stata='未修' and LID=" + comlm.SelectedValue;
            DataSet dsw = DBHelper.GetDataSet(sw);
           cmfh.DisplayMember = "DonID";
           cmfh.ValueMember = "w.ID";
           cmfh.DataSource = dsw.Tables[0];
        }

        private void bh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        string BHID = null;
        private void bh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BHID = bh.SelectedValue.ToString();
        }

        private void cmfh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BHID = cmfh.SelectedValue.ToString();
        }
    }
}
