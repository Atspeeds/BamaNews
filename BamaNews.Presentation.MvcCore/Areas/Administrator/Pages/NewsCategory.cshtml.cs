using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BN.Application.Contract.NewsCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Areas.Administrator.Pages
{
    public class NewsCategoryModel : PageModel
    {
        private readonly INewsCategoryApplication _newsCategory;

        public NewsCategoryModel(INewsCategoryApplication newsCategory)
        {
            _newsCategory = newsCategory;
        }

        public void OnGet()
        {

        }
        public void OnPostAddNewsCategory(CreateNewCategoryViewModel model)
        {
            _newsCategory.AddNewsCategory(model);
            RedirectToPage("Index");
        }

        public IActionResult OnPostActiveNewsCategory(int id)
        {
            _newsCategory.ActivateNewsCategory(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostRemoveNewsCategory(int id)
        {
            _newsCategory.InActivateNewsCategory(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostEditNewsCategory(NewsCategoryEditViewModel model)
        {
            _newsCategory.EditNewsCategory(new NewsCategoryEditViewModel()
            {
                id = model.id,
                Name = model.Name,
                Description = model.Description
            });
            return RedirectToPage("Index");
        }
    }
}
