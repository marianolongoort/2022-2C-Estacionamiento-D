﻿namespace ESTACIONAMIENTO_D.Models
{
    public class Cliente : Persona
    {
        public int Dni { get; set; }

        public Direccion Direccion { get; set; }

        public List<ClienteVehiculo> ClientesVehiculos { get; set; }
    }
}
