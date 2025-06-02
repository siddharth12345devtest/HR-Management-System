using DataServices.IService.ICompanyContactServices;
using Microsoft.AspNetCore.Mvc;

namespace HRMSApis.Controllers.v1.Company
{
  [ApiController]
  [Route("api/[controller]")]
  public class CompanyContactController : ControllerBase
  {
    private readonly ICompanyContactService _companyContactService;

    public CompanyContactController(ICompanyContactService companyContactService)
    {
      _companyContactService = companyContactService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var contacts = await _companyContactService.GetAllAsync();
      return Ok(contacts);
    }
  }

}
