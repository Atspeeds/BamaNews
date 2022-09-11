using BN.Domain.NewsAgg;
using BN.Domain.UserAgg;
using System;

namespace BN.Domain.CommentAgg
{
    public class Comment
    {
        public int Comment_Id { get; private set; }
        public string TitleComment { get; private set; }
        public string Message { get; private set; }
        public int StatusComment { get; private set; } // new = 0 confirmed = 1 cancelled = 2  
        public DateTime Creationdate { get; private set; }

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
            Creationdate = DateTime.Now;
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
