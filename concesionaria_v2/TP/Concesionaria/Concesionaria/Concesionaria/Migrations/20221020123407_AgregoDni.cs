using Microsoft.EntityFrameworkCore.Migrations;

namespace Concesionaria.Migrations
{
    public partial class AgregoDni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaDNI",
                table: "Personas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonaDNI",
                table: "Personas");
        }
    }
}
