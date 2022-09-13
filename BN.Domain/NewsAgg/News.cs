using BN.Domain.CommentAgg;
using BN.Domain.NewsCategoryAgg;
using FrameWork.Domain;
using System;
using System.Collections.Generic;

namespace BN.Domain.NewsAgg
{
    public class News : DomainBase<int>
    {
        public string NewsTitle { get; private set; }
        public string NewsImage { get; private set; }
        public string NewsShortDescription { get; private set; }
        public string NewsContent { get; private set; }
        public bool IsDeleted { get; private set; }

        //Relation Shipts

        // News To NewsCategory
        public int NewsCategoryId { get; private set; }
        public NewsCategory NewsCategory { get; private set; }

        //News To Comment
        public IEnumerable<Comment> Comments { get; set; }


        protected News()
        {
        }

        public News(string newsTitle, string newsImage, string newsShortDescription, string newsContent, int newsCategoryId)
        {
            NewsTitle = newsTitle;
            NewsImage = newsImage;
            NewsShortDescription = newsShortDescription;
            NewsContent = newsContent;
            NewsCategoryId = newsCategoryId;
            IsDeleted = false;
        }

        public void Edit(string newsTitle, string newsImage, string newsShortDescription, string newsContent, int newsCategoryId)
        {
            NewsTitle = newsTitle;
            NewsImage = newsImage;
            NewsShortDescription = newsShortDescription;
            NewsContent = newsContent;
            NewsCategoryId = newsCategoryId;

        }

        public void Active()
        {
            IsDeleted = false;
        }

        public void InActive()
        {
            IsDeleted = true;
        }


    }
}
