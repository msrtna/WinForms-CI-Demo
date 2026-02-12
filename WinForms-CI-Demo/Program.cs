using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_CI_Demo.Applications;
using WinForms_CI_Demo.Domain;

namespace WinForms_CI_Demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUserRepository repository = new FakeUserRepository();
            IAuthenticator authenticator = new Authenticator(repository);
            ILoginService loginService = new LoginService(authenticator);
            Application.Run(new frmLogin(loginService));
        }
    }
}
