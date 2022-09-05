using BN.Application.Contract.Comment;
using System.Collections.Generic;

namespace BN.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void Add(Comment comment);
        void Save();
        IEnumerable<CommentViewModel> All();
    }
}
