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
using System.Configuration;

namespace School
{
    public partial class Admin_suseok_5nw_1_1 : Form
    {
        public Admin_suseok_5nw_1_1()
        {
            InitializeComponent();
        }

        public void exInto()
        {
            try
            {
                int s = 0;
                try
                {
                    string into = "insert into Neiwu(Did,DormitoryNO,FuZe,class,Point,KPiont,Floor,LJ,yt,Desk,beizi,Cloth,Chair,AirConditionner,Shoes,WashRoom, WC,Botton,Drinking,Light,WaterLog,INelcet,LiveTool,CleanTool,SthPlay,EmptyBed,Others,Remark,times)" +
                      " values(@Did,@DormitoryNO,@FuZe,@class,@Point,@KPiont,@Floor,@LJ,@yt,@Desk,@beizi,@Cloth,@Chair,@AirConditionner,@Shoes,@WashRoom, @WC,@Botton,@Drinking,@Light,@WaterLog,@INelcet,@LiveTool,@CleanTool,@SthPlay,@EmptyBed,@Others,@Remark,@times)";
                    for (int i = 0; i < daorus.Rows.Count; i++)
                    {
                        lblStatus.Text = string.Format("录入进度：50%，录入完毕");
                        SqlParameter[] p =
                            {
                new SqlParameter("@Did",(daorus.Rows[i].Cells[0].Value).ToString()),//宿舍楼2
                new SqlParameter("@DormitoryNO",(daorus.Rows[i].Cells[1].Value).ToString()),//宿舍房号3
                 new SqlParameter("@class",(daorus.Rows[i].Cells[2].Value).ToString()),//--班级
                 new SqlParameter("@Point",(daorus.Rows[i].Cells[3].Value).ToString()),//总分 
                new SqlParameter("@KPiont",(daorus.Rows[i].Cells[4].Value).ToString()),//总扣分6
                new SqlParameter("@Floor",(daorus.Rows[i].Cells[5].Value.ToString())),//地面7
                new SqlParameter("@LJ",(daorus.Rows[i].Cells[6].Value).ToString()),//垃圾 8
                new SqlParameter("@yt",(daorus.Rows[i].Cells[7].Value).ToString()),//阳台9
                new SqlParameter("@Desk",(daorus.Rows[i].Cells[8].Value).ToString()),//桌面10
                new SqlParameter("@beizi",(daorus.Rows[i].Cells[9].Value).ToString()),//被子11
                new SqlParameter("@Cloth",(daorus.Rows[i].Cells[10].Value).ToString()),//衣物12
                new SqlParameter("@Chair",(daorus.Rows[i].Cells[11].Value).ToString()),//椅子13
                new SqlParameter("@AirConditionner",(daorus.Rows[i].Cells[12].Value).ToString()),//空调14
                new SqlParameter("@Shoes",(daorus.Rows[i].Cells[13].Value).ToString()),//鞋子15
                new SqlParameter("@WashRoom",(daorus.Rows[i].Cells[14].Value).ToString()),//冲凉房16
                new SqlParameter("@WC",(daorus.Rows[i].Cells[15].Value).ToString()),//洗手间17
                new SqlParameter("@Botton",(daorus.Rows[i].Cells[16].Value).ToString()),//桶18
                new SqlParameter("@Drinking",(daorus.Rows[i].Cells[17].Value).ToString()),//饮水机19
                new SqlParameter("@Light",(daorus.Rows[i].Cells[18].Value).ToString()),//照明灯20
                new SqlParameter("@WaterLog",(daorus.Rows[i].Cells[19].Value).ToString()),//水龙头21
                new SqlParameter("@INelcet",(daorus.Rows[i].Cells[20].Value).ToString()),//违规电器22
                new SqlParameter("@LiveTool",(daorus.Rows[i].Cells[21].Value).ToString()),//毛巾牙刷23
                new SqlParameter("@CleanTool",(daorus.Rows[i].Cells[22].Value).ToString()),//清洁工具24
                new SqlParameter("@SthPlay",(daorus.Rows[i].Cells[23].Value).ToString()),//物品摆放25
                new SqlParameter("@EmptyBed",(daorus.Rows[i].Cells[24].Value).ToString()),//空床物品 26
                new SqlParameter("@Others",(daorus.Rows[i].Cells[25].Value).ToString()),//其他27
                new SqlParameter("@Remark",(daorus.Rows[i].Cells[26].Value).ToString()),//备注28
                new SqlParameter("@FuZe",(daorus.Rows[i].Cells[28].Value).ToString()),//负责人4
                new SqlParameter("@times",datatime.Value.ToString())//时间29
            };

                        int c = DBHelper.ExecuteNonQuery(into, p);
                        if (c > 0)
                        {

                            s++;
                        }

                    }
                    if (s == daorus.Rows.Count)
                    {
                        lblStatus.Text = string.Format("录入进度：100%，录入完毕");
                        MessageBox.Show("录入成功");

                    }


                    else
                    {

                        MessageBox.Show("录入成功,但输入有错误");
                    }

                }
                catch
                {
                }
            }
            catch {

            }
        }


