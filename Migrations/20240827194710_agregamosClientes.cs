using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformatico.Migrations
{
    /// <inheritdoc />
    public partial class agregamosClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Direccion", "FechaNacimiento", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Juan Pérez", "123456789" },
                    { 2, "Avenida Siempre Viva 742", new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "María López", "987654321" },
                    { 4, "Ruta Nacional 19 Km 58", new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ana Martínez", "444555666" },
                    { 5, "Calle del Sol 456", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pedro Fernández", "333444555" }
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Escalada" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Direccion", "FechaNacimiento", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[] { 3, "Boulevard de los Sueños Rotos 101", new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Carlos García", "555666777" });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DeleteData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
