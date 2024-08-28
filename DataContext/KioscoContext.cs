﻿using KioscoInformatico.Enums;
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

                );
            //carga de datos semilla de proveedores
            modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor
            {
                Id = 1,
                Nombre = "Proveedor A",
                Direccion = "Calle 1",
                Telefonos = "111111111",
                Cbu = "0000003100010000000001",
                CondicionIva = CondicionIvaEnum.ResponsableInscripto,
                LocalidadId = 1
            },
            new Proveedor
            {
                Id = 2,
                Nombre = "Proveedor B",
                Direccion = "Calle 2",
                Telefonos = "222222222",
                Cbu = "0000003100010000000002",
                CondicionIva = CondicionIvaEnum.Monotributista,
                LocalidadId = 2
            },
            new Proveedor
            {
                Id = 3,
                Nombre = "Proveedor C",
                Direccion = "Calle 3",
                Telefonos = "333333333",
                Cbu = "0000003100010000000003",
                CondicionIva = CondicionIvaEnum.ConsumidorFinal,
                LocalidadId = 3
            },
            new Proveedor
            {
                Id = 4,
                Nombre = "Proveedor D",
                Direccion = "Calle 4",
                Telefonos = "444444444",
                Cbu = "0000003100010000000004",
                CondicionIva = CondicionIvaEnum.Exento,
                LocalidadId = 4
            },
            new Proveedor
            {
                Id = 5,
                Nombre = "Proveedor E",
                Direccion = "Calle 5",
                Telefonos = "555555555",
                Cbu = "0000003100010000000005",
                CondicionIva = CondicionIvaEnum.NoResponsable,
                LocalidadId = 5
            },
            new Proveedor
            {
                Id = 6,
                Nombre = "Proveedor F",
                Direccion = "Calle 6",
                Telefonos = "666666666",
                Cbu = "0000003100010000000006",
                CondicionIva = CondicionIvaEnum.ResponsableNoInscripto,
                LocalidadId = 6
            },
            new Proveedor
            {
                Id = 7,
                Nombre = "Proveedor G",
                Direccion = "Calle 7",
                Telefonos = "777777777",
                Cbu = "0000003100010000000007",
                CondicionIva = CondicionIvaEnum.ResponsableInscripto,
                LocalidadId = 7
            },
            new Proveedor
            {
                Id = 8,
                Nombre = "Proveedor H",
                Direccion = "Calle 8",
                Telefonos = "888888888",
                Cbu = "0000003100010000000008",
                CondicionIva = CondicionIvaEnum.SujetoNoCategorizado,
                LocalidadId = 8
            },
            new Proveedor
            {
                Id = 9,
                Nombre = "Proveedor I",
                Direccion = "Calle 9",
                Telefonos = "999999999",
                Cbu = "0000003100010000000009",
                CondicionIva = CondicionIvaEnum.Monotributista,
                LocalidadId = 9
            },
            new Proveedor
            {
                Id = 10,
                Nombre = "Proveedor J",
                Direccion = "Calle 10",
                Telefonos = "101010101",
                Cbu = "0000003100010000000010",
                CondicionIva = CondicionIvaEnum.Exento,
                LocalidadId = 10
            }
        );
            //carga de datos semilla de detalle compra
            modelBuilder.Entity<DetalleCompra>().HasData(
                new DetalleCompra { Id = 1, ProductosId = 1, PrecioUnitario = 2650, Cantidad = 1, CompraId = 1 },
                new DetalleCompra { Id = 2, ProductosId = 2, PrecioUnitario = 2450, Cantidad = 2, CompraId = 2 },
                new DetalleCompra { Id = 3, ProductosId = 3, PrecioUnitario = 2550, Cantidad = 1, CompraId = 3 }
                );
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        public DbSet<DetalleCompra> DetallesCompras { get; set; }

    }
}
