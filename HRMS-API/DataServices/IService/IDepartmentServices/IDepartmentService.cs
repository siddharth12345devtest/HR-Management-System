using DataModels.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.IService.IDepartmentServices
{
  public interface IDepartmentService
  {
    Task<IEnumerable<DepartmentDto>> GetAllAsync();
    Task<DepartmentDto> GetByIdAsync(int id);
    Task<DepartmentDto> CreateAsync(DepartmentDto model);
    Task<DepartmentDto> UpdateAsync(int id, DepartmentDto model);
    Task<bool> DeleteAsync(int id);
  }
}
