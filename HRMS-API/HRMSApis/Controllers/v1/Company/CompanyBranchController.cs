using Microsoft.AspNetCore.Mvc;
using DataServices.IService.ICompanyBranchServices;

namespace HRMSApis.Controllers.v1.Company
{
  [ApiController]
  [Route("api/[controller]")]
  public class CompanyBranchController : ControllerBase
  {
    private readonly ICompanyBranchService _companyBranchService;

    public CompanyBranchController(ICompanyBranchService companyBranchService)
    {
      _companyBranchService = companyBranchService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var companyBranches = await _companyBranchService.GetAllAsync();
      return Ok(companyBranches);
    }

  }
}
