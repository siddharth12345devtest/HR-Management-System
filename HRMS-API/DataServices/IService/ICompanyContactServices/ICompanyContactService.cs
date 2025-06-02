using DataModels.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.IService.ICompanyContactServices
{
  public interface ICompanyContactService
  {
    Task<IEnumerable<CompanyContactDto>> GetAllAsync();
  }
}
