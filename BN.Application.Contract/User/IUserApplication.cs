using System.Collections.Generic;

namespace BN.Application.Contract.User
{
    public interface IUserApplication
    {
        IEnumerable<UserViewModel> SelectAll();
    }
}
