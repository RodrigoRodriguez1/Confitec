using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Confitec.Repositorio.Migrations
{
    public partial class CargaUsuarioS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 47, 54, 131, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 47, 54, 132, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 47, 54, 132, DateTimeKind.Local).AddTicks(1906));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 46, 8, 48, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataNascimento",
                value: new DateTime(2020, 7, 8, 14, 46, 8, 49, DateTimeKind.Local).AddTicks(4596));
        }
    }
}
