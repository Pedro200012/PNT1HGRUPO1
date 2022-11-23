using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Anio",
                table: "Motos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Motos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Anio",
                table: "Camionetas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Camionetas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Anio",
                table: "Autos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Autos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Camionetas");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Camionetas");

            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Autos");
        }
    }
}
