using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]    
    public ActionResult Get()
    {
        return Ok(new {Status = "OK"});
    }
}
