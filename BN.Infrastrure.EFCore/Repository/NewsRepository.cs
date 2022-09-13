using BN.Application.Contract.News;
using BN.Domain.CommentAgg;
using BN.Domain.NewsAgg;
using BN.Infrastrure.Query;
using FrameWork.Infrastrure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BN.Infrastrure.EFCore.Repository.NewsRepos
{
    public class NewsRepository : GenericRepository<int, News>, INewsRepository
    {

        private readonly BamaNewsContext _Context;

        public NewsRepository(BamaNewsContext context):base(context)
        {
            _Context = context;
        }

        public List<NewsViewModel> All()
        {

            return _Context.News.Include(x => x.NewsCategory)
                  .Select(x => new NewsViewModel()
                  {
                      Id = x.Id,
                      Title = x.NewsTitle,
                      Image = x.NewsImage,
                      IsDeleted = x.IsDeleted,
                      NewsCategory = x.NewsCategory.CategoryName,
                      CreationDate = x.Creationdate.Toshamsi(),
                      ShortDescription=x.NewsShortDescription,
                      Content=x.NewsContent

                  }).AsNoTracking().ToList();
        }

    }
}
