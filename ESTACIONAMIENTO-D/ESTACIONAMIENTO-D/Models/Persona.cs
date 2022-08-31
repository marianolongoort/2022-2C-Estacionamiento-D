namespace ESTACIONAMIENTO_D.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }        

        public List<Telefono> Telefonos { get; set; }


    }
}
