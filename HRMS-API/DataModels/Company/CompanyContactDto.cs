using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Company
{
  public class CompanyContactDto
  {
    public int CompanyContactId { get; set; }
    public int ScCompanyId { get; set; }
    public int CompanyBranchId { get; set; }

    public string? ContactFirstName { get; set; }
    public string? ContactLastName { get; set; }
    public string? ContactDesignation { get; set; }

    public string? ContactMobile { get; set; }
    public string? ContactAltMobile { get; set; }
    public string? ContactHomePhone { get; set; }
    public string? ContactWorkPhone { get; set; }

    public string? ContactEmail { get; set; }
    public string? ContactAltEmail { get; set; }
    public string? ContactPersonalEmail { get; set; }

    public bool ContactIsPrimary { get; set; }

    public string? ContactGender { get; set; }
    public DateTime? ContactDOB { get; set; }
    public DateTime? ContactAnniversary { get; set; }

    public bool Deleted { get; set; }
    public short? GenderId { get; set; }
    public virtual CompanyDto Company { get; set; }
  }
}
