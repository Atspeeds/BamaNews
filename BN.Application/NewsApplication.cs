using BN.Application.Contract.News;
using BN.Domain.NewsAgg;
using FrameWork.Infrastrure;
using System.Collections.Generic;

namespace BN.Application
{
    public class NewsApplication : INewsApplication
    {
        private readonly INewsRepository _NewsRepository;

        private readonly IUnitOfWork _UnitOfWork;

        public NewsApplication(INewsRepository newsRepository, IUnitOfWork unitofwork)
        {
            _NewsRepository = newsRepository;
            _UnitOfWork = unitofwork;
        }

        public void Active(int id)
        {
            _UnitOfWork.BeginTran();
            var news = _NewsRepository.GetT(id);
            news.Active();
            _UnitOfWork.CommitTran();
        }

        public void AddNews(CreateNewsViewModel command)
        {
            _UnitOfWork.BeginTran();
            var news = new News(command.Title, command.Image, command.ShortDescription,
               command.Content, command.NewsCategoryId);
            _NewsRepository.CreateT(news);
            _UnitOfWork.CommitTran();
        }

        public void EditNews(EditNewsViewModel command)
        {
            _UnitOfWork.BeginTran();
            var news = _NewsRepository.GetT(command.Id);
            news.Edit(command.Title, command.Image, command.ShortDescription,
                command.Content, command.NewsCategoryId);
            _UnitOfWork.CommitTran();
        }

        public void InActive(int id)
        {
            _UnitOfWork.BeginTran();
            var news = _NewsRepository.GetT(id);
            news.InActive();
            _UnitOfWork.CommitTran();
        }

        public IList<NewsViewModel> SelectAllNews()
        {
            return _NewsRepository.All();
        }


    }
}
