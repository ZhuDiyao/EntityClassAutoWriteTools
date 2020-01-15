using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体类转Csharp
{
    public class Csharp插入模板
    {
        public static string Conversion(表结构 表结构实例)
        {
            //类名首字母小写
            string classNameToLower = 首字母大小写转换.LitterToLower(表结构实例.ClassName);

            //头部图案
            string str = 头文件.HeadTXT();
            //引用
            str = str + 符号类.制表符号(0) + "using System;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "using System.Data;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "using System.Data.SqlClient;" + 符号类.换行符号(2);
            //命名空间
            str = str + 符号类.制表符号(0) + "namespace "+ 表结构实例.NameSpace + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "{" + 符号类.换行符号(1);
            //类
            str = str + 符号类.制表符号(1) + "///<summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///插入" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///</summary> " + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public class Insert" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "{" + 符号类.换行符号(1);


            #region 默认插入方法

            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 默认需要的插入方法" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static Boolean Insert("
                + 表结构实例.ClassName + " " + classNameToLower + ")" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " cn = null;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "try" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cn = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cmd.Connection = cn;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cmd.CommandType = CommandType.Text;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "cmd.CommandText =" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "\"INSERT INTO " + 表结构实例.ClassName + "(\" + " + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";
                if (i == 表结构实例.字段列表.Rows.Count - 1)
                {
                    str = str + 符号类.制表符号(5) + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                        + " \" +" + 符号类.换行符号(0);
                }
                else
                {
                    str = str + 符号类.制表符号(5) + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                        + ",\" +" + 符号类.换行符号(0);
                }
                str = str + "/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(5) + "\") VALUES(\" + " + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";

                if (i == 表结构实例.字段列表.Rows.Count - 1)
                {
                    str = str + 符号类.制表符号(5) + "\"@" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " \" +" + 符号类.换行符号(0);
                }
                else
                {
                    str = str + 符号类.制表符号(5) + "\"@" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ",\" +" + 符号类.换行符号(0);
                }
                str = str + "/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(5) + "\") \";" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";
                str = str + 符号类.制表符号(4) + "cmd.Parameters.AddWithValue(\"@"
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\",/**"
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/ "
                    + classNameToLower + "." + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ");" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(4) + "cmd.ExecuteNonQuery();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "catch" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "return false;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "finally" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + 表结构实例.Conection + ".Close(cn);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return true;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            #endregion


            #region 需要传入连接的插入方法
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 需要传入连接的插入方法" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static void Insert("+ 表结构实例.连接对象SqlConnection + " cn," + 表结构实例.ClassName + " " + classNameToLower + ")" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " cn = null;" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "try" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(4) + "cn = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "cmd.Connection = cn;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "cmd.CommandType = CommandType.Text;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "cmd.CommandText =" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "\"INSERT INTO " + 表结构实例.ClassName + "(\" + " + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";
                if (i == 表结构实例.字段列表.Rows.Count - 1)
                {
                    str = str + 符号类.制表符号(4) + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                        + " \" +" + 符号类.换行符号(0);
                }
                else
                {
                    str = str + 符号类.制表符号(4) + "\"" + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                        + ",\" +" + 符号类.换行符号(0);
                }
                str = str + "/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(4) + "\") VALUES(\" + " + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";

                if (i == 表结构实例.字段列表.Rows.Count - 1)
                {
                    str = str + 符号类.制表符号(4) + "\"@" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " \" +" + 符号类.换行符号(0);
                }
                else
                {
                    str = str + 符号类.制表符号(4) + "\"@" + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ",\" +" + 符号类.换行符号(0);
                }
                str = str + "/**" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(4) + "\") \";" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if (表结构实例.字段列表.Rows[i]["字段名"].ToString().Equals("id")) str = str + "//";
                str = str + 符号类.制表符号(4) + "cmd.Parameters.AddWithValue(\"@"
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\",/**"
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "**/ "
                    + classNameToLower + "." + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ");" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(3) + "cmd.ExecuteNonQuery();" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "catch" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(4) + "return false;" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "finally" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(4) + 表结构实例.Conection + ".Close(cn);" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "return true;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            #endregion

            //类结束
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            //命名空间结束
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "" + 符号类.换行符号(1);
            return str;
        }
    }
}
