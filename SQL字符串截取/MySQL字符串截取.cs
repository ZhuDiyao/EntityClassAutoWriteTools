using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using 字符串操作;
using 实体类;

namespace SQL字符串截取
{
    public class MySQL字符串截取
    {
        public static 表结构 Interception(string SourceStr)
        {
            表结构 表结构 = new 表结构();
            try
            {
                //截取类目注释
                表结构.ClassNotes = OperationString.DoIt(SourceStr, "--", "\r\n");
                SourceStr = OperationString.Handle(SourceStr, "--", "\r\n");
                //删除dbo
                string dbostr = OperationString.DoIt(SourceStr, "`", "`.");
                SourceStr = OperationString.Handle(SourceStr, "`", "`.");
                //截取类名
                表结构.ClassName = OperationString.DoIt(SourceStr, "`", "` ");
                SourceStr = OperationString.Handle(SourceStr, "`", "` ");


                DataRow dr = 表结构.字段列表.NewRow();
                dr["字段名"] = "id";
                dr["字段注释"] = "主键";
                表结构.字段列表.Rows.Add(dr);

                //删除id所在行
                string idstr = OperationString.DoIt(SourceStr, "`", "主键");
                SourceStr = OperationString.Handle(SourceStr, "`", "主键");


                try
                {
                    //截取成员变量
                    while (true)
                    {
                        dr = 表结构.字段列表.NewRow();
                        dr["字段名"] = OperationString.DoIt(SourceStr, "`", "` ");

                        //取字段名
                        SourceStr = OperationString.Handle(SourceStr, "`", "` ");

                        dr["字段注释"] = OperationString.DoIt(SourceStr, "--", "\r\n");
                        //取注释
                        SourceStr = OperationString.Handle(SourceStr, "--", "\r\n");
                        表结构.字段列表.Rows.Add(dr);

                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return 表结构;
        }
    }
}
