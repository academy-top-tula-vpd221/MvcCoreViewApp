using Microsoft.AspNetCore.Mvc;

namespace MvcCoreViewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home page";
            ViewBag.Hello = "Hello people!";
            return View();
        }
    }
}
