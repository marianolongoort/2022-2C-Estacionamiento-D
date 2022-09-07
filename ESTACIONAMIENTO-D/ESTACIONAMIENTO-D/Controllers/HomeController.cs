using ESTACIONAMIENTO_D.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ESTACIONAMIENTO_D.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

            ViewBag.Persona = new Persona() { Apellido="Picapiedra",Nombre="Pedro"};

            ViewResult resultado = View(numeros);
            return resultado;
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
}