using System;
using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Repositories;

namespace LawlfyUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // Her servis için ilgili repository'yi tanımlayın
        IRepository<User> Users { get; }
        IRepository<Accounting> Accountings { get; }
        IRepository<Document> Documents { get; }
        IRepository<Campaign> Campaigns { get; }
        IRepository<OCR> OCRs { get; }
        IRepository<Notification> Notifications { get; }
        IRepository<TaskManager> TaskManagers { get; }
        IRepository<Authorization> Authorizations { get; }
        IRepository<Authentication> Authentications { get; }
        IRepository<HealthChecker> HealthCheckers { get; }
        IRepository<Log> Logs { get; }
        IRepository<UnitOfWorkEntity> UnitOfWorkEntities { get; }
        IRepository<FirmManager> FirmManagers { get; }
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        
        // Veritabanı işlemlerini commit etmek için bir method
        Task<int> CommitAsync();
    }
}
