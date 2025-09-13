using DirectoryService.Application;
using DirectoryService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;


[ApiController]
[Route("api/locations")]
public class LocationsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromServices] CreateLocationHandler handler,
        [FromBody] CreateLocationRequest request, CancellationToken cancellationToken)
    {
        var result = await handler.Handle(request, cancellationToken);
        return Ok(result.Value);
    }
}