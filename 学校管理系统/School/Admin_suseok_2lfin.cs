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
    public partial class Admin_suseok_2lfin : Form
    {
        public Admin_suseok_2lfin()
        {
            InitializeComponent();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtloum.Text == "")
            {
                MessageBox.Show("楼名不能为空");
                return;
            }
            if (comlx.Text == "")
            {
                MessageBox.Show("楼名不能为空");
                return;
            }
            #region#图片转换成二进制流
            string mv = Application.StartupPath + "\\mv.png";//获取文件路径赋值
            FileStream fs = new FileStream(mv, FileMode.Open, FileAccess.Read);
            byte[] ageBytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            ageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流
            br.Close();
            fs.Close();
            #endregion
            #region#楼层选出
            string dh = null;
            string se = "select Name,DName from Dormitory";
            SqlDataReader drs = DBHelper.ExecuteReader(se);
            while (drs.Read())
            {
                if (drs["Name"].ToString() == txtloum.Text)
                {
                    MessageBox.Show("已存在该公寓名！", "提示", MessageBoxButtons.OK);
                    drs.Close();
                    return;
                }
                dh = drs["DName"].ToString();
            }
            drs.Close();
            string dhs = null;
            if (dh != null)
            {
                switch (dh)
                {
                    case "A": dhs = "B"; break;
                    case "B": dhs = "C"; break;
                    case "C": dhs = "D"; break;
                    case "D": dhs = "E"; break;
                    case "E": dhs = "F"; break;
                    case "F": dhs = "G"; break;
                    case "G": dhs = "H"; break;
                    case "H": dhs = "I"; break;
                    case "I": dhs = "J"; break;
                    case "J": dhs = "K"; break;
                    case "K": dhs = "L"; break;
                    case "L": dhs = "M"; break;
                    case "M": dhs = "N"; break;
                    case "N": dhs = "O"; break;
                }
            }
            else dhs = "A";
            #endregion
            #region#添加楼层
            
            string into = "insert into Dormitory([Name],DName,[Count],[ZZACount],[Lount],TypeLount,IMGF) Values(@Name,@DName,@Count,@ZZACount,@Lount,@TypeLount,@IMGF)";
            SqlParameter[] p = {
                 new SqlParameter("@Name", txtloum.Text),//楼名称
                 new SqlParameter("@DName", dhs),//楼代号
                 new SqlParameter("@Count", (int)numzcl.Value*(int)nummzjs.Value*(int)numkzr.Value),//可住人数
                 new SqlParameter("@Lount",numzcl.Value),//总层数
                 new SqlParameter("@ZZACount",(int)numzcl.Value*(int)nummzjs.Value),//总间数
                  new SqlParameter("@TypeLount",comlx.Text.ToString()),//宿舍类型
                 new SqlParameter("@IMGF", ageBytes) };//相片
            int dr = DBHelper.ExecuteNonQuery(into, p);

            if (dr > 0)
            {
                string sele = "select top 1 ID from Dormitory order by ID desc";
                int id =(int) DBHelper.ExecuteScalar(sele);
                int c = (int)nummzjs.Value;//每层间数15   
                int mc = (int)numzcl.Value*100;//总层数
                int js = (int)numzcl.Value;//
                for (int i = 1; i <= (int)numzcl.Value * (int)nummzjs.Value; i++)
                {
                    mc++;
                     string intos = "insert into tb_Dormitory(Did,DonID,Count) Values(@Did,@DonID,@Count)";
                    SqlParameter[] s = {
                         new SqlParameter("Count", numkzr.Value),//可住人数
                     new SqlParameter("@DonID", mc),  //房号
                     new SqlParameter("@Did", id)          //哪一个宿舍楼
                    };
                    if(mc== js * 100+c)
                    {
                        js--;
                        mc= js*100;
                    }
                    DBHelper.ExecuteNonQuery(intos, s);
                }
                    if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                        this.Close();
                    else
                        MessageBox.Show("添加失败");
                    this.DialogResult = DialogResult.OK;

                }
            }
#endregion


        private void Admin_shuse1if__Load(object sender, EventArgs e)
        {
            comlx.SelectedIndex = 0;
        }

    
    }
}
