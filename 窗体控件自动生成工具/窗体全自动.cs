using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 字符串操作;
using 实体类;
using 工具;
using 窗体控件自动生成工具模型;

namespace 窗体控件自动生成工具
{
    public partial class 窗体全自动 : Form
    {
        表结构 接收的表结构参数 = null;
        public 窗体全自动(表结构 表结构实体)
        {
            InitializeComponent();
            接收的表结构参数 = 表结构实体;
        }

        private void 窗体全自动_Load(object sender, EventArgs e)
        {
            //窗体必须先接收 表结构 类的参数
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
                    + "autoEntity.set" + 首字母大小写转换.LitterToUpper(表结构1.字段列表.Rows[i]["字段名"].ToString())
                    +"("+ 表结构1.字段列表.Rows[i]["字段名"].ToString() + ");//保存到实体_"
                    + 表结构1.字段列表.Rows[i]["字段注释"].ToString()
                    + 表结构1.字段列表.Rows[i]["字段类型"].ToString() + "\r\n"; 
             * **/

            接收的表结构参数.窗口类_命名空间 = textBox3.Text;
            接收的表结构参数.窗口类_类名称 = textBox2.Text;
            接收的表结构参数.窗口类_项目路径 = textBox1.Text;
            //写出 Designer.cs
            {
                string 最终结果 = 整体模型Designer_cs.创建(接收的表结构参数.窗口类_命名空间, 接收的表结构参数.窗口类_类名称);
                string new相关 = "";
                string 属性相关 = "";
                string 创建相关 = "";
                for (int i = 0; i < 接收的表结构参数.字段列表.Rows.Count; i++)
                {
                    new相关 = new相关 + New控件模型_标签.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString());
                    new相关 = new相关 + New控件模型_文本框.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString());
                    属性相关 = 属性相关 + 属性值模型_标签.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString(), 接收的表结构参数.字段列表.Rows[i]["字段注释"].ToString(), 0, 23 * i, i * 2);
                    属性相关 = 属性相关 + 属性值模型_文本框.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString(), 接收的表结构参数.字段列表.Rows[i]["字段注释"].ToString(), 200, 23 * i, i * 2 + 1);
                    创建相关 = 创建相关 + 创建控件对象模型_标签.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString());
                    创建相关 = 创建相关 + 创建控件对象模型_文本框.创建(接收的表结构参数.字段列表.Rows[i]["字段名"].ToString());
                }
                属性相关 = 属性相关 + 属性值模型_窗体.创建(接收的表结构参数.窗口类_类名称, 接收的表结构参数.ClassName, 接收的表结构参数, 23 * (接收的表结构参数.字段列表.Rows.Count + 2));
                最终结果 = 最终结果.Replace("【【【【【【【【【【【【【【【此处添加_new控件的相关代码】】】】】】】】】】】】】】】", new相关);
                最终结果 = 最终结果.Replace("【【【【【【【【【【【【【【【此处添加_设置控件属性相关代码】】】】】】】】】】】】】】】", 属性相关);
                最终结果 = 最终结果.Replace("【【【【【【【【【【【【【【【此处添加_创建控件对象的相关代码】】】】】】】】】】】】】】】", 创建相关);
                //最终结果 = 最终结果;
                文件写出.Write4string(接收的表结构参数.窗口类_项目路径 + "\\" + 接收的表结构参数.窗口类_类名称 + ".Designer.cs", 最终结果);
            }
            //写出 .cs
            {
                string 最终结果 = 整体模型_cs.创建(接收的表结构参数.窗口类_命名空间, 接收的表结构参数.窗口类_类名称);
                string 方法结果 = "";
                方法结果 = 方法结果 + 方法模型_实体类到界面.创建(接收的表结构参数);
                方法结果 = 方法结果 + 方法模型_界面到实体类.创建(接收的表结构参数);



                最终结果 = 最终结果.Replace("//【【【【【【【【【【【在此处插入方法】】】】】】】】】】】", 方法结果);
                文件写出.Write4string(接收的表结构参数.窗口类_项目路径 + "\\" + 接收的表结构参数.窗口类_类名称 + ".cs", 最终结果);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Y:\MicrosoftAbout\实体类生成工具\实体类生成工具\bin\Debug\JAVA模板.dll

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                int 最后一个斜杠的位置 = file.LastIndexOf("\\");
                textBox1.Text = file.Substring(0, 最后一个斜杠的位置);
                textBox2.Text = file.Replace(textBox1.Text,"").Replace(".cs","").Replace("\\","");

                string 处理过程 = textBox1.Text.Replace(textBox2.Text, "");
                处理过程 = 处理过程.Substring(处理过程.LastIndexOf("\\"), 处理过程.Length- 处理过程.LastIndexOf("\\"));
                textBox3.Text = 处理过程.Replace("\\","");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string file = textBox4.Text;
            int 最后一个斜杠的位置 = file.LastIndexOf("\\");
            textBox1.Text = file.Substring(0, 最后一个斜杠的位置);
            textBox2.Text = file.Replace(textBox1.Text, "").Replace(".cs", "").Replace("\\", "");

            string 处理过程 = textBox1.Text.Replace(textBox2.Text, "");
            处理过程 = 处理过程.Substring(处理过程.LastIndexOf("\\"), 处理过程.Length - 处理过程.LastIndexOf("\\"));
            textBox3.Text = 处理过程.Replace("\\", "");
        }
    }
}
