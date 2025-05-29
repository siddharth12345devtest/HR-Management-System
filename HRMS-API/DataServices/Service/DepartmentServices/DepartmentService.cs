using DataCore;
using DataEntities.Departments;
using DataModels.Departments;
using DataServices.IService.IDepartmentServices;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataServices.Service.DepartmentServices
{
  public class DepartmentService : IDepartmentService
  {
    private readonly HRMSContext _hrmsContext;
    public DepartmentService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }

    public async Task<IEnumerable<DepartmentDto>> GetAllAsync()
    {
      return await _hrmsContext.Departments
          .Select(d => new DepartmentDto
          {
            DepartmentId = d.DepartmentId,
            DepartmentName = d.DepartmentName,
            Description = d.Description
          }).ToListAsync();
    }

    public async Task<DepartmentDto> GetByIdAsync(int id)
    {
      var d = await _hrmsContext.Departments.FindAsync(id);
      if (d == null) return null;

      return new DepartmentDto
      {
        DepartmentId = d.DepartmentId,
        DepartmentName = d.DepartmentName,
        Description = d.Description
      };
    }

    public async Task<DepartmentDto> CreateAsync(DepartmentDto model)
    {
      var entity = new Department
      {
        DepartmentName = model.DepartmentName,
        Description = model.Description
      };

      _hrmsContext.Departments.Add(entity);
      await _hrmsContext.SaveChangesAsync();

      model.DepartmentId = entity.DepartmentId;
      return model;
    }

    public async Task<DepartmentDto> UpdateAsync(int id, DepartmentDto model)
    {
      var entity = await _hrmsContext.Departments.FindAsync(id);
      if (entity == null) return null;

      entity.DepartmentName = model.DepartmentName;
      entity.Description = model.Description;

      await _hrmsContext.SaveChangesAsync();
      return model;
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var entity = await _hrmsContext.Departments.FindAsync(id);
      if (entity == null) return false;

      _hrmsContext.Departments.Remove(entity);
      await _hrmsContext.SaveChangesAsync();
      return true;
    }
  }
}
