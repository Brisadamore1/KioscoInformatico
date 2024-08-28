using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformatico.Migrations
{
    /// <inheritdoc />
    public partial class agregamosProveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
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
                    Cbu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CondicionIva = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Cbu", "CondicionIva", "Direccion", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "0000003100010000000001", 0, "Calle 1", 1, "Proveedor A", "111111111" },
                    { 2, "0000003100010000000002", 5, "Calle 2", 2, "Proveedor B", "222222222" },
                    { 3, "0000003100010000000003", 4, "Calle 3", 3, "Proveedor C", "333333333" },
                    { 4, "0000003100010000000004", 2, "Calle 4", 4, "Proveedor D", "444444444" },
                    { 5, "0000003100010000000005", 3, "Calle 5", 5, "Proveedor E", "555555555" },
                    { 6, "0000003100010000000006", 1, "Calle 6", 6, "Proveedor F", "666666666" },
                    { 7, "0000003100010000000007", 0, "Calle 7", 7, "Proveedor G", "777777777" },
                    { 8, "0000003100010000000008", 6, "Calle 8", 8, "Proveedor H", "888888888" },
                    { 9, "0000003100010000000009", 5, "Calle 9", 9, "Proveedor I", "999999999" },
                    { 10, "0000003100010000000010", 2, "Calle 10", 10, "Proveedor J", "101010101" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_LocalidadId",
                table: "Proveedores",
                column: "LocalidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
