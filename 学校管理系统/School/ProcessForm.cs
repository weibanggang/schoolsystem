using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置提示信息
        /// </summary>
        public string MessageInfo
        {
            set {
                Action a = new Action(() =>
                {
                    this.labelInfor.Text = value;
                });
                this.Invoke(a);
            }
        }

        /// <summary>
        /// 设置进度条显示值
        /// </summary>
        public int ProcessValue
        {
            set
            {
                Action a = new Action(() =>
                {
                    this.progressBar1.Value = value;

                });
                this.Invoke(a);
            }
        }

        /// <summary>
        /// 设置进度条样式
        /// </summary>
        public ProgressBarStyle ProcessStyle
        {
            set
            {
                Action a = new Action(() =>
                {
                    this.progressBar1.Style = value;
                });
                this.Invoke(a);
            }
        }
        

        private void ProcessForm_Load(object sender, EventArgs e)
        {

        }
    }
}
