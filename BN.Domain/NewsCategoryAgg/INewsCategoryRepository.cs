using System.Collections.Generic;
using System.Threading.Tasks;

namespace BN.Domain.NewsCategoryAgg
{
    public interface INewsCategoryRepository
    {
        List<NewsCategory> All();
        NewsCategory Row(int id);
        void Add(NewsCategory command);
        void Save();
    }
}
