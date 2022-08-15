using System.Collections.Generic;

namespace BN.Application.Contract.News
{
    public interface INewsApplication
    {
        IList<NewsViewModel> SelectAllNews();
        void AddNews(CreateNewsViewModel command);

    }
}
