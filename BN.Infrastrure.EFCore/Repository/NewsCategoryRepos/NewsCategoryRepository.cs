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

        public List<NewsCategory> All()
        {
            return _Context.NewsCategories.AsNoTracking().ToList();
        }

        public NewsCategory Row(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
