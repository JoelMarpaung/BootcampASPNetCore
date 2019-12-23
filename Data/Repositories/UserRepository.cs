using Data.Context;
using Data.Models;
using Data.Repositories.Interface;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        MyContext myContext = new MyContext();
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
            return myContext.Users.ToList();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(UserVM userVM)
        {
            //return myContext.Users.Where(u => u.Email == userVM.Email && u.Password == userVM.Password && u.IsDelete==false).FirstOrDefault();
            //return myContext.Users.FromSql($"CALL GetUserLogin {userVM.Email} {userVM.Password}").FirstOrDefault();
            //return myContext.Users.FromSql("Call GetUserLogin @p0, @p1", parameters: new[] { userVM.Email, userVM.Password }).FirstOrDefault();
            return myContext.Users.FromSql("Call GetUserLogin @p0, @p1", parameters: new[] { userVM.Email, userVM.Password }).FirstOrDefault();
        }

        public int Update(int id, UserVM userVM)
        {
            throw new NotImplementedException();
        }
    }
}
