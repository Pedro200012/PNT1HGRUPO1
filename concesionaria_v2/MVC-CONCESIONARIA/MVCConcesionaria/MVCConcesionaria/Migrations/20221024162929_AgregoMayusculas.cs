using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class AgregoMayusculas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Motos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Motos",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "esUsado",
                table: "Motos",
                newName: "EsUsado");

            migrationBuilder.RenameColumn(
                name: "cantKm",
                table: "Motos",
                newName: "CantKm");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Camionetas",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Camionetas",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "esUsado",
                table: "Camionetas",
                newName: "EsUsado");

            migrationBuilder.RenameColumn(
                name: "esDobleCabina",
                table: "Camionetas",
                newName: "EsDobleCabina");

            migrationBuilder.RenameColumn(
                name: "es4x4",
                table: "Camionetas",
                newName: "Es4x4");

            migrationBuilder.RenameColumn(
                name: "cantKm",
                table: "Camionetas",
                newName: "CantKm");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Autos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Autos",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "esUsado",
                table: "Autos",
                newName: "EsUsado");

            migrationBuilder.RenameColumn(
                name: "cantPuertas",
                table: "Autos",
                newName: "CantPuertas");

            migrationBuilder.RenameColumn(
                name: "cantKm",
                table: "Autos",
                newName: "CantKm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Motos",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Motos",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "EsUsado",
                table: "Motos",
                newName: "esUsado");

            migrationBuilder.RenameColumn(
                name: "CantKm",
                table: "Motos",
                newName: "cantKm");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Camionetas",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Camionetas",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "EsUsado",
                table: "Camionetas",
                newName: "esUsado");

            migrationBuilder.RenameColumn(
                name: "EsDobleCabina",
                table: "Camionetas",
                newName: "esDobleCabina");

            migrationBuilder.RenameColumn(
                name: "Es4x4",
                table: "Camionetas",
                newName: "es4x4");

            migrationBuilder.RenameColumn(
                name: "CantKm",
                table: "Camionetas",
                newName: "cantKm");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Autos",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Autos",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "EsUsado",
                table: "Autos",
                newName: "esUsado");

            migrationBuilder.RenameColumn(
                name: "CantPuertas",
                table: "Autos",
                newName: "cantPuertas");

            migrationBuilder.RenameColumn(
                name: "CantKm",
                table: "Autos",
                newName: "cantKm");
        }
    }
}
