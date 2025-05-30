using DataCore;
using DataModels.Company;
using DataModels.Employees;
using DataServices.IService.ICompanyBranchServices;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Service.CompanyBranchService
{
  public class CompanyBranchService : ICompanyBranchService
  {
    private readonly HRMSContext _hrmsContext;
    public CompanyBranchService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }
    public async Task<IEnumerable<CompanyBranchDto>> GetAllAsync()
    {
      var companybranch = await _hrmsContext.ScCompanyBranches
        .Include(e => e.Company)
        .ToListAsync();
      return await _hrmsContext.ScCompanyBranches
                .Select(e => new CompanyBranchDto
                {
                  CompanyBranchId = e.CompanyBranchId,
                  ScCompanyId = e.ScCompanyId,
                  BranchAddress = e.BranchAddress,
                  CompanyURL = e.CompanyURL,
                  BranchEmail = e.BranchEmail,
                  BranchCity = e.BranchCity,
                  BranchPostalCode = e.BranchPostalCode,
                  BranchPhone = e.BranchPhone,
                  BranchFax = e.BranchFax,
                  BranchCountry = e.BranchCountry,
                  BranchGPSLat = e.BranchGPSLat,
                  BranchGPSLon = e.BranchGPSLon,
                  BranchIsHO = e.BranchIsHO,
                  Active = e.Active,
                  DefaultLocaleId = e.DefaultLocaleId,
                  DefaultTimeZoneId = e.DefaultTimeZoneId,
                  BranchState = e.BranchState,
                  BranchName = e.BranchName,
                  GSTIN = e.GSTIN,
                  PANNumber = e.PANNumber,
                  Company = e.Company == null ? null : new CompanyDto
                  {
                    ScCompanyId = e.Company.ScCompanyId,
                    ScCompanyName = e.Company.ScCompanyName,
                    ScCompanyCode = e.Company.ScCompanyCode,
                    Deleted = e.Company.Deleted,
                    ScCompanyLogo = e.Company.ScCompanyLogo,
                    UpdateHash = e.Company.UpdateHash,
                    ImagePath = e.Company.ImagePath,
                  }
                }).ToListAsync();
    }
  }
}
