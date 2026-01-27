using Microsoft.AspNetCore.Mvc;

public class ViduViewBagController : Controller
{
    public IActionResult Vidu()
    {
        ViewBag.Message = "Xin chào, đây là trang Home";
        ViewBag.Year = 2026;

        return View();
    }
}