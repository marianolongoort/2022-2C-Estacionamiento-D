using System.ComponentModel.DataAnnotations;

namespace ESTACIONAMIENTO_D.Models
{
    public class Persona
    {
        

        public int Id { get; set; }

        
        [Required(ErrorMessage = ErrorMsg.MsgReq)]
        [MaxLength(50)]
        [MinLength(2)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = ErrorMsg.MsgReq)]
        [MaxLength(50)]
        public string Apellido { get; set; }        

        public List<Telefono> Telefonos { get; set; }


    }
}
