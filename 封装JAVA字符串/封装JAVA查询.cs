using JAVA模板;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace 封装JAVA字符串
{
    public class 封装JAVA查询
    {
        public static string Combined(表结构 表结构)
        {
            string FileStr2 = 查询操作模板.DoIt(表结构);
           
            string Select = 头文件模板.GetTXT()
                + FileStr2;
            return Select;
        }
    }
}
