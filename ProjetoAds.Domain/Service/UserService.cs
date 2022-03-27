using ProjetoAds.Domain.Entities;
using ProjetoAds.Domain.Repository;
using ProjetoAds.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAds.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get(long id)
        {
            return _userRepository.Get(id);
        }

        public User Get(string username, string password)
        {
            return _userRepository.Get(username, password);
        }

        public void Insert(User user)
        {
            _userRepository.Insert(user);
        }
    }
}