        public void Into()
        {
            int s=0;
            try
            {
                string into = "insert into Neiwu(Did,DormitoryNO,FuZe,class,Point,KPiont,Floor,LJ,yt,Desk,beizi,Cloth,Chair,AirConditionner,Shoes,WashRoom, WC,Botton,Drinking,Light,WaterLog,INelcet,LiveTool,CleanTool,SthPlay,EmptyBed,Others,Remark,times)" +
                  " values(@Did,@DormitoryNO,@FuZe,@class,@Point,@KPiont,@Floor,@LJ,@yt,@Desk,@beizi,@Cloth,@Chair,@AirConditionner,@Shoes,@WashRoom, @WC,@Botton,@Drinking,@Light,@WaterLog,@INelcet,@LiveTool,@CleanTool,@SthPlay,@EmptyBed,@Others,@Remark,@times)";
                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    dgvSource.Rows[i].Cells[5].Value = dgvSource.Rows[i].Cells[5].Value == null ? "" : dgvSource.Rows[i].Cells[5].Value.ToString();
                        dgvSource.Rows[i].Cells[6].Value = dgvSource.Rows[i].Cells[6].Value == null ? "" : dgvSource.Rows[i].Cells[6].Value.ToString();
                        dgvSource.Rows[i].Cells[7].Value = dgvSource.Rows[i].Cells[7].Value == null ? "" : dgvSource.Rows[i].Cells[7].Value.ToString();
                        dgvSource.Rows[i].Cells[8].Value = dgvSource.Rows[i].Cells[8].Value == null ? "" : dgvSource.Rows[i].Cells[8].Value.ToString();
                        dgvSource.Rows[i].Cells[9].Value = dgvSource.Rows[i].Cells[9].Value == null ? "" : dgvSource.Rows[i].Cells[9].Value.ToString();
                        dgvSource.Rows[i].Cells[10].Value = dgvSource.Rows[i].Cells[10].Value == null ? "" : dgvSource.Rows[i].Cells[10].Value.ToString();
                        dgvSource.Rows[i].Cells[11].Value = dgvSource.Rows[i].Cells[11].Value == null ? "" : dgvSource.Rows[i].Cells[11].Value.ToString();
                        dgvSource.Rows[i].Cells[12].Value = dgvSource.Rows[i].Cells[12].Value == null ? "" : dgvSource.Rows[i].Cells[12].Value.ToString();
                        dgvSource.Rows[i].Cells[13].Value = dgvSource.Rows[i].Cells[13].Value == null ? "" : dgvSource.Rows[i].Cells[13].Value.ToString();
                        dgvSource.Rows[i].Cells[14].Value = dgvSource.Rows[i].Cells[14].Value == null ? "" : dgvSource.Rows[i].Cells[14].Value.ToString();
                        dgvSource.Rows[i].Cells[15].Value = dgvSource.Rows[i].Cells[15].Value == null ? "" : dgvSource.Rows[i].Cells[15].Value.ToString();
                        dgvSource.Rows[i].Cells[16].Value = dgvSource.Rows[i].Cells[16].Value == null ? "" : dgvSource.Rows[i].Cells[16].Value.ToString();
                        dgvSource.Rows[i].Cells[17].Value = dgvSource.Rows[i].Cells[17].Value == null ? "" : dgvSource.Rows[i].Cells[17].Value.ToString();
                        dgvSource.Rows[i].Cells[18].Value = dgvSource.Rows[i].Cells[18].Value == null ? "" : dgvSource.Rows[i].Cells[18].Value.ToString();
                        dgvSource.Rows[i].Cells[19].Value = dgvSource.Rows[i].Cells[19].Value == null ? "" : dgvSource.Rows[i].Cells[19].Value.ToString();
                        dgvSource.Rows[i].Cells[20].Value = dgvSource.Rows[i].Cells[20].Value == null ? "" : dgvSource.Rows[i].Cells[20].Value.ToString();
                        dgvSource.Rows[i].Cells[21].Value = dgvSource.Rows[i].Cells[21].Value == null ? "" : dgvSource.Rows[i].Cells[21].Value.ToString();
                        dgvSource.Rows[i].Cells[22].Value = dgvSource.Rows[i].Cells[22].Value == null ? "" : dgvSource.Rows[i].Cells[22].Value.ToString();
                        dgvSource.Rows[i].Cells[23].Value = dgvSource.Rows[i].Cells[23].Value == null ? "" : dgvSource.Rows[i].Cells[23].Value.ToString();
                        dgvSource.Rows[i].Cells[24].Value = dgvSource.Rows[i].Cells[24].Value == null ? "" : dgvSource.Rows[i].Cells[24].Value.ToString();
                        dgvSource.Rows[i].Cells[25].Value = dgvSource.Rows[i].Cells[25].Value == null ? "" : dgvSource.Rows[i].Cells[25].Value.ToString();
                        dgvSource.Rows[i].Cells[26].Value = dgvSource.Rows[i].Cells[26].Value == null ? "" : dgvSource.Rows[i].Cells[26].Value.ToString();
                    lblStatus.Text = string.Format("录入进度：50%，录入完毕");
                    SqlParameter[] p =
                        {
                new SqlParameter("@Did",comlm.Text),//宿舍楼2
                new SqlParameter("@DormitoryNO",(dgvSource.Rows[i].Cells[1].Value).ToString()),//宿舍房号3
                 new SqlParameter("@class",(dgvSource.Rows[i].Cells[2].Value).ToString()),//--班级
                 new SqlParameter("@Point",(dgvSource.Rows[i].Cells[3].Value).ToString()),//总分 
                new SqlParameter("@KPiont",(dgvSource.Rows[i].Cells[4].Value).ToString()),//总扣分6
                new SqlParameter("@Floor",(dgvSource.Rows[i].Cells[5].Value.ToString())),//地面7
                new SqlParameter("@LJ",(dgvSource.Rows[i].Cells[6].Value).ToString()),//垃圾 8
                new SqlParameter("@yt",(dgvSource.Rows[i].Cells[7].Value).ToString()),//阳台9
                new SqlParameter("@Desk",(dgvSource.Rows[i].Cells[8].Value).ToString()),//桌面10
                new SqlParameter("@beizi",(dgvSource.Rows[i].Cells[9].Value).ToString()),//被子11
                new SqlParameter("@Cloth",(dgvSource.Rows[i].Cells[10].Value).ToString()),//衣物12
                new SqlParameter("@Chair",(dgvSource.Rows[i].Cells[11].Value).ToString()),//椅子13
                new SqlParameter("@AirConditionner",(dgvSource.Rows[i].Cells[12].Value).ToString()),//空调14
                new SqlParameter("@Shoes",(dgvSource.Rows[i].Cells[13].Value).ToString()),//鞋子15
                new SqlParameter("@WashRoom",(dgvSource.Rows[i].Cells[14].Value).ToString()),//冲凉房16
                new SqlParameter("@WC",(dgvSource.Rows[i].Cells[15].Value).ToString()),//洗手间17
                new SqlParameter("@Botton",(dgvSource.Rows[i].Cells[16].Value).ToString()),//桶18
                new SqlParameter("@Drinking",(dgvSource.Rows[i].Cells[17].Value).ToString()),//饮水机19
                new SqlParameter("@Light",(dgvSource.Rows[i].Cells[18].Value).ToString()),//照明灯20
                new SqlParameter("@WaterLog",(dgvSource.Rows[i].Cells[19].Value).ToString()),//水龙头21
                new SqlParameter("@INelcet",(dgvSource.Rows[i].Cells[20].Value).ToString()),//违规电器22
                new SqlParameter("@LiveTool",(dgvSource.Rows[i].Cells[21].Value).ToString()),//毛巾牙刷23
                new SqlParameter("@CleanTool",(dgvSource.Rows[i].Cells[22].Value).ToString()),//清洁工具24
                new SqlParameter("@SthPlay",(dgvSource.Rows[i].Cells[23].Value).ToString()),//物品摆放25
                new SqlParameter("@EmptyBed",(dgvSource.Rows[i].Cells[24].Value).ToString()),//空床物品 26
                new SqlParameter("@Others",(dgvSource.Rows[i].Cells[25].Value).ToString()),//其他27
                new SqlParameter("@Remark",(dgvSource.Rows[i].Cells[26].Value).ToString()),//备注28
                new SqlParameter("@FuZe",compo.Text.ToString()),//负责人4
                new SqlParameter("@times",datatime.Value.ToString())//时间29
            };

                        int c = DBHelper.ExecuteNonQuery(into, p);
                        if (c > 0)
                        {
                       
                        s++;
                        }
                        
                    }
                    if (s == dgvSource.Rows.Count)
                {
                    lblStatus.Text = string.Format("录入进度：100%，录入完毕");
                    MessageBox.Show("录入成功");
                    
                }
                        

                    else
                    {
                    lblStatus.Text = string.Format("录入进度：50%，录入完毕");
                    }
                
            }
            catch 
            {
               

            }
        }
        private void Admin_suseok_5nw_1_1_Load(object sender, EventArgs e)
        {
            dgvSource.AutoGenerateColumns = false;
            dgvSource.ColumnHeadersDefaultCellStyle.Alignment = dgvSource.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            daorus.ColumnHeadersDefaultCellStyle.Alignment = daorus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            lm();
            //compo.SelectedIndex = 1;

        }
        public void lm()
        {
            
            string sele = "select * from Dormitory";
            DataSet ds = DBHelper.GetDataSet(sele);
            comlm.DisplayMember = "Name";
            comlm.ValueMember = "ID";
            comlm.DataSource = ds.Tables[0];
            string se1 = "select Fuze from Neiwu group by Fuze";
            DataSet ds2 = DBHelper.GetDataSet(se1);
            compo.DisplayMember = "Fuze";
            compo.DataSource = ds2.Tables[0];
            CountMoney();
            s = 0;
        }
        int c = 0;
        public void lms(int s)
        {
            string sele = "select  Lount from Dormitory where ID=" + s;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            int sw = 0;
            while(dr.Read())
            {
                sw = (int)dr["Lount"];
            }
            dr.Close();
            if(sw==1)
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

        #region OK
        private void CountMoney()
        {
            try
            {
                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    dgvSource.Rows[i].Cells[4].Value = string.Format("{0}", (
                         Convert.ToSingle(dgvSource.Rows[i].Cells[25].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[24].Value) +
                      Convert.ToSingle(dgvSource.Rows[i].Cells[5].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[6].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[7].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[8].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[9].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[10].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[11].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[12].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[13].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[14].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[15].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[16].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[17].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[18].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[19].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[20].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[21].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[22].Value) +
                     Convert.ToSingle(dgvSource.Rows[i].Cells[23].Value)));
                    dgvSource.Rows[i].Cells[3].Value = string.Format("{0}", 100 - double.Parse(dgvSource.Rows[i].Cells[4].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dgvSource.CurrentCell.Value = null;
            }
        }



        private void comlm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lms((int)comlm.SelectedValue);

            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int s = 0;
        private void dgvSource_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(s==0)
            CountMoney();

        }

        private void dgvSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                lblStatus.Text = @"状态栏：当前共有 " + (dgvSource.RowCount - 1) + @" 条记录，当前选中： " + dgvSource.Rows[e.RowIndex].Cells["DonID"].Value.ToString() + "房号-" + dgvSource.Columns[dgvSource.CurrentCell.ColumnIndex].HeaderText.ToString() + @" ，坐标（" +
                 (dgvSource.CurrentCell.RowIndex + 1) + @"，" + (dgvSource.CurrentCell.ColumnIndex + 1) +
                 @"）";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (compo.Text.Trim() == "")
                {
                    MessageBox.Show("检查人不能为空");
                    return;
                }
                if (button2.Text != "Excel导入")
                {
                    s = 10;
                    exInto();
                    s = 0;
                }
                else
                {
                    s = 10;
                    Into();
                    s = 0;
                    lm();
                }
            }
            catch {
            }


        }

