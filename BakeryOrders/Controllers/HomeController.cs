using Microsoft.AspNetCore.Mvc;

namespace BakeryOrders.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}