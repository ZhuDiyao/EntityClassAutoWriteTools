using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 工具
{
    public class 文件写出
    {
        /// <summary>
        /// 传入字符串
        /// </summary>
        public static void Write4string(string FilePath, string str)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            //获得字节数组
            byte[] data = Encoding.UTF8.GetBytes(str);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
    }
}
