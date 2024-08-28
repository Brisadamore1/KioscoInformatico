using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformatico.Migrations
{
    /// <inheritdoc />
    public partial class agregamosDetalleCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FormaPago",
                table: "Ventas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Ventas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaDePago = table.Column<int>(type: "int", nullable: false),
                    Iva = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProveedorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_ProveedorID",
                        column: x => x.ProveedorID,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "ID", "Fecha", "FormaDePago", "Iva", "ProveedorID", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 21, 1, 1000 },
                    { 2, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10, 2, 2000 },
                    { 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, 3, 3000 },
                    { 4, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, 4, 4000 }
                });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClienteId", "Fecha", "FormaPago" },
                values: new object[] { 1, new DateTime(2024, 8, 28, 16, 39, 12, 906, DateTimeKind.Local).AddTicks(9467), 1 });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClienteId", "Fecha", "FormaPago" },
                values: new object[] { 2, new DateTime(2024, 8, 28, 16, 39, 12, 906, DateTimeKind.Local).AddTicks(9473), 4 });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClienteId", "Fecha", "FormaPago" },
                values: new object[] { 3, new DateTime(2024, 8, 28, 16, 39, 12, 906, DateTimeKind.Local).AddTicks(9477), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProveedorID",
                table: "Compras",
                column: "ProveedorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Ventas");

            migrationBuilder.AlterColumn<string>(
                name: "FormaPago",
                table: "Ventas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FormaPago",
                value: "Efectivo");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FormaPago",
                value: "Tarjeta de Crédito");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FormaPago",
                value: "Tarjeta de Débito");
        }
    }
}
