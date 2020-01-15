using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using 字符串操作;

namespace SQL语句转内存表
{
    public class SQL语句转内存表类
    {
        public static DataTable 转换(string str)
        {
            DataTable SQLTABEL = new DataTable();
            str = str.Replace("."," ");
            for (int i = 0; i < 60; i++)
            {
                SQLTABEL.Columns.Add("C"+i);
            }
            while(true)
            {
                try
                {
                    //截取行
                    string Line = OperationString.DoIt(str, "", "\r\n");
                    str = OperationString.Handle(str, "", "\r\n");
                    int index = 0;
                    DataRow dr = SQLTABEL.NewRow();
                    while (true)
                    {
                        try
                        {
                            
                            dr[index] = OperationString.DoIt(Line, "", " "); ;
                            Line = OperationString.Handle(Line,""," ");
                            
                            index++;
                        }
                        catch
                        {
                            break;
                        }
                        
                    }
                    dr[index] = Line;
                    SQLTABEL.Rows.Add(dr);
                }
                catch
                {
                    break;
                }


            }

            return SQLTABEL;
        }
    }
}
