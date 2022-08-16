using BN.Domain.NewsCategoryAgg;
using System;

namespace BN.Domain.NewsAgg
{
    public class News
    {
        public int NewsId { get; private set; }
        public string NewsTitle { get; private set; }
        public string NewsImage { get; private set; }
        public string NewsShortDescription { get; private set; }
        public string NewsContent { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; set; }

        //Relation Shipts

        // News To NewsCategory
        public int NewsCategoryId { get; private set; }
        public NewsCategory NewsCategory { get; private set; }


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
            CreationDate = DateTime.Now;
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
