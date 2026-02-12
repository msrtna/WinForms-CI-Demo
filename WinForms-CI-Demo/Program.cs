using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_CI_Demo.Applications;
using WinForms_CI_Demo.Authenticates;
using WinForms_CI_Demo.Forms;
using WinForms_CI_Demo.Repositories;

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

            using (var db = new Data.AppDbContext())
            {
                db.Database.EnsureCreated();
                db.Seed();
            }

            IUserRepository repository = new SqlUserRepository();
            IAuthenticator authenticator = new Authenticator(repository);
            ILoginService loginService = new LoginService(authenticator);

            Application.Run(new frmLogin(loginService));
        }
    }
}
