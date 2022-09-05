using BN.Infrastrure.Query.ViewModels;
using System.Collections.Generic;

namespace BN.Infrastrure.Query.CommentQuery
{
    public interface ICommentQuery
    {
        bool AddComment(CommentView comment);
        IEnumerable<CommentNewsView> AllCommentNews(int newsid);
        void Save();
    }
}
