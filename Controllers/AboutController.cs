using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 2;
            return View();
        }
    }
}
