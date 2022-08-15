using BN.Application.Contract.News;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class NewsAllViewComponent : ViewComponent
    {
        private readonly INewsApplication _NewsApplication;

        public NewsAllViewComponent(INewsApplication newsApplication)
        {
            _NewsApplication = newsApplication;
        }

        public IViewComponentResult Invoke()
        {
            var newsModel = _NewsApplication.SelectAllNews();
            return View(newsModel);
        }
    }
}
