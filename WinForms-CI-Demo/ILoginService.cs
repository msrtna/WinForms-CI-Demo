using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo
{
    public interface ILoginService
    {
        bool ValidateUser(string username, string password);
    }
}
