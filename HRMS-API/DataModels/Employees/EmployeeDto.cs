using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Employees
{
  public class EmployeeDto
  {
    public int EmployeeId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime DateOfJoining { get; set; }

    public string Address { get; set; }

    public int DepartmentId { get; set; }

    public int DesignationId { get; set; }

    public string DepartmentName { get; set; }         // From join
    public string DesignationName { get; set; }       // From join

    public string AadharCard { get; set; }

    public string PanCard { get; set; }

    public string BloodGroup { get; set; }

    public bool IsActive { get; set; }

    public string ProfileImageUrl { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}
