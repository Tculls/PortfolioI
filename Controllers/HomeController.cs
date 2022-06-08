using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;
public class HelloController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "this is my index";
    }
    [HttpGet("projects")]
    public string Projects()
    {
        return "these are my projects";
    }
    [HttpGet("contacts")]
    public string Contact()
    {
        return "this is my contact";
    }
}