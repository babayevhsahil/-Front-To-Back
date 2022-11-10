using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 3;
            return View();
        }
    }
}
