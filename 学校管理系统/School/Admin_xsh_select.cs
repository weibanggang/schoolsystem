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
    public partial class Admin_xsh_select : Form
    {
   
        public Admin_xsh_select()
        {
            InitializeComponent();
            
        }

        private void Admin_xsh_select_Load(object sender, EventArgs e)
        {
            xiugais.AutoGenerateColumns = false;
            sele();
            xiugais.ColumnHeadersDefaultCellStyle.Alignment = xiugais.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            seles();
          
        }
        public void seles()
        {
            string sele = "select * from AssEmpInfo C join AssPName t on C.Pid=t.ID join AssociationType P on C.Tid=P.ID ";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
        }
        public void sele()
        {
            string sele1 = "select * from AssociationType order by ID";
            DataSet dr = DBHelper.GetDataSet(sele1);
            cboBM.DisplayMember = "TypeName";
            cboBM.ValueMember = "ID";
            cboBM.DataSource = dr.Tables[0];
            string sele2 = "select * from AssPName order by ID";
            DataSet ds2 = DBHelper.GetDataSet(sele2);
            cboZW.DisplayMember = "PName";
            cboZW.ValueMember = "ID";
            cboZW.DataSource = ds2.Tables[0];

        }
        private void button2_Click(object sender, EventArgs e)
        {
            seles();
        }

        private void xiugais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
             {
                return;
            }
            if(e.ColumnIndex== 6)
            {
                if (xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString() == "")
                return;
            new Admin_xsh_upda(xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString()).ShowDialog();
            seles();
            }
            if (e.ColumnIndex == 7)
            {
                string s = xiugais.Rows[e.RowIndex].Cells["xiugai"].Value.ToString();
                if (s == "")
                    return;
                string sw = xiugais.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                if (MessageBox.Show("是否要删除" + sw, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string dele = "delete from AssEmpInfo where ID='" + s + "'";
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
            if (e.ColumnIndex == 8)
            {
                string s = xiugais.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                string sw = "select ID from Stulnfo where TeacherID='" + s+"'";
                SqlDataReader dr = DBHelper.ExecuteReader(sw);
                string sg = null;
                while(dr.Read())
                {
                    sg = dr["ID"].ToString();
                }
                dr.Close();
                new Admin_xueshengok2_1sele(sg).ShowDialog();
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == null)
                return;
            string sele = "select * from AssEmpInfo C join AssPName t on C.Pid=t.ID join AssociationType P on C.Tid=P.ID where  Name like  '%" + txtname.Text + "%'";
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
         
        }

        private void cboZW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZW.SelectedValue == null)
                return;
            string sele = "select * from AssEmpInfo C join AssPName t on C.Pid=t.ID join AssociationType P on C.Tid=P.ID where Pid=" + cboZW.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
        }

        private void cboBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBM.SelectedValue == null)
                return;
            string sele = "select * from AssEmpInfo C join AssPName t on C.Pid=t.ID join AssociationType P on C.Tid=P.ID where Tid=" + cboBM.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            xiugais.DataSource = ds.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(xiugais);
        }
    }
}
