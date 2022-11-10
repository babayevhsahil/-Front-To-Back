using Microsoft.AspNetCore.Mvc;

namespace BaxkendEterna.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 8;
            return View();
        }
    }
}
