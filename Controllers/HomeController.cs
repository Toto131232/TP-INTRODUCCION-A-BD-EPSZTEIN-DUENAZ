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
        string nombreusuario = HttpContext.Session.GetString("NombreDeUsuario");

        if (!string.IsNullOrEmpty(nombreusuario))
        {
            var integrante = Integrante.BuscarXUsuar(nombreusuario);
            return View(integrante);
        }

        return View(null); 
    }
    public IActionResult Iniciarsesion(string nombre, string contraseña)
    {
         var integrante = Integrante.LevantarIntegrantes(nombre, contraseña);

        if (integrante != null)
        {
            HttpContext.Session.SetString("NombreDeUsuario", integrante.NombreUsuario);
            return RedirectToAction();
        }
        else
        {
            ViewBag.ErrorAlIniciarSesion = "Incorrecto";
            return View("IniciarSesion");
        }
    }

    public IActionResult Informacion()
    {
        string integrante2 = HttpContext.Session.GetString("integrante");
        Integrante? integrante = Objeto.StringToObject<Integrante>(integrante2);
        ViewBag.Integrante = integrante;
        ViewBag.Foto = HttpContext.Session.GetString("foto");
        return View();
    }

    public IActionResult CerrarSesion()
    {
        HttpContext.Session.Clear();
        return View("Index");
    }
    public IActionResult IniciarSesion(string nombre, string password)
    {
        return View("InciarSesion");
    }
     public IActionResult Registro()
    {
        return View("Registro");
    }
}