using BN.Domain.NewsAgg;
using FrameWork.Domain;
using System.Collections.Generic;

namespace BN.Domain.NewsCategoryAgg
{
    public class NewsCategory : DomainBase<int>
    {
        public string CategoryName { get; private set; }
        public string Description { get; private set; }
        public bool IsDeleted { get; private set; }

        //Relation Shipts

        // NewsCategory To News
        public ICollection<News> News { get; private set; }

        protected NewsCategory()
        {
        }

        public NewsCategory(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
            IsDeleted = false;
        }

        public void Edit(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
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
