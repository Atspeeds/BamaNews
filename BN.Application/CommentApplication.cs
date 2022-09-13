using BN.Application.Contract.Comments;
using BN.Domain.CommentAgg;
using FrameWork.Infrastrure;
using System.Collections.Generic;

namespace BN.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _CommentRepository;

        private readonly IUnitOfWork _UnitOfWork;
        public CommentApplication(ICommentRepository commentRepository, IUnitOfWork unitofwork)
        {
            _CommentRepository = commentRepository;
            _UnitOfWork = unitofwork;
        }

        public void AddComment(CommentViewModel comment)
        {
            _UnitOfWork.BeginTran();
            _CommentRepository.CreateT(new Comment(comment.Title, comment.Message,
                                    comment.NewsId, comment.UserId));
            _UnitOfWork.CommitTran();
        }

        public void CommentCancelled(int id)
        {
            _UnitOfWork.BeginTran();
            var comment = SelectRowComment(id);
            comment.cancelled();
            _UnitOfWork.CommitTran();
        }

        public void CommentConfirmed(int id)
        {
            _UnitOfWork.BeginTran();
            var comment = SelectRowComment(id);
            comment.confirmed();
            _UnitOfWork.CommitTran();
        }

        public IEnumerable<CommentViewModel> SelectAllComment()
        {
            return _CommentRepository.All();
        }


        public Comment SelectRowComment(int id)
        {
            return _CommentRepository.GetT(id);
        }


    }
}
