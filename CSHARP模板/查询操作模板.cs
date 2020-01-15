using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace CSHARP模板
{
    public class 查询操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "\t///<summary>\r\n" +
                "\t/// 查询" + 表结构.ClassName + "\r\n" +
                "\t///</summary> \r\n" +
                "\tpublic class Select" + 表结构.ClassName + "\r\n" +
                "\t{\r\n"
                ;


            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t/// <summary>\r\n" +
                "\t\t/// 默认需要的查询方法，返回DataTable\r\n" +
                "\t\t/// </summary>\r\n" +
                "\t\t/// <returns></returns>\r\n" +
                "\t\tpublic static DataTable SelectToDataTable()\r\n" +
                "\t\t{\r\n" +
                "\t\t\tDataTable ds = new DataTable();\r\n" +
                "\t\t\t//获取具体的连接，这个视情况而定\r\n" +
                "\t\t\tSqlConnection con = " + 表结构.Conection + ".GetConnection();\r\n" +
                "\t\t\t//进行查询\r\n" +
                "\t\t\tstring sqlStr = @\"select* from " + 表结构.ClassName + "\";\r\n" +
                "\t\t\tSqlCommand cmd = new SqlCommand(sqlStr, con);\r\n" +
                "\t\t\tSqlDataAdapter sqlData = new SqlDataAdapter(cmd);\r\n" +
                "\t\t\tds = new DataTable();\r\n" +
                "\t\t\tsqlData.Fill(ds);\r\n" +
                "\t\t\t//关闭连接\r\n" +
                "\t\t\t" + 表结构.Conection + ".Close(con);\r\n" +
                "\t\t\treturn ds;\r\n" +
                "\t\t}\r\n" +

                "\t\t/// <summary>\r\n" +
                "\t\t/// 默认需要的查询方法，返回实体类\r\n" +
                "\t\t/// </summary>\r\n" +
                "\t\t/// <returns></returns>\r\n" +
                "\t\tpublic static " + 表结构.ClassName + " SelectToEntity(string id)\r\n" +
                "\t\t{\r\n" +
                "\t\t\tDataTable ds = new DataTable();\r\n" +
                "\t\t\t//获取具体的连接，这个视情况而定\r\n" +
                "\t\t\tSqlConnection con = " + 表结构.Conection + ".GetConnection();\r\n" +
                "\t\t\t//进行查询\r\n" +
                "\t\t\tstring sqlStr = @\"select* from " + 表结构.ClassName + " where id = @id\";\r\n" +
                "\t\t\tSqlCommand cmd = new SqlCommand(sqlStr, con);\r\n" +
                "\t\t\tcmd.Parameters.AddWithValue(\"@id\",/**id**/ id);\r\n" +
                "\t\t\tSqlDataAdapter sqlData = new SqlDataAdapter(cmd);\r\n" +
                "\t\t\tds = new DataTable();\r\n" +
                "\t\t\tsqlData.Fill(ds);\r\n" +
                "\t\t\t//关闭连接\r\n" +
                "\t\t\t" + 表结构.Conection + ".Close(con);\r\n" +
                "\t\t\t" + 表结构.ClassName + " yongJieHomeEntity = new " + 表结构.ClassName + "();\r\n" +
                "\t\t\tif (ds.Rows.Count != 0)\r\n" +
                "\t\t\t{\r\n";

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr
                    + "\t\t\t\tyongJieHomeEntity." + 表结构.字段列表.Rows[i]["字段名"].ToString() + " = ds.Rows[0][\"" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\"].ToString();\r\n";
            }



            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t\t}\r\n" +
                "\t\t\treturn yongJieHomeEntity;\r\n" +
                "\t\t}\r\n" +
                "\t}\r\n"
                ;

            return YongJieISeeYouStr;
        }
    }
}
