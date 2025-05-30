using DataModels.Company;
using DataModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.IService.ICompanyBranchServices
{
  public interface ICompanyBranchService
  {
    Task<IEnumerable<CompanyBranchDto>> GetAllAsync();
    //Task<CompanyBranchDto> GetByIdAsync(int id);
  }
}
