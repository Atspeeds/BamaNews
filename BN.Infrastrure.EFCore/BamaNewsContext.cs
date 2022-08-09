using BN.Domain.NewsAgg;
using BN.Domain.NewsCategoryAgg;
using BN.Infrastrure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BN.Infrastrure.EFCore
{
    public class BamaNewsContext:DbContext
    {
        public BamaNewsContext(DbContextOptions<BamaNewsContext> options):base(options)
        {

        }


        #region Database Entities
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<News> News { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapping Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NewsCategoryMapping).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
