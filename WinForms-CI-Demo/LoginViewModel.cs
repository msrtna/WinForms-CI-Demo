using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo
{
    public class LoginViewModel
    {
        private readonly ILoginService _loginService;
        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public bool Login(string username, string password)
        {
            return _loginService.ValidateUser(username, password);
        }
    }
}
