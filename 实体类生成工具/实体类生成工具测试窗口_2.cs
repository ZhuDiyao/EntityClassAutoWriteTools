using SQL语句转内存表;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 字符串操作;
using 实体类;
using 实体类转Csharp;
using 实体转JAVA;
using 工具;
using 示例字符串;
using 窗体控件自动生成工具;
using 项目名称和版本控制;

namespace 实体类生成工具
{
    public partial class 实体类生成工具测试窗口_2 : Form
    {
        public 实体类生成工具测试窗口_2()
        {
            InitializeComponent();
        }

        private void 实体类生成工具测试窗口_2_Load(object sender, EventArgs e)
        {
            Text = 项目信息.项目名称 + 项目信息.项目版本;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = MySQL标准建表语句.str;
            //dataGridView1.DataSource = SQL语句转内存表类.转换(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = SQLServer标准建表语句.str;
            //dataGridView1.DataSource = SQL语句转内存表类.转换(textBox1.Text);
        }
        /// <summary>
        /// 字符串加减
        /// </summary>
        /// <param name="snum"></param>
        /// <param name="i"></param>
        string Tb_number(string snum, int i)
        {
            int n = 0;
            try
            {
                n = int.Parse(snum) + i;
            }
            catch
            {

            }
            return n + "";
        }
        void Tb(TextBox tb, int i)
        {
            tb.Text= Tb_number(tb.Text, i);
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Tb(textBox2, -1);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Tb(textBox2, 1);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Tb(textBox3, -1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tb(textBox3, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tb(textBox4, -1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tb(textBox4, 1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tb(textBox5, -1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tb(textBox5, 1);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Tb(textBox6, -1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Tb(textBox6, 1);

        }

        表结构 根据页面情况获取表结构对象()
        {
            表结构 表结构1 = new 表结构();
            try
            {
                表结构1 = 内存表_转_表结构实体.转换(
                    textBox1.Text,
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text),
                    int.Parse(textBox5.Text),
                    int.Parse(textBox6.Text),
                    Connection_Name.Text,
                    namespace_Name.Text
                    );
                表结构1.连接对象SqlConnection = textBox8.Text;
                表结构1.连接对象SqlCommand = textBox9.Text;
                表结构1.连接对象SqlDataAdapter = textBox10.Text;

                textBox7.Text = 表结构1.ISeeYou();
            }
            catch
            {
                textBox7.Text = "";
                dataGridView1.DataSource = null;
                MessageBox.Show("参数错误");

            }
            return 表结构1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            根据页面情况获取表结构对象();
            //try
            //{
            //    表结构 表结构1 = new 表结构();

            //    表结构1 = 内存表_转_表结构实体.转换(
            //        textBox1.Text, 
            //        int.Parse(textBox2.Text), 
            //        int.Parse(textBox3.Text), 
            //        int.Parse(textBox4.Text), 
            //        int.Parse(textBox5.Text), 
            //        int.Parse(textBox6.Text),
            //        Connection_Name.Text,
            //        namespace_Name.Text
            //        );
            //    表结构1.连接对象SqlConnection = textBox8.Text;
            //    表结构1.连接对象SqlCommand = textBox9.Text;
            //    表结构1.连接对象SqlDataAdapter = textBox10.Text;

            //    textBox7.Text = 表结构1.ISeeYou();
            //}
            //catch
            //{
            //    textBox7.Text = "";
            //    dataGridView1.DataSource = null;
            //    MessageBox.Show("参数错误");

            //}
            
        }
        void FASTCONFIG(int i1, int i2, int i3, int i4, int i5)
        {
            textBox2.Text = i1 + "";
            textBox3.Text = i2 + "";
            textBox4.Text = i3 + "";
            textBox5.Text = i4 + "";
            textBox6.Text = i5 + "";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            FASTCONFIG(3, 0, 1, 4, 2);
            textBox8.Text = "SqlConnection";
            textBox9.Text = "SqlCommand";
            textBox10.Text = "SqlDataAdapter";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FASTCONFIG(2, 0, 1, 9, 3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQL语句转内存表类.转换(textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text =
                @"--注释表头测试
CREATE TABLE `OrderHeader` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '订单头id',
  `orderNumber` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单编号',
  `invalid` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单有效性',
  `time` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建时间',
  `commsID` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者唯一识别码',
  `commsUser` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者登陆账号',
  `commsName` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者姓名',
  `commsCom` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者公司',
  `commsDep` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者部门',
  `commsPos` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单创建者职位',
  `orderType` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单状态',
  `orderTotalPrice` varchar(255) COLLATE utf8_bin DEFAULT NULL COMMENT '订单总价',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FASTCONFIG(2, 0, 1, 7, 1);
            textBox8.Text = "MySqlConnection";
            textBox9.Text = "MySqlCommand";
            textBox10.Text = "MySqlDataAdapter";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                表结构 表结构1 = 根据页面情况获取表结构对象();

                //表结构1 = 内存表_转_表结构实体.转换(
                //    textBox1.Text,
                //    int.Parse(textBox2.Text),
                //    int.Parse(textBox3.Text),
                //    int.Parse(textBox4.Text),
                //    int.Parse(textBox5.Text),
                //    int.Parse(textBox6.Text),
                //    Connection_Name.Text,
                //    namespace_Name.Text
                //    );
                //表结构1.连接对象SqlConnection = textBox8.Text;
                //表结构1.连接对象SqlCommand = textBox9.Text;
                //表结构1.连接对象SqlDataAdapter = textBox10.Text;
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                //textBox7.Text = 表结构1.ISeeYou();
                if (comboBox2.Text.Equals("C#"))
                {
                    string EntityC = Csharp实体模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\" + 表结构1.ClassName + ".cs", EntityC);
                    string insertC = Csharp插入模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Insert" + 表结构1.ClassName + ".cs", insertC);
                    string updateC = Csharp修改模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Update" + 表结构1.ClassName + ".cs", updateC);
                    string selectC = Csharp查询模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Select" + 表结构1.ClassName + ".cs", selectC);
                }
                else if (comboBox2.Text.Equals("Java"))
                {
                    string strr = 实体类模板.Conversion(表结构1);
                    文件写出.Write4string( dir + @"\"+ 表结构1.ClassName+ ".java",strr);
                    string insertStr = 插入模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Insert" + 表结构1.ClassName + ".java", insertStr);
                    string updateStr = 修改模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Update" + 表结构1.ClassName + ".java", updateStr);
                    string selectStr = 查询模板.Conversion(表结构1);
                    文件写出.Write4string(dir + @"\Select" + 表结构1.ClassName + ".java", selectStr);
                }

            }
            catch
            {
                textBox7.Text = "";
                dataGridView1.DataSource = null;
                MessageBox.Show("参数错误");

            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            表结构 表结构1 = 根据页面情况获取表结构对象();

            string str = "";
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    + "String "
                    + 表结构1.字段列表.Rows[i]["字段名"].ToString() + " = \"\";//创建字符串_代表"
                     + 表结构1.字段列表.Rows[i]["字段注释"].ToString()
                    + 表结构1.字段列表.Rows[i]["字段类型"].ToString()
                    +"\r\n";
            }
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    +"try{"
                    + 表结构1.字段列表.Rows[i]["字段名"].ToString() + " = req.getParameter(\""
                    + 表结构1.字段列表.Rows[i]["字段名"].ToString() + "\");}catch (Exception e){}//"
                    + 表结构1.字段列表.Rows[i]["字段注释"].ToString()
                    + 表结构1.字段列表.Rows[i]["字段类型"].ToString()+ "\r\n";
            }

            str = str + 表结构1.ClassName + " autoEntity = new " + 表结构1.ClassName + "();\r\n";
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    + "autoEntity.set" + 首字母大小写转换.LitterToUpper(表结构1.字段列表.Rows[i]["字段名"].ToString())
                    +"("+ 表结构1.字段列表.Rows[i]["字段名"].ToString() + ");//保存到实体_"
                    + 表结构1.字段列表.Rows[i]["字段注释"].ToString()
                    + 表结构1.字段列表.Rows[i]["字段类型"].ToString() + "\r\n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            表结构 表结构1 = 根据页面情况获取表结构对象();
            string str = "";
            str = str + @"<table border = ""1"" style = "" border:1px solid #0094ff;width: 100%"" >";

            str = str + "<tr>\r\n";
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    + "<td>" + 表结构1.字段列表.Rows[i]["字段注释"].ToString() + "</td>\r\n";
                //+""
                //+ "try{"
                //+ 表结构1.字段列表.Rows[i]["字段名"].ToString() + " = req.getParameter(\""
                //+ 表结构1.字段列表.Rows[i]["字段名"].ToString() + "\");}catch (Exception e){}//"
                //+ 表结构1.字段列表.Rows[i]["字段注释"].ToString()
                //+ 表结构1.字段列表.Rows[i]["字段类型"].ToString() + "\r\n";
            }
            str = str + "</tr>\r\n";

            str = str + "<c:forEach items=" + "\"" + "${arrayList}" + "\" var=\"usr\" varStatus=\"idx\">" + "\r\n<tr>\r\n";
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    + "<td>${usr."+ 表结构1.字段列表.Rows[i]["字段名"] + "}"+ "</td>\r\n";

            }
            str = str + "</tr>\r\n</c:forEach>\r\n";
            str = str + "</table>";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            表结构 表结构1 = 根据页面情况获取表结构对象();
            string str = "        #region 自动映射数组相关代码_由实体类自动生成工具生成_"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\r\n";

            str = str + @"        static string[,] AutoArr = {"+"\r\n";


            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str
                    + "\t\t\t" 
                    + "{" +

                    "\"" + 表结构1.字段列表.Rows[i]["字段名"].ToString() + "\""
                    + ","

                    + SetNbsp(60 - 表结构1.字段列表.Rows[i]["字段名"].ToString().Length)

                    + "\"" + "100" + "\""

                    + ","

                    + SetNbsp(8 - "100".ToString().Length)

                    + "\"" + "true" + "\""
                    + ","

                    + SetNbsp(6- "true".ToString().Length) 

                    + "\"" + 表结构1.字段列表.Rows[i]["字段类型"].ToString() + "\"" 
                    
                    + ","

                    + SetNbsp(15 - 表结构1.字段列表.Rows[i]["字段类型"].ToString().Length)

                    + "\"" + 表结构1.字段列表.Rows[i]["字段注释"].ToString() + "\""

                    + "},\r\n";
            }

            str = str + "};\r\n";
            str = str +
                @"        

            /// <summary>
            /// 按数组中的列顺序，进行重新排序
            /// </summary>
            /// <param name=""dataTable""></param>
            /// <param name=""AutoArr""></param>
            /// <returns></returns>
            DataTable Seq(DataTable dataTable, string[,] AutoArr)
            {
                DataTable ReturnDTB = new DataTable();
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    ReturnDTB.Columns.Add(AutoArr[i, 0]);
                }

                for (int rows = 0; rows < dataTable.Rows.Count; rows++)
                {
                    DataRow dataRow = ReturnDTB.NewRow();
                    for (int i = 0; i < AutoArr.Length / 5; i++)
                    {
                        dataRow[AutoArr[i, 0]] = dataTable.Rows[rows][AutoArr[i, 0]].ToString();
                    }
                    ReturnDTB.Rows.Add(dataRow);
                }

                return ReturnDTB;
            }



            /// <summary>
            /// 映射列名称，将英文列名称映射为中文列名称
            /// </summary>
            /// <param name=""dataTable"" ></param>
            /// <param name=""AutoArr"" ></param>
            void Mapping(DataTable dataTable, string[,] AutoArr)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    dataTable.Columns[i].ColumnName
                        =
                    JXDataTableUtil.DataTableColumnsMapping(dataTable.Columns[i].ColumnName, 0, AutoArr, 5, 4);
                }
            }
            /// <summary>
            /// 根据中文列名称映射列宽度
            /// </summary>
            /// <param name=""dgv"" ></param>
            /// <param name=""AutoArr"" ></param>
            void SetColumns(DataGridView dgv, string[,] AutoArr)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    string GetWidth = JXDataTableUtil.DataTableColumnsMapping(dgv.Columns[i].Name, 4, AutoArr, 5, 1);
                    dgv.Columns[i].Width = int.Parse(GetWidth);
                }
            }
            /// <summary>
            /// 根据中文列名称映射列是否显示
            /// </summary>
            /// <param name=""dgv"" ></param>
            /// <param name=""AutoArr"" ></param>
            void SettingShowColumns(DataGridView dgv, string[,] AutoArr)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    string GetVisableCode = JXDataTableUtil.DataTableColumnsMapping(dgv.Columns[i].Name, 4, AutoArr, 5, 2);
                    if (GetVisableCode.Equals(""true""))
                    {
                        dgv.Columns[i].Visible = true;
                    }
                    else
                    {
                        dgv.Columns[i].Visible = false;
                    }
                }
            }
            //将以下代码添加到窗体加载事件
            /**
        /// <summary>
        /// 将内存表显示到界面上
        /// </summary>
        void DataTablePrintWinFrom()
        {
            Mapping(ShowToWinFrom, AutoArr);
            dataGridView1.DataSource = ShowToWinFrom;
            SetColumns(dataGridView1, AutoArr);
            SettingShowColumns(dataGridView1, AutoArr);
            JXStyle.SetGridAlternatingRows(dataGridView1);
            JXStyle.FullRowSelectMode(dataGridView1);
            JXStyle.SetReadOnly(dataGridView1);
        }
            * **/
        /// <summary>
        /// 将内存表显示到界面上
        /// </summary>
        void DataTablePrintWinFrom()
        {
            ShowToWinFrom = Seq(ShowToWinFrom,AutoArr);
            Mapping(ShowToWinFrom, AutoArr);
            dataGridView1.DataSource = ShowToWinFrom;
            SetColumns(dataGridView1, AutoArr);
            SettingShowColumns(dataGridView1, AutoArr);
            JXStyle.SetDataGridViewStandardStyle(dataGridView1);
        }

        /// <summary>
        /// 展示到界面上专用的内存表
        /// </summary>
        DataTable ShowToWinFrom = null;

        #endregion
            ";

            Clipboard.SetDataObject(str, true);
        }
        /// <summary>
        /// 传入数字，返回对应长度的空格字符串
        /// </summary>
        /// <param name="Number"></param>
        static string SetNbsp(int Number)
        {
            string str = "";
            for (int i = 0; i < Number; i++)
            {
                str = str + " ";
            }
            return str;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            表结构 表结构1 = 根据页面情况获取表结构对象();
            string str = "";
            str = str + @"<table border = ""1"" style = "" border:1px solid #0094ff;width: 100%"" >";

            
            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str + "<tr>\r\n";
                str = str + "<td>" + 表结构1.字段列表.Rows[i]["字段注释"].ToString() + "</td>\r\n";
                str = str + "<td>${usr." + 表结构1.字段列表.Rows[i]["字段名"].ToString() + "}</td>\r\n";
                str = str + "</tr>\r\n";
            }
           

            
            str = str + "</table>";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            窗体全自动 ctauto = new 窗体全自动(根据页面情况获取表结构对象());
            ctauto.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string str= 字符串操作.头文件
               .HeadTXT();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            表结构 表结构1 = 根据页面情况获取表结构对象();
            string str = "";
            //bOM_List.id = 表格.Rows[i][""].ToString();
            str = str + @"";


            for (int i = 0; i < 表结构1.字段列表.Rows.Count; i++)
            {
                str = str + "bOM_List."+ 表结构1.字段列表.Rows[i]["字段名"].ToString() + " = 表格.Rows[i][\""+表结构1.字段列表.Rows[i]["字段名"].ToString()+"\"].ToString();//"+ 表结构1.字段列表.Rows[i]["字段注释"].ToString() + "\r\n";
            }

            str = str + "";
        }
    }
}
