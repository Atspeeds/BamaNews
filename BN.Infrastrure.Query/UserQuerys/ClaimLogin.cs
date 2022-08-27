using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BN.Domain.UserAgg;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace BN.Infrastrure.Query.UserQuerys
{
    [Obsolete]
    public class ClaimLogin
    {
        public static void Cliaims(LoginView loginview, User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.User_Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("IsAdmin", user.IsAdmin.ToString()),
                // new Claim("CodeMeli", user.Email),

            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            //var properties = new AuthenticationProperties
            //{
            //    IsPersistent = loginview.RememberMe
            //};

           

        }
    }
}
