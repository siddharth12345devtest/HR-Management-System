using DataModels.Designations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.IService.IDesignationServices
{
  public interface IDesignationService
  {
    Task<IEnumerable<DesignationDto>> GetAllAsync();
    Task<DesignationDto> GetByIdAsync(int id);
    Task<DesignationDto> CreateAsync(DesignationDto model);
    Task<DesignationDto> UpdateAsync(int id, DesignationDto model);
    Task<bool> DeleteAsync(int id);
  }
}
