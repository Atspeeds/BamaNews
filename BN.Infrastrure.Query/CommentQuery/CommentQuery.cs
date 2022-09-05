using BN.Domain.CommentAgg;
using BN.Infrastrure.EFCore;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BN.Infrastrure.Query.CommentQuery
{
    public class CommentQuery : ICommentQuery
    {
        private readonly BamaNewsContext _Context;

        public CommentQuery(BamaNewsContext Context)
        {
            _Context = Context;
        }

        public bool AddComment(CommentView comment)
        {
            try
            {
                _Context.Comments.Add(new Comment(comment.Title, comment.Message,
                                     comment.NewsId, comment.UserId));
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<CommentNewsView> AllCommentNews(int newsid)
        {
            return _Context.Comments.Include(u => u.Users)
                .Where(z => z.NewsId == newsid &&
                 z.StatusComment == Status.confirmed)
            .Select(x => new CommentNewsView()
            {
                Title = x.TitleComment,
                Message = x.Message,
                CreationDate = x.Creationdate.ToString(),
                UserName = x.Users.UserName,
            }).ToList();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

    }
}
