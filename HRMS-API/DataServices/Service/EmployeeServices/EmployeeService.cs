using DataCore;
using DataEntities.Employees;
using DataModels.Employees;
using DataModels.Users;
using DataServices.IService.IEmployeeServices;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Net;

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
      var employees = await _hrmsContext.ScEmployee
        .Include(e => e.Users)
        .ToListAsync();
      return await _hrmsContext.ScEmployee
                .Select(e => new EmployeeDto
                {
                  ScEmployeeId = e.ScEmployeeId,
                  ScCompanyId = e.ScCompanyId,
                  ScUserId = e.ScUserId,
                  Title = e.Title,
                  FirstName = e.FirstName,
                  MiddleName = e.MiddleName,
                  LastName = e.LastName,
                  MobilePhone = e.MobilePhone,
                  AltMobilePhone = e.AltMobilePhone,
                  HomePhone = e.HomePhone,
                  WorkPhone = e.WorkPhone,
                  Address = e.Address,
                  City = e.City,
                  PostalCode = e.PostalCode,
                  Country = e.Country,
                  Fax = e.Fax,
                  Designation = e.Designation,
                  State = e.State,
                  PrimaryEmail = e.PrimaryEmail,
                  AltEmail = e.AltEmail,
                  JoiningDate = e.JoiningDate,
                  Gender = e.Gender,
                  UpdateHash = e.UpdateHash,
                  ConfirmationDate = e.ConfirmationDate,
                  DOB = e.DOB,
                  AnniversaryDate = e.AnniversaryDate,
                  LastModifiedDate = e.LastModifiedDate,
                  LastModifiedBy = e.LastModifiedBy,
                  GPSLat = e.GPSLat,
                  GPSLon = e.GPSLon,
                  SpouseTitle = e.SpouseTitle,
                  SpouseName = e.SpouseName,
                  SpouseMobile = e.SpouseMobile,
                  SpouseEmail = e.SpouseEmail,
                  EmergencyContactName = e.EmergencyContactName,
                  EmergencyContactTitle = e.EmergencyContactTitle,
                  EmergencyContactMobile = e.EmergencyContactMobile,
                  EmergencyContactEmail = e.EmergencyContactEmail,
                  BloodGroup = e.BloodGroup,
                  OtherNotes = e.OtherNotes,
                  ProbationStartDate = e.ProbationStartDate,
                  ProbationEndDate = e.ProbationEndDate,
                  ResignationDate = e.ResignationDate,
                  GenderId = e.GenderId,
                  TitleId = e.TitleId,
                  Users = e.Users == null ? null : new UserDto
                  {
                    ScUserId = e.Users.ScUserId,
                    ScCompanyId = e.Users.ScCompanyId,
                    ScUserName = e.Users.ScUserName,
                    UserIsActive = e.Users.UserIsActive,
                    Deleted = e.Users.Deleted,
                    UserCreatedBy = e.Users.UserCreatedBy,
                    UserCreatedDate = e.Users.UserCreatedDate,
                    LastModifiedBy = e.Users.LastModifiedBy,
                    LastModifiedDate = e.Users.LastModifiedDate,
                    UserJoiningDate = e.Users.UserJoiningDate,
                    UserLastWorkingDate = e.Users.UserLastWorkingDate
                  }
                }).ToListAsync();
    }

    public async Task<EmployeeDto> GetByIdAsync(int Id)
    {
      return await _hrmsContext.ScEmployee
        .Include(e => e.Users) // include related user
        .Where(e => e.ScEmployeeId == Id)
        .Select(e => new EmployeeDto
        {
          ScEmployeeId = e.ScEmployeeId,
          ScCompanyId = e.ScCompanyId,
          ScUserId = e.ScUserId,
          Title = e.Title,
          FirstName = e.FirstName,
          MiddleName = e.MiddleName,
          LastName = e.LastName,
          MobilePhone = e.MobilePhone,
          AltMobilePhone = e.AltMobilePhone,
          HomePhone = e.HomePhone,
          WorkPhone = e.WorkPhone,
          Address = e.Address,
          City = e.City,
          PostalCode = e.PostalCode,
          Country = e.Country,
          Fax = e.Fax,
          Designation = e.Designation,
          State = e.State,
          PrimaryEmail = e.PrimaryEmail,
          AltEmail = e.AltEmail,
          JoiningDate = e.JoiningDate,
          Gender = e.Gender,
          UpdateHash = e.UpdateHash,
          ConfirmationDate = e.ConfirmationDate,
          DOB = e.DOB,
          AnniversaryDate = e.AnniversaryDate,
          LastModifiedDate = e.LastModifiedDate,
          LastModifiedBy = e.LastModifiedBy,
          GPSLat = e.GPSLat,
          GPSLon = e.GPSLon,
          SpouseTitle = e.SpouseTitle,
          SpouseName = e.SpouseName,
          SpouseMobile = e.SpouseMobile,
          SpouseEmail = e.SpouseEmail,
          EmergencyContactName = e.EmergencyContactName,
          EmergencyContactTitle = e.EmergencyContactTitle,
          EmergencyContactMobile = e.EmergencyContactMobile,
          EmergencyContactEmail = e.EmergencyContactEmail,
          BloodGroup = e.BloodGroup,
          OtherNotes = e.OtherNotes,
          ProbationStartDate = e.ProbationStartDate,
          ProbationEndDate = e.ProbationEndDate,
          ResignationDate = e.ResignationDate,
          GenderId = e.GenderId,
          TitleId = e.TitleId,
          Users = e.Users.ScUserId == null ? null : new UserDto
          {
            ScUserId = e.Users.ScUserId,
            ScCompanyId = e.Users.ScCompanyId,
            ScUserName = e.Users.ScUserName,
            UserIsActive = e.Users.UserIsActive,
            Deleted = e.Users.Deleted,
            UserCreatedBy = e.Users.UserCreatedBy,
            UserCreatedDate = e.Users.UserCreatedDate,
            LastModifiedBy = e.Users.LastModifiedBy,
            LastModifiedDate = e.Users.LastModifiedDate,
            UserJoiningDate = e.Users.UserJoiningDate,
            UserLastWorkingDate = e.Users.UserLastWorkingDate
          }
        }).FirstOrDefaultAsync();
    }
  }
}
