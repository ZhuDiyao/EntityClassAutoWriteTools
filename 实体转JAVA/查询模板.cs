using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体转JAVA
{
    public class 查询模板
    {
        public  static string Conversion(表结构 表结构实例)
        {
            //类名首字母小写
            string classNameToLower = 首字母大小写转换.LitterToLower(表结构实例.ClassName);
            string str = 头文件.HeadTXT();
            str = str + 符号类.制表符号(0) + "package " + 表结构实例.NameSpace + ";" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "import java.sql.Connection;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.PreparedStatement;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.ResultSet;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "import java.sql.SQLException;" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "public class Select" + 表结构实例.ClassName + " {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "/***" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " * 查询整个表" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " * @return" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " */" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public static ArrayList<" + 表结构实例.ClassName + "> SelectAll(){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "Connection conn= " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "PreparedStatement ps=null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "ResultSet rs=null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "ArrayList<" + 表结构实例.ClassName + "> alist = new ArrayList<" + 表结构实例.ClassName + ">();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "try {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "ps = conn.prepareStatement(\"SELECT * FROM " + 表结构实例.ClassName + " ORDER BY id DESC \");" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "rs = ps.executeQuery();" + 符号类.换行符号(2);
            str = str + 符号类.制表符号(3) + "while(rs.next()){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + 表结构实例.ClassName + " " + classNameToLower +" = new " + 表结构实例.ClassName + "();" + 符号类.换行符号(1);
            for(int i=0;i< 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(4) + classNameToLower 
                    + ".set" + 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString())+ "(rs.getString(\"" 
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\"/**" 
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/));" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(4) + "alist.add(" + classNameToLower + ");" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}catch (SQLException e){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "e.printStackTrace();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}finally {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".CloseConnection(conn);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "return alist;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(2);
            //查询一条记录
            str = str + 符号类.制表符号(1) + "/***" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " *查询一条记录" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " *@return" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + " */" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public static " + 表结构实例.ClassName + " SelectOne(String id){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "Connection conn= "+ 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "PreparedStatement ps=null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "ResultSet rs=null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + 表结构实例.ClassName + " "+ classNameToLower + " = new " + 表结构实例.ClassName + "();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "try {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "ps = conn.prepareStatement(\"SELECT * FROM " + 表结构实例.ClassName + " WHERE id = ? \");" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "ps.setString(1,id);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "rs = ps.executeQuery();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "while(rs.next()){" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(4) + classNameToLower
                    + ".set" + 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString()) + "(rs.getString(\""
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\"/**"
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/));" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}catch (SQLException e){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "e.printStackTrace();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}finally {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".CloseConnection(conn);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "return " + classNameToLower + ";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);
            return str;
        }
    }
}
