using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
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