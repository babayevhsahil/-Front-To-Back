using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 5;
            return View();
        }
    }
}
