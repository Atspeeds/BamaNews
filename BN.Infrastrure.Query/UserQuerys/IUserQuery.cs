using BN.Domain.UserAgg;
using BN.Infrastrure.Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Infrastrure.Query.UserQuerys
{
    public interface IUserQuery
    {
        User SelectUser(LoginView command);

    }
}
