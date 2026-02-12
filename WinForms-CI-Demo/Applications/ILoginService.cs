using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo.Applications
{
    public interface ILoginService
    {
        bool Login(string username, string password);
    }
}
