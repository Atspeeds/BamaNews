using FrameWork.Infrastrure;

namespace BN.Infrastrure.EFCore
{
    public class UnitOfWorkEf : IUnitOfWork
    {
        private readonly BamaNewsContext _Context;

        public UnitOfWorkEf(BamaNewsContext context)
        {
            _Context = context;
        }

        public void BeginTran()
        {
            _Context.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            _Context.SaveChanges();
            _Context.Database.CommitTransaction();
        }

        public void RollBackTran()
        {
            _Context.Database.RollbackTransaction();
        }

    }
}
