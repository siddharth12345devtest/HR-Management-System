using Microsoft.EntityFrameworkCore;
namespace DataCore
{
    public class HRMSContext : DbContext
    {
        public HRMSContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}