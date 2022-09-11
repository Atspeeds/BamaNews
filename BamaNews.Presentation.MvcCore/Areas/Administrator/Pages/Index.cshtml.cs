using BN.Application.Contract.Comments;
using BN.Application.Contract.NewsCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Onion.Presentation.Areas.Administrator.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ICommentApplication _CommentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _CommentApplication = commentApplication;
        }

        public void OnGet()
        {

        }

        public void OnPostConfirmed(int id)
        {
            _CommentApplication.CommentConfirmed(id);
        }

        public void OnPostCancelled(int id)
        {
            _CommentApplication.CommentCancelled(id);
        }

    }

}
