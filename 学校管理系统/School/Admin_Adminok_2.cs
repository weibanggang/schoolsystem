using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Admin_Adminok_2 : Form
    {
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
        /// <summary>  
        /// 窗体动画函数    注意：要引用System.Runtime.InteropServices;  
        /// </summary>  
        /// <param name="hwnd">指定产生动画的窗口的句柄</param>  
        /// <param name="dwTime">指定动画持续的时间</param>  
        /// <param name="dwFlags">指定动画类型，可以是一个或多个标志的组合。</param>  
        /// <returns></returns>
        #region 窗体动画
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        //下面是可用的常量，根据不同的动画效果声明自己需要的  
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志  
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展  
        private const int AW_HIDE = 0x10000;//隐藏窗口  
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志  
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略  
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果
        #endregion
        string gly=null;
        public Admin_Adminok_2(string gly)
        {
            InitializeComponent();
            this.gly = gly;
        }
        string uid = null;
        public Admin_Adminok_2(string gly,string uid)
        {
            InitializeComponent();
            this.gly = gly;
            this.uid = uid;
        }

        private void Admin_Adminok_2_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 350, AW_VER_NEGATIVE | AW_ACTIVE | AW_CENTER);//由内向外扩展
            this.skin.SkinFile = Application.StartupPath + @"\Skins\office2007.ssk";
            if(gly=="教师管理")
              FormShow(new Admin_jshiok1(gly,uid));
               if(gly=="员工管理")
            FormShow(new Admin_pugongok1(gly, uid));
             if(gly=="学生管理")
           FormShow(new Admin_xueshengok_1(gly, uid));
            if (gly=="宿舍管理")
              FormShow(new Admin_suseok_1(gly, uid));
          if (gly=="社团管理")
           FormShow(new Admin_shetuanok_1(gly, uid));
                 if (gly=="学生会管理")
          FormShow(new Admin_xshok(gly, uid));
            if (gly == "图书管理")
                FormShow(new Admin_tushuok_1(gly, uid));

        }
        public void FormShow(Form frm)
        {
            panzhuangti.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panzhuangti;
            frm.Show();

        }

        private void Admin_Adminok_2_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
            
        }
    }
}
