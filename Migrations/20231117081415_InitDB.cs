using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schebeautyshop.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoriasPs",
                columns: table => new
                {
                    CategoriasPID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoriasPs", x => x.CategoriasPID);
                });

            migrationBuilder.CreateTable(
                name: "categoriasS",
                columns: table => new
                {
                    CategoriasSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoriasS", x => x.CategoriasSID);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio_p = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriasPID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Productos_categoriasPs_CategoriasPID",
                        column: x => x.CategoriasPID,
                        principalTable: "categoriasPs",
                        principalColumn: "CategoriasPID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    ServicioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio_S = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sesiones = table.Column<int>(type: "int", nullable: false),
                    FechayHoraDisponible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriasSID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.ServicioID);
                    table.ForeignKey(
                        name: "FK_Servicios_categoriasS_CategoriasSID",
                        column: x => x.CategoriasSID,
                        principalTable: "categoriasS",
                        principalColumn: "CategoriasSID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriasPID",
                table: "Productos",
                column: "CategoriasPID");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CategoriasSID",
                table: "Servicios",
                column: "CategoriasSID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "categoriasPs");

            migrationBuilder.DropTable(
                name: "categoriasS");
        }
    }
}
