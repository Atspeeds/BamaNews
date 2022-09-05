using BN.Application.Contract.Comment;
using BN.Domain.CommentAgg;
using System.Collections.Generic;

namespace BN.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _CommentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _CommentRepository = commentRepository;
        }

        public void AddComment(CommentViewModel comment)
        {
            _CommentRepository.Add(new Comment(comment.Title,comment.Message,
                                    comment.NewsId,comment.UserId));
        }

        public IEnumerable<CommentViewModel> SelectAllComment()
        {
            return _CommentRepository.All();
        }

    }
}
