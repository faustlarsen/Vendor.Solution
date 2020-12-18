using Microsoft.AspNetCore.Mvc;

namespace XY.Controllers
{
  public class Homecontroller : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    
  }
}