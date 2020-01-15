using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 工具;

namespace 窗体控件自动生成工具模型
{
    public class 属性值模型_标签
    {
        public static string 创建(string 标签名称,string 标签显示值,int point_x,int point_y,int 制表符顺序)
        {
            标签名称 = "lab_" + 标签名称;
            string 结果字符 = "";
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 标签名称 + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);

            结果字符 = 结果字符 + 符号类.制表符号(3) 
                + "this." + 标签名称 + ".Font = new System.Drawing.Font("+ 符号类.双引符号(1) + "宋体"+符号类.双引符号(1) 
                + ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this."+ 标签名称 + ".Location = new System.Drawing.Point("+ point_x + ", "+ point_y+ ");" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 标签名称 + ".Name = "+ 符号类.双引符号(1) + 标签名称 + 符号类.双引符号(1) + ";" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 标签名称 + ".Size = new System.Drawing.Size(200, 23);" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 标签名称 + ".TabIndex = "+ 制表符顺序 + ";" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 标签名称 + ".Text = "+ 符号类.双引符号(1) + 标签显示值 + 符号类.双引符号(1) + ";" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this." + 标签名称 + ".TextAlign = System.Drawing.ContentAlignment.MiddleCenter;" + 符号类.换行符号(1);

            return 结果字符;
        }
    }
}
