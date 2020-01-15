using CSHARP模板;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace 生成CSHARP字符串
{
    public class 封装CSHARP修改
    {
        public static string Combined(表结构 表结构)
        {
            string FileStr = 修改操作模板.DoIt(表结构);
            
            string Update="using System.Data;\r\n"
                + "using System.Data.SqlClient;\r\n\r\n"
                + "namespace " + 表结构.NameSpace + "\r\n"
                + "{\r\n"
                + 头文件模板.GetTXT()
                + FileStr
                + "}\r\n"
                ;
            return Update;
        }
    }
}
