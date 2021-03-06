﻿// <auto-generated />
using System;
using Confitec.Repositorio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Confitec.Repositorio.Migrations
{
    [DbContext(typeof(ConfitecContext))]
    [Migration("20200708174608_CargaUsuario")]
    partial class CargaUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Confitec.Dominio.Entidade.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Escolariedade")
                        .HasMaxLength(400);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNascimento = new DateTime(2020, 7, 8, 14, 46, 8, 48, DateTimeKind.Local).AddTicks(5642),
                            Email = "rodrigo@rodriguez.com",
                            Escolariedade = 1,
                            Nome = "A",
                            SobreNome = "Rodrigo"
                        },
                        new
                        {
                            Id = 2,
                            DataNascimento = new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4477),
                            Email = "rodrigo@teste.com",
                            Escolariedade = 1,
                            Nome = "b",
                            SobreNome = "Rodrigo"
                        },
                        new
                        {
                            Id = 3,
                            DataNascimento = new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4596),
                            Email = "rodrigo@asd.com",
                            Escolariedade = 1,
                            Nome = "v",
                            SobreNome = "Rodrigo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
