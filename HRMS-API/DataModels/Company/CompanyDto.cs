using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Company
{
  public class CompanyDto
  {
    public int ScCompanyId { get; set; }
    public string ScCompanyName { get; set; }
    public string ScCompanyCode { get; set; }
    public bool Deleted { set; get; }
    public string? ScCompanyLogo { get; set; }
    public long UpdateHash { get; set; }
    public string ImagePath { get; set; }

    public virtual ICollection<CompanyBranchDto> CompanyBranches { get; set; }
  }
}
