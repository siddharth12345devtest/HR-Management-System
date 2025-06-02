using DataEntities.Companies;
using DataEntities.Employees;
using DataEntities.UserAttendance;
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

    public DbSet<UserAttendance> ScUserAttendance { get; set; }  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
