using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCore;
using DataModels.UserAttendance;
using DataServices.IService.IUserAttendanceServices;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Service.UserAttendanceServices
{
  public class UserAttendanceService : IUserAttendanceService
  {
    private readonly HRMSContext _hrmsContext;

    public UserAttendanceService(HRMSContext hrmsContext)
    {
      _hrmsContext = hrmsContext;
    }

    public async Task<IEnumerable<UserAttendanceDto>> GetAllAsync()
    {
      return await _hrmsContext.ScUserAttendance
          .Select(a => new UserAttendanceDto
          {
            AttendanceId = a.AttendanceId,
            ScUserId = a.ScUserId,
            LoginTime = a.LoginTime,
            LogoutTime = a.LogoutTime,
            DurationMinutes = a.DurationMinutes,
            AttLocLat = a.AttLocLat,
            AttLocLon = a.AttLocLon,
            AttLocName = a.AttLocName,
            AttLocAddress = a.AttLocAddress,
            AttLocAccuracy = a.AttLocAccuracy,
            UpdateHash = a.UpdateHash,
            ScCompanyId = a.ScCompanyId
          })
          .ToListAsync();
    }
  }
}
