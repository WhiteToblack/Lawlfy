using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class LogDbContext : DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}
