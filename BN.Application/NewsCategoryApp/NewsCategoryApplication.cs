using BN.Application.Contract.NewsCategory;
using BN.Domain.NewsCategoryAgg;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BN.Application.NewsCategoryApp
{
    public class NewsCategoryApplication : INewsCategoryApplication
    {
        private readonly INewsCategoryRepository _NewsCategoryRepository;

        public NewsCategoryApplication(INewsCategoryRepository newsCategoryRepository)
        {
            _NewsCategoryRepository = newsCategoryRepository;
        }


        public void ActivateNewsCategory(int id)
        {
            var newscategory = _NewsCategoryRepository.Row(id);
            newscategory.Active();
            _NewsCategoryRepository.Save();

        }


        public bool EditNewsCategory(NewsCategoryEditViewModel command)
        {
            try
            {
                var newscategory = _NewsCategoryRepository.Row(command.id);
                newscategory.Edit(command.Name,command.Description);
                _NewsCategoryRepository.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void InActivateNewsCategory(int id)
        {
            var newscategory = _NewsCategoryRepository.Row(id);
            newscategory.InActive();
            _NewsCategoryRepository.Save();
        }


        public List<NewsCategoryViewModel> SelectAllNewsCategory()
        {
            var AllNewsCategory = _NewsCategoryRepository.All();

            var newscategorys = new List<NewsCategoryViewModel>();

            foreach (var item in AllNewsCategory)
            {
                newscategorys.Add(new NewsCategoryViewModel()
                {
                    Id = item.CategoryId,
                    Name = item.CategoryName,
                    Description = item.Description,
                    IsDeleted = item.IsDeleted
                });
            }

            return newscategorys.OrderBy(x => x.Id).ToList();
        }


    }
}
