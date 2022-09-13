using BN.Application.Contract.User;
using BN.Domain.UserAgg;
using System.Collections.Generic;

namespace BN.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserRepository _UserRepository;

        public UserApplication(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public IEnumerable<UserViewModel> SelectAll()
        {
            return _UserRepository.All();
        }

    }
}
