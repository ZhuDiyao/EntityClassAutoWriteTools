using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using 实体类;

namespace SQL语句转内存表
{
    public class 内存表_转_表结构实体
    {
        static string Rep_trim(string str)
        {
            string[] 默认屏蔽字符 = {
                "[",
                "]",
                "(",
                ")",
                "'",
                ",",
                "`",
                "-" };
            for (int i=0;i< 默认屏蔽字符.Length;i++)
            {
                str = str.Replace(默认屏蔽字符[i],"");
            }
            return str;
        }

        public static 表结构 转换(string 数据库建表语句,int 类名所在列,int 字段名所在列,int 字段类型所在列,int 字段注释所在列,int 字段行数,string 连接对象,string 命名空间)
        {

            try
            {
                

                DataTable 数据库建表语句内存表 = SQL语句转内存表类.转换(数据库建表语句);

                表结构 表结构 = new 表结构();
                表结构.Conection = 连接对象;
                表结构.NameSpace = 命名空间;

                表结构.ClassNotes = 数据库建表语句内存表.Rows[0]["C0"].ToString();
                表结构.ClassNotes = Rep_trim(表结构.ClassNotes);

                表结构.ClassName = 数据库建表语句内存表.Rows[1]["C"+ 类名所在列].ToString();
                表结构.ClassName = Rep_trim(表结构.ClassName);

                DataRow INDEXDR = 表结构.字段列表.NewRow();
                INDEXDR["字段名"] = "id";
                INDEXDR["字段类型"] = "整数";
                INDEXDR["字段注释"] = "自动递增";
                表结构.字段列表.Rows.Add(INDEXDR);

                for (int i = 3; i < 数据库建表语句内存表.Rows.Count - 字段行数; i++)
                {
                    DataRow dr = 表结构.字段列表.NewRow();
                    dr["字段名"] = 数据库建表语句内存表.Rows[i]["C" + 字段名所在列].ToString();
                    dr["字段类型"] = 数据库建表语句内存表.Rows[i]["C" + 字段类型所在列].ToString();
                    dr["字段注释"] = 数据库建表语句内存表.Rows[i]["C" + 字段注释所在列].ToString();

                    dr["字段名"] = Rep_trim(dr["字段名"].ToString());
                    dr["字段类型"] = Rep_trim(dr["字段类型"].ToString());
                    dr["字段注释"] = Rep_trim(dr["字段注释"].ToString());
                    //if()

                    表结构.字段列表.Rows.Add(dr);


                }

                return 表结构;
            }
            catch
            {
                return null;
            }
        }
    }
}
