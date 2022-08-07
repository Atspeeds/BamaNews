using BN.Application.Contract.NewsCategory;
using BN.Domain.NewsCategoryAgg;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BN.Application.NewsCategoryApp
{
    public class NewsCategoryApplication: INewsCategoryApplication
    {
        private readonly INewsCategoryRepository _NewsCategoryRepository;

        public NewsCategoryApplication(INewsCategoryRepository newsCategoryRepository)
        {
            _NewsCategoryRepository = newsCategoryRepository;
        }

        public List<NewsCategoryViewModel> SelectAll()
        {
            var AllNewsCategory =  _NewsCategoryRepository.All();

            var newscategorys = new List<NewsCategoryViewModel>();

            foreach (var item in AllNewsCategory)
            {
                newscategorys.Add(new NewsCategoryViewModel()
                {
                    Id=item.CategoryId,
                    Name=item.CategoryName,
                    Description=item.Description,
                    IsDeleted=item.IsDeleted
                });
            }

            return newscategorys.OrderBy(x => x.Id).ToList();
        }

    }
}
