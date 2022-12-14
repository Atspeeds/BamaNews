using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BN.Application.Contract.News;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Areas.Administrator.Pages
{
    public class NewsModel : PageModel
    {
        private readonly INewsApplication _NewsApplication;

        public NewsModel(INewsApplication newsApplication)
        {
            _NewsApplication = newsApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostCreateNews(CreateNewsViewModel model)
        {
            _NewsApplication.AddNews(model);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostEditNews(EditNewsViewModel model)
        {
            _NewsApplication.EditNews(model);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostActiveNews(int id)
        {
            _NewsApplication.Active(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostRemoveNews(int id)
        {
            _NewsApplication.InActive(id);
            return RedirectToPage("Index");
        }

    }
}
