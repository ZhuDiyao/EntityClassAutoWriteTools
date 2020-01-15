using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace JAVA模板
{
    public class 实体类模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "package Entity;\r\n"
                + "\r\n"
                + "public class " + 表结构.ClassName + "\r\n"
                + "{\r\n"

                ;
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\t/***\r\n" +
                    "\t*" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "\r\n" +
                    "\t*/\r\n" +
                    "\tprivate String " + 表结构.字段列表.Rows[i]["字段名"].ToString() + ";\r\n\r\n";
            }
            YongJieISeeYouStr = YongJieISeeYouStr + "\r\n";

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\tpublic void set" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "(String " + 表结构.字段列表.Rows[i]["字段名"].ToString() + "){\r\n" +
                    "\t\tthis." + 表结构.字段列表.Rows[i]["字段名"].ToString() + " = " + 表结构.字段列表.Rows[i]["字段名"].ToString() + ";\r\n" +
                    "\t}\r\n" +
                    "\r\n" +
                    "\tpublic String get" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "(){\r\n" +
                    "\t\treturn " + 表结构.字段列表.Rows[i]["字段名"].ToString() + ";\r\n" +
                    "\t}\r\n" +
                    "\r\n"
                ;
            }
            return YongJieISeeYouStr;
        }
    }
}
