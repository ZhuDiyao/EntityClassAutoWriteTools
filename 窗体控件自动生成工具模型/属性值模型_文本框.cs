using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 工具;

namespace 窗体控件自动生成工具模型
{
    public class 属性值模型_文本框
    {
        public static string 创建(string 文本框名称, string 文本显示值, int point_x, int point_y,int 制表符顺序)
        {
            文本框名称 = "txt_" + 文本框名称;
            string 结果字符 = "";
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 文本框名称 + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".Font = new System.Drawing.Font(" + 符号类.双引符号(1) + "宋体" + 符号类.双引符号(1) + ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".Location = new System.Drawing.Point("+ point_x + ", "+ point_y + ");" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".Name = " + 符号类.双引符号(1) + "" + 文本框名称 + "" + 符号类.双引符号(1) + "; " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".Size = new System.Drawing.Size(220, 23);" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".TabIndex = " + 制表符顺序 + ";" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 文本框名称 + ".Text = " + 符号类.双引符号(1) + 文本显示值 + 符号类.双引符号(1) + "; " + 符号类.换行符号(1);
            return 结果字符;
        }
    }
}
