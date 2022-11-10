using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 4;
            return View();
        }
    }
}
