using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.Name = "Hello " + FullName;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}