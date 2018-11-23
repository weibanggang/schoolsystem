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
    public partial class suseneiwbaobxx : UserControl
    {
        string nf = null;
        string yf = null;
        string DormitoryNO = null;
        string did = null;
        public suseneiwbaobxx(string nf, string yf,string DormitoryNO,string Did)
        {
            InitializeComponent();
            this.nf = nf;
            this.yf = yf;
            this.DormitoryNO = DormitoryNO;
            this.did = Did;
        }
        List<string> louname = new List<string>();
        List<string> louzhu = new List<string>();
        List<int> ysw = new List<int>();
        List<int> ks = new List<int>();
        private void suseneiwbaobxx_Load(object sender, EventArgs e)
        {
                string db = " select Did,Point,KPiont,DateName(day,times) from Neiwu n "+
             "join Dormitory D on n.Did = d.Name where convert(varchar(4),times,120)= "+ nf + " and convert(varchar(2),times,110)= " + yf + " and Did ='"+did+"' and DormitoryNO =" + DormitoryNO + " order by times";
                SqlDataReader dr = DBHelper.ExecuteReader(db);
                while (dr.Read())
                {
                    louzhu.Add(dr["Did"].ToString());//ID
                    louname.Add(dr[3].ToString()+"日");//名称
                    ks.Add(int.Parse(dr["Point"].ToString()));
                    ysw.Add(int.Parse(dr["KPiont"].ToString()));
                }
                dr.Close();
            
            int ys = 0;
            for (int i = 0; i < ks.Count; i++)
            {
                ys += ks[i];
            }
            if (louname.Count == 0)
            {
                louzhu.Add("1");//ID
                louname.Add("本月无数据");//名称
                ks.Add(1);
                ysw.Add(1);
            }
            #region 总分
            //标题
            chart1.Titles.Add("所有楼层内务总分表分析");
            chart1.Titles[0].ForeColor = Color.Black;
            chart1.Titles[0].Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            chart1.Titles[0].Alignment = ContentAlignment.MiddleCenter;

            //控件背景
            chart1.BackColor = Color.Transparent;
            //图表区背景
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.ChartAreas[0].BorderColor = Color.Transparent;
            //X轴标签间距

            //cht2.ChartAreas[0].AxisX.Title ="";
            chart1.ChartAreas[0].AxisY2.LineColor = Color.Transparent;

            //背景渐变
            chart1.ChartAreas[0].BackGradientStyle = GradientStyle.None;

            //图例样式
            Legend legend2 = new Legend("#VALX");
            legend2.Title = "图例";
            legend2.TitleBackColor = Color.Transparent;
            legend2.BackColor = Color.Transparent;
            legend2.TitleForeColor = Color.Black;
            legend2.TitleFont = new Font("微软雅黑", 7f, FontStyle.Regular);
            legend2.Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            legend2.ForeColor = Color.Black;

            chart1.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            chart1.Series[0].Label = "#VAL";                //设置显示X Y的值    
            chart1.Series[0].LabelForeColor = Color.Black;
            chart1.Series[0].ToolTip = "#VALX楼-总分:#VAL";     //鼠标移动到对应点显示数值
            chart1.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)
            //chart1.Series[0].ChartType = SeriesChartType.Stock;
            chart1.Series[0].Color = Color.Lime;
            chart1.Series[0].LegendText = legend2.Name;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelForeColor = Color.Black;
            chart1.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            chart1.Series[0].CustomProperties = "PieLabelStyle = Outside";
            chart1.Legends.Add(legend2);
            chart1.Legends[0].Position.Auto = true;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].MarkerBorderWidth = 1000;
            //是否显示图例
            chart1.Series[0].IsVisibleInLegend = true;
            chart1.Series[0].ShadowOffset = 0;
            //饼图折线
            chart1.Series[0]["PieLineColor"] = "Black";
            //绑定数据
            chart1.Series[0].Points.DataBindXY(louname, ks);
            //  cht2.Series[0].Points[0].Color = Color.White;
            //绑定颜色
            chart1.Series[0].Palette = ChartColorPalette.BrightPastel;

            #endregion
            #region 水费饼图

            //标题
            chart2.Titles.Add("所有楼层内务扣分表分析");
            chart2.Titles[0].ForeColor = Color.Black;
            chart2.Titles[0].Font = new Font("微软雅黑", 12f, FontStyle.Regular);
            chart2.Titles[0].Alignment = ContentAlignment.MiddleCenter;

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
            Legend legend3 = new Legend("#VALX");
            legend3.Title = "图例";
            legend3.TitleBackColor = Color.Transparent;
            legend3.BackColor = Color.Transparent;
            legend3.TitleForeColor = Color.Black;
            legend3.TitleFont = new Font("微软雅黑", 7f, FontStyle.Regular);
            legend3.Font = new Font("微软雅黑", 8f, FontStyle.Regular);
            legend3.ForeColor = Color.Black;

            chart2.Series[0].XValueType = ChartValueType.String;  //设置X轴上的值类型
            chart2.Series[0].Label = "#VAL";                //设置显示X Y的值    
            chart2.Series[0].LabelForeColor = Color.Black;
            chart2.Series[0].ToolTip = "#VALX楼-扣分:#VAL";     //鼠标移动到对应点显示数值
            chart2.Series[0].ChartType = SeriesChartType.Line;    //图类型(折线)

            chart2.Series[0].Color = Color.Lime;
            chart2.Series[0].LegendText = legend2.Name;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].LabelForeColor = Color.Black;
            chart2.Series[0].CustomProperties = "DrawingStyle = Cylinder";
            chart2.Series[0].CustomProperties = "PieLabelStyle = Outside";
            chart2.Legends.Add(legend2);
            chart2.Legends[0].Position.Auto = true;
            chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].MarkerBorderWidth = 100;
            //是否显示图例
            chart2.Series[0].IsVisibleInLegend = true;
            chart2.Series[0].ShadowOffset = 0;
            //饼图折线
            chart2.Series[0]["PieLineColor"] = "Black";
            //绑定数据
            chart2.Series[0].Points.DataBindXY(louname, ysw);
            //  cht2.Series[0].Points[0].Color = Color.White;
            //绑定颜色
            chart2.Series[0].Palette = ChartColorPalette.BrightPastel;

            #endregion
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

