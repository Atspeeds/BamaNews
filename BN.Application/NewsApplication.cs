﻿using BN.Application.Contract.News;
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

        public void Active(int id)
        {
            var news = _NewsRepository.SelectRow(id);
            news.Active();
            _NewsRepository.Save();
        }

        public void AddNews(CreateNewsViewModel command)
        {
            var news = new News(command.Title,command.Image,command.ShortDescription,
               command.Content,command.NewsCategoryId);
            _NewsRepository.Create(news);
        }

        public void EditNews(EditNewsViewModel command)
        {
            var news = _NewsRepository.SelectRow(command.Id);
            news.Edit(command.Title,command.Image,command.ShortDescription,
                command.Content,command.NewsCategoryId);
            _NewsRepository.Save();
        }

        public void InActive(int id)
        {
            var news = _NewsRepository.SelectRow(id);
            news.InActive();
            _NewsRepository.Save();
        }

        public IList<NewsViewModel> SelectAllNews()
        {
            return _NewsRepository.All();
        }


    }
}
