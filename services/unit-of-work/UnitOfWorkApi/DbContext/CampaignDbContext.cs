using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class CampaignDbContext : DbContext
    {
        public CampaignDbContext(DbContextOptions<CampaignDbContext> options) : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
    }
}
