using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 6;
            return View();
        }
    }
}
