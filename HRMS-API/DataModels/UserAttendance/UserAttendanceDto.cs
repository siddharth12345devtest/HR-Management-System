using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.UserAttendance
{
  public class UserAttendanceDto
  {
    public int AttendanceId { get; set; }

    public int ScUserId { get; set; }

    public DateTime? LoginTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public int? DurationMinutes { get; set; }

    public double? AttLocLat { get; set; }

    public double? AttLocLon { get; set; }

    public string? AttLocName { get; set; }

    public string? AttLocAddress { get; set; }

    public double? AttLocAccuracy { get; set; }

    public string? UpdateHash { get; set; }

    public int ScCompanyId { get; set; }
  }
}
