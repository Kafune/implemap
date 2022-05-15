using Implemap.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Implemap.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    private static readonly Location[] Locations =
    {
        new(0, 52.36435, 4.94358, "Quiet Garden View Room & Super Fast WiFi"),
        new(1, 52.38231, 4.84866, "Cosy city apartment")
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Locations);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        return Ok(Locations.FirstOrDefault(location => location.Id == id));
    }
}