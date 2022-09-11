using BN.Application.Contract.Comments;
using System.Collections.Generic;

namespace BN.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void Add(Comment comment);
        void Save();
        IEnumerable<CommentViewModel> All();
        Comment Row(int id);
    }
}
