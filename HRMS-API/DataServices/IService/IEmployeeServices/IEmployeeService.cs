using DataModels.Employees;

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
