using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_xueshengok_1sele : Form
    {
        string name;
        public Admin_xueshengok_1sele(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        
        public void seles()
        {
              string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID ";
              DataSet ds = DBHelper.GetDataSet(sele);
              xiugais.DataSource = ds.Tables[0];
            xh();
        }
        public void seles(string name)
        {
            if(name=="姓名")
            {
                string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID where  SStudentName like  '" + txtname.Text+"%'";
                DataSet ds = DBHelper.GetDataSet(sele);
              
                xiugais.DataSource = ds.Tables[0];
                
            }
            if (name == "班级")
            {
                string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID where Cid=" + class1.SelectedValue;
                DataSet ds = DBHelper.GetDataSet(sele);
                
                xiugais.DataSource = ds.Tables[0];
                
            }
            if (name == "年级")
            {
                string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID where C.Gid=" + (int)nianj.SelectedValue;
                DataSet ds = DBHelper.GetDataSet(sele);
              
                xiugais.DataSource = ds.Tables[0];
                
            }
            if (name == "性别")
            {
                string sele = "select I.[ID],[SStudentName],StudentSex,TeacherID,SPhone,STimeRZ,SNation,C.CName from Stulnfo I join Class C on I.Cid=C.ID where StudentSex='" + comboBox1.Text+"'";
                DataSet ds = DBHelper.GetDataSet(sele);

                xiugais.DataSource = ds.Tables[0];

            }
            xh();
        }
        int isw = 0;
        private void Admin_xueshengok_1sele_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex =0;
            xiugais.AutoGenerateColumns = false;
            string sele2 = "select *from Class";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            class1.DisplayMember = "CName";
            class1.ValueMember = "ID";
            class1.DataSource = ds2.Tables[0];

            string sele3 = "select *from Grade";
            DataSet ds3 = DBHelper.GetDataSet(sele3);
            nianj.DisplayMember = "GName";
            nianj.ValueMember = "ID";
            nianj.DataSource = ds3.Tables[0];
            this.xiugais.DefaultCellStyle.Alignment = xiugais.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//居中
            seles();
            isw = 10;
        }
        public void xh()
        {
            int nan = 0;
            int nv = 0;
            for(int i = 0; i < xiugais.Rows.Count; i++)
            {
                if ("男" == xiugais.Rows[i].Cells[2].Value.ToString())
                {
                    nan++;
                }
                else
                    nv++;
            }
            label4.Text =string.Format("执行时间:{3} | 总数据:{0}条|男:{1}|女:{2}",  nan+ nv, nan, nv, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
      
        }


        private void btnsele_Click(object sender, EventArgs e)
        {
            seles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seles("姓名");
        }

        private void xiugais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
                if ( e.ColumnIndex == 9)
            {

                string s = (string)xiugais.Rows[e.RowIndex].Cells["sname"].Value;

                string sw = xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString();
                if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string dele = "delete from Stulnfo where SStudentName='" + s + "'" + "and ID='" + sw + "'";
                    int d = DBHelper.ExecuteNonQuery(dele);
                    if (d > 0)
                    {
                        MessageBox.Show("删除成功");
                        seles();
                    }

                    else
                        MessageBox.Show("删除失败");
                }
            }
            if ( e.ColumnIndex == 8)
            {
                if (xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString() == "")
                    return;
                new Admin_xueshengok_2_1ifin("修改", xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString()).ShowDialog();
                seles();
            }
            if (e.ColumnIndex == 10)
            {

                if (xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString() == "")
                    return;
                new Admin_xueshengok2_1sele(xiugais.Rows[e.RowIndex].Cells["xiugaiid"].Value.ToString()).ShowDialog();
            }
        }
        

        private void class1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isw > 0)
                seles("班级");
        }

        private void nianj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isw>0)
            seles("年级");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isw > 0)
                seles("性别");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(xiugais);
        }
    }
    }

