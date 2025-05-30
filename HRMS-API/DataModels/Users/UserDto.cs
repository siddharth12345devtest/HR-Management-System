using DataModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Users
{
  public class UserDto
  {
    public int ScUserId { get; set; }
    public int ScCompanyId { get; set; }
    public string ScUserName { get; set; }

    public int CompanyBranchId { get; set; }
    public string ScPasswordHash { get; set; }
    public bool UserIsActive { get; set; }
    public string? UserDeviceCode { get; set; }
    public long UpdateHash { get; set; }
    public long? SuccessfulUpdateHash { get; set; }
    public int? ScManagerId { get; set; }
    public string? Token { get; set; }
    public int Deleted { get; set; }
    public bool ForceChangePassword { get; set; }
    public int UserCreatedBy { get; set; }
    public DateTime UserCreatedDate { get; set; }
    public int? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public byte DisableGPSTracking { get; set; }
    public int? DefaultLocaleId { get; set; }
    public int? DefaultTimeZoneId { get; set; }
    public DateTime? UserJoiningDate { get; set; }
    public DateTime? UserLastWorkingDate { get; set; }
    public bool AcceptedEULA { get; set; }
    public bool EnableDebugMode { get; set; }
    public DateTime? EULAAcceptedDate { get; set; }
    public int? CalendarId { get; set; }
    public int AccessLevel { get; set; }
    public virtual ICollection<EmployeeDto> Employees { get; set; }
  }
}
