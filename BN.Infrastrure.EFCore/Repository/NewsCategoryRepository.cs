using BN.Domain.NewsCategoryAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BN.Infrastrure.EFCore.Repository.NewsCategoryRepos
{
    public class NewsCategoryRepository : INewsCategoryRepository
    {
        private readonly BamaNewsContext _Context;

        public NewsCategoryRepository(BamaNewsContext context)
        {
            _Context = context;
        }

        public void Add(NewsCategory command)
        {
            _Context.Add(command);
            _Context.SaveChanges();
        }

        public List<NewsCategory> All()
        {
            return _Context.NewsCategories.AsNoTracking().ToList();
        }

        public NewsCategory Row(int id)
        {
            return _Context.NewsCategories.FirstOrDefault(x=>x.CategoryId==id);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
