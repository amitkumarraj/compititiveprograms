using Microsoft.AspNetCore.Mvc;

namespace ContentNegotitation.Controllers
{
    [Route("api/{v:apiVersion}/employee")]
    [ApiController]
    [ApiVersion("2.0")]
    public class EmployeeV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v2 controller");
        }
    }
}
