using SQL字符串截取;
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
using 实体类;
using 封装CSHARP字符串;
using 封装JAVA字符串;
using 生成CSHARP字符串;
using 示例字符串;
using 项目名称和版本控制;

namespace 实体类生成工具
{
    public partial class 实体类生成工具测试窗口 : Form
    {
        需要返回的字符串实体 需要返回的字符串实体 = new 需要返回的字符串实体();
        表结构 表结构 = new 表结构();
        public 实体类生成工具测试窗口()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = MySQL标准建表语句.str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = SQLServer标准建表语句.str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals(""))
            {
                MessageBox.Show("请选择数据库类型或编程语言种类！");
                
            }
            else
            {
                string sql = textBox1.Text;
                sql = sql.Replace("\n", "\r\n");
                sql = sql.Replace("\t", "");
                string sqlType = comboBox1.Text;
                string tpye = comboBox2.Text;

                需要返回的字符串实体 = Create(sql, sqlType, tpye);

                string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                //MessageBox.Show(dir);

                Write4string(dir + "\\" + sqlType + "_" + tpye + "_实体类.txt", 需要返回的字符串实体.实体类);
                Write4string(dir + "\\" + sqlType + "_" + tpye + "_数据库插入.txt", 需要返回的字符串实体.数据库插入);
                Write4string(dir + "\\" + sqlType + "_" + tpye + "_数据库修改.txt", 需要返回的字符串实体.数据库修改);
                Write4string(dir + "\\" + sqlType + "_" + tpye + "_数据库查询.txt", 需要返回的字符串实体.数据库查询);
            }

        }
        /// <summary>
        /// 传入字符串
        /// </summary>
        public static void Write4string(string FilePath, string str)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            //获得字节数组
            byte[] data = Encoding.UTF8.GetBytes(str);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        public 需要返回的字符串实体 Create(string sql,string sqlType,string tyle)
        {
            if (sqlType.Equals("MySQL"))
            {
                表结构 = MySQL字符串截取.Interception(sql);
                if (tyle.Equals("Java"))
                {
                    需要返回的字符串实体.实体类 = 封装JAVAEntity.Combined(表结构);
                    需要返回的字符串实体.数据库插入 = 封装JAVA插入.Combined(表结构);
                    需要返回的字符串实体.数据库修改 = 封装JAVA查询.Combined(表结构);
                    需要返回的字符串实体.数据库查询 = 封装JAVA修改.Combined(表结构);
                }
                else if (tyle.Equals("C#"))
                {
                    需要返回的字符串实体.实体类 = 封装CSHARPEntity.Combined(表结构);
                    需要返回的字符串实体.数据库插入 = 封装CSHARP插入.Combined(表结构);
                    需要返回的字符串实体.数据库修改 = 封装CSHARP修改.Combined(表结构);
                    需要返回的字符串实体.数据库查询 = 封装CSHARP查询.Combined(表结构);
                }
            }
            else if (sqlType.Equals("SQLServer"))
            {
                表结构 = SQLServer字符串截取.Interception(sql);
                if (tyle.Equals("Java"))
                {
                    需要返回的字符串实体.实体类 = 封装JAVAEntity.Combined(表结构);
                    需要返回的字符串实体.数据库插入 = 封装JAVA插入.Combined(表结构);
                    需要返回的字符串实体.数据库修改 = 封装JAVA查询.Combined(表结构);
                    需要返回的字符串实体.数据库查询 = 封装JAVA修改.Combined(表结构);
                }
                else if (tyle.Equals("C#"))
                {
                    需要返回的字符串实体.实体类 = 封装CSHARPEntity.Combined(表结构);
                    需要返回的字符串实体.数据库插入 = 封装CSHARP插入.Combined(表结构);
                    需要返回的字符串实体.数据库修改 = 封装CSHARP修改.Combined(表结构);
                    需要返回的字符串实体.数据库查询 = 封装CSHARP查询.Combined(表结构);
                }
            }
            return 需要返回的字符串实体;
        }

        private void 实体类生成工具测试窗口_Load(object sender, EventArgs e)
        {
            Text = 项目信息.项目名称 + 项目信息.项目版本;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 
            SQL语句转内存表类.转换(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //内存表_转_表结构实体.转换(textBox1.Text,3,0,1,4,3);
        }


    }
}
