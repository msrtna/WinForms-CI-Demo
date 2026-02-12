using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_CI_Demo.Data;

namespace WinForms_CI_Demo.Repositories
{
    public interface IUserRepository
    {
        bool Exists(string username, string password);
        void Add(User user);
        List<User> GetAll();
        void Delete(int userId);
    }
}
