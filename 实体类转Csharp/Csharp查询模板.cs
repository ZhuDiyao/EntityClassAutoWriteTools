using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体类转Csharp
{
    public class Csharp查询模板
    {
        public static string Conversion(表结构 表结构实例)
        {
            //类名首字母小写
            string classNameToLower = 首字母大小写转换.LitterToLower(表结构实例.ClassName);
            string str = 头文件.HeadTXT();
            str = str + 符号类.制表符号(0) + "using System.Data;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "using System.Data.SqlClient;" + 符号类.换行符号(2);
            str = str + 符号类.制表符号(0) + "namespace " + 表结构实例.NameSpace + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "{" + 符号类.换行符号(1);



            str = str + 符号类.制表符号(1) + "///<summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///查询" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "///</summary> " + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public class Select" + 表结构实例.ClassName + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "{" + 符号类.换行符号(1);

            //==============================================================================================
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 默认需要的查询方法，返回DataTable" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static DataTable SelectAll()" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " con = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            //SQL查询语句
            str = str + 符号类.制表符号(3) + "string sqlStr = @\"select * from " + 表结构实例.ClassName + "\";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "(sqlStr, con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlDataAdapter + " sqlData = new " + 表结构实例.连接对象SqlDataAdapter + "(cmd);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "sqlData.Fill(ds);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".Close(con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return ds;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);



            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);

            //==============================================================================================
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 默认需要的查询方法，返回DataTable" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static DataTable SelectAllOptionalColumn()" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " con = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);

            //SQL查询语句
            str = str + 符号类.制表符号(3) + "string sqlStr = \"\";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "sqlStr = sqlStr + \"select \";" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(4)
                            + "// "
                            + 表结构实例.字段列表.Rows[i]["字段注释"].ToString()
                            + "_"
                            + 表结构实例.字段列表.Rows[i]["字段类型"].ToString()
                            + 符号类.换行符号(1);

                str = str + 符号类.制表符号(3) + "sqlStr = sqlStr + \""+ 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\";" + 符号类.换行符号(1);
                if ((表结构实例.字段列表.Rows.Count - 1) != i)
                {
                    str = str + 符号类.制表符号(3) + "sqlStr = sqlStr + \",\";" + 符号类.换行符号(1);
                }
            }
            str = str + 符号类.制表符号(3) + "sqlStr = sqlStr + \" from "+ 表结构实例.ClassName + "\";" + 符号类.换行符号(1);


            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "(sqlStr, con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlDataAdapter + " sqlData = new " + 表结构实例.连接对象SqlDataAdapter + "(cmd);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "sqlData.Fill(ds);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".Close(con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return ds;" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);



            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);


            //==============================================================================================
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 默认需要的查询方法，返回实体类。" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 使用此方法查询返回的实体类，一定不会是 null 值。" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static " + 表结构实例.ClassName + " SelectEntity(string id)" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " con = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            //查询语句
            str = str + 符号类.制表符号(3) + "string sqlStr = @\"select * from " + 表结构实例.ClassName + " where id = @id\";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "(sqlStr, con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "cmd.Parameters.AddWithValue(\"@id\",/**id**/ id);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlDataAdapter + " sqlData = new " + 表结构实例.连接对象SqlDataAdapter + "(cmd);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "sqlData.Fill(ds);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".Close(con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.ClassName + " " + classNameToLower + " = new " + 表结构实例.ClassName + "();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "if (ds.Rows.Count != 0)" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(4) + "int lineNumber = 0 ;" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {

                str = str + 符号类.制表符号(4)
                    + "// "
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString()
                    + "_"
                    + 表结构实例.字段列表.Rows[i]["字段类型"].ToString()
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(4) + classNameToLower + "."
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " = ds.Rows[lineNumber][\""
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\"].ToString();" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return " + classNameToLower + ";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);


            //==============================================================================================






            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);

            //==============================================================================================
            str = str + 符号类.制表符号(2) + "/// <summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 默认需要的查询方法，返回实体类。" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// 如果查询得不到结果，返回null。" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// </summary>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "/// <returns></returns>" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "public static " + 表结构实例.ClassName + " SelectEntity2(string id)" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "{" + 符号类.换行符号(1);
            //str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlConnection + " con = " + 表结构实例.Conection + ".GetConnection();" + 符号类.换行符号(1);
            //查询语句
            str = str + 符号类.制表符号(3) + "string sqlStr = @\"select * from " + 表结构实例.ClassName + " where id = @id\";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlCommand + " cmd = new " + 表结构实例.连接对象SqlCommand + "(sqlStr, con);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "cmd.Parameters.AddWithValue(\"@id\",/**id**/ id);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.连接对象SqlDataAdapter + " sqlData = new " + 表结构实例.连接对象SqlDataAdapter + "(cmd);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "DataTable ds = new DataTable();" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "sqlData.Fill(ds);" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.Conection + ".Close(con);" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(3) + 表结构实例.ClassName + " " + classNameToLower + " = null;" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(3) + "if (ds.Rows.Count != 0)" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + classNameToLower + " = new " + 表结构实例.ClassName + "();" + 符号类.换行符号(1);

            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {

                str = str + 符号类.制表符号(4)
                    + "// "
                    + 表结构实例.字段列表.Rows[i]["字段注释"].ToString()
                    + "_"
                    + 表结构实例.字段列表.Rows[i]["字段类型"].ToString()
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(4) + classNameToLower + "."
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " = ds.Rows[0][\""
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + "\"].ToString();" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(3) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + "return " + classNameToLower + ";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);


            //==============================================================================================


















            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);

            str = str + 符号类.制表符号(0) + "" + 符号类.换行符号(1);
            return str;
        }
    }
}
