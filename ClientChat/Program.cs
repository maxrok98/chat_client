using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login.LoginForm login = new Login.LoginForm();
            Login.Model model = new Login.Model();
            Login.Presenter persenter = new Login.Presenter(login, model);
 
            Application.Run(login);
        }
    }
}
