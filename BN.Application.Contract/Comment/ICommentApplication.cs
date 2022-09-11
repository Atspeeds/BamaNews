using System.Collections.Generic;

namespace BN.Application.Contract.Comments
{
    public interface ICommentApplication
    {
        void AddComment(CommentViewModel comment);
        IEnumerable<CommentViewModel> SelectAllComment();
        void CommentConfirmed(int id);
        void CommentCancelled(int id);


    }
}
