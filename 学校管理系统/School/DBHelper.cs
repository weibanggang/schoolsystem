using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public class DBHelper
    {
        #region#连接数据库
        static string sql = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        static SqlConnection con = new SqlConnection(sql);
        /// <summary>
        /// 打开连接
        /// </summary>
        public static void Open()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void Close()
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
        }
        #endregion
        /// <summary>
        ///隐藏窗口
        /// </summary>
        /// <param name="form"></param>
        public static void Hide(Form form) {
            new Login().Show();
            form.Parent.Parent.Hide();
        }
        /// <summary>
        /// 添加DataSet 缓存方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string str)//添加DataSet 缓存方法
        {
            DataSet ds = new DataSet();// 将DataSet方法new出来
            SqlDataAdapter da = new SqlDataAdapter(str, con);//创建新的实例SqlDataAdapter 将查询语句放入，连接数据库配置
            da.Fill(ds);//在DataSet中刷新或添加
            return ds;//返回
        }
        /// <summary>
        /// 添加SqlDataReader方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            Open();//连接数据库
            SqlDataReader dada = com.ExecuteReader(CommandBehavior.CloseConnection);//使用关闭流模式对象

            return dada;//返回读取数据

        }
        /// <summary>
        /// //添加SqlDataReader方法带数组
        /// </summary>
        /// <param name="str"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str, params SqlParameter[] p)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            com.Parameters.AddRange(p);
            Open();//连接数据库

            SqlDataReader dada = com.ExecuteReader(CommandBehavior.CloseConnection);//使用关闭流模式对象
            return dada;//返回读取数据
        }
        /// <summary>
        /// 添加SqlDataReader方法
        /// </summary>
        /// <param name="str"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string str, SqlParameter[] p)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            com.Parameters.AddRange(p);
            Open();//连接数据库
            int f = com.ExecuteNonQuery();//使用关闭流模式对象
            Close();
            return f;//返回读取数据
        }
        /// <summary>
        /// 返回是否添加
        /// </summary>
        /// <param name="str">数据库添加字符串</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string str)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            Open();//连接数据库
            int f = com.ExecuteNonQuery();//使用关闭流模式对象
            Close();
            return f;//返回读取数据
        }
        /// <summary>
        /// 用于返回第一行第一列带数组
        /// </summary>
        /// <param name="str"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string str, params SqlParameter[] p)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            com.Parameters.AddRange(p);
            Open();//连接数据库
            object f = com.ExecuteScalar();
            Close();
            return f;//返回读取数据
        }
        /// <summary>
        /// 判断身份是否正确
        /// </summary>
        /// <param name="sid">年月日</param>
        /// <returns></returns>
        public static int Sid(string sid)
        {
            //把年月日录入数据库
            string sd = string.Format("select isdate('{0}') 返回", sid);
            //调用方法返回 如果等于0输入不正确
            int sr = (int)DBHelper.ExecuteScalar(sd);
            //返回
            return sr;
        }
        /// <summary>
        /// 获取年龄
        /// </summary>
        /// <param name="sid">出生日期</param>
        /// <returns></returns>
      public static int Age(string sid)
        {
            //把年月日录入数据库
            //DATEPART(YY,GETDATE())-DATEPART(YY,'{0}')用于当前时间前去出生日期
            string sd = string.Format("select DATEPART(YY,GETDATE())-DATEPART(YY,'{0}')", sid);
            //调用方法返回 当前年龄
            int sr = (int)DBHelper.ExecuteScalar(sd);
            return sr;
        }
        /// <summary>
        /// 用于返回第一行第一列
        /// </summary>
        /// <param name="str">数据库的查询字符中</param>
        /// <returns></returns>
        public static object ExecuteScalar(string str)//添加SqlDataReader方法
        {
            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            Open();//连接数据库
            object f = com.ExecuteScalar();
            Close();
            return f;//返回读取数据
        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="value">密码值</param>
        /// <returns></returns>
        public static string Md5(string value)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] data = Encoding.UTF8.GetBytes(value);
            data = md5.ComputeHash(data);
            return BitConverter.ToString(data);
        }
        /// <summary>
        /// 打开图片
        /// </summary>
        /// <returns></returns>
        public static byte[] byPictureBox(PictureBox s)
        {
            byte[] imageBytes = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP|*.PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
              
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
               imageBytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流
                MemoryStream ms = new MemoryStream(imageBytes);
                s.Image = Image.FromStream(ms);
                s.Visible = true;
                ms.Close();
                br.Close();
              
            }
            return imageBytes;

        }
      
        /// <summary>
        ///  读取图片
        /// </summary>
        public static Bitmap Read(string str)
        {

            SqlCommand com = new SqlCommand(str, con);//创建新实例SqlCommand
            Open();//连接数据库
            SqlDataReader sqlDr = com.ExecuteReader();
            sqlDr.Read();
             byte[] images = (byte[])sqlDr["IMGF"];
            MemoryStream ms = new MemoryStream(images);
            Bitmap bmp = new Bitmap(ms);
            sqlDr.Close();
            return bmp;

        }
        public class CollegeType
        {
            public int ID { get; set; }//编号
            public string TypeName { get; set; }
        }
        /// <summary>
        /// 管理员反馈
        /// </summary>
        /// <param name="zhiti"></param>
        /// <param name="neir"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int fangui(string zhiti,string neir,string id) {
            string sele = "select * from AdminInfo where Uid='" + id + "'";
            SqlDataReader dr = DBHelper.ExecuteReader(sele);
            string Name = null;
            while (dr.Read()) {
                Name = dr["Name"].ToString();
            }
            dr.Close();

            string dly = "insert into fangui Values(@times,@zhiti,@Name,@neir)";
            SqlParameter[] dlyp = {
                        new SqlParameter("@times",DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")),
                        new SqlParameter("@zhiti",zhiti),
                        new SqlParameter("@Name",Name),
                        new SqlParameter("@neir",neir)
                    };
              return   DBHelper.ExecuteNonQuery(dly, dlyp);
        }
        #region#Excel导入导出
        /// <summary>
        /// Excel导出
        /// </summary>
        /// <param name="myDGV"></param>
        #region 导出
        public static void ExportExcel(DataGridView myDGV)
        {
            if (myDGV.Rows.Count > 0)
            {

                string saveFileName = "";
                //bool fileSaved = false;  
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xlsx";
                // saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消   
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1  

                //写入标题  
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
                }
                //写入数值  
                for (int r = 0; r < myDGV.Rows.Count; r++)
                {
                    for (int i = 0; i < myDGV.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应  
                                                         //   if (Microsoft.Office.Interop.cmbxType.Text != "Notification")  
                                                         //   {  
                                                         //       Excel.Range rg = worksheet.get_Range(worksheet.Cells[2, 2], worksheet.Cells[ds.Tables[0].Rows.Count + 1, 2]);  
                                                         //      rg.NumberFormat = "00000000";  
                                                         //   }  

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                        //fileSaved = true;  
                    }
                    catch (Exception ex)
                    {
                        //fileSaved = false;  
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }

                }
                //else  
                //{  
                //    fileSaved = false;  
                //}  
                xlApp.Quit();
                GC.Collect();//强行销毁   
                             // if (fileSaved && System.IO.File.Exists(saveFileName)) System.Diagnostics.Process.Start(saveFileName); //打开EXCEL  
                MessageBox.Show("导出文件成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("报表为空,无表格需要导出", "提示", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region 导入
        /// <summary>
        /// Excel导入
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static  System.Data.DataTable ImportExcel(string path)
        {
            DataSet ds = new DataSet();

            string strConn = "";
            strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", path);
            using (var oledbConn = new OleDbConnection(strConn))
            {
                oledbConn.Open();
                var sheetName = oledbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new[] { null, null, null, "Table" });
                var sheet = new string[sheetName.Rows.Count];
                for (int i = 0, j = sheetName.Rows.Count; i < j; i++)
                {
                    sheet[i] = sheetName.Rows[i]["TABLE_NAME"].ToString();
                }
                var adapter = new OleDbDataAdapter(string.Format("select * from [{0}]", sheet[0]), oledbConn);
                adapter.Fill(ds);
            }
            return ds.Tables[0];
        }
        public static   DataTable daoru(DataGridView myDGV)
        {
            DataTable dt = null;
            string filePath = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "excel文件|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                filePath = openFileDialog1.FileName;
                dt = ImportExcel(filePath);
            }
            return dt;
        }
        public static DataTable daorusw(string filePath) {
            DataTable dt = null;
            dt = ImportExcel(filePath);
            return dt;
        }
        #endregion
        #endregion
    }

}





