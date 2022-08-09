using System.Collections.Generic;
using System.Threading.Tasks;

namespace BN.Application.Contract.NewsCategory
{
    public interface INewsCategoryApplication
    {
        List<NewsCategoryViewModel> SelectAllNewsCategory();
        void ActivateNewsCategory(int id);
        void InActivateNewsCategory(int id);
        bool EditNewsCategory(NewsCategoryEditViewModel command);
        bool AddNewsCategory(CreateNewCategoryViewModel command);
    }
}
