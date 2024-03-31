using Microsoft.AspNetCore.Mvc;

namespace MvcCoreViewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> items = new List<string>() { "Moscow", "Tula", "Voroneg" };
            ViewData["Title"] = "Home page";
            ViewBag.Hello = "Hello people!";

            ViewData["Cities"] = items;
            ViewBag.Cities = items;

            var users = new string[] { "Tommy", "Bobby", "Jimmy" };
            
            return View(users);
        }
    }
}
