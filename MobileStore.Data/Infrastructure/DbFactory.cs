namespace MobileStore.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MobileStoreDbContext dbContext;

        public MobileStoreDbContext Init()
        {
            return dbContext ?? (dbContext = new MobileStoreDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}