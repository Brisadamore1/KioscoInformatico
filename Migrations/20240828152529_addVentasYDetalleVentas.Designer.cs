﻿// <auto-generated />
using System;
using KioscoInformatico.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KioscoInformatico.Migrations
{
    [DbContext(typeof(KioscoContext))]
    [Migration("20240828152529_addVentasYDetalleVentas")]
    partial class addVentasYDetalleVentas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("KioscoInformatico.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Calle Falsa 123",
                            FechaNacimiento = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 1,
                            Nombre = "Juan Pérez",
                            Telefonos = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "Avenida Siempre Viva 742",
                            FechaNacimiento = new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 2,
                            Nombre = "María López",
                            Telefonos = "987654321"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "Boulevard de los Sueños Rotos 101",
                            FechaNacimiento = new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 3,
                            Nombre = "Carlos García",
                            Telefonos = "555666777"
                        },
                        new
                        {
                            Id = 4,
                            Direccion = "Ruta Nacional 19 Km 58",
                            FechaNacimiento = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 1,
                            Nombre = "Ana Martínez",
                            Telefonos = "444555666"
                        },
                        new
                        {
                            Id = 5,
                            Direccion = "Calle del Sol 456",
                            FechaNacimiento = new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 2,
                            Nombre = "Pedro Fernández",
                            Telefonos = "333444555"
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.DetalleCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetallesCompras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 1,
                            CompraId = 1,
                            PrecioUnitario = 2650m,
                            ProductosId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 2,
                            CompraId = 2,
                            PrecioUnitario = 2450m,
                            ProductosId = 2
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 1,
                            CompraId = 3,
                            PrecioUnitario = 2550m,
                            ProductosId = 3
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Localidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "San Justo"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Videla"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Escalada"
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Coca Cola 2lts",
                            Precio = 2650m
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Sprite 2lts",
                            Precio = 2450m
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Fanta 2lts",
                            Precio = 2550m
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cbu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CondicionIva")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Proveedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cbu = "0000003100010000000001",
                            CondicionIva = 0,
                            Direccion = "Calle 1",
                            LocalidadId = 1,
                            Nombre = "Proveedor A",
                            Telefonos = "111111111"
                        },
                        new
                        {
                            Id = 2,
                            Cbu = "0000003100010000000002",
                            CondicionIva = 5,
                            Direccion = "Calle 2",
                            LocalidadId = 2,
                            Nombre = "Proveedor B",
                            Telefonos = "222222222"
                        },
                        new
                        {
                            Id = 3,
                            Cbu = "0000003100010000000003",
                            CondicionIva = 4,
                            Direccion = "Calle 3",
                            LocalidadId = 3,
                            Nombre = "Proveedor C",
                            Telefonos = "333333333"
                        },
                        new
                        {
                            Id = 4,
                            Cbu = "0000003100010000000004",
                            CondicionIva = 2,
                            Direccion = "Calle 4",
                            LocalidadId = 4,
                            Nombre = "Proveedor D",
                            Telefonos = "444444444"
                        },
                        new
                        {
                            Id = 5,
                            Cbu = "0000003100010000000005",
                            CondicionIva = 3,
                            Direccion = "Calle 5",
                            LocalidadId = 5,
                            Nombre = "Proveedor E",
                            Telefonos = "555555555"
                        },
                        new
                        {
                            Id = 6,
                            Cbu = "0000003100010000000006",
                            CondicionIva = 1,
                            Direccion = "Calle 6",
                            LocalidadId = 6,
                            Nombre = "Proveedor F",
                            Telefonos = "666666666"
                        },
                        new
                        {
                            Id = 7,
                            Cbu = "0000003100010000000007",
                            CondicionIva = 0,
                            Direccion = "Calle 7",
                            LocalidadId = 7,
                            Nombre = "Proveedor G",
                            Telefonos = "777777777"
                        },
                        new
                        {
                            Id = 8,
                            Cbu = "0000003100010000000008",
                            CondicionIva = 6,
                            Direccion = "Calle 8",
                            LocalidadId = 8,
                            Nombre = "Proveedor H",
                            Telefonos = "888888888"
                        },
                        new
                        {
                            Id = 9,
                            Cbu = "0000003100010000000009",
                            CondicionIva = 5,
                            Direccion = "Calle 9",
                            LocalidadId = 9,
                            Nombre = "Proveedor I",
                            Telefonos = "999999999"
                        },
                        new
                        {
                            Id = 10,
                            Cbu = "0000003100010000000010",
                            CondicionIva = 2,
                            Direccion = "Calle 10",
                            LocalidadId = 10,
                            Nombre = "Proveedor J",
                            Telefonos = "101010101"
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FormaPago = "Efectivo",
                            Iva = 21m,
                            Total = 3000m
                        },
                        new
                        {
                            Id = 2,
                            FormaPago = "Tarjeta de Crédito",
                            Iva = 10m,
                            Total = 5000m
                        },
                        new
                        {
                            Id = 3,
                            FormaPago = "Tarjeta de Débito",
                            Iva = 21m,
                            Total = 8000m
                        });
                });

            modelBuilder.Entity("KioscoInformatico.Models.Cliente", b =>
                {
                    b.HasOne("KioscoInformatico.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("KioscoInformatico.Models.DetalleCompra", b =>
                {
                    b.HasOne("KioscoInformatico.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("KioscoInformatico.Models.Proveedor", b =>
                {
                    b.HasOne("KioscoInformatico.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId");

                    b.Navigation("Localidad");
                });
#pragma warning restore 612, 618
        }
    }
}
