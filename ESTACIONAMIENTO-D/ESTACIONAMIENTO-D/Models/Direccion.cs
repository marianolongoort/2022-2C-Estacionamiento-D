using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESTACIONAMIENTO_D.Models
{
    public class Direccion
    {
        [Key,ForeignKey("Cliente")]
        public int Id { get; set; }

        public string Calle { get; set; }


        public int Numero { get; set; }
        
        public Cliente Cliente { get; set; }
    }
}