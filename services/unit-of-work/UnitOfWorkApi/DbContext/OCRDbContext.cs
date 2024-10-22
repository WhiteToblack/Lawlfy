using Microsoft.EntityFrameworkCore;
using LawlfyUnitOfWork.Entities;

namespace LawlfyUnitOfWork
{
    public class OCRDbContext : DbContext
    {
        public OCRDbContext(DbContextOptions<OCRDbContext> options) : base(options)
        {
        }

        public DbSet<OCR> OCRs { get; set; }
    }
}
