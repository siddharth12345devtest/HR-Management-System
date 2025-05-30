using System.ComponentModel.DataAnnotations;

namespace DataEntities.Company
{
  public class Company
  {
    [Key]
    public int ScCompanyId { get; set; }
    public string ScCompanyName { get; set; }
    public string ScCompanyCode { get; set; }
    public bool Deleted { set; get; }
    public string? ScCompanyLogo { get; set; }
    public long UpdateHash { get; set; }
    public string ImagePath { get; set; }
    public virtual ICollection<CompanyBranch> CompanyBranches { get; set; }
  }
}
