using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体类转Csharp
{
    public class Csharp修改模板
    {
        public static string Conversion(表结构 表结构实例)
        {
            //类名首字母小写
            string classNameToLower = 首字母大小写转换.LitterToLower(表结构实例.ClassName);
            string str = 头文件.HeadTXT();

            str = str + 符号类.制表符号(0) + "using System;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "using System.Data;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "using System.Data.SqlClient;" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "namespace " + 表结构实例.NameSpace + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "{" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(1) + "///<summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///更新" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///</summary> " + 符号类.换行符号(1);


            str = str + 符号类.制表符号(1) + "public class Update" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// " +表结构实例.ClassName+"的Update方法" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static Boolean Update(" 
                + 表结构实例.ClassName + " " + classNameToLower+ ")" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " cn=null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "try" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + 表结构实例.连接对象SqlCommand + " cmd = new "+ 表结构实例.连接对象SqlCommand + "();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cn = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cmd.Connection = cn;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cmd.CommandType = CommandType.Text;" + 符号类.换行符号(1);
            //拼接SQL语句
            str = str + 符号类.制表符号(4) + "cmd.CommandText =" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "\"update "+ 表结构实例.ClassName + " set \"+" + 符号类.换行符号(1);
            for(int i=0;i< 表结构实例.字段列表.Rows.Count; i++)
            {
                if(i== (表结构实例.字段列表.Rows.Count - 1))
                {
                    str = str + 符号类.制表符号(4)
                    + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " = @"
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " \"/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/+" + 符号类.换行符号(1);
                }
                else
                {
                    str = str + 符号类.制表符号(4)
                    + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " = @"
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ",\"/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/+" + 符号类.换行符号(1);
                }
            }
            str = str + 符号类.制表符号(4) + "\" where id = @id\";" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(4) 
                    + "cmd.Parameters.AddWithValue(\"@" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() 
                    + "\",/*" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() 
                    + "*/" +classNameToLower+"." + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ");" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(4) + "cmd.ExecuteNonQuery();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "catch" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "return false;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "finally" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) +表结构实例.Conection +".Close(cn);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return true;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(0) + "" + 符号类.换行符号(1);
            return str;
        }
    }
}
