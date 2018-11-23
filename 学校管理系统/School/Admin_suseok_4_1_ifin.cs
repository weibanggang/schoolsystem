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
    public partial class Admin_suseok_4_1_ifin : Form
    {
        int id; //宿舍表id
        string Tags;//楼ID
        public Admin_suseok_4_1_ifin(int id, string Tags)
        {
            InitializeComponent();
            this.id = id;
            this.Tags = Tags;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            if (cmGrade.Text=="")
            {
                MessageBox.Show("班级不能为空");
                return;
            }
          if (txtname.Text=="")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (txtph.Text != "")
            {
                if (txtph.Text.Length != 11)
                {
                    MessageBox.Show("手机号码有误");
                    txtph.Focus();
                    return;
                }
                   
            }

            string seles = "select BedNO from Dormitory_information where DormitoryNO=" + fanghao.SelectedValue;
            SqlDataReader drw = DBHelper.ExecuteReader(seles);
            while (drw.Read())
            {
                if (cuanghao.Text == drw["BedNO"].ToString())
                {
                    MessageBox.Show("该床已经有人");
                    drw.Close();
                    return;
                }

            }
            drw.Close();

            string into = "insert into Dormitory_information(DormitoryNO,Did,Name,RZtime,Tell,BedNO,Class) Values(@DormitoryNO,@Did,@Name,@RZtime,@Tell,@BedNO,@Class)";//宿舍信息表 
            SqlParameter[] p = {
                new SqlParameter("@DormitoryNO", fanghao.SelectedValue),
                new SqlParameter("@Name", txtname.Text),
                new SqlParameter("@RZtime", ruzhu.Value.ToString("yyyy/MM/dd")),
                new SqlParameter("@Tell", txtph.Text),
                new SqlParameter("@BedNO", cuanghao.Value),
                 new SqlParameter("@Class", cmGrade.SelectedValue),
                 new SqlParameter("@Did", Tags)
            };
            int dr = DBHelper.ExecuteNonQuery(into, p);
            if (dr > 0)
            {
                if ((MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK)) == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("添加失败");

            
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
        public void sele()
        {
            cmGrade.Controls.Clear();
            string se = "select * from Class";
            DataSet dr = DBHelper.GetDataSet(se);
            cmGrade.DisplayMember = "CName";
            cmGrade.ValueMember = "ID";
            cmGrade.DataSource = dr.Tables[0];

        }
        public void seles()
        {
            
            string sel = "select * from tb_Dormitory where ID=" + id;
            DataSet dr = DBHelper.GetDataSet(sel);
            fanghao.DisplayMember = "DonID";
            fanghao.ValueMember = "ID";
            fanghao.DataSource = dr.Tables[0];
        }
        private void Admin_suseok_4_1_ifin_Load(object sender, EventArgs e)
        {
            seles();
            sele();
        }

        private void txtph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
