using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace CSHARP模板
{
    public class 实体类模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                  "\t///<summary>\r\n"
                + "\t///\r\n"
                + "\t///</summary> \r\n"
                + "\tpublic class " + 表结构.ClassName + "\r\n"
                + "\t{\r\n"

                ;
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                
                
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\t\t/// <summary>\r\n" +
                    "\t\t/// " + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "\r\n" +
                    "\t\t/// </summary>\r\n" +
                    "\t\tpublic string " + 表结构.字段列表.Rows[i]["字段名"].ToString() + "=\"\";\r\n\r\n";
            }
            YongJieISeeYouStr = YongJieISeeYouStr + "\r\n";
            return YongJieISeeYouStr;
        }
    }
}
