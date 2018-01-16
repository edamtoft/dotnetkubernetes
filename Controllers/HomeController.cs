using Microsoft.AspNetCore.Mvc;

namespace DockerSample.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    public IActionResult Index() => Ok(new { Hello = "world" });
  }
}