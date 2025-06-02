using DataEntities.Company;
using DataEntities.Employees;
using DataEntities.Users;
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
    public DbSet<User> ScUser { get; set; }
    public DbSet<CompanyBranch> ScCompanyBranches { get; set; }
    public DbSet<Company> ScCompany { get; set; }
    public DbSet<CompanyContact> ScCompanyContacts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
