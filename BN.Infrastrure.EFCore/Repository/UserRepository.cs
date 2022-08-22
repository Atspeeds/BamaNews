using BN.Application.Contract.User;
using BN.Domain.UserAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Infrastrure.EFCore.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BamaNewsContext _NewsContext;

        public UserRepository(BamaNewsContext NewsContext)
        {
            _NewsContext = NewsContext;
        }


        public IEnumerable<UserViewModel> All()
        {
            return _NewsContext.Users.Select(x => new UserViewModel()
            {
                UserId=x.User_Id,
                UserName=x.UserName,
                CreationDate=x.CreationDate,
                Email=x.Email,
                Passwoard=x.Passwoard,
                UserAvatar=x.UserAvatar,
                UserRole=x.UserRole,
                IsAdmin=x.IsAdmin
            }).AsNoTracking().ToList();
        }



    }
}