        private void comlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lcs((int)comlc.SelectedValue);
        }
        private void Lcs(int w)
        {
            string sq=null;
            if (w==1)
            {
                sq = "select *  from  tb_Dormitory t join Dormitory d on t.Did=d.ID where t.YCount>0 and Did=" + c;

            }
            else
            {
                sq = "select *  from tb_Dormitory t join Dormitory d on t.Did=d.ID  where Did=" + c + "and t.YCount>0 and convert(nvarchar(1),DonID)=" + (w - 1);

            }
            DataSet ds = DBHelper.GetDataSet(sq);
            dgvSource.DataSource = ds.Tables[0];
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Excel导入") {
                button2.Text = "关闭Excel";
                daorus.DataSource=DBHelper.daoru(daorus);
                daorus.Visible = true;
            }

            else
            {
                button2.Text = "Excel导入";
                daorus.Visible = false;
            }
                
           
            
        }

        private void daorus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void daorus_DragDrop(object sender, DragEventArgs e)
        {
            button2.Text = "关闭Excel";
            daorus.Visible = true;
          
            try
            {
                string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                daorus.DataSource = DBHelper.daorusw(path);

            }
            catch 
            {
                
            }
        }

        private void dgvSource_DragDrop(object sender, DragEventArgs e)
        {
            button2.Text = "关闭Excel";
            daorus.Visible = true;
            try
            {
                string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                daorus.DataSource = DBHelper.daorusw(path);

            }
            catch 
            {
              
            }
        }

        private void dgvSource_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
