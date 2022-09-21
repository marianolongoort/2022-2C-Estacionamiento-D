using ESTACIONAMIENTO_D.Data;
using ESTACIONAMIENTO_D.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESTACIONAMIENTO_D.Controllers
{
    public class PreCargaDb : Controller
    {
        private readonly EstacionamientoContext _context;

        public PreCargaDb(EstacionamientoContext context)
        {
            this._context = context;
        }

        public IActionResult Inicializar()
        {
            CrearPersonas();
            return RedirectToAction("Index","Personas");
        }

        private void CrearPersonas()
        {
            Persona persona = new Persona() { 
                Nombre = "Pedro", 
                Apellido = "Picapiedra",
                Email = "pedro@ort.edu.ar",
                FechaNacimiento = new DateTime(1977,8,10)
            
            };
            _context.Personas.Add(persona);
            _context.SaveChanges();

        }
    }
}
