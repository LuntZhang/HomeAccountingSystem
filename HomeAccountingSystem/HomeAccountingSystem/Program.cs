using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAccountingSystem.AccountManagement;

namespace HomeAccountingSystem
{
    static class Program
    {
        public static LoginForm m_LoginForm = null;

        public static MainForm m_MainForm = null;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_LoginForm = new LoginForm();
            m_MainForm = new MainForm();
            Application.Run(m_LoginForm);
            //Application.Run(new SpendingAccountsForm());
        }
    }
}
