using BN.Application;
using BN.Application.Contract.News;
using BN.Application.Contract.NewsCategory;
using BN.Application.Contract.User;
using BN.Application.NewsCategoryApp;
using BN.Domain.NewsAgg;
using BN.Domain.NewsCategoryAgg;
using BN.Domain.UserAgg;
using BN.Infrastrure.EFCore;
using BN.Infrastrure.EFCore.Repository;
using BN.Infrastrure.EFCore.Repository.NewsCategoryRepos;
using BN.Infrastrure.EFCore.Repository.NewsRepos;
using BN.Infrastrure.Query.NewsQuerys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BN.Infrastrure.Core.DependenceIOC
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services, string conconnectiondb)
        {

            #region Repository And Application

            //Category
            services.AddTransient<INewsCategoryApplication, NewsCategoryApplication>();

            services.AddTransient<INewsCategoryRepository, NewsCategoryRepository>();
            //News
            services.AddTransient<INewsApplication, NewsApplication>();

            services.AddTransient<INewsRepository, NewsRepository>();
            //User
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IUserApplication, UserApplication>();

            #endregion


            #region Query View
            services.AddTransient<INewsQuery, NewsQuery>();
            #endregion


            //Send options To Base Class And Use Sql Server
            services.AddDbContext<BamaNewsContext>(options =>
            {
                options.UseSqlServer(conconnectiondb);
            });

        }
    }
}
