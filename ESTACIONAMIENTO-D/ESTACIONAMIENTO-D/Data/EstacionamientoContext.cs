using ESTACIONAMIENTO_D.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;

namespace ESTACIONAMIENTO_D.Data
{
    public class EstacionamientoContext : DbContext
    {
        public EstacionamientoContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClienteVehiculo>().HasKey(cv => new { cv.ClienteId,cv.VehiculoId });
            modelBuilder.Entity<ClienteVehiculo>()
                                              .HasOne(cv => cv.Cliente)
                                              .WithMany(cliente => cliente.ClientesVehiculos)
                                              .HasForeignKey(cv => cv.ClienteId);

            modelBuilder.Entity<ClienteVehiculo>()
                                   .HasOne(cv => cv.Vehiculo)
                                   .WithMany(vehiculo => vehiculo.ClientesVehiculos)
                                   .HasForeignKey(cv => cv.VehiculoId);

        }

        public DbSet<Persona> Personas { get; set; }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<ClienteVehiculo> ClientesVehiculos{ get; set; }

    }
}
