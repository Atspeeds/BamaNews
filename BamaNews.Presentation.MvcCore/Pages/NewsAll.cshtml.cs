using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BN.Infrastrure.Query.NewsQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class NewsAllModel : PageModel
    {

        private readonly INewsQuery _newsQuery;

        public NewsAllModel(INewsQuery newsQuery)
        {
            _newsQuery = newsQuery;
        }
        public IEnumerable<NewsView> NewsModels { get; set; }

        public void OnGet()
        {
            NewsModels = _newsQuery.GetAll();
        }
    }
}
