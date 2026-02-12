using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_CI_Demo.Applications;
using WinForms_CI_Demo.Authenticates;
using WinForms_CI_Demo.Data;
using WinForms_CI_Demo.Forms;
using WinForms_CI_Demo.Repositories;
using WinForms_CI_Demo.Services;

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
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                db.Seed();
            }

            IUserRepository userRepo = new SqlUserRepository();
            IAuthenticator auth = new Authenticator(userRepo);
            ILoginService loginService = new LoginService(auth);
            UserManagementService userService = new UserManagementService(userRepo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin(loginService);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain(userService));
            }
        }
    }
}
