﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 项目名称和版本控制
{
    public class 项目信息
    {
        public static string 项目组 = "**HOME项目组";
        public static string 项目名称 = "实体类生成工具";
        public static string 项目版本 = "正式版 V 0.0.0.4";


        /****
            { "版本修改描述",
                "正式版 V 0.0.0.0","修改者","时间" },
            //==========================================================
          * */
        public static string[,] 项目历史版本信息 = {
            /**版本修改描述，版本号，修改者，修改时间**/
              { "优化了Mysql对C#的SQL类名称",
                "正式版 V 0.0.0.5","诸迪耀","2018-08-25 13:23:33" },
            //==========================================================  
             { "将SQL语句转存为内存，简化开发工作量",
                "正式版 V 0.0.0.4","罗来飞","2018-08-08 16:50:33" },
            //==========================================================           
 
             { "将SQL语句转存为内存，简化开发工作量",
                "正式版 V 0.0.0.3","诸迪耀","2018-07-30 16:36:33" },
            //==========================================================           
            { "测试和检查项目，发现一些问题",
                "正式版 V 0.0.0.2","诸迪耀","2018-07-24 11:22:33" },
            //==========================================================
            { "新增模块，sqlserver对java，mysql对C#，sqlserver对java",
                "正式版 V 0.0.0.1","罗来飞","2018-07-24 11:22:33" },
            //==========================================================
            { "创建**实体类生成工具项目SQLSERVER对C#的实体类增改查",
                "正式版 V 0.0.0.0","罗来飞","2017-12-01 11:22:33" }
        };



    }
}
