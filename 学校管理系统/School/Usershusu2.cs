using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Usshuse : UserControl
    {
        string name;
        int Ycount = 0;
        int Count=0;
       string BCount = null;
        
        public Usshuse(int ID, string DonID, int Count, int YCount,string BCount, string zt, string lid, string lm)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            lanrens.Text = YCount.ToString();
            lanName.Text = DonID; //房号
            lanName.Tag = ID;//房号ID
            lanrens.Tag = lid; //宿舍楼ID
            this.name = lm;//楼名
            this.Ycount = YCount;//已住人数
            this.Count = Count;//可住人数
            this.BCount = BCount;//班级
            if(BCount!="0")
            {
                labbj.Text = BCount+"班";
                btnif.Text = "详细信息";
            }
            else
            {
                labbj.Text = "未入住";
                btnif.Text = "入住";
            }
        }
        private void btnif_Click(object sender, EventArgs e)
        {
            if(BCount=="0") 
            {
                if((new Admin_suse_fh((int)lanName.Tag,name, lanName.Text).ShowDialog())==DialogResult.OK)
                ((Admin_suseok_1)this.ParentForm.ParentForm).FormShow(new Admin_suseok_4_1(BCount,(int)lanName.Tag, lanName.Text, lanrens.Tag.ToString(), name));
            }
           else
            ////房号ID  房号//宿舍楼ID 楼名
            ((Admin_suseok_1)this.ParentForm.ParentForm).FormShow(new Admin_suseok_4_1(BCount,(int)lanName.Tag,lanName.Text, lanrens.Tag.ToString(),name));
        }

        private void Usshuse_Load(object sender, EventArgs e)
        {

        }
    }
}
