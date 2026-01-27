using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HelloController : Controller
    {
        // Mở trang
        [HttpGet]
        public IActionResult ()
        {
            return View();
        }

        // Nhận dữ liệu từ form
        [HttpPost]
        public IActionResult Index(string fullName)
        {
            ViewBag.Message = "Xin chào " + fullName;
            return View();
        }
    }
}