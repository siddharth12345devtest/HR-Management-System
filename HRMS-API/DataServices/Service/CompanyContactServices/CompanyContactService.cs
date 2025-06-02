using DataCore;
using DataModels.Company;
using DataServices.IService.ICompanyContactServices;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Service.CompanyContactServices
{
  public class CompanyContactService : ICompanyContactService
  {
    private readonly HRMSContext _hrmsContext;

    public CompanyContactService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }

    public async Task<IEnumerable<CompanyContactDto>> GetAllAsync()
    {
      return await _hrmsContext.ScCompanyContacts
          .Include(c => c.Company)
          .Select(c => new CompanyContactDto
          {
            CompanyContactId = c.CompanyContactId,
            ScCompanyId = c.ScCompanyId,
            CompanyBranchId = c.CompanyBranchId,
            ContactFirstName = c.ContactFirstName,
            ContactLastName = c.ContactLastName,
            ContactDesignation = c.ContactDesignation,
            ContactMobile = c.ContactMobile,
            ContactAltMobile = c.ContactAltMobile,
            ContactHomePhone = c.ContactHomePhone,
            ContactWorkPhone = c.ContactWorkPhone,
            ContactEmail = c.ContactEmail,
            ContactAltEmail = c.ContactAltEmail,
            ContactPersonalEmail = c.ContactPersonalEmail,
            ContactIsPrimary = c.ContactIsPrimary,
            ContactGender = c.ContactGender,
            ContactDOB = c.ContactDOB,
            ContactAnniversary = c.ContactAnniversary,
            Deleted = c.Deleted,
            GenderId = c.GenderId,
            Company = c.Company == null ? null : new CompanyDto
            {
              ScCompanyId = c.Company.ScCompanyId,
              ScCompanyName = c.Company.ScCompanyName,
              ScCompanyCode = c.Company.ScCompanyCode,
              Deleted = c.Company.Deleted,
              ScCompanyLogo = c.Company.ScCompanyLogo,
              UpdateHash = c.Company.UpdateHash,
              ImagePath = c.Company.ImagePath
            }
          })
          .ToListAsync();
    }

  }
}
