using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YongJieHomeException;

namespace 字符串操作
{
    public class OperationString
    {
        /// <summary>
        /// 【源字符串】
        /// 【头字符串】
        /// 【尾字符串】
        /// 返回【源字符串】 头字符串到尾字符串中间的内容（不包含头尾内容）
        /// </summary>
        /// <param name="SomethingToBeTreated"></param>
        /// <param name="HeadString"></param>
        /// <param name="EndString"></param>
        /// <returns></returns>
        public static string DoIt(string SourceString, string HeadString, string EndString)
        {
            int head = SourceString.ToUpper().IndexOf(HeadString.ToUpper());

            int end = SourceString.ToUpper().IndexOf(EndString.ToUpper());
            if (head == -1)
            {
                throw new YongJieException("源字符串中没有头字符串");
            }
            if (end == -1)
            {
                throw new YongJieException("源字符串中没有尾字符串");
            }
            if (head > end)
            {
                throw new YongJieException("尾字符串出现位置在头字符串之前");
            }
            return SourceString.Substring(head + HeadString.Length, end - head - HeadString.Length).Trim();
        }


        public static string Handle(string SourceString, string HeadString, string EndString)
        {
            int head = SourceString.ToUpper().IndexOf(HeadString.ToUpper());
            int end = SourceString.ToUpper().IndexOf(EndString.ToUpper());
            if (head == -1)
            {
                throw new YongJieException("源字符串中没有头字符串");
            }
            if (end == -1)
            {
                throw new YongJieException("源字符串中没有尾字符串");
            }
            if (head > end)
            {
                throw new YongJieException("尾字符串出现位置在头字符串之前");
            }
            return SourceString.Substring(end + EndString.Length, SourceString.Length - end - EndString.Length);
        }
    }
}
