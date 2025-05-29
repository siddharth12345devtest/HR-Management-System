using DataEntities.Employees;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Departments
{
  public class Department
  {
    [Key]
    public int DepartmentId { get; set; }

    [Required]
    [MaxLength(100)]
    public string DepartmentName { get; set; }

    [MaxLength(250)]
    public string Description { get; set; }

    [MaxLength(100)]
    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    [MaxLength(100)]
    public string ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    // Navigation Property
    public ICollection<Employee> Employees { get; set; }
  }
}
