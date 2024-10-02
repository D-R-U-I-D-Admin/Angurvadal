using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Angurvadal.Models;

namespace Angurvadal.Controllers;

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

    [Route("/About")]
    public IActionResult About()
    {
        return View();
    }    

    [Route("/Projects")]
    public IActionResult Projects()
    {
        return View();
    }

    // [Route("/Privacy")]
    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [Route("/Updates")]
    public IActionResult Updates()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
