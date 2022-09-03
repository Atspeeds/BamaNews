using BN.Domain.UserAgg;
using BN.Infrastrure.EFCore;
using BN.Infrastrure.Query.ViewModels;
using System;
using System.Linq;

namespace BN.Infrastrure.Query.UserQuerys
{
    public class UserQuery : IUserQuery
    {
        private readonly BamaNewsContext _Context;

        public UserQuery(BamaNewsContext Context)
        {
            _Context = Context;
        }

        public bool AddUser(User command)
        {
            try
            {
                _Context.Users.Add(command);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public User SelectUser(LoginView command)
        {
            var user = _Context.Users.SingleOrDefault(x => x.UserName == command.UserName &&
                                          x.Passwoard == command.Password);
            return user;
        }

    }
}
