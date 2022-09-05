namespace BN.Application.Contract.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Message { get; set; }
        public int StatusComment { get; set; }
        public string CreationDate { get; set; }
        public string UserName { get; set; }
        public string NewsTitle { get; set; }
        public int UserId { get; set; }
        public int NewsId { get; set; }

    }
}