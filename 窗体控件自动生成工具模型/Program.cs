using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 窗体控件自动生成工具模型
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
