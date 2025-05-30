using DataModels.Employees;

namespace DataServices.IService.IEmployeeServices
{
  public interface IEmployeeService
  {
    Task<IEnumerable<EmployeeDto>> GetAllAsync();
    Task<EmployeeDto> GetByIdAsync(int id);
  }
}
