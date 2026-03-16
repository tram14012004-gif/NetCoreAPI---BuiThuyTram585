namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using DemoMVC.Models.Entities;

    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.ThongBao = std.StudentCode + " - " + std.FullName;
            return View();
        }
    }

}