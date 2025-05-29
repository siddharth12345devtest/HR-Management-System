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

      [HttpPost]
      public async Task<IActionResult> Create(EmployeeDto model)
      {
        var created = await _employeeService.CreateAsync(model);
        return CreatedAtAction(nameof(GetById), new { id = created.EmployeeId }, created);
      }

      [HttpPut("{id}")]
      public async Task<IActionResult> Update(int id, EmployeeDto model)
      {
        var updated = await _employeeService.UpdateAsync(id, model);
        if (updated == null) return NotFound();
        return Ok(updated);
      }

      [HttpDelete("{id}")]
      public async Task<IActionResult> Delete(int id)
      {
        var result = await _employeeService.DeleteAsync(id);
        if (!result) return NotFound();
        return NoContent();
      }
    }
}
