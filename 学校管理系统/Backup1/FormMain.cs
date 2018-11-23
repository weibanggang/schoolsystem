using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Process;
using System.Threading;

namespace ProcessDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessOperator process = new ProcessOperator();
            process.MessageInfo = "正在执行中。。。。。。";
            process.BackgroundWork = this.Do;
            process.BackgroundWorkerCompleted += new EventHandler<BackgroundWorkerEventArgs>(process_BackgroundWorkerCompleted);
            process.Start();
        }

        void process_BackgroundWorkerCompleted(object sender, BackgroundWorkerEventArgs e)
        {
            if (e.BackGroundException == null)
            {
                MessageBox.Show("执行完毕");
            }
            else
            {
                MessageBox.Show("异常:" + e.BackGroundException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PercentProcessOperator process = new PercentProcessOperator();
            process.BackgroundWork = this.DoWithProcess;
            process.MessageInfo = "正在执行中";
            process.BackgroundWorkerCompleted+=new EventHandler<BackgroundWorkerEventArgs>(process_BackgroundWorkerCompleted);
            process.Start();
        }

        void Do()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        void DoWithProcess(Action<int> percent)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                percent(i);
            }
        }
    }
}
