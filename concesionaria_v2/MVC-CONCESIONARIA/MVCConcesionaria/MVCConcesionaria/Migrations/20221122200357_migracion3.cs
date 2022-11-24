using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaDNI = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "VentaMoto",
                columns: table => new
                {
                    IdVentaMoto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: true),
                    clientePersonaId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: true),
                    motoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaMoto", x => x.IdVentaMoto);
                    table.ForeignKey(
                        name: "FK_VentaMoto_Persona_clientePersonaId",
                        column: x => x.clientePersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentaMoto_Motos_motoID",
                        column: x => x.motoID,
                        principalTable: "Motos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaMoto_clientePersonaId",
                table: "VentaMoto",
                column: "clientePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaMoto_motoID",
                table: "VentaMoto",
                column: "motoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaMoto");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
