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
    public IActionResult Iniciarsesion(string nombre, string contraseña)
    {
        Integrante integrante = BD.LevantarIntegrantes(nombre, contraseña);
        if (integrante != null)
        {
            string integrante2 = Objeto.ObjectToString(integrante);
            HttpContext.Session.SetString("integrante", integrante2);
            string foto = "";
            if (integrante.NombreUsuarioOEmail.ToLower().Contains("Toto"))
                foto = "toto.png";
            else if (integrante.NombreUsuarioOEmail.ToLower().Contains("Dudu"))
                foto = "dudu.jpg";
            else if (integrante.NombreUsuarioOEmail.ToLower().Contains("Dorin"))
                foto = "dorin.jpg";
            HttpContext.Session.SetString("foto", foto);
            Integrante.Nombre = ViewBag.Integrante.CuadroDeFutbol;
            Integrante.Nombre = ViewBag.Integrante.edad;
            Integrante.Nombre = ViewBag.Integrante.Apellido;
            Integrante.Nombre = ViewBag.Integrante.ComidaFavorita;
            Integrante.Apellido = ViewBag.Integrante.Apellido;
            Integrante.CuadroDeFutbol = ViewBag.Integrante.CuadrodeFutbol;
            Integrante.ComidaFavorita = ViewBag.Integrante.ComidaFavorita;
            Integrante.Edad = ViewBag.Integrante.Edad;
            return View("Info");

        }
        else
        {
            return View();
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

    public IActionResult Desloguear()
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