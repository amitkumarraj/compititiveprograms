using Microsoft.AspNetCore.Mvc;

namespace ContentNegotitation.Controllers
{
    [Route("api/employee")]
    [ApiVersion("3.0")]
    [ApiController]
    public class EmployeeV3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v3 controller");
        }
    }
}
