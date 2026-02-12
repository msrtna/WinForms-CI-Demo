using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_CI_Demo.Authenticates;

namespace WinForms_CI_Demo.Applications
{
    public class LoginService : ILoginService
    {
        private readonly IAuthenticator _authenticator;

        public LoginService(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }
        public bool Login(string username, string password)
        {
            return _authenticator.Login(username, password);
        }
    }
}
