using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 示例字符串
{
    public class SQLServer标准建表语句
    {
        public static string str = @"--用户提交信息表
CREATE TABLE [dbo].[userSubmitMessage](  
	[id] [int] identity (1,1) primary key, --主键
	[user_phone] [varchar](50) ,  --用户电话
	[currentState] [varchar](50) ,  --当前状态
	[ipAddr] [varchar](50) ,  --ip地址
	[submitTime] [varchar](50) ,  --提交时间
	[solveTime] [varchar](50) ,  --解决时间
	[processingPerson] [varchar](50) ,  --处理人
) 

";
    }
}
