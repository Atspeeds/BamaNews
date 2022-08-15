using BN.Application.Contract.NewsCategory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class NewsCategoryAllViewComponent : ViewComponent
    {
        private readonly INewsCategoryApplication _newsCategory;

        public NewsCategoryAllViewComponent(INewsCategoryApplication newsCategory)
        {
            _newsCategory = newsCategory;
        }

        public IViewComponentResult Invoke()
        {
            var newscategoryModel = _newsCategory.SelectAllNewsCategory();
            return View(newscategoryModel);
        }
    }
}
