using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
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
            FileHelper.CreateFile(Application.StartupPath + "\\SysLog.txt");
            FileHelper.CreateFile(Application.StartupPath + "\\Config.txt");
            FileHelper.CreateFile(Application.StartupPath + "\\ConfigUnit.txt");
            
            Application.Run(new FormLogin());
        }
    }
}
