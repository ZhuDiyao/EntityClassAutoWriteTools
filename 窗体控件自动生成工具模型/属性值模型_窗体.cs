using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;
using 工具;

namespace 窗体控件自动生成工具模型
{
    public class 属性值模型_窗体
    {
        public static string 创建(string 窗体名称,string 窗体显示名称, 表结构 表结构实体,int 窗口高度)
        {
            窗体名称 = "" + 窗体名称;
            string 结果字符 = "";
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 窗体名称 + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "// " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.ClientSize = new System.Drawing.Size(800, "+ 窗口高度 + ");" + 符号类.换行符号(1);

            for(int i=0;i< 表结构实体.字段列表.Rows.Count; i++)
            {
                结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Controls.Add(this.txt_" + 表结构实体.字段列表.Rows[i]["字段名"].ToString() + ");" + 符号类.换行符号(1);
                结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Controls.Add(this.lab_" + 表结构实体.字段列表.Rows[i]["字段名"].ToString() + ");" + 符号类.换行符号(1);
            }
            //结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Controls.Add(this.txt_id);" + 符号类.换行符号(1);
            //结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Controls.Add(this.lab_id);" + 符号类.换行符号(1);

            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Name = " + 符号类.双引符号(1) + 窗体名称 + 符号类.双引符号(1) + "; " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.Text = " + 符号类.双引符号(1) + 窗体显示名称 + 符号类.双引符号(1) + "; " + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.ResumeLayout(false);" + 符号类.换行符号(1);
            结果字符 = 结果字符 + 符号类.制表符号(3) + "this.PerformLayout();" + 符号类.换行符号(1);
            return 结果字符;
        }
    }
}
