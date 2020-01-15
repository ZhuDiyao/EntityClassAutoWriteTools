using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体转JAVA
{
    public class 修改模板
    {
        public static string Conversion(表结构 表结构实例)
        {
            //类名首字母小写
            string classNameToLower = 首字母大小写转换.LitterToLower(表结构实例.ClassName);
            string str = 头文件.HeadTXT();
            str = str + 符号类.制表符号(0) + "package " + 表结构实例.NameSpace + ";" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "import java.sql.Connection;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.PreparedStatement;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.ResultSet;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.SQLException;" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "public class Update"+ 表结构实例.ClassName + " {" + 符号类.换行符号(2);
            str = str + 符号类.制表符号(1) + "public static void RunUpdate(" + 表结构实例.ClassName + " "+ classNameToLower + "){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "Connection conn = null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "PreparedStatement pst = null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "ResultSet rs = null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "try{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "conn = "+ 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            //拼接SQL语句
            str = str + 符号类.制表符号(3) + "String sql =" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "\"UPDATE " + 表结构实例.ClassName + " SET \" + " + 符号类.换行符号(1);
            for(int i=1;i< 表结构实例.字段列表.Rows.Count; i++)
            {
                if (i == (表结构实例.字段列表.Rows.Count -1))
                {
                    str = str + 符号类.制表符号(5)
                    + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                    + " =? \" +/**" + 表结构实例.字段列表.Rows[i ]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
                }
                else
                {
                    str = str + 符号类.制表符号(5)
                    + "\"" + 表结构实例.字段列表.Rows[i ]["字段名"].ToString()
                    + " =?, \" +/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
                }
            }
            str = str + 符号类.制表符号(5) 
                + "\"WHERE " + 表结构实例.字段列表.Rows[0]["字段名"].ToString() 
                + " = ? \";/**" + 表结构实例.字段列表.Rows[0]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "pst=conn.prepareStatement(sql);" + 符号类.换行符号(1);
            //把相应的参数 添加到pst对象中
            str = str + 符号类.制表符号(3) + "//把相应的参数 添加到pst对象中" + 符号类.换行符号(1);
            for (int i = 1; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(3) 
                    + "pst.setString( " + i + "," + classNameToLower + ".get" 
                    + 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString()) 
                    + "()/**"+ 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/ );" + 符号类.换行符号(1);
            }
            int j = 表结构实例.字段列表.Rows.Count;
            str = str + 符号类.制表符号(3) 
                + "pst.setString( "+ j +","+ classNameToLower + ".getId()/**"
                + 表结构实例.字段列表.Rows[0]["字段注释"].ToString() + "**/ );" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "//提交pst对象" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "pst.executeUpdate();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}catch(SQLException e){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "e.printStackTrace();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "} finally {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".CloseConnection(conn);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            return str;
        }
    }
}
