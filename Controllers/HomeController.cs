using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuiThiKimNganBTH.Models;

namespace BuiThiKimNganBTH.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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
[HttpPost]
public IActionResult Index(String FullName, string Email)
{
    ViewBag.name = "Hello" + "_" + FullName + "_" + Email;
    return View();
}

}
