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
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Delete(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
