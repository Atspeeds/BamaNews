using System;

namespace BN.Application.Contract.User
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserAvatar { get; set; }
        public string Passwoard { get; set; }
        public bool IsAdmin { get; set; }

    }
}