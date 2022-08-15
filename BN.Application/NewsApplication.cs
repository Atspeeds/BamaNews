using BN.Application.Contract.News;
using BN.Domain.NewsAgg;
using System.Collections.Generic;

namespace BN.Application
{
    public class NewsApplication : INewsApplication
    {
        private readonly INewsRepository _NewsRepository;

        public NewsApplication(INewsRepository newsRepository)
        {
            _NewsRepository = newsRepository;
        }

        public void AddNews(CreateNewsViewModel command)
        {
            var news = new News(command.Title,command.Image,command.ShortDescription,
               command.Content,command.NewsCategoryId);
            _NewsRepository.Create(news);
        }

        public IList<NewsViewModel> SelectAllNews()
        {
            return _NewsRepository.All();
        }

    }
}
