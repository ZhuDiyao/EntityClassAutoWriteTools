using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 窗体控件自动生成工具模型
{
    public class 整体模型_cs
    {
        public static string 创建(string 命名空间, string 类名称)
        {
            string 返回值 = "";
            返回值 =
                @"using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace "+ 命名空间 + @"
{
    public partial class "+ 类名称 + @" : Form
    {
        public 自动创建窗口()
        {
            InitializeComponent();
        }
//【【【【【【【【【【【在此处插入方法】】】】】】】】】】】

    }
}
";
            返回值 = 字符串操作.头文件.HeadTXT() + 返回值;
            return 返回值;
        }
    }
}
