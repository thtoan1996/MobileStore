using System;

namespace MobileStore.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MobileStoreDbContext Init();
    }
}