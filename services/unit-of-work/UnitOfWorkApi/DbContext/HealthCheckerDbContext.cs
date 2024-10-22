using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class HealthCheckerDbContext : DbContext
    {
        public HealthCheckerDbContext(DbContextOptions<HealthCheckerDbContext> options) : base(options)
        {
        }

        public DbSet<HealthChecker> HealthCheckers { get; set; }
    }
}
