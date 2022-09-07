using System.ComponentModel.DataAnnotations;

namespace ESTACIONAMIENTO_D.Models
{
    public class Cliente : Persona
    {
        [Range(1,int.MaxValue)]
        public int Dni { get; set; }


        public Direccion Direccion { get; set; }


        public List<ClienteVehiculo> ClientesVehiculos { get; set; }
    }
}
