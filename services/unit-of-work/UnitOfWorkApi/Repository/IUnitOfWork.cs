using System;
using System.Threading.Tasks;
using LawlfyUnitOfWork;
using LawlfyUnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawlfyUnitOfWork.Repositories
{
    public interface IUnitOfWork<TContext>
        where TContext : DbContext
    {
        IRepository<T> Repository<T>()
            where T : class;
        Task<int> SaveChangesAsync();
        Task CommitAsync();
        void Dispose();
    }
}
