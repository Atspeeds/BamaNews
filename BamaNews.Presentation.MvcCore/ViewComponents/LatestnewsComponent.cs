using BN.Infrastrure.Query.NewsQuerys;
using Microsoft.AspNetCore.Mvc;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class Latestnews : ViewComponent
    {
        private readonly INewsQuery _NewsQuery;

        public Latestnews(INewsQuery newsQuery)
        {
            _NewsQuery = newsQuery;
        }

        public IViewComponentResult Invoke()
        {  
            return View(_NewsQuery.GetNewest());
        }

    }
}
