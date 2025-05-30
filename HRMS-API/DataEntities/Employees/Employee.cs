using DataEntities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities.Employees
{
    public class Employee
    {
    [Key]
    public int ScEmployeeId { get; set; }
    public int ScCompanyId { get; set; }
    public int ScUserId {  get; set; }
    public string? Title { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? MobilePhone { get; set; }
    public string? AltMobilePhone { get; set; }
    public string? HomePhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? Fax { get; set; }
    public string? Designation { get; set; }
    public string? State { get; set; }
    public string? PrimaryEmail { get; set; }
    public string? AltEmail { get; set; }
    public DateTime? JoiningDate { get; set; }
    public string? Gender { get; set; }
    public long? UpdateHash { get; set; }
    public DateTime? ConfirmationDate { get; set; }
    public DateTime? DOB { get; set; }
    public DateTime? AnniversaryDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? LastModifiedBy { get; set; }
    public decimal? GPSLat { get; set; }
    public decimal? GPSLon { get; set; }
    public string? SpouseTitle { get; set; }
    public string? SpouseName { get; set; }
    public string? SpouseMobile { get; set; }
    public string? SpouseEmail { get; set; }
    public string? EmergencyContactName { get; set; }
    public string? EmergencyContactTitle { get; set; }
    public string? EmergencyContactMobile { get; set; }
    public string? EmergencyContactEmail { get; set; }
    public string? BloodGroup { get; set; }
    public string? OtherNotes { get; set; }
    public DateTime? ProbationStartDate { get; set; }
    public DateTime? ProbationEndDate { get; set; }
    public DateTime? ResignationDate { get; set; }
    public Int16? GenderId { get; set; }
    public Int16? TitleId { get; set; }

    [ForeignKey("ScUserId")]
    public virtual User Users { get; set; }

  }
}
