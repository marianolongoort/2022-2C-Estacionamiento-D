using System.ComponentModel.DataAnnotations;

namespace ESTACIONAMIENTO_D.Models
{
    public class Persona
    {
        

        public int Id { get; set; }

        
        [Required(ErrorMessage = ErrorMsg.MsgReq)]
        [MaxLength(50,ErrorMessage = ErrorMsg.MsgMaxStr)]
        [MinLength(2,ErrorMessage = "La propiedad {0} debe tener como min {1} caracteres")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="La prop {0} debe estar comprendida entre {2} y {1}")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = ErrorMsg.MsgReq)]
        [MaxLength(50)]
        public string Apellido { get; set; }        

        public List<Telefono> Telefonos { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }



        public string NombreCompleto { 
            get {
                if (string.IsNullOrEmpty(Apellido) && string.IsNullOrEmpty(Nombre)) return "Sin definir" ;
                if (string.IsNullOrEmpty(Apellido)) return Nombre;
                if (string.IsNullOrEmpty(Nombre)) return Apellido;
                return $"{Apellido}, {Nombre}";
            }
        }


    }
}
