namespace DotNet8.EFCoreQueryFilterExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    protected IActionResult Content(object model)
    {
        return Content(model.ToJson(), "application/json");
    }
}
