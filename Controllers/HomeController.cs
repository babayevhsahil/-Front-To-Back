using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 1;
            return View();
        }
    }
}
