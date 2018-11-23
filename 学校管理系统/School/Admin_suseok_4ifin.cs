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
    public partial class Admin_suseok_4ifin : Form
    {
        string Tags;
        public Admin_suseok_4ifin(string Tags)
        {
            InitializeComponent();
            this.Tags = Tags;
        }
        public  string RoomName;

        private void btnno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (txtfh.Text == "")
            {
                MessageBox.Show("房间号不能为空", "提示", MessageBoxButtons.OK);
                return;
            }
            RoomName = txtfh.Text;
            string sele = "select * from tb_Dormitory where Did="+Tags;
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            while (dr.Read())
            {
                if (RoomName == dr["DonID"].ToString())
                {
                    MessageBox.Show("已有该房号");
                    dr.Close();
                    return;
                }

            }
            dr.Close();



            
            string intos = "insert into tb_Dormitory(Did,DonID,Count) Values(" + Tags+ " ,@DonID,@Count)";//宿舍表 
            SqlParameter[] p = { new SqlParameter("@DonID", RoomName),
            new SqlParameter("@Count", lansw.Value)};
            int s = DBHelper.ExecuteNonQuery(intos, p);
            if (s > 0)
            {
                Upda();
                MessageBox.Show("添加成功");
               
            }
            else
                MessageBox.Show("添加失败");
            this.DialogResult = DialogResult.OK;
        }
        public void Upda()
        {
            int r = 0;
            int f = 0;
            string ds = "select Count from tb_Dormitory where Did="+ Tags;
            SqlDataReader dr = DBHelper.ExecuteReader(ds);
            while (dr.Read())
                {
                r+= (int)dr["Count"];
                f++;
               };
            dr.Close();
            string upda = "update Dormitory set ZZACount=@ZZACount ,Count=@Count where ID=" + Tags;
            SqlParameter[] p = { new SqlParameter("@ZZACount", f),
            new SqlParameter("@Count", r)
            };
            DBHelper.ExecuteNonQuery(upda,p);

        }
        private void admin_shuse5if__Load(object sender, EventArgs e)
        {
            txtfh.Focus();
        }
    }
}
