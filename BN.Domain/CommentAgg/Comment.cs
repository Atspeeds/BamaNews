using BN.Domain.NewsAgg;
using BN.Domain.UserAgg;
using FrameWork.Domain;
using System;

namespace BN.Domain.CommentAgg
{
    public class Comment : DomainBase<int>
    {
        public string TitleComment { get; private set; }
        public string Message { get; private set; }
        public int StatusComment { get; private set; } // new = 0 confirmed = 1 cancelled = 2  


        //Relation Shipts

        //Comment To News
        public int NewsId { get; private set; }
        public News News { get; private set; }

        //Comment To User
        public int UserId { get; private set; }
        public User Users { get; private set; }

        protected Comment()
        {
        }

        public Comment(string titleComment, string message, int newsId, int userId)
        {
            TitleComment = titleComment;
            Message = message;
            NewsId = newsId;
            UserId = userId;
            StatusComment = Status.NewComment;
        }

        public void confirmed()
        {
            this.StatusComment = Status.confirmed;
        }

        public void cancelled()
        {
            this.StatusComment = Status.cancelled;
        }


    }
}
