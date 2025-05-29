using DataCore;
using DataEntities.Employees;
using DataModels.Employees;
using DataServices.IService.IEmployeeServices;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Service.EmployeeServices
{
  public class EmployeeService : IEmployeeService
  {
    private readonly HRMSContext _hrmsContext;
    public EmployeeService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }

    public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
    {
      return await _hrmsContext.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation)
                .Select(e => new EmployeeDto
                {
                  EmployeeId = e.EmployeeId,
                  FirstName = e.FirstName,
                  LastName = e.LastName,
                  Email = e.Email,
                  PhoneNumber = e.PhoneNumber,
                  Gender = e.Gender,
                  DateOfBirth = e.DateOfBirth,
                  DateOfJoining = e.DateOfJoining,
                  CurrentAddress = e.CurrentAddress,
                  PermanentAddress = e.PermanentAddress,
                  DepartmentId = e.DepartmentId,
                  DepartmentName = e.Department.DepartmentName,
                  DesignationId = e.DesignationId,
                  DesignationName = e.Designation.DesignationName,
                  AadharCard = e.AadharCard,
                  PanCard = e.PanCard,
                  BloodGroup = e.BloodGroup,
                  IsActive = e.IsActive,
                  ProfileImageUrl = e.ProfileImageUrl,
                  CreatedAt = e.CreatedAt,
                  CreatedBy = e.CreatedBy,
                  ModifiedAt = e.ModifiedAt,
                  ModifiedBy = e.ModifiedBy
                }).ToListAsync();
    }

    public async Task<EmployeeDto> GetByIdAsync(int Id)
    {
      var e = await _hrmsContext.Employees
                .Include(x => x.Department)
                .Include(x => x.Designation)
                .FirstOrDefaultAsync(x => x.EmployeeId == Id);

      if (e == null) return null;

      return new EmployeeDto
      {
        EmployeeId = e.EmployeeId,
        FirstName = e.FirstName,
        LastName = e.LastName,
        Email = e.Email,
        PhoneNumber = e.PhoneNumber,
        Gender = e.Gender,
        DateOfBirth = e.DateOfBirth,
        DateOfJoining = e.DateOfJoining,
        CurrentAddress = e.CurrentAddress,
        PermanentAddress = e.PermanentAddress,
        DepartmentId = e.DepartmentId,
        DepartmentName = e.Department.DepartmentName,
        DesignationId = e.DesignationId,
        DesignationName = e.Designation.DesignationName,
        AadharCard = e.AadharCard,
        PanCard = e.PanCard,
        BloodGroup = e.BloodGroup,
        IsActive = e.IsActive,
        ProfileImageUrl = e.ProfileImageUrl,
        CreatedAt = e.CreatedAt,
        CreatedBy = e.CreatedBy,
        ModifiedAt = e.ModifiedAt,
        ModifiedBy = e.ModifiedBy
      };
    }

    public async Task<EmployeeDto> CreateAsync(EmployeeDto model)
    {
      var employee = new Employee
      {
        FirstName = model.FirstName,
        LastName = model.LastName,
        Email = model.Email,
        PhoneNumber = model.PhoneNumber,
        Gender = model.Gender,
        DateOfBirth = model.DateOfBirth,
        DateOfJoining = model.DateOfJoining,
        CurrentAddress = model.CurrentAddress,
        PermanentAddress = model.PermanentAddress,
        DepartmentId = model.DepartmentId,
        DesignationId = model.DesignationId,
        AadharCard = model.AadharCard,
        PanCard = model.PanCard,
        BloodGroup = model.BloodGroup,
        IsActive = true,
        ProfileImageUrl = model.ProfileImageUrl,
        CreatedAt = DateTime.UtcNow,
        CreatedBy = model.CreatedBy
      };
      _hrmsContext.Employees.Add(employee);
      await _hrmsContext.SaveChangesAsync();
      model.EmployeeId = employee.EmployeeId;
      model.CreatedAt = employee.CreatedAt;
      return model;
    }
     
    public async Task<EmployeeDto> UpdateAsync(int Id, EmployeeDto model)
    {
      var employee = await _hrmsContext.Employees.FindAsync(Id);

      if (employee == null) return null;

      employee.FirstName = model.FirstName;
      employee.LastName = model.LastName;
      employee.Email = model.Email;
      employee.PhoneNumber = model.PhoneNumber;
      employee.Gender = model.Gender;
      employee.DateOfBirth = model.DateOfBirth;
      employee.DateOfJoining = model.DateOfJoining;
      employee.CurrentAddress = model.CurrentAddress;
      employee.PermanentAddress = model.PermanentAddress;
      employee.DepartmentId = model.DepartmentId;
      employee.DesignationId = model.DesignationId;
      employee.AadharCard = model.AadharCard;
      employee.PanCard = model.PanCard;
      employee.BloodGroup = model.BloodGroup;
      employee.IsActive = model.IsActive;
      employee.ProfileImageUrl = model.ProfileImageUrl;
      employee.ModifiedAt = DateTime.UtcNow;
      employee.ModifiedBy = model.ModifiedBy;

      await _hrmsContext.SaveChangesAsync();

      return model;
    }

    public async Task<bool> DeleteAsync(int Id)
    {
      var employee = await _hrmsContext.Employees.FindAsync(Id);
      if (employee == null) return false;

      _hrmsContext.Employees.Remove(employee);
      await _hrmsContext.SaveChangesAsync();
      return true;
    }
  }
}
