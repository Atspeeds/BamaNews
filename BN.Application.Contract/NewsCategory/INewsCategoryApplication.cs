using System.Collections.Generic;
using System.Threading.Tasks;

namespace BN.Application.Contract.NewsCategory
{
    public interface INewsCategoryApplication
    {
        List<NewsCategoryViewModel> SelectAll();

    }
}
