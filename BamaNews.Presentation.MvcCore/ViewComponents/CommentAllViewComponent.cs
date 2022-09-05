using BN.Application.Contract.Comment;
using BN.Infrastrure.Query.NewsQuerys;
using Microsoft.AspNetCore.Mvc;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class CommentAllViewComponent : ViewComponent
    {
        private readonly ICommentApplication _CommentApplication;

        public CommentAllViewComponent(ICommentApplication commentApplication)
        {
            _CommentApplication = commentApplication;
        }

        public IViewComponentResult Invoke()
        {
            var commentModel = _CommentApplication.SelectAllComment();
            return View(commentModel);
        }

    }
}
