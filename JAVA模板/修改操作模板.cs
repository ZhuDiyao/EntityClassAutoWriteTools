using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace JAVA模板
{
    public class 修改操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieUpdate =
                "import Entity." + 表结构.ClassName + ";\r\n" +
                "\r\n" +
                "import java.sql.Connection;\r\n" +
                "import java.sql.PreparedStatement;\r\n" +
                "import java.sql.ResultSet;\r\n" +
                "import java.sql.SQLException;\r\n" +
                "/**\r\n" +
                "*更新用户提交信息\r\n" +
                "*/\r\n" +
                "public class Update" + 表结构.ClassName + "{\r\n" +
                "\t/***\r\n" +
                "\t*根据id更新当前状态，处理人\r\n" +
                "\t*@param userSubmitMessage\r\n" +
                "\t*@throws SQLException\r\n" +
                "\t*/\r\n" +
                "\tpublic static void RunUpdate(" + 表结构.ClassName + " " + 表结构.ClassName + ")  {\r\n" +
                "\t\tConnection conn = null;\r\n" +
                "\t\tPreparedStatement pst = null;\r\n" +
                "\t\tResultSet rs = null;\r\n" +
                "\t\ttry{\r\n" +
                "\t\t\tconn = DBUtil.GetConnection();\r\n" +
                "\t\t\tString sql = \"UPDATE " + 表结构.ClassName + " SET \"+\r\n"

                ;
            for (int i = 1; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieUpdate = YongJieUpdate +
                    "\t\t\t\t\"" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "= ? ,\"+\r\n"
                    ;

            }
            YongJieUpdate = YongJieUpdate.Substring(0, YongJieUpdate.Length - 5) + "\"+\r\n";

            YongJieUpdate = YongJieUpdate + "\t\t\t\t\" where id = ?\";\r\n";
            YongJieUpdate = YongJieUpdate +
                "\t\t\tpst=conn.prepareStatement(sql);\r\n" +
                "\t\t\t//把相应的参数 添加到pst对象中\r\n"
                ;
            for (int i = 1; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieUpdate = YongJieUpdate +
                    "\t\t\tpst.setString(" + i + ", " + 表结构.ClassName + ".get" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "());\r\n"
                    ;
            }
            YongJieUpdate = YongJieUpdate +
                "\t\t\tpst.setString(" + 表结构.字段列表.Rows.Count + ", userSubmitMessage.getId());\r\n"
                ;
            YongJieUpdate = YongJieUpdate +
                "\t\t\t//提交pst对象\r\n" +
                "\t\t\tpst.executeUpdate();\r\n" +
                "\t\t}catch(SQLException e){\r\n" +
                "\t\t\te.printStackTrace();\r\n" +
                "\t\t} finally{\r\n" +
                "\t\t\ttry {\r\n" +
                "\t\t\t\tconn.close();\r\n" +
                "\t\t\t} catch (SQLException e) {\r\n" +
                "\t\t\t\te.printStackTrace();\r\n" +
                "\t\t\t}\r\n" +
                "\t\t}\r\n" +
                "\t}\r\n" +
                "}\r\n"
                ;
            return YongJieUpdate;
        }
    }
}
