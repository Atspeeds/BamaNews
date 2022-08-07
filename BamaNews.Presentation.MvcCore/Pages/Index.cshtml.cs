using BN.Application.Contract.NewsCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly INewsCategoryApplication _NewsCategory;

        public IndexModel(INewsCategoryApplication newsCategory)
        {
            _NewsCategory = newsCategory;
        }

        public List<NewsCategoryViewModel> NewsCategoriesModel;

        public void OnGet()
        {
            NewsCategoriesModel = _NewsCategory.SelectAll();
        }
    }
}
