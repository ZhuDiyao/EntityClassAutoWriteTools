using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace CSHARP模板
{
    public class 修改操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieUpdate =
                "\t\t/// <summary>\r\n" +
                "\t\t/// " + 表结构.ClassName + "的Update方法。在【**HOME】项目中，统一用Update方法\r\n" +
                "\t\t/// </summary>\r\n" +
                "\t\t/// <returns></returns>\r\n" +
                "\t\tpublic static Boolean Update(" + 表结构.ClassName + " yongJieHomeEntity)\r\n" +
                "\t\t{\r\n" +
                "\t\t\tSqlConnection cn=null;\r\n" +
                "\t\t\ttry\r\n" +
                "\t\t\t{\r\n" +
                "\t\t\t\tcn = " + 表结构.Conection + ".GetConnection();\r\n" +
                "\t\t\t\tSqlCommand cmd = new SqlCommand();\r\n" +
                "\t\t\t\tcmd.Connection = cn;\r\n" +
                "\t\t\t\tcmd.CommandType = CommandType.Text;\r\n" +
                "\t\t\t\tcmd.CommandText =\r\n" +
                "\t\t\t\t\"update " + 表结构.ClassName + " set \"+\r\n";
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieUpdate = YongJieUpdate + "\t\t\t\t\"" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "=@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + ",\"+\r\n";

            }
            YongJieUpdate = YongJieUpdate.Substring(0, YongJieUpdate.Length - 5) + "\"+\r\n";

            YongJieUpdate = YongJieUpdate + "\t\t\t\t\" where id=@id\";\r\n";
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieUpdate = YongJieUpdate + "\t\t\t\tcmd.Parameters.AddWithValue(\"@" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\",/*" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "*/yongJieHomeEntity." + 表结构.字段列表.Rows[i]["字段名"].ToString() + ");\r\n";
            }
            YongJieUpdate = YongJieUpdate + "\t\t\t\tcmd.ExecuteNonQuery();\r\n" +
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
                "\t\t}\r\n";
            return YongJieUpdate;
        }
    }
}
