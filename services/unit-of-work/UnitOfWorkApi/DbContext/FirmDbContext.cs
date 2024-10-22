using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class FirmManagerDbContext : DbContext
    {
        public FirmManagerDbContext(DbContextOptions<FirmManagerDbContext> options) : base(options)
        {
        }

        public DbSet<FirmManager> FirmManagers { get; set; }
    }
}
