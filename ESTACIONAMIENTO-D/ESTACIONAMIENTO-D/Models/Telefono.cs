using System.ComponentModel.DataAnnotations;

namespace ESTACIONAMIENTO_D.Models
{
    public class Telefono
    {        
        public int Id { get; set; }

        [Range(100000,99999999,ErrorMessage = "El {0} debe estar comprendido entre {1} y {2}")]
        public int Numero { get; set; }



        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
