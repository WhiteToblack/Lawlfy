using System.Threading.Tasks;
using LawlfyUnitOfWork.Entities;
using LawlfyUnitOfWork.Repositories;

namespace LawlfyUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            // Her servis için repository'leri initialize edin
            Users = new Repository<User>(_context);
            Accountings = new Repository<Accounting>(_context);
            Documents = new Repository<Document>(_context);
            Campaigns = new Repository<Campaign>(_context);
            OCRs = new Repository<OCR>(_context);
            Notifications = new Repository<Notification>(_context);
            TaskManagers = new Repository<TaskManager>(_context);
            Authorizations = new Repository<Authorization>(_context);
            Authentications = new Repository<Authentication>(_context);
            HealthCheckers = new Repository<HealthChecker>(_context);
            Logs = new Repository<Log>(_context);
            UnitOfWorkEntities = new Repository<UnitOfWorkEntity>(_context);
            FirmManagers = new Repository<FirmManager>(_context);
        }

        public IRepository<User> Users { get; private set; }
        public IRepository<Accounting> Accountings { get; private set; }
        public IRepository<Document> Documents { get; private set; }
        public IRepository<Campaign> Campaigns { get; private set; }
        public IRepository<OCR> OCRs { get; private set; }
        public IRepository<Notification> Notifications { get; private set; }
        public IRepository<TaskManager> TaskManagers { get; private set; }
        public IRepository<Authorization> Authorizations { get; private set; }
        public IRepository<Authentication> Authentications { get; private set; }
        public IRepository<HealthChecker> HealthCheckers { get; private set; }
        public IRepository<Log> Logs { get; private set; }
        public IRepository<UnitOfWorkEntity> UnitOfWorkEntities { get; private set; }
        public IRepository<FirmManager> FirmManagers { get; private set; }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
