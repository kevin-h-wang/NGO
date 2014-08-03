using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Founder.FIS.CMD.Tool.UI
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
            //DirectPage loginForm = new DirectPage();
            //loginForm.ShowDialog();
            //if (loginForm.DialogResult == DialogResult.OK)
            //{
            //    loginForm.Dispose();
            Application.Run(new DirectPage());
            //}
        }
    }
}
