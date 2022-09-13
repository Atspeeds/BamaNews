using BN.Application.Contract.News;
using FrameWork.Infrastrure;
using System.Collections.Generic;

namespace BN.Domain.NewsAgg
{
    public interface INewsRepository : IGenericRepository<int, News>
    {
        List<NewsViewModel> All();
    }
}
