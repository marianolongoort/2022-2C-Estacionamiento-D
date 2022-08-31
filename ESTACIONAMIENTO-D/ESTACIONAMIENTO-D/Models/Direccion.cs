namespace ESTACIONAMIENTO_D.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}