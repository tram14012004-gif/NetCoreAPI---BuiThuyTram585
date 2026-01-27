using Microsoft.AspNetCore.Mvc;

public class ViewBagController : Controller
{
    public IActionResult Vidu()
    {
        ViewBag.Message = "Xin chào, đây là trang Home";
        ViewBag.Year = 2026;

        return View();
    }
}