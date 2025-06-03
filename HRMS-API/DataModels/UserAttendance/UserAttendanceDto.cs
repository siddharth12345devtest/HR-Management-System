using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.UserAttendance
{
  public class UserAttendanceDto
  {
    public long AttendanceId { get; set; }

    public int ScUserId { get; set; }

    public DateTime? LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public int? DurationMinutes { get; set; }

    public decimal? AttLocLat { get; set; }

    public decimal? AttLocLon { get; set; }

    public string? AttLocName { get; set; }

    public string? AttLocAddress { get; set; }

    public int? AttLocAccuracy { get; set; }

    public long? UpdateHash { get; set; }

    public int ScCompanyId { get; set; }
  }
}
