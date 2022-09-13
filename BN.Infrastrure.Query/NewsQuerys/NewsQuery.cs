using BN.Infrastrure.EFCore;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BN.Infrastrure.Query.NewsQuerys
{
    public class NewsQuery : INewsQuery
    {
        private readonly BamaNewsContext _Context;

        public NewsQuery(BamaNewsContext Context)
        {
            _Context = Context;
        }

        public List<NewsView> GetAll()
        {

            var result = _Context.News.Include(c => c.NewsCategory)
                  .Select(x => new NewsView()
                  {
                      Id = x.Id,
                      Title = x.NewsTitle,
                      Image = x.NewsImage,
                      NewsCategory = x.NewsCategory.CategoryName,
                      Content = x.NewsContent,
                      CreationDate = x.Creationdate.Toshamsi(),
                      ShortDescription = x.NewsShortDescription
                  }).OrderBy(x => x.CreationDate).AsNoTracking();

            return result.ToList();
        }

        public List<NewsView> GetNewest()
        {
            var result = _Context.News.Include(c => c.NewsCategory)
                 .Select(x => new NewsView()
                 {
                     Id = x.Id,
                     Title = x.NewsTitle,
                     Image = x.NewsImage,
                     NewsCategory = x.NewsCategory.CategoryName,
                     Content = x.NewsContent,
                     CreationDate = x.Creationdate.ToString(),
                     ShortDescription = x.NewsShortDescription
                 }).OrderBy(x => x.CreationDate).AsNoTracking();

            return result.Take(6).ToList();

        }

        public NewsView SelectRow(int id)
        {
            var result = _Context.News.Include(c=>c.NewsCategory)
                .SingleOrDefault(x => x.Id == id);
                
            return new NewsView()
            {
                Id=result.Id,
                Title=result.NewsTitle,
                Content=result.NewsContent,
                CreationDate=result.Creationdate.Toshamsi(),
                Image=result.NewsImage,
                ShortDescription=result.NewsShortDescription,
                NewsCategory=result.NewsCategory.CategoryName
            };
        }

    }
}
