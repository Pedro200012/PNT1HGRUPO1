using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class ventas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VentaAuto",
                columns: table => new
                {
                    IdVentAuto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: true),
                    clientePersonaId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: true),
                    autoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaAuto", x => x.IdVentAuto);
                    table.ForeignKey(
                        name: "FK_VentaAuto_Autos_autoID",
                        column: x => x.autoID,
                        principalTable: "Autos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentaAuto_Persona_clientePersonaId",
                        column: x => x.clientePersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VentaCamioneta",
                columns: table => new
                {
                    IdVentaCamioneta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: true),
                    clientePersonaId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: true),
                    camionetaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaCamioneta", x => x.IdVentaCamioneta);
                    table.ForeignKey(
                        name: "FK_VentaCamioneta_Camionetas_camionetaID",
                        column: x => x.camionetaID,
                        principalTable: "Camionetas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentaCamioneta_Persona_clientePersonaId",
                        column: x => x.clientePersonaId,
                        principalTable: "Persona",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaAuto_autoID",
                table: "VentaAuto",
                column: "autoID");

            migrationBuilder.CreateIndex(
                name: "IX_VentaAuto_clientePersonaId",
                table: "VentaAuto",
                column: "clientePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaCamioneta_camionetaID",
                table: "VentaCamioneta",
                column: "camionetaID");

            migrationBuilder.CreateIndex(
                name: "IX_VentaCamioneta_clientePersonaId",
                table: "VentaCamioneta",
                column: "clientePersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaAuto");

            migrationBuilder.DropTable(
                name: "VentaCamioneta");
        }
    }
}
