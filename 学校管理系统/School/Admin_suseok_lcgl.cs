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
    public partial class Admin_suseok_lcgl : Form
    {
        public Admin_suseok_lcgl()
        {
            InitializeComponent();
        }
        
        private void Admin_suseok_lcgl_Load(object sender, EventArgs e)
        {
            #region//datagridview单元格内容居中下面是dataGridView1内容居中
            this.dataGridView1.DefaultCellStyle.Alignment = dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            #endregion
            dataGridView1.AutoGenerateColumns = false;
            das.AutoGenerateColumns = false;
            FormShow(new Admin_suseok_lcgl_1());
            Se();
        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panzhuangti;
            frm.Show();
        }
       
        public void Se()
        {
            #region#第一次加载
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
            comxzlm.DisplayMember = "Name";
            comxzlm.ValueMember = "ID";
            comxzlm.DataSource = ds.Tables[0];
            comcxlm.DisplayMember = "Name";
            comcxlm.ValueMember = "ID";
            comcxlm.DataSource = ds.Tables[0];

            string bj = "select * from Class";
            DataSet ds2 = DBHelper.GetDataSet(bj);
           combj.DisplayMember = "CName";
           combj.ValueMember = "ID";
           combj.DataSource = ds2.Tables[0];
            
            conbjw.DisplayMember = "CName";
            conbjw.ValueMember = "ID";
            conbjw.DataSource = ds2.Tables[0];
        }
#endregion
        
        
        int xzid = 0;//楼ID
        int xzfh = 0;
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
            xzid = s;

        }

        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lms((int)comlm.SelectedValue);
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
                sq = "select *  from tb_Dormitory where YCount>0 and Did=" + xzid;

            }
            else
            {
                sq = "select *  from tb_Dormitory where Did=" + xzid + "and YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            comfh.DisplayMember = "DonID";
            comfh.ValueMember = "ID";
            comfh.DataSource = ds.Tables[0];

        }
        public void Cname(int s)
        {
            string sele = string.Format("select ID,Name  from Dormitory_information where Did={0} and DormitoryNO={1}", xzid, s);
            DataSet ds = DBHelper.GetDataSet(sele);
            comname.DisplayMember = "Name";
            comname.ValueMember = "ID";
            comname.DataSource = ds.Tables[0];
            xzfh = s;
        }
        private void comfh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cname((int)comfh.SelectedValue);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int nameID = 0;
        private void comname_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameID = (int)comname.SelectedValue;
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlcs.DisplayMember = "Name";
            comlcs.ValueMember = "ID";
            comlcs.DataSource = ds.Tables[0];
        }

        private void comlcs_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            lmss((int)comlcs.SelectedValue);
         
            comzh.Items.Clear();
        }
        int cs = 0;//楼ID
        public void lmss(int s)
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
                comlcsw.DisplayMember = "Name";
                comlcsw.ValueMember = "ID";
                comlcsw.DataSource = ds2.Tables[0];
            }

            else
            {
                string sele2 = string.Format("select top {0} * from lc", sw + 1);
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comlcsw.DisplayMember = "Name";
                comlcsw.ValueMember = "ID";
                comlcsw.DataSource = ds2.Tables[0];
            }
            cs = s;

        }
        int css = 0;
     public void xzlmss(int s)
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
                comxzlc.DisplayMember = "Name";
                comxzlc.ValueMember = "ID";
                comxzlc.DataSource = ds2.Tables[0];
            }

            else
            {
                string sele2 = string.Format("select top {0} * from lc", sw + 1);
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comxzlc.DisplayMember = "Name";
                comxzlc.ValueMember = "ID";
                comxzlc.DataSource = ds2.Tables[0];
            }
            mv = s;

        }
        int mv = 0;
     
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comzh.Items.Clear();
            Loads(int.Parse(comfhs.Text));
          
        }
        public void Cnames(int s)
        {
            string sele = string.Format("select ID,Name  from Dormitory_information where Did={0} and DormitoryNO={1}", xzid, s);
            DataSet ds = DBHelper.GetDataSet(sele);
            comname.DisplayMember = "Name";
            comname.ValueMember = "ID";
            comname.DataSource = ds.Tables[0];
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Lcss((int)comlcsw.SelectedValue);
            comzh.Items.Clear();
            
        }
       
        private void Lcss(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from tb_Dormitory where YCount>0 and Did=" + cs;

            }
            else
            {
                sq = "select *  from tb_Dormitory where Did=" + cs + "and YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
           comfhs.DisplayMember = "DonID";
           comfhs.ValueMember = "ID";
           comfhs.DataSource = ds.Tables[0];
        

        }
        private void wLcss(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from tb_Dormitory where YCount>0 and Did=" + mv;

            }
            else
            {
                sq = "select *  from tb_Dormitory where Did=" + mv + "and YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            comfhws.DisplayMember = "DonID";
            comfhws.ValueMember = "ID";
            comfhws.DataSource = ds.Tables[0];

        }
        int yy = 0;
        private void comxzlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yy!=0)
            {
                xzlmss((int)comxzlm.SelectedValue);
                yy = 0;
            }
           
        }

        private void comxzlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            wLcss((int)comxzlc.SelectedValue);
        }
        int zc = 0;
        private void comfhws_SelectedIndexChanged(object sender, EventArgs e)
        {
            zc = (int)comfhws.SelectedValue;

            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comzr.DisplayMember = "Name";
            comzr.ValueMember = "ID";
            comzr.DataSource = ds.Tables[0];
           
        }

        public void lmssl(int s)
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
                comzrlc.DisplayMember = "Name";
                comzrlc.ValueMember = "ID";
                comzrlc.DataSource = ds2.Tables[0];
            }

            else
            {
                string sele2 = string.Format("select top {0} * from lc", sw + 1);
                DataSet ds2 = DBHelper.GetDataSet(sele2);
                comzrlc.DisplayMember = "Name";
                comzrlc.ValueMember = "ID";
                comzrlc.DataSource = ds2.Tables[0];
            }
            css = s;

        }

        private void comzr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(xx!=0)
            {
                lmssl((int)comzr.SelectedValue);
                xx = 0;
            }
          
        }
        private void comzrlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cwLcss((int)comzrlc.SelectedValue);
        }
        private void cwLcss(int w)
        {
            string sq = null;
            if (w == 1)
            {
                sq = "select *  from tb_Dormitory where Bcount=0 and YCount=0 and Did=" + css;

            }
            else
            {
                sq = " select *  from tb_Dormitory where Bcount=0 and YCount=0 and Did=" + css + "and  convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            comzrfh.DisplayMember = "DonID";
            comzrfh.ValueMember = "ID";
            comzrfh.DataSource = ds.Tables[0];

        }
        
 
        public void Loads(int f)
        {
            string rs = string.Format("select Count from tb_Dormitory where Did={1} and DonID={0}", f, cs);
            int dws = (int)DBHelper.ExecuteScalar(rs);
            int[] bd = new int[dws+1];
            string se = string.Format("select * from Dormitory_information d join  tb_Dormitory tb on d.DormitoryNO=tb.ID  where d.Did={1} and tb.DonID={0}", f, cs);//房号ID
            SqlDataReader dr = DBHelper.ExecuteReader(se);
            while (dr.Read())
            {
                
                for(int i= 1; i<=dws;i++)
                {
                    if ((int)dr["bedNo"] == i)
                        bd[i] = i;
                }
               
            }
            dr.Close();
            for (int i = 1; i< bd.Length; i++)
            {
                if (bd[i] == 0)
                    comzh.Items.Add(i);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (comfh.Text.Trim() == "")
            {
                MessageBox.Show("现住房号不能为空");
                return;
            }
            if (comname.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (comfhs.Text.Trim() == "")
            {
                MessageBox.Show("转入房号不能为空");
                return;
            }
            if (comzh.Text.Trim() == "")
            {
                MessageBox.Show("床号不能为空");
                return;
            }
            if (MessageBox.Show("请问是否把‘" + comname.Text + "’换到‘" + comfhs.Text + "房"+ comzh.Text + "床’？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                swq();
        }
        public void bd()
        {
            if(comfhs.Text.Trim()=="")
            {
                MessageBox.Show("现住房号不能为空");
                return;
            }
            if (comname.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (comfhs.Text.Trim() == "")
            {
                MessageBox.Show("转入房号不能为空");
                return;
            }
            if (comzh.Text.Trim() == "")
            {
                MessageBox.Show("床号不能为空");
                return;
            }
        }

        public void swq()
        {
            
            string my = "update Dormitory_information set DormitoryNO="+ comfhs.SelectedValue+ ", Did="+ comlcs.SelectedValue+" where ID="+ comname.SelectedValue;
            DBHelper.ExecuteNonQuery(my);

            //查询转入房号人数
            string cc = "select count(*) from Dormitory_information where DormitoryNO=" + comfhs.SelectedValue + " and Did=" + comlcs.SelectedValue;
            int js = (int)DBHelper.ExecuteScalar(cc);
            //修改转入房号人数
            string zss = "update tb_Dormitory set Ycount=" + js + " where ID=" + comfhs.SelectedValue;
            DBHelper.ExecuteNonQuery(zss);
            //查询转入楼人数
            string lh2w = "select COUNT(*) from Dormitory_information where Did=" + comlcs.SelectedValue;
            int s12w = (int)DBHelper.ExecuteScalar(lh2w);
            //修改转入栋楼人数
            string up12w = "update Dormitory set YCount =" + s12w + " where ID= " + comlcs.SelectedValue;
            int srs2 = (int)DBHelper.ExecuteNonQuery(up12w);

            //查询转出房号人数
            string cx = "select count(*) from Dormitory_information where DormitoryNO="+ comfh.SelectedValue+" and Did="+ comlm.SelectedValue;
            int j = (int)DBHelper.ExecuteScalar(cx);
            //修改转出房号人数
            string zs1 = "update tb_Dormitory set Ycount=" + j+" where ID=" + comfh.SelectedValue;
            DBHelper.ExecuteNonQuery(zs1);
            //查询转出楼人数
            string lh2 = "select COUNT(*) from Dormitory_information where Did=" + comlm.SelectedValue;
            int s12 = (int)DBHelper.ExecuteScalar(lh2);
            //修改转出栋楼人数
            string up12 = "update Dormitory set YCount =" + s12 + " where ID= " + comlm.SelectedValue;
            int srs2s = (int)DBHelper.ExecuteNonQuery(up12);
            if(srs2s>0)
            {
                MessageBox.Show("转宿成功");
            }
            else
                MessageBox.Show("转宿失败");
            

        }
        private void comzh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int zhuanshu = 0;
        private void comzrfh_SelectedIndexChanged(object sender, EventArgs e)
        {
            zhuanshu = (int)comzrfh.SelectedValue;

        }
        public void show()
        {
             int s=0;
            int Counts=0;
            int Class = 0;
            string my = "select count(*) from Dormitory_information where DormitoryNO=" + zc;//获取当前人数
            s = (int)DBHelper.ExecuteScalar(my);
            string mysw = "select top 1 Class from Dormitory_information where DormitoryNO=" + zc;//获取班级
            SqlDataReader dr = DBHelper.ExecuteReader(mysw);
            while(dr.Read())
            {
                Class = (int)dr["Class"];
            }
            dr.Close();
            string mys = "select Count from tb_Dormitory where ID=" + zhuanshu;//获取宿舍床位
            SqlDataReader drs = DBHelper.ExecuteReader(mys);
            while (drs.Read())
            {
                Counts = (int)drs["Count"];
            }
            drs.Close();
            if(s > Counts)
            {
                MessageBox.Show("转出人数多于转入住宿床位");
                return;
            }
            //修改房号以及人数
            string zs = "update Dormitory_information set DormitoryNO="+ zhuanshu+ ",Did="+ comzr.SelectedValue+ " where DormitoryNO=" + zc;
            int ws = DBHelper.ExecuteNonQuery(zs);
           //修改现在房号以及人数
            string mu = "update tb_Dormitory set YCount=" + s + ",Bcount=" + Class + " where ID=" + zhuanshu;
                int sr=DBHelper.ExecuteNonQuery(mu);
            string lh = "select COUNT(*) from Dormitory_information where Did=" + comzr.SelectedValue;
            int s1 = (int)DBHelper.ExecuteScalar(lh);
            string up1 = "update Dormitory set YCount =" + s1 + " where ID= " + comzr.SelectedValue;
            int srs = (int)DBHelper.ExecuteNonQuery(up1);
            //修改以前房号为0以及人数0
            string zs1 = "update tb_Dormitory set Ycount=0,Bcount=0 where ID=" + zc;
            int ws1 = DBHelper.ExecuteNonQuery(zs1);
            //查询所有这栋楼的人数
            string lh2 = "select COUNT(*) from Dormitory_information where Did=" + comxzlm.SelectedValue;
            int s12 = (int)DBHelper.ExecuteScalar(lh2);
            //修改这栋楼的人数
            string up12 = "update Dormitory set YCount =" + s12 + " where ID= " + comxzlm.SelectedValue;
            int srs2 = (int)DBHelper.ExecuteNonQuery(up12);
            if (srs2 > 0)
            {
                MessageBox.Show("转宿成功");
            }
            else
                MessageBox.Show("转宿失败");
            

        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (comfhws.Text.Trim() == "")
            {
                MessageBox.Show("现住房号不能为空");
                return;
            }
            if (comzrfh.Text.Trim() == "")
            {
                MessageBox.Show("转入房号不能为空");
                return;
            }
            
            if (MessageBox.Show("请问是否把‘" + comxzlm.Text + "楼" + comfhws.Text + "房’换到‘" + comzr.Text + "楼" + comzrfh.Text + "房’？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                show();
            }
        }

        private void comxzlm_Click(object sender, EventArgs e)
        {
            yy = 1;
        }
        int xx = 0;
        private void comzr_Click(object sender, EventArgs e)
        {
            xx = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comfhws.Text.Trim() == "")
            {
                MessageBox.Show("现住房号不能为空");
                return;
            }
            if (MessageBox.Show("请问是否把‘" + comxzlm.Text + "楼" + comfhws.Text + "房’转出，转出后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                swsq();
            }
        }
        public void swsq()
        {
            string my = " delete from Dormitory_information where Did ="+ comxzlm .SelectedValue+ " and DormitoryNO =" + zc;
            DBHelper.ExecuteNonQuery(my);
            //修改当前房号人数0
            string zs1 = "update tb_Dormitory set Ycount=0,Bcount=0 where ID=" + zc;
            DBHelper.ExecuteNonQuery(zs1);
            //查询这栋楼人数
            string lh2 = "select COUNT(*) from Dormitory_information where Did=" + comxzlm.SelectedValue;
            int s12 = (int)DBHelper.ExecuteScalar(lh2);
            //修改这栋楼人数
            string up12 = "update Dormitory set YCount =" + s12 + " where ID= " + comxzlm.SelectedValue;
            int srs2 = (int)DBHelper.ExecuteNonQuery(up12);
            if (srs2 > 0)
            {
                MessageBox.Show("转出");
            }
            else
                MessageBox.Show("转出");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comfhs.Text.Trim() == "")
            {
                MessageBox.Show("现住房号不能为空");
                return;
            }
            if (comname.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (MessageBox.Show("请问是否把‘" + comname.Text + "’转出，转出后不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                mj();
            }
           
        }
        public void mj()
        {
            string de = "delete from Dormitory_information where ID="+ comname.SelectedValue;
            DBHelper.ExecuteNonQuery(de);
            //查询转出房号人数
            string cx = "select count(*) from Dormitory_information where DormitoryNO=" + comfh.SelectedValue + " and Did=" + comlm.SelectedValue;
            int j = (int)DBHelper.ExecuteScalar(cx);
            //修改转出房号人数
            if(j==0)
            {
                string zs1 = "update tb_Dormitory set Ycount=" + j + " BCount=0 where ID=" + comfh.SelectedValue;
                DBHelper.ExecuteNonQuery(zs1);

            }
            else
            {
                string zs1 = "update tb_Dormitory set Ycount=" + j + " where ID=" + comfh.SelectedValue;
                DBHelper.ExecuteNonQuery(zs1);

            }
            
            //查询转出楼人数
            string lh2 = "select COUNT(*) from Dormitory_information where Did=" + comlm.SelectedValue;
            int s12 = (int)DBHelper.ExecuteScalar(lh2);
            //修改转出栋楼人数
            string up12 = "update Dormitory set YCount =" + s12 + " where ID= " + comlm.SelectedValue;
            int srs2s = (int)DBHelper.ExecuteNonQuery(up12);
            if (srs2s > 0)
            {
                MessageBox.Show("转出成功");
            }
            else
                MessageBox.Show("转出失败");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panzhuangti.Visible = true;
            groupBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            panzhuangti.Visible = false;
            dataGridView1.Visible = false;
            das.Visible = true;
            show("班级查询", combj.Text);

        }
        public void show(string tj,string bd)
        {
            string se = null;
            if (tj== "班级查询")
            {
                se= "select DName,TypeLount,d.Name,BCount,DonID,RZtime,Tell from Dormitory_information D join  Class C   on C.ID=D.Class join tb_Dormitory T  on D.DormitoryNO=T.ID join Dormitory ts on ts.id=d.Did  where BCount='" + bd+"'";//房号ID
            }
            if (tj == "姓名查询")
            {
                se = "select DName,TypeLount,d.Name,BCount,DonID,RZtime,Tell from Dormitory_information D join  Class C   on C.ID=D.Class join tb_Dormitory T  on D.DormitoryNO=T.ID join Dormitory ts on ts.id=d.Did  where D.Name like '%" + bd+"%'";//房号ID
            }
           
            DataSet dr = DBHelper.GetDataSet(se);
            das.DataSource = dr.Tables[0];
        }
        public void mys(string id1,string id2,string id3,string id4)
        {
            string msq = null;

            if (id1 == "条件23")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where zt = " + id4 + " and BCount='" + id3 + "'";

            }


            if (id1 == "条件123")
            {
               
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did="+id2+"and Bcount='"+id3+"' AND zt=0" + id4;
                
            }
            if (id1 == "条件12")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did=" + id2 + " and BCount='" + id3 + "'";

            }
            if (id1 == "条件1")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did=" + id2 ;

            }
            if (id1 == "条件2")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where BCount='" + id3+"'";

            }
            if (id1 == "条件3")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where zt = "+id4;

            }
            
            if (id1 == "条件13")
            {
                msq = "select * from tb_Dormitory t  join Dormitory d on t.Did=d.id where Did=" + id2 + " and zt=" + id4;

            }
            
            DataSet ds = DBHelper.GetDataSet(msq);
            dataGridView1 .DataSource = ds.Tables[0];
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            panzhuangti.Visible = false;
            dataGridView1.Visible = false;
            das.Visible = true;
            
                show("姓名查询", txtxm.Text);
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            panzhuangti.Visible = false;
            dataGridView1.Visible = true ;
            das.Visible = false ;
            if (chlm.Checked==true&&chbj.Checked==true&&chzd.Checked==true)
            {
                int zd = 0;
                string Did = comcxlm.SelectedValue.ToString();
                string Name1 = (string)conbjw.Text;
                if(yan.Checked==true)
                {

                    zd = 1;
                }
                
                mys("条件123", Did, Name1, zd.ToString());


            }
            if (chlm.Checked == true && chbj.Checked == true)
            {
                int zd = 0;
                string Did = comcxlm.SelectedValue.ToString();
                string Name1 = conbjw.Text;
                mys("条件12", Did, Name1, zd.ToString());
            }
            if (chlm.Checked == true )
            {
                int zd = 0;
                string Did = comcxlm.SelectedValue.ToString();
                mys("条件1", Did, "", zd.ToString());
            }
            if (chbj.Checked == true)
            {
                int zd = 0;
                string Name1 = (string)conbjw.Text;
                mys("条件2","", Name1, zd.ToString());
            }
        if (chzd.Checked == true)
            {
                int zd = 0;
                if (yan.Checked == true)
                {
                    zd = 1;

                }
                mys("条件3", "", "", zd.ToString());
            }
            if (chzd.Checked == true&&chlm.Checked==true)
            {
                int zd = 0;
                string Did = comcxlm.SelectedValue.ToString();
                if (yan.Checked == true)
                {
                    zd = 1;

                }
                else
                    zd = 0;
                mys("条件13", Did, "", zd.ToString());
            }
            if (chzd.Checked == true&&chbj.Checked==true)
            {
                int zd = 0;
                string Name1 = (string)conbjw.Text;
                if (yan.Checked == true)
                {
                    zd = 1;

                }
                else
                    zd = 0;
                mys("条件23", "", Name1, zd.ToString());
            }
            
        }

        private void conbjw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comcxlm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
