using ESTACIONAMIENTO_D.Data;
using ESTACIONAMIENTO_D.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESTACIONAMIENTO_D.Controllers
{
    public class PersonasOldController : Controller
    {
        private readonly EstacionamientoContext _estacionamientoContext;

        public PersonasOldController(EstacionamientoContext contexto)
        {
            this._estacionamientoContext = contexto;
        }      

        //listamos los objetos de la entidad.
        public IActionResult Index()
         {
            //RepositorioPersonas repo = new RepositorioPersonas();
            var personas = _estacionamientoContext.Personas.ToList();
            
            return View(personas);
        }

        //ofrece el formulario de creacion
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        //para crear una persona
        public IActionResult Create(string nombre, string apellido)
        {
            //https://localhost:7074/personas/create?nombre=Pedro&Apellido=Picapiedra
            Persona persona = new Persona() { Nombre = nombre,Apellido = apellido};

            _estacionamientoContext.Personas.Add(persona);
            _estacionamientoContext.SaveChanges();
            
            
            return RedirectToAction("Index");
        }
    }
}
