using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_CI_Demo.Repositories
{
    public interface IUserRepository
    {
        bool Exists(string username, string password);
    }
}
