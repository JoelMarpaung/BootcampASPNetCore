using API.Services.Interface;
using Data.Models;
using Data.Repositories;
using Data.Repositories.Interface;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository userRepository = new UserRepository();
        public UserService() { }
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public int Create(UserVM userVM)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            return userRepository.Get();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(UserVM userVM)
        {
            return userRepository.Get(userVM);
        }

        public int Update(int id, UserVM userVM)
        {
            throw new NotImplementedException();
        }
    }
}
