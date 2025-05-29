using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Designations
{
  public class DesignationDto
  {
    public int DesignationId { get; set; }

    public string DesignationName { get; set; }

    public string Description { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }
  }
}
