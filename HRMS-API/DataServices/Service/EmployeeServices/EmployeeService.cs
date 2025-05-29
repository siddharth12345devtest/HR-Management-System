using DataCore;
using DataEntities.Designations;
using DataEntities.Employees;
using DataModels.Employees;
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
                }).ToListAsync();
    }

    public async Task<EmployeeDto> GetByIdAsync(int Id)
    {
      var e = await _hrmsContext.ScEmployee
                .FirstOrDefaultAsync(x => x.ScEmployeeId == Id);

      if (e == null) return null;

      return new EmployeeDto
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
      };
    }

    public async Task<EmployeeDto> CreateAsync(EmployeeDto model)
    {
      var employee = new Employee
      {
        ScEmployeeId = model.ScEmployeeId,
        ScCompanyId = model.ScCompanyId,
        ScUserId = model.ScUserId,
        Title = model.Title,
        FirstName = model.FirstName,
        MiddleName = model.MiddleName,
        LastName = model.LastName,
        MobilePhone = model.MobilePhone,
        AltMobilePhone = model.AltMobilePhone,
        HomePhone = model.HomePhone,
        WorkPhone = model.WorkPhone,
        Address = model.Address,
        City = model.City,
        PostalCode = model.PostalCode,
        Country = model.Country,
        Fax = model.Fax,
        Designation = model.Designation,
        State = model.State,
        PrimaryEmail = model.PrimaryEmail,
        AltEmail = model.AltEmail,
        JoiningDate = model.JoiningDate,
        Gender = model.Gender,
        UpdateHash = model.UpdateHash,
        ConfirmationDate = model.ConfirmationDate,
        DOB = model.DOB,
        AnniversaryDate = model.AnniversaryDate,
        LastModifiedDate = model.LastModifiedDate,
        LastModifiedBy = model.LastModifiedBy,
        GPSLat = model.GPSLat,
        GPSLon = model.GPSLon,
        SpouseTitle = model.SpouseTitle,
        SpouseName = model.SpouseName,
        SpouseMobile = model.SpouseMobile,
        SpouseEmail = model.SpouseEmail,
        EmergencyContactName = model.EmergencyContactName,
        EmergencyContactTitle = model.EmergencyContactTitle,
        EmergencyContactMobile = model.EmergencyContactMobile,
        EmergencyContactEmail = model.EmergencyContactEmail,
        BloodGroup = model.BloodGroup,
        OtherNotes = model.OtherNotes,
        ProbationStartDate = model.ProbationStartDate,
        ProbationEndDate = model.ProbationEndDate,
        ResignationDate = model.ResignationDate,
        GenderId = model.GenderId,
        TitleId = model.TitleId,
      };
      _hrmsContext.ScEmployee.Add(employee);
      await _hrmsContext.SaveChangesAsync();
      model.ScEmployeeId = employee.ScEmployeeId;
      //model.CreatedAt = employee.CreatedAt;
      return model;
    }
     
    public async Task<EmployeeDto> UpdateAsync(int Id, EmployeeDto model)
    {
      var employee = await _hrmsContext.ScEmployee.FindAsync(Id);

      if (employee == null) return null;

      employee.Title = model.Title;
      employee.FirstName = model.FirstName;
      employee.MiddleName = model.MiddleName;
      employee.LastName = model.LastName;
      employee.MobilePhone = model.MobilePhone;
      employee.AltMobilePhone = model.AltMobilePhone;
      employee.HomePhone = model.HomePhone;
      employee.WorkPhone = model.WorkPhone;
      employee.Address = model.Address;
      employee.City = model.City;
      employee.PostalCode = model.PostalCode;
      employee.Country = model.Country;
      employee.Fax = model.Fax;
      employee.Designation = model.Designation;
      employee.State = model.State;
      employee.PrimaryEmail = model.PrimaryEmail;
      employee.AltEmail = model.AltEmail;
      employee.JoiningDate = model.JoiningDate;
      employee.Gender = model.Gender;
      employee.UpdateHash = model.UpdateHash;
      employee.ConfirmationDate = model.ConfirmationDate;
      employee.DOB = model.DOB;
      employee.AnniversaryDate = model.AnniversaryDate;
      employee.LastModifiedDate = model.LastModifiedDate;
      employee.LastModifiedBy = model.LastModifiedBy;
      employee.GPSLat = model.GPSLat;
      employee.GPSLon = model.GPSLon;
      employee.SpouseTitle = model.SpouseTitle;
      employee.SpouseName = model.SpouseName;
      employee.SpouseMobile = model.SpouseMobile;
      employee.SpouseEmail = model.SpouseEmail;
      employee.EmergencyContactName = model.EmergencyContactName;
      employee.EmergencyContactTitle = model.EmergencyContactTitle;
      employee.EmergencyContactMobile = model.EmergencyContactMobile;
      employee.EmergencyContactEmail = model.EmergencyContactEmail;
      employee.BloodGroup = model.BloodGroup;
      employee.OtherNotes = model.OtherNotes;
      employee.ProbationStartDate = model.ProbationStartDate;
      employee.ProbationEndDate = model.ProbationEndDate;
      employee.ResignationDate = model.ResignationDate;
      employee.GenderId = model.GenderId;
      employee.TitleId = model.TitleId;


      await _hrmsContext.SaveChangesAsync();

      return model;
    }

    public async Task<bool> DeleteAsync(int Id)
    {
      var employee = await _hrmsContext.ScEmployee.FindAsync(Id);
      if (employee == null) return false;

      _hrmsContext.ScEmployee.Remove(employee);
      await _hrmsContext.SaveChangesAsync();
      return true;
    }
  }
}
