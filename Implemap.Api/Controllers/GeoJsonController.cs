using Microsoft.AspNetCore.Mvc;

namespace Implemap.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeoJsonController : ControllerBase
{
    private static readonly string[] Test =
    {
        "One", "Two", "Three"
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Test);
    }
}