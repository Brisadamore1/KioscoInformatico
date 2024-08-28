using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformatico.Migrations
{
    /// <inheritdoc />
    public partial class addVentasYDetalleVentas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductosId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesCompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaPago = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Iva = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "Id", "Cantidad", "CompraId", "PrecioUnitario", "ProductoId", "ProductosId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2650m, null, 1 },
                    { 2, 2, 2, 2450m, null, 2 },
                    { 3, 1, 3, 2550m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "FormaPago", "Iva", "Total" },
                values: new object[,]
                {
                    { 1, "Efectivo", 21m, 3000m },
                    { 2, "Tarjeta de Crédito", 10m, 5000m },
                    { 3, "Tarjeta de Débito", 21m, 8000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesCompras_ProductoId",
                table: "DetallesCompras",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesCompras");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
