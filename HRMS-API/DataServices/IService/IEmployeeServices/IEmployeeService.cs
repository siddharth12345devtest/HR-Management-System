using DataModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.IService.IEmployeeServices
{
  public interface IEmployeeService
  {
    Task<IEnumerable<EmployeeDto>> GetAllAsync();
    Task<EmployeeDto> GetByIdAsync(int id);
    Task<EmployeeDto> CreateAsync(EmployeeDto model);
    Task<EmployeeDto> UpdateAsync(int id, EmployeeDto model);
    Task<bool> DeleteAsync(int id);
  }
}
