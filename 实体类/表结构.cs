using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace 实体类
{
    public class 表结构
    {
        public 表结构()
        {
            try
            {
                字段列表.Columns.Add("字段名", typeof(string));
                字段列表.Columns.Add("字段类型", typeof(string));
                字段列表.Columns.Add("字段注释", typeof(string));
            }
            catch 
            {
            }
        }
        /// <summary>
        /// 成员变量组,组对象YongJieMap
        /// </summary>
        public DataTable 字段列表 = new DataTable();

        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace = "Entity";

        /// <summary>
        /// 实体类类名
        /// </summary>
        public string ClassName="fdafad";
        /// <summary>
        /// 类注释
        /// </summary>
        public string ClassNotes= "Entitydddds";
        /// <summary>
        /// 数据库连接
        /// </summary>
        public string Conection="";

        public string 连接对象SqlConnection = "SqlConnection";

        public string 连接对象SqlCommand = "SqlCommand";

        public string 连接对象SqlDataAdapter = "SqlDataAdapter";

        /// <summary>
        /// 应用于窗口类自动生成
        /// </summary>
        public string 窗口类_项目路径 = "【暂无赋值_来源自动生成工具表结构类】";
        /// <summary>
        /// 应用于窗口类自动生成
        /// </summary>
        public string 窗口类_类名称 = "【暂无赋值_来源自动生成工具表结构类】";
        /// <summary>
        /// 应用于窗口类自动生成
        /// </summary>
        public string 窗口类_命名空间 = "【暂无赋值_来源自动生成工具表结构类】";

        public string ISeeYou()
        {
            string str = "";
            str = str + "命名空间或者包名【" + NameSpace + "】\r\n";
            str = str + "实体类名【" + ClassName + "】\r\n";
            str = str + "类注释【" + ClassNotes + "】\r\n";
            str = str + "数据库连接【" + Conection + "】\r\n";
            str = str + "连接对象SqlConnection【" + 连接对象SqlConnection + "】\r\n";
            str = str + "连接对象SqlCommand【" + 连接对象SqlCommand + "】\r\n";
            str = str + "连接对象SqlDataAdapter【" + 连接对象SqlDataAdapter + "】\r\n";

            for (int i = 0; i < 字段列表.Rows.Count; i++)
            {
                str += (
                    @"***********************
" +
                      "字段名【" + 字段列表.Rows[i]["字段名"].ToString() + "】\r\n"
                    + "字段注释【" + 字段列表.Rows[i]["字段注释"].ToString() + "】\r\n"
                    + "字段类型【" + 字段列表.Rows[i]["字段类型"].ToString() + "】\r\n"

                    + @"
***********************
"
                    );
            }
            return str;
        }


    }
}
