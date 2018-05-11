using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MTPsys
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
            new Form1().Show();
            //new Main(true).Show();
            //new Main_New().Show();
            //new Profile().Show();
            //new Main_Open().Show();
            /*界面设计信息
             * Form1登陆界面
             * Main 主界面
             * Profile用户登陆信息管理界面
             * Main_New主界面新建界面
             * Main_Edit主界面修改界面
             * Main_Oprn打开界面：军人体能考核标准
             * New_Inport引入单位界面
             * Open_Add增加界面
             * Open_Edit修改界面
             */
            //new Form1().Show();
            Application.Run();
        }
    }
}
