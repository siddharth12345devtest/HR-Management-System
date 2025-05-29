using DataModels.Departments;
using DataServices.IService.IDepartmentServices;
using Microsoft.AspNetCore.Mvc;

namespace HRMSApis.Controllers.v1.Departments
{
  [ApiController]
  [Route("api/[controller]")] 
  public class DepartmentController : ControllerBase
  {
    private readonly IDepartmentService _departmentService;

    public DepartmentController(IDepartmentService departmentService)
    {
      _departmentService = departmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var departments = await _departmentService.GetAllAsync();
      return Ok(departments);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var department = await _departmentService.GetByIdAsync(id);
      if (department == null) return NotFound();
      return Ok(department);
    }

    [HttpPost]
    public async Task<IActionResult> Create(DepartmentDto model)
    {
      var created = await _departmentService.CreateAsync(model);
      return CreatedAtAction(nameof(GetById), new { id = created.DepartmentId }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, DepartmentDto model)
    {
      var updated = await _departmentService.UpdateAsync(id, model);
      if (updated == null) return NotFound();
      return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var result = await _departmentService.DeleteAsync(id);
      if (!result) return NotFound();
      return NoContent();
    }

  }
}
