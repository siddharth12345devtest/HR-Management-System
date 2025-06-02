using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataEntities.Users;
using DataEntities.Companies;

namespace DataEntities.UserAttendance
{
  public class UserAttendance
  {
    [Key]
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

    // Navigation Properties
    [ForeignKey("ScCompanyId")]
    public virtual Company Company { get; set; }

    [ForeignKey("ScUserId")]
    public virtual User Users { get; set; }
  }
}
