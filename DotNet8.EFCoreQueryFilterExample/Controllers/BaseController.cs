using DotNet8.EFCoreQueryFilterExample.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.EFCoreQueryFilterExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IActionResult Content(object model)
        {
            return Content(model.ToJson(), "application/json");
        }
    }
}
