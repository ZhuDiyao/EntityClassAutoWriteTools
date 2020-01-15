using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 工具;

namespace 窗体控件自动生成工具模型
{
    public class New控件模型_标签
    {
        public static string 创建(string 对象名称)
        {
            return 符号类.制表符号(3) + "this.lab_"+ 对象名称+ " = new System.Windows.Forms.Label();" + 符号类.换行符号(1);
        }
    }
}
