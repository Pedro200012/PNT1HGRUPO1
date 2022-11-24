﻿// <auto-generated />
using System;
using MVCConcesionaria.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCConcesionaria.Migrations
{
    [DbContext(typeof(ConcesionariaDatabaseContext))]
    [Migration("20221124152039_ventas")]
    partial class ventas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCConcesionaria.Models.Auto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<double>("CantKm")
                        .HasColumnType("float");

                    b.Property<int>("CantPuertas")
                        .HasColumnType("int");

                    b.Property<bool>("EsUsado")
                        .HasColumnType("bit");

                    b.Property<string>("ImageMimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Autos");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.Camioneta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<double>("CantKm")
                        .HasColumnType("float");

                    b.Property<bool>("Es4x4")
                        .HasColumnType("bit");

                    b.Property<bool>("EsDobleCabina")
                        .HasColumnType("bit");

                    b.Property<bool>("EsUsado")
                        .HasColumnType("bit");

                    b.Property<string>("ImageMimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Camionetas");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.Moto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<double>("CantKm")
                        .HasColumnType("float");

                    b.Property<bool>("EsUsado")
                        .HasColumnType("bit");

                    b.Property<string>("ImageMimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Motos");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaDNI")
                        .HasColumnType("int");

                    b.HasKey("PersonaId");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaAuto", b =>
                {
                    b.Property<int>("IdVentAuto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("autoID")
                        .HasColumnType("int");

                    b.Property<int?>("clientePersonaId")
                        .HasColumnType("int");

                    b.HasKey("IdVentAuto");

                    b.HasIndex("autoID");

                    b.HasIndex("clientePersonaId");

                    b.ToTable("VentaAuto");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaCamioneta", b =>
                {
                    b.Property<int>("IdVentaCamioneta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("camionetaID")
                        .HasColumnType("int");

                    b.Property<int?>("clientePersonaId")
                        .HasColumnType("int");

                    b.HasKey("IdVentaCamioneta");

                    b.HasIndex("camionetaID");

                    b.HasIndex("clientePersonaId");

                    b.ToTable("VentaCamioneta");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaMoto", b =>
                {
                    b.Property<int>("IdVentaMoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("clientePersonaId")
                        .HasColumnType("int");

                    b.Property<int?>("motoID")
                        .HasColumnType("int");

                    b.HasKey("IdVentaMoto");

                    b.HasIndex("clientePersonaId");

                    b.HasIndex("motoID");

                    b.ToTable("VentaMoto");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaAuto", b =>
                {
                    b.HasOne("MVCConcesionaria.Models.Auto", "auto")
                        .WithMany()
                        .HasForeignKey("autoID");

                    b.HasOne("MVCConcesionaria.Models.Persona", "cliente")
                        .WithMany()
                        .HasForeignKey("clientePersonaId");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaCamioneta", b =>
                {
                    b.HasOne("MVCConcesionaria.Models.Camioneta", "camioneta")
                        .WithMany()
                        .HasForeignKey("camionetaID");

                    b.HasOne("MVCConcesionaria.Models.Persona", "cliente")
                        .WithMany()
                        .HasForeignKey("clientePersonaId");
                });

            modelBuilder.Entity("MVCConcesionaria.Models.VentaMoto", b =>
                {
                    b.HasOne("MVCConcesionaria.Models.Persona", "cliente")
                        .WithMany()
                        .HasForeignKey("clientePersonaId");

                    b.HasOne("MVCConcesionaria.Models.Moto", "moto")
                        .WithMany()
                        .HasForeignKey("motoID");
                });
#pragma warning restore 612, 618
        }
    }
}
