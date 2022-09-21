using ESTACIONAMIENTO_D.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;

namespace ESTACIONAMIENTO_D.Data
{
    public class RepositorioPersonas
    {
        private List<Persona> _personas;

        public RepositorioPersonas()
        {
            _personas = new List<Persona>();
            _personas.Add(new Persona() { Nombre = "Pedro", Apellido = "Picapiedra" });
            _personas.Add(new Persona() { Nombre = "Pablo", Apellido = "Marmol" });
        }


        public List<Persona> Personas{ 
            get{ return _personas; } 
            set{ _personas = value;} 
        }
    }
}
