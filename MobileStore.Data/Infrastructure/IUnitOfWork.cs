namespace MobileStore.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}