using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string fullName, string StudentCode)
        {
            ViewBag.Message = "Xin chào " + fullName + " - MSV: " + StudentCode;
            return View();
        }
    }
}