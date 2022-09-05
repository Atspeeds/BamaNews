using System.Security.Claims;
using BN.Infrastrure.Query.CommentQuery;
using BN.Infrastrure.Query.NewsQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class DetailModel : PageModel
    {

        private readonly INewsQuery _NewsQuery;
        private readonly ICommentQuery _CommentQuery;
        public DetailModel(INewsQuery newsQuery, ICommentQuery commentQuery)
        {
            _NewsQuery = newsQuery;
            _CommentQuery = commentQuery;
        }

        public NewsView NewsModel { get; set; }

        public void OnGet(int id)
        {
            NewsModel = _NewsQuery.SelectRow(id);
        }

        public IActionResult OnPostComment(CommentView comment)
        {
            int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            comment.UserId = userid;
            _CommentQuery.AddComment(comment);
            return RedirectToPage("/Detail", new { id = comment.NewsId });
        }
    }
}
