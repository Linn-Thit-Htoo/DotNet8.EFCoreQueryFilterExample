namespace DotNet8.EFCoreQueryFilterExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
    private readonly AppDbContext _appDbContext;

    public BlogController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetBlogsAsync(CancellationToken cs)
    {
        try
        {
            var lst = await _appDbContext.Tbl_Blog.ToListAsync(cs);
            return Content(lst);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
