using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class ViduViewBagController : Controller
{
    private readonly ILogger<ViduViewBagController> _logger;

    public ViduViewBagController(ILogger<ViduViewBagController> logger)
    {
        _logger = logger;
    }

    public IActionResult Vidu()
    {
        ViewBag.Message = "Xin chào, đây là trang của Trâm";
        ViewBag.Year = 2004;

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
