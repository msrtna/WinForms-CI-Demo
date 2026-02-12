using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_CI_Demo.Repositories;

namespace WinForms_CI_Demo.Services
{
    public class UserManagementService
    {
        private readonly IUserRepository _userRepo;

        public UserManagementService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public bool AddUser(string username, string password)
        {
            if (_userRepo.Exists(username, password))
                return false;

            _userRepo.Add(new Data.User { Username = username, Password = password });
            return true;
        }

        public List<Data.User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public void DeleteUser(int userId)
        {
            _userRepo.Delete(userId);
        }
    }
}
