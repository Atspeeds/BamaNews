using System.Collections.Generic;
using BN.Infrastrure.Query.NewsQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class NewsModel : PageModel
    {
        private readonly INewsQuery _newsQuery;

        public NewsModel(INewsQuery newsQuery)
        {
            _newsQuery = newsQuery;
        }
        public  IEnumerable<NewsView> NewsModels { get; set; }

        public void OnGet()
        {
            NewsModels = _newsQuery.GetAll();
        }
    }
}
