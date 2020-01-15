using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工具
{
    public class 符号类
    {
        public static string 换行符号(int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "\r\n";
            }
            return str;
        }

        public static string 制表符号(int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "\t";
            }
            return str;
        }

        public static string 双引符号(int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "\"";
            }
            return str;
        }


    }
}
