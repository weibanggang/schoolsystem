using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace School
{
    public partial class xueshengxinxibaobiao : UserControl
    {
        public xueshengxinxibaobiao(int y, int k)
        {
            InitializeComponent();
            this.y = y;
            this.k = k;
        }
        int y = 0;
        int k = 0;
       
        string o = "";
        List<string> louname = new List<string>();
        List<int> louzhu = new List<int>();
        List<int> ysw = new List<int>();
        List<int> ks = new List<int>();
        private void xueshengxinxibaobiao_Load(object sender, EventArgs e)
        {
          
            int ys = 0;
            louzhu.Add(y);
            louzhu.Add(k);
            louname.Add("男");
            louname.Add("女");
            for (int i = 0; i < louzhu.Count; i++)
            {
                ys += louzhu[i];
            }
            #region 水费饼图

            //标题
            chart2.Titles.Add(o+ "人数数据分析");
            chart2.Titles[0].ForeColor = Color.Black;
            chart2.Titles[0].Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            chart2.Titles[0].Alignment = ContentAlignment.TopCenter;
            chart2.Titles.Add("合计：" + ys + " 人");
            chart2.Titles[1].ForeColor = Color.Black;
            chart2.Titles[1].Font = new Font("微软雅黑", 9f, FontStyle.Regular);
            chart2.Titles[1].Alignment = ContentAlignment.TopRight;

            //控件背景
            chart2.BackColor = Color.Transparent;
            //图表区背景
            chart2.ChartAreas[0].BackColor = Color.Transparent;
            chart2.ChartAreas[0].BorderColor = Color.Transparent;
            //X轴标签间距

            //cht2.ChartAreas[0].AxisX.Title ="";
            chart2.ChartAreas[0].AxisY2.LineColor = Color.Transparent;

            //背景渐变
            chart2.ChartAreas[0].BackGradientStyle = GradientStyle.None;

            //图例样式
            Legend legend2 = new Legend("#VALX");
            legend2.Title = "图例";
            legend2.TitleBackColor = Color.Transparent;
            legend2.BackColor = Color.Transparent;
            legend2.TitleForeColor = Color.Black;
            legend2.TitleFont = new Font("微软雅黑", 7f, FontStyle.Regular);
            legend2.Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            legend2.ForeColor = Color.Black;

            chart2.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            chart2.Series[0].Label = "#VAL";                //设置显示X Y的值    
            chart2.Series[0].LabelForeColor = Color.Black;
            chart2.Series[0].ToolTip = "#VALX:#VAL(人)";     //鼠标移动到对应点显示数值
            chart2.Series[0].ChartType = SeriesChartType.Pie;    //图类型(折线)

            chart2.Series[0].Color = Color.Lime;
            chart2.Series[0].LegendText = legend2.Name;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].LabelForeColor = Color.Black;
            chart2.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            chart2.Series[0].CustomProperties = "PieLabelStyle = Outside";
            chart2.Legends.Add(legend2);
            chart2.Legends[0].Position.Auto = true;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].MarkerBorderWidth = 1000;
            //是否显示图例
            chart2.Series[0].IsVisibleInLegend = true;
            chart2.Series[0].ShadowOffset = 0;
            //饼图折线
            chart2.Series[0]["PieLineColor"] = "Black";
            //绑定数据
            chart2.Series[0].Points.DataBindXY(louname, louzhu);
            //  cht2.Series[0].Points[0].Color = Color.White;
            //绑定颜色
            chart2.Series[0].Palette = ChartColorPalette.BrightPastel;

            #endregion
        }
    }
}
