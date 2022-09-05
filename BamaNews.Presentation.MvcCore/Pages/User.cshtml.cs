using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using BN.Infrastrure.Query;
using BN.Infrastrure.Query.UserQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class UserModel : PageModel
    {


        private readonly IUserQuery _Query;

        public UserModel(IUserQuery query)
        {
            _Query = query;
        }


        public void OnGet()
        {
        }

        public IActionResult OnPostLogin(LoginView login)
        {
            var user = _Query.SelectUser(new LoginView()
            {
                UserName = login.UserName,
                Password = login.Password
            });
            if (user == null)
            {
                return Redirect("/User");
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.User_Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("IsAdmin", user.IsAdmin.ToString()),
                new Claim("UserId", user.User_Id.ToString()),
                // new Claim("CodeMeli", user.Email),

            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties
            {
                IsPersistent = login.RememberMe
            };

            HttpContext.SignInAsync(principal, properties);
            return Redirect("/");
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await AuthenticationHttpContextExtensions.SignOutAsync(HttpContext, CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/"); ;
           
        }

      
    }
}
