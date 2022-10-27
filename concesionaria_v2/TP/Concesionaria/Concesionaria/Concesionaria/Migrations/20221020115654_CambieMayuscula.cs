using Microsoft.EntityFrameworkCore.Migrations;

namespace Concesionaria.Migrations
{
    public partial class CambieMayuscula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Personas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Personas",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "personaId",
                table: "Personas",
                newName: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Personas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Personas",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Personas",
                newName: "personaId");
        }
    }
}
