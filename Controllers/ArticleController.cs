

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
        allArticles.Add(new Article("1","Test","Chad Chandrapaul", "Test Content",DateTime.Now));
        allArticles.Add(new Article("2","Test2","Chad Chandrapaul", "Test Content if it returns as a list",DateTime.Now));
        await Task.Delay(5); // Simulate an asynchronous operation.
        if (allArticles.Count == 0)
        {
            return NotFound();
        }
        return Ok(allArticles);
    }
}
