using BN.Application.Contract.News;
using BN.Domain.NewsAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BN.Infrastrure.EFCore.Repository.NewsRepos
{
    public class NewsRepository : INewsRepository
    {

        private readonly BamaNewsContext _Context;

        public NewsRepository(BamaNewsContext context)
        {
            _Context = context;
        }

        public List<NewsViewModel> All()
        {

            return _Context.News.Include(x => x.NewsCategory)
                  .Select(x => new NewsViewModel()
                  {
                      Id = x.NewsId,
                      Title = x.NewsTitle,
                      Image = x.NewsImage,
                      IsDeleted = x.IsDeleted,
                      NewsCategory = x.NewsCategory.CategoryName,
                      CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)

                  }).AsNoTracking().ToList();
        }

        public void Create(News command)
        {
            _Context.Add(command);
            Save();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
