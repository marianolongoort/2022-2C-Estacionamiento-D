using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESTACIONAMIENTO_D.Models
{
    public class ClienteVehiculo
    {
        [Key,ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [Key,ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }

        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }

    }
}