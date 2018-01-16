using Microsoft.AspNetCore.Mvc;

namespace DockerSample.Controllers
{
  public class HealthController : Controller
  {
    [HttpGet]
    public IActionResult Index() => Ok(new { Healthy = true });
  }
}