using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo.Domain
{
    public class FakeUserRepository : IUserRepository
    {
        public bool Exists(string username, string password)
        {
            if (username == "a" && password == "1")
                return true;
            else
                return false;
        }
    }
}
