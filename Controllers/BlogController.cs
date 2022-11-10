using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 7;
            return View();
        }
    }
}
