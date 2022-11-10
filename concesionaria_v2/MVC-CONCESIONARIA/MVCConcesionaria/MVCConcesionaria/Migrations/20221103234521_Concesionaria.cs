using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCConcesionaria.Migrations
{
    public partial class Concesionaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Motos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Motos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "Motos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Motos",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoFile",
                table: "Motos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Camionetas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Camionetas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "Camionetas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Camionetas",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoFile",
                table: "Camionetas",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Autos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Autos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "Autos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Autos",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoFile",
                table: "Autos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "PhotoFile",
                table: "Motos");

            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "Camionetas");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Camionetas");

            migrationBuilder.DropColumn(
                name: "PhotoFile",
                table: "Camionetas");

            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Autos");

            migrationBuilder.DropColumn(
                name: "PhotoFile",
                table: "Autos");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Motos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Motos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Camionetas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Camionetas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Autos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Autos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
