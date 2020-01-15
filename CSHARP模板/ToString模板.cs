using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 实体类;

namespace CSHARP模板
{
    public class ToString模板
    {
        public static string DoIt(表结构 表结构)
        {
            string YongJieISeeYouStr =
                "\t\t/// <summary>\r\n" +
                "\t\t/// " + 表结构.ClassName + "的ToString方法。在【*】项目中，统一用ISeeYou方法\r\n" +
                "\t\t/// </summary>\r\n" +
                "\t\t/// <returns></returns>\r\n" +
                "\t\tpublic string ISeeYou()\r\n" +
                "\t\t{\r\n" +
                "\t\t\treturn ";
            for (int i = 0; i < 表结构.字段列表.Rows.Count; i++)
            {
                YongJieISeeYouStr = YongJieISeeYouStr +
                    "\"【" + 表结构.字段列表.Rows[i]["字段名"].ToString() + "】是【" + 表结构.字段列表.Rows[i]["字段注释"].ToString() + "】值【\" + " + 表结构.字段列表.Rows[i]["字段名"].ToString() + " + \"】\"\r\n";


                YongJieISeeYouStr = YongJieISeeYouStr + "\t\t\t + ";

            }
            YongJieISeeYouStr = YongJieISeeYouStr + "\"\";\r\n" +
                "\t\t}";
            return YongJieISeeYouStr;
        }
    }
}
