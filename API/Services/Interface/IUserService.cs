using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IUserService
    {
        IEnumerable<User> Get();
        User Get(int id);
        int Create(UserVM userVM);
        int Update(int id, UserVM userVM);
        int Delete(int id);
        User Get(UserVM userVM);
    }
}
