using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace JAVA模板
{
    public class ToString模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "\t@Override\r\n" +
                "\tpublic String toString(){\r\n" +
                "\t\t\treturn \"" + 表结构.ClassName + "{\"+\r\n"
                ;
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\t\t\t\"," + 表结构.字段列表.Rows[i]["字段名"].ToString() + "='\"+" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "+'\\'\' +\r\n";

            }
            YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t'}';";
            return YongJieISeeYouStr;
        }
    }
}
