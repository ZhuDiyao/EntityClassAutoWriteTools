using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串操作
{
    public class 首字母大小写转换
    {
        /// <summary>
        /// 大写转小写
        /// </summary>
        /// <returns></returns>
        public static string LitterToLower(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, str.Length - 1);
            str1 = str1.ToLower();
            str = str1 + str2;
            return str;
        }
        /// <summary>
        /// 小写转大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LitterToUpper(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, str.Length - 1);
            str1 = str1.ToUpper();
            str = str1 + str2;
            return str;
        }
    }
}
