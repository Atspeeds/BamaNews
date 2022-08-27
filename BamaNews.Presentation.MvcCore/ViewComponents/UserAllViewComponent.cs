using BN.Application.Contract.User;
using Microsoft.AspNetCore.Mvc;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class UserAllViewComponent: ViewComponent
    {
        private readonly IUserApplication _UserApplication;

        public UserAllViewComponent(IUserApplication userApplication)
        {
            _UserApplication = userApplication;
        }

        public IViewComponentResult Invoke()
        {
            var newsModel = _UserApplication.SelectAll();
            return View(newsModel);
        }
    }
}
