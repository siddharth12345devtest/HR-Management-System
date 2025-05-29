using DataEntities.Departments;
using DataEntities.Designations;
using DataEntities.Employees;
using Microsoft.EntityFrameworkCore;
namespace DataCore
{
    public class HRMSContext : DbContext
    {
        public HRMSContext(DbContextOptions options)
            : base(options)
        {
        }
    public DbSet<Employee> ScEmployee { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<Department> Departments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
