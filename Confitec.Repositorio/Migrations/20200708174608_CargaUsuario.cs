using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Confitec.Repositorio.Migrations
{
    public partial class CargaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuario",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Escolariedade",
                table: "Usuario",
                maxLength: 400,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuario",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                table: "Usuario",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolariedade", "Nome", "SobreNome" },
                values: new object[] { 1, new DateTime(2020, 7, 8, 14, 46, 8, 48, DateTimeKind.Local).AddTicks(5642), "rodrigo@rodriguez.com", 1, "A", "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolariedade", "Nome", "SobreNome" },
                values: new object[] { 2, new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4477), "rodrigo@teste.com", 1, "b", "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataNascimento", "Email", "Escolariedade", "Nome", "SobreNome" },
                values: new object[] { 3, new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4596), "rodrigo@asd.com", 1, "v", "Rodrigo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Escolariedade",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "Usuario");
        }
    }
}
