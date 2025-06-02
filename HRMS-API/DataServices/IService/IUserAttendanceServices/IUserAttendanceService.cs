using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.Company;
using DataModels.UserAttendance;

namespace DataServices.IService.IUserAttendanceServices
{
  public interface IUserAttendanceService
  {
    Task<IEnumerable<UserAttendanceDto>> GetAllAsync();
  }
}
