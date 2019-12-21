using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> Get();
        User Get(int id);
        int Create(UserVM userVM);
        int Update(int id, UserVM userVM);
        int Delete(int id);
        User Get(UserVM userVM);

    }
}
