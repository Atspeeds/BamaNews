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
        public User SelectUser(LoginView command)
        {
            var user = _Context.Users.SingleOrDefault(x => x.UserName == command.UserName &&
                                          x.Passwoard == command.Password);
            return user;
        }

    }
}
