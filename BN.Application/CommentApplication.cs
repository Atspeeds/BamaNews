using BN.Application.Contract.Comments;
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

        public void CommentCancelled(int id)
        {
            var comment = SelectRowComment(id);
            comment.cancelled();
            _CommentRepository.Save();
        }

        public void CommentConfirmed(int id)
        {
            var comment = SelectRowComment(id);
            comment.confirmed();
            _CommentRepository.Save();

        }

        public IEnumerable<CommentViewModel> SelectAllComment()
        {
            return _CommentRepository.All();
        }


        public Comment SelectRowComment(int id)
        {
            return _CommentRepository.Row(id);
        }


    }
}
