using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo.Domain
{
    public interface IUserRepository
    {
        bool Exists(string username, string password);
    }
}
