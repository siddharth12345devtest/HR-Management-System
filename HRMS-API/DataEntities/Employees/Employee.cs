using DataEntities.Departments;
using DataEntities.Designations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities.Employees
{
    public class Employee
    {
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [MaxLength(100)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(15)]
    public string PhoneNumber { get; set; }

    [MaxLength(10)]
    public string Gender { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfJoining { get; set; }

    [MaxLength(200)]
    public string PermanentAddress { get; set; }

    [MaxLength(200)]
    public string CurrentAddress { get; set; }

    [MaxLength(12)]
    public string AadharCard { get; set; }

    [MaxLength(10)]
    public string PanCard { get; set; }

    [MaxLength(5)]
    public string BloodGroup { get; set; }

    public bool IsActive { get; set; }

    public string ProfileImageUrl { get; set; }

    // Foreign Keys
    public int DepartmentId { get; set; }

    public int DesignationId { get; set; }

    // Navigation Properties
    [ForeignKey("DepartmentId")]
    public Department Department { get; set; }

    [ForeignKey("DesignationId")]
    public Designation Designation { get; set; }

    [MaxLength(100)]
    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    [MaxLength(100)]
    public string ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}
