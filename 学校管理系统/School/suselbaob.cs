using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Configuration;

namespace School
{
    public partial class suselbaob : UserControl
    {
        public suselbaob(string y,string k,string o)
        {
            InitializeComponent();
            this.y = int.Parse(y);
            this.k = int.Parse(k);
            this.o = o;
        }
        int y = 0;
        int k = 0;
        string o = "";
        List<string> louname = new List<string>();
        List<int> louzhu = new List<int>();
        private void suselbaob_Load(object sender, EventArgs e)
        {
            groupBox1.Text = o;
            int ys = 0;
            louzhu.Add(y);
            louzhu.Add(k);
            louname.Add("已住人数");
            louname.Add("可住人数");
            for (int i = 0; i < louzhu.Count; i++)
            {
                ys += louzhu[i];
            }
            #region 水费饼图

            //标题
            cht2.Titles.Add(o+ "人数数据分析");
            cht2.Titles[0].ForeColor = Color.Black;
            cht2.Titles[0].Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            cht2.Titles[0].Alignment = ContentAlignment.TopCenter;
            cht2.Titles.Add("合计：" + ys + " 人");
            cht2.Titles[1].ForeColor = Color.Black;
            cht2.Titles[1].Font = new Font("微软雅黑", 9f, FontStyle.Regular);
            cht2.Titles[1].Alignment = ContentAlignment.TopRight;

            //控件背景
            cht2.BackColor = Color.Transparent;
            //图表区背景
            cht2.ChartAreas[0].BackColor = Color.Transparent;
            cht2.ChartAreas[0].BorderColor = Color.Transparent;
            //X轴标签间距

            //cht2.ChartAreas[0].AxisX.Title ="";
            cht2.ChartAreas[0].AxisY2.LineColor = Color.Transparent;

            //背景渐变
            cht2.ChartAreas[0].BackGradientStyle = GradientStyle.None;

            //图例样式
            Legend legend2 = new Legend("#VALX");
            legend2.Title = "图例";
            legend2.TitleBackColor = Color.Transparent;
            legend2.BackColor = Color.Transparent;
            legend2.TitleForeColor = Color.Black;
            legend2.TitleFont = new Font("微软雅黑", 7f, FontStyle.Regular);
            legend2.Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            legend2.ForeColor = Color.Black;

            cht2.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            cht2.Series[0].Label = "#VAL";                //设置显示X Y的值    
            cht2.Series[0].LabelForeColor = Color.Black;
            cht2.Series[0].ToolTip = "#VALX:#VAL(人)";     //鼠标移动到对应点显示数值
            cht2.Series[0].ChartType = SeriesChartType.Pie;    //图类型(折线)

            cht2.Series[0].Color = Color.Lime;
            cht2.Series[0].LegendText = legend2.Name;
            cht2.Series[0].IsValueShownAsLabel = true;
            cht2.Series[0].LabelForeColor = Color.Black;
            cht2.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            cht2.Series[0].CustomProperties = "PieLabelStyle = Outside";
            cht2.Legends.Add(legend2);
            cht2.Legends[0].Position.Auto = true;
            cht2.Series[0].IsValueShownAsLabel = true;
            cht2.Series[0].MarkerBorderWidth = 1000;
            //是否显示图例
            cht2.Series[0].IsVisibleInLegend = true;
            cht2.Series[0].ShadowOffset = 0;
            //饼图折线
            cht2.Series[0]["PieLineColor"] = "Black";
            //绑定数据
            cht2.Series[0].Points.DataBindXY(louname, louzhu);
            //  cht2.Series[0].Points[0].Color = Color.White;
            //绑定颜色
            cht2.Series[0].Palette = ChartColorPalette.BrightPastel;

            #endregion
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
