using BN.Application.Contract.NewsCategory;
using BN.Domain.NewsCategoryAgg;
using FrameWork.Infrastrure;
using System.Collections.Generic;
using System.Linq;

namespace BN.Application.NewsCategoryApp
{
    public class NewsCategoryApplication : INewsCategoryApplication
    {
        private readonly INewsCategoryRepository _NewsCategoryRepository;

        private readonly IUnitOfWork _UnitOfWork;

        public NewsCategoryApplication(INewsCategoryRepository newsCategoryRepository, IUnitOfWork unitofwork)
        {
            _NewsCategoryRepository = newsCategoryRepository;
            _UnitOfWork = unitofwork;
        }


        public void ActivateNewsCategory(int id)
        {
            _UnitOfWork.BeginTran();
            var newscategory = _NewsCategoryRepository.GetT(id);
            newscategory.Active();
            _UnitOfWork.CommitTran();
        }

        public bool AddNewsCategory(CreateNewCategoryViewModel command)
        {
            try
            {
                _UnitOfWork.BeginTran();
                var newscategory = new NewsCategory(command.Name, command.Description);
                _NewsCategoryRepository.CreateT(newscategory);
                _UnitOfWork.CommitTran();
                return true;
            }
            catch
            {
                _UnitOfWork.RollBackTran();
                return false;
            }
        }

        public bool EditNewsCategory(NewsCategoryEditViewModel command)
        {
            try
            {
                _UnitOfWork.BeginTran();
                var newscategory = _NewsCategoryRepository.GetT(command.id);
                newscategory.Edit(command.Name, command.Description);
                _UnitOfWork.CommitTran();
                return true;
            }
            catch
            {
                _UnitOfWork.RollBackTran();
                return false;
            }
        }


        public void InActivateNewsCategory(int id)
        {
            _UnitOfWork.BeginTran();
            var newscategory = _NewsCategoryRepository.GetT(id);
            newscategory.InActive();
            _UnitOfWork.CommitTran();
        }


        public List<NewsCategoryViewModel> SelectAllNewsCategory()
        {
            var AllNewsCategory = _NewsCategoryRepository.AllT();

            var newscategorys = new List<NewsCategoryViewModel>();

            foreach (var item in AllNewsCategory)
            {
                newscategorys.Add(new NewsCategoryViewModel()
                {
                    Id = item.Id,
                    Name = item.CategoryName,
                    Description = item.Description,
                    IsDeleted = item.IsDeleted
                });
            }

            return newscategorys.OrderBy(x => x.Id).ToList();
        }


    }
}
