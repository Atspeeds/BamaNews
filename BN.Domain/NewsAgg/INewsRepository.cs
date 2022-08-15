using BN.Application.Contract.News;
using System.Collections.Generic;

namespace BN.Domain.NewsAgg
{
    public interface INewsRepository
    {
        List<NewsViewModel> All();
        void Create(News command);
        void Save();
        News SelectRow(int id);
    }
}
