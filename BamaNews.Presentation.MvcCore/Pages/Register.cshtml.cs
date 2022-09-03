using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BN.Domain.UserAgg;
using BN.Infrastrure.Query.UserQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserQuery _Query;

        public RegisterModel(IUserQuery query)
        {
            _Query = query;
        }

        //[BindProperty]
        //public RegisterView RegisterMD { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(RegisterView RegisterMD)
        {
            
            _Query.AddUser(new User(RegisterMD.UserName, RegisterMD.Email, "Default", RegisterMD.Password));
            return Redirect("/User");
        }
    }
}
