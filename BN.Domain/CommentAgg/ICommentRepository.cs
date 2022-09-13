using BN.Application.Contract.Comments;
using FrameWork.Infrastrure;
using System.Collections.Generic;

namespace BN.Domain.CommentAgg
{
    public interface ICommentRepository: IGenericRepository<int, Comment>
    {
        IEnumerable<CommentViewModel> All();
    }
}
