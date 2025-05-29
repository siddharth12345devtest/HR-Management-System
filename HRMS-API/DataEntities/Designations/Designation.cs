using DataEntities.Employees;
using System.ComponentModel.DataAnnotations;

namespace DataEntities.Designations
{
  public class Designation
  {
    [Key]
    public int DesignationId { get; set; }

    [Required]
    [MaxLength(100)]
    public string DesignationName { get; set; }

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
