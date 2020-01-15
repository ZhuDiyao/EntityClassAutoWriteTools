using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace CSHARP模板
{
    public class 插入操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "\t///<summary>\r\n" +
                "\t/// 插入" + 表结构.ClassName + "\r\n" +
                "\t///</summary> \r\n" +
                "\tpublic class Insert" + 表结构.ClassName + "\r\n" +
                "\t{\r\n"
                ;
            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t/// <summary>\r\n" +
                "\t\t/// 默认需要的插入方法\r\n" +
                "\t\t/// </summary>\r\n" +
                "\t\t/// <returns></returns>\r\n" +
                "\t\tpublic static Boolean Insert(" + 表结构.ClassName + " yongJieHomeEntity)\r\n" +
                "\t\t{\r\n" +
                "\t\t\tSqlConnection cn = null;\r\n" +
                "\t\t\ttry\r\n" +
                "\t\t\t{\r\n" +
                "\t\t\t\t//获取具体的连接，这个视情况而定\r\n" +
                "\t\t\t\tcn = " + 表结构.Conection + ".GetConnection();\r\n" +
                "\t\t\t\tSqlCommand cmd = new SqlCommand();\r\n" +
                "\t\t\t\tcmd.Connection = cn;\r\n" +
                "\t\t\t\tcmd.CommandType = CommandType.Text;\r\n" +
                "\t\t\t\tcmd.CommandText =\r\n" +
                "\t\t\t\t\"INSERT INTO " + 表结构.ClassName + " ( \" + \r\n" +
                "\t\t\t\t\""
                ;

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                
                YongJieISeeYouStr = YongJieISeeYouStr + 表结构.字段列表.Rows[i]["字段注释"].ToString() + ",";
            }
            YongJieISeeYouStr = YongJieISeeYouStr.Substring(0, YongJieISeeYouStr.Length - 1);

            YongJieISeeYouStr = YongJieISeeYouStr +
            " ) VALUES ( \" + \r\n\t\t\t\t\"";

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                if (表结构.字段列表.Rows[i]["字段名"].ToString().Equals("FDate"))
                {
                    YongJieISeeYouStr = YongJieISeeYouStr + @""" + YongJieHomeTime.StandardSQLServerTime() + "",";
                }
                else
                {
                    YongJieISeeYouStr = YongJieISeeYouStr + "@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + ",";
                }

            }
            YongJieISeeYouStr = YongJieISeeYouStr.Substring(0, YongJieISeeYouStr.Length - 1);


            YongJieISeeYouStr = YongJieISeeYouStr +
                ") \";\r\n";

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                if (表结构.字段列表.Rows[i]["字段名"].ToString().Equals("FDate"))
                {
                    //如果是时间，就不插入
                    continue;
                }
                if (表结构.字段列表.Rows[i]["字段名"].ToString().Equals("InvalidateMark"))
                {
                    //如果是作废标记，就插入有效
                    YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t\tcmd.Parameters.AddWithValue(\"@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\",/**" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "**/ \"有效\");\r\n";
                    continue;
                }
                if (表结构.字段列表.Rows[i]["字段名"].ToString().Equals("UserName"))
                {
                    //如果是用户，就当前用户
                    YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t\tcmd.Parameters.AddWithValue(\"@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\",/**" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "**/ UserMessage.USERNAME);\r\n";
                    continue;
                }
                YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t\tcmd.Parameters.AddWithValue(\"@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\",/**" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "**/ yongJieHomeEntity." + 表结构.字段列表.Rows[i]["字段名"].ToString() + ");\r\n";

            }

            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t\t\tcmd.ExecuteNonQuery();\r\n" +
                "\t\t\t}\r\n" +
                "\t\t\tcatch\r\n" +
                "\t\t\t{\r\n" +
                "\t\t\t\treturn false;\r\n" +
                "\t\t\t}\r\n" +
                "\t\t\tfinally\r\n" +
                "\t\t\t{\r\n" +
                "\t\t\t\t" + 表结构.Conection + ".Close(cn);\r\n" +
                "\t\t\t}\r\n" +
                "\t\t\treturn true;\r\n" +
                "\t\t}\r\n" +
                "\t}";

            return YongJieISeeYouStr;
        }
    }
}
