using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class ViewBagController : Controller
{
    private readonly ILogger<ViewBagController> _logger;

    public ViewBagController(ILogger<ViewBagController> logger)
    {
        _logger = logger;
    }

    public IActionResult Vidu()
    {
        ViewBag.Message = "Xin chào, đây là trang Home";
        ViewBag.Year = 2026;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
