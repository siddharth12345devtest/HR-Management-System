using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Company
{
  public class CompanyBranchDto
  {
    public int CompanyBranchId { get; set; }
    public int ScCompanyId { get; set; }
    public string? BranchAddress { get; set; }
    public string? CompanyURL { get; set; }
    public string? BranchEmail { get; set; }
    public string? BranchCity { get; set; }
    public string? BranchPostalCode { get; set; }
    public string? BranchPhone { get; set; }
    public string? BranchFax { get; set; }
    public string? BranchCountry { get; set; }
    public decimal? BranchGPSLat { get; set; }
    public decimal? BranchGPSLon { get; set; }
    public bool? BranchIsHO { get; set; }
    public bool? Active { get; set; }
    public int? DefaultLocaleId { get; set; }
    public int? DefaultTimeZoneId { get; set; }
    public string? BranchState { get; set; }
    public string? BranchName { get; set; }
    public string? GSTIN { get; set; }
    public string? PANNumber { get; set; }
    public virtual CompanyDto Company { get; set; }
  }
}
