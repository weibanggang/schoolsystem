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
    public partial class Admin_pugong_1ok : Form
    {
        public Admin_pugong_1ok()
        {
            InitializeComponent();
          
        }
        public void sw()
        {
            string sele = "select * from EmpType";
            string se = "select * from EmpPosition";
            DataSet ds = DBHelper.GetDataSet(sele);
            DataSet ds1 = DBHelper.GetDataSet(se);
            comlx.DisplayMember = "Type";
            comlx.ValueMember = "ID";
            comlx.DataSource = ds.Tables[0];
            comzw.DisplayMember = "PName";
            comzw.ValueMember = "ID";
            comzw.DataSource = ds1.Tables[0];
        }
        public void seles()
        {
            string sele = "select I.[ID],[EUid],EName,ETell,ESet,EmpNation,EIDAd,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID";
            DataSet ds = DBHelper.GetDataSet(sele);
            dadas.DataSource = ds.Tables[0];
            
        }
        
        private void dadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
            {
                return;
            }
            if (dadas.Rows[e.RowIndex].Cells["ID"].Value.ToString() == "")
                return;
            if (e.ColumnIndex== 10)
            {
            string s = (string)dadas.Rows[e.RowIndex].Cells["sname"].Value;
            if (s == "")
                return;
            string sw = dadas.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            if (MessageBox.Show("是否要删除" + s, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string dele = "delete from EmpInfo where EName='" + s + "'" + "and ID=" + sw;
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
            
            if ( e.ColumnIndex == 11)
            {
                new Admin_pugongok1_sele(dadas.Rows[e.RowIndex].Cells["ID"].Value.ToString()).ShowDialog();
            }
            if (e.ColumnIndex == 9)
            {
                new Admin_pugongok1_into1("修改", dadas.Rows[e.RowIndex].Cells["ID"].Value.ToString()).ShowDialog();
                seles();
            }
        }
        

        private void btnsele_Click(object sender, EventArgs e)
        {
            seles();
        }

        private void Admin_pugong_1ok_Load(object sender, EventArgs e)
        {
            dadas.AutoGenerateColumns = false;
            dadas.ColumnHeadersDefaultCellStyle.Alignment=dadas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            xingbie.SelectedIndex = 0;
            sw();
                seles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sele = "select I.[ID],[EUid],EName,ETell,ESet,EmpNation,EIDAd,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID  where  EName like '%" + txtname.Text + "%'";
                DataSet ds = DBHelper.GetDataSet(sele);
                dadas.DataSource = ds.Tables[0];
        }
        
        

        private void comzw_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sele = "select I.[ID],[EUid],EName,ETell,ESet,EmpNation,EIDAd,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID  where Pid =" + comzw.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            dadas.DataSource = ds.Tables[0];
        }

        private void xingbie_SelectedIndexChanged(object sender, EventArgs e)
        {
string sele = "select I.[ID],[EUid],EName,ETell,ESet,EmpNation,EIDAd,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID  where ESet ='" + xingbie.Text + "'";
            DataSet ds = DBHelper.GetDataSet(sele);
            dadas.DataSource = ds.Tables[0];
        }

        private void comlx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sele = "select I.[ID],[EUid],EName,ETell,ESet,EmpNation,EIDAd,P.PName,T.Type from EmpInfo I join EmpPosition P on I.Pid=P.ID join EmpType T on I.Tid=T.ID  where Tid =" + comlx.SelectedValue;
            DataSet ds = DBHelper.GetDataSet(sele);
            dadas.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.ExportExcel(dadas);
        }
    }
}

