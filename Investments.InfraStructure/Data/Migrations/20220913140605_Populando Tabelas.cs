using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investments.InfraStructure.Data.Migrations
{
    public partial class PopulandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ativos",
                columns: new[] { "Id", "Nome", "Tipo" },
                values: new object[,]
                {
                    { 1, "CDB 100%", 1 },
                    { 2, "Fundo Imobiliário", 2 },
                    { 3, "Fundo LCI", 2 },
                    { 4, "Fundo Gold", 3 },
                    { 5, "Fundo Platinum", 3 },
                    { 6, "PETR4", 4 },
                    { 7, "BBAS3", 4 },
                    { 8, "Tesouro IPCA+ 2025", 5 },
                    { 9, "Tesouro Pré-Fixado 2027", 5 },
                    { 10, "Caderneta de Poupança", 6 },
                    { 11, "Bitcoin", 7 },
                    { 12, "Ethereum", 7 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataNascimento", "Email", "Nome", "Password", "Tipo" },
                values: new object[] { 1, new DateTime(1994, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@teste.com", "Admin", "36F583DD16F4E1E201EB1E6F6D8E35A2CCB3BBE2658DE46B4FFAE7B0E9ED872E", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
