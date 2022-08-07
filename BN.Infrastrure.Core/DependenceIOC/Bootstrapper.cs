using BN.Application.Contract.NewsCategory;
using BN.Application.NewsCategoryApp;
using BN.Domain.NewsCategoryAgg;
using BN.Infrastrure.EFCore;
using BN.Infrastrure.EFCore.Repository.NewsCategoryRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BN.Infrastrure.Core.DependenceIOC
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services,string conconnectiondb)
        {
 
            services.AddTransient<INewsCategoryApplication, NewsCategoryApplication>();

            services.AddTransient<INewsCategoryRepository, NewsCategoryRepository>();

            //Send options To Base Class And Use Sql Server
            services.AddDbContext<BamaNewsContext>(options =>
            {
                options.UseSqlServer(conconnectiondb);
            });
        } 
    }
}
