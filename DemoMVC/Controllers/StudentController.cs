namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
         public IActionResult Index(string fullName, string StudentsCode)
        {
            ViewBag.Message = "Xin chào " + fullName;
            return View();
        }
    }
}