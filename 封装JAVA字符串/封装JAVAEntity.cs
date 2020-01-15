using JAVA模板;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace 封装JAVA字符串
{
    public class 封装JAVAEntity
    {
        public static string Combined(表结构 表结构)
        {
            string FileStr1 = 实体类模板.DoIt(表结构);
            string FileStr2 = ToString模板.DoIt(表结构);
            
            string Entity= 头文件模板.GetTXT()
                + FileStr1
                + FileStr2
                + "\r\n" +
                "\t}\r\n" +
                "}\r\n"
                ;
            return Entity;
        }
    }
}
