using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
