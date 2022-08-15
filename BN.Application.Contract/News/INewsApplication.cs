using System.Collections.Generic;

namespace BN.Application.Contract.News
{
    public interface INewsApplication
    {
        IList<NewsViewModel> SelectAllNews();
        void AddNews(CreateNewsViewModel command);
        void EditNews(EditNewsViewModel command);
        void Active(int id);
        void InActive(int id);

    }
}
