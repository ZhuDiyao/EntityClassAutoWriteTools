using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace JAVA模板
{
    public class 插入操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string sssssss =
@"
import java.sql.PreparedStatement;
                        import java.sql.ResultSet;

";
            string YongJieISeeYouStr =
                "import java.sql.PreparedStatement;\r\n" +
                "import java.sql.ResultSet;\r\n" +
                "import java.sql.SQLException;\r\n" +
                "\r\n" +
                "/**\r\n" +
                "*插入数据\r\n" +
                "*/\r\n" +
                "public class Insert" + 表结构.ClassName + "{\r\n" +
                "\r\n" +
                "\t/**\r\n" +
                "\t*传入一个实体，向数据库表插入实体\r\n" +
                "\t*@param " + 表结构.ClassName + "\r\n" +
                "\t*@throws SQLException\r\n" +
                "\t*/\r\n"
                ;

            YongJieISeeYouStr += 
                "\tpublic static void RunInsert(" + 表结构.ClassName + " " + 表结构.ClassName + "){\r\n" +
                "\t\tConnection conn = null;\r\n" +
                "\t\tPreparedStatement pst = null;\r\n" +
                "\t\tResultSet rs = null;\r\n" +
                "\t\ttry{\r\n" +
                "\t\t\tconn = DBUtil.GetConnection();\r\n" +
                "\t\t\tString sql =\r\n" +
                "\t\t\t\t\"INSERT INTO " + 表结构.ClassName + "(\" +\r\n" +
                "\t\t\t\t\""
                ;

            for (int i = 1; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr + 表结构.字段列表.Rows[i]["字段名"].ToString() + ",";
            }
            YongJieISeeYouStr = YongJieISeeYouStr.Substring(0, YongJieISeeYouStr.Length - 1);

            YongJieISeeYouStr = YongJieISeeYouStr +
            "\"+\r\n\t\t\t\t\") VALUES ( \" + \r\n\t\t\t\t\"";

            for (int i = 1; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "?,"
                    ;
            }
            YongJieISeeYouStr = YongJieISeeYouStr.Substring(0, YongJieISeeYouStr.Length - 1);


            YongJieISeeYouStr = YongJieISeeYouStr +
                "\"+\r\n" +
                "\t\t\t\t\") \";\r\n" +
                "\t\t\tpst=conn.prepareStatement(sql);\r\n" +
                "\t\t\t//把相应的参数 添加到pst对象中\r\n"
                ;


            for (int i = 1; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t\tpst.setString( " + i + ", " + 表结构.ClassName + ".get" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "());\r\n";

            }

            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t\tpst.executeUpdate();\r\n" +
                "\t\tcatch(SQLException e){\r\n" +
                "\t\t\te.printStackTrace();\r\n" +
                "\t\t} finally{\r\n" +
                "\t\t\ttry {\r\n" +
                "\t\t\t\tconn.close();\r\n" +
                "\t\t\t} catch (SQLException e) {\r\n" +
                "\t\t\t\te.printStackTrace();\r\n" +
                "\t\t\t}\r\n" +
                "\t\t}\r\n" +
                "\t}";

            return YongJieISeeYouStr;
        }
    }
}
