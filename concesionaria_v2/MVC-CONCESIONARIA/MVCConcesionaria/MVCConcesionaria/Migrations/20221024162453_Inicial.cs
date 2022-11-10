using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    esUsado = table.Column<bool>(nullable: false),
                    cantKm = table.Column<double>(nullable: false),
                    cantPuertas = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    PhotoFile = table.Column<byte[]>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Camionetas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    esUsado = table.Column<bool>(nullable: false),
                    cantKm = table.Column<double>(nullable: false),
                    es4x4 = table.Column<bool>(nullable: false),
                    esDobleCabina = table.Column<bool>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    PhotoFile = table.Column<byte[]>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camionetas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    esUsado = table.Column<bool>(nullable: false),
                    cantKm = table.Column<double>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    PhotoFile = table.Column<byte[]>(nullable: true),
                    ImageMimeType = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "Camionetas");

            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
