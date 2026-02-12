using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo
{
    public class Authenticator : IAuthenticator
    {
            public bool Login(string username, string password)
        {
             return username == "a" && password == "1";
        }

        
    }
}
