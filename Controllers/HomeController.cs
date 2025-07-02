using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_INTRODUCCION_A_BD_EPSZTEIN_DUENAZ.Models;

namespace TP_INTRODUCCION_A_BD_EPSZTEIN_DUENAZ.Controllers;

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
}
