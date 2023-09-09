

using Microsoft.AspNetCore.Mvc;

namespace WebsiteAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ArticleController : ControllerBase
{
    private readonly ILogger<ArticleController> _logger;

    public ArticleController(ILogger<ArticleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAvailableArticles")]
    public async Task<IActionResult> Get()
    {
        var allArticles = new List<Article>();
        await Task.Delay(5); // Simulate an asynchronous operation.
        if (allArticles.Count == 0)
        {
            return NotFound();
        }
        return Ok(allArticles);
    }
}
