using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;
using 工具;

namespace 实体转JAVA
{
    public class 实体类模板
    {
        public static string Conversion(表结构 表结构实例)
        {
            string str = 头文件.HeadTXT();

            str = str + 符号类.制表符号(0) + "package " + 表结构实例.NameSpace + ";" + 符号类.换行符号(2);

            str = str + 符号类.制表符号(0) + "/**" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + " * " + 表结构实例.ClassNotes + 符号类.换行符号(1);
            str = str + 符号类.制表符号(0) + " */" + 符号类.换行符号(1);


            str = str + 符号类.制表符号(0) + "public class " + 表结构实例.ClassName + " {" + 符号类.换行符号(1);

            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(1) + "/**" + 符号类.换行符号(1);
                str = str + 符号类.制表符号(1) + " * " + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + 表结构实例.字段列表.Rows[i]["字段类型"].ToString() + 符号类.换行符号(1);
                str = str + 符号类.制表符号(1) + " */" + 符号类.换行符号(1);

                str = str + 符号类.制表符号(1) + "private String " + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + ";" + 符号类.换行符号(1);
            }

            //===========
            //以下是Set方法
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(1)
                    + "public void set"
                    + 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString())
                    + "(String "
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                    + "){"
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(2)
                    + "this."
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                    + " = "
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                    + ";"
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            }

            //===========
            //以下是Get方法
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(1)
                    + "public String get"
                    + 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString())
                    + "(){"
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(2)
                    + "return "
                    + 表结构实例.字段列表.Rows[i]["字段名"].ToString()
                    + ";"
                    + 符号类.换行符号(1);

                str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            }

            //===========
            //以下是ISeeYou方法
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public String ISeeYou(){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "return " + 符号类.换行符号(1);
            for(int i=0;i< 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(3) 
                    + "\"【" + 表结构实例 .字段列表.Rows[i]["字段名"].ToString() + "】"
                    + "是"
                    + "【" + 表结构实例.字段列表.Rows[i]["字段注释"].ToString() + "】"
                    + "值为"
                    + "【\" + " + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " + \"】\" + "

                    + 符号类.换行符号(1);
                
            }
            str = str + 符号类.制表符号(3) + "\"\";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            //===========
            //以下是ToJson方法
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public String ToJson(){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "return " + 符号类.换行符号(1);

            str = str + 符号类.制表符号(2) + 符号类.双引符号(1) + "{" + 符号类.双引符号(1) + "+" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                if ((表结构实例.字段列表.Rows.Count - 1) == i)
                {
                    str = str + 符号类.制表符号(3) + Json格式单体(表结构实例.字段列表.Rows[i]["字段名"].ToString(), 表结构实例.字段列表.Rows[i]["字段名"].ToString(),true) + 符号类.换行符号(1);
                }
                else
                {
                    str = str + 符号类.制表符号(3) + Json格式单体(表结构实例.字段列表.Rows[i]["字段名"].ToString(), 表结构实例.字段列表.Rows[i]["字段名"].ToString(),false) + 符号类.换行符号(1);
                }
                
            }
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + 符号类.双引符号(1) + "}" + 符号类.双引符号(1) + ";" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            //===========
            //空的构造方法【因为需要写JSON接收的构造方法】
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public " + 表结构实例.ClassName + "(){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            //===========
            //接收JSON字符串的构造方法【】
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public " + 表结构实例.ClassName + "(String JsonCode){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "try{" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(3) + 表结构实例.ClassName + " " + 首字母大小写转换.LitterToLower(表结构实例.ClassName) + " = JSONObject.parseObject(JsonCode," + 表结构实例.ClassName + ".class);" + 符号类.换行符号(1);
            for (int i = 0; i < 表结构实例.字段列表.Rows.Count; i++)
            {
                str = str + 符号类.制表符号(3) + "this." + 表结构实例.字段列表.Rows[i]["字段名"].ToString() + " = " + 首字母大小写转换.LitterToLower(表结构实例.ClassName) + ".get"+ 首字母大小写转换.LitterToUpper(表结构实例.字段列表.Rows[i]["字段名"].ToString()) + "();" + 符号类.换行符号(1);
            }
            str = str + 符号类.制表符号(2) + "}catch (Exception ex){" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(2) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            //===========
            //主方法
            //===========
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "public static void main(String[] args) {" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);
            //===========
            //以下是结尾内容
            //===========
            str = str + 符号类.制表符号(0) + "}" + 符号类.换行符号(1);
            str = str + 符号类.制表符号(1) + "" + 符号类.换行符号(1);




            return str;
        }

        public static string Json格式单体(string key,string value,Boolean 是否最后一个)
        {
            if (是否最后一个)
            {
                return "\"\\\"" + key + "\\\":\\\"\"+" + value + "+\"\\\"\" + ";
            }
            else
            {
                return "\"\\\"" + key + "\\\":\\\"\"+" + value + "+\"\\\",\" + ";
            }
            
        }
    }
}
