namespace ESTACIONAMIENTO_D.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public int Numero { get; set; }



        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
