using BN.Application.Contract.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Domain.UserAgg
{
    public interface IUserRepository
    {
        IEnumerable<UserViewModel> All();
    }
}
