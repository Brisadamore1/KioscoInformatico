using KioscoInformatico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformatico.DataContext
{
    public class KioscoContext : DbContext
    {
        //constructor vacío
        public KioscoContext()
        {
            
        }
        public KioscoContext(DbContextOptions<KioscoContext> options) : base(options) 
        {
              
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string? cadenaConexion = configuration.GetConnectionString("mysqlLocal");


            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //carga de datos semilla
            modelBuilder.Entity<Producto>().HasData(
                new Producto() { Id= 1, Nombre="Coca Cola 2lts", Precio=2650},
                new Producto() { Id = 2, Nombre = "Sprite 2lts", Precio = 2450 },
                new Producto() { Id = 3, Nombre = "Fanta 2lts", Precio = 2550 }
                );
            //carga de datos semilla de localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad() { Id=1, Nombre="San Justo"},
                new Localidad() { Id=2, Nombre="Videla"},
                new Localidad() { Id=3, Nombre="Escalada"}
                );
            //carga de datos semilla de clientes
            modelBuilder.Entity<Cliente>().HasData(
            new Cliente
            {
                Id = 1,
                Nombre = "Juan Pérez",
                Direccion = "Calle Falsa 123",
                Telefonos = "123456789",
                FechaNacimiento = new DateTime(1985, 5, 15),
                LocalidadId = 1
            },
            new Cliente
            {
                Id = 2,
                Nombre = "María López",
                Direccion = "Avenida Siempre Viva 742",
                Telefonos = "987654321",
                FechaNacimiento = new DateTime(1990, 8, 25),
                LocalidadId = 2
            },
            new Cliente
            {
                Id = 3,
                Nombre = "Carlos García",
                Direccion = "Boulevard de los Sueños Rotos 101",
                Telefonos = "555666777",
                FechaNacimiento = new DateTime(1978, 2, 3),
                LocalidadId = 3
            },
            new Cliente
            {
                Id = 4,
                Nombre = "Ana Martínez",
                Direccion = "Ruta Nacional 19 Km 58",
                Telefonos = "444555666",
                FechaNacimiento = new DateTime(2000, 12, 12),
                LocalidadId = 1
            },
            new Cliente
            {
                Id = 5,
                Nombre = "Pedro Fernández",
                Direccion = "Calle del Sol 456",
                Telefonos = "333444555",
                FechaNacimiento = new DateTime(1995, 7, 30),
                LocalidadId = 2
            }
            );
            //Carga de datos semillas
            modelBuilder.Entity<Venta>().HasData(
                new Venta() { Id = 1, FormaPago = "Efectivo", Iva = 21m, Total = 3000m },
                new Venta() { Id = 2, FormaPago = "Tarjeta de Crédito", Iva = 10, Total = 5000m },
                new Venta() { Id = 3, FormaPago = "Tarjeta de Débito", Iva = 21, Total = 8000m }
            );
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
