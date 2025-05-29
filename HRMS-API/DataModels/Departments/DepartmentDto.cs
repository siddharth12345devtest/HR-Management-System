using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Departments
{
  public class DepartmentDto
  {
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public string Description { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}
