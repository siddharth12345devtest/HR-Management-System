using Microsoft.AspNetCore.Mvc;
using DataServices.IService.IUserAttendanceServices;


namespace HRMSApis.Controllers.v1.UserAttendance
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserAttendanceController : ControllerBase
  {
    private readonly IUserAttendanceService _userAttendanceService;

    public UserAttendanceController(IUserAttendanceService userAttendanceService)
    {
      _userAttendanceService = userAttendanceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var attendances = await _userAttendanceService.GetAllAsync();
      return Ok(attendances);
    }
  }
}
