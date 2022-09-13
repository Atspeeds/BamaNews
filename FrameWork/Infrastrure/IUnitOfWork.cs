namespace FrameWork.Infrastrure
{
    public interface IUnitOfWork
    {

        void BeginTran();
        void CommitTran();
        void RollBackTran();


    }
}
