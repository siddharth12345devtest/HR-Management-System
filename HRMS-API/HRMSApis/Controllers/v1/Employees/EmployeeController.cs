using DataModels.Employees;
using DataServices.IService.IEmployeeServices;
using Microsoft.AspNetCore.Mvc;

namespace HRMSApis.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
      private readonly IEmployeeService _employeeService;

      public EmployeeController(IEmployeeService employeeService)
      {
        _employeeService = employeeService;
      }

      [HttpGet]
      public async Task<IActionResult> GetAll()
      {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
      }

      [HttpGet("{id}")]
      public async Task<IActionResult> GetById(int id)
      {
        var employee = await _employeeService.GetByIdAsync(id);
        if (employee == null) return NotFound();
        return Ok(employee);
      }
    }
}
