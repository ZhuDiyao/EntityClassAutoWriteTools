using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace JAVA模板
{
    public class 查询操作模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "import DAO.DBUtil;\r\n" +
                "import Entity." + 表结构.ClassName +
                "\r\n" +
                "import java.sql.Connection;\r\n" +
                "import java.sql.PreparedStatement;\r\n" +
                "import java.sql.ResultSet;\r\n" +
                "import java.sql.SQLException;\r\n" +
                "import java.util.ArrayList;\r\n" +
                "/***\r\n" +
                "*\r\n" +
                "*/\r\n" +
                "public class Select" + 表结构.ClassName + "{\r\n"
                ;


            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t/***\r\n" +
                "\t*查询整个表\r\n" +
                "\t*@return\r\n" +
                "\t*/\r\n" +
                "\tpublic static ArrayList<" + 表结构.ClassName + "> RunSelect(){\r\n" +
                "\t\tConnection conn= DBUtil.GetConnection();\r\n" +
                "\t\tPreparedStatement ps=null;\r\n" +
                "\t\tResultSet rs=null;\r\n" +
                "\t\tArrayList<" + 表结构.ClassName + "> alist=new ArrayList<" + 表结构.ClassName + ">();\r\n" +
                "\r\n" +
                "\t\ttry {\r\n" +
                "\t\t\tps = conn.prepareStatement(\"SELECT* from " + 表结构.ClassName + "\"); \r\n" +
                "\t\t\trs = ps.executeQuery();\r\n" +
                "\t\t\twhile(rs.next()){\r\n" +
                "\t\t\t\t" + 表结构.ClassName + " " + 表结构.ClassName + "= new " + 表结构.ClassName + "();\r\n";
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\t\t\t\t" + 表结构.ClassName + ".set" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "(rs.getString(\"" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\"));\r\n"
                    ;
            }
            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t\t\talist.add(" + 表结构.ClassName + ");\r\n" +
                "\t\t\t}\r\n" +
                "\t\t} catch (SQLException e) {\r\n" +
                "\t\t\te.printStackTrace();\r\n" +
                "\t\t}\r\n" +
                "\t\treturn alist;\r\n" +
                "\t}\r\n" +
                "\r\n"
                ;

            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t/**\r\n" +
                "\t*根据id查询出一条数据\r\n" +
                "\t*@param id\r\n" +
                "\t*@return\r\n" +
                "\t*/\r\n" +
                "\tpublic static " + 表结构.ClassName + " RunSelect(String id){\r\n" +
                "\t\tConnection conn= DBUtil.GetConnection();\r\n" +
                "\t\tPreparedStatement ps=null;\r\n" +
                "\t\tResultSet rs=null;\r\n" +
                "\t\t" + 表结构.ClassName + " " + 表结构.ClassName + "= new " + 表结构.ClassName + "();\r\n" +
                "\t\ttry{\r\n" +
                "\t\t\tps = conn.prepareStatement(\"SELECT* from " + 表结构.ClassName + " WHERE id = ? \"); \r\n" +
                "\t\t\tps.setString(1,id);\r\n" +
                "\t\t\trs = ps.executeQuery();\r\n" +
                "\t\t\tif(rs.next()){\r\n"
                ;

            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\t\t\t\t" + 表结构.ClassName + ".set" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "(rs.getString(\"" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "\"));\r\n"
                    ;
            }

            YongJieISeeYouStr = YongJieISeeYouStr +
                "\t\t\t}\r\n" +
                "\t\t} catch (SQLException e) {\r\n" +
                "\t\t\te.printStackTrace();\r\n" +
                "\t\t}\r\n" +
                "\t\treturn userSubmitMessage;\r\n" +
                "\t}\r\n" +
                "}\r\n"
                ;

            return YongJieISeeYouStr;
        }
    }
}
