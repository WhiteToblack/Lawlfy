using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Her servis için DbSet'leri tanımlayın
        public DbSet<User> Users { get; set; }
        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<OCR> OCRs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<TaskManager> TaskManagers { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<HealthChecker> HealthCheckers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UnitOfWorkEntity> UnitOfWorkEntities { get; set; }
        public DbSet<FirmManager> FirmManagers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Model ayarlamaları yapılabilir (isteğe bağlı)
        }
    }
}
