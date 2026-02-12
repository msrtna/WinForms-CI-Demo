using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_CI_Demo.Data;

namespace WinForms_CI_Demo.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public SqlUserRepository()
        {
            _context = new AppDbContext();
        }
        public bool Exists(string username, string password)
        {
            return _context.Users.Any(auth=> auth.Username == username && auth.Password == password);
        }
    }
}
