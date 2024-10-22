using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class AuthenticationDbContext : DbContext
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
        {
        }

        public DbSet<Authentication> Authentications { get; set; }
    }
}
