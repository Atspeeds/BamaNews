using BN.Domain.NewsCategoryAgg;
using FrameWork.Infrastrure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BN.Infrastrure.EFCore.Repository.NewsCategoryRepos
{
    public class NewsCategoryRepository : GenericRepository<int, NewsCategory>, INewsCategoryRepository
    {
        private readonly BamaNewsContext _Context;

        public NewsCategoryRepository(BamaNewsContext context) : base(context)
        {
            _Context = context;
        }



    }
}
