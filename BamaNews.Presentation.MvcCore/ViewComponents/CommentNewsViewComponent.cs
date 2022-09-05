using BN.Infrastrure.Query.CommentQuery;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamaNews.Presentation.MvcCore.ViewComponents
{
    public class CommentNewsViewComponent : ViewComponent
    {
        private readonly ICommentQuery _CommentQuery;

        public CommentNewsViewComponent(ICommentQuery commentQuery)
        {
            _CommentQuery = commentQuery;
        }

        public IViewComponentResult Invoke(int id)
        {
            var commentnews = _CommentQuery.AllCommentNews(id);
            return View(commentnews);
        }
    }
}
