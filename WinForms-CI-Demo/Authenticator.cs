using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_CI_Demo.Domain;

namespace WinForms_CI_Demo
{
    public class Authenticator : IAuthenticator
    {
        private IUserRepository _userRepository;
        public Authenticator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool Login(string username, string password)
        {
            return _userRepository.Exists(username, password);
        }
    }
}
