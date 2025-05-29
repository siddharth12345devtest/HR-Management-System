using DataCore;
using DataEntities.Designations;
using DataModels.Designations;
using DataServices.IService.IDesignationServices;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Service.DesignationServices
{
  public class DesignationService : IDesignationService
  {
    private readonly HRMSContext _hrmsContext;

    public DesignationService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }

    public async Task<IEnumerable<DesignationDto>> GetAllAsync()
    {
      return await _hrmsContext.Designations
        .Select(d => new DesignationDto
        {
          DesignationId = d.DesignationId,
          DesignationName = d.DesignationName,
          Description = d.Description,
          CreatedBy = d.CreatedBy,
          CreatedAt = d.CreatedAt,
          ModifiedBy = d.ModifiedBy,
          ModifiedAt = d.ModifiedAt
        })
        .ToListAsync();
    }

    public async Task<DesignationDto> GetByIdAsync(int id)
    {
      var d = await _hrmsContext.Designations.FirstOrDefaultAsync(x => x.DesignationId == id);

      if (d == null) return null;

      return new DesignationDto
      {
        DesignationId = d.DesignationId,
        DesignationName = d.DesignationName,
        Description = d.Description,
        CreatedBy = d.CreatedBy,
        CreatedAt = d.CreatedAt,
        ModifiedBy = d.ModifiedBy,
        ModifiedAt = d.ModifiedAt
      };
    }

    public async Task<DesignationDto> CreateAsync(DesignationDto model)
    {
      var designation = new Designation
      {
        DesignationName = model.DesignationName,
        Description = model.Description,
        CreatedBy = model.CreatedBy,
        CreatedAt = DateTime.UtcNow
      };

      _hrmsContext.Designations.Add(designation);
      await _hrmsContext.SaveChangesAsync();

      model.DesignationId = designation.DesignationId;
      model.CreatedAt = designation.CreatedAt;

      return model;
    }

    public async Task<DesignationDto> UpdateAsync(int id, DesignationDto model)
    {
      var designation = await _hrmsContext.Designations.FindAsync(id);

      if (designation == null) return null;

      designation.DesignationName = model.DesignationName;
      designation.Description = model.Description;
      designation.ModifiedBy = model.ModifiedBy;
      designation.ModifiedAt = DateTime.UtcNow;

      await _hrmsContext.SaveChangesAsync();

      model.ModifiedAt = designation.ModifiedAt;

      return model;
    }

    public async Task<bool> DeleteAsync(int id)
    {
      var designation = await _hrmsContext.Designations.FindAsync(id);
      if (designation == null) return false;

      _hrmsContext.Designations.Remove(designation);
      await _hrmsContext.SaveChangesAsync();

      return true;
    }
  }
}
