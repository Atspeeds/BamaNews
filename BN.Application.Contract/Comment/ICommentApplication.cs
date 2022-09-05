using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Application.Contract.Comment
{
    public interface ICommentApplication
    {
        void AddComment(CommentViewModel comment);
        IEnumerable<CommentViewModel> SelectAllComment();
    }
}
